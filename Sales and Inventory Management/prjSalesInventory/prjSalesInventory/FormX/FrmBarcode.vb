Public Class FrmBarcode

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub FrmBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
        sqlSTR = "SELECT Item_Barcode as 'Barcode', Item_Name as 'Name', Item_Description as 'Description / Item Number' FROM TBL_Category_Item_File"
        FillListView(ExecuteSQLQuery(sqlSTR), lstitem, 0)
        lstbarcode.Items.Clear()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If lstitem.Items.Count > 0 Then
            lstitem.Focus()
            lstbarcode.Items.Add(lstitem.FocusedItem.Text)
            lstbarcode.Items(lstbarcode.Items.Count - 1).SubItems.Add(lstitem.FocusedItem.SubItems(1).Text)
            lstbarcode.Items(lstbarcode.Items.Count - 1).SubItems.Add(lstitem.FocusedItem.SubItems(2).Text)
            lstitem.FocusedItem.Remove()
            lstitem.Refresh()
        End If
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        If lstbarcode.Items.Count > 0 Then
            lstbarcode.Focus()
            lstitem.Items.Add(lstitem.FocusedItem.Text)
            lstitem.Items(lstitem.Items.Count - 1).SubItems.Add(lstbarcode.FocusedItem.SubItems(1).Text)
            lstitem.Items(lstitem.Items.Count - 1).SubItems.Add(lstbarcode.FocusedItem.SubItems(2).Text)
            lstbarcode.FocusedItem.Remove()
            lstbarcode.Refresh()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'GroupBox1.Enabled = True
        cmdPrint.Enabled = False
        cmdcancel.Enabled = False
        GroupBox2.Visible = True
    End Sub

    Private Sub rbsingle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsingle.CheckedChanged
        txtpcs.Enabled = False
        Label3.Enabled = False
    End Sub

    Private Sub rbmultiple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmultiple.CheckedChanged
        txtpcs.Enabled = True
        Label3.Enabled = True
    End Sub

    Private Sub cmdcancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel2.Click
        cmdPrint.Enabled = True
        cmdcancel.Enabled = True
        GroupBox2.Visible = False
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Dim x, i As Integer
        Dim cnt As Integer
        Dim XHOLD As Integer
        Dim Report As New FrmREPORTS
        Dim holdI As Integer
        cnt = 0
        holdI = 0
        If lstbarcode.Items.Count > 0 Then
            sqlSTR = "DELETE FROM TBL_Barcode"
            ExecuteSQLQuery(sqlSTR)
            If rbsingle.Checked Then
                For x = 0 To lstbarcode.Items.Count - 1
                    cnt = cnt + 1
                    If cnt < 4 Then
                        If cnt = 1 Then
                            sqlSTR = "INSERT INTO TBL_Barcode (Barcode1) VALUES ('" & lstbarcode.Items(x).Text & "')"
                            ExecuteSQLQuery(sqlSTR)
                            sqlSTR = "SELECT * FROM TBL_Barcode ORDER BY ID DESC"
                            ExecuteSQLQuery(sqlSTR)
                            XHOLD = sqlDT.Rows(0)("ID")
                        ElseIf cnt = 2 Then
                            sqlSTR = "UPDATE TBL_Barcode SET Barcode2 ='" & lstbarcode.Items(x).Text & "' WHERE ID =" & XHOLD
                            ExecuteSQLQuery(sqlSTR)
                        ElseIf cnt = 3 Then
                            sqlSTR = "UPDATE TBL_Barcode SET Barcode3 ='" & lstbarcode.Items(x).Text & "' WHERE ID =" & XHOLD
                            ExecuteSQLQuery(sqlSTR)
                        End If
                    Else
                        cnt = 1
                        sqlSTR = "INSERT INTO TBL_Barcode (Barcode1) VALUES ('" & lstbarcode.Items(x).Text & "')"
                        ExecuteSQLQuery(sqlSTR)
                        sqlSTR = "SELECT * FROM TBL_Barcode ORDER BY ID DESC"
                        ExecuteSQLQuery(sqlSTR)
                        XHOLD = sqlDT.Rows(0)("ID")
                    End If
                Next
            ElseIf rbmultiple.Checked Then
                cnt = 1
                For x = 0 To lstbarcode.Items.Count - 1
                    For i = 0 To Int(txtpcs.Text) - 1
                        'MsgBox(i & " counter ")
                        If cnt = 1 Then
                            'MsgBox(" 1 " & lstbarcode.Items(x).Text)
                            sqlSTR = "INSERT INTO TBL_Barcode (Barcode1) VALUES ('" & lstbarcode.Items(x).Text & "')"
                            ExecuteSQLQuery(sqlSTR)
                            sqlSTR = "SELECT * FROM TBL_Barcode ORDER BY ID DESC"
                            ExecuteSQLQuery(sqlSTR)
                            XHOLD = sqlDT.Rows(0)("ID")

                        ElseIf cnt = 2 Then
                            'MsgBox(" 2 " & lstbarcode.Items(x).Text)
                            sqlSTR = "UPDATE TBL_Barcode SET Barcode2 ='" & lstbarcode.Items(x).Text & "' WHERE ID =" & XHOLD
                            ExecuteSQLQuery(sqlSTR)

                        ElseIf cnt = 3 Then
                            'MsgBox(" 3 " & lstbarcode.Items(x).Text)
                            sqlSTR = "UPDATE TBL_Barcode SET Barcode3 ='" & lstbarcode.Items(x).Text & "' WHERE ID =" & XHOLD
                            ExecuteSQLQuery(sqlSTR)
                            holdI = holdI + 1
                        Else
                            'MsgBox(" 4 " & lstbarcode.Items(x).Text)
                            'MsgBox(cnt & " cnt " & "  " & ((cnt - 1) / (holdI * 3)))
                            If ((cnt - 1) / (3)) = 1 Then
                                sqlSTR = "INSERT INTO TBL_Barcode (Barcode1) VALUES ('" & lstbarcode.Items(x).Text & "')"
                                ' MsgBox(lstbarcode.Items(x).Text)
                                ExecuteSQLQuery(sqlSTR)
                                sqlSTR = "SELECT * FROM TBL_Barcode ORDER BY ID DESC"
                                ExecuteSQLQuery(sqlSTR)
                                XHOLD = sqlDT.Rows(0)("ID")
                                cnt = 1
                            End If
                        End If
                        cnt = cnt + 1
                    Next
                Next
            End If
            
        End If
        cmdPrint.Enabled = True
        cmdcancel.Enabled = True
        GroupBox2.Visible = False
        globalFRM = "frmBarcode"
        Rpt_SqlStr = "SELECT * FROM TBL_Barcode "
        Report.Show()

    End Sub

    Private Sub txtpcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpcs.TextChanged
        txtpcs.Text = str_Filter(txtpcs, 48, 57, 0, 0)
        If txtpcs.Text = "0" Or Int(txtpcs.Text) = 0 Then
            MsgBox("No. of pcs per Barcode should not less than zero !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            cmdok.Enabled = False
        Else
            cmdok.Enabled = True
        End If
    End Sub
End Class