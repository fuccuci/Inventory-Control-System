Public Class FrmPRODUCT_PACING_PRINT

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        If rbfast.Checked Then
            Rpt_SqlStr = "SELECT  DISTINCT TBL_Category_Item_File.Item_ID,  TBL_Sales_Sold_Detail.Item_Name, TBL_Sales_Sold_Detail.Item_QTY, SUM(Item_QTY) " & _
                         "FROM TBL_Sales_Sold_Detail " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Sales_Sold_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                         "INNER JOIN TBL_Sales_Sold ON TBL_Sales_Sold_Detail.Sales_ID = TBL_Sales_Sold.Sales_ID " & _
                         "WHERE TBL_Sales_Sold.Sales_Date >='" & dtfrom.Value & "' AND TBL_Sales_Sold.Sales_Date <='" & dtto.Value & "'" & _
                         "GROUP BY  TBL_Category_Item_File.Item_ID,  TBL_Sales_Sold_Detail.Item_Name, TBL_Sales_Sold_Detail.Item_QTY "
            globalFRM = "frmproduct_pacing"
        ElseIf rbslow.Checked Then

        End If
        Report.Show()
    End Sub

    Private Sub FrmPRODUCT_PACING_PRINT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged

    End Sub

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged

    End Sub
End Class