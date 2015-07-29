<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPURCHASEORDER_RECEIPT_ADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPURCHASEORDER_RECEIPT_ADD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPO = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstitems = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColReceived = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.lbWarehouse = New System.Windows.Forms.Label()
        Me.cboWarehouse = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmddel = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboPO)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtReceiveDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lstitems)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.lbWarehouse)
        Me.GroupBox1.Controls.Add(Me.cboWarehouse)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.cmddel)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 372)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Select PO:"
        '
        'cboPO
        '
        Me.cboPO.FormattingEnabled = True
        Me.cboPO.Location = New System.Drawing.Point(426, 35)
        Me.cboPO.Name = "cboPO"
        Me.cboPO.Size = New System.Drawing.Size(141, 21)
        Me.cboPO.TabIndex = 66
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(630, 12)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(276, 43)
        Me.txtNotes.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(586, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Notes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Received Date :"
        '
        'dtReceiveDate
        '
        Me.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceiveDate.Location = New System.Drawing.Point(426, 12)
        Me.dtReceiveDate.Name = "dtReceiveDate"
        Me.dtReceiveDate.Size = New System.Drawing.Size(141, 20)
        Me.dtReceiveDate.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Select Supplier:"
        '
        'lstitems
        '
        Me.lstitems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colD, Me.ColName, Me.ColDesc, Me.ColQTY, Me.ColReceived})
        Me.lstitems.FullRowSelect = True
        Me.lstitems.GridLines = True
        Me.lstitems.Location = New System.Drawing.Point(6, 62)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(903, 269)
        Me.lstitems.TabIndex = 51
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
        Me.ColDesc.Width = 300
        '
        'ColQTY
        '
        Me.ColQTY.Text = "QTY"
        Me.ColQTY.Width = 68
        '
        'ColReceived
        '
        Me.ColReceived.Text = "RECEIVED"
        Me.ColReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColReceived.Width = 70
        '
        'cboSupplier
        '
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(117, 12)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(212, 21)
        Me.cboSupplier.TabIndex = 60
        '
        'lbWarehouse
        '
        Me.lbWarehouse.AutoSize = True
        Me.lbWarehouse.Location = New System.Drawing.Point(10, 42)
        Me.lbWarehouse.Name = "lbWarehouse"
        Me.lbWarehouse.Size = New System.Drawing.Size(98, 13)
        Me.lbWarehouse.TabIndex = 59
        Me.lbWarehouse.Text = "Select Warehouse:"
        '
        'cboWarehouse
        '
        Me.cboWarehouse.FormattingEnabled = True
        Me.cboWarehouse.Location = New System.Drawing.Point(117, 37)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(212, 21)
        Me.cboWarehouse.TabIndex = 58
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(846, 341)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 25)
        Me.cmdCancel.TabIndex = 57
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(780, 341)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(60, 25)
        Me.cmdSave.TabIndex = 56
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(62, 341)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(55, 25)
        Me.cmdEdit.TabIndex = 55
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmddel
        '
        Me.cmddel.Location = New System.Drawing.Point(117, 341)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(55, 25)
        Me.cmddel.TabIndex = 54
        Me.cmddel.Text = "&Delete"
        Me.cmddel.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(7, 341)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(55, 25)
        Me.cmdadd.TabIndex = 53
        Me.cmdadd.Text = "&Add"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 52)
        Me.Panel2.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Product details receipt by lines "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(58, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Purchase Receipt Add"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FrmPURCHASEORDER_RECEIPT_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 460)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPURCHASEORDER_RECEIPT_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmPURCHASEORDER_RECEIPT_ADD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstitems As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColQTY As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmddel As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lbWarehouse As System.Windows.Forms.Label
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents dtReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColReceived As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPO As System.Windows.Forms.ComboBox
End Class
