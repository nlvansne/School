Public Class Calculator
    '------------------------------------------------------------
    '-              File Name : Calculator.vb                   -
    '-              Part of Project: Assignment6                -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: March 21, 2022                  -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file is the calculator form. It converts binary and -
    '- decimal and hex.                                         -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '-*txtCurrentTextbox - The textbox with the current focus   -
    '------------------------------------------------------------


    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------


    '-------------------------------------------------------------------------------------------
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '-------------------------------------------------------------------------------------------


    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------

    Dim txtCurrentTextbox As TextBox 'Textbox that has focus

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------


#Region "Load"
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-           Subprogram Name: Calculator_Load               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textboxes to-
        '- their default values when the form is loaded.            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Resets each set of textboxes
        resetTextBoxValues(txtBinaryValue1, txtDecimalValue1, txtHexValue1)
        resetTextBoxValues(txtBinaryValue2, txtDecimalValue2, txtHexValue2)
        resetTextBoxValues(txtBinaryResult, txtDecimalResult, txtHexResult)
    End Sub
#End Region

#Region "reset TextBox Values"

    Private Sub resetTextBoxValues(txtBinary As TextBox, txtDecimal As TextBox, txtHex As TextBox)
        '------------------------------------------------------------
        '-           Subprogram Name: resetTextBoxValues            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the text value  -
        '- of three textboxes to "0"                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- txtBinary - Textbox control                              -
        '- txtDecimal - Textbox control                             -
        '- txtHex - Textbox control                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Sets the text for each textbox
        txtBinary.Text = "0"
        txtDecimal.Text = "0"
        txtHex.Text = "0"
    End Sub

    Private Sub btnClearValue1_Click(sender As Object, e As EventArgs) Handles btnClearValue1.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnClearValue1_Click          -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textboxes of-
        '- value 1 to their default values                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        resetTextBoxValues(txtBinaryValue1, txtDecimalValue1, txtHexValue1)
    End Sub

    Private Sub btnClearValue2_Click(sender As Object, e As EventArgs) Handles btnClearValue2.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnClearValue2_Click          -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textboxes of-
        '- value 2 to their default values                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        resetTextBoxValues(txtBinaryValue2, txtDecimalValue2, txtHexValue2)
    End Sub

    Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnClearValue2_Click          -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textboxes of-
        '- Result to their default values                           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        resetTextBoxValues(txtBinaryResult, txtDecimalResult, txtHexResult)
    End Sub

#End Region

