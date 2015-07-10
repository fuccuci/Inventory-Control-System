Public Class FrmPURCHASEORDERADD
    'Dim tmpID As Integer
    Dim stockID As Integer
    Dim tmpPrevCustomer As String
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmPURCHASEORDERADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Purchase Order Detail"
        chckapproved.Enabled = True
        txtapproved.Enabled = True
        cmdadd.Enabled = True
        cmdSave.Enabled = True
        cmddel.Enabled = True
        cmdEdit.Enabled = True
    End Sub

    Private Sub FrmPURCHASEORDERADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim suppName As String
        stockID = globalID
        FILLComboBox("SELECT Supp_ID, SuppName FROM TBL_Suppliers", cmbsupplier)
        If Split(Me.Text, " - ")(1) = "Add" Then

            txtadd.Text = ""
            txtdeliver.Text = "Paid after deliver"
            txtapproved.Text = ""
            chckapproved.Checked = 0
            lstitems.Items.Clear()
            If stockID > 0 Then
                sqlSTR = "SELECT * FROM TBL_Suppliers WHERE Supp_ID = " & sqlDT.Rows(0)("Supp_ID")
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    cmbsupplier.Text = sqlDT.Rows(0)("Supp_ID") & " - " & sqlDT.Rows(0)("SuppName")
                    tmpPrevCustomer = cmbsupplier.Text
                    sqlSTR = "SELECT *, * FROM TBL_Purchase_Detail " & _
                             "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                             "WHERE Purchase_ID =" & stockID & _
                             " AND TBL_Category_Item_File.Item_ID =" & globalID2
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        lstitems.Items.Add(sqlDT.Rows(0)("Item_ID"))
                        lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(0)("Purchase_Detail_ID"))
                        lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(0)("Item_Name")))
                        lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(0)("Item_Description")))
                        lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(0)("Item_QTY"))
                    End If
                End If
            End If
        Else
            sqlSTR = "SELECT TBL_Suppliers.Supp_ID, TBL_Suppliers.Suppname, * " & _
                     " FROM (TBL_Suppliers " & _
                     " INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
                     " WHERE TBL_Purchase_Order.Purchase_ID = " & stockID

            ExecuteSQLQuery(sqlSTR)
            txtadd.Text = R_Change(sqlDT.Rows(0)("Address"))
            txtdeliver.Text = R_Change(sqlDT.Rows(0)("Delivery_Term"))
            dtpurchase.Value = sqlDT.Rows(0)("Purchased_Date")
            dtapprove.Value = sqlDT.Rows(0)("Received_Date")

            If sqlDT.Rows(0)("Approved") = "Yes" Then
                'MsgBox("Yes")
                chckapproved.Checked = 1
                chckapproved.Enabled = False
                txtapproved.Enabled = False
                cmdadd.Enabled = False
                cmdSave.Enabled = False
                cmddel.Enabled = False
                cmdEdit.Enabled = False
            Else
                chckapproved.Checked = 0
            End If

            suppName = sqlDT.Rows(0)("Supp_ID") & " - " & sqlDT.Rows(0)("Suppname")
            lstitems.Items.Clear()
            ' sqlSTR = "SELECT TBL_Purchase_Detail.Item_ID as 'ID', TBL_Purchase_Detail.Purchase_Detail_ID as 'Detail ID', TBL_Category_Item_File.Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Purchase_Detail.Item_QTY as 'Quantity' " & _
            '          " FROM TBL_Purchase_Detail INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
            '          " WHERE TBL_Purchase_Detail.Purchase_ID = " & stockID
            ' FillListView(ExecuteSQLQuery(sqlSTR), lstitems, 1)
            sqlSTR = "SELECT *, * " & _
                     " FROM TBL_Purchase_Detail INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                     " WHERE TBL_Purchase_Detail.Purchase_ID = " & stockID
            ExecuteSQLQuery(sqlSTR)
            For i = 0 To sqlDT.Rows.Count - 1
                lstitems.Items.Add(sqlDT.Rows(i)("Item_ID"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Purchase_Detail_ID"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Description")))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
            Next
            cmbsupplier.SelectedItem = suppName
        End If
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        'FrmPURCHASEORDERLIST.ShowDialog()
        If cmbsupplier.Text <> "" Then
            FrmPURCHASEORDERDATA.ShowDialog()
        Else
            MsgBox("No Supplier Name Selected !", MsgBoxStyle.Information, "Sales and Inventory")
        End If
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        lstitems.Focus()
        If lstitems.Items.Count > 0 Then
            lstitems.FocusedItem.Remove()
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        Dim xTotal As Double
        If cmbsupplier.Text = "" Then
            MsgBox("Input Supplier Name", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If chckapproved.Checked Then
            If lstitems.Items.Count <= 0 Then
                MsgBox("Can't Approved The Order, No Details Had Found!", MsgBoxStyle.Information, "Sales and Inventory")
                Exit Sub
            End If
        End If
        For i = 0 To lstitems.Items.Count - 1
            'MsgBox(lstitems.Items(i).SubItems(5).Text & lstitems.Items(i).SubItems(6).Text)
            'xTotal = xTotal + CDbl(lstitems.Items(i).SubItems(4).Text) * CDbl(lstitems.Items(i).SubItems(5).Text)
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(i).Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                xTotal = xTotal + CDbl(sqlDT.Rows(0)("Item_Price")) * CDbl(lstitems.Items(i).SubItems(4).Text)
            End If
        Next
        If Split(Me.Text, " - ")(1) = "Add" Then
            'ADD
            sqlSTR = "INSERT INTO TBL_Purchase_Order (Supp_ID, Address, Delivery_Term, Approved, Purchased_Date, Received_Date, Direct_Input, Purchase_Total) " & _
                   " VALUES (" & Split(cmbsupplier.Text, " - ")(0) & ", " _
                               & "'" & R_eplace(txtadd.Text) & "', " _
                               & "'" & R_eplace(txtdeliver.Text) & "', " _
                               & "'" & IIf(chckapproved.Checked = True, "Yes", "No") & "', " _
                               & "'" & Format(dtpurchase.Value, "MM/dd/yyyy") & "', " _
                               & "'" & Format(dtapprove.Value, "MM/dd/yyyy") & "', " _
                               & "'" & "No" & "', " _
                               & xTotal & ")"
            ExecuteSQLQuery(sqlSTR)
            sqlSTR = "SELECT * FROM TBL_Purchase_Order ORDER BY Purchase_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            stockID = sqlDT.Rows(0)("Purchase_ID")
            'MsgBox(sqlDT.Rows(0)("purchase_Id"))
            'lstitems.Items.Clear()
            For i = 0 To lstitems.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(i).Text
                ' sqlSTR = "SELECT * FROM TBL_Suppliers_Product WHERE Item_ID =" & lstitems.Items(i).Text & _
                '          " AND Supp_ID =" & Split(cmbsupplier.Text, " - ")(0)
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then

                    sqlSTR = "INSERT INTO TBL_Purchase_Detail (Purchase_ID, Item_ID, Item_Qty, Item_Price, Total_Price, Unit_Measure) " & _
                            " VALUES (" & stockID & ", " _
                                   & lstitems.Items(i).Text & ", " _
                                   & lstitems.Items(i).SubItems(4).Text & ", " _
                                   & CDbl(sqlDT.Rows(0)("Item_Price")) & ", " _
                                   & CDbl(lstitems.Items(i).SubItems(4).Text) * CDbl(sqlDT.Rows(0)("Item_Price")) & ", " _
                                   & "'" & sqlDT.Rows(0)("Unit_Measure") & "')"
                    ExecuteSQLQuery(sqlSTR)
                    '& lstitems.Items(i).SubItems(4).Text & ", " _
                    'CDbl(lstitems.Items(i).SubItems(4).Text) & ", " _
                End If

            Next
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Purchase Order Stocks")
        Else
            'EDIT
            sqlSTR = "DELETE FROM TBL_Purchase_Detail WHERE Purchase_ID =" & stockID
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "UPDATE TBL_Purchase_Order SET Supp_ID =" & Split(cmbsupplier.Text, " - ")(0) & ", " _
                            & "Address ='" & R_eplace(txtadd.Text) & "', " _
                            & "Delivery_Term ='" & R_eplace(txtdeliver.Text) & "', " _
                            & "Approved ='" & IIf(chckapproved.Checked = True, "Yes", "No") & "', " _
                            & "Purchased_Date ='" & Format(dtpurchase.Value, "MM/dd/yyyy") & "', " _
                            & "Received_Date ='" & Format(dtapprove.Value, "MM/dd/yyyy") & "' WHERE Purchase_ID =" & stockID
            ExecuteSQLQuery(sqlSTR)

            For i = 0 To lstitems.Items.Count - 1
                '  sqlSTR = "INSERT INTO TBL_Purchase_Detail (Purchase_ID, Item_ID,Item_Qty, Item_Price, Total_Price, Unit_Measure) " & _
                '         " VALUES (" & stockID & ", " _
                '                     & lstitems.Items(i).Text & ", " _
                '                     & lstitems.Items(i).SubItems(6).Text & ", " _
                '                     & lstitems.Items(i).SubItems(4).Text & ", " _
                '                     & CDbl(lstitems.Items(i).SubItems(6).Text) * CDbl(lstitems.Items(i).SubItems(4).Text) & ", " _
                '                     & "'" & lstitems.Items(i).SubItems(7).Text & "')"
                '  'MsgBox(lstitems.Items(i).SubItems(4).Text)
                '  ExecuteSQLQuery(sqlSTR)
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(i).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then

                    sqlSTR = "INSERT INTO TBL_Purchase_Detail (Purchase_ID, Item_ID, Item_Qty, Item_Price, Total_Price, Unit_Measure) " & _
                             " VALUES (" & stockID & ", " _
                                         & lstitems.Items(i).Text & ", " _
                                         & lstitems.Items(i).SubItems(4).Text & ", " _
                                         & CDbl(sqlDT.Rows(0)("Item_Price")) & ", " _
                                         & CDbl(lstitems.Items(i).SubItems(4).Text) * CDbl(sqlDT.Rows(0)("Item_Price")) & ", " _
                                         & "'" & sqlDT.Rows(0)("Unit_Measure") & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If
            Next
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Purchase Order Stocks")
        End If

        'refresh list
        sqlSTR = "SELECT TBL_Purchase_Detail.Item_ID as 'ID', TBL_Purchase_Detail.Purchase_Detail_ID as 'Detail ID', TBL_Category_Item_File.Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Purchase_Detail.Item_QTY as 'Quantity' " & _
                 " FROM TBL_Purchase_Detail INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                 " WHERE TBL_Purchase_Detail.Purchase_ID = " & stockID
        FillListView(ExecuteSQLQuery(sqlSTR), lstitems, 1)

        'Update Current Stocks
        If chckapproved.Checked Then
            If lstitems.Items.Count > 0 Then
                For i = 0 To lstitems.Items.Count - 1
                    sqlSTR = "SELECT * " & _
                             " FROM TBL_Stocks_Balances INNER JOIN TBL_Purchase_Detail ON TBL_Stocks_Balances.Item_ID = TBL_Purchase_Detail.Item_ID " & _
                             " WHERE TBL_Purchase_Detail.Purchase_Detail_ID = " & lstitems.Items(i).SubItems(1).Text
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        'Already Exists
                        sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                        'MsgBox(sqlDT.Rows.Count & " HERE ")
                        If sqlDT.Rows.Count > 0 Then

                            sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_Qty = Item_QTY + " & lstitems.Items(i).SubItems(4).Text & ", " _
                                     & "PASSWORD_INPUTED ='" & "No" & "', " _
                                     & "DIRECT_INPUT ='" & "No" & "', " _
                                     & "Unit_Measure ='" & sqlDT.Rows(0)("Unit_Measure") & "'" _
                                     & " WHERE Item_ID =" & lstitems.Items(i).Text
                            ExecuteSQLQuery(sqlSTR)
                        End If
                    Else
                        'No current data
                        sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                        If sqlDT.Rows.Count > 0 Then
                            sqlSTR = "INSERT INTO TBL_Stocks_Balances (Item_ID, Item_Description, Item_Price, Item_Barcode, Item_QTY, PASSWORD_INPUTED, DIRECT_INPUT, Unit_Measure) VALUES (" & lstitems.Items(i).Text & ", " _
                                                                    & "'" & R_eplace(lstitems.Items(i).SubItems(3).Text) & "', " _
                                                                    & CDbl(sqlDT.Rows(0)("Item_Price")) & ", " _
                                                                    & sqlDT.Rows(0)("Item_Barcode") & ", " _
                                                                    & lstitems.Items(i).SubItems(4).Text & ", " _
                                                                    & "'" & "No" & "', " _
                                                                    & "'" & "No" & "', " _
                                                                    & "'" & sqlDT.Rows(0)("Unit_Measure") & "')"
                            ExecuteSQLQuery(sqlSTR)
                            '&lstitems.Items(i).SubItems(4).Text & ", " _
                            '& lstitems.Items(i).SubItems(5).Text & ", " _
                            '& "'" & lstitems.Items(i).SubItems(7).Text & "')"
                        End If
                    End If
                Next
            End If
        End If

        MsgBox("Record Successfuly Updated !", MsgBoxStyle.Information, "Sales and Inventory")
        sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                 " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                 " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(Now, "MM/dd/yyyy") & "'" & _
                 " ORDER BY Purchase_ID"

        FillListView(ExecuteSQLQuery(sqlSTR), FrmPURCHASEORDER.listorder, 0)
        With FrmPURCHASEORDER.listorder
            For i = 0 To .Items.Count - 1
                If .Items(i).SubItems(4).Text = "Yes" Then
                    .Items(i).ForeColor = Color.Brown
                Else
                    .Items(i).ForeColor = Color.Black
                End If
            Next
        End With

        'check critical
        sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                 "FROM TBL_Category_Item_File INNER JOIN " & _
                 "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                 "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
        ExecuteSQLQuery(sqlSTR)
        With MDIMain
            If sqlDT.Rows.Count > 0 Then
                MsgBox("A Product(s) reach its critical level !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                .tmrcritical.Enabled = True
            Else
                .tmrcritical.Enabled = False
                .cmdProductReorder.Enabled = True
                .cmdProductReorder.ForeColor = Color.Black
            End If
        End With
        Me.Close()
    End Sub

    Private Sub cmbsupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsupplier.SelectedIndexChanged
        Dim I As Integer
        'Dim tmpPrevCustomer As String
        'If Split(Me.Text, " - ")(1) = "Add" Then
        ' If Split(cmbsupplier.Text, " - ")(0) <> "" Then
        ' sqlSTR = "SELECT * FROM TBL_Suppliers WHERE Supp_ID =" & Split(cmbsupplier.Text, " - ")(0)
        ' ExecuteSQLQuery(sqlSTR)
        ' If sqlDT.Rows.Count > 0 Then
        ' txtadd.Text = sqlDT.Rows(0)("SuppAdd")
        ' End If
        ' End If
        ' End If
        If Split(cmbsupplier.Text, " - ")(0) <> "" Then
            sqlSTR = "SELECT * FROM TBL_Suppliers WHERE Supp_ID =" & Split(cmbsupplier.Text, " - ")(0)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                'replace(replace(suppadd,'$.$',''''),'$..$',',')
                txtadd.Text = Replace(Replace(sqlDT.Rows(0)("SuppAdd"), "$.$", "'"), "$..$", ",")

                'tmpPrevCustomer = txtadd.Text
            End If
            If globalID > 0 Then
                'sqlSTR = "SELECT *, * FROM TBL_Purchase_Detail " & _
                '         "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                '         "WHERE Purchase_ID =" & stockID
                'MsgBox(sqlSTR)
                'ExecuteSQLQuery(sqlSTR)

                For I = 0 To lstitems.Items.Count - 1
                    sqlSTR = "SELECT * FROM TBL_Suppliers_Product " & _
                             "WHERE Supp_ID =" & Split(cmbsupplier.Text, " - ")(0) & _
                             " AND Item_ID =" & lstitems.Items(I).Text
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count <= 0 Then
                        MsgBox("Selected supplier does not have the precise item ", MsgBoxStyle.Exclamation, "Sales and Inventory")
                        cmbsupplier.Text = tmpPrevCustomer
                        Exit Sub
                        'lstitems.Items(I).Remove()
                        'Else
                        '    For x = 0 To lstitems.Items.Count - 1
                        ' If lstitems.Items(x).Text = sqlDT.Rows(0)("Item_ID") Then
                        '
                        '                   End If
                        '              Next
                    End If
                Next
                tmpPrevCustomer = cmbsupplier.Text
                'sqlSTR = ""
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        With FrmPURCHASEORDERDATA_EDIT
            If lstitems.Items.Count > 0 Then
                lstitems.Focus()
                .txtid.Text = lstitems.FocusedItem.Text
                .txtdtl.Text = lstitems.FocusedItem.SubItems(1).Text
                .txtname.Text = lstitems.FocusedItem.SubItems(2).Text
                .txtdesc.Text = lstitems.FocusedItem.SubItems(3).Text
                '.txtprice.Text = lstitems.FocusedItem.SubItems(4).Text
                '.txtbarcode.Text = lstitems.FocusedItem.SubItems(5).Text
                .txtqty.Text = lstitems.FocusedItem.SubItems(4).Text
                '.txtunit.Text = lstitems.FocusedItem.SubItems(7).Text
                .ShowDialog()
            End If

        End With
    End Sub



    Private Sub chckapproved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckapproved.CheckedChanged
        If chckapproved.Checked Then
            txtapproved.Text = username
        Else
            txtapproved.Text = ""
        End If
    End Sub

    Private Sub txtadd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadd.TextChanged

    End Sub
End Class