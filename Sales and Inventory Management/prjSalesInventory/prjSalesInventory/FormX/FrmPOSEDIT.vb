Public Class FrmPOSEDIT
    Dim vat_tax As Double
    Private Sub FrmPOSEDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FrmPOSSTOCKSLIST.ShowDialog()
        ' txtid.Text = ""
        ' txtname.Text = ""
        ' txtprice.Text = ""
        ' txtqty.Text = "0"
        txtreturn.Text = "0"
        txtreturn.Select()
        vat_tax = (100 + VAT) / 100
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim tmp_Name As String
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

        If txtid.Text = "" Or txtname.Text = "" Then
            MsgBox("Cannot save this without details !!", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If

        If CDbl(txtreturn.Text) > CDbl(txtqty.Text) Then
            MsgBox("Return Quantity Should Not Greater Than Current Quantity !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If txtreturn.Text = "0" Or CDbl(txtreturn.Text) = 0 Then
            MsgBox("Can't continue with zero quantity !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If txtreturn.Text <> "0" Or CDbl(txtreturn.Text) <> 0 Then
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & txtid.Text
            ExecuteSQLQuery(sqlSTR)
            tmp_Name = sqlDT.Rows(0)("Item_Name")

            Select Case MsgBox("Would you like previous item as pending defective ???", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Sales and Inventory")
                Case MsgBoxResult.Yes
                    sqlSTR = "INSERT INTO TBL_Pending_Item (Item_ID, Pending_Date, User_ID, Item_QTY, Returnx, Receipt_ID, Sales_Detail_ID) " & _
                         "VALUES (" & Label4.Text & ", " _
                              & "'" & Format(Now, "MM/dd/yyyy") & "', " _
                                    & xUser_ID & ", " _
                                    & CDbl(txtreturn.Text) & ", " _
                                    & "'" & "No" & "', " _
                                    & FrmPOSVIEW.txtreceiptid.Text & ", " _
                                    & Label6.Text & ")"
                    ExecuteSQLQuery(sqlSTR)
                    'MARK AS / [#] DEFECTIVE

                    'GET THE SALES_ID
                    sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text
                    ExecuteSQLQuery(sqlSTR)

                    tmpSalesID = sqlDT.Rows(0)("Sales_ID")
                    sqlSTR = "UPDATE TBL_Sales_Sold_Detail " & _
                             "SET Item_QTY =" & CDbl(txtqty.Text) - CDbl(txtreturn.Text) & ", " _
                           & "Total_Price =" & (CDbl(txtqty.Text) - CDbl(txtreturn.Text)) * CDbl(txtprice.Text) & ", " _
                           & "Item_Name = '" & R_eplace(tmp_Name) & " - " & CDbl(txtreturn.Text) & " QTY Defective Product(s)" & "'" & _
                             " WHERE Sales_Detail_ID =" & Label6.Text & _
                             " AND Sales_ID =" & tmpSalesID
                    ExecuteSQLQuery(sqlSTR)

                    Audit_Trail(xUser_ID, TimeOfDay, "Return Product(s) to Pending Item as Defective Stocks")
                Case MsgBoxResult.No
                    sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text
                    ExecuteSQLQuery(sqlSTR)

                    tmpSalesID = sqlDT.Rows(0)("Sales_ID")

                    sqlSTR = "UPDATE TBL_Sales_Sold_Detail " & _
                             "SET Item_QTY =" & CDbl(txtqty.Text) - CDbl(txtreturn.Text) & ", " _
                           & "Total_Price =" & (CDbl(txtqty.Text) - CDbl(txtreturn.Text)) * CDbl(txtprice.Text) & ", " _
                           & "Item_Name ='" & R_eplace(tmp_Name) & " - " & CDbl(txtreturn.Text) & " QTY Return Product(s)" & "'" & _
                             " WHERE Sales_Detail_ID =" & Label6.Text & _
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
                    Audit_Trail(xUser_ID, TimeOfDay, "Return Product(s) Request by Client")
                Case MsgBoxResult.Cancel
                    Exit Sub
            End Select
            'RETURN TO STOCKS
            ' MsgBox("here")
            sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                     "SET Item_QTY = Item_QTY + " & CDbl(txtreturn.Text) & _
                     "WHERE Item_ID =" & txtid.Text
            ExecuteSQLQuery(sqlSTR)

        End If



        With FrmPOSVIEW
            .lstitems.FocusedItem.SubItems(1).Text = CDbl(txtqty.Text) - CDbl(txtreturn.Text)
        End With
        Me.Close()
    End Sub

    Private Sub txtreturn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreturn.TextChanged
        If txtreturn.Text = "" Then txtreturn.Text = "0"
        txtreturn.Text = str_Filter(txtreturn, 48, 57, 0, 0)
    End Sub
End Class