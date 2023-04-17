'------------------------------------------------------------
'-              File Name : Form1.frm                       -
'-              Part of Project: Assignment4                -
'------------------------------------------------------------
'               Written On: February 16, 2022               -
'               Written By: Nathan VanSnepson               -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the main form for the entire applic-  -
'- ation. It interacts with the user and displays dish      -
'- information, prepped items information, and raw items    -
'- information. It allows the user to connect raw items to  -
'- prepped items and prepped items to dishes.               -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- The purpose of this program is to display the breakdown  -
'- of dishes, showing the prepped items and raw items that  -
'- are attached. Also, it allows the user to build new      -
'- dishes.
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- dictDishes - Dictionary that has a key of String(Dish)   -
'- and value of dictionary wich has a key of String(Prepped)-
'- and a value of dictionary which has a key of String(Raw) -
'- and a value of String(Raw)                               -
'- dictPrepped - Dictionary that has a key of String(Prepped-
'- ) and a value of dictionary that has key of String(Raw)  -
'- and a value of String(Raw)                               -
'- dictRaw - Dictionary that has a key of String(Raw) and a -
'- value of String(Raw)                                     -
'------------------------------------------------------------

Public Class Form1

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

    Dim dictDishes As New SortedDictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))(StringComparer.InvariantCultureIgnoreCase)
    Dim dictPrepped As New SortedDictionary(Of String, Dictionary(Of String, String))(StringComparer.InvariantCultureIgnoreCase)
    Dim dictRaw As New SortedDictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase)


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub populateDictionaries()
        '------------------------------------------------------------
        '-         Subprogram Name: populateDictionaries           -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to prepopulate the     -
        '- dictionaries.
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (none)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Put default ingredients into dictRaw
        dictRaw.Add("Basket", "Basket")
        dictRaw.Add("Beef Patty", "Beef Patty")
        dictRaw.Add("Bun", "Bun")
        dictRaw.Add("Chicken", "Chicken")
        dictRaw.Add("Glass", "Glass")
        dictRaw.Add("Grapes", "Grapes")
        dictRaw.Add("Ketchup", "Ketchup")
        dictRaw.Add("Lettuce", "Lettuce")
        dictRaw.Add("Mayonnaise", "Mayonnaise")
        dictRaw.Add("Mustard", "Mustard")
        dictRaw.Add("Oil", "Oil")
        dictRaw.Add("Onions", "Onions")
        dictRaw.Add("Pickles", "Pickles")
        dictRaw.Add("Plate", "Plate")
        dictRaw.Add("Potatoes", "Potatoes")
        dictRaw.Add("Sugar", "Sugar")
        dictRaw.Add("Syrup", "Syrup")
        dictRaw.Add("Water", "Water")

        'Insert default prepped items into dictPrepped
        dictPrepped.Add("Hamburger", New Dictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase))
        dictPrepped.Item("Hamburger").Add("Beef Patty", "Beef Patty")
        dictPrepped.Item("Hamburger").Add("Bun", "Bun")
        dictPrepped.Item("Hamburger").Add("Ketchup", "Ketchup")
        dictPrepped.Item("Hamburger").Add("Mustard", "Mustard")
        dictPrepped.Item("Hamburger").Add("Onions", "Onions")
        dictPrepped.Item("Hamburger").Add("Pickles", "Pickles")
        dictPrepped.Item("Hamburger").Add("Plate", "Plate")

        dictPrepped.Add("Fries", New Dictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase))
        dictPrepped.Item("Fries").Add("Potatoes", "Potatoes")
        dictPrepped.Item("Fries").Add("Basket", "Basket")

        dictPrepped.Add("Chicken Salad", New Dictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase))
        dictPrepped.Item("Chicken Salad").Add("Chicken", "Chicken")
        dictPrepped.Item("Chicken Salad").Add("Lettuce", "Lettuce")


        'Insert default dishes into dictDishes
        dictDishes.Add("Chicken Salad Platter", New Dictionary(Of String, Dictionary(Of String, String))(StringComparer.InvariantCultureIgnoreCase))
        dictDishes.Item("Chicken Salad Platter").Add("Chicken Salad", dictPrepped.Item("Chicken Salad"))

        dictDishes.Add("Hamburger Platter", New Dictionary(Of String, Dictionary(Of String, String))(StringComparer.InvariantCultureIgnoreCase))
        dictDishes.Item("Hamburger Platter").Add("Hamburger", dictPrepped.Item("Hamburger"))
        dictDishes.Item("Hamburger Platter").Add("Fries", dictPrepped.Item("Fries"))
    End Sub

    Private Sub populateRaw()
        '------------------------------------------------------------
        '-            Subprogram Name: populateRaw                  -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate listbox    -
        '- lstRaw with all the raw items in dictRaw                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (none)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears the listbox
        lstRaw.Items.Clear()

        'Loops through raw items to fill listbox
        For Each raw As String In dictRaw.Keys
            lstRaw.Items.Add(raw)
        Next
    End Sub

    Private Sub populatePrepped()
        '------------------------------------------------------------
        '-            Subprogram Name: populatePrepped              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate listbox    -
        '- lstPrepped with all the prepped items in dictPrepped     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (none)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears the listbox
        lstPrepped.Items.Clear()

        'Loops through prepped items to fill listbox
        For Each prepped As String In dictPrepped.Keys
            lstPrepped.Items.Add(prepped)
        Next
    End Sub

    Private Sub populateDishes()
        '------------------------------------------------------------
        '-            Subprogram Name: populateDishes               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate listbox    -
        '- lstDishes with all the dishes in dictDishes              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (none)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears the listbox
        lstDishes.Items.Clear()

        'Loops through dishes to fill listbox
        For Each dishes As String In dictDishes.Keys
            lstDishes.Items.Add(dishes)
        Next
    End Sub

    Private Sub populateSelectedRaw(preppedItem As String)
        '------------------------------------------------------------
        '-          Subprogram Name: populateSelectedRaw            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate listbox    -
        '- lstSelectedRaw with all the raw items associated with a  -
        '- given prepped item.                                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- preppedItem - A prepped item that comes from dictPrepped -
        '- to access its raw items                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears the listbox
        lstSelectedRaw.Items.Clear()

        'Loops through raw items for a prepped item to fill listbox
        For Each rawItem As String In dictPrepped.Item(preppedItem).Keys
            lstSelectedRaw.Items.Add(rawItem)
        Next
    End Sub

    Private Sub populateSelectedPrepped(dish As String)
        '------------------------------------------------------------
        '-       Subprogram Name: populateSelectedPrepped           -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate listbox    -
        '- lstSelectedPrepped with all the prepped items associated -
        '- with a given dish.                                       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- dish - A dish that comes from dictDishes to access its   -
        '- prepped items                                            -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears the listbox
        lstSelectedPrepped.Items.Clear()

        'Loops through raw items for a prepped item to fill listbox
        For Each preppedItem As String In dictDishes.Item(dish).Keys
            lstSelectedPrepped.Items.Add(preppedItem)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: Form1_Load                   -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to prepopulate all the -
        '- dictionaries, then populate the listboxes that show all  -
        '- the associated items.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Prepopulates dictionaries
        populateDictionaries()

        'Populates lstRaw
        populateRaw()

        'Populates lstPrepped
        populatePrepped()

        'Populates lstDishes
        populateDishes()
    End Sub

    Private Sub btnAddRaw_Click(sender As Object, e As EventArgs) Handles btnAddRaw.Click
        '------------------------------------------------------------
        '-          Subprogram Name: btnAddRaw_Click                -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add new raw items to-
        '- dictRaw and repopulate lstRaw.                           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpAddRaw.Clear()

        'Checks for valid raw item entry
        If dictRaw.ContainsKey(txtAddRaw.Text) Or txtAddRaw.Text.Length = 0 Then
            'displays error to use if invalid entry
            erpAddRaw.SetError(txtAddRaw, "Raw ingredient already exists or is empty")
        Else
            'add raw item to dictRaw
            dictRaw.Add(txtAddRaw.Text, txtAddRaw.Text)

            'repopulate lstRaw
            populateRaw()
        End If

    End Sub

    Private Sub btnAddPrepped_Click(sender As Object, e As EventArgs) Handles btnAddPrepped.Click
        '------------------------------------------------------------
        '-          Subprogram Name: btnAddPrepped_Click            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add new prepped     -
        '- items to dictPrepped and repopulate lstPrepped           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpAddPrepped.Clear()

        'Checks for valid prepped item entry
        If dictPrepped.ContainsKey(txtAddPrepped.Text) Or txtAddPrepped.Text.Length = 0 Then
            'displays error to use if invalid entry
            erpAddPrepped.SetError(txtAddPrepped, "Raw ingredient already exists or is empty")
        Else
            'add prepped item to dictPrepped
            dictPrepped.Add(txtAddPrepped.Text, New Dictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase))

            'repopulate lstPrepped
            populatePrepped()
        End If
    End Sub

    Private Sub btnAddDish_Click(sender As Object, e As EventArgs) Handles btnAddDish.Click
        '------------------------------------------------------------
        '-          Subprogram Name: btnAddDish_Click               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add new dishes to   -
        '- dictDishes and repopulate lstDishes                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpAddDish.Clear()

        'Checks for valid prepped item entry
        If dictDishes.ContainsKey(txtAddDish.Text) Or txtAddDish.Text.Length = 0 Then
            'displays error to use if invalid entry
            erpAddDish.SetError(txtAddDish, "Raw ingredient already exists or is empty")
        Else
            'add dish to dictDishes
            dictDishes.Add(txtAddDish.Text, New Dictionary(Of String, Dictionary(Of String, String))(StringComparer.InvariantCultureIgnoreCase))

            'repopulate lstDishes
            populateDishes()
        End If
    End Sub

    Private Sub lstPrepped_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrepped.SelectedIndexChanged
        '------------------------------------------------------------
        '-    Subprogram Name: lstPrepped_SelectedIndexChanged      -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate            -
        '- lstSelectedRaw with the associated raw items for a       -
        '- selected prepped item                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If there is 1 prepped item selected in lstPrepped
        If lstPrepped.SelectedItems.Count = 1 Then
            'Populate lstSelectedRaw with associated raw items
            populateSelectedRaw(lstPrepped.SelectedItem.ToString())
        End If
    End Sub



    Private Sub lstDishes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDishes.SelectedIndexChanged
        '------------------------------------------------------------
        '-    Subprogram Name: lstDishes_SelectedIndexChanged       -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to populate            -
        '- lstSelectedprepped with the associated prepped items for -
        '- a selected dish                                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If there is 1 dish selected
        If lstDishes.SelectedIndex > -1 Then
            'Populate lstSelectedPrepped with associated prepped items
            populateSelectedPrepped(lstDishes.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnSelectRaw_Click(sender As Object, e As EventArgs) Handles btnSelectRaw.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnSelectRaw_Click            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add selected raw    -
        '- items from lstRaw to the prepped item, then update       -
        '- lstSelectedRaw                                           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpSelectedRaw.Clear()

        'Checks if no raw items were selected
        If lstRaw.SelectedItems.Count = 0 Then
            'Display error, select a raw item
            erpSelectedRaw.SetError(btnSelectRaw, "Select Raw Items to add!")

            'Chckes if no prepped items were selected
        ElseIf lstPrepped.SelectedItems.Count = 0 Then
            'Display error, select a prepped item
            erpSelectedRaw.SetError(btnSelectRaw, "Select Prepped Item to add raw Items!")

            'Checks if only 1 prepped item was selected
        ElseIf lstPrepped.SelectedItems.Count = 1 Then

            'Checks if prepped item is not an empty item
            If lstPrepped.SelectedItem.ToString().Length > -1 Then

                'Loops through selected raw items and adds them to the proper prepped item
                For Each rawItem As String In lstRaw.SelectedItems
                    If Not dictPrepped.Item(lstPrepped.SelectedItem.ToString()).ContainsKey(rawItem) Then
                        dictPrepped.Item(lstPrepped.SelectedItem.ToString()).Add(rawItem, rawItem)
                    End If
                Next
            End If

            'Repopulates lstSelectedRaw
            populateSelectedRaw(lstPrepped.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnDeselectRaw_Click(sender As Object, e As EventArgs) Handles btnDeselectRaw.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnDeselectRaw_Click          -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to remove selected raw -
        '- items from lstSelectedRaw from the prepped item, then    -
        '- update lstSelectedRaw                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------


        'Clears error, removes it from screen
        erpRemoveSelectedRaw.Clear()

        'If no raw items were selected 
        If lstSelectedRaw.SelectedItems.Count = 0 Then
            'Display error, select raw items to remove
            erpRemoveSelectedRaw.SetError(btnDeselectRaw, "Select Raw Items to remove!")

            'If more or less than 1 prepped item was selected
        ElseIf lstPrepped.SelectedItems.Count <> 1 Then
            'Display error, only select 1 raw item
            erpRemoveSelectedRaw.SetError(btnDeselectRaw, "Select only one prepped item to remove Raw Items!")
        Else
            'Loops through selected raw items and removes them from the proper prepped item
            For Each rawItem As String In lstSelectedRaw.SelectedItems
                dictPrepped.Item(lstPrepped.SelectedItem.ToString()).Remove(rawItem)
            Next

            'Repopulates lstSelectedRaw
            populateSelectedRaw(lstPrepped.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnSelectPrepped_Click(sender As Object, e As EventArgs) Handles btnSelectPrepped.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnSelectPrepped_Click        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to add selected prepped-
        '- items from lstPrepped to the dish, then update           -
        '- lstSelectedPrepped                                       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpSelectedPrepped.Clear()

        'If no prepped items were selected
        If lstPrepped.SelectedItems.Count = 0 Then
            'Display error, select prepped items 
            erpSelectedPrepped.SetError(btnSelectPrepped, "Select Prepped Items to add!")

            'If no dishes were selected
        ElseIf lstDishes.SelectedItems.Count = 0 Then
            'Display error, select dish
            erpSelectedPrepped.SetError(btnSelectPrepped, "Select Dish to add Prepped Items!")

            'If only 1 dish was selected
        ElseIf lstDishes.SelectedItems.Count = 1 Then

            'if selected prepped item is not empty String
            If lstPrepped.SelectedItem.ToString().Length > -1 Then

                'Loop through selected Prepped items and add them to the proper dish
                For Each preppedItem As String In lstPrepped.SelectedItems
                    If Not dictDishes.Item(lstDishes.SelectedItem.ToString()).ContainsKey(preppedItem) Then
                        dictDishes.Item(lstDishes.SelectedItem.ToString()).Add(preppedItem, dictPrepped.Item(preppedItem))
                    End If
                Next

                'Repopulate lstSelectedPrepped
                populateSelectedPrepped(lstDishes.SelectedItem.ToString())
            End If
        End If

    End Sub

    Private Sub btnDeslectPrepped_Click(sender As Object, e As EventArgs) Handles btnDeslectPrepped.Click
        '------------------------------------------------------------
        '-           Subprogram Name: btnDeslectPrepped_Click       -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 16, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to remove selected     -
        '- prepped items from lstSelectedPrepped from the dish, then-
        '- update lstSelectedPrepped                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Clears error, removes it from screen
        erpRemoveSelectedPrepped.Clear()

        'Checks if no prepped items were selected
        If lstSelectedPrepped.SelectedItems.Count = 0 Then
            'Display error, select prepped items 
            erpRemoveSelectedPrepped.SetError(btnDeslectPrepped, "Select Prepped Items to remove!")

            'If more or less than 1 dish is selected
        ElseIf lstDishes.SelectedItems.Count <> 1 Then
            'Display error, Select a dish to remove prepped items
            erpRemoveSelectedPrepped.SetError(btnDeslectPrepped, "Select a Dish to remove Prepped Items!")
        Else

            'Loops through selected prepped items and removes them from the proper dish
            For Each preppedItem As String In lstSelectedPrepped.SelectedItems
                dictDishes.Item(lstDishes.SelectedItem.ToString()).Remove(preppedItem)
            Next

            'repopulates lstSelectedPrepped
            populateSelectedPrepped(lstDishes.SelectedItem.ToString())
        End If
    End Sub
End Class
