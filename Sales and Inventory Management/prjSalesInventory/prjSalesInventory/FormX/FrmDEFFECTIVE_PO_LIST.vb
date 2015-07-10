Public Class FrmDEFFECTIVE_PO_LIST

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmDEFFECTIVE_PO_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date'" & _
                 " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'" & _
                 " ORDER BY Purchase_ID"
        FillListView(ExecuteSQLQuery(sqlSTR), lstpo, 0)
        Pending_ID = 0
    End Sub

    Private Sub dtpurchased_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpurchased.ValueChanged
        sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date'" & _
                 " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'" & _
                 " ORDER BY Purchase_ID"
        FillListView(ExecuteSQLQuery(sqlSTR), lstpo, 0)
        Pending_ID = 0
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        If lstpo.Items.Count > 0 Then
            lstpo.Focus()
            With FrmDEFFECTIVE_STOCKS_ADD
                .txtpo.Text = lstpo.FocusedItem.Text
                .txtpo2.Text = lstpo.FocusedItem.Text
            End With
            Me.Close()
        End If
    End Sub

    Private Sub cmdPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPending.Click
        FrmPENDING_STOCK_LIST.ShowDialog()
    End Sub
End Class