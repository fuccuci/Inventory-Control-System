Public Class FrmORDER_FORM

    Private Sub FrmORDER_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_Date ='" & Format(dtOrder.Value, "MM/dd/yyyy") & "'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstOrder, 0)
    End Sub

    Private Sub dtOrder_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtOrder.ValueChanged
        sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_Date ='" & Format(dtOrder.Value, "MM/dd/yyyy") & "'"
        FillListView(ExecuteSQLQuery(sqlSTR), lstOrder, 0)
    End Sub

    Private Sub FrmORDER_FORM_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstOrder.Width = GroupBox1.Width - 10
            .lstOrder.Height = GroupBox1.Height - 18

            .dtOrder.Left = GroupBox1.Width - .dtOrder.Width
            .Label3.Left = (.dtOrder.Left - .Label3.Width) - 4
        End With
    End Sub

    Private Sub txtorder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtorder.TextChanged
        txtorder.Text = str_Filter(txtorder, 48, 57, 0, 0)
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_No =" & txtorder.Text
        FillListView(ExecuteSQLQuery(sqlSTR), lstOrder, 0)
        grpCat.Visible = False
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub
End Class