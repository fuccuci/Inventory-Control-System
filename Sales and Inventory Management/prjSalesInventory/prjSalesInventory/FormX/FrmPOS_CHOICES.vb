Public Class FrmPOS_CHOICES

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        If rbdefect.Checked Or rbNew.Checked Then
            FrmPOSSTOCKSLIST.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class