Public Class FrmCOLLECTION_SUMMARY

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     "AND Receipt_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
        globalFRM = "collection_report"
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Collection Summary ")
        Me.Close()
        Report.Show()
        'FrmREPORTS.Show()
    End Sub
End Class