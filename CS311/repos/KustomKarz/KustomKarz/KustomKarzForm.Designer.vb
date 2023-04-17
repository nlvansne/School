<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KustomKarzForm
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
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.updQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lstCarType = New System.Windows.Forms.ListBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.chkEntertainmentPackage = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.chkBluetooth = New System.Windows.Forms.CheckBox()
        Me.chkCDMP3Connections = New System.Windows.Forms.CheckBox()
        Me.chkPremiumStereo = New System.Windows.Forms.CheckBox()
        Me.chkAirConditioning = New System.Windows.Forms.CheckBox()
        Me.chkRearDefroster = New System.Windows.Forms.CheckBox()
        Me.chkHeatedSeats = New System.Windows.Forms.CheckBox()
        Me.chkLeatherSeats = New System.Windows.Forms.CheckBox()
        Me.gbDriveTrainSelect = New System.Windows.Forms.GroupBox()
        Me.rbElectric = New System.Windows.Forms.RadioButton()
        Me.rbHybrid = New System.Windows.Forms.RadioButton()
        Me.rbV4 = New System.Windows.Forms.RadioButton()
        Me.rbV6 = New System.Windows.Forms.RadioButton()
        Me.rbV8 = New System.Windows.Forms.RadioButton()
        Me.rbV12 = New System.Windows.Forms.RadioButton()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnPlaceCarOrder = New System.Windows.Forms.Button()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.gbDriveTrainSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(331, 63)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(69, 17)
        Me.lblQuantity.TabIndex = 40
        Me.lblQuantity.Text = "Quantity :"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(12, 65)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(74, 17)
        Me.lblCarType.TabIndex = 39
        Me.lblCarType.Text = "Car Type :"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(12, 19)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(117, 17)
        Me.lblCustomerName.TabIndex = 37
        Me.lblCustomerName.Text = "Customer Name :"
        '
        'updQuantity
        '
        Me.updQuantity.Location = New System.Drawing.Point(411, 60)
        Me.updQuantity.Name = "updQuantity"
        Me.updQuantity.Size = New System.Drawing.Size(108, 22)
        Me.updQuantity.TabIndex = 41
        '
        'lstCarType
        '
        Me.lstCarType.FormattingEnabled = True
        Me.lstCarType.ItemHeight = 16
        Me.lstCarType.Items.AddRange(New Object() {"Coupe", "Luxury", "Sedan", "Sports Edition", "SUV"})
        Me.lstCarType.Location = New System.Drawing.Point(92, 56)
        Me.lstCarType.Name = "lstCarType"
        Me.lstCarType.Size = New System.Drawing.Size(155, 36)
        Me.lstCarType.TabIndex = 44
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.chkEntertainmentPackage)
        Me.gbOptions.Controls.Add(Me.chkGPS)
        Me.gbOptions.Controls.Add(Me.chkBluetooth)
        Me.gbOptions.Controls.Add(Me.chkCDMP3Connections)
        Me.gbOptions.Controls.Add(Me.chkPremiumStereo)
        Me.gbOptions.Controls.Add(Me.chkAirConditioning)
        Me.gbOptions.Controls.Add(Me.chkRearDefroster)
        Me.gbOptions.Controls.Add(Me.chkHeatedSeats)
        Me.gbOptions.Controls.Add(Me.chkLeatherSeats)
        Me.gbOptions.Location = New System.Drawing.Point(15, 200)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(506, 151)
        Me.gbOptions.TabIndex = 43
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'chkEntertainmentPackage
        '
        Me.chkEntertainmentPackage.AutoSize = True
        Me.chkEntertainmentPackage.Location = New System.Drawing.Point(327, 107)
        Me.chkEntertainmentPackage.Name = "chkEntertainmentPackage"
        Me.chkEntertainmentPackage.Size = New System.Drawing.Size(177, 21)
        Me.chkEntertainmentPackage.TabIndex = 8
        Me.chkEntertainmentPackage.Text = "Entertainment Package"
        Me.chkEntertainmentPackage.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(327, 69)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(59, 21)
        Me.chkGPS.TabIndex = 7
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'chkBluetooth
        '
        Me.chkBluetooth.AutoSize = True
        Me.chkBluetooth.Location = New System.Drawing.Point(327, 32)
        Me.chkBluetooth.Name = "chkBluetooth"
        Me.chkBluetooth.Size = New System.Drawing.Size(90, 21)
        Me.chkBluetooth.TabIndex = 6
        Me.chkBluetooth.Text = "Bluetooth"
        Me.chkBluetooth.UseVisualStyleBackColor = True
        '
        'chkCDMP3Connections
        '
        Me.chkCDMP3Connections.AutoSize = True
        Me.chkCDMP3Connections.Location = New System.Drawing.Point(158, 107)
        Me.chkCDMP3Connections.Name = "chkCDMP3Connections"
        Me.chkCDMP3Connections.Size = New System.Drawing.Size(163, 21)
        Me.chkCDMP3Connections.TabIndex = 5
        Me.chkCDMP3Connections.Text = "CD/MP3 Connections"
        Me.chkCDMP3Connections.UseVisualStyleBackColor = True
        '
        'chkPremiumStereo
        '
        Me.chkPremiumStereo.AutoSize = True
        Me.chkPremiumStereo.Location = New System.Drawing.Point(158, 69)
        Me.chkPremiumStereo.Name = "chkPremiumStereo"
        Me.chkPremiumStereo.Size = New System.Drawing.Size(131, 21)
        Me.chkPremiumStereo.TabIndex = 4
        Me.chkPremiumStereo.Text = "Premium Stereo"
        Me.chkPremiumStereo.UseVisualStyleBackColor = True
        '
        'chkAirConditioning
        '
        Me.chkAirConditioning.AutoSize = True
        Me.chkAirConditioning.Location = New System.Drawing.Point(158, 32)
        Me.chkAirConditioning.Name = "chkAirConditioning"
        Me.chkAirConditioning.Size = New System.Drawing.Size(129, 21)
        Me.chkAirConditioning.TabIndex = 3
        Me.chkAirConditioning.Text = "Air Conditioning"
        Me.chkAirConditioning.UseVisualStyleBackColor = True
        '
        'chkRearDefroster
        '
        Me.chkRearDefroster.AutoSize = True
        Me.chkRearDefroster.Location = New System.Drawing.Point(13, 107)
        Me.chkRearDefroster.Name = "chkRearDefroster"
        Me.chkRearDefroster.Size = New System.Drawing.Size(124, 21)
        Me.chkRearDefroster.TabIndex = 2
        Me.chkRearDefroster.Text = "Rear Defroster"
        Me.chkRearDefroster.UseVisualStyleBackColor = True
        '
        'chkHeatedSeats
        '
        Me.chkHeatedSeats.AutoSize = True
        Me.chkHeatedSeats.Location = New System.Drawing.Point(13, 69)
        Me.chkHeatedSeats.Name = "chkHeatedSeats"
        Me.chkHeatedSeats.Size = New System.Drawing.Size(116, 21)
        Me.chkHeatedSeats.TabIndex = 1
        Me.chkHeatedSeats.Text = "Heated Seats"
        Me.chkHeatedSeats.UseVisualStyleBackColor = True
        '
        'chkLeatherSeats
        '
        Me.chkLeatherSeats.AutoSize = True
        Me.chkLeatherSeats.Location = New System.Drawing.Point(13, 32)
        Me.chkLeatherSeats.Name = "chkLeatherSeats"
        Me.chkLeatherSeats.Size = New System.Drawing.Size(119, 21)
        Me.chkLeatherSeats.TabIndex = 0
        Me.chkLeatherSeats.Text = "Leather Seats"
        Me.chkLeatherSeats.UseVisualStyleBackColor = True
        '
        'gbDriveTrainSelect
        '
        Me.gbDriveTrainSelect.Controls.Add(Me.rbElectric)
        Me.gbDriveTrainSelect.Controls.Add(Me.rbHybrid)
        Me.gbDriveTrainSelect.Controls.Add(Me.rbV4)
        Me.gbDriveTrainSelect.Controls.Add(Me.rbV6)
        Me.gbDriveTrainSelect.Controls.Add(Me.rbV8)
        Me.gbDriveTrainSelect.Controls.Add(Me.rbV12)
        Me.gbDriveTrainSelect.Location = New System.Drawing.Point(15, 112)
        Me.gbDriveTrainSelect.Name = "gbDriveTrainSelect"
        Me.gbDriveTrainSelect.Size = New System.Drawing.Size(506, 73)
        Me.gbDriveTrainSelect.TabIndex = 42
        Me.gbDriveTrainSelect.TabStop = False
        Me.gbDriveTrainSelect.Text = "Drive Train Selection"
        '
        'rbElectric
        '
        Me.rbElectric.AutoSize = True
        Me.rbElectric.Location = New System.Drawing.Point(405, 31)
        Me.rbElectric.Name = "rbElectric"
        Me.rbElectric.Size = New System.Drawing.Size(75, 21)
        Me.rbElectric.TabIndex = 5
        Me.rbElectric.TabStop = True
        Me.rbElectric.Text = "Electric"
        Me.rbElectric.UseVisualStyleBackColor = True
        '
        'rbHybrid
        '
        Me.rbHybrid.AutoSize = True
        Me.rbHybrid.Location = New System.Drawing.Point(315, 31)
        Me.rbHybrid.Name = "rbHybrid"
        Me.rbHybrid.Size = New System.Drawing.Size(70, 21)
        Me.rbHybrid.TabIndex = 4
        Me.rbHybrid.TabStop = True
        Me.rbHybrid.Text = "Hybrid"
        Me.rbHybrid.UseVisualStyleBackColor = True
        '
        'rbV4
        '
        Me.rbV4.AutoSize = True
        Me.rbV4.Location = New System.Drawing.Point(250, 31)
        Me.rbV4.Name = "rbV4"
        Me.rbV4.Size = New System.Drawing.Size(51, 21)
        Me.rbV4.TabIndex = 3
        Me.rbV4.TabStop = True
        Me.rbV4.Text = "V-4"
        Me.rbV4.UseVisualStyleBackColor = True
        '
        'rbV6
        '
        Me.rbV6.AutoSize = True
        Me.rbV6.Location = New System.Drawing.Point(180, 31)
        Me.rbV6.Name = "rbV6"
        Me.rbV6.Size = New System.Drawing.Size(51, 21)
        Me.rbV6.TabIndex = 2
        Me.rbV6.TabStop = True
        Me.rbV6.Text = "V-6"
        Me.rbV6.UseVisualStyleBackColor = True
        '
        'rbV8
        '
        Me.rbV8.AutoSize = True
        Me.rbV8.Location = New System.Drawing.Point(112, 31)
        Me.rbV8.Name = "rbV8"
        Me.rbV8.Size = New System.Drawing.Size(51, 21)
        Me.rbV8.TabIndex = 1
        Me.rbV8.TabStop = True
        Me.rbV8.Text = "V-8"
        Me.rbV8.UseVisualStyleBackColor = True
        '
        'rbV12
        '
        Me.rbV12.AutoSize = True
        Me.rbV12.Location = New System.Drawing.Point(36, 31)
        Me.rbV12.Name = "rbV12"
        Me.rbV12.Size = New System.Drawing.Size(59, 21)
        Me.rbV12.TabIndex = 0
        Me.rbV12.TabStop = True
        Me.rbV12.Text = "V-12"
        Me.rbV12.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(131, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(390, 22)
        Me.txtCustomerName.TabIndex = 38
        '
        'btnPlaceCarOrder
        '
        Me.btnPlaceCarOrder.Location = New System.Drawing.Point(15, 366)
        Me.btnPlaceCarOrder.Name = "btnPlaceCarOrder"
        Me.btnPlaceCarOrder.Size = New System.Drawing.Size(506, 72)
        Me.btnPlaceCarOrder.TabIndex = 45
        Me.btnPlaceCarOrder.Text = "Place Car(s) Order"
        Me.btnPlaceCarOrder.UseVisualStyleBackColor = True
        '
        'KustomKarzForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 455)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.updQuantity)
        Me.Controls.Add(Me.lstCarType)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbDriveTrainSelect)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.btnPlaceCarOrder)
        Me.Name = "KustomKarzForm"
        Me.Text = "KustomKarzForm"
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbDriveTrainSelect.ResumeLayout(False)
        Me.gbDriveTrainSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents updQuantity As NumericUpDown
    Friend WithEvents lstCarType As ListBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents chkEntertainmentPackage As CheckBox
    Friend WithEvents chkGPS As CheckBox
    Friend WithEvents chkBluetooth As CheckBox
    Friend WithEvents chkCDMP3Connections As CheckBox
    Friend WithEvents chkPremiumStereo As CheckBox
    Friend WithEvents chkAirConditioning As CheckBox
    Friend WithEvents chkRearDefroster As CheckBox
    Friend WithEvents chkHeatedSeats As CheckBox
    Friend WithEvents chkLeatherSeats As CheckBox
    Friend WithEvents gbDriveTrainSelect As GroupBox
    Friend WithEvents rbElectric As RadioButton
    Friend WithEvents rbHybrid As RadioButton
    Friend WithEvents rbV4 As RadioButton
    Friend WithEvents rbV6 As RadioButton
    Friend WithEvents rbV8 As RadioButton
    Friend WithEvents rbV12 As RadioButton
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents btnPlaceCarOrder As Button
End Class
