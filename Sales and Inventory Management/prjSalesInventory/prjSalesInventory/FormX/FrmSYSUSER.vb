Public Class FrmSysUser

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSysUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(xUser_Access) = UCase("Administrator") Then
            FillListView(ExecuteSQLQuery("select user_id as 'Account No', Username as 'Username', Access_type as 'Access Type' FROM tbl_users ORDER BY Username"), lstusers, 1)
            Me.lstusers.Focus()
            Me.lstusers.Select()
        Else
            Me.Close()
            frmadduser.Text = "Edit User Account"
            frmadduser.ShowDialog()
        End If
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        frmadduser.Text = "Add User Account"
        frmadduser.txtlname.Text = ""
        frmadduser.txtfname.Text = ""
        frmadduser.txtmname.Text = ""
        frmadduser.txtaddress.Text = ""
        frmadduser.txtcontact.Text = ""
        frmadduser.txtusername.Text = ""
        frmadduser.txtpassword.Text = ""
        frmadduser.txtconfirm.Text = ""
        frmadduser.ShowDialog()
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        If MsgBox("Do you want to delete this profile?", MsgBoxStyle.YesNo, "Sales And Inventory") = MsgBoxResult.Yes Then
            lstusers.Focus()
            lstusers.Select()
            If xUser_ID = lstusers.FocusedItem.Text Then
                MsgBox("You can't delete your own user account !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            Else
                sqlSTR = "DELETE FROM tbl_users WHERE user_ID =" & lstusers.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)
                FillListView(ExecuteSQLQuery("select user_id as 'Account No', Username as 'Username', Access_type as 'Access Type' FROM tbl_users"), lstusers, 1)
            End If
            'MsgBox(lstusers.FocusedItem.Text)
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        'MsgBox(lstusers.FocusedItem.Text)
        frmadduser.Text = "Edit User Account"
        frmadduser.ShowDialog()
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        'sqlSTR = 
        ' MsgBox(sqlSTR)
        FillListView(ExecuteSQLQuery("SELECT user_id as 'Account No', username as 'Username', access_type as 'Access Type' FROM tbl_users WHERE username LIKE '" & Replace(txtsearch.Text, "'", "'") & "%' ORDER BY username"), lstusers, 1)
    End Sub
End Class