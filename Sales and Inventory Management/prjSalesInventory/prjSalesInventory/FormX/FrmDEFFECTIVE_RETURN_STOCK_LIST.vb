Public Class FrmDEFFECTIVE_RETURN_STOCK_LIST
    Private Sub FrmDEFFECTIVE_RETURN_STOCK_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(FrmDEFFECTIVE_RETURN_ADD.txtpo.Text)
        'MsgBox(FrmDEFFECTIVE_RETURN_ADD.txtpo2.Text)
        sqlSTR = "SELECT DISTINCT TBL_Deffective_PO_Details.Item_ID as 'Item ID', TBL_Deffective_PO_Details.Purchase_Detail_ID as 'Detail ID', " & _
                 "Replace(Replace(TBL_Category_Item_File.Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Purchase_Detail.Item_QTY as 'Current QTY', " & _
                 "TBL_Purchase_Detail.Item_Price as 'Price', TBL_Category_Item_File.Item_Barcode as 'Barcode', " & _
                 "TBL_Deffective_PO_Details.Def_QTY as 'Deffective Qty', TBL_Deffective_PO_Details.Unit as 'Measure' " & _
                 "FROM (((TBL_Deffective_PO_Details " & _
                 "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                 "INNER JOIN TBL_Deffective_PO ON TBL_Deffective_PO_Details.Purchase_ID = TBL_Deffective_PO.Purchase_ID " & _
                 "AND TBL_Deffective_PO.DEF_PO_ID = TBL_Deffective_PO_Details.DEF_PO_ID ) " & _
                 "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_ID = TBL_Purchase_Detail.Purchase_ID " & _
                 "AND TBL_Deffective_PO_Details.Item_ID = TBL_Purchase_Detail.Item_ID) " & _
                 "WHERE TBL_Deffective_PO.DEF_PO_ID =" & FrmDEFFECTIVE_RETURN_ADD.txtpo.Text & _
                 " AND TBL_Deffective_PO_Details.Purchase_Detail_ID NOT IN " & _
                 "(SELECT Purchase_Detail_ID FROM TBL_Deffective_PO_Return_Details WHERE Return_ID =" & FrmDEFFECTIVE_RETURN_ADD.txtpo.Text & " AND Purchase_ID= " & FrmDEFFECTIVE_RETURN_ADD.txtpo2.Text & ")" & _
                 " AND TBL_Deffective_PO_Details.DEF_QTY > 0"

        FillListView(ExecuteSQLQuery(sqlSTR), lstitems, 1)
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        With FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD
            If Me.lstitems.Items.Count > 0 Then
                Me.lstitems.Focus()
                .txtid.Text = Me.lstitems.FocusedItem.Text
                .txtdtl.Text = Me.lstitems.FocusedItem.SubItems(1).Text
                .txtname.Text = Me.lstitems.FocusedItem.SubItems(2).Text
                .txtdesc.Text = Me.lstitems.FocusedItem.SubItems(3).Text
                .txtprice.Text = Me.lstitems.FocusedItem.SubItems(4).Text
                .txtbarcode.Text = Me.lstitems.FocusedItem.SubItems(5).Text
                .txtdefqty.Text = Me.lstitems.FocusedItem.SubItems(6).Text
                .txtunit.Text = Me.lstitems.FocusedItem.SubItems(7).Text
            End If
            Me.lstitems.Focus()
        End With
        Me.Close()
    End Sub
End Class