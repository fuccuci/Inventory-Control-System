<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarcode))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdremove = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.lstbarcode = New System.Windows.Forms.ListView
        Me.colBarcode = New System.Windows.Forms.ColumnHeader
        Me.colname = New System.Windows.Forms.ColumnHeader
        Me.coldesc = New System.Windows.Forms.ColumnHeader
        Me.lstitem = New System.Windows.Forms.ListView
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbsingle = New System.Windows.Forms.RadioButton
        Me.rbmultiple = New System.Windows.Forms.RadioButton
        Me.cmdok = New System.Windows.Forms.Button
        Me.cmdcancel2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpcs = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdremove)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Controls.Add(Me.lstbarcode)
        Me.GroupBox1.Controls.Add(Me.lstitem)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdremove
        '
        Me.cmdremove.Location = New System.Drawing.Point(340, 169)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(49, 23)
        Me.cmdremove.TabIndex = 3
        Me.cmdremove.Text = "<<"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(340, 140)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(49, 23)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = ">>"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'lstbarcode
        '
        Me.lstbarcode.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBarcode, Me.colname, Me.coldesc})
        Me.lstbarcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbarcode.FullRowSelect = True
        Me.lstbarcode.GridLines = True
        Me.lstbarcode.Location = New System.Drawing.Point(395, 19)
        Me.lstbarcode.Name = "lstbarcode"
        Me.lstbarcode.Size = New System.Drawing.Size(343, 313)
        Me.lstbarcode.TabIndex = 1
        Me.lstbarcode.UseCompatibleStateImageBehavior = False
        Me.lstbarcode.View = System.Windows.Forms.View.Details
        '
        'colBarcode
        '
        Me.colBarcode.Text = "Barcode"
        Me.colBarcode.Width = 100
        '
        'colname
        '
        Me.colname.Text = "Name"
        Me.colname.Width = 120
        '
        'coldesc
        '
        Me.coldesc.Text = "Description"
        Me.coldesc.Width = 100
        '
        'lstitem
        '
        Me.lstitem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstitem.FullRowSelect = True
        Me.lstitem.GridLines = True
        Me.lstitem.Location = New System.Drawing.Point(6, 19)
        Me.lstitem.Name = "lstitem"
        Me.lstitem.Size = New System.Drawing.Size(328, 313)
        Me.lstitem.TabIndex = 0
        Me.lstitem.UseCompatibleStateImageBehavior = False
        Me.lstitem.View = System.Windows.Forms.View.Details
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(597, 382)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 27)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(678, 382)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 27)
        Me.cmdcancel.TabIndex = 2
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(7, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select item and print them with their corresponding barcodes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(52, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barcodes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpcs)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdcancel2)
        Me.GroupBox2.Controls.Add(Me.cmdok)
        Me.GroupBox2.Controls.Add(Me.rbmultiple)
        Me.GroupBox2.Controls.Add(Me.rbsingle)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(202, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 125)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Printing Option"
        '
        'rbsingle
        '
        Me.rbsingle.AutoSize = True
        Me.rbsingle.Checked = True
        Me.rbsingle.Location = New System.Drawing.Point(16, 20)
        Me.rbsingle.Name = "rbsingle"
        Me.rbsingle.Size = New System.Drawing.Size(159, 17)
        Me.rbsingle.TabIndex = 0
        Me.rbsingle.TabStop = True
        Me.rbsingle.Text = "Print per single barcode"
        Me.rbsingle.UseVisualStyleBackColor = True
        '
        'rbmultiple
        '
        Me.rbmultiple.AutoSize = True
        Me.rbmultiple.Location = New System.Drawing.Point(16, 43)
        Me.rbmultiple.Name = "rbmultiple"
        Me.rbmultiple.Size = New System.Drawing.Size(192, 17)
        Me.rbmultiple.TabIndex = 1
        Me.rbmultiple.TabStop = True
        Me.rbmultiple.Text = "Print multiple no. per barcode"
        Me.rbmultiple.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(184, 89)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 27)
        Me.cmdok.TabIndex = 2
        Me.cmdok.Text = "&Ok"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'cmdcancel2
        '
        Me.cmdcancel2.Location = New System.Drawing.Point(265, 89)
        Me.cmdcancel2.Name = "cmdcancel2"
        Me.cmdcancel2.Size = New System.Drawing.Size(75, 27)
        Me.cmdcancel2.TabIndex = 3
        Me.cmdcancel2.Text = "&Cancel"
        Me.cmdcancel2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of pcs per barcode :"
        '
        'txtpcs
        '
        Me.txtpcs.Enabled = False
        Me.txtpcs.Location = New System.Drawing.Point(172, 60)
        Me.txtpcs.Name = "txtpcs"
        Me.txtpcs.Size = New System.Drawing.Size(100, 21)
        Me.txtpcs.TabIndex = 5
        '
        'FrmBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(765, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdremove As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents lstbarcode As System.Windows.Forms.ListView
    Friend WithEvents lstitem As System.Windows.Forms.ListView
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents colBarcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colname As System.Windows.Forms.ColumnHeader
    Friend WithEvents coldesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents rbmultiple As System.Windows.Forms.RadioButton
    Friend WithEvents rbsingle As System.Windows.Forms.RadioButton
    Friend WithEvents txtpcs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdcancel2 As System.Windows.Forms.Button
End Class
