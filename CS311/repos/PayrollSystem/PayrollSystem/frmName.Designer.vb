<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmName
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.lblHourlyWage = New System.Windows.Forms.Label()
        Me.chkSalariedPosition = New System.Windows.Forms.CheckBox()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.btnCalculateWage = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnAddNewEmployee = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(92, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 22)
        Me.txtName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(92, 70)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(247, 22)
        Me.txtID.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 73)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 17)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(92, 116)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(247, 22)
        Me.txtHours.TabIndex = 5
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(12, 119)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(50, 17)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Hours:"
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(92, 161)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(247, 22)
        Me.txtWage.TabIndex = 7
        '
        'lblHourlyWage
        '
        Me.lblHourlyWage.AutoSize = True
        Me.lblHourlyWage.Location = New System.Drawing.Point(12, 164)
        Me.lblHourlyWage.Name = "lblHourlyWage"
        Me.lblHourlyWage.Size = New System.Drawing.Size(49, 17)
        Me.lblHourlyWage.TabIndex = 6
        Me.lblHourlyWage.Text = "Wage:"
        '
        'chkSalariedPosition
        '
        Me.chkSalariedPosition.AutoSize = True
        Me.chkSalariedPosition.Location = New System.Drawing.Point(15, 216)
        Me.chkSalariedPosition.Name = "chkSalariedPosition"
        Me.chkSalariedPosition.Size = New System.Drawing.Size(144, 21)
        Me.chkSalariedPosition.TabIndex = 8
        Me.chkSalariedPosition.Text = "Salaried Position?"
        Me.chkSalariedPosition.UseVisualStyleBackColor = True
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Location = New System.Drawing.Point(233, 217)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(0, 17)
        Me.lblWage.TabIndex = 9
        '
        'btnCalculateWage
        '
        Me.btnCalculateWage.Location = New System.Drawing.Point(15, 261)
        Me.btnCalculateWage.Name = "btnCalculateWage"
        Me.btnCalculateWage.Size = New System.Drawing.Size(442, 43)
        Me.btnCalculateWage.TabIndex = 10
        Me.btnCalculateWage.Text = "Calculate Wage"
        Me.btnCalculateWage.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(15, 324)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(126, 46)
        Me.btnLeft.TabIndex = 11
        Me.btnLeft.Text = "<<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnAddNewEmployee
        '
        Me.btnAddNewEmployee.Location = New System.Drawing.Point(174, 324)
        Me.btnAddNewEmployee.Name = "btnAddNewEmployee"
        Me.btnAddNewEmployee.Size = New System.Drawing.Size(126, 46)
        Me.btnAddNewEmployee.TabIndex = 12
        Me.btnAddNewEmployee.Text = "Add New Employee"
        Me.btnAddNewEmployee.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(331, 324)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(126, 46)
        Me.btnRight.TabIndex = 13
        Me.btnRight.Text = ">>"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(15, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 48)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(257, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 48)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 446)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnAddNewEmployee)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnCalculateWage)
        Me.Controls.Add(Me.lblWage)
        Me.Controls.Add(Me.chkSalariedPosition)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.lblHourlyWage)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMain"
        Me.Text = "Payroll System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents txtWage As TextBox
    Friend WithEvents lblHourlyWage As Label
    Friend WithEvents chkSalariedPosition As CheckBox
    Friend WithEvents lblWage As Label
    Friend WithEvents btnCalculateWage As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnAddNewEmployee As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
