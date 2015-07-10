Public Class FrmPENDING_STOCK_LIST

    Private Sub FrmPENDING_STOCK_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sqlSTR = "SELECT Pending_ID as 'Pending ID', TBL_Pending_Item.Item_ID as 'Item ID', Item_Name as 'Name', Item_Description as 'Item_Description',Pending_Date as 'Date', Item_QTY as 'Quantity' " & _
        '         "FROM TBL_Pending_Item " & _
        '         "INNER JOIN TBL_Category_Item_File ON TBL_Pending_Item.Item_ID = TBL_Category_Item_File.Item_ID " & _
        '         "WHERE Returnx = 'No'"

        sqlSTR = "SELECT Pending_ID as 'Pending ID', TBL_Pending_Item.Item_ID as 'Item ID', " & _
                 "Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number', " & _
                 "Pending_Date as 'Date', Item_QTY as 'Quantity' " & _
                 "FROM TBL_Pending_Item " & _
                 "INNER JOIN TBL_Category_Item_File ON TBL_Pending_Item.Item_ID = TBL_Category_Item_File.Item_ID " & _
                 "WHERE TBL_Pending_Item.Pending_ID NOT IN (SELECT Pending_ID FROM TBL_Deffective_PO_Details) "

        FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
        'For x = 0 To lstdeffect.Items.Count - 1
        ' sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details WHERE Pending_ID =" & lstdeffect.Items(x).Text
        ' ExecuteSQLQuery(sqlSTR)
        ' If sqlDT.Rows.Count > 0 Then
        ' lstdeffect.Items(x).ForeColor = Color.Brown
        ' Else
        ' lstdeffect.Items(x).ForeColor = Color.Black
        ' End If
        ' Next
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        'Pending_ID = 0
        Me.Close()
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        If lstdeffect.Items.Count > 0 Then
            lstdeffect.Focus()
            Pending_ID = lstdeffect.FocusedItem.Text
            Pending_Item_ID = lstdeffect.FocusedItem.SubItems(1).Text
            Pending_QTY = lstdeffect.FocusedItem.SubItems(5).Text
            sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date' " & _
                     "FROM ((TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID) " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                     "WHERE TBL_Purchase_Detail.Item_ID =" & lstdeffect.FocusedItem.SubItems(1).Text & _
                     " ORDER BY TBL_Purchase_Order.Purchase_ID"
            FillListView(ExecuteSQLQuery(sqlSTR), FrmDEFFECTIVE_PO_LIST.lstpo, 0)
            Me.Close()
        End If
    End Sub
End Class