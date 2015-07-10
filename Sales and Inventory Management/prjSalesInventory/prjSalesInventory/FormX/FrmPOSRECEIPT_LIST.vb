Public Class FrmPOSRECEIPT_LIST
    Dim and_SQL As String
    Private Sub chckcollector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckcollector.CheckedChanged
        'refresh_List()
        List_Update()
        If chckcollector.Checked Then
            cmbcollector.Enabled = True
        Else
            cmbcollector.Enabled = False
        End If
    End Sub

    Private Sub FrmPOSRECEIPT_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chckcollector.Checked = False
        FILLComboBox("SELECT user_ID, Username FROM TBL_Users  WHERE Access_Type ='Administrator' OR Access_Type ='Cashier'", cmbcollector)
        sqlSTR = "SELECT * FROM TBL_Users "
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            cmbcollector.Text = sqlDT.Rows(0)("User_ID") & " - " & sqlDT.Rows(0)("UserName")
        End If
        refresh_List()
        List_Update()
        Audit_Trail(xUser_ID, TimeOfDay, "View Sales Receipt Listing")
    End Sub

    Private Sub DtFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFrom.ValueChanged
        refresh_List()
        List_Update()
    End Sub

    Private Sub DtTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtTo.ValueChanged
        refresh_List()
        List_Update()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub refresh_List()
        If chckcollector.Checked Then
            and_SQL = " AND User_ID =" & Split(cmbcollector.Text, " - ")(0)
        Else
            and_SQL = ""
        End If
        sqlSTR = "SELECT Order_No AS 'Order No', Receipt_ID as 'Receipt No', Sales_ID as 'ID', VATable as 'Vatable', Total_Sale as 'Total Sale', Amount_Due as 'Amount Due', Void " & _
                 "FROM TBL_Sales_Receipt WHERE Receipt_Date >= '" & Format(DtFrom.Value, "MM/dd/yyyy") & "' AND Receipt_Date <= '" & Format(DtTo.Value, "MM/dd/yyyy") & "'"
        'MsgBox(sqlSTR)
        sqlSTR = sqlSTR & and_SQL
        FillListView(ExecuteSQLQuery(sqlSTR), lstreceipt, 0)
    End Sub

    Private Sub List_Update()
        Dim i As Integer
        For i = 0 To lstreceipt.Items.Count - 1
            If lstreceipt.Items(i).SubItems(6).Text = "Yes" Then
                lstreceipt.Items(i).ForeColor = Color.Brown
            End If
        Next
    End Sub



    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grpreceipt.Visible = True
        txtreceiptid.Select()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        grpreceipt.Visible = False
    End Sub

    Private Sub cmdgosearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgosearch.Click
        If Not IsNumeric(txtreceiptid.Text) Then
            MsgBox("Only numeric are allowed !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        Else
            sqlSTR = "SELECT Receipt_ID as 'Receipt No', Sales_ID as 'ID', VATable as 'Vatable', Total_Sale as 'Total Sale', Amount_Due as 'Amount Due', Void " & _
                     "FROM TBL_Sales_Receipt WHERE Receipt_ID =" & txtreceiptid.Text
            FillListView(ExecuteSQLQuery(sqlSTR), lstreceipt, 0)
        End If
        grpreceipt.Visible = False
    End Sub

    Private Sub cmbcollector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcollector.SelectedIndexChanged
        refresh_List()
        List_Update()
    End Sub

    Private Sub txtreceiptid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreceiptid.TextChanged
        txtreceiptid.Text = str_Filter(txtreceiptid, 48, 57, 46, 1)
    End Sub

    Private Sub lstreceipt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstreceipt.Click
        If lstreceipt.FocusedItem.SubItems(5).Text = "Yes" Then
            'lstreceipt.Items(i).ForeColor = Color.Brown
            cmdview.Enabled = False
            cmdvoid.Enabled = False
        Else
            cmdvoid.Enabled = True
            cmdview.Enabled = True
        End If
    End Sub

    Private Sub lstreceipt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstreceipt.SelectedIndexChanged

    End Sub

    Private Sub FrmPOSRECEIPT_LIST_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GBMID.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GBMID.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 100)

            .lstreceipt.Width = GBMID.Width - 10
            .lstreceipt.Height = GBMID.Height - (GBBOTTOM.Height + 20)
            GBBOTTOM.Top = lstreceipt.Height + 120
            '.listorder.Width = GroupBox1.Width - 10
            '.listorder.Height = GroupBox1.Height - 51
            '.dtpurchased.Left = GroupBox1.Width - .dtpurchased.Width
            '.Label3.Left = (.dtpurchased.Left - .Label3.Width) - 2
            '.rbreceive.Left = GroupBox1.Width - .rbreceive.Width
            '.rbpurchase.Left = (.rbreceive.Left - .rbreceive.Width) - 7
        End With
    End Sub

    Private Sub cmdview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdview.Click
        If lstreceipt.Items.Count > 0 Then
            lstreceipt.Focus()
            If lstreceipt.FocusedItem.SubItems(6).Text = "Yes" Then
                MsgBox("Can't view the records because it's already been void !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            Else
                If lstreceipt.Items.Count > 0 Then

                    lstreceipt.Focus()
                    FrmPOSVIEW.txtreceiptid.Text = lstreceipt.FocusedItem.SubItems(1).Text
                    FrmPOSVIEW.ShowDialog()
                End If
            End If
        End If


    End Sub

    Private Sub cmdvoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvoid.Click
        Dim x As Integer, i As Integer
        Dim sqlstrx(5) As String
        Dim voidNo As Integer
        lstreceipt.Focus()
        If x_Access(xUser_Access) Then
            If lstreceipt.Items.Count > 0 Then
                If MsgBox("Do you really want to void this receipt", MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
                    If lstreceipt.FocusedItem.SubItems(6).Text = "No" Then
                        voidNo = lstreceipt.FocusedItem.Text
                        sqlSTR = "INSERT INTO TBL_Sales_Void (Receipt_ID, Sales_ID, Void_Date) " & _
                                 "VALUES(" & lstreceipt.FocusedItem.SubItems(1).Text & ", " _
                                 & lstreceipt.FocusedItem.SubItems(2).Text & ", " _
                                 & "'" & Format(DTDATE.Value, "MM/dd/yyyy") & "')"
                        ExecuteSQLQuery(sqlSTR)
                        sqlSTR = "UPDATE TBL_Sales_Receipt SET Void ='" & "Yes" & "' WHERE Receipt_ID =" & lstreceipt.FocusedItem.SubItems(1).Text
                        ExecuteSQLQuery(sqlSTR)
                        'return stocks
                        sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & lstreceipt.FocusedItem.SubItems(2).Text
                        ExecuteSQLQuery(sqlSTR)
                        x = sqlDT.Rows.Count

                        For i = 0 To x - 1
                            ReDim Preserve sqlstrx(i)
                            sqlstrx(i) = "UPDATE TBL_Stocks_Balances SET Item_QTY = Item_Qty +" & sqlDT.Rows(i)("Item_Qty") & " WHERE Item_ID =" & sqlDT.Rows(i)("Item_ID")
                        Next
                        For i = 0 To x - 1
                            ExecuteSQLQuery(sqlstrx(i))
                        Next

                        'MsgBox(sqlDT.Rows.Count)
                        refresh_List()
                        List_Update()
                    Else
                        MsgBox("This receipt has already been voided !!", MsgBoxStyle.Information, "Sales and Inventory")
                        Exit Sub
                    End If
                    Audit_Trail(xUser_ID, TimeOfDay, "Receipt Void Receipt No: " & voidNo)
                    MsgBox("Void Success !!", MsgBoxStyle.Information, "Sales and Inventory")
                End If
            End If
        End If
    End Sub
End Class