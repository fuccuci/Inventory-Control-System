Public Class FrmCATITEMADD_2

    Private Sub FrmCATITEMADD_2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Item"
    End Sub

    Private Sub FrmCATITEMADD_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        'MsgBox(Split(Me.Text, " - ")(0) & "   " & Split(Me.Text, " - ")(1))

        If Split(Me.Text, " - ")(1) = "Add" Then
            txtbarcode.Text = ""
            txtdesc.Text = ""
            txtname.Text = ""
            txtprice.Text = ""
            txtreorder.Text = ""
        End If
        FILLComboBox("SELECT Group_ID, Group_Description FROM TBL_Group", cmbrand)
        sqlSTR = "SELECT * FROM TBL_Group "
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            cmbrand.Text = sqlDT.Rows(0)("Group_ID") & " - " & sqlDT.Rows(0)("Group_Name")
        End If
        'FILLComboBox("SELECT Catg_ID, Catg_Name FROM TBL_Category_File", cmbCategory)
        For i = 0 To cmbCategory.Items.Count - 1
            If cmbCategory.Items.Count > 0 Then
                If i = 0 Then
                    cmbCategory.Text = cmbCategory.Items(i)
                End If
            End If
        Next
        FILLComboBox2("SELECT ID, Description FROM TBL_Unit_Measure", cmbUnit)
        For i = 0 To cmbUnit.Items.Count - 1
            If cmbUnit.Items.Count > 0 Then
                If i = 0 Then
                    cmbUnit.Text = cmbUnit.Items(i)
                End If
            End If

        Next
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim errMsg As String
        Dim msg As String

        errMsg = "Please Complete The Following " & Chr(10) & " --------------------------- "
        msg = errMsg
        ' If cmbrand.Text = "" Then
        ' MsgBox("Select Brand First", MsgBoxStyle.Exclamation, "Sales And Inventory")
        ' Exit Sub
        ' End If
        If cmbCategory.Text = "" Then
            MsgBox("Select Category First ", MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If


        If txtname.Text = "" Then
            msg = msg & Chr(10) & "Item Name : < Should not be blank >"
        End If
        If txtdesc.Text = "" Then
            msg = msg & Chr(10) & "Item Description : < Should not be blank >"
        End If
        If Not IsNumeric(txtbarcode.Text) Then
            msg = msg & Chr(10) & "Item Barcode : < Should be numeric >"
        End If
        If Not IsNumeric(txtprice.Text) Then
            msg = msg & Chr(10) & "Item Price :  < Should be numeric >"
        End If

        If Not IsNumeric(txtreorder.Text) Then
            msg = msg & Chr(10) & "Item Reorder : < Should be numeric >"
        End If
        If Len(txtbarcode.Text) < 4 Then
            msg = msg & Chr(10) & " Barcode :            < Barcode minimum length should be 4 >"
        End If
        If msg <> errMsg Then
            MsgBox(msg, MsgBoxStyle.Information, "Sales and Inventory")
            Exit Sub
        End If
        If Len(txtbarcode.Text) > 13 Then
            MsgBox("Barcode length should not be lower than 13 !! ", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
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
            MsgBox("Barcode already exists !!", MsgBoxStyle.Critical, "Sales and Inventory")
            Exit Sub
        End If



        sqlSTR = "INSERT INTO tbl_Category_Item_File (Catg_ID, Item_Name, Item_Description, Item_Barcode, Item_Reorder_Point, Item_Org_Price, Unit_Measure, Item_Price) VALUES(" & Split(cmbCategory.Text, " - ")(0) & ", " _
                                        & "'" & R_eplace(txtname.Text) & "', " _
                                        & "'" & Replace(txtdesc.Text, "'", "") & "', " _
                                        & txtbarcode.Text & ", " _
                                        & txtreorder.Text & ", " _
                                        & CDbl(txtprice.Text) & ", " _
                                        & "'" & cmbUnit.Text & "', " _
                                        & CDbl(txtprice.Text) + (CDbl(txtprice.Text) * (VAT / 100)) & ")"
        ExecuteSQLQuery(sqlSTR)
        'MsgBox(sqlSTR)
        Audit_Trail(xUser_ID, TimeOfDay, "Add New Item File List")
        MsgBox("Record Successfuly Update !", MsgBoxStyle.Information, "Sales and Inventory")
        If MsgBox("Do you want to add other data ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            txtbarcode.Text = ""
            txtdesc.Text = ""
            txtname.Text = ""
            txtprice.Text = ""
            txtreorder.Text = ""
        Else
            FillListView(ExecuteSQLQuery("SELECT Item_ID as 'ID', Catg_ID as 'Category ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Item_Description as 'Description / Item Number', Item_Barcode as 'Barcode', Item_Reorder_Point as 'Reorder Point', Item_Price as 'Price', Unit_Measure as 'Measure' FROM TBL_Category_Item_File ORDER BY Item_Name"), FrmCatList.lstCat, 1)
            Me.Close()
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

    Private Sub cmbrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrand.SelectedIndexChanged
        FILLComboBox("SELECT Catg_ID, Catg_Name " & _
             "FROM TBL_Category_File" & _
             " WHERE Group_ID =" & Split(cmbrand.Text, " - ")(0), cmbCategory)
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        'txtItemName.Text = filter_Special_Char(str_Filter(txtItemName, 39, 122, 32, 40))
        txtname.Text = filter_Special_Char(str_Filter(txtname, 34, 122, 32, 50))
    End Sub

    Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
        txtdesc.Text = filter_Special_Char(str_Filter(txtdesc, 48, 122, 32, 50))
    End Sub
End Class