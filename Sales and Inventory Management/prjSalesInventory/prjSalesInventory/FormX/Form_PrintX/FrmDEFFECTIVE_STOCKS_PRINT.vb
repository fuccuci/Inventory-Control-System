Public Class FrmDEFFECTIVE_STOCKS_PRINT

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        Rpt_SqlStr = "SELECT * FROM TBL_Deffective_PO WHERE Return_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Return_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Deffective Stocks ")
        Report.Show()
        'FrmREPORTS.Show()
        Me.Close()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class