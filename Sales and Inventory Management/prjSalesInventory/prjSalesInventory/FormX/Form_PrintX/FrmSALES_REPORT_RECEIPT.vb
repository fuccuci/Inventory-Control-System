Public Class FrmSALES_REPORT_RECEIPT

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt " & _
                     "WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     "AND Receipt_Date >=' " & Format(dtfrom.Value, "MM/dd/yyyy") & _
                     " ' AND Receipt_Date <=' " & Format(dtto.Value, "MM/dd/yyyy") & "'"
        globalFRM = "Sales_Receipt"
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Report Receipt ")
        Report.Show()
        'FrmREPORTS.Show()
        Me.Close()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class