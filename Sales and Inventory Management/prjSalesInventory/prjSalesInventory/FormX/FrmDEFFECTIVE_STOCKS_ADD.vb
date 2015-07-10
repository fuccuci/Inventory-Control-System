Public Class FrmDEFFECTIVE_STOCKS_ADD
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Pending_ID = 0
        Pending_Item_ID = 0
        Me.Close()
    End Sub

    Private Sub FrmDEFFECTIVE_STOCKS_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Pending_ID = 0
        Pending_Item_ID = 0
        Me.Text = "Defective Stock Details"
    End Sub

    Private Sub FrmDEFFECTIVE_STOCKS_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        lstitems.Items.Clear()
        If Split(Me.Text, " - ")(1) = "Add" Then
            cmdAdd.Enabled = True
            cmdSave.Enabled = True
            txtpo.Text = ""
            txtdeliver.Text = ""
            txtadd.Text = ""
            lstitems.Items.Clear()
            Label7.Text = "Purchase ID"
            FrmDEFFECTIVE_PO_LIST.ShowDialog()
        Else
            cmdAdd.Enabled = False
            Label7.Text = "Defective ID"
            txtpo.Text = globalID
            sqlSTR = "SELECT *, *, *, *, * " & _
              "FROM (((((TBL_Suppliers " & _
              "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
              "INNER JOIN TBL_Deffective_PO ON TBL_Purchase_Order.Purchase_ID = TBL_Deffective_PO.Purchase_ID) " & _
              "INNER JOIN TBL_Deffective_PO_Details ON TBL_Deffective_PO.Purchase_ID = TBL_Deffective_PO_Details.Purchase_ID AND " & _
              "TBL_Deffective_PO.DEF_PO_ID = TBL_Deffective_PO_Details.DEF_PO_ID) " & _
              "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID " & _
              "AND TBL_Deffective_PO_Details.Item_ID = TBL_Purchase_Detail.Item_ID) " & _
              "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
              "WHERE TBL_Deffective_PO.DEF_PO_ID =" & txtpo.Text
            'MsgBox(txtpo.Text)
            'MsgBox(sqlSTR)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtSuppname.Text = R_Change(sqlDT.Rows(0)("suppname"))
                txtadd.Text = R_Change(sqlDT.Rows(0)("address"))
                txtdeliver.Text = R_Change(sqlDT.Rows(0)("delivery_term"))
                dtRETURN.Value = sqlDT.Rows(0)("Return_Date")
                'MsgBox(Pending_QTY)
                For i = 0 To sqlDT.Rows.Count - 1
                    With lstitems
                        .Items.Add(sqlDT.Rows(i)("Item_ID"))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Purchase_Detail_ID"))
                        .Items((.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_description"))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("def_QTY"))
                        .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Unit"))
                    End With
                Next
            End If
            'CHECK IF ITS FULLY RETURNED
            sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & txtpo.Text & _
                     " AND Fully_Return='Yes'" & _
                     " ORDER BY Def_PO_ID ASC"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("Can't modify the data because its already been returned !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                cmdAdd.Enabled = False
                cmdEdit.Enabled = False
                cmdSave.Enabled = False
                Exit Sub
            Else
                cmdAdd.Enabled = True
                cmdEdit.Enabled = True
            End If
        End If
        If Pending_ID > 0 Then
            cmdEdit.Enabled = False
            cmdAdd.Enabled = False
        Else
            cmdAdd.Enabled = True
            cmdEdit.Enabled = True
        End If
    End Sub

    Private Sub txtpo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpo.Click
        If Split(Me.Text, " - ")(1) = "Edit" Then Exit Sub
        FrmDEFFECTIVE_PO_LIST.ShowDialog()
    End Sub

    Private Sub txtpo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpo.TextChanged

        If Split(Me.Text, " - ")(1) = "Edit" Then Exit Sub
        If txtpo.Text = "" Then Exit Sub
        sqlSTR = "SELECT * FROM TBL_Deffective_PO WHERE Purchase_ID =" & txtpo.Text
        ExecuteSQLQuery(sqlSTR)
        'If sqlDT.Rows.Count > 0 And Pending_ID = 0 Then
        ' MsgBox("Purchase Order ' " & txtpo.Text & " is already on the list Date " & sqlDT.Rows(0)("Return_Date"))
        ' Me.Close()
        ' Exit Sub
        ' Else
        '          sqlSTR = "SELECT *, *, *, *, * " & _
        ' "FROM (((((TBL_Suppliers " & _
        ' "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
        ' "INNER JOIN TBL_Deffective_PO ON TBL_Purchase_Order.Purchase_ID = TBL_Deffective_PO.Purchase_ID) " & _
        ' "INNER JOIN TBL_Deffective_PO_Details ON TBL_Deffective_PO.Purchase_ID = TBL_Deffective_PO_Details.Purchase_ID) " & _
        ' "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID) " & _
        ' "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
        '  "WHERE TBL_Purchase_Order.Purchase_ID =" & txtpo.Text

        ' sqlSTR = "SELECT *, *, * " & _
        '          "FROM ((TBL_Deffective_PO_Details " & _
        '          "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
        '          "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_ID = TBL_Purchase_Detail.Purchase_ID " & _
        '          "AND TBL_Deffective_PO_Details.Item_ID = TBL_Purchase_Detail.Item_ID) " & _
        '          "WHERE TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text

        '" AND TBL_Deffective_PO_Details.Item_ID =" & Pending_Item_ID
        ' If Pending_ID > 0 Then
        ' sqlSTR = sqlSTR & " AND TBL_Purchase_Detail.Item_ID =" & Pending_Item_ID
        ' Else
        ' sqlSTR = sqlSTR & ""
        'End If

        sqlSTR = "SELECT *, * " & _
                 "FROM TBL_Purchase_Detail " & _
                 "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                 "WHERE TBL_Purchase_Detail.Purchase_ID =" & txtpo.Text & _
                 " AND TBL_Purchase_Detail.Item_ID =" & Pending_Item_ID
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstitems.Items.Add(sqlDT.Rows(i)("Item_ID"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Purchase_Detail_ID"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Item_Description"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(Pending_QTY)
                'lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("def_QTY") + Pending_QTY)
                lstitems.Items(lstitems.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Unit_Measure"))
            Next
            Me.Text = "Defective Stock Details - Add"
        Else
            Me.Text = "Defective Stock Details - Add"
        End If
        'Me.Text = ""

        'End If
        sqlSTR = "SELECT *, *, *, * " & _
                     "FROM (((TBL_Suppliers " & _
                     "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                     "WHERE TBL_Purchase_Order.Purchase_ID =" & txtpo.Text
        'MsgBox(sqlSTR)
        ExecuteSQLQuery(sqlSTR)
        txtSuppname.Text = R_Change(sqlDT.Rows(0)("suppname"))
        txtadd.Text = R_Change(sqlDT.Rows(0)("address"))
        txtdeliver.Text = R_Change(sqlDT.Rows(0)("delivery_term"))
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'FrmDEFFECTIVE_STOCKS_DATA_ADD.ShowDialog()
        If txtpo.Text <> "" Then
            FormShow(FrmDEFFECTIVE_STOCKS_DATA_ADD, False, 0, 0)
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim def_po_id As Integer
        On Error Resume Next
        Dim I As Integer
        Dim total_price As Double
        Dim ix As Integer, item_qty As Integer
        If Split(Me.Text, " - ")(1) = "Add" Then
            'MsgBox("A")
            If lstitems.Items.Count = 0 Then
                MsgBox("No item details, please add details !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            '----
            'sqlSTR = "SELECT * FROM TBL_Deffective_PO WHERE Purchase_ID =" & txtpo.Text
            'ExecuteSQLQuery(sqlSTR)
            If Pending_ID > 0 Then
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details WHERE Pending_ID =" & Pending_ID
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MsgBox("Record has already been assign as defective !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    Exit Sub
                End If
            End If

            '----
            'If sqlDT.Rows.Count = 0 Then
            sqlSTR = "INSERT INTO TBL_Deffective_PO (Purchase_ID, SupplierName, Delivery_term, Address, Return_Date, Pending_ID) " & _
                     "VALUES (" & txtpo.Text & ", " _
                          & "'" & R_eplace(txtSuppname.Text) & "', " _
                          & "'" & R_eplace(txtdeliver.Text) & "', " _
                          & "'" & R_eplace(txtadd.Text) & "', " _
                          & "'" & Format(dtRETURN.Value, "MM/dd/yyyy") & "', " _
                          & Pending_ID & ")"
            ExecuteSQLQuery(sqlSTR)
            'End If
            sqlSTR = "SELECT * FROM TBL_Deffective_PO ORDER BY DEF_PO_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            def_po_id = sqlDT.Rows(0)("DEF_PO_ID")

            For I = 0 To lstitems.Items.Count - 1
                sqlSTR = "INSERT INTO TBL_Deffective_PO_Details (Pending_ID, Purchase_ID, DEF_PO_ID, Purchase_Detail_ID, Item_ID, Def_Qty, Unit) " & _
                         "VALUES (" & IIf(Pending_Item_ID = lstitems.Items(I).Text, Pending_ID, 0) & ", " _
                                    & txtpo.Text & ", " _
                                    & def_po_id & ", " _
                                    & lstitems.Items(I).SubItems(1).Text & ", " _
                                    & lstitems.Items(I).Text & ", " _
                                    & lstitems.Items(I).SubItems(6).Text & ", " _
                                    & "'" & lstitems.Items(I).SubItems(7).Text & "')"
                ExecuteSQLQuery(sqlSTR)
                'sqlSTR = "UPDATE TBL_Purchase_Detail SET Item_QTY =" & "Item_QTY - " & lstitems.Items(I).SubItems(6).Text & ", " _
                '         & "Total_Price = " & CDbl((" Item_QTY - " & lstitems.Items(I).SubItems(6).Text)) * (2) _
                '          & " WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                'MsgBox(sqlSTR)

                'update purchase detail
                'total_price = CDbl(lstitems.Items(I).SubItems(5).Text - lstitems.Items(I).SubItems(6).Text) * lstitems.Items(I).SubItems(4).Text
                'sqlSTR = "UPDATE TBL_Purchase_Detail SET Item_QTY =" & "Item_QTY - " & lstitems.Items(I).SubItems(6).Text & ", " _
                '        & "Total_Price = " & total_price _
                '        & " WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                'ExecuteSQLQuery(sqlSTR)

                'update stocks
                sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_QTY =" & "Item_QTY - " & lstitems.Items(I).SubItems(6).Text & _
                         " WHERE Item_ID =" & lstitems.Items(I).Text
                ExecuteSQLQuery(sqlSTR)
            Next
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Deffective Stocks")
        Else
            For I = 0 To lstitems.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    ix = sqlDT.Rows(0)("def_QTY")
                Else
                    ix = 0
                End If

                If sqlDT.Rows.Count > 0 Then
                    'IF RECORD EXISTS THEN UPDATE
                    'MsgBox("A")

                    If sqlDT.Rows(0)("Def_QTY") > lstitems.Items(I).SubItems(6).Text Then
                        ' MsgBox("add")
                        'add 
                        '  sqlSTR = "UPDATE TBL_Deffective_PO_Details, TBL_Purchase_Detail, TBL_Stocks_Balances " & _
                        '           "SET def_QTY =" & sqlDT.Rows(0)("Def_QTY") - (sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text) & ", " _
                        '          & "TBL_Purchase_Detail.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY + " & sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text & ", " _
                        '          & "TBL_Stocks_Balances.Item_QTY =" & "TBL_Stocks_Balances.Item_QTY + " & sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text & _
                        '          " WHERE TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID " & _
                        '          " AND TBL_Stocks_Balances.Item_ID = TBL_Purchase_Detail.Item_ID " & _
                        '          " AND TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                        '          " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text

                        '       total_price = (lstitems.Items(I).SubItems(5).Text + (sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text)) * lstitems.Items(I).SubItems(4).Text

                        'sqlSTR = "UPDATE ((TBL_Deffective_PO_Details INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID) " & _
                        '         "INNER JOIN TBL_Stocks_Balances ON TBL_Purchase_Detail.Item_ID = TBL_Stocks_Balances.Item_ID) " & _
                        '         "SET def_QTY =" & sqlDT.Rows(0)("Def_QTY") - (sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text) & ", " _
                        '         & "Return_Date ='" & Format(dtRETURN.Value, "MM/dd/yyyy") & "', " _
                        '         & "TBL_Purchase_Detail.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY + " & sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text & ", " _
                        '         & "TBL_Purchase_Detail.Total_Price=" & total_price & ", " _
                        '         & "TBL_Stocks_Balances.Item_QTY =" & "TBL_Stocks_Balances.Item_QTY + " & sqlDT.Rows(0)("Def_QTY") - lstitems.Items(I).SubItems(6).Text & _
                        '         " WHERE TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                        '         " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        'ExecuteSQLQuery(sqlSTR)


                        sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                                 "SET def_QTY =" & ix - (ix - lstitems.Items(I).SubItems(6).Text) & _
                                 " WHERE TBL_Deffective_PO_Details.DEF_PO_ID =" & txtpo.Text & _
                                 " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "SELECT * FROM TBL_Purchase_Detail WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        ExecuteSQLQuery(sqlSTR)
                        item_qty = sqlDT.Rows(0)("item_qty")

                        'UPDATE PURCHASE DETAILS
                        '    sqlSTR = "UPDATE TBL_Purchase_Detail " & _
                        '             "SET Item_QTY =" & "Item_QTY + " & ix - lstitems.Items(I).SubItems(6).Text & ", " _
                        '           & "TBL_Purchase_Detail.Total_Price=" & total_price & _
                        '             " WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        '    ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                                 "SET Item_QTY =" & item_qty + (ix - lstitems.Items(I).SubItems(6).Text) & _
                                 " WHERE Item_ID =" & lstitems.FocusedItem.Text
                        ExecuteSQLQuery(sqlSTR)
                    ElseIf sqlDT.Rows(0)("Def_QTY") < lstitems.Items(I).SubItems(6).Text Then
                        ' MsgBox("Deduct")
                        'deduct
                        ' sqlSTR = "UPDATE TBL_Deffective_PO_Details, TBL_Purchase_Detail, TBL_Stocks_Balances " & _
                        '         "SET def_QTY =" & sqlDT.Rows(0)("Def_QTY") + (lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY")) & ", " _
                        '        & "TBL_Purchase_Detail.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY - " & lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY") & ", " _
                        '        & "TBL_Stocks_Balances.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY - " & lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY") & _
                        '        " WHERE TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID " & _
                        '        " AND TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                        '        " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text

                        '---------------
                        ' sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                        '                                      "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID " & _
                        '                                      "INNER JOIN TBL_Stocks_Balances ON TBL_Purchase_Detail.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                        '                                      "SET def_QTY =" & sqlDT.Rows(0)("Def_QTY") + (lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY")) & ", " _
                        '                                    & "TBL_Purchase_Detail.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY - " & lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY") & ", " _
                        '                                    & "TBL_Purchase_Detail.Total_Price=" & total_price & ", " _
                        '                                    & "TBL_Stocks_Balances.Item_QTY =" & "TBL_Purchase_Detail.Item_QTY - " & lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY") & _
                        '                                    " WHERE TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                        '                                    " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text

                        '----------------

                        total_price = (lstitems.Items(I).SubItems(5).Text - (lstitems.Items(I).SubItems(6).Text - sqlDT.Rows(0)("Def_QTY"))) * lstitems.Items(I).SubItems(4).Text

                        ' sqlSTR = "UPDATE TBL_Deffective_PO " & _
                        '          "SET Return_Date ='" & Format(dtRETURN.Value, "MM/dd/yyyy") & "' WHERE Purchase_ID =" & txtpo.Text
                        ' ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                                 "SET def_QTY =" & ix + (lstitems.Items(I).SubItems(6).Text - ix) & _
                                 " WHERE TBL_Deffective_PO_Details.DEF_PO_ID =" & txtpo.Text & _
                                 " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "SELECT * FROM TBL_Purchase_Detail WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        ExecuteSQLQuery(sqlSTR)
                        item_qty = sqlDT.Rows(0)("item_qty")

                        'UPDATE PURCHASE DETAIL
                        'sqlSTR = "UPDATE TBL_Purchase_Detail " & _
                        '         "SET Item_QTY =" & "Item_QTY - " & lstitems.Items(I).SubItems(6).Text - ix & ", " _
                        '       & "TBL_Purchase_Detail.Total_Price=" & total_price & _
                        '                 " WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                        'ExecuteSQLQuery(sqlSTR)


                        'MsgBox(sqlDT.Rows(0)("Item_QTY"))
                        sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                                 "SET Item_QTY = Item_QTY -" & CDbl(lstitems.Items(I).SubItems(6).Text) & _
                                 " WHERE Item_ID =" & lstitems.Items(I).Text 'FocusedItem.Text
                        '"SET Item_QTY =" & item_qty - (lstitems.Items(I).SubItems(6).Text - ix) & _

                        'MsgBox(sqlSTR)
                        ExecuteSQLQuery(sqlSTR)
                    End If
                Else
                    'If RECORD NOT EXISTS THEN ADD 
                    'MsgBox("extra")
                    'MsgBox("Extra")
                    sqlSTR = "SELECT * FROM TBL_Deffective_PO WHERE Purchase_ID =" & txtpo.Text
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count = 0 Then
                        sqlSTR = "INSERT INTO TBL_Deffective_PO (Purchase_ID, SupplierName, Delivery_term, Address, Return_Date) " & _
                                 "VALUES (" & txtpo.Text & ", " _
                                      & "'" & R_eplace(txtSuppname.Text) & "', " _
                                      & "'" & R_eplace(txtdeliver.Text) & "', " _
                                      & "'" & R_eplace(txtadd.Text) & "', " _
                                      & "'" & Format(dtRETURN.Value, "MM/dd/yyyy") & "')"
                        ExecuteSQLQuery(sqlSTR)
                    End If

                    sqlSTR = "INSERT INTO TBL_Deffective_PO_Details (Purchase_ID, Purchase_Detail_ID, Item_ID, Def_Qty, Unit) " & _
                             "VALUES (" & txtpo.Text & ", " _
                                        & lstitems.Items(I).SubItems(1).Text & ", " _
                                        & lstitems.Items(I).Text & ", " _
                                        & lstitems.Items(I).SubItems(6).Text & ", " _
                                        & "'" & lstitems.Items(I).SubItems(7).Text & "')"
                    ExecuteSQLQuery(sqlSTR)
                    '---
                    total_price = (lstitems.Items(I).SubItems(5).Text - lstitems.Items(I).SubItems(6).Text) * lstitems.Items(I).SubItems(4).Text

                    '    sqlSTR = "UPDATE ((TBL_Deffective_PO_Details INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_Detail_ID = TBL_Purchase_Detail.Purchase_Detail_ID) " & _
                    '             "INNER JOIN TBL_Stocks_Balances ON TBL_Purchase_Detail.Item_ID = TBL_Stocks_Balances.Item_ID) " & _
                    '             "SET def_QTY =" & lstitems.Items(I).SubItems(6).Text & ", " _
                    '           & "TBL_Purchase_Detail.Item_QTY =" & lstitems.Items(I).SubItems(5).Text - lstitems.Items(I).SubItems(6).Text & ", " _
                    '           & "TBL_Purchase_Detail.Total_Price=" & total_price & ", " _
                    '           & "TBL_Stocks_Balances.Item_QTY =" & lstitems.Items(I).SubItems(5).Text - lstitems.Items(I).SubItems(6).Text & _
                    '           " WHERE TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                    '           " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                    sqlSTR = "UPDATE TBL_Deffective_PO " & _
                             "SET Return_Date ='" & Format(dtRETURN.Value, "MM/dd/yyyy") & "' WHERE Purchase_ID =" & txtpo.Text
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                             "SET def_QTY =" & (lstitems.Items(I).SubItems(6).Text) & _
                             " WHERE TBL_Deffective_PO_Details.Purchase_ID =" & txtpo.Text & _
                             " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                    ExecuteSQLQuery(sqlSTR)

                    'UPDATE PURCHASE DETAILS
                    '  sqlSTR = "UPDATE TBL_Purchase_Detail " & _
                    '           "SET Item_QTY =" & "Item_QTY - " & lstitems.Items(I).SubItems(6).Text & ", " _
                    '         & "TBL_Purchase_Detail.Total_Price=" & total_price & _
                    '           " WHERE Purchase_Detail_ID =" & lstitems.Items(I).SubItems(1).Text
                    ' ExecuteSQLQuery(sqlSTR)

                    'MsgBox(sqlDT.Rows(0)("Item_QTY"))
                    sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                             "SET Item_QTY = Item_QTY - " & lstitems.Items(I).SubItems(6).Text & _
                             " WHERE Item_ID =" & lstitems.Items(I).Text ' FocusedItem.Text
                    'MsgBox(sqlSTR)
                    ExecuteSQLQuery(sqlSTR)
                End If
            Next
            sqlSTR = "UPDATE TBL_Deffective_PO " & _
                     "SET Return_Date ='" & Format(dtRETURN.Value, "MM/dd/yyyy") & "' WHERE Purchase_ID =" & txtpo.Text
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Deffective Stocks")
        End If
        'If Pending_ID > 0 Then
        ' sqlSTR = "UPDATE TBL_Pending_Item SET Returnx = 'Yes' " & ", " _
        '              & " Return_Date ='" & Format(dtRETURN.Value, "MM/dd/yyyy") & "'" & _
        '                 " WHERE Pending_ID =" & Pending_ID
        '
        '        ExecuteSQLQuery(sqlSTR)
        '       End If
        MsgBox("Record successfuly updated !!", MsgBoxStyle.Information, "Sales and Inventory")
        With FrmDEFFECTIVE_RETURN_STOCKS
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Delivery_Term as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',','), Pending_ID AS 'Pending ID' FROM TBL_Deffective_PO " & _
                     "WHERE Return_Date ='" & Format(.dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
            FillListView(ExecuteSQLQuery(sqlSTR), .lstdeffect, 0)
            For I = 0 To .lstdeffect.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & .lstdeffect.Items(I).Text & _
                         " AND Fully_Return='Yes'" & _
                         " ORDER BY Def_PO_ID ASC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    .lstdeffect.Items(I).ForeColor = Color.Brown
                Else
                    .lstdeffect.Items(I).ForeColor = Color.Black
                End If
            Next
        End With

        Pending_ID = 0
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstitems.Items.Count = 0 Then Exit Sub
        lstitems.Focus()
        With FrmDEFFECTIVE_STOCKS_DATA_ADD
            .txtid.Text = Me.lstitems.FocusedItem.Text
            .txtdtl.Text = Me.lstitems.FocusedItem.SubItems(1).Text
            .txtname.Text = Me.lstitems.FocusedItem.SubItems(2).Text
            .txtdesc.Text = Me.lstitems.FocusedItem.SubItems(3).Text
            .txtprice.Text = Me.lstitems.FocusedItem.SubItems(4).Text
            '.txtbarcode.Text = Me.lstitems.FocusedItem.SubItems(5).Text
            .txtqty.Text = Me.lstitems.FocusedItem.SubItems(5).Text
            .txtdefqty.Text = Me.lstitems.FocusedItem.SubItems(6).Text
            .txtunit.Text = Me.lstitems.FocusedItem.SubItems(7).Text
        End With
        FormShow(FrmDEFFECTIVE_STOCKS_DATA_ADD, True, lstitems.FocusedItem.SubItems(1).Text, txtpo.Text)
    End Sub
End Class