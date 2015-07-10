Public Class FrmPASSWORD
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        End If
        If e.KeyCode = 13 Then
            If TextBox1.Text = "password" Then
                sqlSTR = "UPDATE TBL_Stocks_Balances SET PASSWORD_INPUTED ='" & "Yes" & "' WHERE Item_ID =" & globalID
                ExecuteSQLQuery(sqlSTR)
                pass = True
                Audit_Trail(xUser_ID, TimeOfDay, "Access to over-ride the critical of the product")
                xpass = True
                Me.Close()
            Else
                MsgBox("Incorrect Password !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub FrmPASSWORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub
End Class