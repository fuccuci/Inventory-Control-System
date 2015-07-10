Public Class FrmPRODUCTS_REORDER

    Private Sub FrmPRODUCTS_REORDER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' MDIREFRESH()
        MDIDISABLED()
    End Sub
    Private Sub FrmPRODUCTS_REORDER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                 "FROM TBL_Category_Item_File INNER JOIN " & _
                 "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                 "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
        FillListView(ExecuteSQLQuery(sqlSTR), lstreorder, 0)
        For i = 0 To lstreorder.Items.Count - 1
            If Int(lstreorder.Items(i).SubItems(5).Text) <= 0 Then
                lstreorder.Items(i).ForeColor = Color.Brown
            End If
        Next
        Audit_Trail(xUser_ID, TimeOfDay, "View Products On Reorder Point")
    End Sub

    Private Sub lstreorder_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstreorder.MouseDoubleClick
        Dim tmpPurchaseID As Integer
        If lstreorder.Items.Count > 0 Then
            lstreorder.Focus()
            lstreorder.Select()
            sqlSTR = "SELECT *, * FROM TBL_Purchase_Detail " & _
                     "INNER JOIN TBL_Purchase_Order ON TBL_Purchase_Detail.Purchase_ID = TBL_Purchase_Order.Purchase_ID " & _
                     "WHERE TBL_Purchase_Detail.Item_ID =" & lstreorder.FocusedItem.Text & _
                     " ORDER BY TBL_Purchase_Detail.Purchase_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                tmpPurchaseID = sqlDT.Rows(0)("Purchase_ID")
                globalID2 = sqlDT.Rows(0)("Item_ID")
                'Me.Close()
                With FrmPURCHASEORDERADD
                    'sqlSTR = "SELECT * FROM TBL_Suppliers WHERE Supp_ID = " & sqlDT.Rows(0)("Supp_ID")
                    'ExecuteSQLQuery(sqlSTR)
                    'If sqlDT.Rows.Count > 0 Then
                    'MsgBox("here")
                    '.cmbsupplier.Text = "test"
                    'End If
                    FormShow(FrmPURCHASEORDERADD, False, tmpPurchaseID, 0)
                End With
                'MsgBox(sqlDT.Rows(0)("Purchase_ID"))
            End If
        End If
    End Sub



    Private Sub FrmPRODUCTS_REORDER_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstreorder.Width = GroupBox1.Width - 10
            .lstreorder.Height = GroupBox1.Height - 18
        End With
    End Sub

    Private Sub lstreorder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstreorder.SelectedIndexChanged

    End Sub
End Class