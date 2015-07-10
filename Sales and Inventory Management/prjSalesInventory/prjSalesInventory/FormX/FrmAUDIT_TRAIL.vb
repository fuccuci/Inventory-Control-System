Public Class FrmAUDIT_TRAIL

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmAUDIT_TRAIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FILLComboBox("SELECT User_ID, UserName FROM TBL_Users", cmbusers)
        sqlSTR = "select * from tbl_users"

        ExecuteSQLQuery(sqlSTR)
        lstaudit.Items.Clear()
        LP1.Enabled = False
        LP2.Enabled = False
        LP3.Enabled = False
        LP4.Enabled = False
        LP5.Enabled = False
        LP6.Enabled = False
        LP7.Enabled = False
        LP8.Enabled = False
        LP9.Enabled = False
        LP10.Enabled = False
        picPrevious.Enabled = False
        PicNext.Enabled = False
        If sqlDT.Rows.Count > 0 Then
            cmbusers.SelectedItem = sqlDT.Rows(0)("User_ID") & " - " & sqlDT.Rows(0)("UserName")
        End If

    End Sub

    Private Sub cmbusers_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbusers.TextChanged
        'Dim i As Integer

        sqlSTR = "SELECT Action, Date, Timex , LOGIN, LOGOUT " & _
                 "FROM (TBL_Audit_Trail " & _
                 "INNER JOIN TBL_Audit_Log ON TBL_Audit_Trail.User_ID = TBL_Audit_Log.User_ID " & _
                 " AND TBL_Audit_Trail.Log_ID = TBL_Audit_Log.Log_ID) " & _
                 "WHERE TBL_Audit_Trail.User_ID =" & Split(cmbusers.Text, " - ")(0) & _
                 " AND Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"

        ExecuteSQLQuery(sqlSTR)
        'Page_Rendered(sqlDT.Rows.Count)
        'If sqlDT.Rows.Count > 0 Then
        ' LP1_LinkClicked(0, AcceptButton)
        ' End If
        lstaudit.Items.Clear()
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstaudit.Items.Add(sqlDT.Rows(i)("Action"), 0)
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Date"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Timex"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGIN"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGOUT"))
                '

            Next
        End If
    End Sub

    Private Sub dtfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfrom.ValueChanged
        If Split(cmbusers.Text, " - ")(0) = "" Then
            MsgBox("Select Username First", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        '   sqlSTR = "SELECT * FROM TBL_Audit_Trail WHERE User_ID =" & Split(cmbusers.Text, " - ")(0) & _
        '           " AND Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"

        sqlSTR = "SELECT Action, Date, Timex , LOGIN, LOGOUT " & _
                 "FROM (TBL_Audit_Trail " & _
                 "INNER JOIN TBL_Audit_Log ON TBL_Audit_Trail.User_ID = TBL_Audit_Log.User_ID " & _
                 " AND TBL_Audit_Trail.Log_ID = TBL_Audit_Log.Log_ID) " & _
                 "WHERE TBL_Audit_Trail.User_ID =" & Split(cmbusers.Text, " - ")(0) & _
                 " AND Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"
        ExecuteSQLQuery(sqlSTR)
        lstaudit.Items.Clear()
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstaudit.Items.Add(sqlDT.Rows(i)("Action"), 0)
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Date"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Timex"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGIN"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGOUT"))
            Next
        End If
    End Sub

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged
        If Split(cmbusers.Text, " - ")(0) = "" Then
            MsgBox("Select Username First", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        'sqlSTR = "SELECT * FROM TBL_Audit_Trail WHERE User_ID =" & Split(cmbusers.Text, " - ")(0) & _
        ' " AND Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"

        sqlSTR = "SELECT Action, Date, Timex , LOGIN, LOGOUT " & _
                 "FROM (TBL_Audit_Trail " & _
                 "INNER JOIN TBL_Audit_Log ON TBL_Audit_Trail.User_ID = TBL_Audit_Log.User_ID " & _
                 " AND TBL_Audit_Trail.Log_ID = TBL_Audit_Log.Log_ID) " & _
                 "WHERE TBL_Audit_Trail.User_ID =" & Split(cmbusers.Text, " - ")(0) & _
                 " AND Date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Date <='" & Format(dtto.Value, "MM/dd/yyyy") & "' ORDER BY Audit_ID"

        ExecuteSQLQuery(sqlSTR)
        lstaudit.Items.Clear()
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstaudit.Items.Add(sqlDT.Rows(i)("Action"), 0)
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Date"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Timex"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGIN"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGOUT"))
            Next
        End If
    End Sub

    Private Sub FrmAUDIT_TRAIL_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Me
            GroupBox1.Width = (.Width - (MDIMain.TSHoldRight.Width / 2)) + 62
            GroupBox1.Height = .Height - (MDIMain.TSHoldAdvisory.Height + 52)
            .lstaudit.Width = GroupBox1.Width - 10
            .lstaudit.Height = GroupBox1.Height - 58
        End With
    End Sub

    Private Sub LP1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP1.LinkClicked

        LP1.LinkVisited = True
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
        If Nextpage > 0 Then

        Else
            sqlSTR = "Select * from(select row_number() over(order by Audit_ID) as row_numbers, " & _
                         "* from SaleInv_DB.dbo.TBL_Audit_Trail ) Tax " & _
                         "inner join SaleInv_DB.dbo.TBL_Audit_Log on " & _
                         "tax.User_ID = SaleInv_DB.dbo.TBL_Audit_Log.User_ID " & _
                         "and Tax.Log_ID = SaleInv_DB.dbo.TBL_Audit_Log.Log_ID " & _
                         "where tax.date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Tax.Date <='" & Format(dtto.Value, "MM/dd/yyyy") & _
                         "' AND row_numbers between 1 and 200"
            ExecuteSQLQuery(sqlSTR)
        End If
        'p_List()
    End Sub

    Private Sub LP2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP2.LinkClicked

        LP1.LinkVisited = False
        LP2.LinkVisited = True
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
        If NextPage > 0 Then

        Else
            sqlSTR = "Select * from(select row_number() over(order by Audit_ID) as row_numbers, " & _
                     "* from SaleInv_DB.dbo.TBL_Audit_Trail ) Tax " & _
                     "inner join SaleInv_DB.dbo.TBL_Audit_Log on " & _
                     "tax.User_ID = SaleInv_DB.dbo.TBL_Audit_Log.User_ID " & _
                     "and Tax.Log_ID = SaleInv_DB.dbo.TBL_Audit_Log.Log_ID " & _
                     "where tax.date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Tax.Date <='" & Format(dtto.Value, "MM/dd/yyyy") & _
                     "' AND row_numbers between 200 and 400"
            ExecuteSQLQuery(sqlSTR)
        End If
        'p_List()
    End Sub

    Private Sub LP3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP3.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = True
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
        If NextPage > 0 Then

        Else
            sqlSTR = "Select * from(select row_number() over(order by Audit_ID) as row_numbers, " & _
                     "* from SaleInv_DB.dbo.TBL_Audit_Trail ) Tax " & _
                     "inner join SaleInv_DB.dbo.TBL_Audit_Log on " & _
                     "tax.User_ID = SaleInv_DB.dbo.TBL_Audit_Log.User_ID " & _
                     "and Tax.Log_ID = SaleInv_DB.dbo.TBL_Audit_Log.Log_ID " & _
                     "where tax.date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Tax.Date <='" & Format(dtto.Value, "MM/dd/yyyy") & _
                     "' AND row_numbers between 400 and 600"
            ExecuteSQLQuery(sqlSTR)
        End If
        ' p_List()
    End Sub

    Private Sub LP4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP4.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = True
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
        If NextPage > 0 Then

        Else
            sqlSTR = "Select * from(select row_number() over(order by Audit_ID) as row_numbers, " & _
                     "* from SaleInv_DB.dbo.TBL_Audit_Trail ) Tax " & _
                     "inner join SaleInv_DB.dbo.TBL_Audit_Log on " & _
                     "tax.User_ID = SaleInv_DB.dbo.TBL_Audit_Log.User_ID " & _
                     "and Tax.Log_ID = SaleInv_DB.dbo.TBL_Audit_Log.Log_ID " & _
                     "where tax.date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Tax.Date <='" & Format(dtto.Value, "MM/dd/yyyy") & _
                     "' AND row_numbers between 600 and 800"
            ExecuteSQLQuery(sqlSTR)
        End If
        ' p_List()
    End Sub

    Private Sub LP5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP5.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = True
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
        If NextPage > 0 Then

        Else
            sqlSTR = "Select * from(select row_number() over(order by Audit_ID) as row_numbers, " & _
                     "* from SaleInv_DB.dbo.TBL_Audit_Trail ) Tax " & _
                     "inner join SaleInv_DB.dbo.TBL_Audit_Log on " & _
                     "tax.User_ID = SaleInv_DB.dbo.TBL_Audit_Log.User_ID " & _
                     "and Tax.Log_ID = SaleInv_DB.dbo.TBL_Audit_Log.Log_ID " & _
                     "where tax.date >='" & Format(dtfrom.Value, "MM/dd/yyyy") & "' AND Tax.Date <='" & Format(dtto.Value, "MM/dd/yyyy") & _
                     "' AND row_numbers between 800 and 1000"
            ExecuteSQLQuery(sqlSTR)
        End If
        'p_List()
    End Sub

    Private Sub LP6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP6.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = True
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
    End Sub

    Private Sub LP7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP7.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = True
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = False
    End Sub

    Private Sub LP8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP8.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = True
        LP9.LinkVisited = False
        LP10.LinkVisited = False
    End Sub

    Private Sub LP9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP9.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = True
        LP10.LinkVisited = False
    End Sub

    Private Sub LP10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LP10.LinkClicked
        LP1.LinkVisited = False
        LP2.LinkVisited = False
        LP3.LinkVisited = False
        LP4.LinkVisited = False
        LP5.LinkVisited = False
        LP6.LinkVisited = False
        LP7.LinkVisited = False
        LP8.LinkVisited = False
        LP9.LinkVisited = False
        LP10.LinkVisited = True
    End Sub
    Private Sub Page_Rendered(ByVal N_Records As Double)
        For LoopX = 1 To 11
            If LoopX = 1 Then
                If N_Records > 0 And N_Records <= 200 Then
                    LP1.Enabled = True
                    LP2.Enabled = False
                    LP3.Enabled = False
                    LP4.Enabled = False
                    LP5.Enabled = False
                    LP6.Enabled = False
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 2 Then
                If N_Records > 200 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = False
                    LP4.Enabled = False
                    LP5.Enabled = False
                    LP6.Enabled = False
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 3 Then
                If N_Records > 400 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = False
                    LP5.Enabled = False
                    LP6.Enabled = False
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 4 Then
                If N_Records > 600 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = False
                    LP6.Enabled = False
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 5 Then
                If N_Records > 800 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = False
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 6 Then
                If N_Records > 1000 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = True
                    LP7.Enabled = False
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 7 Then
                If N_Records > 1200 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = True
                    LP7.Enabled = True
                    LP8.Enabled = False
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 8 Then
                If N_Records > 1400 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = True
                    LP7.Enabled = True
                    LP8.Enabled = True
                    LP9.Enabled = False
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 9 Then
                If N_Records > 1600 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = True
                    LP7.Enabled = True
                    LP8.Enabled = True
                    LP9.Enabled = True
                    LP10.Enabled = False
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 10 Then
                If N_Records > 1800 And N_Records <= (LoopX * 200) Then
                    LP1.Enabled = True
                    LP2.Enabled = True
                    LP3.Enabled = True
                    LP4.Enabled = True
                    LP5.Enabled = True
                    LP6.Enabled = True
                    LP7.Enabled = True
                    LP8.Enabled = True
                    LP9.Enabled = True
                    LP10.Enabled = True
                    picPrevious.Enabled = False
                    PicNext.Enabled = False
                End If
            ElseIf LoopX = 11 Then
                If N_Records > 2000 Then
                    picPrevious.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub p_List()
        lstaudit.Items.Clear()
        If sqlDT.Rows.Count > 0 Then
            For i = 0 To sqlDT.Rows.Count - 1
                lstaudit.Items.Add(sqlDT.Rows(i)("Action"), 0)
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Date"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("Timex"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGIN"))
                lstaudit.Items(lstaudit.Items.Count - 1).SubItems.Add(sqlDT.Rows(i)("LOGOUT"))
            Next
        End If
    End Sub

End Class