Public Class FrmPURCHASEORDERDATA_EDIT

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtname.Text <> "" And txtdesc.Text <> "" And txtid.Text <> "" And txtqty.Text <> "" Then
            If Not IsNumeric(txtqty.Text) Then
                MsgBox("Quantity Should Be Numeric !!", MsgBoxStyle.Information)
                Exit Sub
            End If
            With FrmPURCHASEORDERADD.lstitems
                ' .FocusedItem.Remove()
                'MsgBox("A")
                .FocusedItem.SubItems(4).Text = txtqty.Text
                ' .Items.Add(txtid.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtdtl.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtname.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtdesc.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtprice.Text)
                '.Items((.Items.Count - 1)).SubItems.Add(txtbarcode.Text)
                '.Items((.Items.Count - 1)).SubItems.Add(txtqty.Text)
            End With
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtqty.Text = str_Filter(txtqty, 48, 57, 0, 0)
    End Sub
End Class