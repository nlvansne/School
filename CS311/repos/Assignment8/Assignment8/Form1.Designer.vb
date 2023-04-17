<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbOwnerInfo = New System.Windows.Forms.GroupBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.txtNameLast = New System.Windows.Forms.TextBox()
        Me.txtNameFirst = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.btnFirstRec = New System.Windows.Forms.Button()
        Me.btnLastRec = New System.Windows.Forms.Button()
        Me.btnPreviousRec = New System.Windows.Forms.Button()
        Me.btnNextRec = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.pnlRecordButtons = New System.Windows.Forms.Panel()
        Me.pnlSaveRecord = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbOwnerInfo.SuspendLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecordButtons.SuspendLayout()
        Me.pnlSaveRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOwnerInfo
        '
        Me.gbOwnerInfo.Controls.Add(Me.txtZipCode)
        Me.gbOwnerInfo.Controls.Add(Me.txtState)
        Me.gbOwnerInfo.Controls.Add(Me.txtCity)
        Me.gbOwnerInfo.Controls.Add(Me.txtAddress)
        Me.gbOwnerInfo.Controls.Add(Me.lblAddress)
        Me.gbOwnerInfo.Controls.Add(Me.txtIDNumber)
        Me.gbOwnerInfo.Controls.Add(Me.lblIDNumber)
        Me.gbOwnerInfo.Controls.Add(Me.txtNameLast)
        Me.gbOwnerInfo.Controls.Add(Me.txtNameFirst)
        Me.gbOwnerInfo.Controls.Add(Me.lblName)
        Me.gbOwnerInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbOwnerInfo.Name = "gbOwnerInfo"
        Me.gbOwnerInfo.Size = New System.Drawing.Size(799, 302)
        Me.gbOwnerInfo.TabIndex = 0
        Me.gbOwnerInfo.TabStop = False
        Me.gbOwnerInfo.Text = "Owner Information"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(391, 95)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(152, 22)
        Me.txtZipCode.TabIndex = 6
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(320, 95)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(65, 22)
        Me.txtState.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(97, 95)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(217, 22)
        Me.txtCity.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(97, 67)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(446, 22)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(17, 70)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 16)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address:"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(679, 39)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.ReadOnly = True
        Me.txtIDNumber.Size = New System.Drawing.Size(94, 22)
        Me.txtIDNumber.TabIndex = 0
        Me.txtIDNumber.TabStop = False
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(599, 42)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(74, 16)
        Me.lblIDNumber.TabIndex = 3
        Me.lblIDNumber.Text = "ID Number:"
        '
        'txtNameLast
        '
        Me.txtNameLast.Location = New System.Drawing.Point(320, 39)
        Me.txtNameLast.Name = "txtNameLast"
        Me.txtNameLast.Size = New System.Drawing.Size(223, 22)
        Me.txtNameLast.TabIndex = 2
        '
        'txtNameFirst
        '
        Me.txtNameFirst.Location = New System.Drawing.Point(97, 39)
        Me.txtNameFirst.Name = "txtNameFirst"
        Me.txtNameFirst.Size = New System.Drawing.Size(217, 22)
        Me.txtNameFirst.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(31, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'dgvVehicles
        '
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Location = New System.Drawing.Point(18, 332)
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.RowHeadersWidth = 51
        Me.dgvVehicles.RowTemplate.Height = 24
        Me.dgvVehicles.Size = New System.Drawing.Size(793, 287)
        Me.dgvVehicles.TabIndex = 1
        Me.dgvVehicles.TabStop = False
        '
        'btnFirstRec
        '
        Me.btnFirstRec.Location = New System.Drawing.Point(59, 26)
        Me.btnFirstRec.Name = "btnFirstRec"
        Me.btnFirstRec.Size = New System.Drawing.Size(36, 46)
        Me.btnFirstRec.TabIndex = 7
        Me.btnFirstRec.Text = "<l"
        Me.btnFirstRec.UseVisualStyleBackColor = True
        '
        'btnLastRec
        '
        Me.btnLastRec.Location = New System.Drawing.Point(701, 26)
        Me.btnLastRec.Name = "btnLastRec"
        Me.btnLastRec.Size = New System.Drawing.Size(36, 46)
        Me.btnLastRec.TabIndex = 13
        Me.btnLastRec.Text = "l>"
        Me.btnLastRec.UseVisualStyleBackColor = True
        '
        'btnPreviousRec
        '
        Me.btnPreviousRec.Location = New System.Drawing.Point(101, 26)
        Me.btnPreviousRec.Name = "btnPreviousRec"
        Me.btnPreviousRec.Size = New System.Drawing.Size(36, 46)
        Me.btnPreviousRec.TabIndex = 8
        Me.btnPreviousRec.Text = "<<"
        Me.btnPreviousRec.UseVisualStyleBackColor = True
        '
        'btnNextRec
        '
        Me.btnNextRec.Location = New System.Drawing.Point(659, 26)
        Me.btnNextRec.Name = "btnNextRec"
        Me.btnNextRec.Size = New System.Drawing.Size(36, 46)
        Me.btnNextRec.TabIndex = 12
        Me.btnNextRec.Text = ">>"
        Me.btnNextRec.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(229, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 46)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(362, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 46)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(494, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 46)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'pnlRecordButtons
        '
        Me.pnlRecordButtons.Controls.Add(Me.btnLastRec)
        Me.pnlRecordButtons.Controls.Add(Me.btnUpdate)
        Me.pnlRecordButtons.Controls.Add(Me.btnFirstRec)
        Me.pnlRecordButtons.Controls.Add(Me.btnDelete)
        Me.pnlRecordButtons.Controls.Add(Me.btnPreviousRec)
        Me.pnlRecordButtons.Controls.Add(Me.btnAdd)
        Me.pnlRecordButtons.Controls.Add(Me.btnNextRec)
        Me.pnlRecordButtons.Location = New System.Drawing.Point(18, 135)
        Me.pnlRecordButtons.Name = "pnlRecordButtons"
        Me.pnlRecordButtons.Size = New System.Drawing.Size(787, 100)
        Me.pnlRecordButtons.TabIndex = 17
        '
        'pnlSaveRecord
        '
        Me.pnlSaveRecord.Controls.Add(Me.btnCancel)
        Me.pnlSaveRecord.Controls.Add(Me.btnSave)
        Me.pnlSaveRecord.Location = New System.Drawing.Point(18, 241)
        Me.pnlSaveRecord.Name = "pnlSaveRecord"
        Me.pnlSaveRecord.Size = New System.Drawing.Size(787, 73)
        Me.pnlSaveRecord.TabIndex = 17
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(494, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 31)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(157, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 31)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 631)
        Me.Controls.Add(Me.pnlSaveRecord)
        Me.Controls.Add(Me.pnlRecordButtons)
        Me.Controls.Add(Me.dgvVehicles)
        Me.Controls.Add(Me.gbOwnerInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbOwnerInfo.ResumeLayout(False)
        Me.gbOwnerInfo.PerformLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecordButtons.ResumeLayout(False)
        Me.pnlSaveRecord.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbOwnerInfo As GroupBox
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents lblIDNumber As Label
    Friend WithEvents txtNameLast As TextBox
    Friend WithEvents txtNameFirst As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents btnFirstRec As Button
    Friend WithEvents btnLastRec As Button
    Friend WithEvents btnNextRec As Button
    Friend WithEvents btnPreviousRec As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlSaveRecord As Panel
    Friend WithEvents pnlRecordButtons As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
