﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDEFFECTIVE_RETURN_STOCK_LIST
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
        Me.ColQTY = New System.Windows.Forms.ColumnHeader
        Me.lstitems = New System.Windows.Forms.ListView
        Me.colID = New System.Windows.Forms.ColumnHeader
        Me.colD = New System.Windows.Forms.ColumnHeader
        Me.ColName = New System.Windows.Forms.ColumnHeader
        Me.colcurrent = New System.Windows.Forms.ColumnHeader
        Me.ColPrice = New System.Windows.Forms.ColumnHeader
        Me.ColBarcode = New System.Windows.Forms.ColumnHeader
        Me.colMeasure = New System.Windows.Forms.ColumnHeader
        Me.cmdselect = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ColQTY
        '
        Me.ColQTY.Text = "QTY"
        Me.ColQTY.Width = 40
        '
        'lstitems
        '
        Me.lstitems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colD, Me.ColName, Me.colcurrent, Me.ColPrice, Me.ColBarcode, Me.ColQTY, Me.colMeasure})
        Me.lstitems.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstitems.FullRowSelect = True
        Me.lstitems.GridLines = True
        Me.lstitems.Location = New System.Drawing.Point(6, 6)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(753, 318)
        Me.lstitems.TabIndex = 54
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
        Me.ColName.Width = 240
        '
        'colcurrent
        '
        Me.colcurrent.Text = "Current QTY"
        Me.colcurrent.Width = 80
        '
        'ColPrice
        '
        Me.ColPrice.Text = "Price"
        Me.ColPrice.Width = 80
        '
        'ColBarcode
        '
        Me.ColBarcode.Text = "Barcode"
        Me.ColBarcode.Width = 110
        '
        'colMeasure
        '
        Me.colMeasure.Text = "Unit"
        '
        'cmdselect
        '
        Me.cmdselect.Location = New System.Drawing.Point(6, 330)
        Me.cmdselect.Name = "cmdselect"
        Me.cmdselect.Size = New System.Drawing.Size(59, 25)
        Me.cmdselect.TabIndex = 55
        Me.cmdselect.Text = "&Select"
        Me.cmdselect.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(71, 330)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(59, 25)
        Me.cmdcancel.TabIndex = 56
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'FrmDEFFECTIVE_RETURN_STOCK_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(763, 365)
        Me.Controls.Add(Me.lstitems)
        Me.Controls.Add(Me.cmdselect)
        Me.Controls.Add(Me.cmdcancel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDEFFECTIVE_RETURN_STOCK_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColQTY As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstitems As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colcurrent As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColBarcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMeasure As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdselect As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
End Class
