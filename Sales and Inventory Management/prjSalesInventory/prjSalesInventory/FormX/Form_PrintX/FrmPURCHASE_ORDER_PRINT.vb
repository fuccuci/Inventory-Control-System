Public Class FrmPURCHASE_ORDER_PRINT

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim Report As New FrmREPORTS
        If rbtnone.Checked Then
            Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <=' " & Format(dtTo.Value, "MM/dd/yyyy") & "'"
        ElseIf rbtyes.Checked Then
            Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <='" & Format(dtTo.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'"
        ElseIf rbselected.Checked Then
            With FrmPURCHASEORDER
                If .listorder.Items.Count > 0 Then
                    globalFRM = "PurchaseORder_BySupplier"
                    .listorder.Focus()
                Else
                    MsgBox("Can't continue printing, because there was no record on the list !!", MsgBoxStyle.Information, "Sales and Inventory")
                    Exit Sub
                End If
                
                Rpt_SqlStr = "SELECT * " & _
                             "FROM TBL_Purchase_Order " & _
                             "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID " & _
                             "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                             "WHERE TBL_Purchase_Order.Purchase_ID =" & .listorder.FocusedItem.Text

            End With
        End If
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Purchase Order ")
        Me.Close()
        Report.Show()
        'Me.Close()
        'FrmREPORTS.Show()
    End Sub
End Class