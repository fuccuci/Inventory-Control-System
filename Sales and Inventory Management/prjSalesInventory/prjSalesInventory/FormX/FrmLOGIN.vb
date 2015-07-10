Public Class FrmLOGIN
    Dim xuserid As Integer
    Dim xcountx As Integer
    Dim ix As Double

    Private Sub FrmLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim i As Integer
        ' For i = 0 To 100
        ' Me.Opacity = Me.Opacity + 1
        ' Application.DoEvents()
        ' Next
        'FILLComboBox ("SELECT  FROM TBL_U
        xcountx = 0
        xlock = False
        username = ""
        xuserid = xUser_ID
        xUser_ID = 0
        txtuser.Text = ""
        txtpassword.Text = ""
        txtuser.Select()
        If Not checkServer() Then
            xUser_ID = 1
            'Me.Close()
            FrmSERVERSETTINGS.ShowDialog()
        End If
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        On Error Resume Next
        Dim timex As String
        'If e.KeyCode = 13 Then
        If Not checkServer() Then
            FrmSERVERSETTINGS.ShowDialog()
            Exit Sub
        End If
        sqlSTR = "SELECT * FROM TBL_Users WHERE Username='" & R_eplace(txtuser.Text) & "' AND userpass ='" & R_eplace(txtpassword.Text) & "'"

        'MsgBox(sqlSTR)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            'MDIMain.Show()
            For i = 0 To sqlDT.Rows.Count - 1
                If sqlDT.Rows(i)("username") <> txtuser.Text Or sqlDT.Rows(i)("userpass") <> txtpassword.Text Then
                    MsgBox("Access denied username and password !!!", MsgBoxStyle.Information, "Sales and Inventory")
                    xcountx = xcountx + 1
                    If xcountx >= 3 Then
                        MsgBox("You have reach the maximum time of login !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                        End
                    End If
                    Exit Sub
                End If
            Next
            'xuserid = xUser_ID

            username = sqlDT.Rows(0)("Username")
            xUser_ID = sqlDT.Rows(0)("User_id")
            xUser_Access = sqlDT.Rows(0)("Access_Type")

            timex = TimeOfDay

            _USER.Value = sqlDT.Rows(0)("lastname") & ", " & sqlDT.Rows(0)("firstname") & " " & sqlDT.Rows(0)("middlename")

            sqlSTR = "INSERT INTO TBL_Audit_Log (User_ID, LOGIN) VALUES(" & xUser_ID & ", '" & timex & "')"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "SELECT * FROM TBL_Audit_Log ORDER BY LOG_ID DESC"
            ExecuteSQLQuery(sqlSTR)

            LOGID = sqlDT.Rows(0)("LOG_ID")

            Audit_Trail(xUser_ID, TimeOfDay, "Login to system ")
            With MDIMain
                If UCase(xUser_Access) = UCase("administrator") Or UCase(xUser_Access) = UCase("Sales Agent") Or UCase(xUser_Access) = UCase("Stock Room") Then
                    sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                             "FROM TBL_Category_Item_File INNER JOIN " & _
                             "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                             "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows.Count > 0 Then
                        MsgBox("A Product(s) reach its critical level !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                        .tmrcritical.Enabled = True
                    Else
                        .tmrcritical.Enabled = False
                    End If

                Else
                    .cmdProductReorder.ForeColor = Color.Black
                End If
            End With

            If xuserid <> 0 Then
                If xuserid <> xUser_ID Then
                    Dim oFrm As Form
                    For Each oFrm In MDIMain.MdiChildren
                        'MsgBox(oFrm.Name)
                        If oFrm.Name <> "FrmBG" And Not _
                                 (TypeOf oFrm Is MDIMain) And Not (TypeOf oFrm Is FrmBG) Then
                            FormClose(oFrm)
                            oFrm.Close()
                        End If
                    Next
                End If
                'just to make sure check
                For i = 0 To MDIMain.lstShortCut.Items.Count - 1
                    MDIMain.lstShortCut.Items(i).Remove()
                Next
            End If

            With MDIMain
                ' .tslabellog.Text = username
                .lblUser.Text = username
                .lbltoday.Text = Today
                .aget()
                .pnadvisory_Admin.Left = .Width - 100
                .pnAdvisory_Stock.Left = .Width - 100
                .pnAdvisory_Cashier.Left = .Width - 100
                .pnAdvisory_SalesAgent.Left = .Width - 100
                .Timer1.Enabled = True
                If UCase(xUser_Access) = UCase("Administrator") Then
                    .SystemFileToolStripMenuItem.Enabled = True
                    'Inventory File
                    .MasterFileToolStripMenuItem.Enabled = True
                    .SetCategoryFileToolStripMenuItem.Enabled = True
                    .SetItemFileToolStripMenuItem.Enabled = True
                    .SuppliersToolStripMenuItem.Enabled = True
                    .SuppliersProductToolStripMenuItem.Enabled = True
                    .ProductsReorderPointToolStripMenuItem.Enabled = True
                    .StockOrderToolStripMenuItem.Enabled = True
                    .StockMonitoringToolStripMenuItem.Enabled = True
                    .BarcodeFormToolStripMenuItem.Enabled = True
                    .UnitMeasureToolStripMenuItem.Enabled = True
                    .BusinessInformationToolStripMenuItem.Enabled = True
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem.Enabled = True
                    .CashieringToolStripMenuItem.Enabled = True
                    .SalesReceiptToolStripMenuItem.Enabled = True
                    'manage users
                    .UserInformationFileToolStripMenuItem.Enabled = True
                    'USERS LOG
                    .AuditTrailToolStripMenuItem.Enabled = True
                    'REPORTS
                    .ReportsToolStripMenuItem.Enabled = True
                    .SupplierProfileToolStripMenuItem.Enabled = True
                    .SupplierProductsToolStripMenuItem.Enabled = True
                    .ProductsReorderPointToolStripMenuItem1.Enabled = True
                    .PurchaseOrderToolStripMenuItem.Enabled = True
                    .PurchaseReceiveToolStripMenuItem.Enabled = True
                    .StockBalancesToolStripMenuItem.Enabled = True
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem1.Enabled = True
                    .SalesCollectionToolStripMenuItem.Enabled = True
                    .SalesCollectionReportVOIDToolStripMenuItem.Enabled = True
                    .CollectionSummaryReportToolStripMenuItem.Enabled = True
                    .SalesReceiptToolStripMenuItem1.Enabled = True
                    .ProductPacingReportToolStripMenuItem.Enabled = True

                ElseIf UCase(xUser_Access) = UCase("Cashier") Then
                    .SystemFileToolStripMenuItem.Enabled = True
                    'Inventory File
                    .MasterFileToolStripMenuItem.Enabled = False
                    .SetCategoryFileToolStripMenuItem.Enabled = False
                    .SetItemFileToolStripMenuItem.Enabled = False
                    .SuppliersToolStripMenuItem.Enabled = False
                    .SuppliersProductToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem.Enabled = False
                    .StockOrderToolStripMenuItem.Enabled = False
                    .StockMonitoringToolStripMenuItem.Enabled = False
                    .BarcodeFormToolStripMenuItem.Enabled = False
                    .UnitMeasureToolStripMenuItem.Enabled = False
                    .BusinessInformationToolStripMenuItem.Enabled = False
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem.Enabled = True
                    .CashieringToolStripMenuItem.Enabled = True
                    .SalesReceiptToolStripMenuItem.Enabled = True
                    'manage users
                    .UserInformationFileToolStripMenuItem.Enabled = False
                    'USERS LOG
                    .AuditTrailToolStripMenuItem.Enabled = False
                    'REPORTS
                    .ReportsToolStripMenuItem.Enabled = False
                    .SupplierProfileToolStripMenuItem.Enabled = False
                    .SupplierProductsToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem1.Enabled = False
                    .PurchaseOrderToolStripMenuItem.Enabled = False
                    .PurchaseReceiveToolStripMenuItem.Enabled = False
                    .StockBalancesToolStripMenuItem.Enabled = False
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem1.Enabled = False
                    .SalesCollectionToolStripMenuItem.Enabled = False
                    .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                    .CollectionSummaryReportToolStripMenuItem.Enabled = False
                    .SalesReceiptToolStripMenuItem1.Enabled = False
                    .ProductPacingReportToolStripMenuItem.Enabled = False

                ElseIf UCase(xUser_Access) = UCase("Stock Room") Then
                    .SystemFileToolStripMenuItem.Enabled = True
                    'Inventory File
                    .MasterFileToolStripMenuItem.Enabled = True
                    .SetCategoryFileToolStripMenuItem.Enabled = False
                    .SetItemFileToolStripMenuItem.Enabled = False
                    .SuppliersToolStripMenuItem.Enabled = False
                    .SuppliersProductToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem.Enabled = True
                    .StockOrderToolStripMenuItem.Enabled = True
                    .StockMonitoringToolStripMenuItem.Enabled = True
                    .BarcodeFormToolStripMenuItem.Enabled = False
                    .UnitMeasureToolStripMenuItem.Enabled = False
                    .BusinessInformationToolStripMenuItem.Enabled = False
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem.Enabled = False
                    .CashieringToolStripMenuItem.Enabled = False
                    .SalesReceiptToolStripMenuItem.Enabled = False
                    'manage users
                    .UserInformationFileToolStripMenuItem.Enabled = False
                    'USERS LOG
                    .AuditTrailToolStripMenuItem.Enabled = False
                    'REPORTS
                    .ReportsToolStripMenuItem.Enabled = True
                    .SupplierProfileToolStripMenuItem.Enabled = False
                    .SupplierProductsToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem1.Enabled = True
                    .PurchaseOrderToolStripMenuItem.Enabled = True
                    .PurchaseReceiveToolStripMenuItem.Enabled = True
                    .StockBalancesToolStripMenuItem.Enabled = True
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem1.Enabled = False
                    .SalesCollectionToolStripMenuItem.Enabled = False
                    .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                    .CollectionSummaryReportToolStripMenuItem.Enabled = False
                    .SalesReceiptToolStripMenuItem1.Enabled = False
                    .ProductPacingReportToolStripMenuItem.Enabled = False
                ElseIf UCase(xUser_Access) = UCase("Sales Agent") Then
                    .SystemFileToolStripMenuItem.Enabled = True
                    'Inventory File
                    .MasterFileToolStripMenuItem.Enabled = True
                    .SetCategoryFileToolStripMenuItem.Enabled = True
                    .SetItemFileToolStripMenuItem.Enabled = True
                    .SuppliersToolStripMenuItem.Enabled = False
                    .SuppliersProductToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem.Enabled = True
                    .StockOrderToolStripMenuItem.Enabled = True
                    .StockMonitoringToolStripMenuItem.Enabled = True
                    .BarcodeFormToolStripMenuItem.Enabled = True
                    .UnitMeasureToolStripMenuItem.Enabled = True
                    .BusinessInformationToolStripMenuItem.Enabled = False
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem.Enabled = False
                    .CashieringToolStripMenuItem.Enabled = False
                    .SalesReceiptToolStripMenuItem.Enabled = False
                    'manage users
                    .UserInformationFileToolStripMenuItem.Enabled = False
                    'USERS LOG
                    .AuditTrailToolStripMenuItem.Enabled = False
                    'REPORTS
                    .ReportsToolStripMenuItem.Enabled = True
                    .SupplierProfileToolStripMenuItem.Enabled = False
                    .SupplierProductsToolStripMenuItem.Enabled = False
                    .ProductsReorderPointToolStripMenuItem1.Enabled = True
                    .PurchaseOrderToolStripMenuItem.Enabled = True
                    .PurchaseReceiveToolStripMenuItem.Enabled = True
                    .StockBalancesToolStripMenuItem.Enabled = True
                    'POINT OF PAYMENTS
                    .PointOfPaymentToolStripMenuItem1.Enabled = False
                    .SalesCollectionToolStripMenuItem.Enabled = False
                    .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                    .CollectionSummaryReportToolStripMenuItem.Enabled = False
                    .SalesReceiptToolStripMenuItem1.Enabled = False
                    .ProductPacingReportToolStripMenuItem.Enabled = False
                End If
            End With
            Me.Close()
        Else
            xcountx = xcountx + 1
            If xcountx >= 3 Then
                MsgBox("You have reach the maximum time of login !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                End
            End If
            MsgBox("Access denied !!!", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        ' End If
    End Sub

    Private Sub cmbtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbtype.KeyDown
        On Error Resume Next
        Dim timex As String
        If e.KeyCode = 13 Then
            If Not checkServer() Then
                FrmSERVERSETTINGS.ShowDialog()
                Exit Sub
            End If
            sqlSTR = "SELECT * FROM TBL_Users WHERE Username='" & R_eplace(txtuser.Text) & "' AND userpass ='" & R_eplace(txtpassword.Text) & "' AND Access_Type ='" & cmbtype.Text & "'"
            'MsgBox(sqlSTR)

            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                'MDIMain.Show()
                FrmPOSCASHIER.Close()
                For i = 0 To sqlDT.Rows.Count - 1
                    If sqlDT.Rows(i)("username") <> txtuser.Text Or sqlDT.Rows(i)("userpass") <> txtpassword.Text Then
                        MsgBox("Access denied username or password !!!", MsgBoxStyle.Information, "Sales and Inventory")
                        If xcountx >= 3 Then
                            End
                        End If
                        xcountx = xcountx + 1
                        Exit Sub
                    End If
                Next

                username = sqlDT.Rows(0)("Username")
                xUser_ID = sqlDT.Rows(0)("User_id")
                xUser_Access = sqlDT.Rows(0)("Access_Type")
                timex = TimeOfDay
                _USER.Value = sqlDT.Rows(0)("lastname") & ", " & sqlDT.Rows(0)("firstname") & " " & sqlDT.Rows(0)("middlename")
                sqlSTR = "INSERT INTO TBL_Audit_Log (User_ID, LOGIN) VALUES(" & xUser_ID & ", '" & timex & "')"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT * FROM TBL_Audit_Log ORDER BY LOG_ID DESC"
                ExecuteSQLQuery(sqlSTR)

                LOGID = sqlDT.Rows(0)("LOG_ID")

                Audit_Trail(xUser_ID, timex, "Login to system ")
                With MDIMain
                    If UCase(xUser_Access) = UCase("administrator") Or UCase(xUser_Access) = UCase("Sales Agent") Or UCase(xUser_Access) = UCase("Stock Room") Then
                        sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                                 "FROM TBL_Category_Item_File INNER JOIN " & _
                                 "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                                 "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                        ExecuteSQLQuery(sqlSTR)

                        If sqlDT.Rows.Count > 0 Then
                            MsgBox("A Product(s) reach its critical level !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                            .tmrcritical.Enabled = True
                        Else
                            .tmrcritical.Enabled = False
                        End If
                    Else
                        .cmdProductReorder.ForeColor = Color.Black
                    End If
                End With

                'MsgBox(xuserid & " " & xUser_ID)
                If xuserid <> 0 Then
                    If xuserid <> xUser_ID Then
                        Dim oFrm As Form
                        For Each oFrm In MDIMain.MdiChildren
                            If oFrm.Name <> "FrmBG" And Not _
                                     (TypeOf oFrm Is MDIMain) And Not (TypeOf oFrm Is FrmBG) Then

                                FormClose(oFrm)
                                oFrm.Close()
                            End If
                        Next
                        'just to make sure check
                        For i = 0 To MDIMain.lstShortCut.Items.Count - 1
                            MDIMain.lstShortCut.Items(i).Remove()
                        Next
                    End If
                End If


                With MDIMain
                    ' .tslabellog.Text = username
                    .lblUser.Text = username
                    .lbltoday.Text = Today
                    .aget()
                    .pnadvisory_Admin.Left = .Width - 100
                    '.pnadvisory_Admin.Top = .PanelHoldAdvisory.Top
                    .pnAdvisory_Stock.Left = .Width - 100
                    .pnAdvisory_Cashier.Left = .Width - 100
                    .pnAdvisory_SalesAgent.Left = .Width - 100
                    .Timer1.Enabled = True
                    If UCase(xUser_Access) = UCase("Administrator") Then
                        .SystemFileToolStripMenuItem.Enabled = True
                        'Inventory File
                        .MasterFileToolStripMenuItem.Enabled = True
                        .SetCategoryFileToolStripMenuItem.Enabled = True
                        .SetItemFileToolStripMenuItem.Enabled = True
                        .SuppliersToolStripMenuItem.Enabled = True
                        .SuppliersProductToolStripMenuItem.Enabled = True
                        .ProductsReorderPointToolStripMenuItem.Enabled = True
                        .StockOrderToolStripMenuItem.Enabled = True
                        .StockMonitoringToolStripMenuItem.Enabled = True
                        .BarcodeFormToolStripMenuItem.Enabled = True
                        .UnitMeasureToolStripMenuItem.Enabled = True
                        .BusinessInformationToolStripMenuItem.Enabled = True
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem.Enabled = True
                        .CashieringToolStripMenuItem.Enabled = True
                        .SalesReceiptToolStripMenuItem.Enabled = True
                        'manage users
                        .UserInformationFileToolStripMenuItem.Enabled = True
                        'USERS LOG
                        .AuditTrailToolStripMenuItem.Enabled = True
                        'REPORTS
                        .ReportsToolStripMenuItem.Enabled = True
                        .SupplierProfileToolStripMenuItem.Enabled = True
                        .SupplierProductsToolStripMenuItem.Enabled = True
                        .ProductsReorderPointToolStripMenuItem1.Enabled = True
                        .PurchaseOrderToolStripMenuItem.Enabled = True
                        .PurchaseReceiveToolStripMenuItem.Enabled = True
                        .StockBalancesToolStripMenuItem.Enabled = True
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem1.Enabled = True
                        .SalesCollectionToolStripMenuItem.Enabled = True
                        .SalesCollectionReportVOIDToolStripMenuItem.Enabled = True
                        .CollectionSummaryReportToolStripMenuItem.Enabled = True
                        .SalesReceiptToolStripMenuItem1.Enabled = True
                        .ProductPacingReportToolStripMenuItem.Enabled = True

                    ElseIf UCase(xUser_Access) = UCase("Cashier") Then
                        .SystemFileToolStripMenuItem.Enabled = True
                        'Inventory File
                        .MasterFileToolStripMenuItem.Enabled = False
                        .SetCategoryFileToolStripMenuItem.Enabled = False
                        .SetItemFileToolStripMenuItem.Enabled = False
                        .SuppliersToolStripMenuItem.Enabled = False
                        .SuppliersProductToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem.Enabled = False
                        .StockOrderToolStripMenuItem.Enabled = False
                        .StockMonitoringToolStripMenuItem.Enabled = False
                        .BarcodeFormToolStripMenuItem.Enabled = False
                        .UnitMeasureToolStripMenuItem.Enabled = False
                        .BusinessInformationToolStripMenuItem.Enabled = False
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem.Enabled = True
                        .CashieringToolStripMenuItem.Enabled = True
                        .SalesReceiptToolStripMenuItem.Enabled = True
                        'manage users
                        .UserInformationFileToolStripMenuItem.Enabled = True
                        'USERS LOG
                        .AuditTrailToolStripMenuItem.Enabled = False
                        'REPORTS
                        .ReportsToolStripMenuItem.Enabled = False
                        .SupplierProfileToolStripMenuItem.Enabled = False
                        .SupplierProductsToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem1.Enabled = False
                        .PurchaseOrderToolStripMenuItem.Enabled = False
                        .PurchaseReceiveToolStripMenuItem.Enabled = False
                        .StockBalancesToolStripMenuItem.Enabled = False
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem1.Enabled = False
                        .SalesCollectionToolStripMenuItem.Enabled = False
                        .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                        .CollectionSummaryReportToolStripMenuItem.Enabled = False
                        .SalesReceiptToolStripMenuItem1.Enabled = False
                        .ProductPacingReportToolStripMenuItem.Enabled = False

                    ElseIf UCase(xUser_Access) = UCase("Stock Room") Then
                        .SystemFileToolStripMenuItem.Enabled = True
                        'Inventory File
                        .MasterFileToolStripMenuItem.Enabled = True
                        .SetCategoryFileToolStripMenuItem.Enabled = False
                        .SetItemFileToolStripMenuItem.Enabled = False
                        .SuppliersToolStripMenuItem.Enabled = False
                        .SuppliersProductToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem.Enabled = True
                        .StockOrderToolStripMenuItem.Enabled = True
                        .StockMonitoringToolStripMenuItem.Enabled = True
                        .BarcodeFormToolStripMenuItem.Enabled = False
                        .UnitMeasureToolStripMenuItem.Enabled = False
                        .BusinessInformationToolStripMenuItem.Enabled = False
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem.Enabled = False
                        .CashieringToolStripMenuItem.Enabled = False
                        .SalesReceiptToolStripMenuItem.Enabled = False
                        'manage users
                        .UserInformationFileToolStripMenuItem.Enabled = True
                        'USERS LOG
                        .AuditTrailToolStripMenuItem.Enabled = False
                        'REPORTS
                        .ReportsToolStripMenuItem.Enabled = True
                        .SupplierProfileToolStripMenuItem.Enabled = False
                        .SupplierProductsToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem1.Enabled = True
                        .PurchaseOrderToolStripMenuItem.Enabled = True
                        .PurchaseReceiveToolStripMenuItem.Enabled = True
                        .StockBalancesToolStripMenuItem.Enabled = True
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem1.Enabled = False
                        .SalesCollectionToolStripMenuItem.Enabled = False
                        .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                        .CollectionSummaryReportToolStripMenuItem.Enabled = False
                        .SalesReceiptToolStripMenuItem1.Enabled = False
                        .ProductPacingReportToolStripMenuItem.Enabled = False
                    ElseIf UCase(xUser_Access) = UCase("Sales Agent") Then
                        .SystemFileToolStripMenuItem.Enabled = True

                        'Inventory File
                        .MasterFileToolStripMenuItem.Enabled = True
                        .SetCategoryFileToolStripMenuItem.Enabled = True
                        .SetItemFileToolStripMenuItem.Enabled = True
                        .SuppliersToolStripMenuItem.Enabled = False
                        .SuppliersProductToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem.Enabled = True
                        .StockOrderToolStripMenuItem.Enabled = True
                        .StockMonitoringToolStripMenuItem.Enabled = True
                        .BarcodeFormToolStripMenuItem.Enabled = True
                        .UnitMeasureToolStripMenuItem.Enabled = True
                        .BusinessInformationToolStripMenuItem.Enabled = False
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem.Enabled = False
                        .CashieringToolStripMenuItem.Enabled = False
                        .SalesReceiptToolStripMenuItem.Enabled = False
                        'manage users
                        .UserInformationFileToolStripMenuItem.Enabled = True
                        'USERS LOG
                        .AuditTrailToolStripMenuItem.Enabled = False
                        'REPORTS
                        .ReportsToolStripMenuItem.Enabled = True
                        .SupplierProfileToolStripMenuItem.Enabled = False
                        .SupplierProductsToolStripMenuItem.Enabled = False
                        .ProductsReorderPointToolStripMenuItem1.Enabled = True
                        .PurchaseOrderToolStripMenuItem.Enabled = True
                        .PurchaseReceiveToolStripMenuItem.Enabled = True
                        .StockBalancesToolStripMenuItem.Enabled = True
                        'POINT OF PAYMENTS
                        .PointOfPaymentToolStripMenuItem1.Enabled = False
                        .SalesCollectionToolStripMenuItem.Enabled = False
                        .SalesCollectionReportVOIDToolStripMenuItem.Enabled = False
                        .CollectionSummaryReportToolStripMenuItem.Enabled = False
                        .SalesReceiptToolStripMenuItem1.Enabled = False
                        .ProductPacingReportToolStripMenuItem.Enabled = False
                    End If
                End With
                Me.Close()
            Else
                xcountx = xcountx + 1
                If xcountx >= 3 Then
                    MsgBox("You have reach the maximum time of login !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    End
                End If

                MsgBox("Access denied !!!", MsgBoxStyle.Information, "Sales and Inventory")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        'Me.Close()
        'End
        If MsgBox("Do you really want to quit the system ???", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sales and Inventory") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If Me.Opacity >= 1 Then Timer1.Enabled = False
        'ix = ix + 1
        'Me.Opacity = ix / 100
        'Application.DoEvents()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'ix -= 1
        'Me.Opacity = ix / 100
        'Application.DoEvents()
        'If ix <= 0 Then End
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged

    End Sub

    Private Sub cmdserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdserver.Click
        FrmSERVERSETTINGS.ShowDialog()
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = 13 Then
            Call cmdlogin_Click(0, AcceptButton)
        End If
    End Sub
End Class