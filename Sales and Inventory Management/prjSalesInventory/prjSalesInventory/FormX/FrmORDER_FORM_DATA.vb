Public Class FrmORDER_FORM_DATA
    Dim EnterX As Boolean
    Dim timx As Integer
    Dim iOrder_no As Integer
    Dim counter As Integer
    Dim add As Boolean
    Private Sub FrmORDER_FORM_DATA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Order Form"
    End Sub

    Private Sub FrmORDER_FORM_DATA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtID.Text = 0
        txtorderno.Text = 0
        txtQTYi.Text = 0
        txtUnitCost.Text = 0
        txtQTY.Text = 0
        iOrder_no = 0
        txtdesc.Text = ""

        txtsearch.Text = ""
        txtTotalAmount.Text = 0
        txtUnit.Text = ""
        lstCurrentLoad.Items.Clear()

        add = True
        cmdLoad.Enabled = False
        If Split(Me.Text, " - ")(1) = "Edit" Then
            'MsgBox(globalID)
            txtorderno.Text = globalID
            iOrder_no = globalID
            add = False
            sqlSTR = "SELECT * FROM TBL_Orders_Detail " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Orders_Detail.Item_ID = TBL_Category_Item_File.Item_ID " & _
                     "WHERE Order_No = " & txtorderno.Text
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                With lstCurrentLoad
                    For i = 0 To sqlDT.Rows.Count - 1
                        .Items.Add(sqlDT.Rows(i)("Item_ID"))
                        .Items(.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(i)("Product_Name")))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Item_Description"))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Unit_Measure"))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Unit_Cost"))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("QTY"))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("TOTAL_COST"))
                    Next
                End With
            End If

            'check

            sqlSTR = "SELECT * FROM TBL_Sales_Receipt WHERE Order_No =" & txtorderno.Text & _
                     " AND Void ='No'"

            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                MsgBox("Can't Edit this module, please void the Order No first !", MsgBoxStyle.Exclamation, "Sales And Inventory")
                cmdLoad.Enabled = False
                cmdRemove.Enabled = False
                cmdSave.Enabled = False
                txtsearch.Enabled = False
            Else
                txtsearch.Enabled = True
                'cmdLoad.Enabled = True
                cmdRemove.Enabled = True
                cmdSave.Enabled = True
            End If
        Else
            'ADD
            txtsearch.Enabled = True
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        'MsgBox(e.KeyCode)
        If e.KeyCode = 40 And lstproducts.Items.Count > 0 Then
            lstproducts.Focus()
            lstproducts.Items(0).Selected = True
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If Len(txtsearch.Text) > 0 And Not EnterX Then
            lstproducts.Items.Clear()
            lstproducts.Top = (txtsearch.Top + txtsearch.Height)
            lstproducts.Left = txtsearch.Left
            'search
            '                     "WHERE LEFT(Catg_Name," & Len(txtcatname.Text) & ")  ='" & txtcatname.Text & "'"
            sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_Name as 'Name', TBL_Category_Item_File.Item_Description, TBL_Category_Item_File.Unit_Measure, TBL_Category_Item_File.Item_Price, TBL_Stocks_Balances.Item_QTY " & _
                     "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                     "WHERE LEFT(TBL_Category_Item_File.Item_Name," & Len(R_eplace(txtsearch.Text)) & ") ='" & R_eplace(txtsearch.Text) & "'" _
                     & "ORDER BY TBL_Category_Item_File.Item_name"
            ExecuteSQLQuery(sqlSTR)
            'FillListView(ExecuteSQLQuery(sqlSTR), lstproducts, 0)
            For x = 0 To sqlDT.Rows.Count - 1
                '   lstItems.Items.Add(sqlDT.Rows(i)("Item_ID"))
                '   lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Name"))
                lstproducts.Items.Add(sqlDT.Rows(x)("ID"))
                lstproducts.Items((lstproducts.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(x)("Name")))
                lstproducts.Items((lstproducts.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(x)("Item_Description")))
                lstproducts.Items((lstproducts.Items.Count - 1)).SubItems.Add(sqlDT.Rows(x)("Unit_Measure"))
                lstproducts.Items((lstproducts.Items.Count - 1)).SubItems.Add(sqlDT.Rows(x)("Item_Price"))
                lstproducts.Items((lstproducts.Items.Count - 1)).SubItems.Add(sqlDT.Rows(x)("Item_QTY"))
            Next
            lstproducts.Visible = True
        Else
            lstproducts.Visible = False
            EnterX = False
        End If
    End Sub

    Private Sub lstproducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstproducts.KeyDown
        If e.KeyCode = 13 Then
            EnterX = True
            txtsearch.Text = lstproducts.FocusedItem.SubItems(1).Text
            txtdesc.Text = lstproducts.FocusedItem.SubItems(2).Text
            txtID.Text = lstproducts.FocusedItem.Text
            txtUnit.Text = lstproducts.FocusedItem.SubItems(3).Text
            txtUnitCost.Text = lstproducts.FocusedItem.SubItems(4).Text
            txtQTYi.Text = lstproducts.FocusedItem.SubItems(5).Text
            txtQTY.Select()
            lstproducts.Visible = False
        ElseIf e.KeyCode = 8 Then
            txtsearch.Focus()
        End If
    End Sub

    Private Sub lstproducts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstproducts.MouseDoubleClick
        EnterX = True
        txtsearch.Text = lstproducts.FocusedItem.SubItems(1).Text
        txtdesc.Text = lstproducts.FocusedItem.SubItems(2).Text
        txtID.Text = lstproducts.FocusedItem.Text
        txtUnit.Text = lstproducts.FocusedItem.SubItems(3).Text
        txtUnitCost.Text = lstproducts.FocusedItem.SubItems(4).Text
        txtQTYi.Text = lstproducts.FocusedItem.SubItems(5).Text

        txtQTY.Focus()
        txtQTY.Select()

    End Sub

    Private Sub txtQTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQTY.TextChanged
        If txtQTY.Text = "" Then txtQTY.Text = 0 And txtQTY.Focus
        txtQTY.Text = str_Filter(txtQTY, 48, 57, 0, 0)
        If CDbl(txtQTY.Text) > CDbl(txtQTYi.Text) Then
            MsgBox("Order quantity should not be greater than current quantity !!" & _
                   Chr(13) & "Order Quantity : " & txtQTY.Text & _
                   Chr(13) & "Current Quantity : " & txtQTYi.Text, MsgBoxStyle.Information, "Sales and Inventory")
            txtQTY.Text = 0
            txtQTY.Focus()
            txtQTY.Select()
            cmdLoad.Enabled = False
        ElseIf CDbl(txtQTY.Text) > 0 Then
            cmdLoad.Enabled = True
        ElseIf CDbl(txtQTY.Text) = 0 Then
            cmdLoad.Enabled = False
        End If
        txtTotalAmount.Text = txtQTY.Text * txtUnitCost.Text
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Dim i, iTemp As Integer
        Dim bReplace As Boolean
        cmdLoad.Enabled = False
        For i = 0 To lstCurrentLoad.Items.Count - 1
            If lstCurrentLoad.Items(i).Text = txtID.Text Then
                If MsgBox("Item is already exist, do you want to replace this ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bReplace = True
                    iTemp = i
                End If
            End If
        Next
        With lstCurrentLoad
            If bReplace = False Then
                .Items.Add(txtID.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtsearch.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtdesc.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtUnit.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtUnitCost.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtQTY.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtTotalAmount.Text)
            Else
                '.Items(i).SubItems(4).Text = txtqty.Text + Iprev_Qty
                .Items(iTemp).SubItems(5).Text = txtQTY.Text
                .Items(iTemp).SubItems(6).Text = txtTotalAmount.Text
            End If
            txtID.Text = 0
            txtUnitCost.Text = 0
            txtQTYi.Text = 0
            txtQTY.Text = 0
            txtsearch.Text = ""
            txtdesc.Text = ""
            txtUnit.Text = ""
            txtsearch.Select()
        End With
    End Sub

    Private Sub lstproducts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstproducts.SelectedIndexChanged

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim total_product As Double
        Dim X, Y As Integer
        Dim STOCK As Boolean
        'Dim SQLStrx(0) As String
        Dim Stock_To_Delete(0) As String
        total_product = 0
        timx = 0
        counter = 0
        STOCK = False

        If lstCurrentLoad.Items.Count > 0 Then
            If Split(Me.Text, " - ")(1) = "Add" And add Then
                For i = 0 To lstCurrentLoad.Items.Count - 1
                    total_product += lstCurrentLoad.Items(i).SubItems(6).Text
                Next
                ' & "'" & Format(dtpurchase.Value, "MM/dd/yyyy") & "', " _

                sqlSTR = "INSERT INTO TBL_Orders (Order_Date, Product_Total) " & _
                         "VALUES ('" & Format(dtOrderDate.Value, "MM/dd/yyyy") & "', " _
                                     & total_product & ")"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT * FROM TBL_Orders ORDER BY Order_No DESC"
                ExecuteSQLQuery(sqlSTR)
                iOrder_no = sqlDT.Rows(0)("Order_No")

                For i = 0 To lstCurrentLoad.Items.Count - 1
                    sqlSTR = "INSERT INTO TBL_Orders_Detail (Order_No, Item_ID, Product_Name, Unit_Measure, Unit_Cost, QTY, TOTAL_COST) " & _
                             "VALUES (" & iOrder_no & ", " _
                                        & lstCurrentLoad.Items(i).Text & ", " _
                                        & "'" & R_eplace(lstCurrentLoad.Items(i).SubItems(1).Text) & "', " _
                                        & "'" & lstCurrentLoad.Items(i).SubItems(3).Text & "', " _
                                        & lstCurrentLoad.Items(i).SubItems(4).Text & ", " _
                                        & lstCurrentLoad.Items(i).SubItems(5).Text & ", " _
                                        & lstCurrentLoad.Items(i).SubItems(6).Text & ")"
                    ExecuteSQLQuery(sqlSTR)
                Next
                add = False

            Else
                'EDIT
                For i = 0 To lstCurrentLoad.Items.Count - 1
                    total_product += lstCurrentLoad.Items(i).SubItems(6).Text
                Next
                sqlSTR = "UPDATE TBL_Orders SET Order_Date ='" & Format(dtOrderDate.Value, "MM/dd/yyyy") & "', " _
                                           & "Product_Total =" & total_product _
                                           & " WHERE Order_No =" & iOrder_no 'txtorderno.Text
                'MsgBox("first")
                ExecuteSQLQuery(sqlSTR)


                'ADD NEW IF NOT EXIST IN THE LIST AND ITEMS ARE EDITED
                For i = 0 To lstCurrentLoad.Items.Count - 1
                    sqlSTR = "SELECT * FROM TBL_Orders_Detail WHERE Order_No =" & iOrder_no & _
                             " AND Item_ID =" & lstCurrentLoad.Items(i).Text
                    'MsgBox("second")
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count = 0 Then
                        sqlSTR = "INSERT INTO TBL_Orders_Detail (Order_No, Item_ID, Product_Name, Unit_Measure, Unit_Cost, QTY, TOTAL_COST) " & _
                                 "VALUES (" & iOrder_no & ", " _
                                            & lstCurrentLoad.Items(i).Text & ", " _
                                            & "'" & R_eplace(lstCurrentLoad.Items(i).SubItems(1).Text) & "', " _
                                            & "'" & lstCurrentLoad.Items(i).SubItems(3).Text & "', " _
                                            & lstCurrentLoad.Items(i).SubItems(4).Text & ", " _
                                            & lstCurrentLoad.Items(i).SubItems(5).Text & ", " _
                                            & lstCurrentLoad.Items(i).SubItems(6).Text & ")"
                        'MsgBox("Third")
                        ExecuteSQLQuery(sqlSTR)
                    Else 'EDIT MODE
                        sqlSTR = "UPDATE TBL_Orders_Detail SET QTY =" & lstCurrentLoad.Items(i).SubItems(5).Text & ", " _
                                                      & "TOTAL_COST =" & lstCurrentLoad.Items(i).SubItems(6).Text & _
                                                        " WHERE Order_No =" & txtorderno.Text & _
                                                        " AND Item_ID =" & lstCurrentLoad.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                    End If
                Next

                sqlSTR = "SELECT * FROM TBL_Orders_Detail WHERE Order_No =" & iOrder_no 'txtorderno.Text
                'MsgBox("Fourth")
                ExecuteSQLQuery(sqlSTR)
                'IF item is delete in the list but still exist in the database
                ' MsgBox(sqlDT.Rows.Count)
                For X = 0 To sqlDT.Rows.Count - 1
                    STOCK = False
                    For Y = 0 To lstCurrentLoad.Items.Count - 1
                        'MsgBox(sqlDT.Rows(X)("Item_ID") & " ---- " & lstCurrentLoad.Items(Y).Text)
                        If lstCurrentLoad.Items(Y).Text = sqlDT.Rows(X)("Item_ID") Then
                            STOCK = True
                        End If
                    Next
                    If Not STOCK Then
                        'MsgBox("here stocks")
                        ReDim Preserve Stock_To_Delete(counter)
                        'MsgBox("Five")
                        Stock_To_Delete(counter) = "DELETE FROM TBL_Orders_Detail WHERE Order_No =" & iOrder_no & " And Item_ID =" & sqlDT.Rows(X)("Item_ID")
                        counter += 1
                    End If
                Next

                'DELETE ALL THE UNECCESSARY RECORDS
                For X = 0 To UBound(Stock_To_Delete)
                    'MsgBox("Six")
                    If Len(Stock_To_Delete(X)) > 0 Then
                        ExecuteSQLQuery(Stock_To_Delete(X))
                    End If

                Next
            End If
        Else
            MsgBox("Can't continue saving without details !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        MsgBox("Record saved !!", MsgBoxStyle.Information, "Sales and Inventory")
        With FrmORDER_FORM
            sqlSTR = "SELECT Order_No AS 'Order No', Order_Date AS 'Order Date', Product_Total AS 'TOTAL COST' FROM TBL_Orders WHERE Order_Date ='" & Format(.dtOrder.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), .lstOrder, 0)
        End With
        If Split(Me.Text, " - ")(1) = "Add" Then
            Timer1.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Report As New FrmREPORTS
        timx = timx + 1
        If timx >= 2 Then
            ' Rpt_SqlStr = "SELECT * FROM TBL_Sales_Sold_Detail WHERE Sales_ID =" & xSales_ID & _
            '             "SELECT * FROM TBL_Globaldata"
            Timer1.Enabled = False
            globalFRM = "frmOrder_form_Data"
            Rpt_SqlStr = "SELECT * FROM TBL_Orders WHERE Order_No =" & iOrder_no
            Report.Show()
            'FrmREPORTS.Show()
            '--
            'mReport.Load(Application.StartupPath & "\ReportX\Receipt_Rpt.rpt")
            'mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
            'mReport.PrintToPrinter(1, True, 1, 1)


        End If
    End Sub

    Private Sub lstCurrentLoad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCurrentLoad.SelectedIndexChanged

    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If lstCurrentLoad.Items.Count > 0 Then
            lstCurrentLoad.Focus()
            lstCurrentLoad.Select()
            If MsgBox("Do you want to remove this data ???", MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
                lstCurrentLoad.FocusedItem.Remove()
            End If
        End If
    End Sub
End Class