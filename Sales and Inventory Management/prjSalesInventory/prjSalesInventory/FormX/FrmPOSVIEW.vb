Public Class FrmPOSVIEW

    Private Sub FrmPOSVIEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        lstitems.Items.Clear()
        'sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & txtreceiptid.Text
        sqlSTR = "SELECT * FROM TBL_Sales_Receipt " & _
                 "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                 "WHERE Receipt_ID =" & txtreceiptid.Text
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstitems.Items.Add(sqlDT.Rows(i)("Item_ID"))
                lstitems.Items(i).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
                lstitems.Items(i).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                lstitems.Items(i).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                lstitems.Items(i).SubItems.Add(sqlDT.Rows(i)("Sales_Detail_ID"))
            Next
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstitems.Items.Count > 0 Then
            lstitems.Focus()
            FrmPOSEDIT.Label4.Text = lstitems.FocusedItem.Text
            FrmPOSEDIT.txtid.Text = lstitems.FocusedItem.Text
            FrmPOSEDIT.txtname.Text = lstitems.FocusedItem.SubItems(2).Text
            FrmPOSEDIT.txtprice.Text = lstitems.FocusedItem.SubItems(3).Text
            FrmPOSEDIT.txtqty.Text = lstitems.FocusedItem.SubItems(1).Text
            FrmPOSEDIT.Label6.Text = lstitems.FocusedItem.SubItems(4).Text
            FrmPOSEDIT.ShowDialog()
        End If
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Dim Report As New FrmREPORTS
        If txtreceiptid.Text <> 0 Or txtreceiptid.Text <> "" Then
            Rpt_SqlStr = "SELECT * FROM TBL_Sales_Receipt " & _
                         "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                         "WHERE Receipt_ID =" & txtreceiptid.Text
            'Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & txtreceiptid.Text
            'MsgBox(Rpt_SqlStr)
            globalFRM = "frmPOSPAYMENT"
            'FrmREPORTS.Show()
            Report.Show()
        End If
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        'FrmPOSADD.ShowDialog()
        'FrmPOSSTOCKSLIST.ShowDialog()
        FrmPOS_CHOICES.ShowDialog()
    End Sub
End Class