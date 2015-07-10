Public Class FrmRECEIVE_ORDER_PRINT

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim Report As New FrmREPORTS
        'Rpt_SqlStr = "SELECT *,*,*,* FROM (((TBL_Purchase_Order " & _
        '             "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
        '             "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID) " & _
        '             "INNER JOIN TBL_Category_Item_File ON TBL_Purchase_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
        '             "WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <=' " & Format(dtTo.Value, "MM/dd/yyyy") & "'" _
        '           & " AND Approved ='Yes' "

        Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order WHERE Purchased_Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Purchased_Date <='" & Format(dtTo.Value, "MM/dd/yyyy") & "' AND Approved ='Yes'"
        ' Rpt_SqlStr = "SELECT * FROM TBL_Purchase_Order "
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Receive Order ")
        Report.Show()
        Me.Close()
        'FrmREPORTS.Show()
    End Sub
End Class