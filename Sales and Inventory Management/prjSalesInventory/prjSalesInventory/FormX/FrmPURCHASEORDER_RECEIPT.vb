Public Class FrmPURCHASEORDER_RECEIPT

    Private Sub FrmPURCHASEORDER_RECEIPT_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With Me
            GroupBox2.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox2.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstreceive.Width = GroupBox2.Width - 2
            .lstreceive.Height = GroupBox2.Height - 105
        End With
    End Sub

    Private Sub FrmPURCHASEORDER_RECEIPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIREFRESH()
    End Sub
End Class