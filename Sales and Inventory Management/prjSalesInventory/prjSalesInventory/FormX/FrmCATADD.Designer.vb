<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatADD))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.grpCat = New System.Windows.Forms.GroupBox()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdedit2 = New System.Windows.Forms.Button()
        Me.cmdadd2 = New System.Windows.Forms.Button()
        Me.lstitems = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdcancel2 = New System.Windows.Forms.Button()
        Me.cmdSave2 = New System.Windows.Forms.Button()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtItemprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemreorder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemBarcode = New System.Windows.Forms.TextBox()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtitemID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.lstcat = New System.Windows.Forms.ListView()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.grpCat.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbGroup)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 46)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(71, 14)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(233, 21)
        Me.cmbGroup.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "By Group :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "clipboard_16.png")
        Me.ImageList1.Images.SetKeyName(1, "address_16.png")
        '
        'grpCat
        '
        Me.grpCat.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCat.Controls.Add(Me.cmdcancel)
        Me.grpCat.Controls.Add(Me.cmdsave)
        Me.grpCat.Controls.Add(Me.txtdesc)
        Me.grpCat.Controls.Add(Me.Label3)
        Me.grpCat.Controls.Add(Me.txtname)
        Me.grpCat.Controls.Add(Me.Label2)
        Me.grpCat.Controls.Add(Me.txtid)
        Me.grpCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCat.Location = New System.Drawing.Point(125, 184)
        Me.grpCat.Name = "grpCat"
        Me.grpCat.Size = New System.Drawing.Size(332, 101)
        Me.grpCat.TabIndex = 3
        Me.grpCat.TabStop = False
        Me.grpCat.Visible = False
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(76, 67)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(57, 25)
        Me.cmdcancel.TabIndex = 154
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(10, 67)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(60, 25)
        Me.cmdsave.TabIndex = 153
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(121, 40)
        Me.txtdesc.MaxLength = 50
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(195, 21)
        Me.txtdesc.TabIndex = 148
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Category Description :"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(121, 18)
        Me.txtname.MaxLength = 50
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(195, 21)
        Me.txtname.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Category Name :"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(241, 70)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(75, 21)
        Me.txtid.TabIndex = 152
        Me.txtid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdedit2)
        Me.GroupBox1.Controls.Add(Me.cmdadd2)
        Me.GroupBox1.Controls.Add(Me.lstitems)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 242)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cmdedit2
        '
        Me.cmdedit2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit2.Location = New System.Drawing.Point(81, 208)
        Me.cmdedit2.Name = "cmdedit2"
        Me.cmdedit2.Size = New System.Drawing.Size(65, 25)
        Me.cmdedit2.TabIndex = 2
        Me.cmdedit2.Text = "Ed&it"
        Me.cmdedit2.UseVisualStyleBackColor = True
        '
        'cmdadd2
        '
        Me.cmdadd2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd2.Location = New System.Drawing.Point(10, 208)
        Me.cmdadd2.Name = "cmdadd2"
        Me.cmdadd2.Size = New System.Drawing.Size(65, 25)
        Me.cmdadd2.TabIndex = 1
        Me.cmdadd2.Text = "A&dd"
        Me.cmdadd2.UseVisualStyleBackColor = True
        '
        'lstitems
        '
        Me.lstitems.FullRowSelect = True
        Me.lstitems.GridLines = True
        Me.lstitems.Location = New System.Drawing.Point(9, 12)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(341, 190)
        Me.lstitems.SmallImageList = Me.ImageList1
        Me.lstitems.TabIndex = 0
        Me.lstitems.UseCompatibleStateImageBehavior = False
        Me.lstitems.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbCategory)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cmdcancel2)
        Me.GroupBox3.Controls.Add(Me.cmdSave2)
        Me.GroupBox3.Controls.Add(Me.cmbUnit)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtItemprice)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtItemreorder)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtItemBarcode)
        Me.GroupBox3.Controls.Add(Me.txtItemDesc)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtItemName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtitemID)
        Me.GroupBox3.Location = New System.Drawing.Point(319, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 222)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(143, 82)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(200, 21)
        Me.cmbCategory.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Category :"
        '
        'cmdcancel2
        '
        Me.cmdcancel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel2.Location = New System.Drawing.Point(80, 184)
        Me.cmdcancel2.Name = "cmdcancel2"
        Me.cmdcancel2.Size = New System.Drawing.Size(65, 25)
        Me.cmdcancel2.TabIndex = 119
        Me.cmdcancel2.Text = "Cancel"
        Me.cmdcancel2.UseVisualStyleBackColor = True
        '
        'cmdSave2
        '
        Me.cmdSave2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave2.Location = New System.Drawing.Point(10, 184)
        Me.cmdSave2.Name = "cmdSave2"
        Me.cmdSave2.Size = New System.Drawing.Size(65, 25)
        Me.cmdSave2.TabIndex = 118
        Me.cmdSave2.Text = "Save"
        Me.cmdSave2.UseVisualStyleBackColor = True
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(143, 106)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(137, 21)
        Me.cmbUnit.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Item Measure :"
        '
        'txtItemprice
        '
        Me.txtItemprice.Location = New System.Drawing.Point(143, 130)
        Me.txtItemprice.MaxLength = 50
        Me.txtItemprice.Name = "txtItemprice"
        Me.txtItemprice.Size = New System.Drawing.Size(84, 21)
        Me.txtItemprice.TabIndex = 111
        Me.txtItemprice.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Price :"
        '
        'txtItemreorder
        '
        Me.txtItemreorder.Location = New System.Drawing.Point(144, 152)
        Me.txtItemreorder.MaxLength = 50
        Me.txtItemreorder.Name = "txtItemreorder"
        Me.txtItemreorder.Size = New System.Drawing.Size(83, 21)
        Me.txtItemreorder.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Reorder Point :"
        '
        'txtItemBarcode
        '
        Me.txtItemBarcode.Location = New System.Drawing.Point(143, 60)
        Me.txtItemBarcode.MaxLength = 13
        Me.txtItemBarcode.Name = "txtItemBarcode"
        Me.txtItemBarcode.Size = New System.Drawing.Size(200, 21)
        Me.txtItemBarcode.TabIndex = 107
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(143, 38)
        Me.txtItemDesc.MaxLength = 50
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(200, 21)
        Me.txtItemDesc.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Item Barcode :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Description / Item Number :"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(142, 15)
        Me.txtItemName.MaxLength = 50
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(200, 21)
        Me.txtItemName.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Item Name :"
        '
        'txtitemID
        '
        Me.txtitemID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtitemID.Location = New System.Drawing.Point(258, 165)
        Me.txtitemID.Name = "txtitemID"
        Me.txtitemID.ReadOnly = True
        Me.txtitemID.Size = New System.Drawing.Size(92, 21)
        Me.txtitemID.TabIndex = 114
        Me.txtitemID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(56, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Category Listing / Item Listing"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Add new and modify current data"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdEdit)
        Me.GroupBox4.Controls.Add(Me.cmdadd)
        Me.GroupBox4.Controls.Add(Me.lstcat)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(311, 416)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Category Details"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(78, 382)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(65, 25)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(9, 382)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(65, 25)
        Me.cmdadd.TabIndex = 6
        Me.cmdadd.Text = "&Add"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'lstcat
        '
        Me.lstcat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcat.FullRowSelect = True
        Me.lstcat.GridLines = True
        Me.lstcat.Location = New System.Drawing.Point(6, 16)
        Me.lstcat.Name = "lstcat"
        Me.lstcat.Size = New System.Drawing.Size(299, 360)
        Me.lstcat.SmallImageList = Me.ImageList1
        Me.lstcat.TabIndex = 5
        Me.lstcat.UseCompatibleStateImageBehavior = False
        Me.lstcat.View = System.Windows.Forms.View.Details
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(587, 513)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(65, 27)
        Me.cmdclose.TabIndex = 7
        Me.cmdclose.Text = "&Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FrmCatADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(687, 545)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.grpCat)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCatADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpCat.ResumeLayout(False)
        Me.grpCat.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCat As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstitems As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItemprice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemreorder As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtitemID As System.Windows.Forms.TextBox
    Friend WithEvents cmdedit2 As System.Windows.Forms.Button
    Friend WithEvents cmdadd2 As System.Windows.Forms.Button
    Friend WithEvents cmdSave2 As System.Windows.Forms.Button
    Friend WithEvents cmdcancel2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents lstcat As System.Windows.Forms.ListView
End Class
