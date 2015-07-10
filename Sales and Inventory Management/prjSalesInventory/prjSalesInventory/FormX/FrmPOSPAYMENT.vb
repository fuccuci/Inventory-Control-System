Public Class FrmPOSPAYMENT
    Dim timx As Integer
    Dim xSales_ID As Integer
    Private mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


    Private Sub txtcashreceive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcashreceive.TextChanged
        txtcashreceive.Text = str_Filter(txtcashreceive, 48, 57, 46, 1)
        'If txtcashreceive.Text = "" Then txtcashreceive.Text = "0"
        'txtcashchange.Text = Format(CDbl(txtcashreceive.Text) - CDbl(lblamountdue.Text), "###,###.00")

        If txtcashreceive.Text = "" Then
            txtcashchange.Text = Format(0 - CDbl(lblamountdue.Text), "###,###.00")
        Else
            txtcashchange.Text = Format(CDbl(txtcashreceive.Text) - CDbl(lblamountdue.Text), "###,###.00")
        End If
    End Sub

    Private Sub FrmPOSPAYMENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim i As Integer
        txtcashchange.Text = "0.00"
        txtcashreceive.Text = ""
        timx = 0
        'For i = 0 To UBound(xid)
        'MsgBox(UBound()
        'MsgBox(xid(i))
        'Next
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim i As Integer
        Dim SQLStrx(0) As String
        With FrmPOSCASHIER
            If Int(txtcashchange.Text) < 0 Then
                MsgBox("Insufficient Cash Amount Receive !!", MsgBoxStyle.Critical, "Sales and Inventory")
                txtcashreceive.Focus()
                txtcashreceive.Select()
                Exit Sub
            End If
            If .lstItems.Items.Count > 0 Then
                If .cmbSelectType.SelectedIndex = 0 Then
                    sqlSTR = "SELECT *, * " & _
                             "FROM TBL_Sales_Receipt " & _
                             "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                             "WHERE TBL_Sales_Receipt.Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                             "AND Order_No =" & .txtbarcode.Text

                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        xSales_ID = sqlDT.Rows(0)("Sales_ID")
                        For i = 0 To sqlDT.Rows.Count - 1
                            'MsgBox(sqlDT.Rows(i)("Item_ID"))
                            ReDim Preserve SQLStrx(i)
                            SQLStrx(i) = "UPDATE TBL_Stocks_Balances SET Item_QTY = Item_QTY - " & sqlDT.Rows(i)("Item_QTY") & _
                                          " WHERE Item_ID = " & sqlDT.Rows(i)("Item_ID")

                        Next
                        For i = 0 To UBound(SQLStrx)
                            ExecuteSQLQuery(SQLStrx(i))
                        Next
                        ''Exit Sub
                        sqlSTR = "DELETE FROM TBL_Sales_Receipt WHERE Order_No =" & .txtbarcode.Text
                        ExecuteSQLQuery(sqlSTR)
                        sqlSTR = "DELETE FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & xSales_ID
                        ExecuteSQLQuery(sqlSTR)
                        sqlSTR = "DELETE FROM TBL_Sales_Sold WHERE Sales_ID =" & xSales_ID
                        ExecuteSQLQuery(sqlSTR)
                    Else
                        For i = 0 To FrmPOSCASHIER.lstItems.Items.Count - 1
                            ReDim Preserve SQLStrx(i)
                            SQLStrx(i) = "UPDATE TBL_Stocks_Balances SET Item_QTY = Item_QTY  - " & FrmPOSCASHIER.lstItems.Items(i).SubItems(4).Text & _
                                          " WHERE Item_ID = " & FrmPOSCASHIER.lstItems.Items(i).Text
                        Next
                        For i = 0 To UBound(SQLStrx)
                            ExecuteSQLQuery(SQLStrx(i))
                        Next
                    End If
                End If
                sqlSTR = "INSERT INTO TBL_Sales_Sold (Sales_Date, Amount_Due, Amount_Receive, Amount_Change, Order_No) " & _
                         "VALUES ('" & .lbldate.Text & "', " _
                                     & CDbl(lblamountdue.Text) & ", " _
                                     & CDbl(txtcashreceive.Text) & ", " _
                                     & IIf(CDbl(txtcashchange.Text) > 0, CDbl(txtcashchange.Text), 0) & ", " _
                                     & IIf(.cmbSelectType.SelectedIndex = 0, .txtbarcode.Text, 0) & ")"

                'add to tbl_sales_sold_Detail
                ExecuteSQLQuery(sqlSTR)
                sqlSTR = "SELECT * FROM TBL_Sales_Sold ORDER BY Sales_ID DESC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    'pass id
                    xSales_ID = sqlDT.Rows(0)("Sales_ID")
                    ' MsgBox(xSales_ID)
                End If
                For i = 0 To FrmPOSCASHIER.lstItems.Items.Count - 1
                    sqlSTR = "INSERT INTO TBL_Sales_Sold_Detail (Sales_ID, Item_ID, Item_Name, Item_Description, Item_Price, Item_Qty, Total_Price, Added_QTY) " & _
                            "VALUES (" & xSales_ID & ", " _
                                       & .lstItems.Items(i).Text & ", " _
                                       & "'" & R_eplace(.lstItems.Items(i).SubItems(1).Text) & "', " _
                                       & "'" & R_eplace(.lstItems.Items(i).SubItems(2).Text) & "', " _
                                       & CDbl(.lstItems.Items(i).SubItems(3).Text) & ", " _
                                       & .lstItems.Items(i).SubItems(4).Text & ", " _
                                       & CDbl(.lstItems.Items(i).SubItems(3).Text) * CDbl(.lstItems.Items(i).SubItems(4).Text) & ", " _
                                       & 0 & ")"
                    ExecuteSQLQuery(sqlSTR)

                    'UPDATE STOCKS
                    If .cmbSelectType.SelectedIndex <> 0 Then
                        sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_QTY =" & " Item_QTY - " & .lstItems.Items(i).SubItems(4).Text & " WHERE Item_ID = " & .lstItems.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                    End If
                Next
                'Create Receipt
                sqlSTR = "INSERT INTO TBL_Sales_Receipt " & _
                         "(Sales_ID, VATable, VAT_Exempt_Sale, " & _
                         "Total_Sale, Amount_Due, Receipt_Date, VAT, " & _
                         "Void, User_ID, Order_No) " & _
                         "VALUES (" & xSales_ID & ", " _
                                       & CDbl(.txtvatable.Text) & ", " _
                                       & CDbl(.txtvatexempt.Text) & ", " _
                                       & CDbl(.txttotalsale.Text) & ", " _
                                       & CDbl(.txtamountdue.Text) & ", " _
                                       & "'" & .lbldate.Text & "', " _
                                       & CDbl(.txtvat12.Text) & ", " _
                                       & "'" & "No" & "', " _
                                       & xUser_ID & ", " _
                                       & IIf(.cmbSelectType.SelectedIndex = 0, .txtbarcode.Text, 0) & ")"
                ExecuteSQLQuery(sqlSTR)
            Else
                MsgBox("No item in the list !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            Audit_Trail(xUser_ID, TimeOfDay, "Print New Sales Receipt Receipt No : " & xSales_ID)
            MsgBox("Purchase Success !!", MsgBoxStyle.Information, "Sales and Inventory")
            Timer1.Enabled = True
            'IIf(.cmbSelectType.SelectedIndex = 0, .txtbarcode.Text = "0", .txtbarcode.Text = "")
            '.lblbarcode.Text = ""
            If .cmbSelectType.SelectedIndex = 0 Then
                .txtbarcode.Text = "0"
            Else
                .txtbarcode.Text = ""
            End If
            .lbltotalamount.Text = ""
            .txttotalsale.Text = ""
            .txtvat12.Text = ""
            .txtvatable.Text = ""
            .txtvatexempt.Text = "0.00"
            .txtamountdue.Text = "0"
            '.txtDiscount.Text = "0"
            '.txttotalamountdue.Text = "0"
            .lstItems.Items.Clear()
            'check critical product

            With MDIMain
                If UCase(xUser_Access) = UCase("administrator") Or UCase(xUser_Access) = UCase("Sales Agent") Or UCase(xUser_Access) = UCase("Stock Room") Then
                    sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                             "FROM TBL_Category_Item_File INNER JOIN " & _
                             "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                             "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows.Count > 0 Then
                        MsgBox("A Product(s) reach its critical level !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                        .tmrcritical.Enabled = True
                        With FrmPOSCASHIER
                            .Timer1.Enabled = True
                        End With
                    Else
                        .tmrcritical.Enabled = False
                        .cmdProductReorder.ForeColor = Color.Black
                        With FrmPOSCASHIER
                            .Timer1.Enabled = False
                            .lblreach.Visible = False
                        End With
                    End If
                Else
                    .cmdProductReorder.ForeColor = Color.Black
                    sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                             "FROM TBL_Category_Item_File INNER JOIN " & _
                             "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                             "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                    ExecuteSQLQuery(sqlSTR)
                    With FrmPOSCASHIER
                        If sqlDT.Rows.Count > 0 Then

                            .Timer1.Enabled = True

                        Else
                            .Timer1.Enabled = False
                            .lblreach.Visible = False

                        End If
                    End With
                End If
            End With
            Me.Close()
        End With
        xpass = False
        howx = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Report As New FrmREPORTS
        timx = timx + 1
        If timx >= 4 Then
            ' Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & xSales_ID & _
            '             "SELECT * FROM TBL_Globaldata"
            Timer1.Enabled = False
            Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & xSales_ID
            'MsgBox(Rpt_SqlStr)
            globalFRM = "frmPOSPAYMENT"
            Report.Show()
            'FrmREPORTS.Show()
            '--
            'mReport.Load(Application.StartupPath & "\ReportX\Receipt_Rpt.rpt")
            'mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
            'mReport.PrintToPrinter(1, True, 1, 1)


        End If
    End Sub

    Private Sub txtcashchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcashchange.TextChanged

    End Sub
End Class