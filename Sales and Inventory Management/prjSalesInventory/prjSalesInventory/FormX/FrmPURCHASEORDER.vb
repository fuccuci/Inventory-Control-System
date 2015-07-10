Public Class FrmPURCHASEORDER

    Private Sub FrmPURCHASEORDER_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim i As Integer
        If rbpurchase.Checked Then
            For i = 0 To listorder.Items.Count - 1
                'MsgBox(listorder.Items(i).SubItems(4).Text)
                If listorder.Items(i).SubItems(4).Text = "No" Then
                    listorder.Items(i).ForeColor = Color.Brown
                    '   Else
                    '      listorder.Items(i).ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Private Sub FrmPURCHASEORDER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub

    Private Sub FrmPURCHASEORDER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rbpurchase.Checked Then
            sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                     " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(Now, "MM/dd/yyyy") & "'" & _
                     " ORDER BY Purchase_ID"
            FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)

            Dim i As Integer
            If rbpurchase.Checked Then
                For i = 0 To listorder.Items.Count - 1
                    'MsgBox(listorder.Items(i).SubItems(4).Text)
                    If listorder.Items(i).SubItems(4).Text = "Yes" Then
                        listorder.Items(i).ForeColor = Color.Brown
                    Else
                        listorder.Items(i).ForeColor = Color.Black
                    End If
                Next
            End If
            MDIREFRESH()
        End If
        Audit_Trail(xUser_ID, TimeOfDay, "View Products Purchasing Order and Receive Form")
    End Sub

    Private Sub rbName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtname.Enabled = True
        dtpurchased.Enabled = False
    End Sub


    Private Sub dtreceived_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpurchased.ValueChanged
        If rbpurchase.Checked Then
            sqlSTR = "SELECT Purchase_ID as 'ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                     " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'" & _
                     " ORDER BY Purchase_ID"
            FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)
            Dim i As Integer
            If rbpurchase.Checked Then
                For i = 0 To listorder.Items.Count - 1
                    'MsgBox(listorder.Items(i).SubItems(4).Text)
                    If listorder.Items(i).SubItems(4).Text = "Yes" Then
                        listorder.Items(i).ForeColor = Color.Brown
                        'Else
                        '   listorder.Items(i).ForeColor = Color.Black
                    End If
                Next
            End If

        Else
            sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'ID', Replace(Replace(TBL_Suppliers.SuppName,'$.$',''''),'$..$',',') as 'Supplier Name' " & _
                     ", Replace(Replace(TBL_Purchase_Order.Address,'$.$',''''),'$..$',',') as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term' " & _
                     "FROM TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                     "AND TBL_Purchase_Order.Received_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)
        End If



    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        If rbpurchase.Checked Then
            sqlSTR = "SELECT Purchase_ID as 'ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                     " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     " WHERE TBL_Suppliers.SuppName LIKE '%" & txtname.Text & "%'" & _
                     " AND TBL_Purchase_Order.Purchased_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'" & _
                     " ORDER BY Purchase_ID"
        Else
            sqlSTR = "SELECT DISTINCT TBL_Purchase_Order.Purchase_ID as 'ID',TBL_Suppliers.SuppName as 'Supplier Name'" & _
                     ", TBL_Purchase_Order.Address as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term'" & _
                     "FROM (TBL_Purchase_Order " & _
                     "INNER JOIN TBL_Purchase_Detail ON TBL_Purchase_Order.Purchase_ID = TBL_Purchase_Detail.Purchase_ID) " & _
                     "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
                     "AND TBL_Purchase_Order.Received_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'" & _
                     " AND TBL_Suppliers.SuppName LIKE '%" & txtname.Text & "%'"
        End If

        FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)
        grpCat.Visible = False
    End Sub


    Private Sub rbreceive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbreceive.CheckedChanged
        If rbreceive.Checked Then
            Label3.Text = "Received Date :"
            sqlSTR = "SELECT TBL_Purchase_Order.Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name' " & _
             ", Replace(Replace(TBL_Purchase_Order.Address,'$.$',''''),'$..$',',') as 'Address', TBL_Purchase_Order.Delivery_Term as 'Delivery Term' " & _
             "FROM TBL_Purchase_Order " & _
             "INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
             "WHERE TBL_Purchase_Order.Approved = 'Yes' " & _
             "AND TBL_Purchase_Order.Received_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)
            MDIREFRESH()
            With MDIMain
                .cmdNew.Enabled = False
                .cmdEdit.Enabled = False
                .cmdDelete.Enabled = False
                '  .ToolStripNew.Enabled = False
                '  .ToolStripEdit.Enabled = False
                '  .ToolStripDelete.Enabled = False
            End With
        End If
    End Sub


    Private Sub FrmPURCHASEORDER_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .listorder.Width = GroupBox1.Width - 10
            .listorder.Height = GroupBox1.Height - 60
            .dtpurchased.Left = GroupBox1.Width - .dtpurchased.Width
            .Label3.Left = (.dtpurchased.Left - .Label3.Width) - 2
            .rbreceive.Left = GroupBox1.Width - .rbreceive.Width - 2
            .rbpurchase.Left = (.rbreceive.Left - .rbreceive.Width) - 10
        End With
        If rbreceive.Checked Then
            MDIREFRESH()
            With MDIMain
                .cmdNew.Enabled = False
                .cmdEdit.Enabled = False
                .cmdDelete.Enabled = False
                '  .ToolStripNew.Enabled = False
                '  .ToolStripEdit.Enabled = False
                '  .ToolStripDelete.Enabled = False
            End With
        Else
            'MDIREFRESH()
        End If
    End Sub

    Private Sub rbpurchase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpurchase.CheckedChanged
        If rbpurchase.Checked Then
            txtname.Enabled = False
            dtpurchased.Enabled = True
            Label3.Text = "Purchased Date :"
            sqlSTR = "SELECT Purchase_ID as 'Purchase ID', TBL_Suppliers.SuppName as 'Supplier Name', Delivery_Term as 'Delivery Term', Purchased_Date as 'Purchase Date', Approved" & _
                     " FROM TBL_Purchase_Order INNER JOIN TBL_Suppliers ON TBL_Purchase_Order.Supp_ID = TBL_Suppliers.Supp_ID " & _
                     " WHERE TBL_Purchase_Order.Purchased_Date ='" & Format(dtpurchased.Value, "MM/dd/yyyy") & "'" & _
                     " ORDER BY Purchase_ID"

            FillListView(ExecuteSQLQuery(sqlSTR), listorder, 0)
            Dim i As Integer
            If rbpurchase.Checked Then
                For i = 0 To listorder.Items.Count - 1
                    'MsgBox(listorder.Items(i).SubItems(4).Text)
                    If listorder.Items(i).SubItems(4).Text = "Yes" Then
                        listorder.Items(i).ForeColor = Color.Brown
                    Else
                        listorder.Items(i).ForeColor = Color.Black
                    End If
                Next
            End If
            MDIREFRESH()
        End If
    End Sub


    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class