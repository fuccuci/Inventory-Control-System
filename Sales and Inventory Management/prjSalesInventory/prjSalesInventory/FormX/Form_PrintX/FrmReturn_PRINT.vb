Public Class FrmReturn_PRINT

    Private Sub rbreturnstocks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbreturnstocks.CheckedChanged
        'globalFRM = "deffective_po_return"
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        If rbreturnstocks.Checked Then
            globalFRM = "deffective_po_return"
            Rpt_SqlStr = "SELECT * FROM TBL_Deffective_PO_Return WHERE Return_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Return_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
            Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Deffective Stocks Return ")
            Report.Show()
            'FrmREPORTS.Show()
        Else
            globalFRM = "return_customer"
            Rpt_SqlStr = "SELECT * FROM TBL_Pending_Item WHERE Return_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Return_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' And Returnx ='Yes'"
            Report.Show()
            'FrmREPORTS.Show()
        End If
        Me.Close()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class