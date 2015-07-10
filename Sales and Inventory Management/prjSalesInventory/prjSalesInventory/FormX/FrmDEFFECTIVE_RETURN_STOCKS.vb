Public Class FrmDEFFECTIVE_RETURN_STOCKS

    Private Sub FrmDEFFECTIVE_RETURN_STOCKS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIDISABLED()
    End Sub

    Private Sub FrmDEFFECTIVE_STOCKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rbDeffect.Checked Then
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Pending_ID AS 'Pending ID' " & _
                     "FROM TBL_Deffective_PO " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY Def_PO_ID ASC"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
            For i = 0 To lstdeffect.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & lstdeffect.Items(i).Text & _
                         " AND Fully_Return='Yes'" & _
                         " ORDER BY Def_PO_ID ASC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    lstdeffect.Items(i).ForeColor = Color.Brown
                Else
                    lstdeffect.Items(i).ForeColor = Color.Black
                End If
            Next
        Else
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address' FROM TBL_Deffective_PO_Return " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
        End If
        Audit_Trail(xUser_ID, TimeOfDay, "View Deffective and Return Stocks")
    End Sub

    Private Sub dtreturn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtreturn.ValueChanged
        If rbDeffect.Checked Then
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase ID', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',','), Pending_ID AS 'Pending ID' FROM TBL_Deffective_PO " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
            For i = 0 To lstdeffect.Items.Count - 1
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & lstdeffect.Items(i).Text & _
                         " AND Fully_Return='Yes'" & _
                         " ORDER BY Def_PO_ID ASC"

                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    lstdeffect.Items(i).ForeColor = Color.Brown
                Else
                    lstdeffect.Items(i).ForeColor = Color.Black
                End If
            Next
        ElseIf rbReturn.Checked Then
            'x123
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Fully_Return AS 'Return' FROM TBL_Deffective_PO_Return " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
            For i = 0 To lstdeffect.Items.Count - 1
                'MsgBox(.lstdeffect.Items(i).SubItems(5).Text)
                If lstdeffect.Items(i).SubItems(5).Text = "Yes" Then
                    lstdeffect.Items(i).ForeColor = Color.Brown
                Else
                    lstdeffect.Items(i).ForeColor = Color.Black
                End If
            Next
        ElseIf rbpending.Checked Then
            sqlSTR = "SELECT Pending_ID as 'Pending ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Replace(Replace(Item_Description,'$.$',''''),'$..$',',') as 'Description / Item Number',Pending_Date as 'Date', Item_QTY as 'Quantity', Receipt_ID AS 'Receipt No' " & _
                     "FROM TBL_Pending_Item " & _
                     "INNER JOIN TBL_Category_Item_File ON TBL_Pending_Item.Item_ID = TBL_Category_Item_File.Item_ID " & _
                     "WHERE Returnx = 'No' AND Pending_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
            For x = 0 To lstdeffect.Items.Count - 1
                'MsgBox(lstdeffect.Items(x).Text)
                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details " & _
                         "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO_Details.DEF_PO_ID = TBL_Deffective_PO_Return.DEF_PO_ID " & _
                         "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Return_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                         "WHERE TBL_Deffective_PO_Details.Pending_ID =" & lstdeffect.Items(x).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    lstdeffect.Items(x).ForeColor = Color.Brown
                Else
                    lstdeffect.Items(x).ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Private Sub rbDeffect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDeffect.CheckedChanged
        If rbDeffect.Checked Then
            With MDIMain
                .cmdNew.Enabled = True
                .cmdEdit.Enabled = True
                .cmdPrint.Enabled = True
                .cmdSearch.Enabled = True
                '.ToolStripNew.Enabled = True
                '.ToolStripEdit.Enabled = True
                '.ToolStripPrint.Enabled = True
                '.ToolStripSearch.Enabled = True
                'sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Pending_ID AS 'Pending ID' FROM TBL_Deffective_PO " & _
                '         "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY Def_PO_ID ASC"


                sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Pending_ID AS 'Pending ID' " & _
                         "FROM TBL_Deffective_PO " & _
                         "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY Def_PO_ID ASC"
                FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)

                For i = 0 To lstdeffect.Items.Count - 1
                    sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return WHERE Def_PO_ID =" & lstdeffect.Items(i).Text & _
                             " AND Fully_Return='Yes'" & _
                             " ORDER BY Def_PO_ID ASC"

                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        lstdeffect.Items(i).ForeColor = Color.Brown
                    Else
                        lstdeffect.Items(i).ForeColor = Color.Black
                    End If
                Next
                ' sqlSTR = "SELECT TBL_Deffective_PO.def_po_id AS 'DEF_ID', *, *, * " & _
                '          "FROM TBL_Deffective_PO " & _
                '          "INNER JOIN TBL_Deffective_PO_Details ON TBL_Deffective_PO.Def_PO_ID = TBL_Deffective_PO_Details.Def_PO_ID " & _
                '          "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO.Def_PO_ID = TBL_Deffective_PO_Return.Def_PO_ID " & _
                '          "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                '          "WHERE TBL_Deffective_PO.Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & _
                '          "' ORDER BY TBL_Deffective_PO.Def_PO_ID ASC"

                ' ExecuteSQLQuery(sqlSTR)

                '                If sqlDT.Rows.Count > 0 Then
                ' For x = 0 To sqlDT.Rows.Count - 1
                ' If CDbl(sqlDT.Rows(x)("Def_QTY")) = CDbl(sqlDT.Rows(x)("Return_QTY")) Then
                ' 'lstdeffect.Items(x).ForeColor = Color.Brown
                ' Else
                ' 'lstdeffect.Items(x).ForeColor = Color.DarkBlue
                ' End If
                ' Next
                'End If

            End With
        End If
        
    End Sub

    Private Sub rbReturn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReturn.CheckedChanged
        If rbReturn.Checked Then
            With MDIMain
                .cmdNew.Enabled = True
                .cmdEdit.Enabled = True
                .cmdPrint.Enabled = True
                .cmdSearch.Enabled = True
                '.ToolStripNew.Enabled = True
                '.ToolStripEdit.Enabled = True
                '.ToolStripPrint.Enabled = True
                '.ToolStripSearch.Enabled = True
                sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase No', Replace(Replace(SupplierName,'$.$',''''),'$..$',',') as 'Supplier Name', Replace(Replace(Delivery_Term,'$.$',''''),'$..$',',') as 'Delivery Term', Replace(Replace(Address,'$.$',''''),'$..$',',') AS 'Address', Fully_Return AS 'Return' FROM TBL_Deffective_PO_Return " & _
                         "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
                FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
                For i = 0 To lstdeffect.Items.Count - 1
                    'MsgBox(.lstdeffect.Items(i).SubItems(5).Text)
                    If lstdeffect.Items(i).SubItems(5).Text = "Yes" Then
                        lstdeffect.Items(i).ForeColor = Color.Brown
                    Else
                        lstdeffect.Items(i).ForeColor = Color.Black
                    End If
                Next
                'sqlSTR = "SELECT * FROM TBL_Deffective_PO_Return " & _
                '         "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' ORDER BY DEF_PO_ID ASC"
                'ExecuteSQLQuery(sqlSTR)
                'For i = 0 To sqlDT.Rows.Count - 1
                ' 'MsgBox(sqlDT.Rows(i)("Fully_Return"))
                ' If CDbl(sqlDT.Rows(i)("Fully_Return")) > 0 Then
                ' lstdeffect.Items(i).BackColor = Color.Brown
                ' Else
                ' lstdeffect.Items(i).BackColor = Color.Black
                ' End If
                'Next
            End With
        End If
    End Sub

    Private Sub rbpending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpending.CheckedChanged
        Dim xGo As Boolean
        If rbpending.Checked Then
            With MDIMain
                .cmdPrint.Enabled = False
                .cmdSearch.Enabled = False
                .cmdEdit.Enabled = False
                .cmdNew.Enabled = False
                '.ToolStripPrint.Enabled = False
                '.ToolStripSearch.Enabled = False
                '.ToolStripEdit.Enabled = False
                '.ToolStripNew.Enabled = False
            End With
            sqlSTR = "SELECT Pending_ID as 'Pending ID', Replace(Replace(Item_Name,'$.$',''''),'$..$',',') as 'Name', Replace(Replace(Item_Description,'$.$',''''),'$..$',',') as 'Description / Item Number',Pending_Date as 'Date', Item_QTY as 'Quantity', Receipt_ID AS 'Receipt No' " & _
                      "FROM TBL_Pending_Item " & _
                      "INNER JOIN TBL_Category_Item_File ON TBL_Pending_Item.Item_ID = TBL_Category_Item_File.Item_ID " & _
                      "WHERE Returnx = 'No' AND Pending_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
            For x = 0 To lstdeffect.Items.Count - 1

                sqlSTR = "SELECT * FROM TBL_Deffective_PO_Details " & _
                         "INNER JOIN TBL_Deffective_PO_Return ON TBL_Deffective_PO_Details.DEF_PO_ID = TBL_Deffective_PO_Return.DEF_PO_ID " & _
                         "INNER JOIN TBL_Deffective_PO_Return_Details ON TBL_Deffective_PO_Return.Return_ID = TBL_Deffective_PO_Return_Details.Return_ID " & _
                         "INNER JOIN TBL_Category_Item_File ON TBL_Deffective_PO_Return_Details.Item_ID = TBL_Category_Item_File.Item_ID " & _
                         "WHERE TBL_Deffective_PO_Details.Pending_ID =" & lstdeffect.Items(x).Text
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    For i = 0 To sqlDT.Rows.Count - 1
                        'MsgBox(sqlDT.Rows(i)("DEF_QTY") & "  " & sqlDT.Rows(i)("Return_QTY"))
                        If CDbl(sqlDT.Rows(i)("Def_QTY")) = CDbl(sqlDT.Rows(i)("Return_QTY")) Then
                            lstdeffect.Items(x).ForeColor = Color.Brown
                        Else
                            xGo = True
                            lstdeffect.Items(x).ForeColor = Color.DarkBlue
                        End If
                    Next
                Else
                    If Not xGo Then
                        sqlSTR = "SELECT * FROM TBL_Deffective_PO WHERE Pending_ID =" & lstdeffect.Items(x).Text
                        ExecuteSQLQuery(sqlSTR)
                        If sqlDT.Rows.Count > 0 Then
                            lstdeffect.Items(x).ForeColor = Color.YellowGreen
                        Else
                            lstdeffect.Items(x).ForeColor = Color.Black
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpCat.Visible = False
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        If rbDeffect.Checked Then
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase ID', SupplierName as 'Supplier Name', Delivery_Term as 'Delivery Term', Address FROM TBL_Deffective_PO " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' AND SupplierName LIKE '%" & txtname.Text & "%'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
        Else
            sqlSTR = "SELECT DEF_PO_ID AS 'Defective ID', Purchase_ID as 'Purchase ID', SupplierName as 'Supplier Name', Delivery_Term as 'Delivery Term', Address FROM TBL_Deffective_PO_Return " & _
                     "WHERE Return_Date ='" & Format(dtreturn.Value, "MM/dd/yyyy") & "' AND SupplierName LIKE '%" & txtname.Text & "%'"
            FillListView(ExecuteSQLQuery(sqlSTR), lstdeffect, 0)
        End If
        grpCat.Visible = False
    End Sub

    Private Sub FrmDEFFECTIVE_RETURN_STOCKS_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 60
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 45)
            .lstdeffect.Width = GroupBox1.Width - 10
            .lstdeffect.Height = GroupBox1.Height - 45

            .rbReturn.Left = (GroupBox1.Width - .rbReturn.Width) - 2
            .rbDeffect.Left = (.rbReturn.Left - .rbDeffect.Width) - 4
            .rbpending.Left = (.rbDeffect.Left - .rbpending.Width) - 4

            .dtreturn.Left = (.rbpending.Left - .dtreturn.Width) - 18
            .Label3.Left = (.dtreturn.Left - .Label3.Width) - 4

        End With
    End Sub
End Class