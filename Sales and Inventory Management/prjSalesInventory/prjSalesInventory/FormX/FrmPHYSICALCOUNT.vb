Public Class FrmPhysicalCount

    Private Sub FrmPhysicalCount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FILLComboBox("SELECT Catg_ID, Catg_Name FROM TBL_Category_File", cbclass)
        refresh_list()
        Audit_Trail(xUser_ID, TimeOfDay, "View Physical Counting" )

    End Sub

    Private Sub FrmPhysicalCount_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstphysical.Width = GroupBox1.Width - 10
            .lstphysical.Height = GroupBox1.Height - 18
            cbclass.Left = (GroupBox1.Left + GroupBox1.Width) - (.cbclass.Width) - 4
            .Label3.Left = (.cbclass.Left - .Label3.Width) - 2
            '.RBALL.Left = (GroupBox1.Left + GroupBox1.Width) - (.RBALL.Width)
            '.rbcatitemlist.Left = (.RBALL.Left - .rbcatitemlist.Width) - 2
            '.RBCat.Left = (.rbcatitemlist.Left - .RBCat.Width) - 2
        End With
    End Sub

    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        'FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Item_Name as 'Item Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM TBL_Stocks_Balances WHERE Catg_ID =" & Split(cbclass.Text, " - ")(0) & " ORDER BY Item_Name"), lstphysical, 0)
        'MsgBox(Split(cbclass.Text, " - ")(0))

        For i = 0 To lstphysical.Items.Count - 1
            If Int(lstphysical.Items(i).SubItems(5).Text) <= 0 Then
                lstphysical.Items(i).ForeColor = Color.Brown
            Else
                lstphysical.Items(i).ForeColor = Color.Black
            End If
        Next

    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged
        refresh_list()
    End Sub

    Private Sub refresh_list()
        ' sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_name as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Category_Item_File.Item_Barcode AS 'Barcode', TBL_Category_Item_File.Item_Reorder_Point AS 'Reorder Point', TBL_Stocks_Balances.Item_QTY as 'Quantity' " & _
        '           "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
        '           "WHERE Catg_ID =" & Split(cbclass.Text, " - ")(0) & "ORDER BY TBL_Category_Item_File.Item_name"
        ' FillListView(ExecuteSQLQuery(sqlSTR), lstphysical, 0)

        sqlSTR = "SELECT P_ID AS 'P_ID', P_Date as 'DATE', Lastname + ', ' + Firstname + ' ' + Middlename AS ' Username' " & _
                 "FROM TBL_Physical_Count " & _
                 "INNER JOIN TBL_Users ON TBL_Physical_Count.User_ID = TBL_Users.User_ID " & _
                 " WHERE P_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND P_Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstphysical, 0)
    End Sub

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged
        refresh_list()
    End Sub
End Class