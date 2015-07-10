Public Class frmSTOCKMONITORINGBALANCES

    Private Sub frmSTOCKMONITORINGBALANCES_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub

    Private Sub FrmSTOCMONITORINGBALANCES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        MDIREFRESH()
        With MDIMain
            .cmdNew.Enabled = False
            .cmdEdit.Enabled = False
            .cmdDelete.Enabled = False
            '.ToolStripNew.Enabled = False
            '.ToolStripEdit.Enabled = False
            '.ToolStripDelete.Enabled = False
        End With
        'sqlSTR = "SELECT tbl_category_item_file.item_id AS 'ID', tbl_category_item_file.Item_name as 'Name', tbl_category_item_file.Item_Description as 'Description', tbl_stocks_balances.item_qty as 'Quantity' FROM tbl_category_item_file JOIN tbl_stocks_balances ON tbl_stocks_balances.item_id = tbl_category_item_file.item_id "

        'sqlSTR = "select tbl_category_item_file.item_id AS 'ID', tbl_category_item_file.Item_name as 'Name', tbl_category_item_file.Item_Description as 'Description', tbl_category_item_file.item_price as 'Price', tbl_stocks_balances.item_qty as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total' FROM tbl_category_item_file, tbl_stocks_balances where tbl_category_item_file.Item_id = tbl_stocks_balances.item_id "
        sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.Item_Barcode AS 'Barcode', TBL_Category_Item_File.Item_Reorder_Point AS 'Reorder Point', TBL_Category_Item_File.Item_Org_Price as 'Price W/O VAT',TBL_Category_Item_File.item_price as 'Price W/ VAT', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total'" & _
                 "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID ORDER BY TBL_Category_Item_File.Item_name"
        FillListView(ExecuteSQLQuery(sqlSTR), listStocks, 0)
        For i = 0 To listStocks.Items.Count - 1
            If Int(listStocks.Items(i).SubItems(7).Text) <= 0 Then
                listStocks.Items(i).ForeColor = Color.Brown
            End If
        Next
        Audit_Trail(xUser_ID, TimeOfDay, "View Stocks Monitoring Balances")
        listStocks.Focus()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Category_Item_File.Item_Org_Price as 'Price W/O VAT',TBL_Category_Item_File.item_price as 'Price W/ VAT', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total'" & _
                 "FROM TBL_category_item_file " & _
                 "INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                 "WHERE Replace(Replace(Item_Name,'$.$',''''),'$..$',',') LIKE '%" & R_eplace(txtname.Text) & "%' ORDER BY Item_name"
        FillListView(ExecuteSQLQuery(sqlSTR), listStocks, 0)
        grpCat.Visible = False
    End Sub

    Private Sub frmSTOCKMONITORINGBALANCES_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .listStocks.Width = GroupBox1.Width - 10
            .listStocks.Height = GroupBox1.Height - 18
        End With
    End Sub
End Class