
Public Class Form1

    Private Sub btnParseName_Click(sender As Object, e As EventArgs) Handles btnParseName.Click

        Dim fullName As String = txtName.Text

        ' Splits the name every time there is a space
        Dim names() As String = fullName.Split(CChar(" "))

        Dim firstName As String = names(0)
        Dim middleName As String = ""
        Dim lastName As String = ""

        ' If there is only 1 name then it will only display <first name>
        ' if there is only 2 name then it will display second name as <last name> with empty <middle name>
        ' if there is 3 name then it will display second name as <middle name> and third name as <last name>

        firstName = CapitalizeFirstLetter(firstName)

        If names.Length = 1 Then

        ElseIf names.Length = 2 Then
            lastName = names(1)
            lastName = CapitalizeFirstLetter(lastName)

        ElseIf names.Length = 3 Then
            middleName = names(1)
            middleName = CapitalizeFirstLetter(middleName)
            lastName = names(2)
            lastName = CapitalizeFirstLetter(lastName)

        End If

        Dim nameString As String = ""

        nameString &= "First name: " & firstName & vbNewLine & "Middle name: " & middleName &
                      vbNewLine & "Last name: " & lastName

        MessageBox.Show(nameString, "String Handling")

    End Sub

    ' Function to capitalize first letter of name and other letters as lower case
    Public Function CapitalizeFirstLetter(name As String) As String

        Dim firstLetter As String = name.Substring(0, 1).ToUpper
        Dim otherLetters As String = name.Substring(1).ToLower
        name = firstLetter & otherLetters

        Return name
    End Function
    Private Sub btnEditPhoneNumber_Click(sender As Object, e As EventArgs) Handles btnEditPhoneNumber.Click

        Dim phoneNumberSB As New StringBuilder(10)

        'Dim phoneNumber As String = txtPhoneNumber.Text

        '' Checks if the character in txtPhoneNumber.Text is numeric, if not, replaces it with empty string
        '' Then replaces any spaces with empty string
        '' Stores phone number into digitsOnly format variable

        'For i As Integer = 0 To phoneNumber.Length - 1
        '    If i > phoneNumber.Length - 1 Then
        '        Exit For
        '    End If
        '    If Not IsNumeric(phoneNumber.Chars(i)) Then
        '        Dim ch As Char = phoneNumber.Chars(i)
        '        phoneNumber = phoneNumber.Replace(ch, "")
        '    End If
        '    phoneNumber = phoneNumber.Replace(" ", "")
        'Next

        'Dim digitsOnly As String = phoneNumber.ToString()

        '' Formatting phone number to Standard Format

        'phoneNumber.Insert(3, "-")
        'phoneNumber.Insert(7, "-")
        'Dim standardFormat As String = phoneNumber.ToString()

        ' Formatting phone number using methods of StringBuilder class 

        phoneNumberSB.Append(txtPhoneNumber.Text)
        phoneNumberSB.Replace(" ", "")
        phoneNumberSB.Remove(0, 1)
        phoneNumberSB.Remove(3, 1)
        phoneNumberSB.Remove(6, 1)
        Dim digitsOnly As String = phoneNumberSB.ToString

        phoneNumberSB.Insert(3, "-")
        phoneNumberSB.Insert(7, "-")
        Dim standardFormat As String = phoneNumberSB.ToString

        ' Displaying message box with formatted phone number

        Dim phoneNumberString As String = ""

        phoneNumberString &= "Entered: " & vbTab & vbTab & txtPhoneNumber.Text & vbNewLine &
                             "Digits Only:  " & vbTab & digitsOnly & vbNewLine &
                             "Standard Format:  " & standardFormat

        MessageBox.Show(phoneNumberString, "Edit Phone Number")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
