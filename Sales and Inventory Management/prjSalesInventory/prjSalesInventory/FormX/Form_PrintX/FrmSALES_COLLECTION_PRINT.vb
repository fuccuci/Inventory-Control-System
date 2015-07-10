Public Class FrmSALES_COLLECTION_PRINT

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        Dim xfrom As New CrystalDecisions.Shared.ParameterDiscreteValue
        Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     "AND Receipt_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
        globalFRM = "Sales_Report"
        ParamDVFrom.Value = dtfrom.Value
        ParamDVTo.Value = dtto.Value
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Collection ")
        Me.Close()
        Report.Show()
        'FrmREPORTS.Show()
    End Sub
End Class