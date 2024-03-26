'Alex Wheelock
'RCET 0265
'Spring 2024
'Math Contest
'https://github.com/AlexWheelock/MathContest.git

Option Explicit On
Option Strict On

'TODO
'[x] Create a sub to clear/set default settings
'[ ] Validate the student information (Age must be 7-11, and Grade 1-4)
'[ ] Generate pop-ups for invalid information
'[ ] Clear invalid fields and set focus to those fields
'[ ] Lock the student information in when validated
'[ ] Generate two random numbers for each math problem
'[ ] Create a way to handle the math problem type for the problems
'[ ] Get the correct answer for the math problem
'[ ] Check student answers, compare it to the correct answer
'[ ] Run through 5 problems and give the score to the student
Public Class MathContestForm

    'Clears everything and sets it back to default settings
    Sub SetDefaults()
        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        AddRadioButton.Checked = True
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
    End Sub

    'Validates the input student information when the submit button is pressed
    Function ValidateStudentInformation() As Boolean
        Dim validFields As Boolean = True
        Dim nameTest As Integer = 0
        Dim ageTest As Integer = 0
        Dim gradeTest As Integer = 0
        Dim gradeString As String = ""
        Dim errorMessage As String = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf)

        'Tests to see if the name can be converted to a number, if so it flags it as an error, and adds it to the errorMessage
        Try
            nameTest = CInt(NameTextBox.Text)
            errorMessage += "Name"
            NameTextBox.Focus()
            validFields = False
        Catch ex As Exception
        End Try

        'Validates the age, verifying that it is within 7-11 and a number
        Try
            'Checks to see that the entered age is a number
            ageTest = CInt(AgeTextBox.Text)

            'Checks to see that the entered age number is between 7 and 11
            'If not, it will flag the age as an error, and add it to the errorMessage
            If ageTest < 7 Then
                validFields = False
                If errorMessage <> ("The following fields are invalid:" & vbCrLf _
                & vbCrLf) Then
                    errorMessage += ", Age is too low"
                Else
                    errorMessage += "Age is too low"
                End If
            ElseIf ageTest > 11 Then
                validFields = False
                If errorMessage <> ("The following fields are invalid:" & vbCrLf _
                & vbCrLf) Then
                    errorMessage += ", Age is too high"
                Else
                    errorMessage += "Age is too high"
                End If
            Else
            End If

        Catch ex As Exception
            'If the entered age cannot be converted to an integer, then it will flag it as an error
            'Adds it to the errorMessage
            validFields = False
            If errorMessage <> ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                errorMessage += ", Age"
            Else
                errorMessage += "Age"
            End If
        End Try

        Return validFields

    End Function

    'Event handlers below this point


    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub StudentInformationGroupBox_Enter(sender As Object, e As EventArgs) Handles StudentInformationGroupBox.Enter

    End Sub

    Private Sub AgeLabel_Click(sender As Object, e As EventArgs) Handles AgeLabel.Click

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged

    End Sub

    Private Sub GradeLabel_Click(sender As Object, e As EventArgs) Handles GradeLabel.Click

    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged

    End Sub

    Private Sub CurrentMathProblemGroupBox_Enter(sender As Object, e As EventArgs) Handles CurrentMathProblemGroupBox.Enter

    End Sub

    Private Sub FirstNumberLabel_Click(sender As Object, e As EventArgs) Handles FirstNumberLabel.Click

    End Sub

    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged

    End Sub

    Private Sub SecondNumberLabel_Click(sender As Object, e As EventArgs) Handles SecondNumberLabel.Click

    End Sub

    Private Sub SecondNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTextBox.TextChanged

    End Sub

    Private Sub StudentAnswerLabel_Click(sender As Object, e As EventArgs) Handles StudentAnswerLabel.Click

    End Sub

    Private Sub StudentAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.TextChanged

    End Sub

    Private Sub MathProblemTypeGroupBox_Enter(sender As Object, e As EventArgs) Handles MathProblemTypeGroupBox.Enter

    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        AddRadioButton.Checked = True
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = True
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = True
        DivideRadioButton.Checked = False
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = True
    End Sub

    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Checks the student information and validates it
        'If valid then it will run through the rest of the subs, else it will do nothing
        If ValidateStudentInformation() Then

        Else
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

End Class
