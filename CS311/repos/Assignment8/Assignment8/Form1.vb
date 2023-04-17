'------------------------------------------------------------
'-              File Name : Form1.frm                       -
'-              Part of Project: Assignment8                -
'------------------------------------------------------------
'               Written By: Nathan VanSnepson               -
'               Written On: April 4, 2022                   -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the form logic to allow a user to     -
'- interact with a database                                 -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'-*DBAdaptOwner - Used for Insert, Update, and Select on the-
'- owners table                                             -
'-*DBAdaptVehicle - Used for Insert, Update, and Select on  -
'- the Vehicles table                                       -
'-*cmdBuilder - used to create insert statements for Owners -
'- table                                                    -
'-*dsOwners - DataSet to hold results from Select query     -
'-*dsVehicles - DataSet to hold results from Select query   -
'-*intPrevOwner - Holds the value of the previous Owner     -
'-*strButtonClicked - Which button was clicked              -
'-*strDBPATH - Path of the database file                    -
'-*strCONNECTION - Connection string to database            -
'-*myConn - Used for SQL code                               -
'------------------------------------------------------------

Imports System.Data.SqlClient

Public Class Form1

    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------
    Const strDBNAME As String = "VehicleOwners" 'Name of the database
    Const strServerName As String = "(localdb)\MSSQLLocalDB" 'Name of the database server

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
    'SQLDataAdapters to run queries such as Insert, Update, and Select
    Dim DBAdaptOwner As SqlDataAdapter
    Dim DBAdaptVehicle As SqlDataAdapter

    'Path to the database
    Dim strDBPATH As String = My.Application.Info.DirectoryPath & "\" & strDBNAME & ".mdf"
    'Connection string to connect to databse
    Dim strCONNECTION As String = "SERVER=" & strServerName & ";DATABASE=" & strDBNAME &
                                           ";Integrated Security=SSPI;AttachDbFileName=" & strDBPATH
    'DataSets to hold data from queries
    Dim dsOwners As New DataSet
    Dim dsVehicles As New DataSet

    'Used to hold the location of the prev owner when adding a new record
    Dim intPrevOwner As Integer

    'String to hold which button was held ("ADD" OR "UPDATE")
    Dim strButtonClicked As String

    'SQLCommandBuilder to build Update command
    Dim cmdBuilder As SqlCommandBuilder

    'We'll also create a SqlConnection object since we will execute some
    'straight SQL rather than relying on the DBAdapters...
    Dim myConn As New SqlConnection(strCONNECTION)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: Form1_Load                   -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to get data from the   -
        '- owners and vehicles tables and populating the controls   -
        '- with the information.                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strSQLCmd - String containing SQL code                   -
        '------------------------------------------------------------

        Dim strSQLCmd As String

        'Select All from Owners
        strSQLCmd = "SELECT * FROM Owners"
        DBAdaptOwner = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        cmdBuilder = New SqlCommandBuilder(DBAdaptOwner)
        DBAdaptOwner.InsertCommand = cmdBuilder.GetInsertCommand
        DBAdaptOwner.DeleteCommand = cmdBuilder.GetDeleteCommand
        dsOwners.Clear()
        DBAdaptOwner.Fill(dsOwners, "Owners")

        'Hide panel
        pnlSaveRecord.Visible = False

        'Set Text inputs to readonly
        SetReadOnly(True)

        'Set Bindings
        txtIDNumber.DataBindings.Add(New Binding("Text", dsOwners, "Owners.TUID"))
        txtNameFirst.DataBindings.Add(New Binding("Text", dsOwners, "Owners.FirstName"))
        txtNameLast.DataBindings.Add(New Binding("Text", dsOwners, "Owners.LastName"))
        txtAddress.DataBindings.Add(New Binding("Text", dsOwners, "Owners.StreetAddress"))
        txtCity.DataBindings.Add(New Binding("Text", dsOwners, "Owners.City"))
        txtState.DataBindings.Add(New Binding("Text", dsOwners, "Owners.State"))
        txtZipCode.DataBindings.Add(New Binding("Text", dsOwners, "Owners.ZipCode"))

        'Sets the first Vehicle record
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))

    End Sub

    Private Sub LoadVehicleRecord(ByVal intOwnerID)
        '------------------------------------------------------------
        '-            Subprogram Name: LoadVehicleRecord            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to return data from    -
        '- the Vehicles table based on an OnwersID                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*intOwnerID - TUID of the Owner                           -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*strSQLCmd - String containing SQL code                   -
        '------------------------------------------------------------

        Dim strSQLCmd As String

        'Load vehicles because it does not change while program runs
        strSQLCmd = "SELECT Make, Model, Color, ModelYear, VIN FROM Vehicles WHERE OwnerID = '" & intOwnerID & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        dsVehicles.Clear()
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")

        'Updates the dataGridViews datasource
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
    End Sub

    Private Sub SetReadOnly(ByVal blnValue As Boolean)
        '------------------------------------------------------------
        '-            Subprogram Name: SetReadOnly                  -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to update the readonly -
        '- property of textbox controls                             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*blnValue - Value to set readonly to                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        txtNameFirst.ReadOnly = blnValue
        txtNameLast.ReadOnly = blnValue
        txtAddress.ReadOnly = blnValue
        txtCity.ReadOnly = blnValue
        txtState.ReadOnly = blnValue
        txtZipCode.ReadOnly = blnValue
    End Sub

    Private Sub btnNextRec_Click(sender As Object, e As EventArgs) Handles btnNextRec.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnNextRec_Click             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to go to the next      -
        '- record                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Set the BindingConetext value to the next position
        BindingContext(dsOwners, "Owners").Position = (BindingContext(dsOwners,
                       "Owners").Position + 1)

        'Load Vehicle records for the Owner
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))
    End Sub

    Private Sub btnLastRec_Click(sender As Object, e As EventArgs) Handles btnLastRec.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnLastRec_Click             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to go to the last      -
        '- record                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Goes to the last record
        BindingContext(dsOwners, "Owners").Position = (BindingContext(dsOwners,
                       "Owners").Count - 1)

        'Load Vehicle records for the Owner
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))
    End Sub

    Private Sub btnPreviousRec_Click(sender As Object, e As EventArgs) Handles btnPreviousRec.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnPreviousRec_Click         -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to go to the previous  -
        '- record                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        'Goes to the previous record
        BindingContext(dsOwners, "Owners").Position = (BindingContext(dsOwners,
                       "Owners").Position - 1)

        'Load Vehicle records for the Owner
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))
    End Sub

    Private Sub btnFirstRec_Click(sender As Object, e As EventArgs) Handles btnFirstRec.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnFirstRec_Click            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to go to the first     -
        '- record                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Goes to the first record
        BindingContext(dsOwners, "Owners").Position = 0

        'Load Vehicle records for the Owner
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnAdd_Click                 -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Add an Owner record -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Sets the previously displayed Owner
        intPrevOwner = BindingContext(dsOwners, "Owners").Position

        'Sets the button that was clicked to be Add
        strButtonClicked = "Add"

        'Ends the Current Edit and Adds a new record into dsOwners
        BindingContext(dsOwners, "Owners").EndCurrentEdit()
        BindingContext(dsOwners, "Owners").AddNew()

        'Set textboxes readonly to false
        SetReadOnly(False)

        'Set default values for textboxes 
        txtIDNumber.Text = CType(dsOwners.Tables("Owners").Compute("Max(TUID)", ""), Integer) + 1
        txtNameFirst.Text = ""
        txtNameLast.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZipCode.Text = ""

        'Update dataGridViews dataSource
        dgvVehicles.DataSource = Nothing

        'Displays the Save and Cancel panel
        pnlRecordButtons.Visible = False
        pnlSaveRecord.Visible = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnCancel_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Cancel Add or Update-
        '- Operation                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If the Add button was clicked remove the new record from dsOwners
        If strButtonClicked = "Add" Then
            BindingContext(dsOwners, "Owners").RemoveAt(dsOwners.Tables("Owners").Rows.Count)
        End If

        'Updates the binding source to the prvious Owner
        BindingContext(dsOwners, "Owners").Position = intPrevOwner
        LoadVehicleRecord(CType(txtIDNumber.Text, Integer))

        'Sets textboxes to be readonly
        SetReadOnly(True)

        'Hides the save and cancel panel
        pnlRecordButtons.Visible = True
        pnlSaveRecord.Visible = False

        'Update button clicked to be empty string
        strButtonClicked = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnSave_Click                -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Save from the  Add  -
        '- or Update Operation                                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If Add was clicked then insert record into Owner
        If strButtonClicked = "Add" Then
            InsertOwner(strCONNECTION, txtIDNumber.Text, txtNameFirst.Text, txtNameLast.Text,
                        txtAddress.Text, txtCity.Text, txtState.Text, txtZipCode.Text)

            'If update was selected update the current user
        ElseIf strButtonClicked = "Update" Then
            'Stop any current edits.
            BindingContext(dsOwners, "Owners").EndCurrentEdit()

            Dim DBConn As SqlConnection
            Dim DBCmd As SqlCommand = New SqlCommand()

            'Now try to open up a connection to the database
            DBConn = New SqlConnection(strCONNECTION)
            DBConn.Open()


            'Updates Owners Table
            DBCmd.CommandText = "Update Owners " &
                             "Set FirstName = '" & txtIDNumber.Text & "', LastName = '" & txtNameLast.Text & "', " &
                             "StreetAddress = '" & txtAddress.Text & "', City = '" & txtCity.Text & "'," &
                             "State = '" & txtState.Text & "', ZipCode = '" & txtZipCode.Text & "'" &
                             "Where TUID = '" & txtIDNumber.Text & "'"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()


            'Update the dataset to correspond with database.
            dsOwners.AcceptChanges()

        End If

        'Sets the button clicked to an empty String
        strButtonClicked = ""

        'Hides the Save and Cancel Panel
        pnlRecordButtons.Visible = True
        pnlSaveRecord.Visible = False

        'Sets textboxes to be readonly
        SetReadOnly(True)

        'Loads Vehicle records with new OwnerID
        LoadVehicleRecord(txtIDNumber.Text)
    End Sub

    Private Sub InsertOwner(ByVal strConn, ByVal strTUID, ByVal strFirstName, ByVal strLastName, ByVal strStreetAddress, ByVal strCity,
                             ByVal strState, ByVal strZipCode)
        '------------------------------------------------------------
        '-                Subprogram Name: InsertOwner              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Insert a record into-
        '- the Owners table                                         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*strConn - Connection string to database                  -
        '-*strTUID - OwnerID                                        -
        '-*strFirstName - Owners first name                         -
        '-*strLastName - Onwers Last name                           -
        '-*strStreetAddress - Onwers Street Address                 -
        '-*strCity - Owners City                                    -
        '-*strState - Owners State                                  -
        '-*strZipCode - Owners ZipCode                              -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*DBConn - SQLConnection used to connect database          -
        '-*DBCmd - SqlCommand for running sql code                  -
        '------------------------------------------------------------

        Dim DBConn As SqlConnection
        Dim DBCmd As SqlCommand = New SqlCommand()

        'Now try to open up a connection to the database
        DBConn = New SqlConnection(strConn)
        DBConn.Open()

        'Insert to Owners Table
        DBCmd.CommandText = "INSERT INTO Owners (TUID, FirstName, LastName, 
                             StreetAddress, City, State, ZipCode) " &
   "VALUES (" & strTUID & ", '" & strFirstName & "','" & strLastName & "','" & strStreetAddress & "', 
            '" & strCity & "', '" & strState & "', '" & strZipCode & "')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()

        'Close the database connection
        DBConn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnUpdate_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Update an Owner     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Sets textboxes readonly to be false
        SetReadOnly(False)

        'Sets button clicked to Update
        strButtonClicked = "Update"

        'Displays the Save and Cancel Panel
        pnlRecordButtons.Visible = False
        pnlSaveRecord.Visible = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnDelete_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to Delete and Owner    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*DBConn - SQL Connection to database                      -
        '-*DBCmd - SQL Command to run on database                   -
        '-*strSQLCmd - SQL Code                                     -
        '------------------------------------------------------------

        Dim DBConn As SqlConnection
        Dim DBCmd As SqlCommand = New SqlCommand()
        Dim strSQLCmd As String

        'Now try to open up a connection to the database
        DBConn = New SqlConnection(strCONNECTION)
        DBConn.Open()

        'Confirm to delete the recorrd
        If MessageBox.Show("Are you sure you want to delete this record?", "",
                   MessageBoxButtons.YesNo) = DialogResult.Yes Then

            'Use SQL DML to zap the contents of the table
            DBCmd.CommandText = "DELETE FROM Vehicles Where OwnerID = '" & txtIDNumber.Text & "'"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()

            'Use SQL DML to zap the contents of the table
            DBCmd.CommandText = "DELETE FROM Owners Where TUID = '" & txtIDNumber.Text & "'"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()

            'Updates Owners
            strSQLCmd = "SELECT * FROM Owners"
            DBAdaptOwner = New SqlDataAdapter(strSQLCmd, strCONNECTION)
            dsOwners.Clear()
            DBAdaptOwner.Fill(dsOwners, "Owners")
        End If

        'Closes the connection
        DBConn.Close()
    End Sub
End Class
