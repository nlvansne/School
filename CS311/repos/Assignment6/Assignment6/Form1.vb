Public Class Form1

    '------------------------------------------------------------
    '-              File Name : Form1.vb                        -
    '-              Part of Project: Assignment6                -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: March 21, 2022                  -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file is the main form for assignment 6. It is the   -
    '- MDI container of the calculator forms.                   -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to create multiple caluc- -
    '- ator forms in an MDI parent. The caluclator forms are    -
    '- used for hex/binary/decimal conversions.                 -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- (None)                                                   -
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


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        '------------------------------------------------------------
        '-           Subprogram Name: mnuHelpAbout_Click            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to show the about form -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Displays the about form
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        '------------------------------------------------------------
        '-           Subprogram Name: mnuFileNew_Click              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to abstantiate and     -
        '- initialize a new Calculator form and add it to MDI.      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Create a child Calculator
        Dim frmCalculator As Calculator = New Calculator()


        'Hook child to the parent
        frmCalculator.MdiParent = Me

        'Show the child
        frmCalculator.Show()
    End Sub

    Private Sub mnuWindowTile_Click(sender As Object, e As EventArgs) Handles mnuWindowTile.Click
        '------------------------------------------------------------
        '-           Subprogram Name: mnuWindowTile_Click           -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is display child forms in -
        '- the MDI in a tiled format                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Displays a tiled format in the MDI layout
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        '------------------------------------------------------------
        '-           Subprogram Name: mnuWindowCascade_Click        -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is display child forms in -
        '- the MDI in a cascaded format                             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Displays a cascaded format in the MDI Layout
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        '------------------------------------------------------------
        '-           Subprogram Name: mnuFileExit_Click             -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: March 21, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to provoke closing the -
        '- application                                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Calls to close the application
        Me.Close()
    End Sub

End Class
