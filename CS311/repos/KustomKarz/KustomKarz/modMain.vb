Module modMain
    '------------------------------------------------------------
    '-                 File Name : modMain.vb                   -
    '-              Part of Project: KustomKarz                 -
    '------------------------------------------------------------
    '               Written By: Nathan VanSnepson               -
    '               Written On: January 26, 2022                -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- The purpose of this file is to initialize the program    -
    '- by displaying the selection form.                        -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- frmKustomKarz - Instance of KustomKarz                   -
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
    Dim frmKustomKarz As KustomKarzForm



    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------



    Sub Main()
        '------------------------------------------------------------
        '-                  Subprogram Name: Main                   -
        '------------------------------------------------------------
        '-               Written By: Nathan VanSnepson              -
        '-               Written On: January 26, 2022               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '- The purpose of this subprogram is start the selection    -
        '- form.
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- frmKustomKarz - Reference to an instance of KustomKarz-  -
        '- Form.                                                    -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Creates a new instance of the KustomKarzForm 
        frmKustomKarz = New KustomKarzForm

        'Displays the KustomKarzForm
        frmKustomKarz.ShowDialog()

    End Sub

End Module
