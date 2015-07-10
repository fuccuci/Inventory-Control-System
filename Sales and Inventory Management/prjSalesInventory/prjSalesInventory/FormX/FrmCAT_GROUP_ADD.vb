Public Class FrmCAT_GROUP_ADD
    Dim StockID As Integer
    Private Sub FrmCAT_GROUP_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Group"
    End Sub

    Private Sub FrmCAT_GROUP_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StockID = globalID
        If Split(Me.Text, " - ")(1) = "Add" Then
            txtgname.Text = ""
            txtgdesc.Text = ""
        Else
            sqlSTR = "SELECT * FROM TBL_Group WHERE Group_ID =" & StockID
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtgname.Text = sqlDT.Rows(0)("Group_Name")
                txtgdesc.Text = sqlDT.Rows(0)("Group_Description")
            End If
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim sqlstr As String
        If txtgname.Text = "" Then
            MsgBox("Group name is recquired !!", MsgBoxStyle.Exclamation, "Sales and Inventory")
            Exit Sub
        End If
        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlstr = "INSERT INTO TBL_Group (Group_Name, Group_Description) VALUES ('" & R_eplace(txtgname.Text) & "', '" & R_eplace(txtgdesc.Text) & "')"
            ExecuteSQLQuery(sqlstr)
        Else
            sqlstr = "UPDATE TBL_Group SET Group_Name ='" & txtgname.Text & "', " & _
                                   "Group_Description ='" & txtgdesc.Text & "'" & _
                                   "WHERE Group_ID =" & StockID
            ExecuteSQLQuery(sqlstr)
        End If
        FillListView(ExecuteSQLQuery("SELECT Group_ID AS 'ID', Group_Name AS 'Name', Group_Description AS 'Description' FROM TBL_Group"), FrmCatList.lstCat, 0)
        Me.Close()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub txtgname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgname.TextChanged
        txtgname.Text = filter_Special_Char(str_Filter(txtgname, 65, 122, 32, 40))
    End Sub

    Private Sub txtgdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgdesc.TextChanged
        txtgdesc.Text = filter_Special_Char(str_Filter(txtgdesc, 65, 122, 32, 40))
    End Sub
End Class