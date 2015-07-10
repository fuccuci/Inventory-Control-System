<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBG))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pics = New System.Windows.Forms.PictureBox()
        CType(Me.pics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "organize.ico")
        Me.ImageList1.Images.SetKeyName(1, "shared.ico")
        Me.ImageList1.Images.SetKeyName(2, "factory.ico")
        Me.ImageList1.Images.SetKeyName(3, "statistics.ico")
        Me.ImageList1.Images.SetKeyName(4, "statics-2.ico")
        Me.ImageList1.Images.SetKeyName(5, "ftp.ico")
        Me.ImageList1.Images.SetKeyName(6, "cubes.ico")
        Me.ImageList1.Images.SetKeyName(7, "download.ico")
        Me.ImageList1.Images.SetKeyName(8, "export1.ico")
        Me.ImageList1.Images.SetKeyName(9, "upload.ico")
        Me.ImageList1.Images.SetKeyName(10, "basket.ico")
        Me.ImageList1.Images.SetKeyName(11, "graph32(8).ico")
        Me.ImageList1.Images.SetKeyName(12, "shopping-basket.ico")
        Me.ImageList1.Images.SetKeyName(13, "agenda.ico")
        Me.ImageList1.Images.SetKeyName(14, "sale.ico")
        Me.ImageList1.Images.SetKeyName(15, "Project.ico")
        Me.ImageList1.Images.SetKeyName(16, "grafle.ico")
        Me.ImageList1.Images.SetKeyName(17, "factory.ico")
        Me.ImageList1.Images.SetKeyName(18, "basket.ico")
        Me.ImageList1.Images.SetKeyName(19, "get_info.ico")
        Me.ImageList1.Images.SetKeyName(20, "chart.ico")
        Me.ImageList1.Images.SetKeyName(21, "file _paste.ico")
        Me.ImageList1.Images.SetKeyName(22, "connect.ico")
        '
        'pics
        '
        Me.pics.Location = New System.Drawing.Point(23, 78)
        Me.pics.Name = "pics"
        Me.pics.Size = New System.Drawing.Size(756, 329)
        Me.pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pics.TabIndex = 0
        Me.pics.TabStop = False
        '
        'FrmBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.pics)
        Me.Name = "FrmBG"
        CType(Me.pics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pics As System.Windows.Forms.PictureBox
End Class
