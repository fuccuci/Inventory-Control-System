<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOSCASHIER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPOSCASHIER))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbltotalamount = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblready = New System.Windows.Forms.Label
        Me.lblarrow = New System.Windows.Forms.Label
        Me.lblbarcode = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmdlock = New System.Windows.Forms.Button
        Me.lblreach = New System.Windows.Forms.Label
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdclose = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtreceiptno = New System.Windows.Forms.TextBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lstItems = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.ColName = New System.Windows.Forms.ColumnHeader
        Me.ColDesc = New System.Windows.Forms.ColumnHeader
        Me.ColPrice = New System.Windows.Forms.ColumnHeader
        Me.ColQTY = New System.Windows.Forms.ColumnHeader
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbSelectType = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtamountdue = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txttotalsale = New System.Windows.Forms.TextBox
        Me.txtvat12 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtvatexempt = New System.Windows.Forms.TextBox
        Me.txtvatable = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtbarcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbltotalamount)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblready)
        Me.Panel1.Controls.Add(Me.lblarrow)
        Me.Panel1.Controls.Add(Me.lblbarcode)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(497, 668)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 94)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.BackColor = System.Drawing.Color.Black
        Me.lbltotalamount.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.Color.White
        Me.lbltotalamount.Location = New System.Drawing.Point(464, 36)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(66, 29)
        Me.lbltotalamount.TabIndex = 103
        Me.lbltotalamount.Text = "0.00"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Black
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(480, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 14)
        Me.lbldate.TabIndex = 104
        '
        'lblready
        '
        Me.lblready.AutoSize = True
        Me.lblready.BackColor = System.Drawing.Color.Black
        Me.lblready.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblready.ForeColor = System.Drawing.Color.White
        Me.lblready.Location = New System.Drawing.Point(108, 38)
        Me.lblready.Name = "lblready"
        Me.lblready.Size = New System.Drawing.Size(95, 26)
        Me.lblready.TabIndex = 102
        Me.lblready.Text = "Ready . . ."
        '
        'lblarrow
        '
        Me.lblarrow.AutoSize = True
        Me.lblarrow.BackColor = System.Drawing.Color.Black
        Me.lblarrow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarrow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblarrow.Location = New System.Drawing.Point(19, 42)
        Me.lblarrow.Name = "lblarrow"
        Me.lblarrow.Size = New System.Drawing.Size(74, 19)
        Me.lblarrow.TabIndex = 101
        Me.lblarrow.Text = ">>>>>"
        '
        'lblbarcode
        '
        Me.lblbarcode.AutoSize = True
        Me.lblbarcode.BackColor = System.Drawing.Color.Black
        Me.lblbarcode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbarcode.ForeColor = System.Drawing.Color.White
        Me.lblbarcode.Location = New System.Drawing.Point(10, 7)
        Me.lblbarcode.Name = "lblbarcode"
        Me.lblbarcode.Size = New System.Drawing.Size(0, 19)
        Me.lblbarcode.TabIndex = 100
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(6, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(594, 92)
        Me.TextBox1.TabIndex = 0
        '
        'cmdlock
        '
        Me.cmdlock.Image = CType(resources.GetObject("cmdlock.Image"), System.Drawing.Image)
        Me.cmdlock.Location = New System.Drawing.Point(632, 731)
        Me.cmdlock.Name = "cmdlock"
        Me.cmdlock.Size = New System.Drawing.Size(38, 29)
        Me.cmdlock.TabIndex = 121
        Me.cmdlock.UseVisualStyleBackColor = True
        Me.cmdlock.Visible = False
        '
        'lblreach
        '
        Me.lblreach.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreach.ForeColor = System.Drawing.Color.Red
        Me.lblreach.Location = New System.Drawing.Point(600, 40)
        Me.lblreach.Name = "lblreach"
        Me.lblreach.Size = New System.Drawing.Size(226, 53)
        Me.lblreach.TabIndex = 120
        Me.lblreach.Text = "A product/s reached its " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critical level!"
        Me.lblreach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblreach.Visible = False
        '
        'cmdAccept
        '
        Me.cmdAccept.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccept.ImageKey = "thumbs_up_48.png"
        Me.cmdAccept.ImageList = Me.ImageList1
        Me.cmdAccept.Location = New System.Drawing.Point(22, 521)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(114, 40)
        Me.cmdAccept.TabIndex = 11
        Me.cmdAccept.Text = "   &Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "thumbs_up_48.png")
        '
        'cmdclose
        '
        Me.cmdclose.Location = New System.Drawing.Point(784, 634)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 25)
        Me.cmdclose.TabIndex = 12
        Me.cmdclose.Text = "&Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        Me.cmdclose.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(245, 652)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Receipt No :"
        Me.Label12.Visible = False
        '
        'txtreceiptno
        '
        Me.txtreceiptno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiptno.Location = New System.Drawing.Point(497, 705)
        Me.txtreceiptno.Name = "txtreceiptno"
        Me.txtreceiptno.Size = New System.Drawing.Size(82, 22)
        Me.txtreceiptno.TabIndex = 109
        Me.txtreceiptno.Visible = False
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(631, 638)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 21)
        Me.txtprice.TabIndex = 113
        Me.txtprice.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(604, 608)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Item Description :"
        Me.Label3.Visible = False
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(693, 600)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(200, 21)
        Me.txtdescription.TabIndex = 112
        Me.txtdescription.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 646)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Price :"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 585)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Item ID :"
        Me.Label6.Visible = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(693, 577)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 21)
        Me.txtID.TabIndex = 110
        Me.txtID.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(60, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 23)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Sales Cashiering"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 13)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Product(s) sales transaction"
        '
        'lstItems
        '
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ColName, Me.ColDesc, Me.ColPrice, Me.ColQTY})
        Me.lstItems.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.Location = New System.Drawing.Point(6, 170)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(825, 291)
        Me.lstItems.SmallImageList = Me.ImageList2
        Me.lstItems.TabIndex = 106
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 40
        '
        'ColName
        '
        Me.ColName.Text = "Item Name"
        Me.ColName.Width = 260
        '
        'ColDesc
        '
        Me.ColDesc.Text = "Description"
        Me.ColDesc.Width = 370
        '
        'ColPrice
        '
        Me.ColPrice.Text = "Price"
        Me.ColPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColPrice.Width = 70
        '
        'ColQTY
        '
        Me.ColQTY.Text = "Quantity"
        Me.ColQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "bag1_16.png")
        Me.ImageList2.Images.SetKeyName(1, "billing.png")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblreach)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.lstItems)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(837, 467)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSelectType)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtamountdue)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txttotalsale)
        Me.GroupBox1.Controls.Add(Me.txtvat12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtvatexempt)
        Me.GroupBox1.Controls.Add(Me.txtvatable)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtbarcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 145)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        '
        'cmbSelectType
        '
        Me.cmbSelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectType.FormattingEnabled = True
        Me.cmbSelectType.Items.AddRange(New Object() {"Order No", "Product Barcode"})
        Me.cmbSelectType.Location = New System.Drawing.Point(91, 13)
        Me.cmbSelectType.Name = "cmbSelectType"
        Me.cmbSelectType.Size = New System.Drawing.Size(155, 22)
        Me.cmbSelectType.TabIndex = 137
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 14)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Select Type :"
        '
        'txtamountdue
        '
        Me.txtamountdue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtamountdue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamountdue.ForeColor = System.Drawing.Color.Maroon
        Me.txtamountdue.Location = New System.Drawing.Point(407, 106)
        Me.txtamountdue.Name = "txtamountdue"
        Me.txtamountdue.ReadOnly = True
        Me.txtamountdue.Size = New System.Drawing.Size(162, 27)
        Me.txtamountdue.TabIndex = 130
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(310, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Amount Due :"
        '
        'txttotalsale
        '
        Me.txttotalsale.BackColor = System.Drawing.Color.White
        Me.txttotalsale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalsale.Location = New System.Drawing.Point(407, 59)
        Me.txttotalsale.Name = "txttotalsale"
        Me.txttotalsale.ReadOnly = True
        Me.txttotalsale.Size = New System.Drawing.Size(162, 22)
        Me.txttotalsale.TabIndex = 128
        '
        'txtvat12
        '
        Me.txtvat12.BackColor = System.Drawing.Color.White
        Me.txtvat12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvat12.Location = New System.Drawing.Point(407, 83)
        Me.txtvat12.Name = "txtvat12"
        Me.txtvat12.ReadOnly = True
        Me.txtvat12.Size = New System.Drawing.Size(162, 22)
        Me.txtvat12.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(331, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "VAT - 12 % :"
        '
        'txtvatexempt
        '
        Me.txtvatexempt.BackColor = System.Drawing.Color.White
        Me.txtvatexempt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvatexempt.Location = New System.Drawing.Point(407, 36)
        Me.txtvatexempt.Name = "txtvatexempt"
        Me.txtvatexempt.ReadOnly = True
        Me.txtvatexempt.Size = New System.Drawing.Size(162, 22)
        Me.txtvatexempt.TabIndex = 127
        '
        'txtvatable
        '
        Me.txtvatable.BackColor = System.Drawing.Color.White
        Me.txtvatable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvatable.Location = New System.Drawing.Point(407, 13)
        Me.txtvatable.Name = "txtvatable"
        Me.txtvatable.ReadOnly = True
        Me.txtvatable.Size = New System.Drawing.Size(162, 22)
        Me.txtvatable.TabIndex = 126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "VATable :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(337, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Total Sale :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(301, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "VAT-Exemp Sale :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Quantity :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Item Name :"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(91, 84)
        Me.txtqty.MaxLength = 5
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 22)
        Me.txtqty.TabIndex = 124
        '
        'txtbarcode
        '
        Me.txtbarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbarcode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.Location = New System.Drawing.Point(91, 37)
        Me.txtbarcode.MaxLength = 50
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(155, 22)
        Me.txtbarcode.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Barcode :"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(91, 60)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(190, 22)
        Me.txtname.TabIndex = 122
        '
        'FrmPOSCASHIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(923, 746)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdlock)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtreceiptno)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPOSCASHIER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashiering"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblarrow As System.Windows.Forms.Label
    Friend WithEvents lblbarcode As System.Windows.Forms.Label
    Friend WithEvents lblready As System.Windows.Forms.Label
    Friend WithEvents lbltotalamount As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtreceiptno As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblreach As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdlock As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lstItems As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColQTY As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamountdue As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotalsale As System.Windows.Forms.TextBox
    Friend WithEvents txtvat12 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtvatexempt As System.Windows.Forms.TextBox
    Friend WithEvents txtvatable As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents cmbSelectType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
