Public Class FrmCatITEMList

    Private Sub FrmCatITEMList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub

    Private Sub FrmCatITEMList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Audit_Trail(xUser_ID, TimeOfDay, "View Supplies and Property File")
        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), lstCategory, 1)
        lstCategory.Focus()
        lstCategory.Select()
        'Call lstCategory_Click()
    End Sub

    Private Sub lstCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCategory.Click
        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Item_Name as 'Item Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & lstCategory.FocusedItem.Text), lstItems, 1)
        'lstItems.Focus()
    End Sub

    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged

    End Sub

    Private Sub FrmCatITEMList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstCategory.Width = GroupBox1.Width - 28
            .lstCategory.Height = (GroupBox1.Height / 2) - 53

            .lstItems.Width = GroupBox1.Width - 28
            .lstItems.Height = (GroupBox1.Height - lstCategory.Height) - 25
        End With

    End Sub
End Class