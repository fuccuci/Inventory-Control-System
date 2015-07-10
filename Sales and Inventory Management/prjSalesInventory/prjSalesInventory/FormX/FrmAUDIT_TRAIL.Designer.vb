<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAUDIT_TRAIL
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAUDIT_TRAIL))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbusers = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstaudit = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PagePanel = New System.Windows.Forms.Panel
        Me.LP10 = New System.Windows.Forms.LinkLabel
        Me.LP9 = New System.Windows.Forms.LinkLabel
        Me.LP8 = New System.Windows.Forms.LinkLabel
        Me.LP7 = New System.Windows.Forms.LinkLabel
        Me.LP6 = New System.Windows.Forms.LinkLabel
        Me.LP5 = New System.Windows.Forms.LinkLabel
        Me.LP4 = New System.Windows.Forms.LinkLabel
        Me.LP3 = New System.Windows.Forms.LinkLabel
        Me.LP2 = New System.Windows.Forms.LinkLabel
        Me.LP1 = New System.Windows.Forms.LinkLabel
        Me.PicNext = New System.Windows.Forms.PictureBox
        Me.picPrevious = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagePanel.SuspendLayout()
        CType(Me.PicNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Users Log"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(94, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Trailing records of all users"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtfrom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbusers)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstaudit)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 393)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'dtto
        '
        Me.dtto.Location = New System.Drawing.Point(604, 20)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(202, 21)
        Me.dtto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(580, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To :"
        '
        'dtfrom
        '
        Me.dtfrom.Location = New System.Drawing.Point(357, 20)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(208, 21)
        Me.dtfrom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(309, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "From :"
        '
        'cmbusers
        '
        Me.cmbusers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusers.FormattingEnabled = True
        Me.cmbusers.Location = New System.Drawing.Point(94, 20)
        Me.cmbusers.Name = "cmbusers"
        Me.cmbusers.Size = New System.Drawing.Size(148, 21)
        Me.cmbusers.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "USERNAME :"
        '
        'lstaudit
        '
        Me.lstaudit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstaudit.FullRowSelect = True
        Me.lstaudit.GridLines = True
        Me.lstaudit.Location = New System.Drawing.Point(6, 50)
        Me.lstaudit.Name = "lstaudit"
        Me.lstaudit.Size = New System.Drawing.Size(800, 337)
        Me.lstaudit.SmallImageList = Me.ImageList1
        Me.lstaudit.TabIndex = 0
        Me.lstaudit.UseCompatibleStateImageBehavior = False
        Me.lstaudit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Actions"
        Me.ColumnHeader1.Width = 450
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "LOG IN"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LOG OUT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "document_pencil_16.png")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(55, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PagePanel
        '
        Me.PagePanel.Controls.Add(Me.LP10)
        Me.PagePanel.Controls.Add(Me.LP9)
        Me.PagePanel.Controls.Add(Me.LP8)
        Me.PagePanel.Controls.Add(Me.LP7)
        Me.PagePanel.Controls.Add(Me.LP6)
        Me.PagePanel.Controls.Add(Me.LP5)
        Me.PagePanel.Controls.Add(Me.LP4)
        Me.PagePanel.Controls.Add(Me.LP3)
        Me.PagePanel.Controls.Add(Me.LP2)
        Me.PagePanel.Controls.Add(Me.LP1)
        Me.PagePanel.Controls.Add(Me.PicNext)
        Me.PagePanel.Controls.Add(Me.picPrevious)
        Me.PagePanel.Location = New System.Drawing.Point(501, 30)
        Me.PagePanel.Name = "PagePanel"
        Me.PagePanel.Size = New System.Drawing.Size(225, 27)
        Me.PagePanel.TabIndex = 7
        Me.PagePanel.Visible = False
        '
        'LP10
        '
        Me.LP10.AutoSize = True
        Me.LP10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP10.Location = New System.Drawing.Point(173, 5)
        Me.LP10.Name = "LP10"
        Me.LP10.Size = New System.Drawing.Size(24, 16)
        Me.LP10.TabIndex = 17
        Me.LP10.TabStop = True
        Me.LP10.Text = "10"
        '
        'LP9
        '
        Me.LP9.AutoSize = True
        Me.LP9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP9.Location = New System.Drawing.Point(157, 5)
        Me.LP9.Name = "LP9"
        Me.LP9.Size = New System.Drawing.Size(16, 16)
        Me.LP9.TabIndex = 16
        Me.LP9.TabStop = True
        Me.LP9.Text = "9"
        '
        'LP8
        '
        Me.LP8.AutoSize = True
        Me.LP8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP8.Location = New System.Drawing.Point(141, 5)
        Me.LP8.Name = "LP8"
        Me.LP8.Size = New System.Drawing.Size(16, 16)
        Me.LP8.TabIndex = 15
        Me.LP8.TabStop = True
        Me.LP8.Text = "8"
        Me.LP8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LP7
        '
        Me.LP7.AutoSize = True
        Me.LP7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP7.Location = New System.Drawing.Point(126, 5)
        Me.LP7.Name = "LP7"
        Me.LP7.Size = New System.Drawing.Size(16, 16)
        Me.LP7.TabIndex = 10
        Me.LP7.TabStop = True
        Me.LP7.Text = "7"
        '
        'LP6
        '
        Me.LP6.AutoSize = True
        Me.LP6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP6.Location = New System.Drawing.Point(110, 5)
        Me.LP6.Name = "LP6"
        Me.LP6.Size = New System.Drawing.Size(16, 16)
        Me.LP6.TabIndex = 14
        Me.LP6.TabStop = True
        Me.LP6.Text = "6"
        '
        'LP5
        '
        Me.LP5.AutoSize = True
        Me.LP5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP5.Location = New System.Drawing.Point(94, 5)
        Me.LP5.Name = "LP5"
        Me.LP5.Size = New System.Drawing.Size(16, 16)
        Me.LP5.TabIndex = 13
        Me.LP5.TabStop = True
        Me.LP5.Text = "5"
        '
        'LP4
        '
        Me.LP4.AutoSize = True
        Me.LP4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP4.Location = New System.Drawing.Point(78, 5)
        Me.LP4.Name = "LP4"
        Me.LP4.Size = New System.Drawing.Size(16, 16)
        Me.LP4.TabIndex = 12
        Me.LP4.TabStop = True
        Me.LP4.Text = "4"
        '
        'LP3
        '
        Me.LP3.AutoSize = True
        Me.LP3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP3.Location = New System.Drawing.Point(62, 5)
        Me.LP3.Name = "LP3"
        Me.LP3.Size = New System.Drawing.Size(16, 16)
        Me.LP3.TabIndex = 11
        Me.LP3.TabStop = True
        Me.LP3.Text = "3"
        '
        'LP2
        '
        Me.LP2.AutoSize = True
        Me.LP2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP2.Location = New System.Drawing.Point(46, 5)
        Me.LP2.Name = "LP2"
        Me.LP2.Size = New System.Drawing.Size(16, 16)
        Me.LP2.TabIndex = 10
        Me.LP2.TabStop = True
        Me.LP2.Text = "2"
        '
        'LP1
        '
        Me.LP1.AutoSize = True
        Me.LP1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP1.Location = New System.Drawing.Point(30, 5)
        Me.LP1.Name = "LP1"
        Me.LP1.Size = New System.Drawing.Size(16, 16)
        Me.LP1.TabIndex = 9
        Me.LP1.TabStop = True
        Me.LP1.Text = "1"
        '
        'PicNext
        '
        Me.PicNext.Image = CType(resources.GetObject("PicNext.Image"), System.Drawing.Image)
        Me.PicNext.Location = New System.Drawing.Point(200, 2)
        Me.PicNext.Name = "PicNext"
        Me.PicNext.Size = New System.Drawing.Size(23, 22)
        Me.PicNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNext.TabIndex = 8
        Me.PicNext.TabStop = False
        '
        'picPrevious
        '
        Me.picPrevious.Image = CType(resources.GetObject("picPrevious.Image"), System.Drawing.Image)
        Me.picPrevious.Location = New System.Drawing.Point(3, 2)
        Me.picPrevious.Name = "picPrevious"
        Me.picPrevious.Size = New System.Drawing.Size(23, 22)
        Me.picPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrevious.TabIndex = 8
        Me.picPrevious.TabStop = False
        '
        'FrmAUDIT_TRAIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(888, 550)
        Me.Controls.Add(Me.PagePanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmAUDIT_TRAIL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users Log"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagePanel.ResumeLayout(False)
        Me.PagePanel.PerformLayout()
        CType(Me.PicNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbusers As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstaudit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PagePanel As System.Windows.Forms.Panel
    Friend WithEvents LP1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PicNext As System.Windows.Forms.PictureBox
    Friend WithEvents picPrevious As System.Windows.Forms.PictureBox
    Friend WithEvents LP10 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LP2 As System.Windows.Forms.LinkLabel
End Class
