Public Class clsStudent
    '------------------------------------------------------------
    '-              File Name : clsStudent.vb                   -
    '-              Part of Project: Assignment9                -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: April 4, 2022                   -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the logic for a Student Object        -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '-*arrAssignment - Array of assignment grades               -
    '-*dblExam - Exam score                                     -
    '-*strInitials - Students first and middle initials         -
    '-*strLastName - Students last name                         -
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

    Private strInitials As String
    Private strLastName As String
    Private arrAssignment(4) As Integer
    Private dblExam As Double


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

#Region "Constructors"
    Public Sub New(strInitials As String, strLastName As String, arrAssignment() As Integer, dblExam As Double)
        '------------------------------------------------------------
        '-                Subprogram Name: New                      -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the constuctor for the Student Object -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*strInitials - first and middle initials of student       -
        '-*strLastName - Last name of student                       -
        '-*arrAssignment - Array of assignment grades               -
        '-*dblExam - Exam grade                                     -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.strInitials = strInitials
        Me.strLastName = strLastName
        Me.arrAssignment = arrAssignment
        Me.dblExam = dblExam
    End Sub

#End Region

#Region "Getters/Setters"

    Public Sub SetInitials(ByVal strInitials)
        '------------------------------------------------------------
        '-                Subprogram Name: SetInitials              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the setter for strInitials            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*strInitials - Students first and middle initial          -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.strInitials = strInitials
    End Sub

    Public Function GetInitials() As String
        '------------------------------------------------------------
        '-                Subprogram Name: GetInitials              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the getter for strInitials            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return strInitials
    End Function

    Public Sub SetLastName(ByVal strLastName)
        '------------------------------------------------------------
        '-                Subprogram Name: SetLastName              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the setter for strLastName            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*strLastName - Students Last Name                         -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.strLastName = strLastName
    End Sub

    Public Function GetLastName() As String
        '------------------------------------------------------------
        '-                Subprogram Name: GetLastName              -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the getter for strLastName            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return strLastName
    End Function

    Public Sub SetArrAssignment(ByVal arrAssignment)
        '------------------------------------------------------------
        '-                Subprogram Name: SetArrAssignment         -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the setter for arrAssignment          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*arrAssignment - array of assignment grades               -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.arrAssignment = arrAssignment
    End Sub

    Public Function GetArrAssignment() As Integer()
        '------------------------------------------------------------
        '-                Subprogram Name: GetArrAssignment         -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the getter for arrAssignment          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return arrAssignment
    End Function

    Public Sub SetIntExam(ByVal intExam)
        '------------------------------------------------------------
        '-                Subprogram Name: SetIntExam               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the setter for SetIntExam             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*SetIntExam - Exam grade                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.dblExam = intExam
    End Sub

    Public Function GetIntExam() As Double
        '------------------------------------------------------------
        '-                Subprogram Name: GetIntExam               -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the getter for dblExam                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Return dblExam
    End Function


#End Region
End Class
