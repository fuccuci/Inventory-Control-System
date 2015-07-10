Public Class FrmSALES_COLLECTION_VOID_PRINT

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID IN " & _
                     "(SELECT Sales_ID FROM TBL_Sales_Sold WHERE Sales_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Sales_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "')"
        globalFRM = "Sales_Report_VOID"
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Sales Collection Void ")
        Me.Close()
        Report.Show()
        'FrmREPORTS.Show()
    End Sub
End Class