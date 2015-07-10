Public Class FrmSTOCKADD
    Dim stockID As Integer
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSTOCKADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Stock Information"
    End Sub

    Private Sub FrmSTOCKADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stockID = globalID
        FILLComboBox("SELECT Supp_ID, SuppName FROM TBL_Suppliers", cmbsupplier)
        If Split(Me.Text, " - ")(1) = "Add" Then
            txtproductid.Text = ""
            txtdesc.Text = ""
            txtqty.Text = ""
            txtbarcode.Text = ""
            FormShow(FrmStockList, False, 0, 0)
        Else
            'sqlSTR = "SELECT * FROM "

        End If

        'If Split(Me.Text, " - ")(1) = "Edit" Then
        '    stockID = globalID
        '    sqlSTR = "SELECT * FROM tbl_Category_File WHERE catg_ID =" & stockID
        '    ExecuteSQLQuery(sqlSTR)
        '    If sqlDT.Rows.Count > 0 Then
        '        txtid.Text = sqlDT.Rows(0)("Catg_ID")
        '        txtname.Text = sqlDT.Rows(0)("Catg_Name")
        '        txtdesc.Text = sqlDT.Rows(0)("Catg_Description")
        '    End If
        'Else
        '    txtid.Text = ""
        '    txtname.Text = ""
        '    txtdesc.Text = ""
        'End If
    End Sub

    Private Sub txtproductid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtproductid.MouseClick
        FrmStockList.ShowDialog()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not IsNumeric(txtqty.Text) Then
            MsgBox("Quantity Should Be Numeric ", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If txtproductid.Text = "" And txtdesc.Text = "" And txtbarcode.Text = "" And txtqty.Text = "" Then
            MsgBox("No Corresponding Data Found !!", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If cmbsupplier.Text = "" Then
            MsgBox("Input Supplier Name", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If

        'sqlSTR = "INSERT INTO TBL_Stocks_Details (Item_ID, Item_Qty, Item_Description, Date_Purchased, Item_Consolidate) VALUES (" & txtproductid.Text & ", " _
        '                                                       & txtqty.Text & ", " _
        '                                                      & "'" & txtdesc.Text & "', " _
        '                                                     & dtPicker.Text & ", " _
        '                                                    & 0 & ")"
        'ADD TO TBL_PURCHASE_ORDER
        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "INSERT INTO TBL_Purchase_Order (Supp_ID, Address, Delivery_Term, Approved, Purchased_Date, Received_Date, Direct_Input) " & _
                 " VALUES (" & Split(cmbsupplier.Text, " - ")(0) & ", " _
                             & "'" & txtaddress.Text & "', " _
                             & "'" & txtdelivery.Text & "', " _
                             & "'" & "Yes" & "', " _
                             & "'" & Format(dtPicker.Value, "MM/dd/yyyy") & "', " _
                             & "'" & Format(dtreceived.Value, "MM/dd/yyyy") & "', " _
                             & "'" & "Yes" & "')"
            'MsgBox(sqlSTR)
            ExecuteSQLQuery(sqlSTR)
            'GET THE LAST ID
            sqlSTR = "SELECT * FROM TBL_Purchase_Order ORDER BY Purchase_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            'STORE THE LAST ID
            stockID = sqlDT.Rows(0)("Purchase_ID")
            sqlSTR = "INSERT INTO TBL_Purchase_Detail (Purchase_ID, Item_ID,Item_Qty) " & _
              " VALUES (" & stockID & ", " _
                       & txtproductid.Text & ", " _
                       & txtqty.Text & ")"
            'MsgBox(lstitems.Items(i).SubItems(4).Text)
            ExecuteSQLQuery(sqlSTR)
            'CHECK IF ITEM IS ALREADY EXISTS IN THE TABLE!
            sqlSTR = "SELECT * FROM TBL_Stocks_Balances WHERE Item_ID =" & txtproductid.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                ' sqlSTR = "UPDATE tbl_Category_File SET Catg_Name ='" & txtname.Text & "', " _
                '                               & "Catg_Description ='" & txtdesc.Text & "' WHERE catg_ID =" & stockID

                sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_Qty =" & sqlDT.Rows(0)("Item_QTY") + txtqty.Text & ", " _
                         & "Direct_Input ='" & "Yes" & "' WHERE Item_ID =" & txtproductid.Text
                ExecuteSQLQuery(sqlSTR)

            Else
                'if the current record is not yet on TBL_Stock_Balances, Add the Data !
                sqlSTR = "INSERT INTO TBL_Stocks_Balances (Item_ID, Item_QTY, Item_Description, DIRECT_INPUT) VALUES (" & txtproductid.Text & ", " _
                                                                                & txtqty.Text & ", " _
                                                                                & "'" & txtdesc.Text & "', " _
                                                                               & "'" & "Yes" & "')"
                ExecuteSQLQuery(sqlSTR)
            End If
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Direct Stocks Add")
        Else
            'EDIT
            sqlSTR = "SELECT * FROM TBL_Stocks_Balances WHERE Item_ID =" & txtproductid.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                ' sqlSTR = "UPDATE tbl_Category_File SET Catg_Name ='" & txtname.Text & "', " _
                '                               & "Catg_Description ='" & txtdesc.Text & "' WHERE catg_ID =" & stockID

                sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_Qty =" & sqlDT.Rows(0)("Item_QTY") + txtqty.Text & ", " _
                         & "Direct_Input ='" & "Yes" & "' WHERE Item_ID =" & txtproductid.Text
                ExecuteSQLQuery(sqlSTR)
            Else
                'if the current record is not yet on TBL_Stock_Balances, Add the Data !
                sqlSTR = "INSERT INTO TBL_Stocks_Balances (Item_ID, Item_QTY, Item_Description, DIRECT_INPUT) VALUES (" & txtproductid.Text & ", " _
                                                                                & txtqty.Text & ", " _
                                                                                & "'" & txtdesc.Text & "', " _
                                                                               & "'" & "Yes" & "')"
                ExecuteSQLQuery(sqlSTR)
            End If
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Item by Direct Stocks")
        End If
        sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.item_price as 'Price', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total', DIRECT_INPUT AS 'DIRECT' " & _
                 "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID "
        FillListView(ExecuteSQLQuery(sqlSTR), frmSTOCKMONITORINGBALANCES.listStocks, 0)
        Me.Close()
    End Sub
End Class