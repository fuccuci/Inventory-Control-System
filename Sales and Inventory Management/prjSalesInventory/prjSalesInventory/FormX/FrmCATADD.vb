Public Class FrmCatADD
    Dim stockID As Integer
    Dim edit As Boolean
    Dim xlstcat As Boolean
    Dim xlstitem As Boolean
    Private Sub FrmCatADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Category"
    End Sub

    Private Sub FrmCatADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xlstcat = False
        xlstitem = False
        lstitems.Items.Clear()
        '  If Split(Me.Text, " - ")(1) = "Edit" Then
        ' stockID = globalID
        ' sqlSTR = "SELECT * FROM tbl_Category_File WHERE catg_ID =" & stockID
        ' ExecuteSQLQuery(sqlSTR)
        ' If sqlDT.Rows.Count > 0 Then
        ' txtid.Text = sqlDT.Rows(0)("Catg_ID")
        ' txtname.Text = sqlDT.Rows(0)("Catg_Name")
        ' txtdesc.Text = sqlDT.Rows(0)("Catg_Description")
        ' End If
        ' Else
        ' txtid.Text = ""
        ' txtname.Text = ""
        ' txtdesc.Text = ""
        ' End If
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = False
        FILLComboBox2("SELECT ID, Description FROM TBL_Unit_Measure", cmbUnit)
        FILLComboBox("SELECT Group_ID, Group_Description FROM TBL_Group", cmbGroup)
        'FILLComboBox("SELECT Catg_ID, Catg_Name FROM TBL_Category_File", cmbCategory)
        lstcat.Enabled = True
        sqlSTR = "SELECT * FROM TBL_Group"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            cmbGroup.Text = sqlDT.Rows(0)("Group_ID") & " - " & R_Change(sqlDT.Rows(0)("Group_Description"))
            FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'ID', Catg_Name as 'Name', Catg_Description as 'Description' " & _
                                         "FROM TBL_Category_File " & _
                                         " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0)), lstcat, 0)
            cmdadd.Enabled = True
            cmdEdit.Enabled = True
        Else
            cmdadd.Enabled = False
            cmdEdit.Enabled = False
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        cmdadd.Enabled = True
        cmdEdit.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        'GroupBox3.Enabled = True
        grpCat.Visible = False
        edit = False
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        'MsgBox(edit)
        If txtname.Text = "" Then
            MsgBox("No Category Name Please Input", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If txtdesc.Text = "" Then
            MsgBox("No Category Description Please Input", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If edit = True Then
            sqlSTR = "UPDATE TBL_Category_File SET Catg_Name ='" & txtname.Text & "', " _
                                           & "Catg_Description ='" & R_eplace(txtdesc.Text) & "', " _
                                           & "Group_ID =" & Split(cmbGroup.Text, " - ")(0) & " WHERE catg_ID =" & txtid.Text
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Data On Category Listing ")
        Else
            sqlSTR = "INSERT INTO TBL_Category_File (Catg_Name, Catg_Description, Group_ID) VALUES ('" & txtname.Text & "', " _
                                                                            & "'" & R_eplace(txtdesc.Text) & "', " & _
                                                                            Split(cmbGroup.Text, " - ")(0) & ")"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Data On Category Listing ")
        End If
        'ExecuteSQLQuery(sqlSTR)
        MsgBox("Record Successfuly Update!", MsgBoxStyle.Information)
        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'Category ID', Catg_Name as 'Category Name', Catg_Description as 'Category Description' FROM tbl_Category_File"), FrmCatList.lstCat, 0)
        'FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'ID', Catg_Name as 'Name', Catg_Description as 'Description' FROM tbl_Category_File"), lstcat, 0)
        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'ID', Catg_Name as 'Name', Catg_Description as 'Description' " & _
                                     "FROM TBL_Category_File " & _
                                     " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0)), lstcat, 0)
        'FILLComboBox("SELECT Catg_ID, Catg_Name FROM TBL_Category_File", cmbCategory)
        FILLComboBox("SELECT Catg_ID, Catg_Name " & _
                             "FROM TBL_Category_File" & _
                             " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0), cmbCategory)
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = False
        grpCat.Visible = False
        ' cmdadd.Enabled = True
        ' cmdEdit.Enabled = True
        edit = False
        'Me.Close()
    End Sub

    Private Sub cmdadd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd2.Click
        If lstcat.Items.Count > 0 Then
            lstcat.Focus()
            edit = False
            GroupBox3.Enabled = True
            GroupBox2.Enabled = False
            GroupBox1.Enabled = False
            txtitemID.Text = ""
            txtItemName.Text = ""
            txtItemDesc.Text = ""
            txtItemBarcode.Text = ""
            txtItemprice.Text = ""
            txtItemreorder.Text = ""
            If cmbCategory.Text = "" Then
                FILLComboBox("SELECT Catg_ID, Catg_Name " & _
                             "FROM TBL_Category_File" & _
                             " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0), cmbCategory)
            End If
            lstcat.Enabled = False
        End If
    End Sub

    Private Sub cmdSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave2.Click
        Dim msg As String, msgERR As String
        Dim duplicate_barcode As Boolean
        Dim duplicate_item_number As Boolean
        Dim tmp_barcode As Integer
        msg = "Please Complete The Following " & Chr(10) & " --------------------------- "
        msgERR = msg
        If txtItemName.Text = "" Then
            msg = msg & Chr(10) & " Item Name :           < Should not be blank >"
        End If
        If txtItemDesc.Text = "" Then
            msg = msg & Chr(10) & " Item Description :   < Should not be blank > "
        End If
        If cmbUnit.Text = "" Then
            msg = msg & Chr(10) & " Item Measure :      < Should not be blank > "
        End If
        If Not IsNumeric(txtItemBarcode.Text) Then
            msg = msg & Chr(10) & " Barcode:             < Should be numeric >"
        End If

        If Not IsNumeric(txtItemreorder.Text) Then
            msg = msg & Chr(10) & " Reorder Point:       < Should be numeric >"
        End If

        If Not IsNumeric(txtItemprice.Text) Then
            msg = msg & Chr(10) & " Price :              < Should be numeric >"
        End If

        If Len(txtItemBarcode.Text) < 4 Then
            msg = msg & Chr(10) & " Barcode :            < Barcode minimum length should be 4 >"
        End If

        If msg <> msgERR Then
            MsgBox(msg, MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If Len(txtItemBarcode.Text) > 13 Then
            MsgBox("Barcode length should not be lower than 13 !! ", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If

        If edit = True Then
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & txtitemID.Text
            ExecuteSQLQuery(sqlSTR)
            tmp_barcode = sqlDT.Rows(0)("Item_Barcode")
            If R_Change(sqlDT.Rows(0)("Item_Description")) = txtItemDesc.Text Then
                duplicate_item_number = False
            Else
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Description ='" & txtItemDesc.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MsgBox("Item Number Already Exist !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    duplicate_item_number = True
                    Exit Sub
                Else
                    duplicate_item_number = False
                End If
            End If

            If tmp_barcode = txtItemBarcode.Text Then
                duplicate_barcode = False
            Else
                'Find if barcode already exist
                sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Barcode =" & txtItemBarcode.Text
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
                sqlSTR = "UPDATE TBL_Category_Item_File SET Item_Name ='" & R_eplace(txtItemName.Text) & "', " _
                                                & "Catg_ID =" & Split(cmbCategory.Text, " - ")(0) & ", " _
                                                & "Item_Description ='" & txtItemDesc.Text & "', " _
                                                & "Item_Barcode =" & txtItemBarcode.Text & ", " _
                                                & "Item_Reorder_Point =" & txtItemreorder.Text & ", " _
                                                & "Item_Org_Price =" & CDbl(txtItemprice.Text) & ", " _
                                                & "Unit_Measure='" & cmbUnit.Text & "', " _
                                                & "Item_Price =" & CDbl(txtItemprice.Text) + (CDbl(txtItemprice.Text) * (VAT / 100)) _
                                                & " WHERE Item_ID =" & txtitemID.Text
                ExecuteSQLQuery(sqlSTR)
                Audit_Trail(xUser_ID, TimeOfDay, "Edit Item File List")
            End If
        Else
            'ADD
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Description ='" & txtItemDesc.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("Item Number Already Exist !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If

            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_Barcode =" & txtItemBarcode.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                MsgBox("Barcode already exists !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            'MsgBox("here")
            sqlSTR = "INSERT INTO tbl_Category_Item_File (Catg_ID, Item_Name, Item_Description, Item_Barcode, Item_Reorder_Point, Item_Org_Price, Unit_Measure, Item_Price) VALUES(" & Split(cmbCategory.Text, " - ")(0) & ", " _
                            & "'" & R_eplace(txtItemName.Text) & "', " _
                            & "'" & txtItemDesc.Text & "', " _
                            & txtItemBarcode.Text & ", " _
                            & txtItemreorder.Text & ", " _
                            & CDbl(txtItemprice.Text) & ", " _
                            & "'" & cmbUnit.Text & "', " _
                            & CDbl(txtItemprice.Text) + (CDbl(txtItemprice.Text) * (VAT / 100)) & ")"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Item File List")
            End If

            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Item Name', Item_Description as 'Description / Item Number' FROM tbl_Category_Item_File WHERE Catg_ID =" & lstcat.FocusedItem.Text), lstitems, 1)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            edit = False
            lstcat.Enabled = True
    End Sub


    Private Sub cmdcancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel2.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = False
        edit = False
        lstcat.Enabled = True
    End Sub

    Private Sub lstitems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstitems.Click
        ' MsgBox("A")
        'xlstitem = True
        'xlstcat = False
        sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.FocusedItem.Text
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            txtitemID.Text = sqlDT.Rows(0)("Item_ID")
            txtItemName.Text = R_Change(sqlDT.Rows(0)("Item_Name"))
            txtItemDesc.Text = sqlDT.Rows(0)("Item_Description")
            txtItemBarcode.Text = sqlDT.Rows(0)("Item_Barcode")
            txtItemprice.Text = sqlDT.Rows(0)("Item_Org_Price")
            cmbUnit.SelectedItem = (sqlDT.Rows(0)("Unit_Measure"))
            'cmbsupplier.SelectedItem = sqlDT.Rows(0)("Supp_ID") & " - " & sqlDT.Rows(0)("Suppname")
            txtItemreorder.Text = sqlDT.Rows(0)("Item_Reorder_Point")
        End If
    End Sub

    Private Sub cmdedit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit2.Click
        If lstitems.Items.Count > 0 Then
            lstitems.Focus()
            lstitems.Select()
            lstcat.Enabled = False
            edit = True
            GroupBox1.Enabled = False
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub txtItemprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemprice.TextChanged
        txtItemprice.Text = str_Filter(txtItemprice, 48, 57, 46, 1)
        If txtItemprice.Text = "0" Or txtItemprice.Text = "" Then txtItemprice.Text = "1"
    End Sub

    Private Sub txtItemreorder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemreorder.TextChanged
        txtItemreorder.Text = str_Filter(txtItemreorder, 48, 57, 0, 0)
    End Sub

    Private Sub txtItemBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemBarcode.TextChanged
        txtItemBarcode.Text = str_Filter(txtItemBarcode, 48, 57, 0, 0)
    End Sub

    Private Sub lstcat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstcat.Click
        'xlstcat = True
        'xlstitem = False
        FillListView(ExecuteSQLQuery("SELECT Item_ID as 'Item ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Item Name', Item_Description as 'Description / Item Number' FROM tbl_Category_Item_File WHERE Catg_ID =" & lstcat.FocusedItem.Text), lstitems, 1)
        'MsgBox(lstcat.FocusedItem.Text & " - " & lstcat.FocusedItem.SubItems(1).Text)
        cmbCategory.Text = lstcat.FocusedItem.Text & " - " & lstcat.FocusedItem.SubItems(1).Text
        If lstitems.Items.Count > 0 Then
            'lstitems.Focus()
            sqlSTR = "SELECT * FROM TBL_Category_Item_File WHERE Item_ID =" & lstitems.Items(0).Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtitemID.Text = sqlDT.Rows(0)("Item_ID")
                txtItemName.Text = R_Change(sqlDT.Rows(0)("Item_Name"))
                txtItemDesc.Text = sqlDT.Rows(0)("Item_Description")
                txtItemBarcode.Text = sqlDT.Rows(0)("Item_Barcode")
                txtItemprice.Text = sqlDT.Rows(0)("Item_Org_Price")
                cmbUnit.SelectedItem = (sqlDT.Rows(0)("Unit_Measure"))
                'cmbsupplier.SelectedItem = sqlDT.Rows(0)("Supp_ID") & " - " & sqlDT.Rows(0)("Suppname")
                txtItemreorder.Text = sqlDT.Rows(0)("Item_Reorder_Point")
            End If


        Else
            txtid.Text = ""
            txtItemName.Text = ""
            txtItemDesc.Text = ""
            txtItemBarcode.Text = ""
            txtItemprice.Text = ""
            txtItemreorder.Text = ""
        End If
    End Sub

    Private Sub lstcat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstcat.GotFocus
        ' add2, edit2 visible = false
        ' xlstcat = True
        ' xlstitem = False
    End Sub

    Private Sub lstcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcat.SelectedIndexChanged

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        ' MsgBox(xlstcat & " " & xlstitem)
        ' If xlstcat Then
        If lstcat.Items.Count > 0 Then
            lstcat.Focus()
            txtid.Text = lstcat.FocusedItem.Text
            txtname.Text = lstcat.FocusedItem.SubItems(1).Text
            txtdesc.Text = lstcat.FocusedItem.SubItems(2).Text
            edit = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            grpCat.Visible = True
        End If
        ' ElseIf xlstitem Then
        '  If lstitems.Items.Count > 0 Then
        'lstitems.Focus()
        'lstitems.Select()
        'edit = True
        'GroupBox1.Enabled = False
        'GroupBox2.Enabled = False
        'GroupBox3.Enabled = True
        'End If
        'End If
        txtname.Focus()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click

        'add2, edit2 visible =false
        '  If xlstcat Then
        ' edit = False
        ' txtname.Text = ""
        ' txtdesc.Text = ""
        ' grpCat.Visible = True
        ' GroupBox1.Enabled = False
        ' GroupBox2.Enabled = False
        ' GroupBox3.Enabled = False
        ' ElseIf xlstitem Then
        ' edit = False
        ' lstcat.Focus()
        ' 'edit = False
        ' GroupBox3.Enabled = True
        ' GroupBox2.Enabled = False
        ' GroupBox1.Enabled = False
        ' txtitemID.Text = ""
        ' txtItemName.Text = ""
        ' txtItemDesc.Text = ""
        ' txtItemBarcode.Text = ""
        ' txtItemprice.Text = ""
        ' txtItemreorder.Text = ""
        ' End If
        '' Exit Sub
        ' edit = False
        ' txtname.Text = ""
        ' txtdesc.Text = ""
        ' grpCat.Visible = True
        ' GroupBox1.Enabled = False
        ' GroupBox2.Enabled = False
        ' GroupBox3.Enabled = False
        ' 'cmdadd.Enabled = False
        ' 'cmdEdit.Enabled = False

        txtname.Text = ""
        txtdesc.Text = ""
        grpCat.Visible = True
        edit = False
        txtname.Focus()
    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged
        FillListView(ExecuteSQLQuery("SELECT Catg_ID as 'ID', Catg_Name as 'Name', Catg_Description as 'Description' " & _
                                     "FROM TBL_Category_File " & _
                                     " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0)), lstcat, 0)
        FILLComboBox("SELECT Catg_ID, Catg_Name " & _
                     "FROM TBL_Category_File" & _
                     " WHERE Group_ID =" & Split(cmbGroup.Text, " - ")(0), cmbCategory)
        lstitems.Items.Clear()
        txtItemDesc.Text = ""
        txtItemBarcode.Text = ""
        txtItemName.Text = ""
        txtItemprice.Text = 1
        txtItemreorder.Text = ""
        txtname.Text = ""
        cmbCategory.Text = ""
    End Sub

    Private Sub lstitems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstitems.SelectedIndexChanged

    End Sub

    Private Sub txtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemName.TextChanged
        txtItemName.Text = filter_Special_Char(str_Filter(txtItemName, 34, 122, 32, 40))
    End Sub

    Private Sub txtItemDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemDesc.TextChanged
        txtItemDesc.Text = filter_Special_Char(str_Filter(txtItemDesc, 48, 122, 32, 50))
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        txtname.Text = filter_Special_Char(str_Filter(txtname, 65, 122, 32, 40))
    End Sub

    Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
        'txtdesc.Text = filter_Special_Char(str_Filter(txtdesc, 65, 122, 32, 40))
    End Sub
End Class