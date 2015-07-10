Public Class FrmUNIT_MEASURE_ADD

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "INSERT INTO TBL_Unit_Measure (Code, Description) " & _
                     "VALUES ('" & txtcode.Text & "', " & _
                             "'" & txtdescription.Text & "')"
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Add New Unit Measure")
        Else
            sqlSTR = "UPDATE TBL_Unit_Measure SET Code ='" & txtcode.Text & "', " & _
                                              "Description ='" & txtdescription.Text & "' WHERE ID=" & txtid.Text
            ExecuteSQLQuery(sqlSTR)
            Audit_Trail(xUser_ID, TimeOfDay, "Edit Unit Measure")
        End If

        MsgBox("Record successfuly updated !!!", MsgBoxStyle.Information, "Sales and Inventory")
        sqlSTR = "SELECT * FROM TBL_Unit_Measure"
        FillListView(ExecuteSQLQuery(sqlSTR), FrmUNIT_MEASURE.lstunit, 0)
        Me.Close()
    End Sub

    Private Sub FrmUNIT_MEASURE_ADD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Unit Measure"
    End Sub

    Private Sub FrmUNIT_MEASURE_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim stockid As Integer
        stockid = globalID
        If Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM TBL_Unit_Measure WHERE ID =" & stockid
            ExecuteSQLQuery(sqlSTR)
            txtid.Text = sqlDT.Rows(0)("ID")
            txtcode.Text = sqlDT.Rows(0)("Code")
            txtdescription.Text = sqlDT.Rows(0)("Description")
        Else
            txtcode.Text = ""
            txtid.Text = ""
            txtdescription.Text = ""
        End If

    End Sub
End Class