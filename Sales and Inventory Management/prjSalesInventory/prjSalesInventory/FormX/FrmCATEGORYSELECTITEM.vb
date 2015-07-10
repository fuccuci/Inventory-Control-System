Public Class FrmCATEGORYSELECTitem
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCATEGORYSELECTitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsearch.Focus()
        txtsearch.Text = ""
        lstItems.Items.Clear()
        FILLComboBox("SELECT Catg_ID, Catg_Name FROM tbl_Category_File ORDER BY tbl_Category_File.Catg_Name ASC ", cmbCategory)
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        'MsgBox(cmbCategory.Left)
        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name' FROM tbl_Category_Item_File WHERE Catg_ID =" & Split(cmbCategory.Text, " - ")(0)), lstItems, 1)
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        Dim i As Integer, x As Integer
        'If cmbCategory.Text = "" Then
        ' MsgBox("No category selected !!", MsgBoxStyle.Information, "Sales and Inventory")
        ' Exit Sub
        ' End If
        'With FrmADDSUPPLIER_ITEM
        ' If lstItems.Items.Count > 0 Then
        ' lstItems.Focus()
        ' .txtcategory.Text = Split(cmbCategory.Text, " - ")(0)
        ' .txtid.Text = lstItems.FocusedItem.Text
        ' .txtname.Text = lstItems.FocusedItem.SubItems(1).Text
        ' .txtprice.Text = lstItems.FocusedItem.SubItems(2).Text
        ' End If
        ' Me.Close()
        ' End With
        If lstItems.Items.Count > 0 Then
            lstItems.Focus()
            With FrmAddSupplier.lstProducts
                For i = 0 To .Items.Count - 1
                    'MsgBox(lstItems.FocusedItem.SubItems(1).Text)
                    If .Items(i).SubItems(1).Text = lstItems.FocusedItem.SubItems(1).Text Then
                        MsgBox("Current details is on the list !!", MsgBoxStyle.Information, "Sales and Inventory")
                        Exit Sub
                    End If
                Next

                For i = 0 To lstItems.Items.Count - 1
                    If lstItems.Items(i).Selected Then
                        '.Items.Add(Split(cmbCategory.Text, " - ")(0))
                        .Items.Add(lstItems.Items(i).Text)
                        For x = 0 To .Items.Count - 1
                            .Items(x).SubItems.Add(lstItems.Items(i).SubItems(1).Text)
                            .Items(x).SubItems.Add(lstItems.Items(i).SubItems(2).Text)
                        Next

                    End If
                Next
            End With
        End If

        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        'FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name' FROM tbl_Category_Item_File WHERE Catg_ID =" & Split(cmbCategory.Text, " - ")(0)), lstItems, 1)
        lstItems.Items.Clear()
        If Len(txtsearch.Text) > 0 Then
            sqlSTR = "SELECT * FROM tbl_Category_Item_File WHERE Item_Name LIKE '%" & R_eplace(txtsearch.Text) & "%' ORDER BY Item_Name"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                With lstItems
                    For i = 0 To sqlDT.Rows.Count - 1
                        .Items.Add(sqlDT.Rows(i)("Catg_ID"), 0)
                        .Items((.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_ID")))
                        .Items((.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                        '.Items((.Items.Count - 1)).SubItems.Add(txtprice.Text)
                        '.Items((.Items.Count - 1)).SubItems.Add(txtqty.Text)
                    Next
                End With

            End If
        End If
    End Sub
End Class