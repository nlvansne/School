Public Class KustomKarzForm
    '------------------------------------------------------------
    '-          File Name : KustomKarzInvoiceForm.frm           -
    '-              Part of Project: KustomKarz                 -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: January 26, 2022                -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the logic for the KustomKarzForm to   -
    '- allow a buyer to select kar options then create an       -
    '- invoice to submit to manufacturing.                      -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '                                                           -
    '- blnAllowClose - Determines if the form can be closed.    -
    '- frmKustomKarzInvoice - an instance of KustomKarzInvoice- -
    '- Form to display the invoice.                             -
    '- udtKustomKarzSelections - structure containing all the   -
    '- options and pricing selected from the buyer.             -
    '------------------------------------------------------------



    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------

    'Constants for Car Type cost
    Const COUPE = 10000
    Const LUXURY = 20000
    Const SEDAN = 17000
    Const SPORTS_EDITION = 25000
    Const SUV = 27000

    'Constants for Drive Train cost
    Const V12 = 7500
    Const V8 = 2500
    Const V6 = 1000
    Const V4 = 500
    Const HYBRID = 3000
    Const ELECTRIC = 6000

    'Constant for cost of each option
    Const COST_PER_OPTION = 750



    '-------------------------------------------------------------------------------------------
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '-------------------------------------------------------------------------------------------

    'Structure for holding the options and prices from buyers selection
    Structure udtKustomKarzSelectionStruct
        Dim strCustomerName As String
        Dim strCarType As String
        Dim intCarTypeCost As Integer
        Dim intQuantity As Integer
        Dim strDriveTrainSelect As String
        Dim intDriveTrainCost As Integer
        Dim arrOptions As ArrayList
        Dim intCostPerOption As Integer
    End Structure


    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------

    Dim frmKustomKarzInvoice As KustomKarzInvoiceForm
    Public blnAllowClose As Boolean
    Public udtKustomKarzSelections As udtKustomKarzSelectionStruct



    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------


    Public Sub New()

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
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' This call is required by the designer.
        InitializeComponent()

        'Defaults to false to prevent form from closing
        blnAllowClose = False
    End Sub


    Private Sub btnPlaceCarOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceCarOrder.Click
        '------------------------------------------------------------
        '-            Subprogram Name: frmMain_Load                 -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: January 26, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to read from an emplo- -
        '- yee text file and display existing Employees. If no emp- -
        '- oyees exist then it displays for the user to add a new   -
        '- employee.                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '- sender - reference to the object that raised the event   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- arrOptions - ArrayList of the options the buyer selected.-
        '- intCarTypeCost - Cost of the type of car buyer selected. -
        '- intDriveTrainSelection - Cost of the drive train buyer   -
        '- selected.                                                -
        '- strDriveTrainSelection - Name of the drive train the     -
        '- buyer selected.                                          -
        '------------------------------------------------------------

        Dim intCarTypeCost As Integer 'Cost of the selected car type
        Dim intDriveTrainSelection As Integer 'Cost of the seleted drive train
        Dim strDriveTrainSelection As String 'The name of the selected drive train
        Dim arrOptions = New ArrayList 'List of added options


        'If statements to check for correct input from the user
        If txtCustomerName.Text.Length = 0 Then
            MessageBox.Show("Enter the Customers Name!")
            Return
        ElseIf lstCarType.SelectedIndex < 0 Then
            MessageBox.Show("Select a Car Type!")
            Return
        ElseIf updQuantity.Value <= 0 Then
            MessageBox.Show("Enter the quantity of cars you want!")
            Return
        End If


        'Finds which car type was selected and 
        If lstCarType.SelectedItem.ToString = "Coupe" Then
            intCarTypeCost = COUPE
        ElseIf lstCarType.SelectedItem.ToString = "Luxury" Then
            intCarTypeCost = LUXURY
        ElseIf lstCarType.SelectedItem.ToString = "Sedan" Then
            intCarTypeCost = SEDAN
        ElseIf lstCarType.SelectedItem.ToString = "Sports Edition" Then
            intCarTypeCost = SPORTS_EDITION
        ElseIf lstCarType.SelectedItem.ToString = "SUV" Then
            intCarTypeCost = SUV
        End If


        'Checks gbDriveTrainSelect to find selected drive train. If none display
        'to user to select one
        If rbV12.Checked Then
            intDriveTrainSelection = V12
            strDriveTrainSelection = rbV12.Text
        ElseIf rbV8.Checked Then
            intDriveTrainSelection = V8
            strDriveTrainSelection = rbV8.Text
        ElseIf rbV6.Checked Then
            intDriveTrainSelection = V6
            strDriveTrainSelection = rbV6.Text
        ElseIf rbV4.Checked Then
            intDriveTrainSelection = V4
            strDriveTrainSelection = rbV4.Text
        ElseIf rbHybrid.Checked Then
            intDriveTrainSelection = HYBRID
            strDriveTrainSelection = rbHybrid.Text
        ElseIf rbElectric.Checked Then
            intDriveTrainSelection = ELECTRIC
            strDriveTrainSelection = rbElectric.Text
        Else
            MessageBox.Show("Choose a Drive Train Selection!")
            Return
        End If


        'If statements to add selected Options from gbOptions
        'to an arrayList
        If chkLeatherSeats.Checked Then
            arrOptions.Add(chkLeatherSeats.Text)
        End If

        If chkHeatedSeats.Checked Then
            arrOptions.Add(chkHeatedSeats.Text)
        End If

        If chkRearDefroster.Checked Then
            arrOptions.Add(chkRearDefroster.Text)
        End If

        If chkAirConditioning.Checked Then
            arrOptions.Add(chkAirConditioning.Text)
        End If

        If chkPremiumStereo.Checked Then
            arrOptions.Add(chkPremiumStereo.Text)
        End If

        If chkCDMP3Connections.Checked Then
            arrOptions.Add(chkCDMP3Connections.Text)
        End If

        If chkBluetooth.Checked Then
            arrOptions.Add(chkBluetooth.Text)
        End If

        If chkGPS.Checked Then
            arrOptions.Add(chkGPS.Text)
        End If

        If chkEntertainmentPackage.Checked Then
            arrOptions.Add(chkEntertainmentPackage.Text)
        End If


        'Create a new instance of udtKustomKarzSelectionStruct Structure
        udtKustomKarzSelections = New udtKustomKarzSelectionStruct


        'Sets all the variables in the structure to their appropriate value
        With udtKustomKarzSelections
            .strCustomerName = txtCustomerName.Text
            .strCarType = lstCarType.SelectedItem.ToString
            .intCarTypeCost = intCarTypeCost
            .intQuantity = updQuantity.Value
            .strDriveTrainSelect = strDriveTrainSelection
            .intDriveTrainCost = intDriveTrainSelection
            .arrOptions = arrOptions
            .intCostPerOption = COST_PER_OPTION
        End With


        'Create a new KustomKarzInvoiceForm
        frmKustomKarzInvoice = New KustomKarzInvoiceForm(Me)

        'Hide KustomKarzForm
        Me.Hide()

        'Display KustomKarzInvoiceForm
        frmKustomKarzInvoice.ShowDialog()

    End Sub


    Private Sub KustomKarzForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '------------------------------------------------------------
        '-      Subprogram Name: KustomKarzForm_FormClosing         -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: January 26, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to handle closing the  -
        '- form properly and prevent the buyer from closing out     -
        '- while KustomKarzForm is displayed.                       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '- sender - reference to the object that raised the event   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If the form is not allowed to close prevent it from closing
        If Not blnAllowClose Then
            MessageBox.Show("Sorry but the application can only be closed on the Invoice Screeen" & vbNewLine &
                    "Please press Place Order to go to that screen...")
            e.Cancel = True
        End If
    End Sub


    Public Sub resetFormControls()
        '------------------------------------------------------------
        '-           Subprogram Name: resetFormControls             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: January 26, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to reset all the       -
        '- controls to blank fields to allow a new order to be made -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '- sender - reference to the object that raised the event   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Customer Name
        txtCustomerName.Text = ""

        'Car Type
        lstCarType.SelectedIndex = -1

        'Quantity
        updQuantity.Value = 0

        'Drive Train Select  (gbDriveTrainSelect)
        rbV12.Checked = False
        rbV8.Checked = False
        rbV6.Checked = False
        rbV4.Checked = False
        rbHybrid.Checked = False
        rbElectric.Checked = False

        'Options (gbOptions)
        chkLeatherSeats.Checked = False
        chkHeatedSeats.Checked = False
        chkRearDefroster.Checked = False
        chkAirConditioning.Checked = False
        chkPremiumStereo.Checked = False
        chkCDMP3Connections.Checked = False
        chkBluetooth.Checked = False
        chkGPS.Checked = False
        chkEntertainmentPackage.Checked = False

    End Sub

End Class