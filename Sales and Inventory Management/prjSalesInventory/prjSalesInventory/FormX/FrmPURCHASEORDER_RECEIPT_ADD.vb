Public Class FrmPURCHASEORDER_RECEIPT_ADD
    Dim stockId As Integer

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cboSupplier.Text <> "" Then
            FrmPURCHASEORDER_RECEIPT_DATA.ShowDialog()
        Else
            MsgBox("No Supplier Name Selected !", MsgBoxStyle.Information, "Sales and Inventory")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmPURCHASEORDER_RECEIPT_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim suppName As String
        stockId = globalID
        FILLComboBox("SELECT Supp_ID, SuppName FROM TBL_Suppliers", cboSupplier)
    End Sub
End Class