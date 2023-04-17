'------------------------------------------------------------
'-              File Name : Book.vb                         -
'-              Part of Project: PayrollSystem              -
'------------------------------------------------------------
'               Written By: Nathan VanSnepson               -
'               Written On: February 28, 2022               -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains information that represents a book    -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'-*intQuantity - The number of books available              -
'-*sngInventoryTotal - The total cost of all the books in   -
'- the inventory.                                           -
'-*sngPrice - The price for a single book                   -
'-*strCaregory - The genre of the book.                     -
'-*strTitle - The title of the book
'------------------------------------------------------------


Public Class Book
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

    Public intQuantity As Integer
    Public sngInventoryTotal As Single
    Public sngPrice As Single
    Public strCategory As String
    Public strTitle As String

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------
    Public Sub New(intQuantity As Integer, sngInventoryTotal As Single, sngPrice As Single, strCategory As String, strTitle As String)
        '------------------------------------------------------------
        '-               Subprogram Name: new                       -
        '------------------------------------------------------------
        '-                Written By: Nathan VanSnepson             -
        '-                Written On: February 28, 2022             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- This subprogram is a constructor for the book class      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '-*intQuantity - the number of the book available           -
        '-*sngInventoryTotal - the total cost quantity of book      -
        '- available                                                -
        '-*sngPrice - The price per single book                     -
        '-*strCategory - The genre of the book                      -
        '-strTitle - Title of the book                              -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '-*bookTemp - an instance of the book class that gets       -
        '- reused to add new books to the book list                 -
        '-*sbBookName - A StringBuilder to add the book title       -
        '-*srReadInputFile - StreamReader to read in from a file    -
        '-*strInputStream - String array that holds the value of a  -
        '- line from the file                                       -
        '------------------------------------------------------------
        Me.intQuantity = intQuantity
        Me.sngInventoryTotal = sngInventoryTotal
        Me.sngPrice = sngPrice
        Me.strCategory = strCategory
        Me.strTitle = strTitle
    End Sub

End Class
