﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDEFFECTIVE_STOCKS_ADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDEFFECTIVE_STOCKS_ADD))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtpo2 = New System.Windows.Forms.TextBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.txtSuppname = New System.Windows.Forms.TextBox
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.txtpo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtdeliver = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtRETURN = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstitems = New System.Windows.Forms.ListView
        Me.colID = New System.Windows.Forms.ColumnHeader
        Me.colD = New System.Windows.Forms.ColumnHeader
        Me.ColName = New System.Windows.Forms.ColumnHeader
        Me.ColDesc = New System.Windows.Forms.ColumnHeader
        Me.ColPrice = New System.Windows.Forms.ColumnHeader
        Me.ColQTY = New System.Windows.Forms.ColumnHeader
        Me.colDeffect = New System.Windows.Forms.ColumnHeader
        Me.colMeasure = New System.Windows.Forms.ColumnHeader
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
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 51)
        Me.Panel1.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Control current stocks with defective quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(60, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Defective Stocks Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpo2)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.txtSuppname)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.txtpo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtdeliver)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtRETURN)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstitems)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 387)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'txtpo2
        '
        Me.txtpo2.Location = New System.Drawing.Point(248, 10)
        Me.txtpo2.Name = "txtpo2"
        Me.txtpo2.Size = New System.Drawing.Size(100, 21)
        Me.txtpo2.TabIndex = 65
        Me.txtpo2.Text = "0"
        Me.txtpo2.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(10, 355)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(53, 26)
        Me.cmdAdd.TabIndex = 64
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtSuppname
        '
        Me.txtSuppname.BackColor = System.Drawing.Color.White
        Me.txtSuppname.Location = New System.Drawing.Point(122, 37)
        Me.txtSuppname.MaxLength = 50
        Me.txtSuppname.Name = "txtSuppname"
        Me.txtSuppname.ReadOnly = True
        Me.txtSuppname.Size = New System.Drawing.Size(217, 21)
        Me.txtSuppname.TabIndex = 63
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(67, 355)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(55, 26)
        Me.cmdEdit.TabIndex = 6
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'txtpo
        '
        Me.txtpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpo.Location = New System.Drawing.Point(122, 13)
        Me.txtpo.Name = "txtpo"
        Me.txtpo.ReadOnly = True
        Me.txtpo.Size = New System.Drawing.Size(100, 22)
        Me.txtpo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Purchase ID :"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(704, 355)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 26)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(638, 355)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(60, 26)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtdeliver
        '
        Me.txtdeliver.Location = New System.Drawing.Point(467, 57)
        Me.txtdeliver.MaxLength = 50
        Me.txtdeliver.Name = "txtdeliver"
        Me.txtdeliver.Size = New System.Drawing.Size(207, 21)
        Me.txtdeliver.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delivery Term :"
        '
        'dtRETURN
        '
        Me.dtRETURN.Location = New System.Drawing.Point(467, 35)
        Me.dtRETURN.Name = "dtRETURN"
        Me.dtRETURN.Size = New System.Drawing.Size(207, 21)
        Me.dtRETURN.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Return Date :"
        '
        'txtadd
        '
        Me.txtadd.BackColor = System.Drawing.Color.White
        Me.txtadd.Location = New System.Drawing.Point(122, 60)
        Me.txtadd.MaxLength = 50
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ReadOnly = True
        Me.txtadd.Size = New System.Drawing.Size(217, 47)
        Me.txtadd.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier Name :"
        '
        'lstitems
        '
        Me.lstitems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colD, Me.ColName, Me.ColDesc, Me.ColPrice, Me.ColQTY, Me.colDeffect, Me.colMeasure})
        Me.lstitems.FullRowSelect = True
        Me.lstitems.GridLines = True
        Me.lstitems.Location = New System.Drawing.Point(6, 126)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(760, 223)
        Me.lstitems.TabIndex = 5
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
        Me.ColName.Width = 160
        '
        'ColDesc
        '
        Me.ColDesc.Text = "Description"
        Me.ColDesc.Width = 180
        '
        'ColPrice
        '
        Me.ColPrice.Text = "Price"
        Me.ColPrice.Width = 80
        '
        'ColQTY
        '
        Me.ColQTY.Text = "Current QTY"
        Me.ColQTY.Width = 75
        '
        'colDeffect
        '
        Me.colDeffect.Text = "Defect QTY"
        Me.colDeffect.Width = 75
        '
        'colMeasure
        '
        Me.colMeasure.Text = "Unit"
        '
        'FrmDEFFECTIVE_STOCKS_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(778, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDEFFECTIVE_STOCKS_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Defective Stock Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents txtdeliver As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtRETURN As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstitems As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColQTY As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMeasure As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents colDeffect As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtpo As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppname As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents txtpo2 As System.Windows.Forms.TextBox
End Class
