Public Class FrmAddSupplier
    Dim stockID As Integer
    Dim hOldID As Integer
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim i As Integer
        If txtname.Text = "" And txtaddress.Text = "" And txtcontact.Text = "" And txtCperson.Text = "" Then
            MsgBox("No Corresponding Data !", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Edit" Then
            'Replace(Replace(Replace(TextBox1.Text, "'", "$.$"), ",", "$..$"), "`", "")
            sqlSTR = "UPDATE tbl_suppliers SET suppname ='" & R_eplace(txtname.Text) & "', " _
                                            & "suppadd ='" & R_eplace(txtaddress.Text) & "', " _
                                            & "suppcontact ='" & R_eplace(txtcontact.Text) & "', " _
                                            & "contactperson ='" & R_eplace(txtCperson.Text) & "', " _
                                            & "supplocal ='" & txtlocal.Text & "' WHERE supp_id =" & stockID
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Suppliers Products ")
        Else
            sqlSTR = "INSERT INTO tbl_suppliers (suppname, suppadd, suppcontact, contactperson, supplocal) VALUES ('" & R_eplace(txtname.Text) & "', " _
                                        & "'" & R_eplace(txtaddress.Text) & "', " _
                                        & "'" & R_eplace(txtcontact.Text) & "', " _
                                        & "'" & R_eplace(txtCperson.Text) & "', " _
                                        & "'" & txtlocal.Text & "')"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Suppliers Products ")
        End If


        If Split(Me.Text, " - ")(1) = "Edit" Then
            ExecuteSQLQuery("DELETE FROM TBL_Suppliers_Product WHERE Supp_ID =" & txtid.Text)
            For i = 0 To lstProducts.Items.Count - 1
                'MsgBox(lstProducts.Items(i).SubItems(2).Text)
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstProducts.Items(i).SubItems(1).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    sqlSTR = "INSERT INTO TBL_Suppliers_Product (Supp_ID, Catg_ID, Item_ID, Prod_Name, Item_Price) VALUES (" & txtid.Text & ", " _
                                         & lstProducts.Items(i).Text & ", " _
                                         & lstProducts.Items(i).SubItems(1).Text & ", " _
                                         & "'" & R_eplace(lstProducts.Items(i).SubItems(2).Text) & "', " _
                                         & sqlDT.Rows(0)("Item_Price") & ")"

                    '& IIf(lstProducts.Items(i).SubItems(3).Text = "", 0, lstProducts.Items(i).SubItems(3).Text) & ")"

                End If
                ExecuteSQLQuery(sqlSTR)
            Next
        Else
            sqlSTR = "SELECT Supp_ID FROM TBL_Suppliers ORDER BY Supp_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            hOldID = sqlDT.Rows(0)("Supp_ID") ' When user add new Get Current ID  
            For i = 0 To lstProducts.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstProducts.Items(i).SubItems(1).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    sqlSTR = "INSERT INTO TBL_Suppliers_Product (Supp_ID, Catg_ID, Item_ID, Prod_Name, Item_Price) VALUES (" & hOldID & ", " _
                                         & lstProducts.Items(i).Text & ", " _
                                         & lstProducts.Items(i).SubItems(1).Text & ", " _
                                         & "'" & lstProducts.Items(i).SubItems(2).Text & "', " _
                                         & sqlDT.Rows(0)("Item_Price") & ")"
                    '& lstProducts.Items(i).SubItems(3).Text & ")"
                End If
                ExecuteSQLQuery(sqlSTR)
            Next
        End If

        MsgBox("Record Sucessfuly Update", MsgBoxStyle.Information)
        'FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppName,'$.$','''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$','''),'$..$',',') as 'Address', suppcontact as 'Contact No', replace(replace(ContactPerson,'$.$','''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"), FrmSuppliersList.lstsupplier, 0)
        FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"), FrmSuppliersList.lstsupplier, 0)
        Me.Close()
    End Sub

    Private Sub FrmAddSupplier_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Supplier Profile"
    End Sub

    Private Sub FrmAddSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Split(Me.Text, " - ")(1) = "Edit" Then
            stockID = globalID
            sqlSTR = "SELECT * FROM tbl_suppliers WHERE supp_ID =" & stockID
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtid.Text = stockID
                txtname.Text = R_Change(sqlDT.Rows(0)("SuppName"))
                txtaddress.Text = R_Change(sqlDT.Rows(0)("SuppAdd"))
                txtCperson.Text = R_Change(sqlDT.Rows(0)("ContactPerson"))
                txtcontact.Text = R_Change(sqlDT.Rows(0)("SuppContact"))
                txtlocal.Text = sqlDT.Rows(0)("supplocal").ToString
            End If
            FillListView(ExecuteSQLQuery("SELECT Catg_ID, Item_ID as 'ID', Replace(Replace(Prod_Name,'$.$',''''),'$..$',',') as 'Name' FROM TBL_Suppliers_Product WHERE Supp_ID =" & txtid.Text), lstProducts, 1)
        Else
            txtid.Text = ""
            txtname.Text = ""
            txtaddress.Text = ""
            txtCperson.Text = ""
            txtcontact.Text = ""
            txtlocal.Text = ""
            lstProducts.Items.Clear()
        End If
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        FrmCATEGORYSELECTitem.ShowDialog()
        ' FrmADDSUPPLIER_ITEM.Show()
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If lstProducts.Items.Count > 0 Then
            lstProducts.Focus()
            lstProducts.FocusedItem.Remove()
        End If
    End Sub

    Private Sub txtCperson_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCperson.KeyDown
        'MsgBox(e.KeyCode)
    End Sub

    Private Sub txtCperson_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCperson.TextChanged
        txtCperson.Text = str_Filter(txtCperson, 65, 122, 32, 100)
    End Sub

    Private Sub txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged
        txtaddress.Text = filter_Special_Char(txtaddress.Text)
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        'txtname.Text = filter_Special_Char(str_Filter(txtname, 45, 122, 32, 150))
        txtname.Text = filter_Special_Char(str_Filter(txtname, 45, 122, 32, 150))
    End Sub
End Class