Public Class FrmPOSADD
    Dim vat_tax As Double
    Private Sub FrmPOSADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtid.Text = ""
        'txtname.Text = ""
        'txtprice.Text = ""
        'txtqty.Text = "0"
        txtqty.Select()
        vat_tax = (100 + VAT) / 100
        'FrmPOSSTOCKSLIST.ShowDialog()
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If txtqty.Text = "" Then txtqty.Text = "0"
        txtqty.Text = str_Filter(txtqty, 48, 57, 0, 0)
        With FrmPOS_CHOICES
            If CDbl(txtqty.Text) > CDbl(txt_QTYi.Text) Then
                If .rbdefect.Checked Then
                    MsgBox("Return quantity should not be greater than current quantity !!" & _
                    Chr(13) & "Return Quantity : " & txtqty.Text & _
                    Chr(13) & "Current Quantity : " & txt_QTYi.Text, MsgBoxStyle.Information, "Sales and Inventory")
                    txtqty.Text = 0
                    txtqty.Focus()
                    txtqty.Select()
                Else
                    MsgBox("Order quantity should not be greater than current quantity !!" & _
                    Chr(13) & "Order Quantity : " & txtqty.Text & _
                    Chr(13) & "Current Quantity : " & txt_QTYi.Text, MsgBoxStyle.Information, "Sales and Inventory")
                    txtqty.Text = 0
                    txtqty.Focus()
                    txtqty.Select()
                End If
            End If
            If CDbl(txtqty.Text) > 0 Then
                cmdsave.Enabled = True
            Else
                cmdsave.Enabled = False
            End If
        End With
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dtl_ID As Integer
        Dim VATable As Double
        Dim TotalAmount As Double
        Dim TotalSale As Double
        Dim Vat12 As Double
        Dim TotalAmount_Due As Double
        Dim tmpSalesID As Integer

        VATable = 0
        TotalAmount = 0
        TotalSale = 0
        Vat12 = 0
        TotalAmount_Due = 0

        With FrmPOS_CHOICES
            If CDbl(txtqty.Text) > 0 Then
                If .rbdefect.Checked Then



                    sqlSTR = "SELECT * FROM TBL_Pending_Item WHERE Pending_ID =" & txtpendingID.Text
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        dtl_ID = sqlDT.Rows(0)("sales_Detail_ID")
                        'FOR ITEM_QTY
                        'sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_Detail_ID =" & dtl_ID & " AND Sales_ID =" & FrmPOSVIEW.txtreceiptid.Text
                        sqlSTR = "SELECT * FROM TBL_Sales_Receipt " & _
                                 "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                                 " WHERE TBL_Sales_Receipt.Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text & _
                                 " AND Sales_Detail_ID =" & dtl_ID
                        ExecuteSQLQuery(sqlSTR)

                        'GET SALES_ID
                        tmpSalesID = sqlDT.Rows(0)("Sales_ID")

                        sqlSTR = "UPDATE TBL_Sales_Sold_Detail " & _
                                 "SET Item_QTY = Item_QTY + " & CDbl(txtqty.Text) & ", " _
                               & "Total_Price = " & CDbl((CDbl(sqlDT.Rows(0)("Item_QTY")) + CDbl(txtqty.Text)) * CDbl(txtprice.Text)) & ", " _
                               & "Item_Name ='" & R_eplace(txtname.Text) & " / " & CDbl(txtqty.Text) & " QTY Return Product(s)" & "', " _
                               & "Added_QTY = Added_QTY + " & CDbl(txtqty.Text) & _
                                 " WHERE Sales_Detail_ID =" & dtl_ID & _
                                 " AND Sales_ID =" & tmpSalesID
                        ExecuteSQLQuery(sqlSTR)

                        'START TO RE-COMPUTE
                        sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & tmpSalesID
                        ExecuteSQLQuery(sqlSTR)
                        If sqlDT.Rows.Count > 0 Then
                            For x = 0 To sqlDT.Rows.Count - 1
                                TotalAmount = TotalAmount + CDbl(sqlDT.Rows(x)("Item_QTY")) * CDbl(sqlDT.Rows(x)("Item_Price"))
                            Next
                        End If

                        VATable = Format(TotalAmount - (TotalAmount - (TotalAmount / vat_tax)), "###,###.00")
                        TotalSale = VATable
                        Vat12 = Format((TotalAmount - (TotalAmount / vat_tax)), "###,###.00")
                        TotalAmount_Due = Format(CDbl(TotalSale) + CDbl(Vat12), "###,###,###.00")

                        'FOR TBL_Sales_Sold
                        sqlSTR = "UPDATE TBL_Sales_Sold " & _
                                 "SET Amount_Due =" & TotalAmount & ", " _
                               & "Amount_Change = Amount_Receive -" & TotalAmount & _
                                 " WHERE Sales_ID =" & tmpSalesID
                        ExecuteSQLQuery(sqlSTR)

                        'FOR TBL_Sales_Receipt
                        sqlSTR = "UPDATE TBL_Sales_Receipt " & _
                                 "SET Vatable =" & VATable & ", " & "Total_Sale =" & TotalSale & ", " & _
                                 "Amount_Due =" & TotalAmount_Due & ", " & "Vat =" & Vat12 & _
                                 "WHERE Sales_ID =" & tmpSalesID
                        ExecuteSQLQuery(sqlSTR)

                        'UPDATE STOCKS
                        sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                                 "SET Item_QTY = Item_QTY - " & CDbl(txtqty.Text) & _
                                 "WHERE Item_ID =" & txtid.Text
                        ExecuteSQLQuery(sqlSTR)
                    End If
                    'Product Return
                    If CDbl(txtqty.Text) = CDbl(txt_QTYi.Text) Then
                        sqlSTR = "UPDATE TBL_Pending_Item SET Returnx= 'Yes'" & ", " & _
                                                              "Return_Date ='" & Format(Now, "MM/dd/yyyy") & "'" & _
                                                              " WHERE Pending_ID =" & txtpendingID.Text
                        ExecuteSQLQuery(sqlSTR)
                        '-----
                        sqlSTR = "UPDATE TBL_Sales_Sold_Detail " & _
                                 "SET Added_QTY = 0 WHERE Sales_Detail_ID =" & dtl_ID & _
                                 " AND Sales_ID =" & tmpSalesID
                        ExecuteSQLQuery(sqlSTR)
                    End If
                    Audit_Trail(xUser_ID, TimeOfDay, "Return defect item to customer")
                ElseIf .rbNew.Checked Then
                    'ADD NEW PRODUCTx
                    sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text
                    ExecuteSQLQuery(sqlSTR)
                    tmpSalesID = sqlDT.Rows(0)("Sales_ID")
                    'GET SALES_ID

                    sqlSTR = "INSERT INTO TBL_Sales_Sold_Detail (Sales_ID, Item_ID, Item_Name, Item_Description, Item_Price, Item_Qty, Total_Price, Added_QTY) " & _
                             "VALUES (" & tmpSalesID & ", " _
                                       & txtid.Text & ", " _
                                       & "'" & R_eplace(txtname.Text) & " [ Added new product ]" & "', " _
                                       & "'" & R_eplace(txtdesc.Text) & "', " _
                                       & CDbl(txtprice.Text) & ", " _
                                       & CDbl(txtqty.Text) & ", " _
                                       & CDbl(txtprice.Text) * CDbl(txtqty.Text) & ", " _
                                       & 0 & ")"
                    ExecuteSQLQuery(sqlSTR)

                    'START TO RE-COMPUTE
                    sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & tmpSalesID
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        For x = 0 To sqlDT.Rows.Count - 1
                            TotalAmount = TotalAmount + CDbl(sqlDT.Rows(x)("Item_QTY")) * CDbl(sqlDT.Rows(x)("Item_Price"))
                        Next
                    End If

                    VATable = Format(TotalAmount - (TotalAmount - (TotalAmount / vat_tax)), "###,###.00")
                    TotalSale = VATable
                    Vat12 = Format((TotalAmount - (TotalAmount / vat_tax)), "###,###.00")
                    TotalAmount_Due = Format(CDbl(TotalSale) + CDbl(Vat12), "###,###,###.00")

                    'FOR TBL_Sales_Sold
                    sqlSTR = "UPDATE TBL_Sales_Sold " & _
                             "SET Amount_Due =" & TotalAmount & ", " _
                           & "Amount_Change = Amount_Receive -" & TotalAmount & _
                             " WHERE Sales_ID =" & tmpSalesID
                    ExecuteSQLQuery(sqlSTR)

                    'FOR TBL_Sales_Receipt
                    sqlSTR = "UPDATE TBL_Sales_Receipt " & _
                             "SET Vatable =" & VATable & ", " & "Total_Sale =" & TotalSale & ", " & _
                             "Amount_Due =" & TotalAmount_Due & ", " & "Vat =" & Vat12 & _
                             "WHERE Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text
                    ExecuteSQLQuery(sqlSTR)

                    'UPDATE STOCKS
                    sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                             "SET Item_QTY = Item_QTY - " & CDbl(txtqty.Text) & _
                             "WHERE Item_ID =" & txtid.Text
                    ExecuteSQLQuery(sqlSTR)

                    Audit_Trail(xUser_ID, TimeOfDay, "Add New Stocks to Customer")
                End If
            End If

        End With
        
        Me.Close()
    End Sub
End Class