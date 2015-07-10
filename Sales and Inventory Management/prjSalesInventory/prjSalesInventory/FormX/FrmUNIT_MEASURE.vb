Public Class FrmUNIT_MEASURE

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        FormAdd("FrmUNIT_MEASURE_ADD")
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmUNIT_MEASURE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT * FROM TBL_Unit_Measure"
        FillListView(ExecuteSQLQuery(sqlSTR), lstunit, 0)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FormEdit("FrmUNIT_MEASURE")
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If lstunit.Items.Count > 0 Then
            If MsgBox("Are you sure to delete this Unit Measure ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sales and Inventory") = MsgBoxResult.Yes Then
                sqlSTR = "DELETE FROM TBL_Unit_Measure WHERE ID=" & lstunit.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)
                sqlSTR = "SELECT * FROM TBL_Unit_Measure"
                FillListView(ExecuteSQLQuery(sqlSTR), lstunit, 0)
            End If
        End If
    End Sub
End Class