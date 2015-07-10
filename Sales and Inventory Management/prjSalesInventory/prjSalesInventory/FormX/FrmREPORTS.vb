Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data

Public Class FrmREPORTS
    Private Sub FrmREPORTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues
        mReport = New ReportDocument()

        ' Frm_Screen.Show()
        With MDIMain
            i_Print = 0
            .P_Print.Visible = True
            .tmr_Print.Enabled = True
            Select Case UCase(globalFRM)
                Case UCase("frmcatitemlist")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\ProductList_Rpt.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\ProductList_Rpt.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("FrmSuppliersList")
                    'mReport.Load("G:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\SuppliersList_Rpt.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\SuppliersList_Rpt.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("frmsuppliersproduct")
                    'mReport.Load("D:\_PROGRAM\_VB.NET\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\SuppliersProduct_RPT.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\SuppliersProduct_RPT.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)
                    CrystalReportViewer1.ReportSource = mReport

                    Me.MdiParent = MDIMain

                Case UCase("FrmPURCHASEORDER")
                    mReport.Load(Application.StartupPath & "\ReportX\PurchaseOrder_RPT.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("PurchaseORder_BySupplier")
                    mReport.Load(Application.StartupPath & "\ReportX\PO_Supplier_RPT.rpt")
                    'mReport.Load("D:\_PROGRAM\_VB.NET\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\PO_Supplier_RPT.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))

                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain
                Case UCase("frmpurchaseorder_receive")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\PurchaseReceive_RPT.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\PurchaseReceive_RPT.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("FrmSTOCKMONITORINGBALANCES")
                    mReport.Load(Application.StartupPath & "\ReportX\CurrentStocks_RPT.rpt")
                    Call DataSourceConnection_Report()
                    'mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", Split(tmpStr, ":")(2), False)
                    'mReport.DataSourceConnections(0).SetLogon("sa", "angelito")
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))

                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("frmPOSPAYMENT")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Receipt_Rpt.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Receipt_Rpt.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyTIN)
                    mReport.DataDefinition.ParameterFields("CompTIN").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    CrystalReportViewer1.PrintReport()
                    'Me.MdiParent = MDIMain
                Case UCase("Sales_Report")

                    mReport.Load(Application.StartupPath & "\ReportX\SALES_REPORT.rpt")
                    Call DataSourceConnection_Report()

                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(ParamDVFrom)
                    mReport.DataDefinition.ParameterFields("txtfrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamDVTo)
                    mReport.DataDefinition.ParameterFields("txtto").ApplyCurrentValues(ParamCollection)

                    'ParamCollection.Add(_USER)
                    'mReport.DataDefinition.ParameterFields("users").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    CrystalReportViewer1.Refresh()
                    'CrystalReportViewer1.ParameterFieldInfo.Item("txttest").DefaultValues = tempValues
                    Me.MdiParent = MDIMain

                Case UCase("Sales_Report_VOID")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\SALES_REPORT_VOID.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\SALES_REPORT_VOID.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("collection_report")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Collection_Summary.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Collection_Summary.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("FrmPRODUCTS_REORDER")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Products_Reorder.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Products_Reorder.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("frmBarcode")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\BARCODE.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\BARCODE.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    CrystalReportViewer1.ReportSource = mReport

                    'Me.MdiParent = MDIMain

                Case UCase("Sales_Receipt")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\SALES_RECEIPT_REPORT.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\SALES_RECEIPT_REPORT.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("deffective_po_report")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Deffective_Stocks.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Deffective_Stocks.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("deffective_po_return")
                    'mReport.Load("D:\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Deffective_Stocks_Return.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Deffective_Stocks_Return.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyContact)
                    mReport.DataDefinition.ParameterFields("CompContact").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("return_customer")
                    mReport.Load(Application.StartupPath & "\ReportX\ReturnStockToCustomer.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                Case UCase("frmorder_form")
                    mReport.Load(Application.StartupPath & "\ReportX\Order_Slip.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    CrystalReportViewer1.ReportSource = mReport

                Case UCase("frmorder_form_data")
                    mReport.Load(Application.StartupPath & "\ReportX\Order_Slip.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    CrystalReportViewer1.ReportSource = mReport
                Case UCase("FRMAUDIT_TRAIL")

                    'mReport.Load("D:\_PROGRAM\_VB.NET\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\Users_LOG.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\Users_LOG.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)


                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain
                Case UCase("frmphysicalcount")
                    mReport.Load(Application.StartupPath & "\ReportX\physicalcount_report.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain

                    '---
                Case UCase("frmproduct_pacing")
                    'mReport.Load("D:\_PROGRAM\_VB.NET\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\ProductPacing_Report.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\physicalcount_report.rpt")
                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = MDIMain
            End Select
            .P_Print.Visible = False
            .tmr_Print.Enabled = False
        End With
        'Frm_Screen.Close()
    End Sub
End Class