Public Class FrmPHYSICALCOUNT_ADD
    Dim enterX As Boolean
    Dim Physical_ID As Integer

    Private Sub FrmPHYSICALCOUNT_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Physical Details"
    End Sub

    Private Sub FrmPHYSICALCOUNT_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        lstcur_stocks.Visible = False
        lstphysical.Items.Clear()
        txtqtyi.Text = 0
        txtID.Text = 0
        txtqty.Text = 0
        txtproductname.Text = ""
        txtdesc.Text = ""
        txtproductname.Select()
        txtverified.Text = _USER.Value
        cmdaddphysical.Enabled = False

        lstphysical.Items.Clear()
        If Split(Me.Text, " - ")(1) = "Edit" Then
            Physical_ID = globalID
            sqlSTR = "SELECT * , * " & _
                     "FROM TBL_Physical_Count_Details " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Physical_Count_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                     "WHERE P_ID =" & Physical_ID
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                With lstphysical
                    For x = 0 To sqlDT.Rows.Count - 1
                        .Items.Add(sqlDT.Rows(x)("Item_ID"))
                        .Items(.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(x)("Item_Name")))
                        .Items(.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(x)("Item_Description")))
                        .Items(.Items.Count - 1).SubItems.Add(R_Change(sqlDT.Rows(x)("P_REMARKS")))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(x)("P_Counts"))
                        .Items(.Items.Count - 1).SubItems.Add(sqlDT.Rows(x)("Total_QTY"))
                    Next
                End With
            End If
        End If
    End Sub

    Private Sub txtproductname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtproductname.KeyDown
        If e.KeyCode = 40 And lstcur_stocks.Items.Count > 0 Then
            lstcur_stocks.Focus()
            lstcur_stocks.Items(0).Selected = True
        End If
    End Sub


    Private Sub txtproductname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproductname.TextChanged
        If Len(txtproductname.Text) > 0 And Not enterX Then
            lstcur_stocks.Items.Clear()
            lstcur_stocks.Top = (txtproductname.Top + txtproductname.Height)
            lstcur_stocks.Left = txtproductname.Left


            sqlSTR = "SELECT TBL_category_item_file.item_id AS 'ID', TBL_Category_Item_File.Item_Name as 'Name',  TBL_Category_Item_File.Item_Description AS 'Description', TBL_Category_Item_File.Unit_Measure, TBL_Category_Item_File.Item_Price, TBL_Stocks_Balances.Item_QTY " & _
                     "FROM TBL_category_item_file INNER JOIN TBL_Stocks_Balances ON TBL_Category_Item_File.Item_ID = TBL_Stocks_Balances.Item_ID " & _
                     "WHERE LEFT(TBL_Category_Item_File.Item_Name," & Len(R_eplace(txtproductname.Text)) & ") ='" & R_eplace(txtproductname.Text) & "'" _
                     & "ORDER BY TBL_Category_Item_File.Item_name"
            ExecuteSQLQuery(sqlSTR)
            '---
            For x = 0 To sqlDT.Rows.Count - 1
                '   lstItems.Items.Add(sqlDT.Rows(i)("Item_ID"))
                '   lstItems.Items((lstItems.Items.Count - 1)).SubItems.Add(sqlDT.Rows(i)("Item_Name"))
                lstcur_stocks.Items.Add(sqlDT.Rows(x)("ID"))
                lstcur_stocks.Items((lstcur_stocks.Items.Count - 1)).SubItems.Add(R_Change(sqlDT.Rows(x)("Name")))
                lstcur_stocks.Items((lstcur_stocks.Items.Count - 1)).SubItems.Add(sqlDT.Rows(x)("Description"))
                lstcur_stocks.Items((lstcur_stocks.Items.Count - 1)).SubItems.Add(sqlDT.Rows(x)("Item_QTY"))
            Next
            lstcur_stocks.Visible = True
            '---
            enterX = False
        Else
            lstcur_stocks.Visible = False
            enterX = False
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub lstcur_stocks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstcur_stocks.KeyDown
        If e.KeyCode = 13 Then
            enterX = True
            txtID.Text = lstcur_stocks.FocusedItem.Text
            txtproductname.Text = lstcur_stocks.FocusedItem.SubItems(1).Text
            txtdesc.Text = lstcur_stocks.FocusedItem.SubItems(2).Text
            txtqtyi.Text = lstcur_stocks.FocusedItem.SubItems(3).Text
            lstcur_stocks.Visible = False
            txtqty.Focus()
        ElseIf e.KeyCode = 8 Then
            enterX = False
            txtID.Text = 0
            txtqtyi.Text = 0
            txtproductname.Focus()
            lstcur_stocks.Visible = False
        End If
    End Sub

    Private Sub lstcur_stocks_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstcur_stocks.MouseDoubleClick
        enterX = True
        lstcur_stocks.Visible = False
        txtID.Text = lstcur_stocks.FocusedItem.Text
        txtproductname.Text = lstcur_stocks.FocusedItem.SubItems(1).Text
        txtdesc.Text = lstcur_stocks.FocusedItem.SubItems(2).Text
        txtqty.Text = lstcur_stocks.FocusedItem.SubItems(3).Text

    End Sub

    Private Sub lstcur_stocks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcur_stocks.SelectedIndexChanged

    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If txtqty.Text = "" Then txtqty.Text = 0 And txtqty.Focus
        txtqty.Text = str_Filter(txtqty, 48, 57, 0, 0)
        If CDbl(txtqty.Text) > CDbl(txtqtyi.Text) Then
            MsgBox("Physical quantity should not be greater than current quantity !!" & _
                   Chr(13) & "Physical Quantity : " & txtqty.Text & _
                   Chr(13) & "Current Quantity : " & txtqtyi.Text, MsgBoxStyle.Information, "Sales and Inventory")

            txtqty.Text = 0
            txtqty.Focus()

            cmdaddphysical.Enabled = False
        ElseIf CDbl(txtqty.Text) < CDbl(txtqtyi.Text) Then
            txtremarks.Text = "Missing " & CDbl(txtqtyi.Text) - CDbl(txtqty.Text) & " item(s)"
            cmdaddphysical.Enabled = True
            If CDbl(txtqty.Text) = 0 Then
                cmdaddphysical.Enabled = False
            End If
        ElseIf CDbl(txtqty.Text) = CDbl(txtqtyi.Text) Then
            txtremarks.Text = ""
            If CDbl(txtqty.Text) > 0 Then
                cmdaddphysical.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdaddphysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddphysical.Click
        Dim i, iTemp As Integer
        Dim bReplace As Boolean
        cmdaddphysical.Enabled = False
        For i = 0 To lstphysical.Items.Count - 1
            If lstphysical.Items(i).Text = txtID.Text Then
                If MsgBox("Item is already exist, do you want to replace this ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bReplace = True
                    iTemp = i
                End If
            End If
        Next

        With lstphysical
            If bReplace = False Then
                .Items.Add(txtID.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtproductname.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtdesc.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtremarks.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtqty.Text)
                .Items(.Items.Count - 1).SubItems.Add(txtqtyi.Text)
            Else
                .Items(iTemp).SubItems(3).Text = txtremarks.Text
                .Items(iTemp).SubItems(4).Text = txtqty.Text
            End If

            txtID.Text = 0
            txtqtyi.Text = 0
            txtqty.Text = 0
            txtdesc.Text = ""
            txtproductname.Text = ""
            txtproductname.Select()
        End With
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim x, y, Counter As Integer
        Dim STOCK As Boolean
        'Dim SQLStrx(0) As String
        Dim Physical_to_Delete(0) As String
        STOCK = False
        If lstphysical.Items.Count > 0 Then
            If Split(Me.Text, " - ")(1) = "Add" Then


                sqlSTR = "INSERT INTO TBL_Physical_Count (p_Date, User_ID) VALUES ('" & Format(dtphysical.Value, "MM/dd/yyyy") & "', " & xUser_ID & ")"
                ExecuteSQLQuery(sqlSTR)
                sqlSTR = "SELECT * FROM TBL_Physical_Count ORDER BY P_ID DESC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    Physical_ID = sqlDT.Rows(0)("P_ID")
                End If

                'ADD NEW ITEMS
                For x = 0 To lstphysical.Items.Count - 1
                    sqlSTR = "INSERT INTO TBL_Physical_Count_Details (P_ID, Item_ID, P_Counts, P_Remarks, Total_QTY) " & _
                             "VALUES(" & Physical_ID & ", " & _
                                         lstphysical.Items(x).Text & ", " & _
                                         lstphysical.Items(x).SubItems(4).Text & ", '" & _
                                         lstphysical.Items(x).SubItems(3).Text & "', " & _
                                         lstphysical.Items(x).SubItems(5).Text & ")"
                    ExecuteSQLQuery(sqlSTR)
                Next
                Audit_Trail(xUser_ID, TimeOfDay, "Add New Physical Count")
            Else ' EDIT
                '---
                sqlSTR = "UPDATE TBL_Physical_Count SET p_Date ='" & Format(dtphysical.Value, "MM/dd/yyyy") & "', " _
                                           & "User_ID =" & xUser_ID
                ExecuteSQLQuery(sqlSTR)

                'ADD NEW IF NOT EXIST IN THE LIST AND ITEMS ARE EDITED
                For i = 0 To lstphysical.Items.Count - 1
                    sqlSTR = "SELECT * FROM TBL_Physical_Count_Details WHERE P_ID =" & Physical_ID & _
                             " AND Item_ID =" & lstphysical.Items(i).Text
                    'MsgBox("second")
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count = 0 Then
                        sqlSTR = "INSERT INTO TBL_Physical_Count_Details (P_ID, Item_ID, P_Counts, P_Remarks, TOtal_QTY) " & _
                                 "VALUES(" & Physical_ID & ", " & lstphysical.Items(i).Text & ", " & _
                                             lstphysical.Items(i).SubItems(4).Text & ", '" & _
                                             lstphysical.Items(i).SubItems(3).Text & "', " & _
                                             lstphysical.Items(i).SubItems(5).Text & ")"
                        'MsgBox("Third")
                        ExecuteSQLQuery(sqlSTR)
                    Else 'EDIT MODE
                        sqlSTR = "UPDATE TBL_Physical_Count_Details SET P_Counts =" & lstphysical.Items(i).SubItems(4).Text & ", " _
                                                      & "P_Remarks='" & lstphysical.Items(i).SubItems(3).Text & "'" & _
                                                        " WHERE P_ID =" & Physical_ID & _
                                                        " AND Item_ID =" & lstphysical.Items(i).Text
                        ExecuteSQLQuery(sqlSTR)
                    End If
                Next

                '----
                sqlSTR = "SELECT * FROM TBL_Physical_Count_Details WHERE P_ID =" & Physical_ID 'txtorderno.Text
                'MsgBox("Fourth")
                ExecuteSQLQuery(sqlSTR)
                'IF item is delete in the list but still exist in the database
                ' MsgBox(sqlDT.Rows.Count)
                For x = 0 To sqlDT.Rows.Count - 1
                    STOCK = False
                    For Y = 0 To lstphysical.Items.Count - 1
                        'MsgBox(sqlDT.Rows(X)("Item_ID") & " ---- " & lstCurrentLoad.Items(Y).Text)
                        If lstphysical.Items(Y).Text = sqlDT.Rows(x)("Item_ID") Then
                            STOCK = True
                        End If
                    Next
                    If Not STOCK Then
                        'MsgBox("here stocks")
                        ReDim Preserve Physical_to_Delete(counter)
                        'MsgBox("Five")
                        Physical_to_Delete(Counter) = "DELETE FROM TBL_Physical_Count_Details WHERE P_ID =" & Physical_ID & " AND Item_ID =" & sqlDT.Rows(x)("Item_ID")
                        counter += 1
                    End If
                Next

                'DELETE ALL THE UNECCESSARY RECORDS
                For x = 0 To UBound(Physical_to_Delete)
                    'MsgBox("Six")
                    If Len(Physical_to_Delete(x)) > 0 Then
                        ExecuteSQLQuery(Physical_to_Delete(x))
                    End If

                Next
                '----
                Audit_Trail(xUser_ID, TimeOfDay, "Edit Physical Count")
            End If
        Else
            MsgBox("Can't continue saving without details !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If

        With FrmPhysicalCount
            sqlSTR = "SELECT P_ID AS 'P_ID', P_Date as 'DATE', Lastname + ', ' + Firstname + ' ' + Middlename AS ' Username' " & _
                             "FROM TBL_Physical_Count " & _
                             "INNER JOIN TBL_Users ON TBL_Physical_Count.User_ID = TBL_Users.User_ID " & _
                             " WHERE P_Date >='" & Format(.dtfrom.Value, "MM/dd/yyyy") & "' AND P_Date <='" & Format(.dtto.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), .lstphysical, 0)
        End With
        MsgBox("Record saved !!", MsgBoxStyle.Information, "Sales and Inventory")
        Me.Close()
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        If lstphysical.Items.Count > 0 Then
            lstphysical.Focus()
            lstphysical.Select()
            If MsgBox("Do you want to remove this data ???", MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
                lstphysical.FocusedItem.Remove()
            End If
        End If
    End Sub
End Class