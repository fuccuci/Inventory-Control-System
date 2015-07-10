Public Class FrmBUSINESS_INFO

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not IsNumeric(txtvat.Text) Then
            MsgBox("Vat should be numeric !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If sqlDT.Rows.Count > 0 Then
            'edit
            sqlSTR = "UPDATE TBL_GlobalData SET BussName ='" & txtbusname.Text & "', " _
                                    & "BussLocation ='" & txtbusaddress.Text & "', " _
                                    & "BussContact ='" & txtno.Text & "', " _
                                    & "BussVat =" & txtvat.Text & ", " _
                                    & "Tin ='" & txttin.Text & "', " _
                                    & "Busslocal ='" & txtlocal.Text & "', " _
                                    & "Email_Address ='" & txtemail.Text & "', " _
                                    & "Website ='" & txtwebsite.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Bussiness Info")
        Else
            'add
            sqlSTR = "INSERT INTO TBL_GlobalData (BussName, BussLocation, BussContact, BussVat, Tin, Busslocal, email_Address, Website) " & _
                     "VALUES ('" & txtbusname.Text & "', " _
                             & "'" & txtbusaddress.Text & "', " _
                             & "'" & txtno.Text & "', " _
                             & CDbl(txtvat.Text) & ", " _
                             & "'" & txttin.Text & "', " _
                             & "'" & txtlocal.Text & "', " _
                             & "'" & txtemail.Text & "', " _
                             & "'" & txtwebsite.Text & "')"
            'MsgBox(sqlSTR)
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add Business Info")

        End If
        MsgBox("Records successfuly update !!", MsgBoxStyle.Information, "Sales and Inventory")
        ExecuteSQLQuery("SELECT * FROM TBL_GlobalData")
        If sqlDT.Rows.Count > 0 Then
            VAT = sqlDT.Rows(0)("BussVat")
            ParamCompanyName.Value = sqlDT.Rows(0)("BussName")
            ParamCompanyLoc.Value = sqlDT.Rows(0)("BussLocation")
            ParamCompanyContact.Value = sqlDT.Rows(0)("BussContact")
            ParamCompanyTIN.Value = sqlDT.Rows(0)("Tin")
        End If
        Me.Close()
    End Sub

    Private Sub txtvat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvat.TextChanged
        txtvat.Text = str_Filter(txtvat, 48, 57, 0, 0)
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmBUSINESS_INFO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT * FROM TBL_Globaldata"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            txtbusID.Text = sqlDT.Rows(0)("Buss_ID")
            txtbusname.Text = sqlDT.Rows(0)("BussName")
            txtbusaddress.Text = sqlDT.Rows(0)("BussLocation")
            txtvat.Text = sqlDT.Rows(0)("BussVat")
            txtno.Text = sqlDT.Rows(0)("BussContact")
            txttin.Text = sqlDT.Rows(0)("Tin")
            txtlocal.Text = sqlDT.Rows(0)("busslocal").ToString
            txtemail.Text = sqlDT.Rows(0)("email_address").ToString
            txtwebsite.Text = sqlDT.Rows(0)("website").ToString
        End If
        txtbusname.Select()
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged
        txtemail.Text = str_Filter(txtemail, 46, 122, 64, 1)
    End Sub
End Class