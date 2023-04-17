<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtBinaryValue1 = New System.Windows.Forms.TextBox()
        Me.lblBinaryValue1 = New System.Windows.Forms.Label()
        Me.lblDecimalValue1 = New System.Windows.Forms.Label()
        Me.txtDecimalValue1 = New System.Windows.Forms.TextBox()
        Me.lblHexValue1 = New System.Windows.Forms.Label()
        Me.txtHexValue1 = New System.Windows.Forms.TextBox()
        Me.lblValue1 = New System.Windows.Forms.Label()
        Me.lblValue2 = New System.Windows.Forms.Label()
        Me.lblHexValue2 = New System.Windows.Forms.Label()
        Me.txtHexValue2 = New System.Windows.Forms.TextBox()
        Me.lblDecimalValue2 = New System.Windows.Forms.Label()
        Me.txtDecimalValue2 = New System.Windows.Forms.TextBox()
        Me.lblBinaryValue2 = New System.Windows.Forms.Label()
        Me.txtBinaryValue2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblHexResult = New System.Windows.Forms.Label()
        Me.txtHexResult = New System.Windows.Forms.TextBox()
        Me.lblDecimalResult = New System.Windows.Forms.Label()
        Me.txtDecimalResult = New System.Windows.Forms.TextBox()
        Me.lblBinaryResult = New System.Windows.Forms.Label()
        Me.txtBinaryResult = New System.Windows.Forms.TextBox()
        Me.btnClearValue1 = New System.Windows.Forms.Button()
        Me.btnClearValue2 = New System.Windows.Forms.Button()
        Me.btnClearResults = New System.Windows.Forms.Button()
        Me.btnAnd = New System.Windows.Forms.Button()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.btnXor = New System.Windows.Forms.Button()
        Me.btnNotvalue1 = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.pnlInputButtons = New System.Windows.Forms.Panel()
        Me.pnlInputButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBinaryValue1
        '
        Me.txtBinaryValue1.Location = New System.Drawing.Point(23, 42)
        Me.txtBinaryValue1.Name = "txtBinaryValue1"
        Me.txtBinaryValue1.Size = New System.Drawing.Size(275, 22)
        Me.txtBinaryValue1.TabIndex = 0
        '
        'lblBinaryValue1
        '
        Me.lblBinaryValue1.AutoSize = True
        Me.lblBinaryValue1.Location = New System.Drawing.Point(23, 23)
        Me.lblBinaryValue1.Name = "lblBinaryValue1"
        Me.lblBinaryValue1.Size = New System.Drawing.Size(48, 16)
        Me.lblBinaryValue1.TabIndex = 1
        Me.lblBinaryValue1.Text = "Binary:"
        '
        'lblDecimalValue1
        '
        Me.lblDecimalValue1.AutoSize = True
        Me.lblDecimalValue1.Location = New System.Drawing.Point(23, 90)
        Me.lblDecimalValue1.Name = "lblDecimalValue1"
        Me.lblDecimalValue1.Size = New System.Drawing.Size(60, 16)
        Me.lblDecimalValue1.TabIndex = 3
        Me.lblDecimalValue1.Text = "Decimal:"
        '
        'txtDecimalValue1
        '
        Me.txtDecimalValue1.Location = New System.Drawing.Point(23, 109)
        Me.txtDecimalValue1.Name = "txtDecimalValue1"
        Me.txtDecimalValue1.Size = New System.Drawing.Size(275, 22)
        Me.txtDecimalValue1.TabIndex = 1
        '
        'lblHexValue1
        '
        Me.lblHexValue1.AutoSize = True
        Me.lblHexValue1.Location = New System.Drawing.Point(23, 158)
        Me.lblHexValue1.Name = "lblHexValue1"
        Me.lblHexValue1.Size = New System.Drawing.Size(34, 16)
        Me.lblHexValue1.TabIndex = 5
        Me.lblHexValue1.Text = "Hex:"
        '
        'txtHexValue1
        '
        Me.txtHexValue1.Location = New System.Drawing.Point(23, 177)
        Me.txtHexValue1.Name = "txtHexValue1"
        Me.txtHexValue1.Size = New System.Drawing.Size(275, 22)
        Me.txtHexValue1.TabIndex = 2
        '
        'lblValue1
        '
        Me.lblValue1.AutoSize = True
        Me.lblValue1.Location = New System.Drawing.Point(125, 229)
        Me.lblValue1.Name = "lblValue1"
        Me.lblValue1.Size = New System.Drawing.Size(52, 16)
        Me.lblValue1.TabIndex = 6
        Me.lblValue1.Text = "Value 1"
        '
        'lblValue2
        '
        Me.lblValue2.AutoSize = True
        Me.lblValue2.Location = New System.Drawing.Point(564, 229)
        Me.lblValue2.Name = "lblValue2"
        Me.lblValue2.Size = New System.Drawing.Size(52, 16)
        Me.lblValue2.TabIndex = 13
        Me.lblValue2.Text = "Value 2"
        '
        'lblHexValue2
        '
        Me.lblHexValue2.AutoSize = True
        Me.lblHexValue2.Location = New System.Drawing.Point(455, 158)
        Me.lblHexValue2.Name = "lblHexValue2"
        Me.lblHexValue2.Size = New System.Drawing.Size(34, 16)
        Me.lblHexValue2.TabIndex = 12
        Me.lblHexValue2.Text = "Hex:"
        '
        'txtHexValue2
        '
        Me.txtHexValue2.Location = New System.Drawing.Point(455, 177)
        Me.txtHexValue2.Name = "txtHexValue2"
        Me.txtHexValue2.Size = New System.Drawing.Size(275, 22)
        Me.txtHexValue2.TabIndex = 5
        '
        'lblDecimalValue2
        '
        Me.lblDecimalValue2.AutoSize = True
        Me.lblDecimalValue2.Location = New System.Drawing.Point(455, 90)
        Me.lblDecimalValue2.Name = "lblDecimalValue2"
        Me.lblDecimalValue2.Size = New System.Drawing.Size(60, 16)
        Me.lblDecimalValue2.TabIndex = 10
        Me.lblDecimalValue2.Text = "Decimal:"
        '
        'txtDecimalValue2
        '
        Me.txtDecimalValue2.Location = New System.Drawing.Point(455, 109)
        Me.txtDecimalValue2.Name = "txtDecimalValue2"
        Me.txtDecimalValue2.Size = New System.Drawing.Size(275, 22)
        Me.txtDecimalValue2.TabIndex = 4
        '
        'lblBinaryValue2
        '
        Me.lblBinaryValue2.AutoSize = True
        Me.lblBinaryValue2.Location = New System.Drawing.Point(455, 23)
        Me.lblBinaryValue2.Name = "lblBinaryValue2"
        Me.lblBinaryValue2.Size = New System.Drawing.Size(48, 16)
        Me.lblBinaryValue2.TabIndex = 8
        Me.lblBinaryValue2.Text = "Binary:"
        '
        'txtBinaryValue2
        '
        Me.txtBinaryValue2.Location = New System.Drawing.Point(455, 42)
        Me.txtBinaryValue2.Name = "txtBinaryValue2"
        Me.txtBinaryValue2.Size = New System.Drawing.Size(275, 22)
        Me.txtBinaryValue2.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(952, 229)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(45, 16)
        Me.lblResult.TabIndex = 20
        Me.lblResult.Text = "Result"
        '
        'lblHexResult
        '
        Me.lblHexResult.AutoSize = True
        Me.lblHexResult.Location = New System.Drawing.Point(850, 158)
        Me.lblHexResult.Name = "lblHexResult"
        Me.lblHexResult.Size = New System.Drawing.Size(34, 16)
        Me.lblHexResult.TabIndex = 19
        Me.lblHexResult.Text = "Hex:"
        '
        'txtHexResult
        '
        Me.txtHexResult.Location = New System.Drawing.Point(850, 177)
        Me.txtHexResult.Name = "txtHexResult"
        Me.txtHexResult.ReadOnly = True
        Me.txtHexResult.Size = New System.Drawing.Size(275, 22)
        Me.txtHexResult.TabIndex = 18
        '
        'lblDecimalResult
        '
        Me.lblDecimalResult.AutoSize = True
        Me.lblDecimalResult.Location = New System.Drawing.Point(850, 90)
        Me.lblDecimalResult.Name = "lblDecimalResult"
        Me.lblDecimalResult.Size = New System.Drawing.Size(60, 16)
        Me.lblDecimalResult.TabIndex = 17
        Me.lblDecimalResult.Text = "Decimal:"
        '
        'txtDecimalResult
        '
        Me.txtDecimalResult.Location = New System.Drawing.Point(850, 109)
        Me.txtDecimalResult.Name = "txtDecimalResult"
        Me.txtDecimalResult.ReadOnly = True
        Me.txtDecimalResult.Size = New System.Drawing.Size(275, 22)
        Me.txtDecimalResult.TabIndex = 16
        '
        'lblBinaryResult
        '
        Me.lblBinaryResult.AutoSize = True
        Me.lblBinaryResult.Location = New System.Drawing.Point(850, 23)
        Me.lblBinaryResult.Name = "lblBinaryResult"
        Me.lblBinaryResult.Size = New System.Drawing.Size(48, 16)
        Me.lblBinaryResult.TabIndex = 15
        Me.lblBinaryResult.Text = "Binary:"
        '
        'txtBinaryResult
        '
        Me.txtBinaryResult.Location = New System.Drawing.Point(850, 42)
        Me.txtBinaryResult.Name = "txtBinaryResult"
        Me.txtBinaryResult.ReadOnly = True
        Me.txtBinaryResult.Size = New System.Drawing.Size(275, 22)
        Me.txtBinaryResult.TabIndex = 14
        '
        'btnClearValue1
        '
        Me.btnClearValue1.Location = New System.Drawing.Point(608, 291)
        Me.btnClearValue1.Name = "btnClearValue1"
        Me.btnClearValue1.Size = New System.Drawing.Size(253, 37)
        Me.btnClearValue1.TabIndex = 23
        Me.btnClearValue1.Text = "Clear Value 1"
        Me.btnClearValue1.UseVisualStyleBackColor = True
        '
        'btnClearValue2
        '
        Me.btnClearValue2.Location = New System.Drawing.Point(608, 343)
        Me.btnClearValue2.Name = "btnClearValue2"
        Me.btnClearValue2.Size = New System.Drawing.Size(253, 37)
        Me.btnClearValue2.TabIndex = 24
        Me.btnClearValue2.Text = "Clear Value 2"
        Me.btnClearValue2.UseVisualStyleBackColor = True
        '
        'btnClearResults
        '
        Me.btnClearResults.Location = New System.Drawing.Point(608, 395)
        Me.btnClearResults.Name = "btnClearResults"
        Me.btnClearResults.Size = New System.Drawing.Size(253, 37)
        Me.btnClearResults.TabIndex = 25
        Me.btnClearResults.Text = "Clear Result"
        Me.btnClearResults.UseVisualStyleBackColor = True
        '
        'btnAnd
        '
        Me.btnAnd.Location = New System.Drawing.Point(964, 291)
        Me.btnAnd.Name = "btnAnd"
        Me.btnAnd.Size = New System.Drawing.Size(121, 37)
        Me.btnAnd.TabIndex = 26
        Me.btnAnd.Text = "And"
        Me.btnAnd.UseVisualStyleBackColor = True
        '
        'btnOr
        '
        Me.btnOr.Location = New System.Drawing.Point(964, 343)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(121, 37)
        Me.btnOr.TabIndex = 27
        Me.btnOr.Text = "Or"
        Me.btnOr.UseVisualStyleBackColor = True
        '
        'btnXor
        '
        Me.btnXor.Location = New System.Drawing.Point(964, 395)
        Me.btnXor.Name = "btnXor"
        Me.btnXor.Size = New System.Drawing.Size(121, 37)
        Me.btnXor.TabIndex = 28
        Me.btnXor.Text = "Xor"
        Me.btnXor.UseVisualStyleBackColor = True
        '
        'btnNotvalue1
        '
        Me.btnNotvalue1.Location = New System.Drawing.Point(964, 448)
        Me.btnNotvalue1.Name = "btnNotvalue1"
        Me.btnNotvalue1.Size = New System.Drawing.Size(121, 37)
        Me.btnNotvalue1.TabIndex = 29
        Me.btnNotvalue1.Text = "Not Value 1"
        Me.btnNotvalue1.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(304, 67)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(139, 162)
        Me.btnConvert.TabIndex = 22
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(376, 11)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(67, 50)
        Me.btnF.TabIndex = 21
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(304, 11)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(67, 50)
        Me.btnE.TabIndex = 20
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(231, 11)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(67, 50)
        Me.btnD.TabIndex = 19
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(160, 11)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(67, 50)
        Me.btnC.TabIndex = 18
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(87, 11)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(67, 50)
        Me.btnB.TabIndex = 17
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(14, 11)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(67, 50)
        Me.btnA.TabIndex = 16
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(87, 67)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(67, 50)
        Me.btn7.TabIndex = 13
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(14, 67)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(67, 50)
        Me.btn6.TabIndex = 12
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(231, 67)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(67, 50)
        Me.btn9.TabIndex = 15
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(160, 67)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(67, 50)
        Me.btn8.TabIndex = 14
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(233, 123)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(67, 50)
        Me.btn5.TabIndex = 11
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(162, 123)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(67, 50)
        Me.btn4.TabIndex = 10
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(89, 123)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(67, 50)
        Me.btn3.TabIndex = 9
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(16, 123)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(67, 50)
        Me.btn2.TabIndex = 8
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(89, 179)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(67, 50)
        Me.btn1.TabIndex = 7
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(16, 179)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(67, 50)
        Me.btn0.TabIndex = 6
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'pnlInputButtons
        '
        Me.pnlInputButtons.Controls.Add(Me.btnConvert)
        Me.pnlInputButtons.Controls.Add(Me.btn1)
        Me.pnlInputButtons.Controls.Add(Me.btnE)
        Me.pnlInputButtons.Controls.Add(Me.btn0)
        Me.pnlInputButtons.Controls.Add(Me.btnF)
        Me.pnlInputButtons.Controls.Add(Me.btn5)
        Me.pnlInputButtons.Controls.Add(Me.btnC)
        Me.pnlInputButtons.Controls.Add(Me.btn4)
        Me.pnlInputButtons.Controls.Add(Me.btnD)
        Me.pnlInputButtons.Controls.Add(Me.btn3)
        Me.pnlInputButtons.Controls.Add(Me.btnA)
        Me.pnlInputButtons.Controls.Add(Me.btn2)
        Me.pnlInputButtons.Controls.Add(Me.btnB)
        Me.pnlInputButtons.Controls.Add(Me.btn9)
        Me.pnlInputButtons.Controls.Add(Me.btn6)
        Me.pnlInputButtons.Controls.Add(Me.btn8)
        Me.pnlInputButtons.Controls.Add(Me.btn7)
        Me.pnlInputButtons.Location = New System.Drawing.Point(96, 283)
        Me.pnlInputButtons.Name = "pnlInputButtons"
        Me.pnlInputButtons.Size = New System.Drawing.Size(469, 243)
        Me.pnlInputButtons.TabIndex = 30
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 538)
        Me.Controls.Add(Me.pnlInputButtons)
        Me.Controls.Add(Me.btnNotvalue1)
        Me.Controls.Add(Me.btnXor)
        Me.Controls.Add(Me.btnOr)
        Me.Controls.Add(Me.btnAnd)
        Me.Controls.Add(Me.btnClearResults)
        Me.Controls.Add(Me.btnClearValue2)
        Me.Controls.Add(Me.btnClearValue1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblHexResult)
        Me.Controls.Add(Me.txtHexResult)
        Me.Controls.Add(Me.lblDecimalResult)
        Me.Controls.Add(Me.txtDecimalResult)
        Me.Controls.Add(Me.lblBinaryResult)
        Me.Controls.Add(Me.txtBinaryResult)
        Me.Controls.Add(Me.lblValue2)
        Me.Controls.Add(Me.lblHexValue2)
        Me.Controls.Add(Me.txtHexValue2)
        Me.Controls.Add(Me.lblDecimalValue2)
        Me.Controls.Add(Me.txtDecimalValue2)
        Me.Controls.Add(Me.lblBinaryValue2)
        Me.Controls.Add(Me.txtBinaryValue2)
        Me.Controls.Add(Me.lblValue1)
        Me.Controls.Add(Me.lblHexValue1)
        Me.Controls.Add(Me.txtHexValue1)
        Me.Controls.Add(Me.lblDecimalValue1)
        Me.Controls.Add(Me.txtDecimalValue1)
        Me.Controls.Add(Me.lblBinaryValue1)
        Me.Controls.Add(Me.txtBinaryValue1)
        Me.Name = "Calculator"
        Me.Text = "Calc"
        Me.pnlInputButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBinaryValue1 As TextBox
    Friend WithEvents lblBinaryValue1 As Label
    Friend WithEvents lblDecimalValue1 As Label
    Friend WithEvents txtDecimalValue1 As TextBox
    Friend WithEvents lblHexValue1 As Label
    Friend WithEvents txtHexValue1 As TextBox
    Friend WithEvents lblValue1 As Label
    Friend WithEvents lblValue2 As Label
    Friend WithEvents lblHexValue2 As Label
    Friend WithEvents txtHexValue2 As TextBox
    Friend WithEvents lblDecimalValue2 As Label
    Friend WithEvents txtDecimalValue2 As TextBox
    Friend WithEvents lblBinaryValue2 As Label
    Friend WithEvents txtBinaryValue2 As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblHexResult As Label
    Friend WithEvents txtHexResult As TextBox
    Friend WithEvents lblDecimalResult As Label
    Friend WithEvents txtDecimalResult As TextBox
    Friend WithEvents lblBinaryResult As Label
    Friend WithEvents txtBinaryResult As TextBox
    Friend WithEvents btnClearValue1 As Button
    Friend WithEvents btnClearValue2 As Button
    Friend WithEvents btnClearResults As Button
    Friend WithEvents btnAnd As Button
    Friend WithEvents btnOr As Button
    Friend WithEvents btnXor As Button
    Friend WithEvents btnNotvalue1 As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents pnlInputButtons As Panel
End Class
