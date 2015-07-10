Public Class FrmPURCHASEORDERLIST

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmPURCHASEORDERLIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT  TBL_Category_File.Catg_ID, TBL_Category_File.Catg_Name " & _
                 "FROM TBL_Category_File WHERE TBL_Category_File.Catg_ID IN " & _
                 "(SELECT  Catg_ID FROM TBL_Suppliers_Product WHERE Supp_ID=" & Split(FrmPURCHASEORDERADD.cmbsupplier.Text, " - ")(0) & ")"
        FILLComboBox(sqlSTR, cmblist)
        listitems.Items.Clear()
        'listitems.Items(0).ForeColor = Color.Beige

    End Sub

    Private Sub cmblist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblist.SelectedIndexChanged
        sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'Item ID', Replace(Replace(TBL_Category_Item_File.Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Suppliers_Product.Item_Price as 'Price', TBL_Category_Item_File.Item_Barcode as 'Barcode', TBL_Category_Item_File.Unit_Measure as 'Measure' " & _
                 "FROM ((TBL_Category_Item_File " & _
                 "INNER JOIN TBL_Suppliers_Product ON TBL_Category_Item_File.Item_ID = TBL_Suppliers_Product.Item_ID) " & _
                 "INNER JOIN TBL_Suppliers ON TBL_Suppliers_Product.Supp_ID = TBL_Suppliers.Supp_ID) " & _
                 "WHERE TBL_Suppliers.Supp_ID = " & Split(FrmPURCHASEORDERADD.cmbsupplier.Text, " - ")(0) & _
                 " AND tbl_Category_Item_File.Catg_ID =" & Split(cmblist.Text, " - ")(0)
        FillListView(ExecuteSQLQuery(sqlSTR), listitems, 0)
        'FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Item_Name as 'Name', Item_Description as 'Description', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & Split(cmblist.Text, " - ")(0)), listitems, 1)
    End Sub

    Private Sub CmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSelect.Click
        'listitems.Focus()
        If listitems.Items.Count > 0 Then
            listitems.Focus()
            FrmPURCHASEORDERDATA.txtid.Text = listitems.FocusedItem.Text
            FrmPURCHASEORDERDATA.txtname.Text = listitems.FocusedItem.SubItems(1).Text
            FrmPURCHASEORDERDATA.txtdesc.Text = listitems.FocusedItem.SubItems(2).Text
            FrmPURCHASEORDERDATA.txtprice.Text = listitems.FocusedItem.SubItems(3).Text
            FrmPURCHASEORDERDATA.txtbarcode.Text = listitems.FocusedItem.SubItems(4).Text
            FrmPURCHASEORDERDATA.txtunit.Text = listitems.FocusedItem.SubItems(5).Text
        Else
            MsgBox("No Item Selected !", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class