Public Class FrmStockList

    Private Sub FrmStockList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Stock List"
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmStockList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FILLComboBox("SELECT Catg_ID, Catg_Name FROM tbl_Category_File", cmbCategory)
        lstStock.Focus()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        'Split(cmbCategory.Text, " - ")(0)
        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Item_Description as 'Description / Item Number', Item_barcode as 'Barcode' FROM TBL_Category_Item_File WHERE Catg_ID =" & Split(cmbCategory.Text, " - ")(0)), lstStock, 0)
        lstStock.Focus()
    End Sub

    Private Sub cmdselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselect.Click
        If cmbCategory.Text <> "" Then
            FrmSTOCKADD.txtproductid.Text = lstStock.FocusedItem.Text
            FrmSTOCKADD.txtdesc.Text = lstStock.FocusedItem.SubItems(1).Text
            FrmSTOCKADD.txtbarcode.Text = lstStock.FocusedItem.SubItems(2).Text
            Me.Close()
        Else
            MsgBox("No Category Selected !!!", MsgBoxStyle.Information, "Sales and Inventory")
        End If
    End Sub

    Private Sub lstStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStock.SelectedIndexChanged

    End Sub
End Class