<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOSRECEIPT_LIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPOSRECEIPT_LIST))
        Me.GBMID = New System.Windows.Forms.GroupBox
        Me.grpreceipt = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdgosearch = New System.Windows.Forms.Button
        Me.txtreceiptid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstreceipt = New System.Windows.Forms.ListView
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GBTOP = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DtTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.chckcollector = New System.Windows.Forms.CheckBox
        Me.cmbcollector = New System.Windows.Forms.ComboBox
        Me.GBBOTTOM = New System.Windows.Forms.GroupBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdview = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DTDATE = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdvoid = New System.Windows.Forms.Button
        Me.GBMID.SuspendLayout()
        Me.grpreceipt.SuspendLayout()
        Me.GBTOP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBBOTTOM.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMID
        '
        Me.GBMID.Controls.Add(Me.grpreceipt)
        Me.GBMID.Controls.Add(Me.lstreceipt)
        Me.GBMID.Location = New System.Drawing.Point(4, 102)
        Me.GBMID.Name = "GBMID"
        Me.GBMID.Size = New System.Drawing.Size(700, 345)
        Me.GBMID.TabIndex = 0
        Me.GBMID.TabStop = False
        '
        'grpreceipt
        '
        Me.grpreceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpreceipt.Controls.Add(Me.Button1)
        Me.grpreceipt.Controls.Add(Me.cmdgosearch)
        Me.grpreceipt.Controls.Add(Me.txtreceiptid)
        Me.grpreceipt.Controls.Add(Me.Label5)
        Me.grpreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpreceipt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpreceipt.Location = New System.Drawing.Point(229, 117)
        Me.grpreceipt.Name = "grpreceipt"
        Me.grpreceipt.Size = New System.Drawing.Size(244, 81)
        Me.grpreceipt.TabIndex = 13
        Me.grpreceipt.TabStop = False
        Me.grpreceipt.Text = "Search Receipt No"
        Me.grpreceipt.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdgosearch
        '
        Me.cmdgosearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgosearch.Location = New System.Drawing.Point(111, 51)
        Me.cmdgosearch.Name = "cmdgosearch"
        Me.cmdgosearch.Size = New System.Drawing.Size(60, 23)
        Me.cmdgosearch.TabIndex = 2
        Me.cmdgosearch.Text = "&GO"
        Me.cmdgosearch.UseVisualStyleBackColor = True
        '
        'txtreceiptid
        '
        Me.txtreceiptid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiptid.Location = New System.Drawing.Point(60, 23)
        Me.txtreceiptid.MaxLength = 50
        Me.txtreceiptid.Name = "txtreceiptid"
        Me.txtreceiptid.Size = New System.Drawing.Size(175, 21)
        Me.txtreceiptid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Search :"
        '
        'lstreceipt
        '
        Me.lstreceipt.FullRowSelect = True
        Me.lstreceipt.GridLines = True
        Me.lstreceipt.Location = New System.Drawing.Point(4, 17)
        Me.lstreceipt.Name = "lstreceipt"
        Me.lstreceipt.Size = New System.Drawing.Size(690, 322)
        Me.lstreceipt.SmallImageList = Me.ImageList2
        Me.lstreceipt.TabIndex = 0
        Me.lstreceipt.UseCompatibleStateImageBehavior = False
        Me.lstreceipt.View = System.Windows.Forms.View.Details
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "money_16.png")
        '
        'GBTOP
        '
        Me.GBTOP.Controls.Add(Me.Label6)
        Me.GBTOP.Controls.Add(Me.Label4)
        Me.GBTOP.Controls.Add(Me.PictureBox1)
        Me.GBTOP.Controls.Add(Me.DtTo)
        Me.GBTOP.Controls.Add(Me.Label2)
        Me.GBTOP.Controls.Add(Me.DtFrom)
        Me.GBTOP.Controls.Add(Me.Label1)
        Me.GBTOP.Controls.Add(Me.chckcollector)
        Me.GBTOP.Controls.Add(Me.cmbcollector)
        Me.GBTOP.Location = New System.Drawing.Point(4, 1)
        Me.GBTOP.Name = "GBTOP"
        Me.GBTOP.Size = New System.Drawing.Size(704, 105)
        Me.GBTOP.TabIndex = 1
        Me.GBTOP.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "All transaction sales receipt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(54, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sales Receipt List"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DtTo
        '
        Me.DtTo.Location = New System.Drawing.Point(438, 79)
        Me.DtTo.Name = "DtTo"
        Me.DtTo.Size = New System.Drawing.Size(210, 21)
        Me.DtTo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date To :"
        '
        'DtFrom
        '
        Me.DtFrom.Location = New System.Drawing.Point(438, 57)
        Me.DtFrom.Name = "DtFrom"
        Me.DtFrom.Size = New System.Drawing.Size(210, 21)
        Me.DtFrom.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date From :"
        '
        'chckcollector
        '
        Me.chckcollector.AutoSize = True
        Me.chckcollector.Location = New System.Drawing.Point(6, 63)
        Me.chckcollector.Name = "chckcollector"
        Me.chckcollector.Size = New System.Drawing.Size(127, 17)
        Me.chckcollector.TabIndex = 4
        Me.chckcollector.Text = "Display by Collector :"
        Me.chckcollector.UseVisualStyleBackColor = True
        '
        'cmbcollector
        '
        Me.cmbcollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcollector.Enabled = False
        Me.cmbcollector.FormattingEnabled = True
        Me.cmbcollector.Location = New System.Drawing.Point(139, 60)
        Me.cmbcollector.Name = "cmbcollector"
        Me.cmbcollector.Size = New System.Drawing.Size(171, 21)
        Me.cmbcollector.TabIndex = 3
        '
        'GBBOTTOM
        '
        Me.GBBOTTOM.Controls.Add(Me.cmdsearch)
        Me.GBBOTTOM.Controls.Add(Me.cmdview)
        Me.GBBOTTOM.Controls.Add(Me.DTDATE)
        Me.GBBOTTOM.Controls.Add(Me.Label3)
        Me.GBBOTTOM.Controls.Add(Me.cmdcancel)
        Me.GBBOTTOM.Controls.Add(Me.cmdvoid)
        Me.GBBOTTOM.Location = New System.Drawing.Point(4, 449)
        Me.GBBOTTOM.Name = "GBBOTTOM"
        Me.GBBOTTOM.Size = New System.Drawing.Size(687, 50)
        Me.GBBOTTOM.TabIndex = 2
        Me.GBBOTTOM.TabStop = False
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(445, 16)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(64, 25)
        Me.cmdsearch.TabIndex = 18
        Me.cmdsearch.Text = "&Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        Me.cmdsearch.Visible = False
        '
        'cmdview
        '
        Me.cmdview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdview.ImageKey = "file.ico"
        Me.cmdview.ImageList = Me.ImageList1
        Me.cmdview.Location = New System.Drawing.Point(87, 13)
        Me.cmdview.Name = "cmdview"
        Me.cmdview.Size = New System.Drawing.Size(128, 32)
        Me.cmdview.TabIndex = 17
        Me.cmdview.Text = "    &View / Return"
        Me.cmdview.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "file.ico")
        '
        'DTDATE
        '
        Me.DTDATE.Location = New System.Drawing.Point(481, 18)
        Me.DTDATE.Name = "DTDATE"
        Me.DTDATE.Size = New System.Drawing.Size(200, 21)
        Me.DTDATE.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "DATE :"
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(515, 16)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(61, 25)
        Me.cmdcancel.TabIndex = 14
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        Me.cmdcancel.Visible = False
        '
        'cmdvoid
        '
        Me.cmdvoid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdvoid.Image = CType(resources.GetObject("cmdvoid.Image"), System.Drawing.Image)
        Me.cmdvoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdvoid.Location = New System.Drawing.Point(10, 13)
        Me.cmdvoid.Name = "cmdvoid"
        Me.cmdvoid.Size = New System.Drawing.Size(71, 32)
        Me.cmdvoid.TabIndex = 13
        Me.cmdvoid.Text = "   &Void"
        Me.cmdvoid.UseVisualStyleBackColor = True
        '
        'FrmPOSRECEIPT_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 511)
        Me.Controls.Add(Me.GBBOTTOM)
        Me.Controls.Add(Me.GBTOP)
        Me.Controls.Add(Me.GBMID)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPOSRECEIPT_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Receipt"
        Me.GBMID.ResumeLayout(False)
        Me.grpreceipt.ResumeLayout(False)
        Me.grpreceipt.PerformLayout()
        Me.GBTOP.ResumeLayout(False)
        Me.GBTOP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBBOTTOM.ResumeLayout(False)
        Me.GBBOTTOM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBMID As System.Windows.Forms.GroupBox
    Friend WithEvents lstreceipt As System.Windows.Forms.ListView
    Friend WithEvents GBTOP As System.Windows.Forms.GroupBox
    Friend WithEvents DtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chckcollector As System.Windows.Forms.CheckBox
    Friend WithEvents cmbcollector As System.Windows.Forms.ComboBox
    Friend WithEvents grpreceipt As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdgosearch As System.Windows.Forms.Button
    Friend WithEvents txtreceiptid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GBBOTTOM As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdview As System.Windows.Forms.Button
    Friend WithEvents DTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdvoid As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
End Class
