Public Class myClock
    '------------------------------------------------------------
    '-              File Name : myClock.vb                      -
    '-              Part of Project: Assignment10               -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: April 17, 2022                  -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the code for the myClock control      -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to make a custom time     -
    '- control.                                                 -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- ArialFont - Font that the clock displays                 -
    '- myBrush - Color of the time                              -
    '- CurrentForeColor - Used to get the current foreground    -
    '- color.                                                   -
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

    'Create the Font and Brush that we will use to print the time 
    'and also set the default Foreground color to Black
    Dim ArialFont As New Font("Arial", 12, FontStyle.Regular)
    Dim myBrush As New SolidBrush(Color.Black)
    Dim CurrentForeColor As Color = Color.Black


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Overrides Property ForeColor() As Color
        '------------------------------------------------------------
        '-            Subprogram Name: ForeColor                    -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 17, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to override the getter -
        '- and setter for the ForColor                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Get
            Return (CurrentForeColor)
        End Get
        Set(ByVal Value As Color)
            CurrentForeColor = Value
            Me.Invalidate()
        End Set
    End Property

    Private Sub timerMyClock_Tick(sender As Object, e As EventArgs) Handles timerMyClock.Tick
        '------------------------------------------------------------
        '-            Subprogram Name: timerMyClock_Tick            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 17, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to refresh the controls-
        '- conteext every time the clock ticks, this invokes onPaint-
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - reference to the object that raised the event   -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.Refresh()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        '------------------------------------------------------------
        '-            Subprogram Name: OnPaint                      -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 17, 2022                -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is to display the time    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- e - reference to EventArgs class that contains any addi- -
        '- tional information about the event.                      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- myGFx - the graphics context for the control             -
        '------------------------------------------------------------

        'e.Graphics is the graphics context for the control
        Dim myGfx As Graphics = e.Graphics

        'Set the brush to whatever the current foreground color is
        myBrush.Color = CurrentForeColor

        'Print the time out
        myGfx.DrawString(DateTime.Now.ToLongTimeString, ArialFont, myBrush, 10, 10)
    End Sub
End Class

