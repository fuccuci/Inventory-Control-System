Public Class FrmCatITEMADD
    Dim stockID
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim msg As String, msgERR As String
        Dim tmp_barcode As Integer
        Dim duplicate_barcode As Boolean
        Dim duplicate_item_number As Boolean

        msg = "Please Complete The Following " & Chr(10) & " --------------------------- "
        msgERR = msg
        If txtname.Text = "" Then
            msg = msg & Chr(10) & " Item Name :           < Should not be blank >"
        End If
        If txtdesc.Text = "" Then
            msg = msg & Chr(10) & " Item Description :   < Should not be blank > "
        End If
        If cmbUnit.Text = "" Then
            msg = msg & Chr(10) & " Item Measure :      < Should not be blank > "
        End If
        If Not IsNumeric(txtbarcode.Text) Then
            msg = msg & Chr(10) & " Barcode:             < Should be numeric >"
        End If

        If Not IsNumeric(txtreorder.Text) Then
            msg = msg & Chr(10) & " Reorder Point:       < Should be numeric >"
        End If

        If Not IsNumeric(txtprice.Text) Then
            msg = msg & Chr(10) & " Price :              < Should be numeric >"
        End If

        If Len(txtbarcode.Text) < 4 Then
            msg = msg & Chr(10) & " Barcode :            < Barcode minimum length should be 4 >"
        End If
        If msg <> msgERR Then
            MsgBox(msg, MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If Len(txtbarcode.Text) > 13 Then
            MsgBox("Barcode length should not be lower than 13 !! ", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & txtID.Text
            ExecuteSQLQuery(sqlSTR)
            tmp_barcode = sqlDT.Rows(0)("Item_Barcode")
            If R_Change(sqlDT.Rows(0)("Item_Description")) = txtdesc.Text Then
                duplicate_item_number = False
            Else
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Description ='" & txtdesc.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MsgBox("Item Number Already Exist !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    duplicate_item_number = True
                    Exit Sub
                Else
                    duplicate_item_number = False
                End If
            End If

            If tmp_barcode = txtbarcode.Text Then
                duplicate_barcode = False
            Else
                'Find if barcode already exist
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Barcode =" & txtbarcode.Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MsgBox("Barcode Already Exist !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    duplicate_barcode = True
                    Exit Sub
                Else
                    duplicate_barcode = False
                End If
            End If
            If Not duplicate_barcode And Not duplicate_item_number Then
                sqlSTR = "UPDATE tbl_Category_Item_File SET Item_Name ='" & R_eplace(txtname.Text) & "', " _
                                                                    & "Item_Description ='" & Replace(txtdesc.Text, "'", "") & "', " _
                                                                    & "Item_Barcode =" & txtbarcode.Text & ", " _
                                                                    & "Item_Reorder_Point =" & txtreorder.Text & ", " _
                                                                    & "Item_Org_Price =" & CDbl(txtprice.Text) & ", " _
                                                                    & "Unit_Measure='" & cmbUnit.Text & "', " _
                                                                    & "Item_Price =" & CDbl(txtprice.Text) + (CDbl(txtprice.Text) * (VAT / 100)) _
                                                                    & " WHERE Item_ID =" & Int(Split(stockID, "x")(1))
                ExecuteSQLQuery(sqlSTR)
                Audit_Trail(xUser_ID, TimeOfDay, "Edit Item File List")
            End If

        Else
            'ADD
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Description ='" & txtdesc.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("Item Number Already Exist !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If

            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Barcode =" & txtbarcode.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("Barcode Already Exists !!!", MsgBoxStyle.Critical, "Sales and Inventory")
                Exit Sub
            End If

            sqlSTR = "INSERT INTO tbl_Category_Item_File (Catg_ID, Item_Name, Item_Description, Item_Barcode, Item_Reorder_Point, Item_Org_Price, Unit_Measure, Item_Price) VALUES(" & stockID & ", " _
                                        & "'" & R_eplace(txtname.Text) & "', " _
                                        & "'" & Replace(txtdesc.Text, "'", "") & "', " _
                                        & txtbarcode.Text & ", " _
                                        & txtreorder.Text & ", " _
                                        & CDbl(txtprice.Text) & ", " _
                                        & "'" & cmbUnit.Text & "', " _
                                        & CDbl(txtprice.Text) + (CDbl(txtprice.Text) * (VAT / 100)) & ")"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Item File List")
        End If

        MsgBox("Record Successfuly Update !", MsgBoxStyle.Information, "Sales and Inventory")
        If UCase(globalFRM) = UCase("frmcatitemlist") Then
            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Item Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & FrmCatITEMList.lstCategory.FocusedItem.Text & " ORDER BY Item_Name"), FrmCatITEMList.lstItems, 1)
        ElseIf UCase(globalFRM) = UCase("frmcatitemlist2") Then
            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Item Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM tbl_Category_Item_File WHERE Catg_ID =" & FrmCatList.lstCategory.FocusedItem.Text & " ORDER BY Item_Name"), FrmCatList.lstItems, 1)
        Else
            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Price as 'Price', Unit_Measure as 'Measure' FROM TBL_Category_Item_File ORDER BY Item_Name"), FrmCatList.lstCat, 1)
            ' FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', Item_Name as 'Name', Item_Description as 'Description', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Unit_Measure as 'Measure', Item_Price as 'Price' FROM TBL_Category_Item_File"), FrmCatList.lstCat, 1)
        End If
        Me.Close()
    End Sub

    Private Sub FrmCatITEMADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "ITEM"
    End Sub

    Private Sub FrmCatITEMADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim i As Integer
        stockID = globalID
        FILLComboBox2("SELECT ID, Description FROM TBL_Unit_Measure", cmbUnit)
        If Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM tbl_Category_Item_File WHERE Item_ID =" & Split(stockID, "x")(1)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtID.Text = sqlDT.Rows(0)("Item_ID")
                txtname.Text = R_Change(sqlDT.Rows(0)("Item_Name"))
                txtdesc.Text = R_Change(sqlDT.Rows(0)("Item_Description"))
                txtbarcode.Text = sqlDT.Rows(0)("Item_Barcode")
                txtreorder.Text = sqlDT.Rows(0)("Item_Reorder_Point")
                txtprice.Text = Format(sqlDT.Rows(0)("Item_Org_Price"), "###,###.00")
                cmbUnit.Text = sqlDT.Rows(0)("Unit_Measure")
                ' For i = 0 To cmbUnit.Items.Count - 1
                '     If cmbUnit.Items.Count > 0 Then
                '         If Split(cmbUnit.Items(i), " - ")(1) = sqlDT.Rows(0)("Unit_Measure") Then
                '             cmbUnit.Text = cmbUnit.Items(i)
                '         End If
                '     End If
                ' Next
            End If
        Else
            txtID.Text = ""
            txtname.Text = ""
            txtdesc.Text = ""
            txtbarcode.Text = ""
            txtreorder.Text = ""
            'cmbUnit.Text = sqlDT.Rows(0)("ID") & " - " & sqlDT.Rows(0)("Description")
        End If
    End Sub

    Private Sub txtreorder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreorder.TextChanged
        txtreorder.Text = str_Filter(txtreorder, 48, 57, 0, 0)
    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged
        txtbarcode.Text = str_Filter(txtbarcode, 48, 57, 0, 0)
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        txtprice.Text = str_Filter(txtprice, 48, 57, 46, 1)
        If txtprice.Text = "0" Or txtprice.Text = "" Then txtprice.Text = "1"
    End Sub

    Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
        txtdesc.Text = filter_Special_Char(str_Filter(txtdesc, 48, 122, 32, 50))
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        'txtItemName.Text = filter_Special_Char(str_Filter(txtItemName, 39, 122, 32, 40))
        txtname.Text = filter_Special_Char(str_Filter(txtname, 34, 122, 32, 50))
    End Sub
End Class