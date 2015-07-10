Public Class FrmSUPPLIER_PRODUCT_PRINT

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        Dim Report As New FrmREPORTS
        'Rpt_SqlStr = "SELECT Suppname, Item_Name FROM ((TBL_Suppliers " & _
        '           "INNER JOIN TBL_Suppliers_Product ON TBL_Suppliers.Supp_ID = TBL_Suppliers_Product.Supp_ID) " & _
        '          "INNER JOIN TBL_Category_Item_File ON TBL_Suppliers_Product.Item_ID = TBL_Category_Item_File.Item_ID) " & _
        '         "WHERE TBL_Suppliers.Supp_ID =" & FrmSUPPLIERSPRODUCT.lstSuppliers.FocusedItem.Text
        'Rpt_SqlStr = "select * from tbl_suppliers "
        'MsgBox(Rpt_SqlStr)

        'SELECT 'TBL_Suppliers'.'SuppName', 'TBL_Category_Item_File'.'Item_Name'
        'FROM   ('TBL_Suppliers' 'TBL_Suppliers' INNER JOIN 'TBL_Suppliers_Product' 'TBL_Suppliers_Product' ON 'TBL_Suppliers'.'Supp_ID'='TBL_Suppliers_Product'.'Supp_ID') INNER JOIN 'TBL_Category_Item_File' 'TBL_Category_Item_File' ON 'TBL_Suppliers_Product'.'Item_ID'='TBL_Category_Item_File'.'Item_ID'

        If rbtAll.Checked Then
            Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName "
        Else
            FrmSUPPLIERSPRODUCT.lstSuppliers.Focus()
            FrmSUPPLIERSPRODUCT.lstSuppliers.Select()
            Rpt_SqlStr = "SELECT * FROM TBL_Suppliers WHERE Supp_ID =" & FrmSuppliersList.lstSuppliers.FocusedItem.Text & " Order by SuppName"
        End If
        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Suppliers Products ")
        'FrmREPORTS.Show()
        Report.Show()
        Me.Close()
    End Sub
End Class