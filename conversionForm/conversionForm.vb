Option Strict On
Option Explicit On

'Program:       conversionForm
'               Exercise 4 - Feet To Meters
'               Exercise 5 - Hours To Minutes
'               Lab 1      - Weight On The Moon
'Programmer:    Ryan Isaacson / Munchinator6354
'Date           October 12, 2020
'Description    Program will convert meters to feet, feet to meters, hours to minutes, and minutes to hours with remainder.
'               This program is also able to convert a person's Earth Weight to their Moon Weight and the reverse.

Public Class frmConversionForm
    'Subroutine:    btnCalculate_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 12, 2020
    'Description    Performs calculation for final output based on the number that the user input  
    '               as well as the conversion form that they chose from the provided list.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Set up our variables and types here
        Dim decInput, decConversionRate, decUserWeight, decUserMass, decEarthGravAcceleration As Decimal
        Dim decMoonGravAcceleration, decEarthWeight, decMoonWeight As Decimal
        Dim intConversionRate As Integer
        Dim sngSolution As Single
        Dim strListBoxOption, strUnits, strAnswer, strFinalConversion, strRemainder As String
        Dim lngInput, lngConversionRate As Long
        Dim dblRemainder As Double

        'Perform a check to see if the input was a number
        If Not txtInput.Text.Contains("-") And IsNumeric(txtInput.Text) Then
            'Perform a check to see if a conversion option was selected. 
            'In a 0 index array list box, an index of -1 would mean nothing is selected.
            strListBoxOption = CStr(lstConversionOptions.SelectedIndex)
            'The following line of code was helpful to display to the debug window which conversion option Index# the user chose
            'System.Diagnostics.Debug.Write("User chose conversion index#" & lstConversionOptions.SelectedIndex & vbCrLf)

            'If the user chose no conversion option a message box displays "Please select a Conversion Option"
            If strListBoxOption = "-1" Then
                MsgBox("Please select a Conversion Option")

                'This checks which conversion option the user chose and takes the string value and sets it to variable strListBoxOption
            ElseIf CInt(strListBoxOption) >= -1 Then
                strListBoxOption = lstConversionOptions.SelectedItem.ToString()
                lblOutput2.Text = ""
                'The following line of code was helpful to display which conversion option string the user chose
                'System.Diagnostics.Debug.Write("User chose conversion string " & strListBoxOption & vbCrLf)

                'The following acts as a sort of router: depending on which conversion option the user chose, it sets the conversion rate

                'First the conversion from Feet To Meters
                If strListBoxOption = "Feet To Meters" Then
                    lblInputUnits.Text = "Feet"
                    decConversionRate = CDec(0.3048)
                    decInput = CDec(txtInput.Text)
                    sngSolution = (decConversionRate * decInput)
                    sngSolution = CSng(Math.Round(sngSolution, 2, MidpointRounding.AwayFromZero))
                    strUnits = " Meters"
                    strAnswer = CStr(sngSolution)
                    strFinalConversion = strAnswer & strUnits
                    '----------------------------------------------------------------------------------------

                    'Next the conversion from Meters To Feet
                ElseIf strListBoxOption = "Meters To Feet" Then
                    lblInputUnits.Text = "Meters"
                    decConversionRate = CDec(3.28084)
                    decInput = CDec(txtInput.Text)
                    sngSolution = (decConversionRate * decInput)
                    sngSolution = CSng(Math.Round(sngSolution, 2, MidpointRounding.AwayFromZero))
                    strUnits = " Feet"
                    strAnswer = CStr(sngSolution)
                    strFinalConversion = strAnswer & strUnits
                    '----------------------------------------------------------------------------------------

                    'Next the conversion from Hours To Minutes
                ElseIf strListBoxOption = "Hours To Minutes" Then
                    lblInputUnits.Text = "Hours"
                    intConversionRate = 60
                    decInput = CDec(txtInput.Text)
                    sngSolution = intConversionRate * decInput
                    strUnits = " Minutes"
                    strAnswer = CStr(sngSolution)
                    strFinalConversion = strAnswer & strUnits
                    '----------------------------------------------------------------------------------------

                    'Next the conversion from Minutes To Hours
                ElseIf strListBoxOption = "Minutes To Hours" Then
                    lblInputUnits.Text = "Minutes"
                    lngConversionRate = 60
                    lngInput = CLng(txtInput.Text)
                    sngSolution = lngInput \ lngConversionRate
                    dblRemainder = lngInput Mod lngConversionRate
                    'These were helpful troubleshooting methods to determine what I was getting for sngSolution and dblRemainder
                    'System.Diagnostics.Debug.Write("sngSolution " & sngSolution & vbCrLf)
                    'System.Diagnostics.Debug.Write("dblRemainder " & dblRemainder & vbCrLf)
                    strUnits = " Hours"
                    strAnswer = CStr(sngSolution)
                    strRemainder = CStr(dblRemainder)
                    strFinalConversion = strAnswer & strUnits & " and " & strRemainder & " Minutes"
                    '----------------------------------------------------------------------------------------

                    'Next the conversion from Earth Weight To Moon Weight
                ElseIf strListBoxOption = "Earth Weight To Moon Weight" Then
                    lblInputUnits.Text = "Earth Pounds"
                    decUserWeight = CDec(txtInput.Text)
                    decEarthGravAcceleration = CDec(32.2)
                    decUserMass = decUserWeight / decEarthGravAcceleration
                    decUserMass = Math.Round(decUserMass, 2, MidpointRounding.AwayFromZero)
                    lblOutput2.Text = "(" & decUserMass & " slugs (Mass))"
                    lblOutput2.Show()
                    'This was helpful code to determine the user's mass before it was printed
                    'System.Diagnostics.Debug.Write("decUserMass " & decUserMass & vbCrLf)
                    decMoonGravAcceleration = CDec(5.3)
                    decMoonWeight = decUserMass * decMoonGravAcceleration
                    decMoonWeight = Math.Round(decMoonWeight, 2, MidpointRounding.AwayFromZero)
                    strFinalConversion = CStr(decMoonWeight) & " Pounds on the Moon "
                    '----------------------------------------------------------------------------------------

                    'Next the conversion from Moon Weight To Earth Weight
                ElseIf strListBoxOption = "Moon Weight To Earth Weight" Then
                    lblInputUnits.Text = "Moon Pounds"
                    decUserWeight = CDec(txtInput.Text)
                    decMoonGravAcceleration = CDec(5.3)
                    decUserMass = decUserWeight / decMoonGravAcceleration
                    decUserMass = Math.Round(decUserMass, 2, MidpointRounding.AwayFromZero)
                    'This code was helpful to determine user's mass before it was printed
                    'System.Diagnostics.Debug.Write("decUserMass " & decUserMass & vbCrLf)
                    lblOutput2.Text = "(" & decUserMass & " slugs (Mass))"
                    lblOutput2.Show()
                    decEarthGravAcceleration = CDec(32.2)
                    decEarthWeight = decUserMass * decEarthGravAcceleration
                    decEarthWeight = Math.Round(decEarthWeight, 2, MidpointRounding.AwayFromZero)
                    strFinalConversion = CStr(decEarthWeight) & " Pounds on the Earth"

                    '----------------------------------------------------------------------------------------
                End If
            End If
            'Display whichever final conversion came out of the router to the user
            lblOutput.Text = strFinalConversion

        Else
            'Asks user to not input negative numbers (implied by "-" usage)
            If txtInput.Text.Contains("-") Then
                MsgBox("No negative numbers buddy...")
            Else
                'Display's message prompting user to input a number value
                MsgBox("Looks like you didn't put in a number buddy...")

            End If

        End If
    End Sub

    'Subroutine:    btnClear_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 12, 2020
    'Description    Clears user inputs as well as any previous outputs and reset app to the initialized state.
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear button resets all user inputs back to starting values
        txtInput.Text = ""
        lblInputUnits.Text = ""
        lblOutput.Text = "Output Will Appear Here"
        lblOutput2.Text = ""
        lstConversionOptions.SelectedIndex = -1
        txtInput.Focus()
    End Sub

    'Subroutine:    btnExitProgram_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          October 12, 2020
    'Description    Exits the Program.
    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click
        Me.Close()
    End Sub
End Class
