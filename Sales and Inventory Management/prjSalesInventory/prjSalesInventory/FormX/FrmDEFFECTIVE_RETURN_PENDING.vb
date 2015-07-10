Public Class FrmDEFFECTIVE_RETURN_PENDING

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmDEFFECTIVE_RETURN_PENDING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(12)
        sqlSTR = "SELECT TBL_Deffective_PO.DEF_PO_ID AS 'Defective ID', TBL_Deffective_PO.Purchase_ID as 'Purchase ID', TBL_Deffective_PO.SupplierName as 'Supplier Name', TBL_Deffective_PO.Delivery_Term as 'Delivery Term', TBL_Deffective_PO.Return_Date as 'Purchase Date' " & _
                 "FROM TBL_Deffective_PO " & _
                 "WHERE TBL_Deffective_PO.DEF_PO_ID NOT IN (SELECT DEF_PO_ID FROM TBL_Deffective_PO_Return) " & _
                 " AND TBL_Deffective_PO.Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstreturn, 0)
    End Sub

    Private Sub dtreturn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtreturn.ValueChanged
        'sqlSTR = "SELECT TBL_Deffective_PO.Purchase_ID as 'Purchase ID', TBL_Deffective_PO.SupplierName as 'Supplier Name', TBL_Deffective_PO.Delivery_Term as 'Delivery Term', TBL_Deffective_PO.Return_Date as 'Purchase Date' " & _
        '         "FROM TBL_Deffective_PO " & _
        '         "WHERE TBL_Deffective_PO.Purchase_ID NOT IN (SELECT Purchase_ID FROM TBL_Deffective_PO_Return) " & _
        '         " AND TBL_Deffective_PO.Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
        sqlSTR = "SELECT TBL_Deffective_PO.DEF_PO_ID AS 'Defective ID', TBL_Deffective_PO.Purchase_ID as 'Purchase ID', TBL_Deffective_PO.SupplierName as 'Supplier Name', TBL_Deffective_PO.Delivery_Term as 'Delivery Term', TBL_Deffective_PO.Return_Date as 'Purchase Date' " & _
                 "FROM TBL_Deffective_PO " & _
                 "WHERE TBL_Deffective_PO.DEF_PO_ID NOT IN (SELECT DEF_PO_ID FROM TBL_Deffective_PO_Return) " & _
                 " AND TBL_Deffective_PO.Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"

        FillListView(ExecuteSQLQuery(sqlSTR), lstreturn, 0)
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        With FrmDEFFECTIVE_RETURN_ADD
            If lstreturn.Items.Count > 0 Then
                lstreturn.Focus()
                .txtpo.Text = lstreturn.FocusedItem.Text
                .txtpo2.Text = lstreturn.FocusedItem.SubItems(1).Text
                .txtreturn.Text = lstreturn.FocusedItem.SubItems(4).Text
                Me.Close()
            End If
        End With
    End Sub
End Class