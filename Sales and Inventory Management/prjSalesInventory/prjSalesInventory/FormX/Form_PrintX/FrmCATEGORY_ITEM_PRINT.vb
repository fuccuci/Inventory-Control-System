Public Class FrmCATEGORY_ITEM_PRINT

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        'MsgBox(ActiveMdiChild.Name)
        If rbtall.Checked Then
            Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File ORDER BY Item_Name"
        Else
            Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File WHERE Catg_ID =" & FrmCatITEMList.lstCategory.FocusedItem.Text & " ORDER BY Item_Name"
        End If
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Category Item List ")
        Report.Show()
        'FrmREPORTS.Show()
        Me.Close()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub rbtselected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtselected.CheckedChanged

    End Sub
End Class