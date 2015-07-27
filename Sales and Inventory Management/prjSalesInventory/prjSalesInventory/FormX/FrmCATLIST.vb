Public Class FrmCatList


    Private Sub FrmCatList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub

    Private Sub FrmCatList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Audit_Trail(xUser_ID, TimeOfDay, "View Product Listing")
    End Sub

    Private Sub RBCat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBCat.CheckedChanged
        If RBCat.Checked Then
            With MDIMain
                .cmdEdit.Enabled = False
                .cmdPrint.Enabled = False
                .cmdSearch.Enabled = True
                '     .ToolStripEdit.Enabled = False
                '     .ToolStripPrint.Enabled = False
            End With
            grpcatitem.Visible = False
            'GroupBox1.Visible = True
            FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), lstCat, 0)
        End If
    End Sub

    Private Sub RBALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBALL.CheckedChanged
        If RBALL.Checked Then
            'MDIREFRESH()
            With MDIMain
                ' .ToolStripDelete.Enabled = False
                .cmdDelete.Enabled = False
                .cmdSearch.Enabled = True
            End With
            grpcatitem.Visible = False
            'GroupBox1.Visible = True
            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', TBL_Category_Item_File.Catg_ID as 'Category ID', Group_Name AS 'Group' ,replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Org_Price as 'Price', Item_Price as 'Price (VAT 12%)', Unit_Measure as 'Measure' " & _
                                         "FROM TBL_Category_Item_File " & _
                                         "INNER JOIN TBL_Category_File ON TBL_Category_Item_File.Catg_ID = TBL_Category_File.Catg_ID " & _
                                         "INNER JOIN TBL_Group ON TBL_Category_File.Group_ID = TBL_Group.Group_ID " & _
                                         "ORDER BY Item_Name"), lstCat, 0)
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
        RBALL.Enabled = True
        RBCat.Enabled = True
        rbcatitemlist.Enabled = True
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        If RBCat.Checked Then

            sqlSTR = "SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' " & _
                     "FROM tbl_Category_File " & _
                     "WHERE LEFT(Catg_Name," & Len(txtcatname.Text) & ")  ='" & txtcatname.Text & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstCat, 1)
        ElseIf RBALL.Checked Then
            ' sqlSTR = "SELECT Item_ID as 'ID', Catg_ID as 'Category ID', Item_Name as 'Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Price as 'Price' " & _
            '          "FROM TBL_Category_Item_File " & _
            '          "WHERE Item_Name LIKE '%" & txtcatname.Text & "%'"
            sqlSTR = "SELECT Item_ID as 'ID', Catg_ID as 'Category ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Price as 'Price' " & _
                     "FROM TBL_Category_Item_File " & _
                     "WHERE LEFT(Item_Name," & R_eplace(Len(txtcatname.Text)) & ") ='" & R_eplace(txtcatname.Text) & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstCat, 1)
        ElseIf rbcatitemlist.Checked Then
            ' sqlSTR = "SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' " & _
            '         "FROM tbl_Category_File " & _
            '         "WHERE Catg_Name LIKE '%" & txtcatname.Text & "%'"
            sqlSTR = "SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' " & _
                     "FROM tbl_Category_File " & _
                     "WHERE LEFT(Catg_Name," & Len(txtcatname.Text) & ")= '" & txtcatname.Text & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstCategory, 1)
        End If

        grpCat.Visible = False
        RBALL.Enabled = True
        RBCat.Enabled = True
        rbcatitemlist.Enabled = True
    End Sub

    Private Sub rbcatitemlist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcatitemlist.CheckedChanged
        If rbcatitemlist.Checked Then
            MDIREFRESH()
            With MDIMain
                .cmdDelete.Enabled = False
                .cmdSearch.Enabled = False
                ' .ToolStripDelete.Enabled = False
            End With
            grpcatitem.Visible = True
            grpCat.BringToFront()
            FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File  "), lstCategory, 0)
            lstCategory.Focus()
            lstCategory.Select()
            'GroupBox1.Visible = False
        End If

    End Sub

    Private Sub lstCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCategory.Click
        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Item Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & lstCategory.FocusedItem.Text & " ORDER BY Item_Name"), lstItems, 1)
    End Sub

    Private Sub FrmCatList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstCat.Width = GroupBox1.Width - 10
            .lstCat.Height = GroupBox1.Height - 18
            .RBALL.Left = (GroupBox1.Left + GroupBox1.Width) - (.RBALL.Width)
            .rbcatitemlist.Left = (.RBALL.Left - .rbcatitemlist.Width) - 2
            .RBCat.Left = (.rbcatitemlist.Left - .RBCat.Width) - 2
            .RBGroup.Left = (.RBCat.Left - .RBGroup.Width) - 2
            '////

            grpcatitem.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            grpcatitem.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstCategory.Width = grpcatitem.Width - 28
            .lstItems.Width = grpcatitem.Width - 28
            .lstItems.Height = grpcatitem.Height - (lstCategory.Height + 23)

        End With
    End Sub

    Private Sub RBGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBGroup.CheckedChanged
        If RBGroup.Checked Then
            grpcatitem.Visible = False
            With MDIMain
                .cmdEdit.Enabled = True
                .cmdPrint.Enabled = True
                .cmdDelete.Enabled = False
                .cmdSearch.Enabled = False
                .cmdPrint.Enabled = False
                .cmdRefresh.Enabled = True
                '     .ToolStripEdit.Enabled = False
                '     .ToolStripPrint.Enabled = False
            End With
            'GroupBox1.Visible = True
            FillListView(ExecuteSQLQuery("SELECT Group_ID AS 'ID', Group_Name AS 'Name', Group_Description AS 'Description' FROM TBL_Group"), lstCat, 0)
        End If
    End Sub
End Class