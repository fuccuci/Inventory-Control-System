'Created on August 16, 2010
'Tan, Angelito S.

'Date update dec 12, 2010
Module ModActiveForm
    Public globalID ' PASS AND USED CURRENT ID, THE MAIN PURPOSE IS TO STORE THE ID
    Public globalID2
    Public globalFRM ' PASS AND USED CURRENT FORM NAME, MAIN PURPOSE IS TO GET THE CURRENT OPEN FORMS

    Public Sub FormAdd(ByVal frmStr As String)
        'MsgBox(frmStr)
        Select Case UCase(frmStr)
            Case UCase("FrmSuppliersList")
                FormShow(FrmAddSupplier, False, 0, 0) ' Add and zero ID !

            Case UCase("frmcatlist")
                With FrmCatList
                    If .RBCat.Checked Then
                        FormShow(FrmCatADD, False, 0, 0)
                    ElseIf .rbcatitemlist.Checked Then
                        If .lstCategory.Items.Count = 0 Then Exit Sub
                        FormShow(FrmCatITEMADD, False, .lstCategory.FocusedItem.Text, 0)
                    ElseIf .RBALL.Checked Then
                        FormShow(FrmCATITEMADD_2, False, 0, 0)
                    ElseIf .RBGroup.Checked Then
                        FormShow(FrmCAT_GROUP_ADD, False, 0, 0)
                    End If
                End With

            Case UCase("frmcatitemlist") ' show to add new items
                FormShow(FrmCatITEMADD, False, FrmCatITEMList.lstCategory.FocusedItem.Text, 0)

            Case UCase("frmSTOCKMONITORINGBALANCES") 'show add stock
                FormShow(FrmSTOCKADD, False, 0, 0)

            Case UCase("FrmPURCHASEORDER")
                FormShow(FrmPURCHASEORDERADD, False, 0, 0)

            Case UCase("FrmSupplierProducts")
                'MsgBox(" Add Supplier Products")

            Case UCase("FrmUNIT_MEASURE_ADD")
                FormShow(FrmUNIT_MEASURE_ADD, False, 0, 0)

            Case UCase("FrmDEFFECTIVE_RETURN_STOCKS") ' show deffective stocks
                With FrmDEFFECTIVE_RETURN_STOCKS
                    If .rbDeffect.Checked Then
                        FormShow(FrmDEFFECTIVE_STOCKS_ADD, False, 0, 0)
                        FrmDEFFECTIVE_STOCKS_ADD.txtpo2.Text = 0
                    ElseIf .rbReturn.Checked Then
                        'FrmDEFFECTIVE_RETURN_ADD.txtpo2.Text = 0
                        FormShow(FrmDEFFECTIVE_RETURN_ADD, False, 0, 0)
                    End If
                End With
            Case UCase("frmorder_form") 'show order form
                FormShow(FrmORDER_FORM_DATA, False, 0, 0)

            Case UCase("frmphysicalcount")
                FormShow(FrmPHYSICALCOUNT_ADD, False, 0, 0)
        End Select
    End Sub

    Public Sub FormEdit(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmSuppliersList")
                With FrmSuppliersList
                    If .lstsupplier.Items.Count = 0 Then Exit Sub
                    .lstsupplier.Focus()
                    .lstsupplier.Select()
                    FormShow(FrmAddSupplier, True, .lstsupplier.FocusedItem.Text, 0) ' edit and pass the ID !
                End With

            Case UCase("frmcatlist")
                With FrmCatList
                    'If .lstCat.Items.Count = 0 Then Exit Sub ' verify if theres a record if zero record found do nothing
                    globalFRM = "frmcatlist"
                    .lstCat.Focus()
                    If .RBCat.Checked Then
                        FormShow(FrmCatADD, True, .lstCat.FocusedItem.Text, 0)
                    ElseIf .rbcatitemlist.Checked Then
                        globalFRM = "frmcatitemlist2"

                        .lstItems.Focus()
                        If .lstItems.Items.Count <= 0 Then Exit Sub
                        FormShow(FrmCatITEMADD, True, .lstCategory.FocusedItem.Text, .lstItems.FocusedItem.Text)

                    ElseIf .RBALL.Checked Then
                        FormShow(FrmCatITEMADD, True, .lstCat.FocusedItem.SubItems(1).Text, .lstCat.FocusedItem.Text)

                    ElseIf .RBGroup.Checked Then
                        FormShow(FrmCAT_GROUP_ADD, True, .lstCat.FocusedItem.Text, 0)
                    End If
                End With

            Case UCase("frmcatitemlist") ' show to edit new items
                If FrmCatITEMList.lstItems.Items.Count = 0 Then Exit Sub ' verify if theres a record if zero record found do nothing
                globalFRM = "frmcatitemlist"
                FrmCatITEMList.lstItems.Focus()
                FormShow(FrmCatITEMADD, True, FrmCatITEMList.lstCategory.FocusedItem.Text, FrmCatITEMList.lstItems.FocusedItem.Text)

                'Case UCase("frmSTOCKMONITORINGBALANCES") 'show add stock
                '    If frmSTOCKMONITORINGBALANCES.listStocks.Items.Count = 0 Then Exit Sub
                '    FormShow(FrmSTOCKADD, True, frmSTOCKMONITORINGBALANCES.listStocks.FocusedItem.Text, 0)

            Case UCase("FrmPURCHASEORDER")
                If FrmPURCHASEORDER.listorder.Items.Count = 0 Then Exit Sub
                FrmPURCHASEORDER.listorder.Focus()
                FormShow(FrmPURCHASEORDERADD, True, FrmPURCHASEORDER.listorder.FocusedItem.Text, 0)

            Case UCase("FrmSupplierProducts")
                'MsgBox(" Add Supplier Products")
            Case UCase("frmUnit_Measure")
                If FrmUNIT_MEASURE.lstunit.Items.Count = 0 Then Exit Sub
                FormShow(FrmUNIT_MEASURE_ADD, True, FrmUNIT_MEASURE.lstunit.FocusedItem.Text, 0)
            Case UCase("FrmDEFFECTIVE_RETURN_STOCKS")
                With FrmDEFFECTIVE_RETURN_STOCKS
                    If .lstdeffect.Items.Count = 0 Then Exit Sub
                    .lstdeffect.Focus()
                    If .rbDeffect.Checked Then
                        FrmDEFFECTIVE_STOCKS_ADD.txtpo2.Text = .lstdeffect.FocusedItem.SubItems(1).Text
                        FormShow(FrmDEFFECTIVE_STOCKS_ADD, True, .lstdeffect.FocusedItem.Text, 0)
                    ElseIf .rbReturn.Checked Then
                        FrmDEFFECTIVE_RETURN_ADD.txtpo2.Text = .lstdeffect.FocusedItem.SubItems(1).Text
                        FormShow(FrmDEFFECTIVE_RETURN_ADD, True, .lstdeffect.FocusedItem.Text, 0)
                    End If
                End With
            Case UCase("FrmORDER_FORM")
                With FrmORDER_FORM
                    .lstOrder.Focus()
                    If .lstOrder.Items.Count > 0 Then
                        FormShow(FrmORDER_FORM_DATA, True, .lstOrder.FocusedItem.Text, 0)
                    End If
                End With
            Case UCase("frmphysicalcount")
                With FrmPhysicalCount
                    If .lstphysical.Items.Count = 0 Then Exit Sub
                    .lstphysical.Focus()
                    .lstphysical.Select()
                    FormShow(FrmPHYSICALCOUNT_ADD, True, .lstphysical.FocusedItem.Text, 0)
                End With
        End Select
    End Sub

    'DELETE
    Public Sub FormDelete(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmCatList")
                With FrmCatList
                    If .RBALL.Checked Or .RBCat.Checked Then
                        If MsgBox("Do you want to delete this record ???", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sales and Inventory") = MsgBoxResult.Yes Then
                            'LIST ALL PRODUCT
                            If .RBALL.Checked Then
                                sqlSTR = "SELECT * FROM TBL_Stocks_Balances WHERE Item_ID =" & .lstCat.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                If sqlDT.Rows.Count > 0 Then
                                    MsgBox("This item is currenty used in stock balances ", MsgBoxStyle.Information, "Sales and Inventory")
                                    Exit Sub
                                Else
                                    sqlSTR = "DELETE FROM TBL_Category_Item_File WHERE Item_ID =" & .lstCat.FocusedItem.Text
                                    ExecuteSQLQuery(sqlSTR)
                                    sqlSTR = "DELETE FROM TBL_Suppliers_Product WHERE Item_ID =" & .lstCat.FocusedItem.Text
                                    ExecuteSQLQuery(sqlSTR)
                                    'MsgBox("Record has been successfuly deleted !!!", MsgBoxStyle.Information, "Sales and Inventory")
                                    ' FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', Item_Name as 'Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Price as 'Price' FROM TBL_Category_Item_File"), .lstCat, 1)
                                    FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', Item_Name as 'Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Org_Price as 'Price', Item_Price as 'Price (VAT 12%)', Unit_Measure as 'Measure' FROM TBL_Category_Item_File"), .lstCat, 1)

                                End If
                            Else
                                'BY CATEGORY
                                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Catg_ID =" & .lstCat.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                If sqlDT.Rows.Count > 0 Then
                                    MsgBox("This category has detail(s) and in used by item file !!", MsgBoxStyle.Information, "Sales and Inventory")
                                    Exit Sub
                                Else
                                    sqlSTR = "DELETE FROM TBL_Category_File WHERE Catg_ID =" & .lstCat.FocusedItem.Text
                                    ExecuteSQLQuery(sqlSTR)
                                    ' MsgBox("Record has been successfuly deleted !!!", MsgBoxStyle.Information, "Sales and Inventory")
                                    FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), .lstCat, 1)
                                End If
                            End If
                        End If
                    End If
                End With
            Case UCase("FrmSuppliersList")
                With FrmSuppliersList
                    If .lstsupplier.Items.Count > 0 Then
                        If MsgBox("Do you really want to delete this record ???", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sales and Inventory") = MsgBoxResult.Yes Then
                            sqlSTR = "SELECT * FROM TBL_Purchase_Order WHERE Supp_ID =" & .lstsupplier.FocusedItem.Text
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MsgBox("Record exists in purchase order form", MsgBoxStyle.Critical, "Sales and Inventory")
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM TBL_Suppliers WHERE Supp_ID=" & .lstsupplier.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                sqlSTR = "DELETE FROM TBL_Suppliers_Product WHERE Supp_ID=" & .lstsupplier.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                'MsgBox("Record has been successfuly deleted", MsgBoxStyle.Information, "Sales and Inventory")
                            End If
                        End If
                    End If
                End With
            Case UCase("FrmPURCHASEORDER")
                With FrmPURCHASEORDER
                    If .listorder.Items.Count > 0 Then
                        If .listorder.FocusedItem.SubItems(4).Text <> "Yes" Then
                            If MsgBox("Do you really want to delete this record ??", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sales and Inventory") = MsgBoxResult.Yes Then
                                sqlSTR = "DELETE FROM TBL_Purchase_Order WHERE TBL_Purchase_Order.Purchase_ID =" & .listorder.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                sqlSTR = "DELETE FROM TBL_Purchase_Detail WHERE TBL_Purchase_Detail.Purchase_ID =" & .listorder.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                'MsgBox("Record has been successfuly deleted", MsgBoxStyle.Information, "Sales and Inventory")
                                sqlSTR = "SELECT Purchase_ID as 'ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                                         " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID ORDER BY Purchase_ID"
                                FillListView(ExecuteSQLQuery(sqlSTR), .listorder, 0)

                            End If
                        Else
                            MsgBox("This record has been APPROVED, delete not granted !!!", MsgBoxStyle.Information, "Sales and Inventory")
                        End If
                    End If
                End With
            Case UCase("frmSTOCKMONITORINGBALANCES")
                With frmSTOCKMONITORINGBALANCES
                    sqlSTR = "SELECT * FROM TBL_Stocks_Balances WHERE Item_ID =" & .listStocks.FocusedItem.Text
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows(0)("Item_QTY") = 0 Then
                        sqlSTR = "DELETE FROM TBL_Stocks_Balances WHERE Item_ID =" & .listStocks.FocusedItem.Text
                        ExecuteSQLQuery(sqlSTR)
                        'MsgBox("Record successfuly deleted", MsgBoxStyle.Information, "Sales and Inventory")
                        sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.item_price as 'Price', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total', DIRECT_INPUT AS 'DIRECT' " & _
                                 "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID "
                        FillListView(ExecuteSQLQuery(sqlSTR), .listStocks, 0)
                    Else
                        MsgBox("Cannot delete this record, quantity is above zero !!", MsgBoxStyle.Information, "Sales and Inventory")
                    End If
                End With
            Case UCase("frmorder_form")
                With FrmORDER_FORM
                    If .lstOrder.Items.Count > 0 Then
                        .lstOrder.Focus()
                        If MsgBox("Do you really want to delete this record ???", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
                            sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Order_No =" & .lstOrder.FocusedItem.Text
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MsgBox("Can't continue deleting this record, Void this ORDER NO first !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM TBL_Orders WHERE Order_No =" & .lstOrder.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                sqlSTR = "DELETE FROM TBL_Orders_Detail WHERE Order_No =" & .lstOrder.FocusedItem.Text
                                ExecuteSQLQuery(sqlSTR)
                                sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_Date ='" & Format(.dtOrder.Value, "MM/dd/yyyy") & "'"
                                FillListView(ExecuteSQLQuery(sqlSTR), .lstOrder, 0)
                            End If
                        End If
                    End If
                End With
        End Select
    End Sub
    'SEARCH
    Public Sub FormSearch(ByVal frmStr As String)
        Select Case UCase(frmStr)
            Case UCase("FrmCatList")
                With FrmCatList
                    'If .RBALL.Checked Or .RBCat.Checked Or .rbcatitemlist.Checked Then
                    'MsgBox("here")
                    '   If Not .rbcatitemlist.Checked Then
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtcatname.Text = ""
                    .grpCat.Visible = True
                    .RBCat.Enabled = False
                    .RBALL.Enabled = False
                    .rbcatitemlist.Enabled = False
                    .txtcatname.Select()
                    ' End If

                    'End If
                End With
            Case UCase("FrmSuppliersList")
                With FrmSuppliersList
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("FrmSUPPLIERSPRODUCT")
                With FrmSUPPLIERSPRODUCT
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("FrmPURCHASEORDER")
                With FrmPURCHASEORDER
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("FrmPURCHASEORDER_RECEIVE")
                With FrmPURCHASEORDER_RECEIVE
                    '.Enabled = False
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("frmSTOCKMONITORINGBALANCES")
                With frmSTOCKMONITORINGBALANCES
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("frmDeffective_Return_Stocks")
                With FrmDEFFECTIVE_RETURN_STOCKS
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .txtname.Text = ""
                    .grpCat.Visible = True
                    .txtname.Select()
                End With
            Case UCase("frmposreceipt_list")
                With FrmPOSRECEIPT_LIST
                    .grpreceipt.Left = (.Width / 2) - (.grpreceipt.Width / 2)
                    .grpreceipt.Visible = True
                    .txtreceiptid.Text = ""
                    .txtreceiptid.Select()
                End With
            Case UCase("frmorder_form")
                With FrmORDER_FORM
                    .txtorder.Text = 0
                    .grpCat.Left = (.Width / 2) - (.grpCat.Width / 2)
                    .grpCat.Visible = True
                    .txtorder.Select()
                End With
        End Select
    End Sub

    'PRINTING
    Public Sub FormPrint(ByVal frmStr As String)
        Dim Report As New FrmREPORTS
        Select Case UCase(frmStr)
            Case UCase("frmcatitemlist") 'CATEGORY ITEM LIST PRINT
                globalFRM = "FrmCatITEMList"
                FrmCATEGORY_ITEM_PRINT.ShowDialog()

            Case UCase("FrmSuppliersList") 'PRINT SUPPLIER LIST
                With FrmSuppliersList
                    If .rbsuplist.Checked Then
                        globalFRM = "FrmSuppliersList"
                        Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName"
                        Report.Show()
                    ElseIf .rbsuppro.Checked Then
                        globalFRM = "frmsuppliersproduct"
                        FrmSUPPLIER_PRODUCT_PRINT.ShowDialog()
                    End If
                End With
                'FrmREPORTS.Show()
            Case UCase("frmsuppliersproduct") ' PRINT SUPPLIERS PRODUCT
                globalFRM = "frmsuppliersproduct"
                FrmSUPPLIER_PRODUCT_PRINT.ShowDialog()

            Case UCase("FrmPURCHASEORDER") ' PRINT PURCHASE ORDER
                With FrmPURCHASEORDER
                    If .rbpurchase.Checked Then
                        globalFRM = "FrmPURCHASEORDER"
                        FrmPURCHASE_ORDER_PRINT.ShowDialog()
                    Else
                        globalFRM = "frmpurchaseorder_receive"
                        FrmRECEIVE_ORDER_PRINT.ShowDialog()
                    End If
                End With

            Case UCase("frmpurchaseorder_receive")
                globalFRM = "frmpurchaseorder_receive"
                FrmRECEIVE_ORDER_PRINT.ShowDialog()

            Case UCase("FrmSTOCKMONITORINGBALANCES")
                globalFRM = "FrmSTOCKMONITORINGBALANCES"
                Rpt_SqlStr = "SELECT *, * FROM TBL_Stocks_Balances " & _
                             "INNER JOIN TBL_Category_Item_File ON TBL_Stocks_Balances.Item_ID =TBL_Category_Item_File.Item_ID "
                Report.Show()
                'FrmREPORTS.Show()

            Case UCase("FrmPRODUCTS_REORDER")
                globalFRM = "FrmPRODUCTS_REORDER"
                Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File " & _
                             "WHERE Item_ID IN (SELECT Item_ID FROM TBL_Stocks_Balances WHERE Item_QTY <= Item_Reorder_Point)"
                Report.Show()
                'FrmREPORTS.Show()

            Case UCase("FrmDEFFECTIVE_RETURN_STOCKS")
                With FrmDEFFECTIVE_RETURN_STOCKS
                    If .rbDeffect.Checked Then
                        globalFRM = "deffective_po_report"
                        FrmDEFFECTIVE_STOCKS_PRINT.ShowDialog()
                    ElseIf .rbReturn.Checked Then
                        'globalFRM = "deffective_po_return"
                        'FrmDEFFECTIVE_STOCKS_RETURN.ShowDialog()
                        FrmReturn_PRINT.ShowDialog()
                    End If
                End With
            Case UCase("frmcatlist")
                globalFRM = "FrmCatITEMList"
                With FrmCatList
                    If .rbcatitemlist.Checked Then
                        If .lstCategory.Items.Count = 0 Then Exit Sub
                        .lstCategory.Focus()
                        .lstCategory.Select()
                        Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File WHERE Catg_ID =" & .lstCategory.FocusedItem.Text & " ORDER BY Item_Name"
                        Report.Show()
                        'FrmREPORTS.Show()
                    ElseIf .RBALL.Checked Then
                        Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File ORDER BY Item_Name"
                        Report.Show()
                        'FrmREPORTS.Show()
                    End If
                End With
            Case UCase("frmorder_form")
                With FrmORDER_FORM
                    If .lstOrder.Items.Count > 0 Then
                        .lstOrder.Focus()
                        globalFRM = "frmorder_form"
                        Rpt_SqlStr = "SELECT * FROM TBL_Orders WHERE Order_No =" & .lstOrder.FocusedItem.Text
                        Report.Show()
                    End If
                End With
                'Case UCase("frmorder_form_data")
            Case UCase("frmposreceipt_list")
                With FrmPOSRECEIPT_LIST
                    If .lstreceipt.Items.Count > 0 Then
                        .lstreceipt.Focus()
                        ' MsgBox(FrmPOSRECEIPT_LIST.lstreceipt.FocusedItem.SubItems(1).Text)
                        Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & .lstreceipt.FocusedItem.SubItems(2).Text
                        'MsgBox(Rpt_SqlStr)
                        globalFRM = "frmPOSPAYMENT"
                        'FrmREPORTS.Show()
                        Report.Show()
                    End If
                End With
            Case UCase("frmaudit_trail")
                With FrmAUDIT_TRAIL
                    'Rpt_SqlStr = "SELECT * FROM TBL_Audit_Log WHERE User_ID = " & Split(.cmbusers.Text, " - ")(0)
                    Rpt_SqlStr = "SELECT * " & _
                                 "FROM TBL_Audit_Log " & _
                                 "INNER JOIN TBL_Audit_Trail ON TBL_Audit_Log.User_ID = TBL_Audit_Trail.User_ID " & _
                                 "AND TBL_Audit_Trail.Log_ID = TBL_Audit_Log.Log_ID " & _
                                 "WHERE TBL_Audit_Trail.User_ID = " & Split(.cmbusers.Text, " - ")(0) & _
                                 " AND Date >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(.dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"
                    '       Rpt_SqlStr = "Select * " & _
                    '"from( " & _
                    '"select row_number() over(order by User_ID) as row_number, * " & _
                    '"from SaleInv_DB.dbo.TBL_Audit_Trail )  t " & _
                    '"where row_number between 6 and 10 "
                    'MsgBox(Rpt_SqlStr)
                    globalFRM = "FRMAUDIT_TRAIL"
                    Report.Show()
                End With
            Case UCase("frmphysicalcount")
                With FrmPhysicalCount
                    'Rpt_SqlStr = "SELECT * FROM TBL_Physical_Count " & _
                    '             "INNER JOIN TBL_Physical_Count_Details ON TBL_Physical_Count.P_ID = TBL_Physical_Count_Details.P_ID " & _
                    '             "INNER JOIN TBL_Category_Item_File ON TBL_Physical_Count_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                    '             "WHERE P_DATE >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & _
                    '             "' AND P_DATE <='" & Format(.dtto.Value, "MM/dd/yyyy") & "'"

                    'MsgBox(sqlDT.Rows.Count)
                    Rpt_SqlStr = "SELECT * FROM TBL_Physical_Count " & _
                                 "INNER JOIN TBL_Physical_Count_Details ON TBL_Physical_Count.P_ID = TBL_Physical_Count_Details.P_ID " & _
                                 "WHERE P_DATE >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & _
                                 "' AND P_DATE <='" & Format(.dtto.Value, "MM/dd/yyyy") & "'"
                    ExecuteSQLQuery(Rpt_SqlStr)
                    globalFRM = "frmphysicalcount"
                    Report.Show()
                End With

        End Select
    End Sub

    'REFRESH
    Public Sub RefreshList(ByVal frmStr As String)
        Dim and_SQL As String
        Select Case UCase(frmStr)
            Case UCase("FrmCatITEMList")
                With FrmCatITEMList
                    FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), .lstCategory, 0)
                    .lstCategory.Focus()
                    .lstCategory.Select()
                End With
            Case UCase("FrmCatList")
                With FrmCatList
                    If .RBCat.Checked Then
                        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), .lstCat, 0)
                        .lstCat.Focus()
                        .lstCat.Select()
                    ElseIf .rbcatitemlist.Checked Then
                        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), .lstCategory, 0)
                        .lstCategory.Focus()
                        .lstCategory.Select()
                    ElseIf .RBALL.Checked Then
                        'MsgBox("here")
                        'FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Org_Price as 'Price', Item_Price as 'Price (VAT 12%)', Unit_Measure as 'Measure' FROM TBL_Category_Item_File ORDER BY Item_Name"), .lstCat, 0)
                        'FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Item_Name as 'Item Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & .lstCategory.FocusedItem.Text), .lstItems, 1)
                        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', TBL_Category_Item_File.Catg_ID as 'Category ID', Group_Name AS 'Brand' ,replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Org_Price as 'Price', Item_Price as 'Price (VAT 12%)', Unit_Measure as 'Measure' " & _
                                                     "FROM TBL_Category_Item_File " & _
                                                     "INNER JOIN TBL_Category_File ON TBL_Category_Item_File.Catg_ID = TBL_Category_File.Catg_ID " & _
                                                     "INNER JOIN TBL_Group ON TBL_Category_File.Group_ID = TBL_Group.Group_ID " & _
                                                     "ORDER BY Item_Name"), .lstCat, 0)
                    ElseIf .RBGroup.Checked Then
                        FillListView(ExecuteSQLQuery("SELECT Group_ID AS 'ID', Group_Name AS 'Name', Group_Description AS 'Description' FROM TBL_Group"), .lstCat, 0)
                    End If
                End With
            Case UCase("FrmDEFFECTIVE_RETURN_STOCKS")
                With FrmDEFFECTIVE_RETURN_STOCKS
                    Dim xGo As Boolean
                    If .rbpending.Checked Then
                        sqlSTR = "SELECT Pending_ID as 'Pending ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number',Pending_Date as 'Date', Item_QTY as 'Quantity', Receipt_ID AS 'Receipt No' " & _
                                 "FROM TBL_Pending_Item " & _
                                 "INNER JOIN TBL_Category_Item_File ON TBL_Pending_Item.Item_ID = TBL_Category_Item_File.Item_ID " & _
                                 "WHERE Returnx = 'No' AND Pending_Date ='" & Format(.dtreturn.Value, "MM/dd/yyyy") & "'"
                        FillListView(ExecuteSQLQuery(sqlSTR), .lstdeffect, 0)


                        For x = 0 To .lstdeffect.Items.Count - 1
                            'MsgBox(lstdeffect.Items(x).Text)
                            sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details " & _
                                     "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO_Details.DEF_PO_ID = TBL_Deffective_PO_Return.DEF_PO_ID " & _
                                     "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                                     "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Return_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                                     "WHERE TBL_Deffective_PO_Details.Pending_ID =" & .lstdeffect.Items(x).Text
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                For i = 0 To sqlDT.Rows.Count - 1
                                    'MsgBox(sqlDT.Rows(i)("DEF_QTY") & "  " & sqlDT.Rows(i)("Return_QTY"))
                                    If CDbl(sqlDT.Rows(i)("Def_QTY")) = CDbl(sqlDT.Rows(i)("Return_QTY")) Then
                                        .lstdeffect.Items(x).ForeColor = Color.Brown
                                    Else
                                        xGo = True
                                        .lstdeffect.Items(x).ForeColor = Color.DarkBlue
                                    End If
                                Next
                            Else
                                If Not xGo Then
                                    sqlSTR = "SELECT * FROM TBL_Deffective_PO WHERE Pending_ID =" & .lstdeffect.Items(x).Text
                                    ExecuteSQLQuery(sqlSTR)
                                    If sqlDT.Rows.Count > 0 Then
                                        .lstdeffect.Items(x).ForeColor = Color.YellowGreen
                                    Else
                                        .lstdeffect.Items(x).ForeColor = Color.Black
                                    End If
                                End If
                            End If
                        Next
                    ElseIf .rbDeffect.Checked Then
                        sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', SupplierName as 'Supplier Name', Delivery_Term as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Pending_ID AS 'Pending ID' FROM TBL_Deffective_PO " & _
                                 "WHERE Return_Date ='" & Format(.dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
                        FillListView(ExecuteSQLQuery(sqlSTR), .lstdeffect, 0)
                        For i = 0 To .lstdeffect.Items.Count - 1
                            sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & .lstdeffect.Items(i).Text & _
                                     " AND Fully_Return='Yes'" & _
                                     " ORDER BY Def_PO_ID ASC"
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                .lstdeffect.Items(i).ForeColor = Color.Brown
                            Else
                                .lstdeffect.Items(i).ForeColor = Color.Black
                            End If
                        Next
                    ElseIf .rbReturn.Checked Then
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

                    End If
                End With
            Case UCase("FrmPURCHASEORDER")
                With FrmPURCHASEORDER
                    If .rbpurchase.Checked Then
                        sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                                 " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                                 " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(.dtpurchased.Value, "MM/dd/yyyy") & "'" & _
                                 " ORDER BY Purchase_ID"
                        FillListView(ExecuteSQLQuery(sqlSTR), .listorder, 0)
                        For i = 0 To .listorder.Items.Count - 1
                            If .listorder.Items(i).SubItems(4).Text = "Yes" Then
                                .listorder.Items(i).ForeColor = Color.Brown
                            Else
                                .listorder.Items(i).ForeColor = Color.Black
                            End If
                        Next
                    ElseIf .rbreceive.Checked Then
                        sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name' " & _
                                 ", Replace(Replace(TBL_Purchase_Order.Address,'$.$',''''),'$..$',',') as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term' " & _
                                 "FROM TBL_Purchase_Order " & _
                                 "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                                 "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                                 "AND TBL_Purchase_Order.Received_Date ='" & Format(.dtpurchased.Value, "MM/dd/yyyy") & "'"
                        FillListView(ExecuteSQLQuery(sqlSTR), .listorder, 0)

                    End If
                End With
            Case UCase("FrmPRODUCTS_REORDER")
                With FrmPRODUCTS_REORDER
                    sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                             "FROM TBL_Category_Item_File INNER JOIN " & _
                             "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                             "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                    FillListView(ExecuteSQLQuery(sqlSTR), .lstreorder, 0)
                    For i = 0 To .lstreorder.Items.Count - 1
                        If Int(.lstreorder.Items(i).SubItems(5).Text) <= 0 Then
                            .lstreorder.Items(i).ForeColor = Color.Brown
                        End If
                    Next
                End With
            Case UCase("frmSTOCKMONITORINGBALANCES")
                With frmSTOCKMONITORINGBALANCES
                    sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', Replace(Replace(TBL_Category_Item_File.Item_Name,'$.$',''''),'$..$',',') as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Category_Item_File.Item_Barcode AS 'Barcode', TBL_Category_Item_File.Item_Reorder_Point AS 'Reorder Point', TBL_Category_Item_File.Item_Org_Price as 'Price W/O VAT',TBL_Category_Item_File.item_price as 'Price W/ VAT', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total'" & _
                             "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID ORDER BY TBL_Category_Item_File.Item_name"

                    ' sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_name as 'Name', TBL_Category_Item_File.Item_Description as 'Description', TBL_Category_Item_File.Item_Org_Price as 'Price W/O VAT',TBL_Category_Item_File.item_price as 'Price W/ VAT', TBL_Stocks_Balances.Item_QTY as 'Quantity' , (tbl_stocks_balances.item_qty * tbl_category_item_file.item_price) as 'Total', DIRECT_INPUT AS 'DIRECT' " & _
                    '          "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID ORDER BY TBL_Category_Item_File.Item_Name"
                    FillListView(ExecuteSQLQuery(sqlSTR), .listStocks, 0)
                    For i = 0 To .listStocks.Items.Count - 1
                        If Int(.listStocks.Items(i).SubItems(7).Text) <= 0 Then
                            .listStocks.Items(i).ForeColor = Color.Brown
                        End If
                    Next
                End With
            Case UCase("FrmSuppliersList")
                With FrmSuppliersList
                    'ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppName,'$.$','''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$','''),'$..$',',') as 'Address', suppcontact as 'Contact No', replace(replace(ContactPerson,'$.$','''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"
                    If .rbsuplist.Checked Then
                        FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers ORDER BY suppName"), .lstsupplier, 0)
                    ElseIf .rbsuppro.Checked Then
                        FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers"), .lstSuppliers, 0)
                    End If

                End With
            Case UCase("FrmSUPPLIERSPRODUCT")

                With FrmSUPPLIERSPRODUCT
                    FillListView(ExecuteSQLQuery("select Supp_ID as 'Supplier ID', replace(replace(suppname,'$.$',''''),'$..$',',') as 'Supplier Name', replace(replace(suppadd,'$.$',''''),'$..$',',') as 'Address', replace(replace(suppcontact,'$.$',''''),'$..$',',') as 'Contact No', replace(replace(contactperson,'$.$',''''),'$..$',',') as 'Contact Person' FROM tbl_suppliers"), .lstSuppliers, 0)
                End With
            Case UCase("frmOrder_form")
                With FrmORDER_FORM
                    sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_Date ='" & Format(.dtOrder.Value, "MM/dd/yyyy") & "'"
                    FillListView(ExecuteSQLQuery(sqlSTR), .lstOrder, 0)
                End With
            Case UCase("frmposreceipt_list")
                With FrmPOSRECEIPT_LIST
                    If .chckcollector.Checked Then
                        and_SQL = " AND User_ID =" & Split(.cmbcollector.Text, " - ")(0)
                    Else
                        and_SQL = ""
                    End If
                    sqlSTR = "SELECT Order_No AS 'Order No', Receipt_ID as 'Receipt No', Sales_ID as 'ID', VATable as 'Vatable', Total_Sale as 'Total Sale', Amount_Due as 'Amount Due', Void " & _
                             "FROM TBL_Sales_Receipt WHERE Receipt_Date >= '" & Format(.DtFrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <= '" & Format(.DtTo.Value, "MM/dd/yyyy") & "'"
                    'MsgBox(sqlSTR)
                    sqlSTR = sqlSTR & and_SQL
                    FillListView(ExecuteSQLQuery(sqlSTR), .lstreceipt, 0)
                    For i = 0 To .lstreceipt.Items.Count - 1
                        If .lstreceipt.Items(i).SubItems(6).Text = "Yes" Then
                            .lstreceipt.Items(i).ForeColor = Color.Brown
                        End If
                    Next
                End With
            Case UCase("frmaudit_trail")
                With FrmAUDIT_TRAIL
                    If Split(.cmbusers.Text, " - ")(0) = "" Then
                        Exit Select
                    End If
                    sqlSTR = "SELECT Action, Date, Timex , LOGIN, LOGOUT " & _
                             "FROM (TBL_Audit_Trail " & _
                             "INNER JOIN TBL_Audit_Log ON TBL_Audit_Trail.User_ID = TBL_Audit_Log.User_ID " & _
                             " AND TBL_Audit_Trail.Log_ID = TBL_Audit_Log.Log_ID) " & _
                             "WHERE TBL_Audit_Trail.User_ID =" & Split(.cmbusers.Text, " - ")(0) & _
                             " AND Date >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(.dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"
                    ExecuteSQLQuery(sqlSTR)
                    .lstaudit.Items.Clear()
                    If sqlDT.Rows.Count > 0 Then
                        For i = 0 To sqlDT.Rows.Count - 1
                            .lstaudit.Items.Add(sqlDT.Rows(i)("Action"), 0)
                            .lstaudit.Items(.lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Date"))
                            .lstaudit.Items(.lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Timex"))
                            .lstaudit.Items(.lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGIN"))
                            .lstaudit.Items(.lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGOUT"))
                        Next
                    End If
                End With
            Case UCase("frmphysicalcount")

                With FrmPhysicalCount
                    sqlSTR = "SELECT P_ID AS 'P_ID', P_Date as 'DATE', Lastname + ', ' + Firstname + ' ' + Middlename AS ' Username' " & _
                             "FROM TBL_Physical_Count " & _
                             "INNER JOIN TBL_Users ON TBL_Physical_Count.User_ID = TBL_Users.User_ID " & _
                             " WHERE P_Date >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & "' AND P_Date <='" & Format(.dtto.Value, "MM/dd/yyyy") & "'"
                    FillListView(ExecuteSQLQuery(sqlSTR), .lstphysical, 0)
                End With
            Case UCase("FrmBG")
                Call refreshAdvisory()
                'fuccuci - add po receipt
            Case UCase("FrmPURCHASEORDER_RECEIPT")
                With FrmPURCHASEORDER_RECEIPT

                End With

        End Select
    End Sub

    Private Sub refreshAdvisory()
        With MDIMain
            ' .toolStripClose.Enabled = False
            ' Call xclose()
            'Year sales
            sqlSTR = "SELECT SUM(TBL_Sales_Receipt.AMOUNT_DUE) AS 'yearly_sales'  FROM TBL_Sales_Receipt " & _
                     "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                     "WHERE TBL_Sales_Receipt.Sales_ID  NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     " AND YEAR(Receipt_Date) =" & Year(Today) & _
                     " GROUP BY YEAR(TBL_Sales_Receipt.Receipt_Date)"
            ' " ORDER BY TBL_Sales_Sold.Sales_ID"
            ExecuteSQLQuery(sqlSTR)
            'MsgBox(sqlDT.Rows.Count)
            If sqlDT.Rows.Count > 0 Then
                .lblyrsales.Text = "Total Sales In This Year =Php " & Format(sqlDT.Rows(0)("yearly_sales"), "###,###,###.00")
            Else
                .lblyrsales.Text = "Total Sales In This Year =Php 0.00"
            End If

            'MONTHLY SALES
            sqlSTR = "SELECT SUM(AMOUNT_DUE) AS 'monthly_sales'  FROM TBL_Sales_Receipt " & _
                     "WHERE Sales_ID NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     " AND MONTH(Receipt_Date) =" & Month(Today) & _
                     " GROUP BY MONTH(TBL_Sales_Receipt.Receipt_Date) "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblmonthsales.Text = "Total Sales In This Month =Php " & Format(sqlDT.Rows(0)("monthly_sales"), "###,###,###.00")
            Else
                .lblmonthsales.Text = "Total Sales In This Month =Php 0.00"
            End If

            'TOTAL PRODUCTS
            sqlSTR = "SELECT Count(Item_ID) AS 'xCount' FROM TBL_Category_Item_File "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lbltotalprod.Text = "Total Products =" & Format(sqlDT.Rows(0)("xCount"), "###,###,###.00")
            Else
                .lbltotalprod.Text = "Total Products =0.00"
            End If

            'current inventory
            sqlSTR = "SELECT SUM(Item_QTY) AS 'sumQTY', Count(Item_ID) AS 'xCount' FROM TBL_Stocks_Balances"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 And Int(sqlDT.Rows(0)("xCount")) <> 0 Then
                .lblinventory.Text = "Current Iventory =" & sqlDT.Rows(0)("sumQTY")
                .lblstock_tot_product.Text = "Current Iventory =" & sqlDT.Rows(0)("sumQTY")
                .lblsalesagent_totalInventory.Text = "Total Inventory =" & sqlDT.Rows(0)("sumQTY")
            Else
                .lblinventory.Text = "Current Iventory =0"
                .lblstock_tot_product.Text = "Current Iventory =0"
                .lblsalesagent_totalInventory.Text = "Total Inventory =0"
            End If

            'UN-DELIVERD
            'sqlSTR = "SELECT COUNT(Order_No) AS 'total_Order' FROM TBL_Orders " & _
            '         "WHERE Order_No NOT IN(SELECT Order_No FROM TBL_Truck_Load_Dtl)"
            'ExecuteSQLQuery(sqlSTR)
            ' MsgBox(sqlDT.Rows(0)("total_order"))
            'If sqlDT.Rows.Count > 0 Then
            ' .lblundelivered.Text = "Un-delivered Order =" & sqlDT.Rows(0)("total_Order")
            ' Else
            ' .lblundelivered.Text = "Un-delivered Order =0.00"
            ' End If

            'REMAINING ORDER
            sqlSTR = "SELECT COUNT(Order_No) AS 'Total_order' FROM TBL_Orders " & _
                     "WHERE Order_No NOT IN (SELECT Order_No FROM TBL_Sales_Receipt) "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblremainorder.Text = "Remaining Order No =" & sqlDT.Rows(0)("Total_Order")
            Else
                .lblremainorder.Text = "Remaining Order No =0.00"
            End If

            'CHECK REORDER LEVEL
            sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                     "FROM TBL_Category_Item_File INNER JOIN " & _
                     "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                     "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblreorder.Text = "Products on Critical level =" & sqlDT.Rows.Count
                .lblstock_critical.Text = "Product(s) on Critical =" & sqlDT.Rows.Count
                .lblcashier_critical.Text = "Critical Product =" & sqlDT.Rows.Count
                .lblsalesagent_Criticalproduct.Text = "Critical Product =" & sqlDT.Rows.Count
            Else
                .lblreorder.Text = "Products on Critical level =0"
                .lblstock_critical.Text = "Product(s) on Critical =0"
                .lblcashier_critical.Text = "Critical Product =0"
                .lblsalesagent_Criticalproduct.Text = "Critical Product =0"
            End If

            'CHECK PURCHASE DETAIL FOR THE YEAR
            'MsgBox("here")
            sqlSTR = "SELECT distinct SUM(Purchase_Total) AS 'totalx' " & _
                     "FROM TBL_Purchase_Order " & _
                     "WHERE Year(Received_Date) =" & Year(Today) & _
                     " AND Approved ='Yes' " & _
                     "GROUP BY YEAR(TBL_Purchase_Order.Received_Date) "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblPurchaseYr.Text = "Amount Purchase This Year =Php " & Format(sqlDT.Rows(0)("totalx"), "###,###,###.00")
                .lblsalesagent_purchaseyear.Text = "Amount Purchase For The Year =Php " & Format(sqlDT.Rows(0)("totalx"), "###,###,###.00")
            Else
                .lblPurchaseYr.Text = "Amount Purchase This Year =Php 0.00"
                .lblsalesagent_purchaseyear.Text = "Amount Purchase For The Year =Php 0.00"
            End If

            'CHECK PURCHASE DETAIL FOR THE MONTH
            sqlSTR = "SELECT SUM(Purchase_Total) AS 'totalx' " & _
                     "FROM TBL_Purchase_Order " & _
                     "WHERE Month(Received_Date) =" & Month(Today) & _
                     " AND Approved ='Yes' " & _
                     "GROUP BY MONTH(TBL_Purchase_Order.Received_Date) "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblpurchasemonth.Text = "Amount Purchase This Month =Php " & Format(sqlDT.Rows(0)("totalx"), "###,###,###.00")
                .lblsalesagent_purchaseMonth.Text = "Amount Purchase For The Month =Php " & Format(sqlDT.Rows(0)("totalx"), "###,###,###.00")
            Else
                .lblpurchasemonth.Text = "Amount Purchase This Month =Php 0.00"
                .lblsalesagent_purchaseMonth.Text = "Amount Purchase For The Month =Php 0.00"
            End If

            'receive order year
            sqlSTR = "SELECT  SUM(Item_QTY) AS 'totalx_Item' " & _
                     "FROM TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Detail.Purchase_ID = TBL_Purchase_Order.Purchase_ID " & _
                     "WHERE Year(Received_Date) =" & Year(Today) & _
                     " AND Approved ='Yes' " & _
                     "GROUP BY YEAR(TBL_Purchase_Order.Received_Date) "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblstock_received_year.Text = "Received order for the year =" & Format(sqlDT.Rows(0)("totalx_Item"), "###,###,###")
            Else
                .lblstock_received_year.Text = "Received order for the year =0"
            End If

            'receive order month
            sqlSTR = "SELECT SUM(Item_QTY) AS 'totalx_Item' " & _
                     "FROM TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Detail.Purchase_ID = TBL_Purchase_Order.Purchase_ID " & _
                     "WHERE MONTH(Received_Date) =" & Month(Today) & _
                     " AND Approved ='Yes' " & _
                     "GROUP BY MONTH(TBL_Purchase_Order.Received_Date) "
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                .lblstock_received_month.Text = "Received order for the month =" & Format(sqlDT.Rows(0)("totalx_Item"), "###,###,###")
                .lblsalesagent_totalorder.Text = "Total order for the month =" & Format(sqlDT.Rows(0)("totalx_Item"), "###,###,###")
            Else
                .lblstock_received_month.Text = "Received order for the month =0"
                .lblsalesagent_totalorder.Text = "Total order for the month =0"
            End If

            'undeliver
            sqlSTR = "SELECT  SUM(Item_QTY) AS 'totalx_Item' , Count(TBL_Purchase_Order.Purchase_ID) AS 'xCount' " & _
                     "FROM TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Detail.Purchase_ID = TBL_Purchase_Order.Purchase_ID " & _
                     "WHERE Approved ='No' "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 And sqlDT.Rows(0)("xCount") <> 0 Then
                .lblstock_Undeliver.Text = "Undeliver order =" & Format(sqlDT.Rows(0)("totalx_Item"), "###,###,###")
            Else
                .lblstock_Undeliver.Text = "Undeliver order =0"
            End If

            'cashier sales
            sqlSTR = "SELECT SUM(TBL_Sales_Receipt.AMOUNT_DUE) AS 'daily'  FROM TBL_Sales_Receipt " & _
                     "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                     "WHERE TBL_Sales_Receipt.Sales_ID  NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     " AND Receipt_Date ='" & Format(Today, "MM/dd/yyyy") & "'" & _
                     " AND TBL_Sales_Receipt.User_ID =" & xUser_ID & _
                     " GROUP BY YEAR(TBL_Sales_Receipt.Receipt_Date)"
            ' " ORDER BY TBL_Sales_Sold.Sales_ID"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblcashier_DaySales.Text = "Cashier Sales =Php " & Format(sqlDT.Rows(0)("daily"), "###,###.00")
            Else
                .lblcashier_DaySales.Text = "Cashier Sales =Php 0.00"
            End If

            'Cashier Void
            sqlSTR = "SELECT *, *, *  FROM TBL_Sales_Receipt " & _
                     "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                     "INNER JOIN TBL_Sales_Void ON TBL_Sales_Sold.Sales_ID = TBL_Sales_Void.Sales_ID " & _
                     " AND Receipt_Date ='" & Format(Today, "MM/dd/yyyy") & "'" & _
                     " AND TBL_Sales_Receipt.User_ID =" & xUser_ID
            ' " GROUP BY YEAR(TBL_Sales_Receipt.Receipt_Date)"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblcashier_Void.Text = "Cashier Void =" & sqlDT.Rows.Count
            Else
                .lblcashier_Void.Text = "Cashier Void =0"
            End If

            'cashier Receipt
            sqlSTR = "SELECT *, *  FROM TBL_Sales_Receipt " & _
                     "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                     "WHERE TBL_Sales_Receipt.Sales_ID  NOT IN (SELECT Sales_ID FROM TBL_Sales_Void) " & _
                     " AND Receipt_Date ='" & Format(Today, "MM/dd/yyyy") & "'" & _
                     " AND TBL_Sales_Receipt.User_ID =" & xUser_ID
            '" GROUP BY YEAR(TBL_Sales_Receipt.Receipt_Date)"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                .lblcashier_totalReceipt.Text = "Total Receipt =" & sqlDT.Rows.Count
            Else
                .lblcashier_totalReceipt.Text = "Total Receipt =0"
            End If

            'With MDIMain
            If UCase(xUser_Access) = UCase("administrator") Or UCase(xUser_Access) = UCase("Sales Agent") Or UCase(xUser_Access) = UCase("Stock Room") Then
                sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                         "FROM TBL_Category_Item_File INNER JOIN " & _
                         "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                         "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
                ExecuteSQLQuery(sqlSTR)

                ' If sqlDT.Rows.Count > 0 Then
                ' MsgBox("A Product(s) reach its critical level !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                ' .tmrcritical.Enabled = True
                'Else
                '    .tmrcritical.Enabled = False
                'End If

                If sqlDT.Rows.Count > 0 Then
                    .tmrcritical.Enabled = True
                Else
                    .tmrcritical.Enabled = False
                    .cmdProductReorder.Enabled = True
                    .cmdProductReorder.ForeColor = Color.Black
                End If

            Else
                .tmrcritical.Enabled = False
                .cmdProductReorder.ForeColor = Color.Black
            End If
            'End With
        End With
    End Sub

End Module
