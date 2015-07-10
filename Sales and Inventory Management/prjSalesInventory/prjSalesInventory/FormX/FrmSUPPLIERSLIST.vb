Public Class FrmSuppliersList

    Private Sub FrmSuppliersList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub
    Private Sub FrmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '(suppname, suppadd, suppcontact, contactperson) 
        rbsuplist.Checked = True
        lstSuppliers.Visible = False
        lstSupplies.Visible = False
        PictureBox2.Visible = False
        Label4.Visible = False
        lstsupplier.Visible = True
        ' FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"), lstsupplier, 0)
        Audit_Trail(xUser_ID, TimeOfDay, "View Suppliers Profile")
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        If rbsuplist.Checked Then
            sqlSTR = "SELECT Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' " & _
                     "FROM TBL_Suppliers " & _
                     "WHERE replace(replace(suppname,'$.$',''''),'$..$',',') LIKE '%" & R_eplace(txtname.Text) & "%' ORDER BY suppName"
            FillListView(ExecuteSQLQuery(sqlSTR), lstsupplier, 0)
        Else
            sqlSTR = "SELECT Supp_ID as 'Supplier ID', suppName as 'Supplier Name', suppadd as 'Address', suppcontact as 'Contact No', ContactPerson as 'Contact Person' " & _
                     "FROM tbl_suppliers " & _
                     "WHERE SuppName LIKE '%" & txtname.Text & "%'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstSuppliers, 0)
        End If

        grpCat.Visible = False
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub

    Private Sub FrmSuppliersList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me



            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstsupplier.Width = GroupBox1.Width - 10
            .lstsupplier.Height = GroupBox1.Height - 18

            'for suppliers product(s)
            .lstSuppliers.Width = GroupBox1.Width - 14
            .lstSupplies.Width = GroupBox1.Width - 36
            .lstSupplies.Height = (GroupBox1.Height - lstSuppliers.Height) - 60

            .rbsuppro.Left = (GroupBox1.Left + GroupBox1.Width) - (.rbsuppro.Width)
            .rbsuplist.Left = (.lstsupplier.Width - .rbsuppro.Width) - 96

            '.RBALL.Left = (GroupBox1.Left + GroupBox1.Width) - (.RBALL.Width)
            '.rbcatitemlist.Left = (.RBALL.Left - .rbcatitemlist.Width) - 2
            '.RBCat.Left = (.rbcatitemlist.Left - .RBCat.Width) - 2
            '.RBGroup.Left = (.RBCat.Left - .RBGroup.Width) - 2
            'MsgBox(rbsuplist.Left)
            'MsgBox(lstsupplier.Width - .rbsuppro.Left)
        End With

    End Sub


    Private Sub cmdcncel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = 13 Then
            CmdSearch_Click(0, AcceptButton)
        End If
    End Sub

    Private Sub txtname_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtname.MouseDown

    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub rbsuplist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsuplist.CheckedChanged
        If rbsuplist.Checked Then
            With MDIMain
                .cmdEdit.Enabled = True
                .cmdHome.Enabled = True
                .cmdNew.Enabled = True
                .cmdDelete.Enabled = True
                .cmdRefresh.Enabled = True
            End With
            lstSuppliers.Visible = False
            lstSupplies.Visible = False
            PictureBox2.Visible = False
            Label4.Visible = False
            lstsupplier.Visible = True
            FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"), lstsupplier, 0)

        End If
    End Sub

    Private Sub rbsuppro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsuppro.CheckedChanged
        If rbsuppro.Checked Then
            With MDIMain
                .cmdEdit.Enabled = False
                .cmdHome.Enabled = True
                .cmdNew.Enabled = False
                .cmdDelete.Enabled = False
                .cmdRefresh.Enabled = True

            End With
            FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', suppName as 'Supplier Name', Replace(Replace(suppadd,'$.$',''''),'$..$',',') as 'Address', suppcontact as 'Contact No', ContactPerson as 'Contact Person' FROM tbl_suppliers ORDER BY suppName ASC"), lstSuppliers, 1)
            lstSuppliers.Visible = True
            lstSupplies.Visible = True
            PictureBox2.Visible = True
            Label4.Visible = True
            lstsupplier.Visible = False
        End If
    End Sub

    Private Sub lstSuppliers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSuppliers.Click
        sqlSTR = "SELECT Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number' FROM TBL_Category_Item_File, TBL_Category_File WHERE TBL_Category_Item_File.Item_ID IN " & _
                 "(SELECT TBL_Suppliers_Product.Item_ID FROM TBL_Suppliers_Product WHERE Supp_ID = " & lstSuppliers.FocusedItem.Text & ") AND TBL_Category_File.Catg_ID = TBL_Category_Item_File.Catg_ID " & _
                 " ORDER BY Item_Name ASC"
        FillListView(ExecuteSQLQuery(sqlSTR), lstSupplies, 0)
    End Sub

    Private Sub lstSuppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSuppliers.SelectedIndexChanged

    End Sub
End Class

