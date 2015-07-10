Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data
Public Class FrmREPORTSDated
    Private Sub FrmREPORTSDated_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues
        mReport = New ReportDocument()
        Me.MdiParent = MDIMain
        CrystalReportViewer1.Height = (Me.Height - Panel1.Height) + 10
        CrystalReportViewer1.Width = Me.Width - 10
        xRefresh()
    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged
        Call xRefresh()
    End Sub

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged
        Call xRefresh()
    End Sub

    Private Function xRefresh()
        Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues
        With MDIMain
            i_Print = 0
            .P_Print.Visible = True
            .tmr_Print.Enabled = True
            Select Case UCase(globalFRM)
                Case UCase("FrmPURCHASEORDER")
                    Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'"
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
                    'CrystalReportViewer1.RefreshReport()
                Case UCase("frmsales_collection")
                    Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                                 "AND Receipt_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
                    mReport.Load(Application.StartupPath & "\ReportX\SALES_REPORT.rpt")
                    ParamDVFrom.Value = dtfrom.Value
                    ParamDVTo.Value = dtto.Value

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))

                    ParamCollection.Add(ParamDVFrom)
                    mReport.DataDefinition.ParameterFields("txtfrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamDVTo)
                    mReport.DataDefinition.ParameterFields("txtto").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(_USER)
                    mReport.DataDefinition.ParameterFields("user").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyName)
                    mReport.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(ParamCompanyLoc)
                    mReport.DataDefinition.ParameterFields("CompLoc").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport

                    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Collection ")

                Case UCase("frmcollection_void")
                    Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID IN " & _
                                 "(SELECT Sales_ID FROM TBL_Sales_Sold WHERE Sales_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Sales_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "')"
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
                    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Collection Void ")

                Case UCase("frmcollection_summary")
                    Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                                 "AND Receipt_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
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
                    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Collection Summary ")

                Case UCase("frmsales_report_receipt")
                    Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt " & _
                                 "WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                                 "AND Receipt_Date >=' " & Format(dtfrom.Value, "MM/dd/yyyy") & _
                                 " ' AND Receipt_Date <=' " & Format(dtto.Value, "MM/dd/yyyy") & "'"
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
                    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Report Receipt ")
                Case UCase("frmproduct_pacing_fast_moving")
                    Rpt_SqlStr = "SELECT  DISTINCT TBL_Category_Item_File.Item_ID,  TBL_Sales_Sold_Detail.Item_Name, TBL_Sales_Sold_Detail.Item_QTY, SUM(Item_QTY) " & _
                                 "FROM TBL_Sales_Sold_Detail " & _
                                 "INNER JOIN TBL_Category_Item_File ON TBL_Sales_Sold_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                                 "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Sold_Detail.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                                 "WHERE TBL_Sales_Sold.Sales_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND TBL_Sales_Sold.Sales_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'" & _
                                 "GROUP BY  TBL_Category_Item_File.Item_ID,  TBL_Sales_Sold_Detail.Item_Name, TBL_Sales_Sold_Detail.Item_QTY "
                    'mReport.Load("D:\_PROGRAM\_VB.NET\Sales and Inventory\prjSalesInventory\prjSalesInventory\ReportX\ProductPacing_Report.rpt")
                    mReport.Load(Application.StartupPath & "\ReportX\ProductPacing_Report.rpt")
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
                Case UCase("frmproduct_pacing_slow_moving")
                    Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File " & _
                                 "WHERE Item_ID NOT IN " & _
                                 "(SELECT DISTINCT Item_ID FROM TBL_Sales_Sold_Detail " & _
                                 " INNER JOIN TBL_Sales_Sold ON TBL_Sales_Sold_Detail.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                                 " WHERE TBL_Sales_Sold.Sales_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND TBL_Sales_Sold.Sales_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "')"
                    mReport.Load(Application.StartupPath & "\ReportX\Product_pacing_slow_moving.rpt")
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
                Case UCase("frmpurchaseorder_receive")
                    Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'"

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

            End Select
            .P_Print.Visible = False
            .tmr_Print.Enabled = False
        End With
        xRefresh = 0
    End Function
End Class