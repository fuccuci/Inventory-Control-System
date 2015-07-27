<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpCat = New System.Windows.Forms.GroupBox()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.CmdSearch = New System.Windows.Forms.Button()
        Me.txtcatname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCat = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RBCat = New System.Windows.Forms.RadioButton()
        Me.RBALL = New System.Windows.Forms.RadioButton()
        Me.rbcatitemlist = New System.Windows.Forms.RadioButton()
        Me.lstCategory = New System.Windows.Forms.ListView()
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.grpcatitem = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBGroup = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCat.SuspendLayout()
        Me.grpcatitem.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Allow to categorize each kind of properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(52, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Listing"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpCat
        '
        Me.grpCat.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCat.Controls.Add(Me.cmdcancel)
        Me.grpCat.Controls.Add(Me.CmdSearch)
        Me.grpCat.Controls.Add(Me.txtcatname)
        Me.grpCat.Controls.Add(Me.Label3)
        Me.grpCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCat.Location = New System.Drawing.Point(268, 173)
        Me.grpCat.Name = "grpCat"
        Me.grpCat.Size = New System.Drawing.Size(320, 81)
        Me.grpCat.TabIndex = 2
        Me.grpCat.TabStop = False
        Me.grpCat.Text = "Search by Name "
        Me.grpCat.Visible = False
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(239, 52)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancel.TabIndex = 3
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.Location = New System.Drawing.Point(158, 52)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.CmdSearch.TabIndex = 2
        Me.CmdSearch.Text = "&Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'txtcatname
        '
        Me.txtcatname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcatname.Location = New System.Drawing.Point(60, 23)
        Me.txtcatname.MaxLength = 50
        Me.txtcatname.Name = "txtcatname"
        Me.txtcatname.Size = New System.Drawing.Size(254, 22)
        Me.txtcatname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Search :"
        '
        'lstCat
        '
        Me.lstCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCat.FullRowSelect = True
        Me.lstCat.GridLines = True
        Me.lstCat.Location = New System.Drawing.Point(6, 11)
        Me.lstCat.Name = "lstCat"
        Me.lstCat.Size = New System.Drawing.Size(779, 532)
        Me.lstCat.SmallImageList = Me.ImageList1
        Me.lstCat.TabIndex = 0
        Me.lstCat.UseCompatibleStateImageBehavior = False
        Me.lstCat.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "paste.ico")
        '
        'RBCat
        '
        Me.RBCat.AutoSize = True
        Me.RBCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCat.Location = New System.Drawing.Point(408, 24)
        Me.RBCat.Name = "RBCat"
        Me.RBCat.Size = New System.Drawing.Size(94, 17)
        Me.RBCat.TabIndex = 2
        Me.RBCat.TabStop = True
        Me.RBCat.Text = "By Category"
        Me.RBCat.UseVisualStyleBackColor = True
        '
        'RBALL
        '
        Me.RBALL.AutoSize = True
        Me.RBALL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBALL.Location = New System.Drawing.Point(638, 24)
        Me.RBALL.Name = "RBALL"
        Me.RBALL.Size = New System.Drawing.Size(166, 17)
        Me.RBALL.TabIndex = 3
        Me.RBALL.TabStop = True
        Me.RBALL.Text = "List all  item file products"
        Me.RBALL.UseVisualStyleBackColor = True
        '
        'rbcatitemlist
        '
        Me.rbcatitemlist.AutoSize = True
        Me.rbcatitemlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcatitemlist.Location = New System.Drawing.Point(508, 24)
        Me.rbcatitemlist.Name = "rbcatitemlist"
        Me.rbcatitemlist.Size = New System.Drawing.Size(125, 17)
        Me.rbcatitemlist.TabIndex = 5
        Me.rbcatitemlist.TabStop = True
        Me.rbcatitemlist.Text = "Item by Category"
        Me.rbcatitemlist.UseVisualStyleBackColor = True
        '
        'lstCategory
        '
        Me.lstCategory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCategory.FullRowSelect = True
        Me.lstCategory.GridLines = True
        Me.lstCategory.Location = New System.Drawing.Point(20, 11)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(765, 261)
        Me.lstCategory.SmallImageList = Me.ImageList1
        Me.lstCategory.TabIndex = 0
        Me.lstCategory.UseCompatibleStateImageBehavior = False
        Me.lstCategory.View = System.Windows.Forms.View.Details
        '
        'lstItems
        '
        Me.lstItems.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.Location = New System.Drawing.Point(20, 278)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(765, 265)
        Me.lstItems.TabIndex = 0
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'grpcatitem
        '
        Me.grpcatitem.Controls.Add(Me.lstCategory)
        Me.grpcatitem.Controls.Add(Me.PictureBox2)
        Me.grpcatitem.Controls.Add(Me.lstItems)
        Me.grpcatitem.Location = New System.Drawing.Point(0, 0)
        Me.grpcatitem.Name = "grpcatitem"
        Me.grpcatitem.Size = New System.Drawing.Size(789, 549)
        Me.grpcatitem.TabIndex = 4
        Me.grpcatitem.TabStop = False
        Me.grpcatitem.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.prjSalesInventory.My.Resources.Resources.xx
        Me.PictureBox2.Location = New System.Drawing.Point(6, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 85)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpCat)
        Me.GroupBox1.Controls.Add(Me.grpcatitem)
        Me.GroupBox1.Controls.Add(Me.lstCat)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 549)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RBGroup
        '
        Me.RBGroup.AutoSize = True
        Me.RBGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBGroup.Location = New System.Drawing.Point(281, 24)
        Me.RBGroup.Name = "RBGroup"
        Me.RBGroup.Size = New System.Drawing.Size(76, 17)
        Me.RBGroup.TabIndex = 6
        Me.RBGroup.TabStop = True
        Me.RBGroup.Text = "By Group"
        Me.RBGroup.UseVisualStyleBackColor = True
        '
        'FrmCatList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(868, 623)
        Me.Controls.Add(Me.RBGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbcatitemlist)
        Me.Controls.Add(Me.RBCat)
        Me.Controls.Add(Me.RBALL)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCatList"
        Me.Text = "Product Listing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCat.ResumeLayout(False)
        Me.grpCat.PerformLayout()
        Me.grpcatitem.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCat As System.Windows.Forms.ListView
    Friend WithEvents RBCat As System.Windows.Forms.RadioButton
    Friend WithEvents RBALL As System.Windows.Forms.RadioButton
    Friend WithEvents grpCat As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtcatname As System.Windows.Forms.TextBox
    Friend WithEvents rbcatitemlist As System.Windows.Forms.RadioButton
    Friend WithEvents lstCategory As System.Windows.Forms.ListView
    Friend WithEvents lstItems As System.Windows.Forms.ListView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents grpcatitem As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RBGroup As System.Windows.Forms.RadioButton
End Class
