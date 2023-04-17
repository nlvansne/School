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
        Me.components = New System.ComponentModel.Container()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.lblSelectedRaw = New System.Windows.Forms.Label()
        Me.lblPreppedItems = New System.Windows.Forms.Label()
        Me.lblSelectedPreppedItem = New System.Windows.Forms.Label()
        Me.txtAddRaw = New System.Windows.Forms.TextBox()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.txtAddPrepped = New System.Windows.Forms.TextBox()
        Me.btnAddPrepped = New System.Windows.Forms.Button()
        Me.txtAddDish = New System.Windows.Forms.TextBox()
        Me.btnAddDish = New System.Windows.Forms.Button()
        Me.lblListDishes = New System.Windows.Forms.Label()
        Me.lstRaw = New System.Windows.Forms.ListBox()
        Me.lstSelectedRaw = New System.Windows.Forms.ListBox()
        Me.lstSelectedPrepped = New System.Windows.Forms.ListBox()
        Me.lstPrepped = New System.Windows.Forms.ListBox()
        Me.lstDishes = New System.Windows.Forms.ListBox()
        Me.erpAddRaw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpAddPrepped = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpAddDish = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpSelectedPrepped = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpRemoveSelectedPrepped = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpSelectedRaw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpRemoveSelectedRaw = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erpAddRaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpAddPrepped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpAddDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpSelectedPrepped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpRemoveSelectedPrepped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpSelectedRaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpRemoveSelectedRaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Location = New System.Drawing.Point(519, 455)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(260, 16)
        Me.lblRaw.TabIndex = 39
        Me.lblRaw.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'lblSelectedRaw
        '
        Me.lblSelectedRaw.AutoSize = True
        Me.lblSelectedRaw.Location = New System.Drawing.Point(11, 457)
        Me.lblSelectedRaw.Name = "lblSelectedRaw"
        Me.lblSelectedRaw.Size = New System.Drawing.Size(260, 16)
        Me.lblSelectedRaw.TabIndex = 38
        Me.lblSelectedRaw.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'lblPreppedItems
        '
        Me.lblPreppedItems.AutoSize = True
        Me.lblPreppedItems.Location = New System.Drawing.Point(519, 221)
        Me.lblPreppedItems.Name = "lblPreppedItems"
        Me.lblPreppedItems.Size = New System.Drawing.Size(152, 16)
        Me.lblPreppedItems.TabIndex = 37
        Me.lblPreppedItems.Text = "List of all Prepped Items:"
        '
        'lblSelectedPreppedItem
        '
        Me.lblSelectedPreppedItem.AutoSize = True
        Me.lblSelectedPreppedItem.Location = New System.Drawing.Point(11, 221)
        Me.lblSelectedPreppedItem.Name = "lblSelectedPreppedItem"
        Me.lblSelectedPreppedItem.Size = New System.Drawing.Size(198, 16)
        Me.lblSelectedPreppedItem.TabIndex = 36
        Me.lblSelectedPreppedItem.Text = "Prepped Items in Selected Dish:"
        '
        'txtAddRaw
        '
        Me.txtAddRaw.Location = New System.Drawing.Point(624, 634)
        Me.txtAddRaw.Name = "txtAddRaw"
        Me.txtAddRaw.Size = New System.Drawing.Size(237, 22)
        Me.txtAddRaw.TabIndex = 35
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(531, 614)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(86, 66)
        Me.btnAddRaw.TabIndex = 34
        Me.btnAddRaw.Text = "Add New Raw Ingredient" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'txtAddPrepped
        '
        Me.txtAddPrepped.Location = New System.Drawing.Point(624, 398)
        Me.txtAddPrepped.Name = "txtAddPrepped"
        Me.txtAddPrepped.Size = New System.Drawing.Size(237, 22)
        Me.txtAddPrepped.TabIndex = 29
        '
        'btnAddPrepped
        '
        Me.btnAddPrepped.Location = New System.Drawing.Point(531, 378)
        Me.btnAddPrepped.Name = "btnAddPrepped"
        Me.btnAddPrepped.Size = New System.Drawing.Size(86, 64)
        Me.btnAddPrepped.TabIndex = 28
        Me.btnAddPrepped.Text = "Add New Prepped Item"
        Me.btnAddPrepped.UseVisualStyleBackColor = True
        '
        'txtAddDish
        '
        Me.txtAddDish.Location = New System.Drawing.Point(625, 168)
        Me.txtAddDish.Name = "txtAddDish"
        Me.txtAddDish.Size = New System.Drawing.Size(236, 22)
        Me.txtAddDish.TabIndex = 27
        '
        'btnAddDish
        '
        Me.btnAddDish.Location = New System.Drawing.Point(531, 151)
        Me.btnAddDish.Name = "btnAddDish"
        Me.btnAddDish.Size = New System.Drawing.Size(86, 57)
        Me.btnAddDish.TabIndex = 26
        Me.btnAddDish.Text = "Add New Dish"
        Me.btnAddDish.UseVisualStyleBackColor = True
        '
        'lblListDishes
        '
        Me.lblListDishes.AutoSize = True
        Me.lblListDishes.Location = New System.Drawing.Point(12, 9)
        Me.lblListDishes.Name = "lblListDishes"
        Me.lblListDishes.Size = New System.Drawing.Size(106, 16)
        Me.lblListDishes.TabIndex = 20
        Me.lblListDishes.Text = "List of all Dishes:"
        '
        'lstRaw
        '
        Me.lstRaw.AllowDrop = True
        Me.lstRaw.FormattingEnabled = True
        Me.lstRaw.ItemHeight = 16
        Me.lstRaw.Location = New System.Drawing.Point(522, 476)
        Me.lstRaw.Name = "lstRaw"
        Me.lstRaw.Size = New System.Drawing.Size(339, 132)
        Me.lstRaw.TabIndex = 40
        '
        'lstSelectedRaw
        '
        Me.lstSelectedRaw.AllowDrop = True
        Me.lstSelectedRaw.FormattingEnabled = True
        Me.lstSelectedRaw.ItemHeight = 16
        Me.lstSelectedRaw.Location = New System.Drawing.Point(12, 476)
        Me.lstSelectedRaw.Name = "lstSelectedRaw"
        Me.lstSelectedRaw.Size = New System.Drawing.Size(338, 132)
        Me.lstSelectedRaw.TabIndex = 41
        '
        'lstSelectedPrepped
        '
        Me.lstSelectedPrepped.AllowDrop = True
        Me.lstSelectedPrepped.FormattingEnabled = True
        Me.lstSelectedPrepped.ItemHeight = 16
        Me.lstSelectedPrepped.Location = New System.Drawing.Point(12, 240)
        Me.lstSelectedPrepped.Name = "lstSelectedPrepped"
        Me.lstSelectedPrepped.Size = New System.Drawing.Size(338, 132)
        Me.lstSelectedPrepped.TabIndex = 42
        '
        'lstPrepped
        '
        Me.lstPrepped.AllowDrop = True
        Me.lstPrepped.FormattingEnabled = True
        Me.lstPrepped.ItemHeight = 16
        Me.lstPrepped.Location = New System.Drawing.Point(522, 240)
        Me.lstPrepped.Name = "lstPrepped"
        Me.lstPrepped.Size = New System.Drawing.Size(339, 132)
        Me.lstPrepped.TabIndex = 43
        '
        'lstDishes
        '
        Me.lstDishes.FormattingEnabled = True
        Me.lstDishes.ItemHeight = 16
        Me.lstDishes.Location = New System.Drawing.Point(12, 28)
        Me.lstDishes.Name = "lstDishes"
        Me.lstDishes.Size = New System.Drawing.Size(849, 116)
        Me.lstDishes.TabIndex = 44
        '
        'erpAddRaw
        '
        Me.erpAddRaw.ContainerControl = Me
        '
        'erpAddPrepped
        '
        Me.erpAddPrepped.ContainerControl = Me
        '
        'erpAddDish
        '
        Me.erpAddDish.ContainerControl = Me
        '
        'erpSelectedPrepped
        '
        Me.erpSelectedPrepped.ContainerControl = Me
        '
        'erpRemoveSelectedPrepped
        '
        Me.erpRemoveSelectedPrepped.ContainerControl = Me
        '
        'erpSelectedRaw
        '
        Me.erpSelectedRaw.ContainerControl = Me
        '
        'erpRemoveSelectedRaw
        '
        Me.erpRemoveSelectedRaw.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 692)
        Me.Controls.Add(Me.lstDishes)
        Me.Controls.Add(Me.lstPrepped)
        Me.Controls.Add(Me.lstSelectedPrepped)
        Me.Controls.Add(Me.lstSelectedRaw)
        Me.Controls.Add(Me.lstRaw)
        Me.Controls.Add(Me.lblRaw)
        Me.Controls.Add(Me.lblSelectedRaw)
        Me.Controls.Add(Me.lblPreppedItems)
        Me.Controls.Add(Me.lblSelectedPreppedItem)
        Me.Controls.Add(Me.txtAddRaw)
        Me.Controls.Add(Me.btnAddRaw)
        Me.Controls.Add(Me.txtAddPrepped)
        Me.Controls.Add(Me.btnAddPrepped)
        Me.Controls.Add(Me.txtAddDish)
        Me.Controls.Add(Me.btnAddDish)
        Me.Controls.Add(Me.lblListDishes)
        Me.Name = "Form1"
        Me.Text = "Chez SouSad"
        CType(Me.erpAddRaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpAddPrepped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpAddDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpSelectedPrepped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpRemoveSelectedPrepped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpSelectedRaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpRemoveSelectedRaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblRaw As Label
    Private WithEvents lblSelectedRaw As Label
    Private WithEvents lblPreppedItems As Label
    Private WithEvents lblSelectedPreppedItem As Label
    Private WithEvents txtAddRaw As TextBox
    Private WithEvents btnAddRaw As Button
    Private WithEvents txtAddPrepped As TextBox
    Private WithEvents btnAddPrepped As Button
    Private WithEvents txtAddDish As TextBox
    Private WithEvents btnAddDish As Button
    Private WithEvents lblListDishes As Label
    Friend WithEvents lstRaw As ListBox
    Friend WithEvents lstSelectedRaw As ListBox
    Friend WithEvents lstSelectedPrepped As ListBox
    Friend WithEvents lstPrepped As ListBox
    Friend WithEvents lstDishes As ListBox
    Friend WithEvents erpAddRaw As ErrorProvider
    Friend WithEvents erpAddPrepped As ErrorProvider
    Friend WithEvents erpAddDish As ErrorProvider
    Friend WithEvents erpSelectedPrepped As ErrorProvider
    Friend WithEvents erpRemoveSelectedPrepped As ErrorProvider
    Friend WithEvents erpSelectedRaw As ErrorProvider
    Friend WithEvents erpRemoveSelectedRaw As ErrorProvider
End Class
