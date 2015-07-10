Public Class FrmDEFFECTIVE_STOCKS_LIST

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmDEFFECTIVE_STOCKS_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MsgBox("A")
        sqlSTR = "SELECT TBL_Purchase_Detail.Item_ID as 'ID', TBL_Purchase_Detail.Purchase_Detail_ID as 'Detail ID', Replace(Replace(TBL_Category_Item_File.Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Purchase_Detail.Item_Price as 'Price', TBL_Category_Item_File.Item_Barcode as 'Barcode', TBL_Purchase_Detail.Item_QTY as 'Quantity', TBL_Purchase_Detail.Unit_Measure as 'Measure'" & _
                 " FROM TBL_Purchase_Detail INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                 " WHERE TBL_Purchase_Detail.Purchase_ID = " & FrmDEFFECTIVE_STOCKS_ADD.txtpo2.Text
        FillListView(ExecuteSQLQuery(sqlSTR), lstitems, 1)
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        'With FrmDEFFECTIVE_STOCKS_ADD
        ' .lstitems.Items.Add(Me.lstitems.FocusedItem.Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(1).Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(2).Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(3).Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(4).Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(6).Text)
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add("")
        ' .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(Me.lstitems.FocusedItem.SubItems(7).Text)
        ' End With
        With FrmDEFFECTIVE_STOCKS_DATA_ADD
            If Me.lstitems.Items.Count > 0 Then
                Me.lstitems.Focus()
                .txtid.Text = Me.lstitems.FocusedItem.Text
                .txtdtl.Text = Me.lstitems.FocusedItem.SubItems(1).Text
                .txtname.Text = Me.lstitems.FocusedItem.SubItems(2).Text
                .txtdesc.Text = Me.lstitems.FocusedItem.SubItems(3).Text
                .txtprice.Text = Me.lstitems.FocusedItem.SubItems(4).Text
                .txtbarcode.Text = Me.lstitems.FocusedItem.SubItems(5).Text
                .txtqty.Text = Me.lstitems.FocusedItem.SubItems(6).Text
                .txtunit.Text = Me.lstitems.FocusedItem.SubItems(7).Text
            End If
        End With
        Me.Close()
    End Sub
End Class