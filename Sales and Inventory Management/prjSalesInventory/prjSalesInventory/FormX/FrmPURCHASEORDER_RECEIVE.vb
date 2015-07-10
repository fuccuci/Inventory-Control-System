Public Class FrmPURCHASEORDER_RECEIVE

    Private Sub FrmPURCHASEORDER_RECEIVE_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIREFRESH()
    End Sub

    Private Sub FrmPURCHASEORDER_RECEIVE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'ID', TBL_Suppliers.SuppName as 'Supplier Name' " & _
                 ", TBL_Purchase_Order.Address as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term' " & _
                 "FROM TBL_Purchase_Order " & _
                 "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                 "AND TBL_Purchase_Order.Received_Date ='" & Format(dtreceived.Value, "MM/dd/yyyy") & "'"
        '"INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _

        FillListView(ExecuteSQLQuery(sqlSTR), lstreceive, 0)
        MDIREFRESH()
        With MDIMain
            .cmdNew.Enabled = False
            .cmdEdit.Enabled = False
            .cmdDelete.Enabled = False
            ' .ToolStripNew.Enabled = False
            ' .ToolStripEdit.Enabled = False
            ' .ToolStripDelete.Enabled = False
        End With
        'MsgBox(dtreceived.Value)
    End Sub

    Private Sub dtreceived_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtreceived.ValueChanged
        sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'ID',TBL_Suppliers.SuppName as 'Supplier Name'" & _
                 ", TBL_Purchase_Order.Address as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term'" & _
                 "FROM TBL_Purchase_Order " & _
                 "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                 "AND TBL_Purchase_Order.Received_Date ='" & Format(dtreceived.Value, "MM/dd/yyyy") & "'"
        '"INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
        FillListView(ExecuteSQLQuery(sqlSTR), lstreceive, 0)
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
        Me.Enabled = True
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        sqlSTR = "SELECT DISTINCT TBL_Purchase_Order.Purchase_ID as 'ID',TBL_Suppliers.SuppName as 'Supplier Name'" & _
                 ", TBL_Purchase_Order.Address as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term'" & _
                 "FROM (TBL_Purchase_Order " & _
                 "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                 "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                 "AND TBL_Purchase_Order.Received_Date ='" & Format(dtreceived.Value, "MM/dd/yyyy") & "'" & _
                 " AND TBL_Suppliers.SuppName LIKE '%" & txtname.Text & "%'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstreceive, 0)
        grpCat.Visible = False
    End Sub
End Class