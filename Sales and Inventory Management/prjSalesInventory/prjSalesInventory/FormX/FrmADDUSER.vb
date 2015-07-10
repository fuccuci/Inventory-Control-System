Public Class frmadduser
    Dim strERR As String
    Dim strNOERR As String
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Close()
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        strERR = "Please complete the following requirements!" & Chr(10) & "-----------------------------"
        strNOERR = strERR
        If txtfname.Text = "" Then
            strERR = strERR & Chr(10) & " Username"
        End If
        If txtlname.Text = "" Then
            strERR = strERR & Chr(10) & " Lastname"
        End If
        If txtmname.Text = "" Then
            strERR = strERR & Chr(10) & " Middlename"
        End If
        If txtaddress.Text = "" Then
            strERR = strERR & Chr(10) & " Address"
        End If
        If txtcontact.Text = "" Then
            strERR = strERR & Chr(10) & "Mobile / Phone "
        End If
        If txtusername.Text = "" Then
            strERR = strERR & Chr(10) & " Username "
        End If
        If Len(txtpassword.Text) < 6 Then
            strERR = strERR & Chr(10) & "Password Must Be At least 6 Characters"
        End If
        If txtpassword.Text = "" Then
            strERR = strERR & Chr(10) & " Password "
        End If

        If cmbaccnttype.Text = "" Then
            strERR = strERR & Chr(10) & " Account Type "
        End If
        If txtpassword.Text <> txtconfirm.Text Then
            strERR = strERR & Chr(10) & " Password not match "
        End If
        If strNOERR <> strERR Then
            MsgBox(strERR, MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If

        If Me.Text = "Edit User Account" Then
            If UCase(xUser_Access) = UCase("Administrator") Then
                sqlSTR = "UPDATE tbl_users SET username ='" & txtusername.Text & "', " _
                                    & "userpass='" & txtpassword.Text & "', " _
                                    & "access_type='" & cmbaccnttype.Text & "', " _
                                    & "lastname='" & txtlname.Text & "', " _
                                    & "firstname='" & txtfname.Text & "', " _
                                    & "middlename='" & txtmname.Text & "', " _
                                    & "address='" & txtaddress.Text & "', " _
                                    & "contact='" & txtcontact.Text & "', " _
                                    & "local_number ='" & txtlocal.Text & "' WHERE user_id =" & FrmSysUser.lstusers.FocusedItem.Text
            Else
                sqlSTR = "UPDATE tbl_users SET username ='" & txtusername.Text & "', " _
                                    & "userpass='" & txtpassword.Text & "', " _
                                    & "access_type='" & cmbaccnttype.Text & "', " _
                                    & "lastname='" & txtlname.Text & "', " _
                                    & "firstname='" & txtfname.Text & "', " _
                                    & "middlename='" & txtmname.Text & "', " _
                                    & "address='" & txtaddress.Text & "', " _
                                    & "contact='" & txtcontact.Text & "', " _
                                    & "local_number ='" & txtlocal.Text & "' WHERE user_id =" & xUser_ID
            End If
            
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit User Account ")
        Else
            sqlSTR = "INSERT INTO tbl_users (username, userpass, access_type, lastname, firstname, middlename, address, contact, local_number) VALUES('" & txtusername.Text & "', " _
                                                                     & "'" & txtpassword.Text & "', " _
                                                                     & "'" & cmbaccnttype.Text & "', " _
                                                                     & "'" & txtlname.Text & "', " _
                                                                     & "'" & txtfname.Text & "', " _
                                                                     & "'" & txtmname.Text & "', " _
                                                                     & "'" & txtaddress.Text & "', " _
                                                                     & "'" & txtcontact.Text & "', " _
                                                                     & "'" & txtlocal.Text & "')"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New User Account ")
        End If

        'ExecuteSQLQuery(sqlSTR)
        MsgBox("Record Successfuly Update! ", MsgBoxStyle.Information)
        FillListView(ExecuteSQLQuery("select user_id as 'Account No', Username as 'Username', Access_type as 'Access Type' FROM tbl_users"), FrmSysUser.lstusers, 1)
        Me.Close()
    End Sub

    Private Sub frmadduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtlname.Text = ""
        txtfname.Text = ""
        txtmname.Text = ""
        txtaddress.Text = ""
        txtcontact.Text = ""
        txtlocal.Text = ""
        If Me.Text = "Edit User Account" Then
            'FrmSysUser.lstusers.Select()
            If UCase(xUser_Access) = UCase("Administrator") Then
                FrmSysUser.lstusers.Focus()
                sqlSTR = "SELECT * FROM tbl_users WHERE user_ID =" & FrmSysUser.lstusers.FocusedItem.Text
                txtlname.Enabled = True
                txtfname.Enabled = True
                txtmname.Enabled = True
                txtaddress.Enabled = True
                txtcontact.Enabled = True
                txtlocal.Enabled = True
                txtusername.Enabled = True
                txtpassword.Enabled = True
                txtconfirm.Enabled = True
                cmbaccnttype.Enabled = True
            Else
                sqlSTR = "SELECT * FROM tbl_users WHERE user_ID =" & xUser_ID
                txtlname.Enabled = False
                txtfname.Enabled = False
                txtmname.Enabled = False
                txtaddress.Enabled = True
                txtcontact.Enabled = True
                txtlocal.Enabled = False
                txtusername.Enabled = False
                txtpassword.Enabled = True
                txtconfirm.Enabled = True
                cmbaccnttype.Enabled = False
            End If
            ExecuteSQLQuery(sqlSTR)
            'MsgBox(sqlDT.Rows(0)("username"))
            With sqlDT
                If .Rows.Count > 0 Then
                    'MsgBox(sqlDT.Rows(0)("lastname"))
                    txtlname.Text = .Rows(0)("lastname")
                    txtfname.Text = .Rows(0)("firstname")
                    txtmname.Text = .Rows(0)("middlename")
                    txtaddress.Text = .Rows(0)("address")
                    txtcontact.Text = .Rows(0)("contact")
                    txtlocal.Text = .Rows(0)("local_number").ToString
                    txtusername.Text = .Rows(0)("username")
                    txtpassword.Text = .Rows(0)("userpass")
                    txtconfirm.Text = .Rows(0)("userpass")
                    cmbaccnttype.Text = .Rows(0)("access_type")
                End If
            End With
        End If
    End Sub

    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged
        'txtusername.Text = txtlname.Text
        txtlname.Text = filter_Special_Char(str_Filter(txtlname, 65, 122, 32, 50))
        txtusername.Text = txtlname.Text
    End Sub

    Private Sub txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged
        txtcontact.Text = str_Filter(txtcontact, 48, 57, 0, 0)
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged
        txtfname.Text = filter_Special_Char(str_Filter(txtfname, 65, 122, 32, 50))
    End Sub

    Private Sub txtmname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmname.TextChanged
        txtmname.Text = filter_Special_Char(str_Filter(txtmname, 65, 122, 32, 50))
    End Sub

    Private Sub txtlocal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlocal.TextChanged
        txtlocal.Text = str_Filter(txtlocal, 48, 57, 0, 0)
    End Sub
End Class
