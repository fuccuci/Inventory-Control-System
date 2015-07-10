Public Class FrmSUPPLIERSPRODUCT

    Private Sub FrmSUPPLIERSPRODUCT_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MDIREFRESH()
        MDIDISABLED()
    End Sub
    Private Sub FrmSUPPLIERSPRODUCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', suppName as 'Supplier Name', suppadd as 'Address', suppcontact as 'Contact No', ContactPerson as 'Contact Person' FROM tbl_suppliers ORDER BY suppName ASC"), lstSuppliers, 1)
        MDIREFRESH()
        With MDIMain
            '.cmdNew.Enabled = False
            '.cmdEdit.Enabled = False
            '.cmdDelete.Enabled = False
            ' .ToolStripNew.Enabled = False
            ' .ToolStripEdit.Enabled = False
            ' .ToolStripDelete.Enabled = False
        End With
        Audit_Trail(xUser_ID, TimeOfDay, "View Suppliers Product Listing")
    End Sub

    Private Sub lstSuppliers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSuppliers.Click
        sqlSTR = "SELECT Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number' FROM TBL_Category_Item_File, TBL_Category_File WHERE TBL_Category_Item_File.Item_ID IN " & _
                 "(SELECT TBL_Suppliers_Product.Item_ID FROM TBL_Suppliers_Product WHERE Supp_ID = " & lstSuppliers.FocusedItem.Text & ") AND TBL_Category_File.Catg_ID = TBL_Category_Item_File.Catg_ID " & _
                 " ORDER BY Item_Name ASC"
        FillListView(ExecuteSQLQuery(sqlSTR), lstSupplies, 0)
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        sqlSTR = "SELECT Supp_ID as 'Supplier ID', suppName as 'Supplier Name', suppadd as 'Address', suppcontact as 'Contact No', ContactPerson as 'Contact Person' " & _
                 "FROM tbl_suppliers " & _
                 "WHERE SuppName LIKE '%" & txtname.Text & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstSuppliers, 0)
        grpCat.Visible = False
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub

    Private Sub lstSuppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSuppliers.SelectedIndexChanged

    End Sub

    Private Sub FrmSUPPLIERSPRODUCT_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 57)
            .lstSuppliers.Width = GroupBox1.Width - 14
            .lstSupplies.Width = GroupBox1.Width - 36
            .lstSupplies.Height = (GroupBox1.Height - lstSuppliers.Height) - 60
            '.lstCategory.Width = GroupBox1.Width - 28
            '.lstCategory.Height = (GroupBox1.Height / 2) - 53
        End With

    End Sub

    Private Sub lstSupplies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSupplies.SelectedIndexChanged

    End Sub
End Class