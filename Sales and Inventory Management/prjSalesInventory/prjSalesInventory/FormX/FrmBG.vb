Public Class FrmBG

 
    
    Private Sub FrmBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pics.Left = (Me.Width / 2) / 2
        pics.Top = (Me.Height / 2) / 2.7
        pics.Left = ((Me.Width / 2) - (pics.Width / 2)) - 10

    End Sub
End Class