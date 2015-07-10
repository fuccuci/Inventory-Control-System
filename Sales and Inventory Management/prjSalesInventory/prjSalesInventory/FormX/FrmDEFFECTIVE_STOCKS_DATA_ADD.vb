Public Class FrmDEFFECTIVE_STOCKS_DATA_ADD

    Private Sub FrmDEFFECTIVE_STOCKS_DATA_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Defect Details"
    End Sub

    Private Sub FrmDEFFECTIVE_STOCKS_DATA_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Split(Me.Text, " - ")(1) <> "Edit" Then
            FrmDEFFECTIVE_STOCKS_LIST.ShowDialog()
            txtdefqty.Select()
            txtdefqty.Text = "0"
        Else
            sqlSTR = "SELECT *, *, *, * " & _
              "FROM ((((TBL_Suppliers " & _
              "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
              "INNER JOIN TBL_Deffective_PO_Details ON TBL_Purchase_Order.Purchase_ID = TBL_Deffective_PO_Details.Purchase_ID) " & _
              "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Details.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
              "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
              "WHERE TBL_Deffective_PO_Details.Purchase_ID =" & Split(globalID, "x")(1) & _
              " AND TBL_Deffective_PO_Details.Purchase_Detail_ID =" & Split(globalID, "x")(0)
            ExecuteSQLQuery(sqlSTR)
            '        txtid.Text = sqlDT.Rows(0)("TBL_Deffective_PO_Details.Item_ID")
            '        txtdtl.Text = sqlDT.Rows(0)("TBL_Deffective_PO_Details.Purchase_Detail_ID")
            '        txtname.Text = sqlDT.Rows(0)("Item_Name")
            '        txtdesc.Text = sqlDT.Rows(0)("Item_Description")
            '        txtprice.Text = sqlDT.Rows(0)("TBL_Purchase_Detail.Item_Price")
            If sqlDT.Rows.Count > 0 Then
                txtbarcode.Text = sqlDT.Rows(0)("Item_Barcode")
            End If

            '        txtunit.Text = sqlDT.Rows(0)("Unit")
            '       txtqty.Text = sqlDT.Rows(0)("Item_QTY")
            '       txtdefqty.Text = sqlDT.Rows(0)("Def_QTY")
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        With FrmDEFFECTIVE_STOCKS_ADD
            If txtdefqty.Text = "0" Then
                MsgBox("Def.Qty should not be zero !!", MsgBoxStyle.Information, "Sales and Inventory")
                txtdefqty.Select()
                Exit Sub
            End If

            If CDbl(txtdefqty.Text) > CDbl(txtqty.Text) Then
                MsgBox("Def.Qty should not be greater than to Current Quantity !! ", MsgBoxStyle.Information, "Sales and Inventory")
                txtdefqty.Select()
                Exit Sub
            End If

            If Split(Me.Text, " - ")(1) = "Add" Then
                For i = 0 To .lstitems.Items.Count - 1
                    If .lstitems.Items(i).Text = txtid.Text Then
                        MsgBox("Current details is already on the defective list !!", MsgBoxStyle.Information, "Sales and Inventory")
                        Exit Sub
                    End If
                Next

                .lstitems.Items.Add(txtid.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtdtl.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtname.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtdesc.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtprice.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtqty.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtdefqty.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtunit.Text)
                .cmdSave.Enabled = True
                .cmdEdit.Enabled = True
            Else
                For i = 0 To .lstitems.Items.Count - 1
                    If .lstitems.Items(i).Text = txtid.Text Then
                        .lstitems.Items(i).SubItems(6).Text = txtdefqty.Text
                    End If
                Next
                .cmdSave.Enabled = True
                .cmdEdit.Enabled = True
            End If
        End With
        Me.Close()
        ' With FrmDEFFECTIVE_STOCKS_DATA_ADD
        '     .txtid.Text = Me.lstitems.FocusedItem.Text
        '     .txtdtl.Text = Me.lstitems.FocusedItem.SubItems(1).Text
        '     .txtname.Text = Me.lstitems.FocusedItem.SubItems(2).Text
        '     .txtdesc.Text = Me.lstitems.FocusedItem.SubItems(3).Text
        '     .txtprice.Text = Me.lstitems.FocusedItem.SubItems(4).Text
        '     .txtbarcode.Text = Me.lstitems.FocusedItem.SubItems(5).Text
        '     .txtqty.Text = Me.lstitems.FocusedItem.SubItems(6).Text
        '     .txtunit.Text = Me.lstitems.FocusedItem.SubItems(7).Text
        ' End With
    End Sub

    Private Sub txtdefqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefqty.TextChanged
        txtdefqty.Text = str_Filter(txtdefqty, 48, 57, 0, 0)
        If txtdefqty.Text = "" Then txtdefqty.Text = "0"
    End Sub
End Class