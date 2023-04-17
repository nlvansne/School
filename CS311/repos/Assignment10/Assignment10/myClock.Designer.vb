<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myClock
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.timerMyClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'timerMyClock
        '
        Me.timerMyClock.Enabled = True
        Me.timerMyClock.Interval = 1000
        '
        'myClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "myClock"
        Me.Size = New System.Drawing.Size(140, 45)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timerMyClock As Timer
End Class
