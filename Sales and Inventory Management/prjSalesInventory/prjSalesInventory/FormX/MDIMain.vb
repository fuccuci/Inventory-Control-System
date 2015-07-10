Imports System.Windows.Forms

Public Class MDIMain
    Dim minMaintenance As Integer
    Dim minPurchase As Integer
    Dim minSales As Integer
    Dim critical As Integer


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'aget()
    End Sub

    Private Sub MDIMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Do you really want to exit the system ??", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.No Then
            e.Cancel = 1
        Else
            sqlSTR = "UPDATE TBL_Audit_Log SET LOGOUT ='" & TimeOfDay & "' WHERE User_ID =" & xUser_ID & " AND LOG_ID=" & LOGID
            ExecuteSQLQuery(sqlSTR)

        End If
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If username = "" Then
        ' End
        ' End If
        'xUser_Access = "Administrator"
        checkServer()
        Me.lblUser.Text = username
        MDIDISABLED()
        ExecuteSQLQuery("SELECT * FROM TBL_Globaldata")
        Me.WindowState = FormWindowState.Maximized
        PanelAdvisory.Width = Me.Width
        PanelHoldAdvisory.Width = Me.Width
        
        If sqlDT.Rows.Count > 0 Then
            VAT = sqlDT.Rows(0)("BussVat")
            ParamCompanyName.Value = sqlDT.Rows(0)("BussName")
            ParamCompanyLoc.Value = sqlDT.Rows(0)("BussLocation")
            ParamCompanyContact.Value = sqlDT.Rows(0)("BussContact")
            ParamCompanyTIN.Value = sqlDT.Rows(0)("Tin")
        End If
        With FrmBG
            .MdiParent = Me
            '.WindowState = Me.WindowState
            .WindowState = FormWindowState.Maximized
            '.pics.Left = (Me.Width / 2) - (.pics.Width / 2)
            'pics.Left = (Me.Width / 2) - (pics.Width / 2)
            '.Width = Me.Width - (ToolStrip1.Width - TSHold.Width)
            .Show()
        End With
        With TSHoldRight
            PanelShortCut.Top = .Top - 15
            PanelShortCut.Left = .Left - 1
        End With
        FrmLOGIN.ShowDialog()
        LinkMaintain_LinkClicked(0, AcceptButton)
        LinkPurchasing_LinkClicked(0, AcceptButton)
        LinkSales_LinkClicked(0, AcceptButton)
        cmdLock.Enabled = True
        RefreshList(ActiveMdiChild.Name)
        'FrmAbout.ShowDialog()
        'MsgBox(Me.Width)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you really want to exit the system ??", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub UserInformationFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserInformationFileToolStripMenuItem.Click
        'If x_Access(xUser_Access) Then
        Audit_Trail(xUser_ID, TimeOfDay, "View User Account Info")
        FrmSysUser.ShowDialog()
        ' End If
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        'ToolStrip1.Visible = True
        cmdManageSuppliers_Click(0, AcceptButton)
    End Sub

    Private Sub SetCategoryFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCategoryFileToolStripMenuItem.Click
        cmdProductListing_Click(0, AcceptButton)
    End Sub

    Private Sub SetItemFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetItemFileToolStripMenuItem.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmCatITEMList.IsHandleCreated Then
                .Add("Category Item List", 18)
            End If
        End With
        FrmCatITEMList.MdiParent = Me
        FrmCatITEMList.Width = Me.Width
        FrmCatITEMList.Height = Me.Height
        FrmCatITEMList.Show()
        'End If
    End Sub

    Private Sub SuppliersProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersProductToolStripMenuItem.Click
        If x_Access(xUser_Access) Then
            With lstShortCut.Items
                If Not FrmSUPPLIERSPRODUCT.IsHandleCreated Then
                    .Add("Supplier Products", 19)
                End If
            End With
            FrmSUPPLIERSPRODUCT.MdiParent = Me
            FrmSUPPLIERSPRODUCT.Width = Me.Width
            FrmSUPPLIERSPRODUCT.Height = Me.Height
            FrmSUPPLIERSPRODUCT.Show()
        End If

    End Sub

    Private Sub StockOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockOrderToolStripMenuItem.Click
        cmdOrderReceive_Click(0, AcceptButton)
    End Sub

    Private Sub StockReceiveFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPURCHASEORDER_RECEIVE.MdiParent = Me
        FrmPURCHASEORDER_RECEIVE.Width = Me.Width
        FrmPURCHASEORDER_RECEIVE.Height = Me.Height
        FrmPURCHASEORDER_RECEIVE.Show()
    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMonitoringToolStripMenuItem.Click
        cmdStockMonitoring_Click(0, AcceptButton)
    End Sub

    Private Sub BusinessInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusinessInformationToolStripMenuItem.Click
        If x_Access(xUser_Access) Then
            FrmBUSINESS_INFO.ShowDialog()
        End If
    End Sub

    Private Sub CashieringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashieringToolStripMenuItem.Click
        cmdCashiering_Click(0, AcceptButton)
    End Sub

    Private Sub SalesReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReceiptToolStripMenuItem.Click
        cmdSalesReceipt_Click(0, AcceptButton)
    End Sub

    Private Sub SupplierProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierProfileToolStripMenuItem.Click
        Dim Report As New FrmREPORTS
        If x_Access(xUser_Access) Then
            Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Suppliers Listing")
            globalFRM = "FrmSuppliersList"
            Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName"
            Report.Show()
            'FrmREPORTS.Show()
        End If
    End Sub

    Private Sub SupplierProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierProductsToolStripMenuItem.Click
        Dim Report As New FrmREPORTS
        If x_Access(xUser_Access) Then
            Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Suppliers Products")
            globalFRM = "frmsuppliersproduct"
            Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName "
            Report.Show()
            'FrmREPORTS.Show()
        End If

    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        Dim report As New FrmREPORTSDated
        ' If x_Access(xUser_Access) Then
        'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
        globalFRM = "FrmPURCHASEORDER"
        'FrmREPORTSDated.MdiParent = Me
        'FrmREPORTSDated.Width = Me.Width
        'FrmREPORTSDated.Height = Me.Height
        report.Show()
        'FrmPURCHASE_ORDER_PRINT.ShowDialog()
        'End If
    End Sub

    Private Sub PurchaseReceiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReceiveToolStripMenuItem.Click
        Dim report As New FrmREPORTSDated
        ' If x_Access(xUser_Access) Then
        globalFRM = "frmpurchaseorder_receive"
        report.Show()
        '   FrmRECEIVE_ORDER_PRINT.ShowDialog()

        ' End If

    End Sub

    Private Sub StockBalancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBalancesToolStripMenuItem.Click
        Dim Report As New FrmREPORTS
        'If x_Access(xUser_Access) Then
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Current Stocks Balances")
        globalFRM = "FrmSTOCKMONITORINGBALANCES"
        Rpt_SqlStr = "SELECT * FROM TBL_Stocks_Balances"
        Report.Show()
        'FrmREPORTS.Show()
        'End If
    End Sub

    Private Sub SalesCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCollectionToolStripMenuItem.Click
        'FrmSALES_COLLECTION_PRINT.ShowDialog()
        Dim report As New FrmREPORTSDated
        'If x_Access(xUser_Access) Then
        'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
        globalFRM = "FrmSales_Collection"
        'FrmREPORTSDated.MdiParent = Me
        'FrmREPORTSDated.Width = Me.Width
        'FrmREPORTSDated.Height = Me.Height
        report.Show()
        'FrmPURCHASE_ORDER_PRINT.ShowDialog()
        ' End If
    End Sub

    Private Sub SalesCollectionReportVOIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCollectionReportVOIDToolStripMenuItem.Click
        'FrmSALES_COLLECTION_VOID_PRINT.ShowDialog()
        Dim report As New FrmREPORTSDated
        If x_Access(xUser_Access) Then
            globalFRM = "frmcollection_void"
            report.Show()
        End If
    End Sub

    Private Sub CollectionSummaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionSummaryReportToolStripMenuItem.Click
        'FrmCOLLECTION_SUMMARY.ShowDialog()
        Dim report As New FrmREPORTSDated
        'If x_Access(xUser_Access) Then
        globalFRM = "frmcollection_summary"
        report.Show()
        ' End If
    End Sub

    Private Sub ProductsReorderPointToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsReorderPointToolStripMenuItem1.Click
        Dim Report As New FrmREPORTS
        'If x_Access(xUser_Access) Then
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Products Reorder Level")
        globalFRM = "FrmPRODUCTS_REORDER"
        Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File " & _
                     "WHERE Item_ID IN (SELECT Item_ID FROM TBL_Stocks_Balances WHERE Item_QTY <= Item_Reorder_Point)"
        Report.Show()
        'FrmREPORTS.Show()
        'End If
    End Sub

    Private Sub BarcodeFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarcodeFormToolStripMenuItem.Click
        FrmBarcode.ShowDialog()
    End Sub

    Private Sub UnitMeasureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitMeasureToolStripMenuItem.Click
        If x_Access(xUser_Access) Then
            FrmUNIT_MEASURE.ShowDialog()
        End If
    End Sub

    Private Sub SalesReceiptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReceiptToolStripMenuItem1.Click
        'FrmSALES_REPORT_RECEIPT.ShowDialog()
        Dim report As New FrmREPORTSDated
        'If x_Access(xUser_Access) Then
        globalFRM = "frmsales_report_receipt"
        report.Show()
        'End If
    End Sub

    Private Sub toolStripClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormClose(ActiveMdiChild)
    End Sub

    Private Sub ToolStripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormAdd(ActiveMdiChild.Name)
    End Sub

    Private Sub ToolStripEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormEdit(ActiveMdiChild.Name)
    End Sub

    Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDelete(ActiveMdiChild.Name)
    End Sub

    Private Sub ToolStripSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormSearch(ActiveMdiChild.Name)
    End Sub

    Private Sub ToolStripPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPrint(ActiveMdiChild.Name)
    End Sub

    Private Sub ToolStripLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLOGIN.ShowDialog()
    End Sub

    Private Sub AuditTrailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditTrailToolStripMenuItem.Click
        If x_Access(xUser_Access) Then
            With lstShortCut.Items
                If Not FrmAUDIT_TRAIL.IsHandleCreated Then
                    .Add("Users Log", 20)
                End If
            End With
            FrmAUDIT_TRAIL.MdiParent = Me
            FrmAUDIT_TRAIL.WindowState = FormWindowState.Maximized
            FrmAUDIT_TRAIL.Show()
        End If
    End Sub

    Private Sub ToolStripRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshList(ActiveMdiChild.Name)
    End Sub

    Private Sub ProductsReorderPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsReorderPointToolStripMenuItem.Click
        cmdProductReorder_Click(0, AcceptButton)
    End Sub

    Private Sub LinkMaintain_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMaintain.LinkClicked
        Click_Maintain()
    End Sub

    Private Sub LinkPurchasing_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPurchasing.LinkClicked
        Click_Purchasing()
    End Sub

    Private Sub LinkSales_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkSales.LinkClicked
        Click_Sales()
    End Sub

    Private Sub cmdProductListing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProductListing.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmCatList.IsHandleCreated Then
                .Add("Product Listing", 11)
            End If
        End With
        FrmCatList.MdiParent = Me
        'FrmCatList.WindowState = FormWindowState.Maximized
        FrmCatList.Height = Me.Height
        FrmCatList.Width = Me.Width
        FrmCatList.Show()
        'End If
    End Sub

    Private Sub cmdManageSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManageSuppliers.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmSuppliersList.IsHandleCreated Then
                .Add("Manage Suppliers", 12)
            End If
        End With
        FrmSuppliersList.MdiParent = Me
        FrmSuppliersList.Width = Me.Width
        FrmSuppliersList.Height = Me.Height
        FrmSuppliersList.Show()
        ' End If
    End Sub

    Private Sub lstShortCut_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstShortCut.MouseDoubleClick
        Select Case lstShortCut.FocusedItem.Text
            Case "Product Listing"
                FrmCatList.BringToFront()
            Case "Manage Suppliers"
                FrmSuppliersList.BringToFront()
            Case "Order and Receive"
                FrmPURCHASEORDER.BringToFront()
            Case "Stock Monitoring"
                frmSTOCKMONITORINGBALANCES.BringToFront()
            Case "Critical Product(s)"
                FrmPRODUCTS_REORDER.BringToFront()
            Case "Defective Stocks"
                FrmDEFFECTIVE_RETURN_STOCKS.BringToFront()
            Case "Ordering Kiosk"
                FrmORDER_FORM.BringToFront()
            Case "Cashiering"
                FrmPOSCASHIER.BringToFront()
            Case "Sales Receipt"
                FrmPOSRECEIPT_LIST.BringToFront()
            Case "Physical Counting"
                FrmPhysicalCount.BringToFront()
            Case "Category Item List"
                FrmCatITEMList.BringToFront()
            Case "Supplier Products"
                FrmSUPPLIERSPRODUCT.BringToFront()
            Case "Users Log"
                FrmAUDIT_TRAIL.BringToFront()
        End Select
    End Sub

    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        'If x_Access(xUser_Access) Then
        FrmSysUser.ShowDialog()
        ' End If
    End Sub

    Private Sub cmdOrderReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrderReceive.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmPURCHASEORDER.IsHandleCreated Then
                .Add("Order and Receive", 13)
            End If
        End With
        FrmPURCHASEORDER.MdiParent = Me
        FrmPURCHASEORDER.Width = Me.Width
        FrmPURCHASEORDER.Height = Me.Height
        FrmPURCHASEORDER.Show()
        'End If
    End Sub

    Private Sub cmdStockMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStockMonitoring.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not frmSTOCKMONITORINGBALANCES.IsHandleCreated Then
                .Add("Stock Monitoring", 3)
            End If
        End With
        frmSTOCKMONITORINGBALANCES.MdiParent = Me
        frmSTOCKMONITORINGBALANCES.Width = Me.Width
        frmSTOCKMONITORINGBALANCES.Height = Me.Height
        frmSTOCKMONITORINGBALANCES.Show()
        'End If
    End Sub

    Private Sub cmdProductReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProductReorder.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmPRODUCTS_REORDER.IsHandleCreated Then
                .Add("Critical Product(s)", 14)
            End If
        End With
        FrmPRODUCTS_REORDER.MdiParent = Me
        FrmPRODUCTS_REORDER.Width = Me.Width
        FrmPRODUCTS_REORDER.Height = Me.Height
        FrmPRODUCTS_REORDER.Show()
        'End If
    End Sub

    Private Sub cmdDefective_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefective.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmDEFFECTIVE_RETURN_STOCKS.IsHandleCreated Then
                .Add("Defective Stocks", 15)
            End If
        End With
        FrmDEFFECTIVE_RETURN_STOCKS.MdiParent = Me
        FrmDEFFECTIVE_RETURN_STOCKS.Width = Me.Width
        FrmDEFFECTIVE_RETURN_STOCKS.Height = Me.Height
        FrmDEFFECTIVE_RETURN_STOCKS.Show()
        'End If
    End Sub

    Private Sub cmdBusInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBusInfo.Click
        'If x_Access(xUser_Access) Then
        FrmBUSINESS_INFO.ShowDialog()
        ' End If
    End Sub

    Private Sub Click_Maintain()
        Dim i As Integer
        'LinkMaintain.Enabled = False
        If minMaintenance = 0 Then
            For i = 0 To 177
                PanelMaintain.Height = PanelMaintain.Height + 1
                PanelPurchasing.Top = PanelMaintain.Height + 20
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top)
                minMaintenance = minMaintenance + PanelMaintain.Height
                Application.DoEvents()
            Next
        Else
            'MsgBox(Min)
            For i = 0 To 177
                PanelMaintain.Height = PanelMaintain.Height - 1
                PanelPurchasing.Top = (PanelMaintain.Height + 30) - 20
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top)
                Application.DoEvents()
            Next
            minMaintenance = 0
        End If
        'LinkMaintain.Enabled = True
    End Sub

    Private Sub Click_Purchasing()
        Dim i As Integer
        'LinkPurchasing.Enabled = False
        If minPurchase = 0 Then
            For i = 0 To 170
                PanelPurchasing.Height = PanelPurchasing.Height + 1
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
                minPurchase = minPurchase + PanelPurchasing.Height
                Application.DoEvents()
            Next
        Else
            'MsgBox(Min)
            For i = 0 To 170
                PanelPurchasing.Height = PanelPurchasing.Height - 1
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 2
                Application.DoEvents()
            Next
            minPurchase = 0
        End If
        'LinkPurchasing.Enabled = True
    End Sub

    Private Sub Click_Sales()
        Dim i As Integer
        'LinkSales.Enabled = False
        If minSales = 0 Then
            For i = 0 To 120
                PanelSales.Height = PanelSales.Height + 1
                'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
                minSales = minSales + PanelPurchasing.Height
                Application.DoEvents()
            Next
        Else
            'MsgBox(Min)
            For i = 0 To 120
                PanelSales.Height = PanelSales.Height - 1
                'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 5
                Application.DoEvents()
            Next
            minSales = 0
        End If
        'LinkSales.Enabled = True
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        FormClose(ActiveMdiChild)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        FormAdd(ActiveMdiChild.Name)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FormEdit(ActiveMdiChild.Name)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If xUser_Access = "Administrator" Then
            pnadvisory_Admin.BringToFront()
            pnadvisory_Admin.Visible = True
            pnadvisory_Admin.Left = pnadvisory_Admin.Left - 1.3
            If pnadvisory_Admin.Left <= (pnadvisory_Admin.Width * -1) Then
                pnadvisory_Admin.Left = Me.Width + 150
            End If
            'If xSlidePanel <= -10 Then
            ' pnadvisory_Admin.Left = Me.Width + 150
            'End If
        ElseIf xUser_Access = "Cashier" Then
            pnAdvisory_Cashier.BringToFront()
            pnAdvisory_Cashier.Visible = True
            pnAdvisory_Cashier.Left = pnAdvisory_Cashier.Left - 1.3
            If pnAdvisory_Cashier.Left <= (pnAdvisory_Cashier.Width * -1) Then
                pnAdvisory_Cashier.Left = Me.Width + 150
            End If
        ElseIf xUser_Access = "Stock Room" Then
            pnAdvisory_Stock.BringToFront()
            pnAdvisory_Stock.Visible = True
            pnAdvisory_Stock.Left = pnAdvisory_Stock.Left - 1.3
            If pnAdvisory_Stock.Left <= (pnAdvisory_Stock.Width * -1) Then
                pnAdvisory_Stock.Left = Me.Width + 150
            End If
        ElseIf xUser_Access = "Sales Agent" Then
            pnAdvisory_SalesAgent.BringToFront()
            pnAdvisory_SalesAgent.Visible = True
            pnAdvisory_SalesAgent.Left = pnAdvisory_SalesAgent.Left - 1.3
            If pnAdvisory_SalesAgent.Left <= (pnAdvisory_SalesAgent.Width * -1) Then
                pnAdvisory_SalesAgent.Left = Me.Width + 150
            End If
        End If
    End Sub

    Private Sub cmdCustomerOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerOrder.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmORDER_FORM.IsHandleCreated Then
                .Add("Ordering Kiosk", 7)
            End If
        End With
        FrmORDER_FORM.MdiParent = Me
        FrmORDER_FORM.Width = Me.Width
        FrmORDER_FORM.Height = Me.Height
        FrmORDER_FORM.Show()
        'End If
    End Sub


    Private Sub cmdCashiering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashiering.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmPOSCASHIER.IsHandleCreated Then
                .Add("Cashiering", 17)
            End If
        End With
        FrmPOSCASHIER.MdiParent = Me
        'FrmPOSCASHIER.WindowState = FormWindowState.Maximized
        FrmPOSCASHIER.Width = Me.Width
        FrmPOSCASHIER.Height = Me.Height
        FrmPOSCASHIER.Show()
        'End If
    End Sub

    Private Sub MDIMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        'Debug.Print("test4")
        ActivatedToolbar(ActiveMdiChild)
    End Sub

    Private Sub MDIMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'MsgBox(1)
        With TSHoldRight
            PanelShortCut.Top = .Top - 15
            PanelShortCut.Left = .Left - 1
        End With
        PanelHoldAdvisory.Top = TSHoldAdvisory.Top
        PanelAdvisory.Top = PanelHoldAdvisory.Top
        PanelShortCut.Height = (Me.Height - (TSHoldButtons.Height + TSHoldAdvisory.Height + (TSHoldAdvisory.Height / 2) + 30))
        lstShortCut.Height = PanelShortCut.Height - 27
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        RefreshList(ActiveMdiChild.Name)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        FormPrint(ActiveMdiChild.Name)
    End Sub

    Private Sub cmdSalesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalesReceipt.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmPOSRECEIPT_LIST.IsHandleCreated Then
                .Add("Sales Receipt", 16)
            End If
        End With
        FrmPOSRECEIPT_LIST.MdiParent = Me
        FrmPOSRECEIPT_LIST.WindowState = FormWindowState.Maximized
        'FrmORDER_FORM.Width = Me.Width
        'FrmORDER_FORM.Height = Me.Height
        FrmPOSRECEIPT_LIST.Show()
        'End If
    End Sub

 
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        FormDelete(ActiveMdiChild.Name)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        FormSearch(ActiveMdiChild.Name)
    End Sub

    Private Sub cmdPhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhysical.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmPhysicalCount.IsHandleCreated Then
                .Add("Physical Counting", 10)
            End If
        End With
        FrmPhysicalCount.MdiParent = Me
        'FrmPhysicalCount.WindowState = FormWindowState.Maximized
        FrmORDER_FORM.Width = Me.Width
        FrmORDER_FORM.Height = Me.Height
        FrmPhysicalCount.Show()
        'End If
    End Sub

    Private Sub tmrclock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrclock.Tick
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub cmdAuditTrail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAuditTrail.Click
        'If x_Access(xUser_Access) Then
        With lstShortCut.Items
            If Not FrmAUDIT_TRAIL.IsHandleCreated Then
                .Add("Users Log", 20)
            End If
        End With
        ' frmSTOCKMONITORINGBALANCES.MdiParent = Me
        ' frmSTOCKMONITORINGBALANCES.Width = Me.Width
        ' frmSTOCKMONITORINGBALANCES.Height = Me.Height
        ' frmSTOCKMONITORINGBALANCES.Show()

        FrmAUDIT_TRAIL.MdiParent = Me
        FrmAUDIT_TRAIL.Width = Me.Width
        FrmAUDIT_TRAIL.Height = Me.Height
        FrmAUDIT_TRAIL.Show()
        'End If
    End Sub

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        xclose()
        lstShortCut.Items.Clear()
        sqlSTR = "UPDATE TBL_Audit_Log SET LOGOUT ='" & TimeOfDay & "' WHERE User_ID =" & xUser_ID & " AND LOG_ID=" & LOGID
        ExecuteSQLQuery(sqlSTR)
         LinkMaintain.Enabled = False
        LinkPurchasing.Enabled = False
        LinkSales.Enabled = False
        'Maintenance
        cmdProductListing.Enabled = False
        cmdManageSuppliers.Enabled = False
        cmdUsers.Enabled = False
        cmdAuditTrail.Enabled = False
        cmdBusInfo.Enabled = False
        'Purchasing
        cmdOrderReceive.Enabled = False
        cmdStockMonitoring.Enabled = False
        cmdPhysical.Enabled = False
        cmdProductReorder.Enabled = False
        cmdDefective.Enabled = False
        'Sales
        cmdCustomerOrder.Enabled = False
        cmdCashiering.Enabled = False
        cmdSalesReceipt.Enabled = False
        Timer1.Enabled = False
        pnadvisory_Admin.Visible = False
        pnAdvisory_Stock.Visible = False
        pnAdvisory_Cashier.Visible = False
        pnAdvisory_SalesAgent.Visible = False
        tmrcritical.Enabled = False
        FrmLOGIN.ShowDialog()
    End Sub

    Public Function aget()

        If UCase(xUser_Access) = UCase("Administrator") Then
            LinkMaintain.Enabled = True
            LinkPurchasing.Enabled = True
            LinkSales.Enabled = True
            'Maintenance
            cmdProductListing.Enabled = True
            cmdManageSuppliers.Enabled = True
            cmdUsers.Enabled = True
            cmdAuditTrail.Enabled = True
            cmdBusInfo.Enabled = True
            'Purchasing
            cmdOrderReceive.Enabled = True
            cmdStockMonitoring.Enabled = True
            cmdPhysical.Enabled = True
            cmdProductReorder.Enabled = True
            cmdDefective.Enabled = True
            'Sales
            cmdCustomerOrder.Enabled = True
            cmdCashiering.Enabled = True
            cmdSalesReceipt.Enabled = True
        ElseIf UCase(xUser_Access) = UCase("Cashier") Then
            'Maintenance
            cmdProductListing.Enabled = False
            cmdManageSuppliers.Enabled = False
            cmdUsers.Enabled = True
            cmdAuditTrail.Enabled = False
            cmdBusInfo.Enabled = False
            'Purchasing
            cmdOrderReceive.Enabled = False
            cmdStockMonitoring.Enabled = False
            cmdPhysical.Enabled = False
            cmdProductReorder.Enabled = False
            cmdDefective.Enabled = False
            'Sales
            cmdCustomerOrder.Enabled = False
            cmdCashiering.Enabled = True
            cmdSalesReceipt.Enabled = True

            LinkMaintain.Enabled = False
            LinkPurchasing.Enabled = False
            LinkSales.Enabled = True

        ElseIf UCase(xUser_Access) = UCase("Stock Room") Then
            'Maintenance
            cmdProductListing.Enabled = False
            cmdManageSuppliers.Enabled = False
            cmdUsers.Enabled = True
            cmdAuditTrail.Enabled = False
            cmdBusInfo.Enabled = False
            'Purchasing
            cmdOrderReceive.Enabled = True
            cmdStockMonitoring.Enabled = True
            cmdPhysical.Enabled = True
            cmdProductReorder.Enabled = True
            cmdDefective.Enabled = True
            'Sales
            cmdCustomerOrder.Enabled = False
            cmdCashiering.Enabled = False
            cmdSalesReceipt.Enabled = False

            LinkMaintain.Enabled = False
            LinkPurchasing.Enabled = True
            LinkSales.Enabled = False
        ElseIf UCase(xUser_Access) = UCase("Sales Agent") Then
            'Maintenance
            cmdProductListing.Enabled = True
            cmdManageSuppliers.Enabled = True
            cmdUsers.Enabled = True
            cmdAuditTrail.Enabled = False
            cmdBusInfo.Enabled = False
            'Purchasing
            cmdOrderReceive.Enabled = True
            cmdStockMonitoring.Enabled = True
            cmdPhysical.Enabled = True
            cmdProductReorder.Enabled = True
            cmdDefective.Enabled = True
            'Sales
            cmdCustomerOrder.Enabled = True
            cmdCashiering.Enabled = False
            cmdSalesReceipt.Enabled = False

            LinkMaintain.Enabled = True
            LinkPurchasing.Enabled = True
            LinkSales.Enabled = True
        End If
        aget = 0
    End Function

    Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click
        FrmBG.BringToFront()
    End Sub

    Private Sub lstShortCut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstShortCut.SelectedIndexChanged

    End Sub

    Private Sub pnadvisory_Admin_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnadvisory_Admin.Paint

    End Sub

    Private Sub tmrcritical_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcritical.Tick
        critical = critical + 1

        If (critical Mod 2) = 0 Then
            ' MsgBox(critical & "   1")
            'cmdProductReorder.Enabled = False
            cmdProductReorder.ForeColor = Color.Red
        Else
            cmdProductReorder.ForeColor = Color.Black
            'MsgBox(critical & "  2")
            'cmdProductReorder.Enabled = True
        End If
    End Sub

    Private Sub ProductPacingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductPacingReportToolStripMenuItem.Click
        'Dim report As New FrmREPORTSDated
        ' If x_Access(xUser_Access) Then
        'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
        'globalFRM = "frmproduct_pacing"
        'FrmREPORTSDated.MdiParent = Me
        'FrmREPORTSDated.Width = Me.Width
        'FrmREPORTSDated.Height = Me.Height
        'report.Show()
        'FrmPURCHASE_ORDER_PRINT.ShowDialog()
        ' End If
    End Sub

    Private Sub tmr_Print_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Print.Tick
        i_Print += 1
        If i_Print = 1 Then
            lblprint.Text = "Please wait while printing records."
        ElseIf i_Print = 2 Then
            lblprint.Text = "Please wait while printing records.."
        ElseIf i_Print = 3 Then
            lblprint.Text = "Please wait while printing records..."
        ElseIf i_Print = 4 Then
            lblprint.Text = "Please wait while printing records...."
            i_Print = 0
        End If
    End Sub

    Private Sub FastMovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastMovingToolStripMenuItem.Click
        Dim report As New FrmREPORTSDated
        globalFRM = "frmproduct_pacing_fast_moving"
        report.Show()
    End Sub

    Private Sub SlowMovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlowMovingToolStripMenuItem.Click
        Dim report As New FrmREPORTSDated
        globalFRM = "frmproduct_pacing_slow_moving"
        report.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'MsgBox(Application.StartupPath)
        System.Diagnostics.Process.Start(Application.StartupPath & "\Gazuto Manual.doc")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub
End Class
