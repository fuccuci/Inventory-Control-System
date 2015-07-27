<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPURCHASEORDER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPURCHASEORDER))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbreceive = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbpurchase = New System.Windows.Forms.RadioButton()
        Me.listorder = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtpurchased = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpCat = New System.Windows.Forms.GroupBox()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.CmdSearch = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpCat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "List of purchase order and receive products"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Purchasing Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbreceive)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rbpurchase)
        Me.GroupBox1.Controls.Add(Me.listorder)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 475)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Black for Not Approved Order"
        '
        'rbreceive
        '
        Me.rbreceive.AutoSize = True
        Me.rbreceive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbreceive.Location = New System.Drawing.Point(670, 14)
        Me.rbreceive.Name = "rbreceive"
        Me.rbreceive.Size = New System.Drawing.Size(105, 17)
        Me.rbreceive.TabIndex = 2
        Me.rbreceive.TabStop = True
        Me.rbreceive.Text = "Receive Order"
        Me.rbreceive.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(69, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Red For Approved Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Legend :"
        '
        'rbpurchase
        '
        Me.rbpurchase.AutoSize = True
        Me.rbpurchase.Checked = True
        Me.rbpurchase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpurchase.Location = New System.Drawing.Point(552, 14)
        Me.rbpurchase.Name = "rbpurchase"
        Me.rbpurchase.Size = New System.Drawing.Size(112, 17)
        Me.rbpurchase.TabIndex = 1
        Me.rbpurchase.TabStop = True
        Me.rbpurchase.Text = "Purchase Order"
        Me.rbpurchase.UseVisualStyleBackColor = True
        '
        'listorder
        '
        Me.listorder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listorder.FullRowSelect = True
        Me.listorder.GridLines = True
        Me.listorder.Location = New System.Drawing.Point(6, 37)
        Me.listorder.Name = "listorder"
        Me.listorder.Size = New System.Drawing.Size(769, 415)
        Me.listorder.SmallImageList = Me.ImageList1
        Me.listorder.TabIndex = 0
        Me.listorder.UseCompatibleStateImageBehavior = False
        Me.listorder.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "archives.png")
        '
        'dtpurchased
        '
        Me.dtpurchased.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpurchased.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpurchased.Location = New System.Drawing.Point(592, 28)
        Me.dtpurchased.Name = "dtpurchased"
        Me.dtpurchased.Size = New System.Drawing.Size(200, 21)
        Me.dtpurchased.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Purchased Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpCat
        '
        Me.grpCat.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCat.Controls.Add(Me.cmdcancel)
        Me.grpCat.Controls.Add(Me.CmdSearch)
        Me.grpCat.Controls.Add(Me.txtname)
        Me.grpCat.Controls.Add(Me.Label5)
        Me.grpCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCat.Location = New System.Drawing.Point(287, 237)
        Me.grpCat.Name = "grpCat"
        Me.grpCat.Size = New System.Drawing.Size(320, 81)
        Me.grpCat.TabIndex = 6
        Me.grpCat.TabStop = False
        Me.grpCat.Text = "Search by Supplier Name "
        Me.grpCat.Visible = False
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(239, 52)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancel.TabIndex = 3
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Location = New System.Drawing.Point(158, 52)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.CmdSearch.TabIndex = 2
        Me.CmdSearch.Text = "&Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(60, 23)
        Me.txtname.MaxLength = 50
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 22)
        Me.txtname.TabIndex = 1
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
        'FrmPURCHASEORDER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(826, 633)
        Me.Controls.Add(Me.grpCat)
        Me.Controls.Add(Me.dtpurchased)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "FrmPURCHASEORDER"
        Me.Text = "Order and Receive"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCat.ResumeLayout(False)
        Me.grpCat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listorder As System.Windows.Forms.ListView
    Friend WithEvents dtpurchased As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpCat As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbpurchase As System.Windows.Forms.RadioButton
    Friend WithEvents rbreceive As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
