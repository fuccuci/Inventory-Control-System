Public Class FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD

    Private Sub FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Return Details"
    End Sub

    Private Sub FrmDEFFECTIVE_RETURN_STOCKS_DATA_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Split(Me.Text, " - ")(1) <> "Edit" Then
            txtbarcode.Text = ""
            txtdefqty.Text = ""
            txtdesc.Text = ""
            txtdtl.Text = ""
            txtid.Text = ""
            txtname.Text = ""
            txtprice.Text = ""
            FrmDEFFECTIVE_RETURN_STOCK_LIST.ShowDialog()
            txtreturnqty.Select()
            txtreturnqty.Text = "0"
        Else
            sqlSTR = "SELECT *, *, *, * " & _
                     "FROM ((((TBL_Suppliers " & _
                     "INNER JOIN TBL_Purchase_Order ON TBL_Suppliers.Supp_ID = TBL_Purchase_Order.Supp_ID) " & _
                     "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Purchase_Order.Purchase_ID = TBL_Deffective_PO_Return_Details.Purchase_ID) " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Deffective_PO_Return_Details.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Return_Details.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                     "WHERE TBL_Deffective_PO_Return_Details.Purchase_ID =" & Split(globalID, "x")(1) & _
                     " AND TBL_Deffective_PO_Return_Details.Purchase_Detail_ID =" & Split(globalID, "x")(0)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtbarcode.Text = sqlDT.Rows(0)("Item_Barcode")
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtreturnqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreturnqty.TextChanged
        txtreturnqty.Text = str_Filter(txtreturnqty, 48, 57, 0, 0)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        With FrmDEFFECTIVE_RETURN_ADD
            If txtid.Text = "" Or txtname.Text = "" Then
                MsgBox("No details has found !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            If CDbl(txtreturnqty.Text) = 0 Then
                MsgBox("Return quantity should not be equal to zero !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
            If CDbl(txtreturnqty.Text) > CDbl(txtdefqty.Text) Then
                MsgBox("Return quantity should not be greater than defective quantity !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
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
                'If Label11.Text <> "" Then
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtdefqty.Text)
                'End If

                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtreturnqty.Text)
                .lstitems.Items(.lstitems.Items.Count - 1).SubItems.Add(txtunit.Text)
            Else
                For i = 0 To .lstitems.Items.Count - 1
                    If .lstitems.Items(i).Text = txtid.Text Then
                        .lstitems.Items(i).SubItems(6).Text = txtreturnqty.Text
                        ' .lstitems.Items(i).SubItems(5).Text = (txtdefqty.Text - txtreturnqty.Text)
                    End If
                Next
            End If
            .cmdSave.Enabled = True
        End With
        Me.Close()
    End Sub
End Class