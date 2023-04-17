Imports Microsoft.Office.Interop

Module Main
    '------------------------------------------------------------
    '-              File Name : Main.vb                         -
    '-              Part of Project: Assignment9                -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: April 4, 2022                   -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the logic for creating an excel sheet -
    '- and populating it with student infromation. Also it adds -
    '- formulas for analyzing the student data                  -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to show statistics of     -
    '- students in an excel sheet using excel formulas          -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '-*myStudents - ArrayList containing students of clsStudent -
    '- type                                                     -
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

    Dim myStudents As New ArrayList


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Sub Main()
        '------------------------------------------------------------
        '-                Subprogram Name: Main                     -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is the main method that is run when the  -
        '- application is executed. It creates a new excel sheet and-
        '- populates it with student information and statistics     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*anExcelDoc - Excel Doc Application                       -
        '-*CheckExcel - Used to check if excel sheet already exists -
        '-*intLoop - Loop counter                                   -
        '------------------------------------------------------------

        Dim CheckExcel As Object
        Dim anExcelDoc As Excel.Application
        Dim intLoop As Integer = 2

        'Insert Student records into array
        InsertMyStudents()

        'Checks if excel object exists
        Try
            CheckExcel = GetObject(, "Excel.Application")
        Catch Ex As Exception
            'Excel was not running, so we got an error
        End Try

        'Create a new instance of excel
        If CheckExcel Is Nothing Then
            'Create a new instance of Excel
            anExcelDoc = New Excel.Application()
            anExcelDoc.Visible = True
        Else
            anExcelDoc = CheckExcel
            anExcelDoc.Visible = True
        End If

        'Add a new workbook and a new sheet
        anExcelDoc.Workbooks.Add()
        anExcelDoc.Sheets.Add()

        'Put student information into excel sheet
        PutStudentsIntoExcel(anExcelDoc, intLoop)

        'Put formulas into excel sheet
        Formula(anExcelDoc, "Aver:", "Average", intLoop, 0)
        Formula(anExcelDoc, "St Dev:", "STDEV", intLoop, 1)
        Formula(anExcelDoc, "Min:", "MIN", intLoop, 2)
        Formula(anExcelDoc, "Max:", "MAX", intLoop, 3)
    End Sub

    Private Sub PutStudentsIntoExcel(ByRef anExcelDoc, ByRef intLoop)
        '------------------------------------------------------------
        '-         Subprogram Name: PutStudentsIntoExcel            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is puts the data into Excel              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*anExcelDoc - reference to the excel document             -
        '-*intLoop - reference to a loop counter                    -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Excel file headers
        anExcelDoc.Cells(1, 1) = "Initials"
        anExcelDoc.Cells(1, 2) = "Name"
        anExcelDoc.Cells(1, 3) = "Grade 1"
        anExcelDoc.Cells(1, 4) = "Grade 2"
        anExcelDoc.Cells(1, 5) = "Grade 3"
        anExcelDoc.Cells(1, 6) = "Grade 4"
        anExcelDoc.Cells(1, 7) = "Grade Total"
        anExcelDoc.Cells(1, 8) = "Exam"
        anExcelDoc.Cells(1, 9) = "Final Grade"

        'Fill excel file with data
        For Each student As clsStudent In myStudents
            anExcelDoc.Cells(intLoop, 1) = student.GetInitials
            anExcelDoc.Cells(intLoop, 2) = student.GetLastName
            anExcelDoc.Cells(intLoop, 3) = student.GetArrAssignment(0)
            anExcelDoc.Cells(intLoop, 4) = student.GetArrAssignment(1)
            anExcelDoc.Cells(intLoop, 5) = student.GetArrAssignment(2)
            anExcelDoc.Cells(intLoop, 6) = student.GetArrAssignment(3)
            anExcelDoc.Cells(intLoop, 7) = "=SUM(C" & intLoop & ":F" & intLoop & ")"
            anExcelDoc.Cells(intLoop, 8) = student.GetIntExam
            anExcelDoc.Cells(intLoop, 9) = "=((G" & intLoop & " * .40) + (H" & intLoop & " * .60))"

            intLoop = intLoop + 1
        Next

    End Sub

    Private Sub Formula(ByRef anExcelDoc, ByVal strHeader, ByVal strformula, ByVal intEnd, ByVal intRow)
        '------------------------------------------------------------
        '-         Subprogram Name: PutStudentsIntoExcel            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is puts the data into Excel              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*anExcelDoc - reference to the excel document             -
        '-*strHeader - Truncated description of formula             -
        '-*strFormula - The excel formual                           -
        '-*intEnd - The last row of data                            -
        '-*intRow - How many rows after intEnd + 2 to put formulas  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Puts formulas into excel file
        anExcelDoc.Cells(intEnd + 2 + intRow, 2) = strHeader
        anExcelDoc.Cells(intEnd + 2 + intRow, 3) = "=" & strformula & "(C2:C" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 4) = "=" & strformula & "(D2:D" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 5) = "=" & strformula & "(E2:E" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 6) = "=" & strformula & "(F2:F" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 7) = "=" & strformula & "(G2:G" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 8) = "=" & strformula & "(H2:H" & intEnd & ")"
        anExcelDoc.Cells(intEnd + 2 + intRow, 9) = "=" & strformula & "(I2:I" & intEnd & ")"
    End Sub


    Private Sub InsertMyStudents()
        '------------------------------------------------------------
        '-             Subprogram Name: InsertMyStudents            -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: April 4, 2022                 -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is puts students into Student Array      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        myStudents.Add(New clsStudent("V.A.", "Borstellis", {25, 25, 25, 25}, 100.0))
        myStudents.Add(New clsStudent("A.S.", "Reid", {20, 21, 20, 18}, 75.0))
        myStudents.Add(New clsStudent("C.U.", "Tyler", {19, 20, 21, 24}, 75.5))
        myStudents.Add(New clsStudent("H.A.", "Renee", {20, 23, 23, 25}, 80.5))
        myStudents.Add(New clsStudent("I.A.", "Douglas", {24, 23, 25, 25}, 95.0))
        myStudents.Add(New clsStudent("M.A.", "Elenaips", {23, 24, 23, 21}, 94.5))
        myStudents.Add(New clsStudent("A.L.", "Emmet", {21, 19, 18, 15}, 73.0))
        myStudents.Add(New clsStudent("S.U.", "James", {21, 24, 23, 22}, 87.5))
        myStudents.Add(New clsStudent("S.H.", "Issacs", {23, 24, 21, 21}, 93.0))
        myStudents.Add(New clsStudent("B.I.", "Opus", {23, 24, 25, 23}, 97.5))
        myStudents.Add(New clsStudent("T.R.", "Alski", {24, 25, 25, 23}, 95.5))
        myStudents.Add(New clsStudent("H.E.", "Zeus", {23, 24, 23, 23}, 77.0))
        myStudents.Add(New clsStudent("S.C.", "Ustaf", {24, 23, 24, 25}, 91.0))
        myStudents.Add(New clsStudent("K.I.", "Chrint", {23, 23, 24, 21}, 89.0))
        myStudents.Add(New clsStudent("J.E.", "Yaz", {25, 24, 23, 24}, 92.5))
        myStudents.Add(New clsStudent("F.R.", "Franks", {23, 19, 18, 23}, 88.5))
        myStudents.Add(New clsStudent("W.I.", "Walton", {24, 23, 23, 19}, 90.0))
        myStudents.Add(New clsStudent("K.A.", "Gilch", {24, 23, 25, 24}, 92.0))
        myStudents.Add(New clsStudent("R.O.", "Little", {23, 24, 23, 24}, 94.0))
        myStudents.Add(New clsStudent("S.A.", "Xerxes", {24, 23, 25, 23}, 94.0))
        myStudents.Add(New clsStudent("W.I.", "Harris", {23, 24, 25, 23}, 92.0))
        myStudents.Add(New clsStudent("T.I.", "Vargo", {24, 23, 25, 25}, 99.0))
        myStudents.Add(New clsStudent("I.E.", "Interas", {24, 23, 25, 25}, 97.5))
        myStudents.Add(New clsStudent("T.O.", "Kiliens", {23, 19, 18, 18}, 73.0))
        myStudents.Add(New clsStudent("E.R.", "Manrose", {23, 24, 25, 23}, 84.0))
        myStudents.Add(New clsStudent("W.A.", "Nelson", {23, 24, 25, 23}, 87.0))
        myStudents.Add(New clsStudent("K.U.", "Quaras", {23, 24, 25, 23}, 96.5))
    End Sub
End Module
