<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KustomKarzInvoiceForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmitToManufacturing = New System.Windows.Forms.Button()
        Me.btnChangeOrder = New System.Windows.Forms.Button()
        Me.txtDisplayInvoice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(506, 509)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 45)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmitToManufacturing
        '
        Me.btnSubmitToManufacturing.Location = New System.Drawing.Point(234, 509)
        Me.btnSubmitToManufacturing.Name = "btnSubmitToManufacturing"
        Me.btnSubmitToManufacturing.Size = New System.Drawing.Size(191, 45)
        Me.btnSubmitToManufacturing.TabIndex = 10
        Me.btnSubmitToManufacturing.Text = "Submit To Manufacturing"
        Me.btnSubmitToManufacturing.UseVisualStyleBackColor = True
        '
        'btnChangeOrder
        '
        Me.btnChangeOrder.Location = New System.Drawing.Point(12, 509)
        Me.btnChangeOrder.Name = "btnChangeOrder"
        Me.btnChangeOrder.Size = New System.Drawing.Size(141, 45)
        Me.btnChangeOrder.TabIndex = 9
        Me.btnChangeOrder.Text = "Change Order"
        Me.btnChangeOrder.UseVisualStyleBackColor = True
        '
        'txtDisplayInvoice
        '
        Me.txtDisplayInvoice.Location = New System.Drawing.Point(12, 12)
        Me.txtDisplayInvoice.Multiline = True
        Me.txtDisplayInvoice.Name = "txtDisplayInvoice"
        Me.txtDisplayInvoice.ReadOnly = True
        Me.txtDisplayInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplayInvoice.Size = New System.Drawing.Size(635, 472)
        Me.txtDisplayInvoice.TabIndex = 8
        '
        'KustomKarzInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 566)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmitToManufacturing)
        Me.Controls.Add(Me.btnChangeOrder)
        Me.Controls.Add(Me.txtDisplayInvoice)
        Me.Name = "KustomKarzInvoiceForm"
        Me.Text = "KustomKarzInvoiceForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmitToManufacturing As Button
    Friend WithEvents btnChangeOrder As Button
    Friend WithEvents txtDisplayInvoice As TextBox
End Class
