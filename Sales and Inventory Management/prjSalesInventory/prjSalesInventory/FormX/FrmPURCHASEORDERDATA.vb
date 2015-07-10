Public Class FrmPURCHASEORDERDATA

    Private Sub FrmPURCHASEORDERDATA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid.Text = ""
        txtname.Text = ""
        txtdesc.Text = ""
        txtprice.Text = ""
        txtqty.Text = ""
        txtqty.Select()
        FrmPURCHASEORDERLIST.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'MsgBox(FrmPURCHASEORDERADD.lstitems.Items.Count)
        Dim i As Integer
        If txtname.Text <> "" And txtdesc.Text <> "" And txtid.Text <> "" And txtprice.Text <> "" And txtqty.Text <> "" Then
            If Not IsNumeric(txtqty.Text) Then
                MsgBox("Quantity Should Be Numeric !!", MsgBoxStyle.Information)
                Exit Sub
            End If
            With FrmPURCHASEORDERADD.lstitems
                For i = 0 To .Items.Count - 1
                    If .Items(i).Text = txtid.Text Then
                        MsgBox("Stock details is already on the list !!", MsgBoxStyle.Information, "Sales and Inventory")
                        FrmPURCHASEORDERLIST.ShowDialog()
                        Exit Sub
                    End If
                Next
                .Items.Add(txtid.Text)
                .Items((.Items.Count - 1)).SubItems.Add("")
                .Items((.Items.Count - 1)).SubItems.Add(txtname.Text)
                .Items((.Items.Count - 1)).SubItems.Add(txtdesc.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtprice.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtbarcode.Text)
                .Items((.Items.Count - 1)).SubItems.Add(txtqty.Text)
                ' .Items((.Items.Count - 1)).SubItems.Add(txtunit.Text)
                If MsgBox("Do you want to add another data?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
                    txtname.Text = ""
                    txtdesc.Text = ""
                    txtprice.Text = ""
                    txtbarcode.Text = ""
                    txtqty.Text = ""
                    txtunit.Text = ""
                    FrmPURCHASEORDERLIST.ShowDialog()
                Else
                    Me.Close()
                End If
            End With
        End If
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtqty.Text = str_Filter(txtqty, 48, 57, 0, 0)
    End Sub
End Class