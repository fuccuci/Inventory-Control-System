'Created on August 16, 2010
'Tan, Angelito S.

'Date update dec 12, 2010
Imports System.Data.OleDb
Module ModCon
    'Public fso As New filesystemobject
    Public ParamDVFrom As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamDVTo As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyName As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyLoc As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyContact As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyTIN As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public _USER As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public sqlDT As New DataTable
    Public sqlDTx As New DataTable
    Public openedFileStream As System.IO.Stream

    'Public Const cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=../database/SaleInv_DB.mdb"
    'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB; Trusted_Connection=yes;"
    'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB;Uid=sa; Pwd=angelito;"

    'Public Const cnstring As String = "Provider=SQLOLEDB;" & _
    '                                  "Data Source=;" & _
    '                                  "Network=CPAT;" & _
    '                                  "Initial Catalog=SaleInv_DB;" & _
    '                                  "User Id=sa;" & _
    '                                  "Password=angelito"
    '192.168.1.104;" & _'                           

    Public CnString As String

    'Public conn As OleDbConnection = New OleDbConnection(cnString)
    ' Public DataFileLock As New System.Threading.ReaderWriterLock

    Public sqlSTR As String
    Public Rpt_SqlStr As String
    Public pass As Boolean
    Public VAT As Double
    Public username As String
    Public xUser_ID As Integer
    Public xUser_Access As String
    Public Pending_ID As Integer
    Public Pending_QTY As Integer
    Public Pending_Item_ID As Integer
    Public dataBytes() As Byte
    Public xpass As Boolean
    Public howx As Integer
    Public xid(1) As Integer
    Public xlock As Boolean
    Public iMin As Integer
    Public tmpStr As String
    Public LOGID As Integer
    Public PreviousPage, NextPage As Integer
    Public i_Print As Integer

    Public Function checkServer() As Boolean
        Try

            With FrmSERVERSETTINGS
                .OpenFileDialog1.FileName = Application.StartupPath & "\Config.ini"
                openedFileStream = .OpenFileDialog1.OpenFile()
            End With

            ReDim dataBytes(openedFileStream.Length - 1) 'Init 
            openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
            openedFileStream.Close()
            tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)

            With FrmSERVERSETTINGS
                If Split(tmpStr, ":")(4) = "1" Then
                    'network
                    CnString = "Provider=SQLOLEDB;" & _
                               "Data Source=" & Split(tmpStr, ":")(0) & _
                               ";Network=" & Split(tmpStr, ":")(1) & _
                               ";Server=" & Split(tmpStr, ":")(1) & _
                               ";Initial Catalog=SaleInv_DB" & _
                               ";User Id=" & Split(tmpStr, ":")(2) & _
                               ";Password=" & Split(tmpStr, ":")(3)
                Else
                    'local
                    'MsgBox(Split(tmpStr, ":")(1))
                    CnString = "Provider=SQLOLEDB;Server=" & Split(tmpStr, ":")(1) & _
                               ";Database=SaleInv_DB; Trusted_Connection=yes;"
                End If
            End With
            Dim sqlCon As New OleDbConnection
            sqlCon.ConnectionString = CnString
            sqlCon.Open()
            checkServer = True
            sqlCon.Close()
        Catch ex As Exception
            checkServer = False
        End Try
    End Function

    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New OleDbConnection(CnString)
            Dim sqlDA As New OleDbDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New OleDbCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            'MsgBox("Error: " & ex.ToString)
            ' If Err.Number = 5 Then
            ' MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
            ' Else
            MsgBox("Error : " & ex.Message)
            ' End If
            'MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
            'MsgBox(SQLQuery)
        End Try
        Return sqlDT
    End Function
    Public Sub FILLComboBox(ByVal sql As String, ByVal cb As ComboBox)
        Dim conn As OleDbConnection = New OleDbConnection(CnString)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString & " - " & rdr(1).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub FILLComboBox2(ByVal sql As String, ByVal cb As ComboBox)
        Dim conn As OleDbConnection = New OleDbConnection(CnString)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(1).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Function DataSourceConnection_Report()
        If Split(tmpStr, ":")(4) = "1" Then
            'mReport.DataSourceConnections
            'mReport()
            'mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
            mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", False)
            'MsgBox(Split(tmpStr, ":")(2) & "  " & Split(tmpStr, ":")(3))
            mReport.DataSourceConnections(0).SetLogon(Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
        Else

            mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", True)
        End If
        'MsgBox(mReport.DataSourceConnections(0).ServerName.ToString)
        Return 0
    End Function
End Module
