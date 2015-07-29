<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPURCHASEORDER_RECEIPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPURCHASEORDER_RECEIPT))
        Me.cboWarehouse = New System.Windows.Forms.ComboBox()
        Me.lbWarehouse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkreceivedateall = New System.Windows.Forms.CheckBox()
        Me.chkpodateall = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dttopodate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtfrompodate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstreceive = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbSumReceivedAmt = New System.Windows.Forms.Label()
        Me.lbSumPOAmt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboWarehouse
        '
        Me.cboWarehouse.FormattingEnabled = True
        Me.cboWarehouse.Location = New System.Drawing.Point(107, 39)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(252, 21)
        Me.cboWarehouse.TabIndex = 0
        '
        'lbWarehouse
        '
        Me.lbWarehouse.AutoSize = True
        Me.lbWarehouse.Location = New System.Drawing.Point(9, 42)
        Me.lbWarehouse.Name = "lbWarehouse"
        Me.lbWarehouse.Size = New System.Drawing.Size(98, 13)
        Me.lbWarehouse.TabIndex = 1
        Me.lbWarehouse.Text = "Select Warehouse:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Supplier:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Purchase Order:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkreceivedateall)
        Me.GroupBox1.Controls.Add(Me.chkpodateall)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dttopodate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtfrompodate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(365, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 81)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Range"
        '
        'chkreceivedateall
        '
        Me.chkreceivedateall.Location = New System.Drawing.Point(459, 47)
        Me.chkreceivedateall.Name = "chkreceivedateall"
        Me.chkreceivedateall.Size = New System.Drawing.Size(37, 14)
        Me.chkreceivedateall.TabIndex = 15
        Me.chkreceivedateall.Text = "All"
        Me.chkreceivedateall.UseVisualStyleBackColor = True
        '
        'chkpodateall
        '
        Me.chkpodateall.Location = New System.Drawing.Point(459, 22)
        Me.chkpodateall.Name = "chkpodateall"
        Me.chkpodateall.Size = New System.Drawing.Size(37, 14)
        Me.chkpodateall.TabIndex = 14
        Me.chkpodateall.Text = "All"
        Me.chkpodateall.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(305, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "to"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(134, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Receive Date:"
        '
        'dttopodate
        '
        Me.dttopodate.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttopodate.CustomFormat = "dd/MMM/yyyy"
        Me.dttopodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttopodate.Location = New System.Drawing.Point(305, 19)
        Me.dttopodate.Name = "dttopodate"
        Me.dttopodate.Size = New System.Drawing.Size(142, 20)
        Me.dttopodate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "to"
        '
        'dtfrompodate
        '
        Me.dtfrompodate.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrompodate.CustomFormat = "dd/MMM/yyyy"
        Me.dtfrompodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrompodate.Location = New System.Drawing.Point(134, 19)
        Me.dtfrompodate.Name = "dtfrompodate"
        Me.dtfrompodate.Size = New System.Drawing.Size(142, 20)
        Me.dtfrompodate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PO Date:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstreceive)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 323)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lstreceive
        '
        Me.lstreceive.FullRowSelect = True
        Me.lstreceive.GridLines = True
        Me.lstreceive.Location = New System.Drawing.Point(0, 6)
        Me.lstreceive.Name = "lstreceive"
        Me.lstreceive.Size = New System.Drawing.Size(869, 297)
        Me.lstreceive.TabIndex = 3
        Me.lstreceive.UseCompatibleStateImageBehavior = False
        Me.lstreceive.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 33)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(47, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Purchase Order Receipt"
        '
        'lbSumReceivedAmt
        '
        Me.lbSumReceivedAmt.Location = New System.Drawing.Point(701, 121)
        Me.lbSumReceivedAmt.Name = "lbSumReceivedAmt"
        Me.lbSumReceivedAmt.Size = New System.Drawing.Size(164, 18)
        Me.lbSumReceivedAmt.TabIndex = 20
        Me.lbSumReceivedAmt.Text = "Total Order Amount: 999999999"
        '
        'lbSumPOAmt
        '
        Me.lbSumPOAmt.Location = New System.Drawing.Point(520, 122)
        Me.lbSumPOAmt.Name = "lbSumPOAmt"
        Me.lbSumPOAmt.Size = New System.Drawing.Size(184, 18)
        Me.lbSumPOAmt.TabIndex = 19
        Me.lbSumPOAmt.Text = "Total Order Amount: 999999999"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Received PO By Items"
        '
        'FrmPURCHASEORDER_RECEIPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 564)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbSumReceivedAmt)
        Me.Controls.Add(Me.lbSumPOAmt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbWarehouse)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Name = "FrmPURCHASEORDER_RECEIPT"
        Me.Text = "Purchase Order Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lbWarehouse As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkpodateall As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dttopodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtfrompodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkreceivedateall As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstreceive As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbSumReceivedAmt As System.Windows.Forms.Label
    Friend WithEvents lbSumPOAmt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