#Region "TextBoxControls"

    Private Sub txtBinaryValue1_Enter(sender As Object, e As EventArgs) Handles txtBinaryValue1.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: btnClearValue2_Click          -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setBinaryControls(sender)
    End Sub

    Private Sub txtDecimalValue1_Enter(sender As Object, e As EventArgs) Handles txtDecimalValue1.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: txtDecimalValue1_Enter        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setDecimalControls(sender)
    End Sub

    Private Sub txtHexValue1_Enter(sender As Object, e As EventArgs) Handles txtHexValue1.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: txtHexValue1_Enter            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setHexControls(sender)
    End Sub

    Private Sub txtBinaryValue2_Enter(sender As Object, e As EventArgs) Handles txtBinaryValue2.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: txtBinaryValue2_Enter         -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setBinaryControls(sender)
    End Sub

    Private Sub txtDecimalValue2_Enter(sender As Object, e As EventArgs) Handles txtDecimalValue2.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: txtDecimalValue2_Enter        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setDecimalControls(sender)
    End Sub

    Private Sub txtHexValue2_Enter(sender As Object, e As EventArgs) Handles txtHexValue2.Enter
        '------------------------------------------------------------
        '-           Subprogram Name: txtHexValue2_Enter            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is when the textbox is    -
        '- selected it will set the buttons allowed for input       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        setHexControls(sender)
    End Sub

    Private Sub setBinaryControls(txtSender As TextBox)
        '------------------------------------------------------------
        '-           Subprogram Name: setBinaryControls             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textbox     -
        '- that currently has focus and enable/disable buttons that -
        '- are allowed for input                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- txtSender - Textbox that has focus                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Update the textbox that has focus
        txtCurrentTextbox = txtSender

        'Enables/Disables appropriate files
        setEnabledInputButtons(New String() {"0", "1"})
    End Sub

    Private Sub setDecimalControls(txtSender As TextBox)
        '------------------------------------------------------------
        '-           Subprogram Name: setDecimalControls            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textbox     -
        '- that currently has focus and enable/disable buttons that -
        '- are allowed for input                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- txtSender - Textbox that has focus                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Update the textbox that has focus
        txtCurrentTextbox = txtSender

        'Enables/Disables appropriate files
        setEnabledInputButtons(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
    End Sub

    Private Sub setHexControls(txtSender As TextBox)
        '------------------------------------------------------------
        '-           Subprogram Name: setHexControls                -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textbox     -
        '- that currently has focus and enable/disable buttons that -
        '- are allowed for input                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- txtSender - Textbox that has focus                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Update the textbox that has focus
        txtCurrentTextbox = txtSender

        'Enables/Disables appropriate files
        setEnabledInputButtons(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
    End Sub

#End Region

#Region "Form Closing"
    Private Sub Calculator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '------------------------------------------------------------
        '-           Subprogram Name: Calculator_FormClosing        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to handling closing the-
        '- form. It will prompt the user is the textboxes are not   -
        '- all 0.                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Checks if all textboxes text is "0"
        If Not (txtBinaryValue1.Text.Equals("0") And txtDecimalValue1.Text.Equals("0") And txtHexValue1.Text.Equals("0") And
            txtBinaryValue2.Text.Equals("0") And txtDecimalValue2.Text.Equals("0") And txtHexValue2.Text.Equals("0")) Then

            'Prompts user if they want to close dirty child
            If MessageBox.Show("Close the dirty child?", "", MessageBoxButtons.YesNo) = vbNo Then
                e.Cancel = True 'Cancels closing the form
            End If
        End If
    End Sub
#End Region

#Region "pnlInputButtons"
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnA_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnB_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnC_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnD_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnE_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnF_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn6_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   -          
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn7_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn8_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn9_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn2_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn3_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn4_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn5_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn0_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btn1_Click                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add the value of a  -
        '- buttons text to the text of the textbox that has focus   - 
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        txtCurrentTextbox.Text = txtCurrentTextbox.Text + sender.text
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnConvert_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to set the textboxes   -
        '- equal to a new converted value                           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------


        If txtCurrentTextbox Is txtBinaryValue1 Then 'txtBinaryValue1 has focus
            txtDecimalValue1.Text = binaryToDecimal(txtCurrentTextbox.Text())
            txtHexValue1.Text = binaryToHex(txtCurrentTextbox.Text())
        ElseIf txtCurrentTextbox Is txtDecimalValue1 Then 'txtDecimalValue1 has focus
            txtBinaryValue1.Text = decimalToBinary(txtCurrentTextbox.Text())
            txtHexValue1.Text = decimalToHex(txtCurrentTextbox.Text())
        ElseIf txtCurrentTextbox Is txtHexValue1 Then 'txtHexValue1 has focus
            txtBinaryValue1.Text = hexToBinary(txtCurrentTextbox.Text())
            txtDecimalValue1.Text = hexToDecimal(txtCurrentTextbox.Text())
        ElseIf txtCurrentTextbox Is txtBinaryValue2 Then 'txtBinaryValue2 has focus
            txtDecimalValue2.Text = binaryToDecimal(txtCurrentTextbox.Text())
            txtHexValue2.Text = binaryToHex(txtCurrentTextbox.Text())
        ElseIf txtCurrentTextbox Is txtDecimalValue2 Then 'txtDecimalValue2 has focus
            txtBinaryValue2.Text = decimalToBinary(txtCurrentTextbox.Text())
            txtHexValue2.Text = decimalToHex(txtCurrentTextbox.Text())
        ElseIf txtCurrentTextbox Is txtHexValue2 Then 'txtHexValue2 has focus
            txtBinaryValue2.Text = hexToBinary(txtCurrentTextbox.Text())
            txtDecimalValue2.Text = hexToDecimal(txtCurrentTextbox.Text())
        End If
    End Sub

    Private Sub setEnabledInputButtons(lstValidButtons As String())
        '------------------------------------------------------------
        '-           Subprogram Name: setEnabledInputButtons        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to enable/disable      -
        '- buttons based on the given list of valid buttons using   -
        '- button text.                                             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- lstValidButtons - string list for valid buttons          -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Loops through all the buttons in pnlInputButtons
        For Each btnInput In pnlInputButtons.Controls
            btnInput = CType(btnInput, Button) 'Converts btnInput to a Button

            'Checks if the button should be enabled
            If btnInput.text.Equals("Convert") Or lstValidButtons.Contains(btnInput.text) Then
                btnInput.enabled = True
            Else
                btnInput.enabled = False
            End If
        Next
    End Sub
#End Region

#Region "Conversions"
    Function binaryToDecimal(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: binaryToDecimal               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from binary -
        '- to decimal                                               -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*intOutput - 64bit that will hold the value of the decimal-
        '-*intPowerCounter - Counter to increment used for powers of-
        '- two                                                      -
        '------------------------------------------------------------

        Dim intOutput As Int64 = 0
        Dim intPowerCounter As Integer = 0

        'Removes whitespaces from binary input
        strInput = strInput.Replace(" ", "")

        'Loops through binary input
        For i = strInput.Length - 1 To 0 Step -1
            If strInput.Chars(i) = "1" Then 'If the binary value is 1 then add current power of two to intOutput
                intOutput = intOutput + Math.Pow(2, strInput.Length - 1 - i)
            End If
            intPowerCounter = intPowerCounter + 1 'Increment power counter
        Next

        Return intOutput.ToString()
    End Function

    Function binaryToHex(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: binaryToHex                   -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from binary -
        '- to hex                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Removes white spaces from binary value
        strInput = strInput.Replace(" ", "")

        Return decimalToHex(binaryToDecimal(strInput))
    End Function

    Function decimalToBinary(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: decimalToBinary               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from decimal-
        '- to binary                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*intInput - inputted value as an integer                  -
        '-*strOutput - String to hold the output                    -
        '------------------------------------------------------------

        'Try catch used to catch overflow
        Try
            Dim intInput As Integer = CType(strInput, Integer)
            Dim strOutput As String = ""

            'Loop 32 times to check if current binary bit is 1 or 0
            For i = 31 To 0 Step -1

                'Adds a space after every 4 bits for formatting
                If (strOutput.Length + 1) Mod 5 = 0 Then
                    strOutput = strOutput & " "
                End If

                'if the decimal value is greater or equal to current power ser bit = 1
                If intInput >= Math.Pow(2, i) Then
                    strOutput = strOutput & "1"
                    intInput = intInput - Math.Pow(2, i)
                Else 'Set bit to 0
                    strOutput = strOutput & "0"
                End If
            Next

            Return strOutput
        Catch
            MessageBox.Show("Overflow: Value entered was too large")
            Return 0
        End Try
    End Function

    Function decimalToHex(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: decimalToHex                  -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from decimal-
        '- to hex                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return Hex(strInput).ToString()
    End Function

    Function hexToDecimal(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: hexToDecimal                  -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from hex to -
        '- decimal                                                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Try
            Return Convert.ToInt64(strInput, 16).ToString()
        Catch
            Return "0"
        End Try
    End Function

    Function hexToBinary(strInput As String) As String
        '------------------------------------------------------------
        '-           Subprogram Name: hexToBinary                   -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to convert from hex to -
        '- Binary                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strInput - String input of value to be converted         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return decimalToBinary(hexToDecimal(strInput))
    End Function
#End Region

#Region "Logical Operations"
    Private Sub btnAnd_Click(sender As Object, e As EventArgs) Handles btnAnd.Click
        '------------------------------------------------------------
        '-                Subprogram Name: btnAnd_Click             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to use the AND logical -
        '- Operation on Value1 and Value2 binary values             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strBinaryValue1 - binary value 1                         -
        '-*strBinaryValue2 - binary value 2                         -
        '-*strResults - binary result                               -
        '------------------------------------------------------------


        Dim strBinaryValue1 As String = txtBinaryValue1.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strBinaryValue2 As String = txtBinaryValue2.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strResults As String = ""

        'Loops through the 32 bits
        For i As Integer = 0 To 31 Step 1

            'Checks if both binary strings have a value at i
            If strBinaryValue1.Length - 1 >= i And strBinaryValue2.Length - 1 >= i Then

                'If both binary values are 1
                If strBinaryValue1.Chars(i) = strBinaryValue2.Chars(i) And strBinaryValue2.Chars(i) = "1" Then
                    strResults = strResults & "1"
                Else
                    strResults = strResults & "0"
                End If
            Else
                strResults = strResults & "0"
            End If

            'Format binary
            If (strResults.Length + 1) Mod 5 = 0 Then
                strResults = strResults & " "
            End If
        Next

        'Update Result textboxes
        txtBinaryResult.Text = strResults
        txtDecimalResult.Text = binaryToDecimal(strResults)
        txtHexResult.Text = binaryToHex(strResults)
    End Sub

    Private Sub btnOr_Click(sender As Object, e As EventArgs) Handles btnOr.Click
        '------------------------------------------------------------
        '-                Subprogram Name: btnOr_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to use the OR logical  -
        '- Operation on Value1 and Value2 binary values             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strBinaryValue1 - binary value 1                         -
        '-*strBinaryValue2 - binary value 2                         -
        '-*strResults - binary result                               -
        '------------------------------------------------------------

        Dim strBinaryValue1 As String = txtBinaryValue1.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strBinaryValue2 As String = txtBinaryValue2.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strResults As String = ""

        'Loops through 32 bit binary string
        For i As Integer = 0 To 31 Step 1

            'Checks if both binary strings have a value at i
            If strBinaryValue1.Length - 1 >= i Or strBinaryValue2.Length - 1 >= i Then


                If strBinaryValue1.Chars(i) = "1" Then 'If value1 bit is 1 
                    strResults = strResults & "1"
                ElseIf strBinaryValue2.Chars(i) = "1" Then 'If value2 bit is 1 
                    strResults = strResults & "1"
                Else
                    strResults = strResults & "0"
                End If
            Else
                strResults = strResults & "0"
            End If

            'Format binary results
            If (strResults.Length + 1) Mod 5 = 0 Then
                strResults = strResults & " "
            End If
        Next

        'Update Result textboxes
        txtBinaryResult.Text = strResults
        txtDecimalResult.Text = binaryToDecimal(strResults)
        txtHexResult.Text = binaryToHex(strResults)
    End Sub

    Private Sub btnXor_Click(sender As Object, e As EventArgs) Handles btnXor.Click
        '------------------------------------------------------------
        '-                Subprogram Name: btnXor_Click             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to use the XOR logical -
        '- Operation on Value1 and Value2 binary values             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strBinaryValue1 - binary value 1                         -
        '-*strBinaryValue2 - binary value 2                         -
        '-*strResults - binary result                               -
        '------------------------------------------------------------


        Dim strBinaryValue1 As String = txtBinaryValue1.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strBinaryValue2 As String = txtBinaryValue2.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strResults As String = ""

        'Loop through 32 bit binary string
        For i As Integer = 0 To 31 Step 1

            'Checks if either binary strings have a value at i
            If strBinaryValue1.Length - 1 >= i Or strBinaryValue2.Length - 1 >= i Then
                If (strBinaryValue1.Chars(i) = "0" And strBinaryValue2.Chars(i) = "1" Or
                    strBinaryValue1.Chars(i) = "1" And strBinaryValue2.Chars(i) = "0") Then
                    strResults = strResults & "1"
                Else
                    strResults = strResults & "0"
                End If
            Else
                strResults = strResults & "0"
            End If

            'Format binary string
            If (strResults.Length + 1) Mod 5 = 0 Then
                strResults = strResults & " "
            End If
        Next

        'Update Result textboxes
        txtBinaryResult.Text = strResults
        txtDecimalResult.Text = binaryToDecimal(strResults)
        txtHexResult.Text = binaryToHex(strResults)
    End Sub

    Private Sub btnNotvalue1_Click(sender As Object, e As EventArgs) Handles btnNotvalue1.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnNotvalue1_Click           -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to use the NOT logical -
        '- Operation on Value1 binary values                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strBinaryValue1 - binary value 1                         -
        '-*strResults - binary result                               -
        '------------------------------------------------------------

        Dim strBinaryValue1 As String = txtBinaryValue1.Text.Replace(" ", "").PadLeft(32, "0")
        Dim strResults As String = ""

        'Loop through 32 bit binary string
        For i As Integer = 0 To 31 Step 1
            If strBinaryValue1.Chars(i) = "1" Then
                strResults = strResults & "0"
            Else
                strResults = strResults & "1"
            End If

            'Format binary string
            If (strResults.Length + 1) Mod 5 = 0 Then
                strResults = strResults & " "
            End If
        Next

        'Update Result textboxes
        txtBinaryResult.Text = strResults
        txtDecimalResult.Text = binaryToDecimal(strResults)
        txtHexResult.Text = binaryToHex(strResults)
    End Sub
#End Region

End Class