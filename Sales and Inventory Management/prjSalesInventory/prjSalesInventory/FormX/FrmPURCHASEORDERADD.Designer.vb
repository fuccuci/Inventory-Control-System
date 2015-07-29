<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPURCHASEORDERADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPURCHASEORDERADD))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtdeliver = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpurchase = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.cmbsupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstitems = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmddel = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.chckapproved = New System.Windows.Forms.CheckBox()
        Me.txtapproved = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dtapprove = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(382, 52)
        Me.Panel1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Product details and items "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 23)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Purchase Detail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.txtdeliver)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpurchase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.cmbsupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstitems)
        Me.GroupBox1.Controls.Add(Me.cmddel)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 351)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(61, 321)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(55, 25)
        Me.cmdEdit.TabIndex = 51
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'txtdeliver
        '
        Me.txtdeliver.Location = New System.Drawing.Point(432, 36)
        Me.txtdeliver.MaxLength = 50
        Me.txtdeliver.Name = "txtdeliver"
        Me.txtdeliver.Size = New System.Drawing.Size(207, 21)
        Me.txtdeliver.TabIndex = 4
        Me.txtdeliver.Text = "Paid after deliver"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(346, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delivery Term :"
        '
        'dtpurchase
        '
        Me.dtpurchase.Enabled = False
        Me.dtpurchase.Location = New System.Drawing.Point(432, 14)
        Me.dtpurchase.Name = "dtpurchase"
        Me.dtpurchase.Size = New System.Drawing.Size(207, 21)
        Me.dtpurchase.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Purchase Date :"
        '
        'txtadd
        '
        Me.txtadd.BackColor = System.Drawing.Color.White
        Me.txtadd.Location = New System.Drawing.Point(92, 36)
        Me.txtadd.MaxLength = 50
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ReadOnly = True
        Me.txtadd.Size = New System.Drawing.Size(217, 46)
        Me.txtadd.TabIndex = 2
        '
        'cmbsupplier
        '
        Me.cmbsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsupplier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsupplier.FormattingEnabled = True
        Me.cmbsupplier.Location = New System.Drawing.Point(92, 14)
        Me.cmbsupplier.Name = "cmbsupplier"
        Me.cmbsupplier.Size = New System.Drawing.Size(217, 21)
        Me.cmbsupplier.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier Name :"
        '
        'lstitems
        '
        Me.lstitems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colD, Me.ColName, Me.ColDesc, Me.ColQTY})
        Me.lstitems.FullRowSelect = True
        Me.lstitems.GridLines = True
        Me.lstitems.Location = New System.Drawing.Point(6, 93)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(760, 222)
        Me.lstitems.TabIndex = 50
        Me.lstitems.UseCompatibleStateImageBehavior = False
        Me.lstitems.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 40
        '
        'colD
        '
        Me.colD.Text = "Detail ID"
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        Me.ColName.Width = 210
        '
        'ColDesc
        '
        Me.ColDesc.Text = "Description"
        Me.ColDesc.Width = 385
        '
        'ColQTY
        '
        Me.ColQTY.Text = "QTY"
        Me.ColQTY.Width = 40
        '
        'cmddel
        '
        Me.cmddel.Location = New System.Drawing.Point(116, 321)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(55, 25)
        Me.cmddel.TabIndex = 6
        Me.cmddel.Text = "&Delete"
        Me.cmddel.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(6, 321)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(55, 25)
        Me.cmdadd.TabIndex = 5
        Me.cmdadd.Text = "&Add"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'chckapproved
        '
        Me.chckapproved.AutoSize = True
        Me.chckapproved.Location = New System.Drawing.Point(12, 409)
        Me.chckapproved.Name = "chckapproved"
        Me.chckapproved.Size = New System.Drawing.Size(149, 17)
        Me.chckapproved.TabIndex = 7
        Me.chckapproved.Text = "Approved and Delivered :"
        Me.chckapproved.UseVisualStyleBackColor = True
        '
        'txtapproved
        '
        Me.txtapproved.Location = New System.Drawing.Point(164, 404)
        Me.txtapproved.Name = "txtapproved"
        Me.txtapproved.Size = New System.Drawing.Size(148, 21)
        Me.txtapproved.TabIndex = 8
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(516, 401)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(60, 25)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(582, 401)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 25)
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'dtapprove
        '
        Me.dtapprove.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtapprove.Location = New System.Drawing.Point(407, 406)
        Me.dtapprove.Name = "dtapprove"
        Me.dtapprove.Size = New System.Drawing.Size(94, 21)
        Me.dtapprove.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Received Date :"
        '
        'FrmPURCHASEORDERADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(778, 436)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtapprove)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtapproved)
        Me.Controls.Add(Me.chckapproved)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPURCHASEORDERADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstitems As System.Windows.Forms.ListView
    Friend WithEvents cmddel As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents chckapproved As System.Windows.Forms.CheckBox
    Friend WithEvents txtapproved As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents dtpurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents cmbsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtapprove As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdeliver As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents colD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColQTY As System.Windows.Forms.ColumnHeader
End Class
