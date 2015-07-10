<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPENDING_STOCK_LIST
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
        Me.lstdeffect = New System.Windows.Forms.ListView
        Me.cmdselect = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstdeffect
        '
        Me.lstdeffect.FullRowSelect = True
        Me.lstdeffect.GridLines = True
        Me.lstdeffect.Location = New System.Drawing.Point(2, 3)
        Me.lstdeffect.Name = "lstdeffect"
        Me.lstdeffect.Size = New System.Drawing.Size(570, 283)
        Me.lstdeffect.TabIndex = 0
        Me.lstdeffect.UseCompatibleStateImageBehavior = False
        Me.lstdeffect.View = System.Windows.Forms.View.Details
        '
        'cmdselect
        '
        Me.cmdselect.Location = New System.Drawing.Point(2, 292)
        Me.cmdselect.Name = "cmdselect"
        Me.cmdselect.Size = New System.Drawing.Size(62, 25)
        Me.cmdselect.TabIndex = 1
        Me.cmdselect.Text = "&Select"
        Me.cmdselect.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(70, 292)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(62, 25)
        Me.cmdcancel.TabIndex = 2
        Me.cmdcancel.Text = "&Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'FrmPENDING_STOCK_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(575, 323)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdselect)
        Me.Controls.Add(Me.lstdeffect)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPENDING_STOCK_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pending List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstdeffect As System.Windows.Forms.ListView
    Friend WithEvents cmdselect As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
End Class
