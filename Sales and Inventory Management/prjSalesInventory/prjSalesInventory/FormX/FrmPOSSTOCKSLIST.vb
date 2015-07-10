Public Class FrmPOSSTOCKSLIST

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmPOSSTOCKSLIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsearch.Text = ""
        With FrmPOS_CHOICES
            If .rbdefect.Checked Then
                txtsearch.Enabled = False
                lststocks.Items.Clear()
                sqlSTR = "SELECT TBL_Pending_Item.Pending_ID AS 'Pending ID',  TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_name,'$.$',''''),'$..$',',') as 'Name', " & _
                         "TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.item_price as 'Price', " & _
                         "TBL_Deffective_PO_Return_Details.Return_QTY - TBL_Sales_Sold_Detail.Added_QTY as 'Quantity' " & _
                         "FROM TBL_Pending_Item " & _
                         "INNER JOIN TBL_Deffective_PO_Details ON TBL_Pending_Item.Pending_ID = TBL_Deffective_PO_Details.Pending_ID " & _
                         "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO_Details.DEF_PO_ID = TBL_Deffective_PO_Return.DEF_PO_ID " & _
                         "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                         "INNER JOIN TBL_Sales_Receipt ON TBL_Sales_Receipt.Receipt_ID = TBL_Pending_Item.Receipt_ID " & _
                         "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                         " AND  TBL_Sales_Sold_Detail.Sales_Detail_ID = TBL_Pending_Item.Sales_Detail_ID " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                         "WHERE TBL_Pending_Item.Receipt_ID =" & FrmPOSVIEW.txtreceiptid.Text & " AND Returnx ='No'"
                FillListView(ExecuteSQLQuery(sqlSTR), lststocks, 0)
            Else
                lststocks.Items.Clear()
                txtsearch.Enabled = True
                sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.item_price as 'Price', TBL_Stocks_Balances.Item_QTY as 'Quantity' " & _
                         "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID "
                FillListView(ExecuteSQLQuery(sqlSTR), lststocks, 1)
            End If
        End With
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        With FrmPOSADD
            If lststocks.Items.Count > 0 Then
                lststocks.Focus()
                If FrmPOS_CHOICES.rbdefect.Checked Then
                    .txtpendingID.Text = lststocks.FocusedItem.Text
                    .txtid.Text = lststocks.FocusedItem.SubItems(1).Text
                    .txtname.Text = lststocks.FocusedItem.SubItems(2).Text
                    .txtdesc.Text = lststocks.FocusedItem.SubItems(3).Text
                    .txtprice.Text = lststocks.FocusedItem.SubItems(4).Text
                    .txt_QTYi.Text = lststocks.FocusedItem.SubItems(5).Text
                    .txtqty.Text = lststocks.FocusedItem.SubItems(5).Text
                ElseIf FrmPOS_CHOICES.rbNew.Checked Then
                    .txtid.Text = lststocks.FocusedItem.Text
                    .txtname.Text = lststocks.FocusedItem.SubItems(1).Text
                    .txtdesc.Text = lststocks.FocusedItem.SubItems(2).Text
                    .txtprice.Text = lststocks.FocusedItem.SubItems(3).Text
                    .txt_QTYi.Text = lststocks.FocusedItem.SubItems(4).Text
                    .txtqty.Text = lststocks.FocusedItem.SubItems(4).Text
                End If
                .ShowDialog()
            End If
        End With
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        With FrmPOS_CHOICES
            If .rbNew.Checked Then
                sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.item_price as 'Price', TBL_Stocks_Balances.Item_QTY as 'Quantity' " & _
                         "FROM TBL_category_item_file " & _
                         "INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                         "WHERE TBL_Category_Item_File.Item_Name LIKE '%" & R_eplace(txtsearch.Text) & "%'"
                FillListView(ExecuteSQLQuery(sqlSTR), lststocks, 1)
            End If
        End With
    End Sub
End Class