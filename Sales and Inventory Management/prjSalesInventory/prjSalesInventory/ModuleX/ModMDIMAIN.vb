Module ModMDIMAIN
    Public Sub MDIREFRESH()
        With MDIMain
            '  .ToolStripNew.Enabled = True
            '  .ToolStripEdit.Enabled = True
            '  .ToolStripDelete.Enabled = True
            '  .ToolStripSearch.Enabled = True
            '  .toolStripClose.Enabled = True
            '  .ToolStripRefresh.Enabled = True
            '  .ToolStripPrint.Enabled = True
            .cmdNew.Enabled = True
            .cmdEdit.Enabled = True
            .cmdDelete.Enabled = True
            .cmdSearch.Enabled = True
            .cmdRefresh.Enabled = True
            .cmdClose.Enabled = True
            .cmdPrint.Enabled = True
        End With
    End Sub
    Public Sub MDIDISABLED()
        With MDIMain
            .cmdNew.Enabled = False
            .cmdEdit.Enabled = False
            .cmdDelete.Enabled = False
            .cmdSearch.Enabled = False
            .cmdRefresh.Enabled = True
            .cmdClose.Enabled = False
            .cmdPrint.Enabled = False
            '.ToolStripSearch.Enabled = False
            ' .toolStripClose.Enabled = False
            '.ToolStripDelete.Enabled = False
            '.ToolStripEdit.Enabled = False
            '.ToolStripNew.Enabled = False
            '.ToolStripPrint.Enabled = False
            '.ToolStripRefresh.Enabled = False
        End With
    End Sub
    Public Sub xclose()
        Dim oFrm As Form
        For Each oFrm In MDIMain.MdiChildren
            'MsgBox(oFrm.Name)
            If oFrm.Name <> "FrmBG" And Not _
                     (TypeOf oFrm Is MDIMain) And Not (TypeOf oFrm Is FrmBG) Then oFrm.Close()
        Next
    End Sub
End Module
