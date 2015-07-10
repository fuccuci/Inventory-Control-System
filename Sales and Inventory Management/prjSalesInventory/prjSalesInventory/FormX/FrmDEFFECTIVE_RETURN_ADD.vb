Public Class FrmDEFFECTIVE_RETURN_ADD
    Dim return_ID As Integer
    Dim _Match As Boolean
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmDEFFECTIVE_RETURN_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Defective Return Stocks"
    End Sub

    Private Sub FrmDEFFECTIVE_RETURN_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstitems.Items.Clear()
        If Split(Me.Text, " - ")(1) = "Add" Then
            'FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD.ShowDialog()
            FrmDEFFECTIVE_RETURN_PENDING.ShowDialog()
        Else
            txtpo.Text = globalID
            sqlSTR = "SELECT  *, *, *, * " & _
                     "FROM TBL_Deffective_PO_Details " & _
                     "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO_Details.DEF_PO_ID = TBL_Deffective_PO_Return.DEF_PO_ID " & _
                     "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                     " AND TBL_Deffective_PO_Return_Details.Item_ID  = TBL_Deffective_PO_Details.Item_ID " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Return_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                     "INNER JOIN TBL_Purchase_Order ON TBL_Deffective_PO_Return.Purchase_ID = TBL_Purchase_Order.Purchase_ID " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_Id = TBL_Purchase_Detail.Purchase_ID " & _
                     " AND TBL_Purchase_Detail.Item_ID = TBL_Deffective_PO_Return_Details.Item_ID " & _
                     "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     "WHERE TBL_Deffective_PO_Details.DEF_PO_ID =" & txtpo.Text
            'fix bugs 'z123
            'MsgBox(txtpo.Text)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                return_ID = sqlDT.Rows(0)("Return_ID")
                txtSuppname.Text = R_Change(sqlDT.Rows(0)("suppname"))
                txtadd.Text = R_Change(sqlDT.Rows(0)("address"))
                txtdeliver.Text = R_Change(sqlDT.Rows(0)("delivery_term"))
                txtreturn.Text = sqlDT.Rows(0)("Return_Date")
            End If

            For i = 0 To sqlDT.Rows.Count - 1
                With lstitems
                    .Items.Add(sqlDT.Rows(i)("Item_ID"))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Purchase_Detail_ID"))
                    .Items((.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Def_QTY") - sqlDT.Rows(i)("Return_QTY"))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Return_QTY"))
                    .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Unit"))
                End With
            Next
            cmdSave.Enabled = False
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        Dim total_price As Double
        Dim return_QTY As Integer, Item_QTY As Integer
        Dim return_IDx As Integer
        Item_QTY = 0 'no use
        total_price = 0 'no use
        If Split(Me.Text, " - ")(1) = "Add" Then

            If lstitems.Items.Count = 0 Then
                MsgBox("No item details, please add details !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            sqlSTR = "INSERT INTO TBL_Deffective_PO_Return (DEF_PO_ID, Purchase_ID, SupplierName, Delivery_term, Address, Return_Date, Fully_Return) " & _
                           "VALUES (" & txtpo.Text & ", " _
                                      & txtpo2.Text & ", " _
                                  & "'" & R_eplace(txtSuppname.Text) & "', " _
                                  & "'" & txtdeliver.Text & "', " _
                                  & "'" & R_eplace(txtadd.Text) & "', " _
                                  & "'" & txtreturn.Text & "', " _
                                  & "'Yes'" & ")"
            'MsgBox(sqlSTR)
            ExecuteSQLQuery(sqlSTR)
            'MsgBox(sqlSTR)
            sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return ORDER BY Return_ID DESC"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                return_IDx = sqlDT.Rows(0)("Return_ID")
            End If
            For i = 0 To lstitems.Items.Count - 1
                sqlSTR = "INSERT INTO TBL_Deffective_PO_Return_Details (Purchase_ID, Return_ID, Purchase_Detail_ID, Item_ID, Return_Qty, Unit) " & _
                         "VALUES (" & txtpo2.Text & ", " _
                                    & return_IDx & ", " _
                                    & lstitems.Items(i).SubItems(1).Text & ", " _
                                    & lstitems.Items(i).Text & ", " _
                                    & lstitems.Items(i).SubItems(6).Text & ", " _
                                    & "'" & lstitems.Items(i).SubItems(7).Text & "')"
                ExecuteSQLQuery(sqlSTR)

                ''UPDATE DEFECTIVE QTY

                'sqlSTR = "UPDATE TBL_Deffective_PO_Details SET def_QTY = def_QTY - " & lstitems.Items(i).SubItems(6).Text & _
                '         "WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text & _
                '         " AND DEF_PO_ID =" & txtpo.Text
                'ExecuteSQLQuery(sqlSTR)

                ''UPDATE PURCHASE QTY
                'total_price = CDbl((CDbl(lstitems.Items(i).SubItems(3).Text) + CDbl(lstitems.Items(i).SubItems(6).Text))) * CDbl(lstitems.Items(i).SubItems(4).Text)
                'sqlSTR = "UPDATE TBL_Purchase_Detail SET Item_QTY =" & "Item_QTY + " & lstitems.Items(i).SubItems(6).Text & ", " _
                '        & "Total_Price = " & total_price _
                '        & " WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                'ExecuteSQLQuery(sqlSTR)

                'UPDATE STOCKS
                sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_QTY =" & "Item_QTY + " & lstitems.Items(i).SubItems(6).Text & _
                         " WHERE Item_ID =" & lstitems.Items(i).Text
                ExecuteSQLQuery(sqlSTR)

                'find if it's a pending item
                '----
                'sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details " & _
                '         "WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text & _
                '         " AND DEF_PO_ID =" & txtpo.Text

                'ExecuteSQLQuery(sqlSTR)
                'If sqlDT.Rows.Count > 0 Then
                ' If sqlDT.Rows(0)("Pending_ID") > 0 Then
                ' sqlSTR = "UPDATE TBL_Pending_Item SET Returnx = 'Yes' " & ", " _
                '        & "Return_Date ='" & txtreturn.Text & _
                '          "' WHERE Pending_ID =" & sqlDT.Rows(0)("Pending_ID")
                ' ExecuteSQLQuery(sqlSTR)

                ' sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_QTY =" & "Item_QTY + " & lstitems.Items(i).SubItems(6).Text & _
                '          " WHERE Item_ID =" & lstitems.Items(i).Text
                ' ExecuteSQLQuery(sqlSTR)
                'End If
                'Else
                ' sqlSTR = "UPDATE TBL_Stocks_Balances SET Item_QTY =" & "Item_QTY + " & lstitems.Items(i).SubItems(6).Text & _
                '          " WHERE Item_ID =" & lstitems.Items(i).Text
                ' ExecuteSQLQuery(sqlSTR)
                'End If
            Next



            'CHECK IF IT IS FULLY RETURNED
            '
            sqlSTR = "SELECT *, *, *, * " & _
                     "FROM TBL_Deffective_PO " & _
                     "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO.Def_PO_ID = TBL_Deffective_PO_Return.Def_PO_ID " & _
                     "INNER JOIN TBL_Deffective_PO_Details ON TBL_Deffective_PO_Return.Def_PO_ID = TBL_Deffective_PO_Details.Def_PO_ID " & _
                     "LEFT OUTER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                     " AND TBL_Deffective_PO_Details.Item_ID = TBL_Deffective_PO_Return_Details.Item_ID " & _
                     "WHERE TBL_Deffective_PO.Def_PO_ID =" & txtpo.Text & _
                     " ORDER BY TBL_Deffective_PO_Details.Item_ID ASC"
            ExecuteSQLQuery(sqlSTR)
            ' MsgBox(sqlDT.Rows(0)("Def_ID") & " -- " & sqlDT.Rows(0)("Return_ID"))
            If sqlDT.Rows.Count > 0 Then
                For x = 0 To sqlDT.Rows.Count - 1
                    If sqlDT.Rows(x)("Return_QTY").ToString <> "" Then
                        _Match = True
                        If CDbl(sqlDT.Rows(x)("Def_QTY")) <> CDbl(sqlDT.Rows(x)("Return_QTY")) Then
                            _Match = False
                            Exit For
                        Else
                            _Match = True
                        End If
                    Else
                        _Match = False
                        Exit For
                    End If
                Next
                If Not _Match Then
                    sqlSTR = "UPDATE TBL_Deffective_PO_Return SET Fully_Return = 'No' WHERE DEF_PO_ID =" & txtpo.Text
                    ExecuteSQLQuery(sqlSTR)
                End If
            End If
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Return Stocks")
        Else
            'EDIT
            For i = 0 To lstitems.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return_Details WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    '-comment
                    return_QTY = sqlDT.Rows(0)("Return_QTY")
                    If CDbl(lstitems.Items(i).SubItems(5).Text) > 0 Then
                        sqlSTR = "SELECT * FROM " & _
                                 "TBL_Deffective_PO_Return_Details WHERE Return_ID =" & return_ID & _
                                 " AND Item_ID =" & lstitems.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                        If sqlDT.Rows.Count > 0 Then
                            sqlSTR = "UPDATE TBL_Deffective_PO_Return_Details " & _
                                     "SET Return_QTY = Return_QTY + " & lstitems.Items(i).SubItems(6).Text & _
                                     " WHERE Return_ID =" & return_ID & _
                                     " AND Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                            ExecuteSQLQuery(sqlSTR)
                        Else
                            'ADD NEW DATA IF NOT FIND
                            sqlSTR = "INSERT INTO TBL_Deffective_PO_Return_Details (Purchase_ID, Return_ID, Purchase_Detail_ID, Item_ID, Return_Qty, Unit) " & _
                                     "VALUES (" & txtpo2.Text & ", " _
                                                & return_ID & ", " _
                                                & lstitems.Items(i).SubItems(1).Text & ", " _
                                                & lstitems.Items(i).Text & ", " _
                                                & lstitems.Items(i).SubItems(6).Text & ", " _
                                                & "'" & lstitems.Items(i).SubItems(7).Text & "')"
                            ExecuteSQLQuery(sqlSTR)
                        End If
 
                    End If

                    'end

                    'If sqlDT.Rows(0)("Return_QTY") > lstitems.Items(i).SubItems(6).Text Then
                    'add 3 > 2

                    'UPDATE DEFECTIVE PO DETAILS
                    'sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                    '         "SET def_QTY = def_QTY - " & CDbl(lstitems.Items(i).SubItems(6).Text) & _
                    '         " WHERE TBL_Deffective_PO_Details.DEF_PO_ID =" & txtpo.Text
                    ''"AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ''"SET def_QTY = def_QTY + " & (return_QTY - lstitems.Items(i).SubItems(6).Text) & _

                    ''--UNCOMMENT
                    'ExecuteSQLQuery(sqlSTR)
                    'sqlSTR = "UPDATE TBL_Deffective_PO_Return_Details " & _
                    '         "SET Return_QTY = Return_QTY + " & lstitems.Items(i).SubItems(6).Text & _
                    '         " WHERE Return_ID =" & return_ID & _
                    '         " AND Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    'ExecuteSQLQuery(sqlSTR)
                    ''--END

                    '------can be uncomment
                    'UPDATE PURCHASE DETAIL
                    ' total_price = (CDbl(lstitems.Items(i).SubItems(3).Text) + (CDbl(lstitems.Items(i).SubItems(5).Text) - CDbl(lstitems.Items(i).SubItems(6).Text))) * CDbl(lstitems.Items(i).SubItems(4).Text)
                    ' sqlSTR = "SELECT * FROM TBL_Purchase_Detail WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ' ExecuteSQLQuery(sqlSTR)
                    ' Item_QTY = sqlDT.Rows(0)("Item_QTY")

                    ''MsgBox((sqlDT.Rows(0)("Item_QTY") - (CDbl(lstitems.Items(i).SubItems(5).Text) + return_QTY)) + CDbl(lstitems.Items(i).SubItems(6).Text))
                    'sqlSTR = "UPDATE TBL_Purchase_Detail " & _
                    '         "SET Item_QTY = Item_QTY + " & CDbl(lstitems.Items(i).SubItems(6).Text) & ", " _
                    '       & "Total_Price=" & total_price & _
                    '         " WHERE Purchase_ID =" & txtpo.Text & _
                    '         " AND Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ''"SET Item_QTY = " & (sqlDT.Rows(0)("Item_QTY") - return_QTY) + CDbl(lstitems.Items(i).SubItems(6).Text) & ", " _
                    'ExecuteSQLQuery(sqlSTR)
                    '-----------

                    ''--UNCOMMENT
                    ''update balances
                    'sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                    '         "SET Item_QTY = Item_QTY + " & CDbl(lstitems.Items(i).SubItems(6).Text) & _
                    '         "WHERE Item_ID =" & lstitems.Items(i).Text
                    ''"SET Item_QTY = " & (Item_QTY - return_QTY) + CDbl(lstitems.Items(i).SubItems(6).Text) & _
                    'ExecuteSQLQuery(sqlSTR)
                    '---END
                    'ElseIf sqlDT.Rows(0)("Return_QTY") < lstitems.Items(i).SubItems(6).Text Then

                    'DEDUCT--
                    'UPDATE DEFECTIVE PO DETAILS
                    'sqlSTR = "UPDATE TBL_Deffective_PO_Details " & _
                    '         "SET def_QTY = def_QTY - " & CDbl(lstitems.Items(i).SubItems(6).Text) & _
                    '         " WHERE TBL_Deffective_PO_Details.DEF_PO_ID =" & txtpo.Text
                    '' " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ''"SET def_QTY = def_QTY - " & (CDbl(lstitems.Items(i).SubItems(6).Text) - return_QTY) & _
                    'ExecuteSQLQuery(sqlSTR)

                    '-uncomment
                    'sqlSTR = "UPDATE TBL_Deffective_PO_Return_Details " & _
                    '         "SET Return_QTY = Return_QTY - " & lstitems.Items(i).SubItems(6).Text & _
                    '         " WHERE Return_ID =" & return_ID & _
                    '         " AND Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    'ExecuteSQLQuery(sqlSTR)
                    ''--END
                    'UPDATE DETAILS
                    ' sqlSTR = "SELECT * FROM TBL_Purchase_Detail WHERE Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ' ExecuteSQLQuery(sqlSTR)
                    ' Item_QTY = sqlDT.Rows(0)("Item_QTY")

                    '                        total_price = CDbl(CDbl(sqlDT.Rows(0)("Item_QTY") - return_QTY) + CDbl(lstitems.Items(i).SubItems(6).Text)) * lstitems.Items(i).SubItems(4).Text

                    '                      sqlSTR = "UPDATE TBL_Purchase_Detail " & _
                    '                                "SET Item_QTY = Item_QTY + " & lstitems.Items(i).SubItems(6).Text & ", " _
                    '     & "Total_Price=" & total_price & _
                    '       " WHERE Purchase_ID =" & txtpo.Text & _
                    '       " AND Purchase_Detail_ID =" & lstitems.Items(i).SubItems(1).Text
                    ''"SET Item_QTY = " & (sqlDT.Rows(0)("Item_QTY") - return_QTY) + CDbl(lstitems.Items(i).SubItems(6).Text) & ", " _

                    'ExecuteSQLQuery(sqlSTR)


                    ''--- uncomennt
                    'UPDATE STOCK BALANCES
                    sqlSTR = "UPDATE TBL_Stocks_Balances " & _
                             "SET Item_QTY = Item_QTY + " & CDbl(lstitems.Items(i).SubItems(6).Text) & _
                             "WHERE Item_ID =" & lstitems.Items(i).Text
                    ' '                                 "SET Item_QTY = " & (Item_QTY - return_QTY) + CDbl(lstitems.Items(i).SubItems(6).Text) & _
                    ExecuteSQLQuery(sqlSTR)
                    'Else
                    'MsgBox("RETURN")
                    'MsgBox(lstitems.FocusedItem.Text)
                    'End If
                Else
                    'MsgBox("RETURN HERE")
                End If
            Next

            'CHECK IF IT IS FULLY RETURNED
            sqlSTR = "SELECT *, *, *, * " & _
                     "FROM TBL_Deffective_PO " & _
                     "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO.Def_PO_ID = TBL_Deffective_PO_Return.Def_PO_ID " & _
                     "INNER JOIN TBL_Deffective_PO_Details ON TBL_Deffective_PO_Return.Def_PO_ID = TBL_Deffective_PO_Details.Def_PO_ID " & _
                     "LEFT OUTER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                     " AND TBL_Deffective_PO_Details.Item_ID = TBL_Deffective_PO_Return_Details.Item_ID " & _
                     "WHERE TBL_Deffective_PO.Def_PO_ID =" & txtpo.Text & _
                     " ORDER BY TBL_Deffective_PO_Details.Item_ID ASC"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                For x = 0 To sqlDT.Rows.Count - 1
                    If sqlDT.Rows(x)("Return_QTY").ToString <> "" Then
                        _Match = True
                        If CDbl(sqlDT.Rows(x)("Def_QTY")) <> CDbl(sqlDT.Rows(x)("Return_QTY")) Then
                            _Match = False
                            Exit For
                        Else
                            _Match = True
                        End If
                    Else
                        _Match = False
                        Exit For
                    End If
                Next
                If Not _Match Then
                    sqlSTR = "UPDATE TBL_Deffective_PO_Return SET Fully_Return ='No' WHERE DEF_PO_ID =" & txtpo.Text
                    ExecuteSQLQuery(sqlSTR)
                Else
                    sqlSTR = "UPDATE TBL_Deffective_PO_Return SET Fully_Return ='Yes' WHERE DEF_PO_ID =" & txtpo.Text
                    ExecuteSQLQuery(sqlSTR)
                End If
                With FrmDEFFECTIVE_RETURN_STOCKS
                    sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Fully_Return AS 'Return' FROM TBL_Deffective_PO_Return " & _
                             "WHERE Return_Date ='" & Format(.dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
                    FillListView(ExecuteSQLQuery(sqlSTR), .lstdeffect, 0)
                    For i = 0 To .lstdeffect.Items.Count - 1
                        'MsgBox(.lstdeffect.Items(i).SubItems(5).Text)
                        If .lstdeffect.Items(i).SubItems(5).Text = "Yes" Then
                            .lstdeffect.Items(i).ForeColor = Color.Brown
                        Else
                            .lstdeffect.Items(i).ForeColor = Color.Black
                        End If
                    Next
                End With

            End If
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Return Stocks")
        End If
        MsgBox("Record successfuly updated !!", MsgBoxStyle.Information, "Sales and Inventory")
        Me.Close()
    End Sub

    Private Sub txtpo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpo.Click
        If Split(Me.Text, " - ")(1) = "Edit" Then Exit Sub
        FrmDEFFECTIVE_RETURN_PENDING.ShowDialog()
    End Sub

    Private Sub txtpo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpo.TextChanged
        If Split(Me.Text, " - ")(1) = "Edit" Then Exit Sub
        If txtpo.Text = "" Then Exit Sub
        'MsgBox(txtpo.Text & " " & txtpo2.Text)
        'sqlSTR = "SELECT *, *, *, * " & _
        '      "FROM (((TBL_Suppliers " & _
        '      "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
        '      "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
        '      "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
        '      "WHERE TBL_Purchase_Order.Purchase_ID =" & txtpo.Text

        '---
        sqlSTR = "SELECT *, *, *, *, * " & _
                 "FROM ((((TBL_Suppliers " & _
                 "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
                 "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                 "INNER JOIN TBL_Deffective_PO ON TBL_Purchase_Order.Purchase_ID = TBL_Deffective_PO.Purchase_ID) " & _
                 "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                 "WHERE TBL_Deffective_PO.DEF_PO_ID =" & txtpo.Text
        '---
        ' MsgBox(txtpo.Text & " " & txtpo2.Text)
        'MsgBox(sqlSTR)
        ExecuteSQLQuery(sqlSTR)
        'MsgBox(sqlDT.Rows.Count)
        If sqlDT.Rows.Count > 0 Then
            txtSuppname.Text = R_Change(sqlDT.Rows(0)("suppname"))
            txtadd.Text = R_Change(sqlDT.Rows(0)("address"))
            txtdeliver.Text = R_Change(sqlDT.Rows(0)("delivery_term"))
        Else
            sqlSTR = "SELECT *, *, *, * " & _
                     "FROM (((TBL_Suppliers " & _
                     "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                     "WHERE TBL_Purchase_Order.Purchase_ID =" & txtpo2.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtSuppname.Text = R_Change(sqlDT.Rows(0)("suppname"))
                txtadd.Text = R_Change(sqlDT.Rows(0)("address"))
                txtdeliver.Text = R_Change(sqlDT.Rows(0)("delivery_term"))
            End If
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtpo.Text = "" Then Exit Sub
        FormShow(FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD, False, 0, 0)
        'FrmDEFFECTIVE_RETURN_STOCK_LIST.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstitems.Items.Count = 0 Then Exit Sub
        lstitems.Focus()
        If lstitems.FocusedItem.SubItems(5).Text = 0 Then
            MsgBox("This item has already been return, modifying the data is not allowed !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        With FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD
            .txtid.Text = Me.lstitems.FocusedItem.Text
            .txtdtl.Text = Me.lstitems.FocusedItem.SubItems(1).Text
            .txtname.Text = Me.lstitems.FocusedItem.SubItems(2).Text
            .txtdesc.Text = Me.lstitems.FocusedItem.SubItems(3).Text
            .txtprice.Text = Me.lstitems.FocusedItem.SubItems(4).Text
            .Label11.Text = Me.lstitems.FocusedItem.SubItems(6).Text
            '.txtbarcode.Text = Me.lstitems.FocusedItem.SubItems(5).Text
            .txtreturnqty.Text = Me.lstitems.FocusedItem.SubItems(6).Text
            .txtdefqty.Text = Me.lstitems.FocusedItem.SubItems(5).Text
            .txtunit.Text = Me.lstitems.FocusedItem.SubItems(7).Text
        End With
        FormShow(FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD, True, lstitems.FocusedItem.SubItems(1).Text, txtpo.Text)
    End Sub
End Class