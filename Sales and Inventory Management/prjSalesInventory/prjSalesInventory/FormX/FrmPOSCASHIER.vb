Public Class FrmPOSCASHIER
    Dim vat_tax As Double
    Dim amount As Double
    Dim b_found As Boolean
    Dim Iprev_Qty As Integer
    Dim iz As Integer
    Dim strCurr As String

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub FrmPOSCASHIER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim sqlno As String
        If xpass Then
            For i = 0 To UBound(xid)
                'MsgBox(UBound()
                'MsgBox(xid(i))
                'ReDim Preserve sqlno
                sqlno = "UPDATE TBL_Stocks_Balances SET PASSWORD_INPUTED = 'No' WHERE Item_ID =" & xid(i)
                'MsgBox(sqlno)
                ExecuteSQLQuery(sqlno)
            Next
            xpass = False
        End If

        'If UCase(xUser_Access) = UCase("Cashier") And xlock = False Then
        ' If MsgBox("Do you really want to exit the system ??", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
        ' End
        ' Else
        ' e.Cancel = 1
        'End If
        'End If
    End Sub

    Private Sub FrmPOSCASHIER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim lock As Boolean
        cmbSelectType.Text = "Order No"
        cmbSelectType.SelectedIndex = 0
        xlock = False
        vat_tax = (100 + VAT) / 100
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        lblbarcode.Text = ""
        lbltotalamount.Text = "0.00"
        txtbarcode.Text = ""
        txtID.Text = ""
        txtname.Text = ""
        txtprice.Text = ""
        txtqty.Text = ""
        txtvatexempt.Text = "0.00"
        lstItems.Items.Clear()
        txtbarcode.Focus()
        txtbarcode.Select()
        howx = 0
        txtvatable.Text = ""
        txtvat12.Text = ""

        txttotalsale.Text = ""
        txtamountdue.Text = ""
        Timer1.Enabled = False
        sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                 "FROM TBL_Category_Item_File INNER JOIN " & _
                 "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                 "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            lblreach.Visible = False
        End If
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If CDbl(lbltotalamount.Text) > 0 And lstItems.Items.Count > 0 Then
            FrmPOSPAYMENT.lblamountdue.Text = lbltotalamount.Text
            FrmPOSPAYMENT.ShowDialog()
        End If
    End Sub

    Private Sub lstItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstItems.KeyDown
        ' MsgBox(e.KeyCode)
        Dim X As Integer
        'MsgBox(e.KeyCode)
        If e.KeyCode = 46 Then
            If lstItems.Items.Count > 0 Then
                lstItems.FocusedItem.Remove()
                lstItems.Refresh()
                amount = 0
                For X = 0 To lstItems.Items.Count - 1
                    amount = amount + lstItems.Items(X).SubItems(3).Text * lstItems.Items(X).SubItems(4).Text
                    lblready.Text = "Computing . . ."
                Next
                lblready.Text = "Ready . . ."
                lbltotalamount.Text = Format(amount, "###,###.00") ' TOTAL AMOUNT DUE
                txtvatable.Text = Format(amount - (amount - (amount / vat_tax)), "###,###.00") ' VATable Amount
                txttotalsale.Text = CDbl(txtvatable.Text) - CDbl(txtvatexempt.Text) ' TOTAL SALE
                txtvat12.Text = Format((amount - (amount / vat_tax)), "###,###.00") ' 12 % VAT
                txtamountdue.Text = Format(CDbl(txttotalsale.Text) + CDbl(txtvat12.Text), "###,###.00") ' Amount Due
                txtID.Text = ""
                txtname.Text = ""
                txtbarcode.Text = ""
                txtqty.Text = ""
                txtname.Text = ""
                txtdescription.Text = ""
                txtprice.Text = ""
                txtbarcode.Focus()
                txtbarcode.Select()
            End If
        End If
    End Sub


    Private Sub txtKeyDown()
        Dim i As Integer
        Dim xStock As Integer

        amount = 0
        xStock = 0
        'If MsgBox("Proceed Current Data ??", MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
        If txtqty.Text = "" Or txtqty.Text = "0" Then
            MsgBox("Quantity should not be zero or null !!!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If txtbarcode.Text = "" And txtdescription.Text = "" And txtID.Text = "" And txtname.Text = "" And txtprice.Text = "" Then
            MsgBox("No Record Found, Fields Should Not Be Empty !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            txtqty.Text = ""
            txtbarcode.Focus()
            txtbarcode.Select()
            Exit Sub
        End If
        '-------------
        'CHECK REORDER POINT
        With lstItems
            sqlSTR = "SELECT *, * FROM TBL_Category_Item_File " & _
                     "INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                     "WHERE TBL_Stocks_Balances.Item_ID =" & txtID.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                'MsgBox(sqlDT.Rows(0)("item_QTY") & " " & txtqty.Text)
                'MsgBox(sqlDT.Rows(0)("Item_Reorder_Point"))
                For i = 0 To .Items.Count - 1
                    'MsgBox(lstItems.Items(i).Text)
                    If .Items(i).Text = txtID.Text Then
                        xStock = .Items(i).SubItems(4).Text
                    End If
                Next
                ' MsgBox(xStock)
                If (CDbl(sqlDT.Rows(0)("Item_QTY")) - CDbl(txtqty.Text + xStock)) <= sqlDT.Rows(0)("Item_Reorder_Point") Then
                    If (CDbl(sqlDT.Rows(0)("Item_QTY")) - CDbl(txtqty.Text + xStock)) < 0 Then
                        MsgBox("Insufficient number of stocks !! " & _
                     Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("Item_QTY"), MsgBoxStyle.Critical, "Sales and Inventory")
                        Exit Sub
                    End If
                    If sqlDT.Rows(0)("PASSWORD_INPUTED") = "No" Then
                        MsgBox("Reorder point of this item has been reach !!" & _
                               Chr(10) & "-------------------------------" & _
                               Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("Item_QTY") & Chr(10) & _
                                        "Reorder Point : " & sqlDT.Rows(0)("Item_Reorder_Point"), MsgBoxStyle.Exclamation, "Sales and Inventory")
                        globalID = txtID.Text 'pass to globalID variable
                        ReDim Preserve xid(howx)
                        xid(howx) = txtID.Text
                        howx = howx + 1
                        sqlSTR = "UPDATE TBL_Stocks_Balances SET PASSWORD_INPUTED ='" & "Yes" & "' WHERE Item_ID =" & txtID.Text
                        ExecuteSQLQuery(sqlSTR)
                        pass = True
                        'Audit_Trail(xUser_ID, "Access to over-ride the critical of the product")
                        xpass = True
                        'FrmPASSWORD.ShowDialog()
                        ' pass = True
                        'b_found = True
                        For i = 0 To .Items.Count - 1
                            If .Items(i).Text = txtID.Text Then
                                b_found = True
                            End If
                        Next

                    Else
                        pass = True
                    End If

                    If pass Then
                        For i = 0 To .Items.Count - 1
                            If .Items(i).Text = txtID.Text Then
                                '.Items(i).Remove()
                                .Items(i).SubItems(4).Text = txtqty.Text + Iprev_Qty
                                Exit For
                            End If
                        Next
                        If b_found = False Then

                            .Items.Add(txtID.Text, 0)
                            .Items((.Items.Count - 1)).SubItems.Add(R_Change(txtname.Text))
                            .Items((.Items.Count - 1)).SubItems.Add(R_Change(txtdescription.Text))
                            .Items((.Items.Count - 1)).SubItems.Add(txtprice.Text)
                            .Items((.Items.Count - 1)).SubItems.Add(txtqty.Text)
                        End If
                        pass = False
                    End If
                Else
                    For i = 0 To .Items.Count - 1
                        If .Items(i).Text = txtID.Text Then
                            '.Items(i).Remove()
                            .Items(i).SubItems(4).Text = txtqty.Text + Iprev_Qty
                            'MsgBox("1")
                            Exit For
                        End If
                    Next
                    If b_found = False Then
                        .Items.Add(txtID.Text, 0)
                        .Items((.Items.Count - 1)).SubItems.Add(R_Change(txtname.Text))
                        .Items((.Items.Count - 1)).SubItems.Add(R_Change(txtdescription.Text))
                        .Items((.Items.Count - 1)).SubItems.Add(txtprice.Text)
                        .Items((.Items.Count - 1)).SubItems.Add(txtqty.Text)
                    End If
                End If
            End If
            'END CHECK REORDER POINT
            '-------------
        End With
        For i = 0 To lstItems.Items.Count - 1
            amount = amount + lstItems.Items(i).SubItems(3).Text * lstItems.Items(i).SubItems(4).Text
            lblready.Text = "Computing . . ."
        Next
        lblready.Text = "Ready . . ."
        lbltotalamount.Text = Format(amount, "###,###.00") ' TOTAL AMOUNT DUE
        txtvatable.Text = Format(amount - (amount - (amount / vat_tax)), "###,###.00") ' VATable Amount
        txttotalsale.Text = CDbl(txtvatable.Text) - CDbl(txtvatexempt.Text) ' TOTAL SALE
        txtvat12.Text = Format((amount - (amount / vat_tax)), "###,###.00") ' 12 % VAT
        txtamountdue.Text = Format(CDbl(txttotalsale.Text) + CDbl(txtvat12.Text), "###,###,###.00") ' Amount Due
        txtID.Text = ""
        txtname.Text = ""
        txtbarcode.Text = ""
        txtqty.Text = ""
        txtname.Text = ""
        txtdescription.Text = ""
        txtprice.Text = ""
        txtbarcode.Focus()
        txtbarcode.Select()
        'End If
        b_found = False
    End Sub

    Private Sub txtreceiptno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtreceiptno.KeyDown
        Dim i As Integer
        If e.KeyCode = 13 Then
            amount = 0
            'sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Receipt_ID =" & txtreceiptno.Text
            sqlSTR = "SELECT * FROM TBL_Sales_Receipt " & _
                     "INNER JOIN TBL_Sales_Sold_Detail ON TBL_Sales_Receipt.Sales_ID = TBL_Sales_Sold_Detail.Sales_ID " & _
                     "WHERE TBL_Sales_Receipt.Receipt_ID =" & txtreceiptno.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                For i = 0 To sqlDT.Rows.Count - 1
                    lstItems.Items.Add(sqlDT.Rows(i)("Item_ID"), 0)
                    lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                    lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Description")))
                    lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                    lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_QTY"))
                Next
                For i = 0 To lstItems.Items.Count - 1
                    amount = amount + lstItems.Items(i).SubItems(3).Text * lstItems.Items(i).SubItems(4).Text
                    lblready.Text = "Computing . . ."
                Next
                lblready.Text = "Ready . . ."
                lbltotalamount.Text = Format(amount, "###,###.00") ' TOTAL AMOUNT DUE
                txtvatable.Text = Format(amount - (amount - (amount / vat_tax)), "###,###.00") ' VATable Amount
                txttotalsale.Text = CDbl(txtvatable.Text) - CDbl(txtvatexempt.Text) ' TOTAL SALE
                txtvat12.Text = Format((amount - (amount / vat_tax)), "###,###.00") ' 12 % VAT
                txtamountdue.Text = format(CDbl(txttotalsale.Text) + CDbl(txtvat12.Text),"###,###,###.00") ' Amount Due
                txtID.Text = ""
                txtname.Text = ""
                txtbarcode.Text = ""
                txtqty.Text = ""
                txtname.Text = ""
                txtdescription.Text = ""
                txtprice.Text = ""
                txtbarcode.Focus()
                txtbarcode.Select()
                ' sqlSTR = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & sqlDT.Rows(0)("Sales_ID")
            Else
                MsgBox("No Receipt Number Found !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtreceiptno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreceiptno.TextChanged
        txtreceiptno.Text = str_Filter(txtreceiptno, 48, 57, 0, 0)
    End Sub

    Private Sub lstItems_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstItems.MouseDoubleClick
        Dim xqty
        'If IsNumeric(InputBox("Input quantity", "Sales and Inventory")) Then
        '        End If
        xqty = InputBox("Input quantity", "Sales and Inventory")
        If IsNumeric(xqty) Then
            'MsgBox("A")
            If xqty > 0 Then
                sqlSTR = "SELECT * FROM TBL_Stocks_Balances WHERE Item_ID =" & lstItems.FocusedItem.Text
                ExecuteSQLQuery(sqlSTR)
                If CDbl(sqlDT.Rows(0)("Item_QTY")) - CDbl(xqty) >= 0 Then
                    lstItems.FocusedItem.SubItems(4).Text = xqty
                Else
                    MsgBox("Insufficient number of stocks !! " & _
                    Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("Item_QTY"), MsgBoxStyle.Critical, "Sales and Inventory")
                    Exit Sub
                End If
                amount = 0
                For i = 0 To lstItems.Items.Count - 1
                    amount = amount + lstItems.Items(i).SubItems(3).Text * lstItems.Items(i).SubItems(4).Text
                    lblready.Text = "Computing . . ."
                Next
                lblready.Text = "Ready . . ."
                lbltotalamount.Text = Format(amount, "###,###.00") ' TOTAL AMOUNT DUE
                txtvatable.Text = Format(amount - (amount - (amount / vat_tax)), "###,###.00") ' VATable Amount
                txttotalsale.Text = CDbl(txtvatable.Text) - CDbl(txtvatexempt.Text) ' TOTAL SALE
                txtvat12.Text = Format((amount - (amount / vat_tax)), "###,###.00") ' 12 % VAT
                txtamountdue.Text = Format(CDbl(txttotalsale.Text) + CDbl(txtvat12.Text), "###,###.00") ' Amount Due
            End If
        End If

        ' grpquantity.Visible = True
        ' grpquantity.Enabled = True
        ' GroupBox1.Enabled = False
        ' GroupBox2.Enabled = False
    End Sub

    Private Sub lstItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstItems.SelectedIndexChanged

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        iz = iz + 1
        If (iz Mod 2) = 0 Then
            lblreach.Visible = False
        Else
            lblreach.Visible = True
        End If
    End Sub

    Private Sub cmdlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlock.Click
        'Lock = True
        'Me.Close()
        xlock = True
        'FrmLOGIN.ShowDialog()
        'Frmtest.ShowDialog()
        Me.Close()
        'End

    End Sub

    Private Sub txtbarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbarcode.KeyDown
        Dim x As Integer

        If e.KeyCode = 13 Then
            If cmbSelectType.SelectedIndex = 0 Then
                Call txtdown_order()
            Else
                If Not IsNumeric(txtbarcode.Text) Then
                    MsgBox("Barcode should be numeric !!!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    Exit Sub
                End If
                sqlSTR = "SELECT *, * " & _
                         "FROM TBL_Stocks_Balances " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Stocks_Balances.Item_ID = TBL_Category_Item_File.Item_ID " & _
                         "WHERE TBL_Stocks_Balances.Item_Barcode =" & txtbarcode.Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    lblbarcode.Text = txtbarcode.Text
                    txtID.Text = sqlDT.Rows(0)("Item_ID")
                    txtname.Text = R_Change(sqlDT.Rows(0)("Item_Name"))
                    txtdescription.Text = R_Change(sqlDT.Rows(0)("Item_Description"))
                    txtprice.Text = sqlDT.Rows(0)("Item_Price")
                    'txtqty.Text = "1"
                    txtqty.Text = "1"
                    txtqty.Focus()
                    Iprev_Qty = 0
                    For x = 0 To lstItems.Items.Count - 1
                        'MsgBox(lstItems.Items(x).Text)
                        If lstItems.Items(x).Text = txtID.Text Then
                            Iprev_Qty = lstItems.Items(x).SubItems(4).Text ' iF item found get the quantity
                            txtqty.Select()
                            txtqty.Focus()
                            b_found = True
                        End If
                    Next
                    'If b_found <> True Then txtKeyDown()
                    'txtqty_KeyDown(txtbarcode.Text, txtbarcode.Select)
                    'Call txtqty_KeyDown(txtqty.Text, )
                Else
                    MsgBox("No Item Data Found !!!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    txtbarcode.Text = ""
                    Exit Sub
                End If
            End If
        End If
    End Sub



    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged
        txtbarcode.Text = str_Filter(txtbarcode, 48, 57, 0, 0)
    End Sub

    Private Sub txtqty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = 13 Then
            txtKeyDown()
            sqlSTR = "SELECT TBL_Category_Item_File.Item_ID as 'ID', Item_Name as 'Name', TBL_Category_Item_File.Item_Description as 'Description / Item Number', TBL_Stocks_Balances.Item_Price as 'Price', Item_Reorder_Point as 'Reorder Point', Item_QTY as 'CURRENT STOCKS' " & _
                     "FROM TBL_Category_Item_File INNER JOIN " & _
                     "TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                     "WHERE  TBL_Stocks_Balances.Item_QTY <= Item_Reorder_Point"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                Timer1.Enabled = True
            Else
                Timer1.Enabled = False
                lblreach.Visible = False
            End If
        Else
            'MsgBox(e.KeyCode)
            'If e.KeyCode >= 48 And e.KeyCode <= 57 Then
            ' MsgBox("test")
            'End If
        End If
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtqty.Text = str_Filter(txtqty, 48, 57, 0, 0)
    End Sub

    Private Sub cmbSelectType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectType.SelectedIndexChanged
        txtvatable.Text = ""
        txtvatexempt.Text = "0.00"
        txttotalsale.Text = ""
        txtvat12.Text = ""
        txtamountdue.Text = ""
        If cmbSelectType.SelectedIndex = 0 Then
            Label1.Text = "Order No:"
            ' txtbarcode.Enabled = False
            'cmdopen.Enabled = True
            txtqty.Enabled = False
            lstItems.Items.Clear()
            lbltotalamount.Text = "0.00"
            txtbarcode.Text = "0"
            txtID.Text = ""
            txtname.Text = ""
            txtprice.Text = ""
            txtqty.Text = ""
            txtvatexempt.Text = "0.00"
            txtname.Enabled = False
            txtbarcode.Focus()

        ElseIf cmbSelectType.SelectedIndex = 1 Then
            Label1.Text = "Barcode :"
            ' txtbarcode.Enabled = False
            ' cmdopen.Enabled = False
            txtqty.Enabled = True
            lstItems.Items.Clear()
            lbltotalamount.Text = "0.00"
            txtbarcode.Text = "0"
            txtID.Text = ""
            txtname.Text = ""
            txtprice.Text = ""
            txtqty.Text = ""
            txtvatexempt.Text = "0.00"
            lstItems.Items.Clear()
            txtname.Enabled = True
            txtbarcode.Focus()
        ElseIf cmbSelectType.SelectedIndex = 2 Then
            'txtbarcode.Enabled = True
        End If
    End Sub

    Private Sub txtdown_order()
        ' Dim x As Integer
        lstItems.Items.Clear()
        If cmbSelectType.SelectedIndex = 0 Then
            If txtbarcode.Text <> "" Then
                txtvatable.Text = ""
                txtvatexempt.Text = "0.00"
                txttotalsale.Text = ""
                txtvat12.Text = ""
                txtamountdue.Text = ""
                lbltotalamount.Text = 0

                sqlSTR = "SELECT * FROM TBL_Sales_Receipt " & _
                          "WHERE Sales_ID NOT IN(SELECT Sales_ID FROM TBL_Sales_Void) " & _
                          "AND Order_No = " & txtbarcode.Text
                ' sqlSTR = "SELECT * FROM TBL_Sales_Receipt " & _
                '         "WHERE Order_No = " & txtbarcode.Text & _
                '         "AND Void ='" & "No" & "'"

                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    If MsgBox("Order No. already exists in the payment receipt !! VOID this to be able to RE-COMPUTE again !! ", MsgBoxStyle.Exclamation, "Sales and Inventory") Then
                        Exit Sub
                    End If
                End If
                sqlSTR = "SELECT TBL_Category_Item_File.Item_ID, TBL_Category_Item_File.Item_Name, " & _
                         "TBL_Category_Item_File.Item_Description, TBL_Category_Item_File.Item_Price, " & _
                         "TBL_Orders_Detail.QTY, TBL_Stocks_Balances.Item_QTY " & _
                         "FROM (((TBL_Orders " & _
                         "INNER JOIN TBL_Orders_Detail ON TBL_Orders.Order_No = TBL_Orders_Detail.Order_No) " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Orders_Detail.Item_ID = TBL_Category_Item_File.Item_ID) " & _
                         "INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID) " & _
                         "WHERE TBL_Orders.Order_No =" & txtbarcode.Text & _
                         "ORDER BY TBL_Orders_Detail.Item_ID ASC"

                ' sqlSTR = "SELECT * " & _
                '          "FROM " & _
                '          "TBL_Category_Item_File " & _
                '          "INNER JOIN TBL_Orders_Detail  ON TBL_Category_Item_File.Item_ID = TBL_Orders_Detail.Item_ID " & _
                '          "INNER JOIN TBL_Orders ON TBL_Orders_Detail.Order_No = TBL_Orders.Order_No " & _
                '          "WHERE TBL_Orders.Order_No =" & txtbarcode.Text & _
                '            "ORDER BY TBL_Orders_Detail.Item_ID ASC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    For i = 0 To sqlDT.Rows.Count - 1
                        If CDbl(sqlDT.Rows(i)("Item_QTY")) >= CDbl(sqlDT.Rows(i)("QTY")) Then
                            With lstItems
                                .Items.Add(sqlDT.Rows(i)("Item_ID"), 0)
                                .Items((.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(i)("Item_Name")))
                                .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Description"))
                                .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Price"))
                                .Items((.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("QTY"))
                            End With
                        Else
                            strCurr = "Insufficient Stock Balance " & Chr(13)
                            strCurr = strCurr & "Stock Balance : " & sqlDT.Rows(i)("Item_QTY") & Chr(13)
                            strCurr = strCurr & "Order Quantity : " & sqlDT.Rows(i)("QTY")
                            MsgBox(strCurr, MsgBoxStyle.Information, "Sales and Inventory")
                            Exit Sub
                        End If
                    Next
                    '-check back load
                    'sqlSTR = "SELECT * FROM TBL_Back_Load_Dtl WHERE Order_No =" & txtbarcode.Text
                    'ExecuteSQLQuery(sqlSTR)
                    'If sqlDT.Rows.Count > 0 Then
                    ' For x = 0 To sqlDT.Rows.Count - 1
                    ' For i = 0 To lstItems.Items.Count - 1
                    ' If lstItems.Items(i).Text = sqlDT.Rows(x)("Item_ID") Then
                    ' If CDbl(sqlDT.Rows(x)("Back_QTY")) > CDbl(lstItems.Items(i).SubItems(4).Text) Then
                    ' lstItems.Items(i).SubItems(4).Text = sqlDT.Rows(x)("Back_QTY") - CDbl(lstItems.Items(i).SubItems(4).Text)
                    'Else
                    '    lstItems.Items(i).SubItems(4).Text = CDbl(lstItems.Items(i).SubItems(4).Text) - sqlDT.Rows(x)("Back_QTY")
                    'End If
                    'End If
                    '    Next
                    '    Next
                    'End If
                    '--
                    amount = 0
                    For i = 0 To lstItems.Items.Count - 1
                        amount = amount + lstItems.Items(i).SubItems(3).Text * lstItems.Items(i).SubItems(4).Text
                        lblready.Text = "Computing . . ."
                    Next
                    lblready.Text = "Ready . . ."
                    lbltotalamount.Text = Format(amount, "###,###.00") ' TOTAL AMOUNT DUE
                    txtvatable.Text = Format(amount - (amount - (amount / vat_tax)), "###,###.00") ' VATable Amount
                    txttotalsale.Text = CDbl(txtvatable.Text) - CDbl(txtvatexempt.Text) ' TOTAL SALE
                    txtvat12.Text = Format((amount - (amount / vat_tax)), "###,###.00") ' 12 % VAT
                    txtamountdue.Text = Format(CDbl(txttotalsale.Text) + CDbl(txtvat12.Text), "###,###,###.00") ' Amount Due
                    'txtDiscount.Text = "0"
                    'txttotalamountdue.Text = lbltotalamount.Text
                Else
                    MsgBox("No order no. found !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub cmbSelectType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectType.SelectedValueChanged

    End Sub

    Private Sub lblreach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblreach.Click

    End Sub
End Class