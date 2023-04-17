Public Class KustomKarzInvoiceForm

    '------------------------------------------------------------
    '-          File Name : KustomKarzInvoiceForm.frm           -
    '-              Part of Project: KustomKarz                 -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: January 26, 2022                -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the logic for the Invoice form. This  -
    '- form displays the cost breakdown for a kar order and     -
    '- submits the order for manufacturing or allows the kar    -
    '- order to be updated.                                     -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is for a kar buyer to select -
    '- kar options and then create an invoice showing the total -
    '- cost of the kar manufacturing. It then can be submitted  -
    '- to manufacturing or the order can be updated.            -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- blnExitClicked - True if user tries to exit the           -
    '- application.                                             -
    '- frmKustomKarz - Reference to an instance of KustomKarz-  -
    '- Form.                                                    -
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
    Dim blnExitClicked As Boolean
    Dim frmKustomKarz



    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------


    Public Sub New(ByRef frmKustomKarz)
        '------------------------------------------------------------
        '-                  Subprogram Name: New                    -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is initialize the form    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- frmKustomKarz - Reference to an instance of KustomKarz-  -
        '- Form.                                                    -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.frmKustomKarz = frmKustomKarz

        'Sets boolean to true, true when user exits application
        blnExitClicked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '------------------------------------------------------------
        '-             Subprogram Name: btnExit_Click               -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram close the program.        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Updates boolean when user exits
        blnExitClicked = True

        'Closes the form
        Me.Close()
    End Sub

    Private Sub KustomKarzInvoiceForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '------------------------------------------------------------
        '-   Subprogram Name: KustomKarzInvoiceForm_FormClosing     -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to update a boolean    -
        '- value in the referenced frmKustomKarz to allow it to     -
        '- close.                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Prompt user if they want to quit 
        If blnExitClicked Then
            If MessageBox.Show("Are you sure you want to quit?",
                                              "Kustom Karz Order System",
                                              MessageBoxButtons.YesNo) = DialogResult.No Then
                'Updates to not exit the form
                blnExitClicked = True

                'Cancels exiting the form
                e.Cancel = True
                Return
            End If
        End If

        'Closes KustomKarzForm
        frmKustomKarz.blnAllowClose = True
    End Sub

    Private Sub btnSubmitToManufacturing_Click(sender As Object, e As EventArgs) Handles btnSubmitToManufacturing.Click
        '------------------------------------------------------------
        '-    Subprogram Name: btnSubmitToManufacturing_Click       -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to submit the invoice  -
        '- to manufacturing and display a new selection form.       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Resets control values to default values in frmKustomKarz
        frmKustomKarz.resetFormControls()

        'Closes the form without prompting user
        blnExitClicked = False

        'Closes the invoice form
        Me.Close()

        'Prevents frmKustomKarz from being closed
        frmKustomKarz.blnAllowClose = False

        'Displays frmKustomKarz
        frmKustomKarz.show()
    End Sub

    Private Sub KustomKarzInvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-      Subprogram Name: KustomKarzInvoiceForm_Load         -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to display the invoice.-
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- intGrandTotal - Total cost of all vehicles               -
        '- intOptionCostPerVehicle - Total option cost per vehicle  -
        '- intPerVehicleTotal - Total cost per vehicle              -
        '- strInvoice - String to create the invoice                -
        '------------------------------------------------------------

        Dim strInvoice As String
        Dim intPerVehicleTotal As Integer
        Dim intGrandTotal As Integer
        Dim intOptionCostPerVehicle As Integer

        'Creating string for invoice output
        strInvoice = "====================================================================================" & vbNewLine &
                     vbTab & vbTab & vbTab & vbTab & "Kustom Karz Order" & vbNewLine &
                     "====================================================================================" & vbNewLine &
                     "" & vbNewLine &
                     "Getting ready to Kustom manufacture for " & frmKustomKarz.udtKustomKarzSelections.strCustomerName & vbNewLine &
                     "" & vbNewLine &
                     "There will be " & frmKustomKarz.udtKustomKarzSelections.intQuantity & " car(s) kustom built" & vbNewLine &
                     "" & vbNewLine &
                     "Karfrom factor : " & frmKustomKarz.udtKustomKarzSelections.strCarType & " at " & FormatCurrency(frmKustomKarz.udtKustomKarzSelections.intCarTypeCost) & vbNewLine &
                     "" & vbNewLine &
                     "Selected drive train : " & frmKustomKarz.udtKustomKarzSelections.strDriveTrainSelect & " at " & FormatCurrency(frmKustomKarz.udtKustomKarzSelections.intDriveTrainCost) & vbNewLine &
                     "" & vbNewLine &
                     "Here are the options requested:" & vbNewLine

        'Loopts through arrOptions to add all the options the buyer selected
        For Each strOption In frmKustomKarz.udtKustomKarzSelections.arrOptions
            strInvoice += vbTab & strOption & vbNewLine
        Next

        'If the buyer selected options find the total cost of them, 
        'else set the options cost to 0
        If frmKustomKarz.udtKustomKarzSelections.arrOptions.Count > 0 Then
            intOptionCostPerVehicle = frmKustomKarz.udtKustomKarzSelections.arrOptions.Count * frmKustomKarz.udtKustomKarzSelections.intCostPerOption
        Else
            intOptionCostPerVehicle = 0
        End If

        'Sets the total cost per vehicle
        intPerVehicleTotal = frmKustomKarz.udtKustomKarzSelections.intCarTypeCost + intOptionCostPerVehicle + frmKustomKarz.udtKustomKarzSelections.intDriveTrainCost

        'Sets the grand total of all the cars
        intGrandTotal = intPerVehicleTotal * frmKustomKarz.udtKustomKarzSelections.intQuantity

        strInvoice += frmKustomKarz.udtKustomKarzSelections.arrOptions.Count & " Options Selected for a total of " + FormatCurrency(intOptionCostPerVehicle) & vbNewLine

        strInvoice += "" & vbNewLine &
                      "" & vbNewLine &
                      "Per vehicle total: " & vbTab & vbTab & FormatCurrency(intPerVehicleTotal) & vbNewLine &
                      "***************************************************************************" & vbNewLine &
                      "Quantity Ordered: " & vbTab & vbTab & frmKustomKarz.udtKustomKarzSelections.intQuantity & vbNewLine &
                      "***************************************************************************" & vbNewLine &
                      "Grand Total: " & vbTab & vbTab & FormatCurrency(intGrandTotal) & vbNewLine &
                      "" & vbNewLine &
                      "===================================================================================="

        'Sets the textbox to display the invoice
        txtDisplayInvoice.Text = strInvoice
    End Sub

    Private Sub btnChangeOrder_Click(sender As Object, e As EventArgs) Handles btnChangeOrder.Click
        '------------------------------------------------------------
        '-         Subprogram Name: btnChangeOrder_Click            -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to allow go to the     -
        '- selection form to update the order.                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '- sender - reference to the object that raised the event   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '------------------------------------------------------------

        'Closes the form without prompting user
        blnExitClicked = False

        'Closes the invoice form
        Me.Close()

        'Prevents selection form from being closed
        frmKustomKarz.blnAllowClose = False

        'Displays the selection form
        frmKustomKarz.show()
    End Sub
End Class