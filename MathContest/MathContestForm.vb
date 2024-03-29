'Alex Wheelock
'RCET 0265
'Spring 2024
'Math Contest
'https://github.com/AlexWheelock/MathContest.git

Option Explicit On
Option Strict On

Imports System.CodeDom.Compiler
Imports System.Security.Cryptography.X509Certificates

'TODO
'[x] Create a sub to clear/set default settings
'[x] Validate the student information (Age must be 7-11, and Grade 1-4)
'[x] Generate pop-ups for invalid information
'[x] Clear invalid fields and set focus to those fields
'[x] Lock the student information in when validated
'[x] Generate two random numbers for each math problem
'[x] Create a way to handle the math problem type for the problems
'[x] Get the correct answer for the math problem
'[x] Check student answers, compare it to the correct answer
'[x] Run through 5 problems and give the score to the student
'[x] Allow the student to check the amount of problems they have gotten right during the contest
Public Class MathContestForm

    'Clears everything and sets it back to default settings
    Sub SetDefaults()
        If NameTextBox.Enabled = True Then
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
            SubmitButton.Enabled = False
            SummaryButton.Enabled = False
            AddRadioButton.Enabled = False
            SubtractRadioButton.Enabled = False
            MultiplyRadioButton.Enabled = False
            DivideRadioButton.Enabled = False
        Else
            StudentAnswerTextBox.Text = ""
        End If

    End Sub

    'Validates the input student information when the submit button is pressed
    Sub ValidateStudentInformation(newContest As Boolean)
        Dim validFields As Boolean = True
        Dim nameTest As Integer = 0
        Dim ageTest As Integer = 0
        Dim gradeTest As Integer = 0

        'Tests to see if the name can be converted to a number, if so it flags it as an error
        'and adds it to the errorMessage
        If newContest = False Then

            Try
                nameTest = CInt(NameTextBox.Text)
                NameTextBox.Text = ""
                NameTextBox.Focus()
                validFields = False
                NameTextBox.BackColor = Color.LightYellow
            Catch ex As Exception
                'Makes sure that something was put into NameTextBox, if not then it will flag it as an error
                'and add it to the errorMessage
                If NameTextBox.Text = "" Then
                    NameTextBox.Text = ""
                    NameTextBox.Focus()
                    validFields = False
                    NameTextBox.BackColor = Color.LightYellow
                Else
                    NameTextBox.BackColor = Color.White
                End If
            End Try

            'Validates the age, verifying that it is within 7-11 and a number
            Try
                'Checks to see that the entered age is a number
                ageTest = CInt(AgeTextBox.Text)

                'Checks to see that the entered age number is between 7 and 11
                'If not, it will flag the age as an error, and add it to the errorMessage
                If ageTest < 7 Then
                    If validFields Then
                        AgeTextBox.Focus()
                    Else
                    End If
                    AgeTextBox.Text = ""
                    validFields = False
                    AgeTextBox.BackColor = Color.LightYellow
                ElseIf ageTest > 11 Then
                    If validFields Then
                        AgeTextBox.Focus()
                    Else
                    End If
                    AgeTextBox.Text = ""
                    validFields = False
                    AgeTextBox.BackColor = Color.LightYellow
                Else
                    AgeTextBox.BackColor = Color.White
                End If
            Catch ex As Exception
                'If the entered age cannot be converted to an integer, then it will flag it as an error
                'Adds it to the errorMessage
                'If validFields is already false, then it keeps the focus on the earlier invalid input
                'else it will set the focus to the AgeTextBox upon failure.
                If validFields Then
                    AgeTextBox.Focus()
                Else
                End If
                AgeTextBox.Text = ""
                validFields = False
                AgeTextBox.BackColor = Color.LightYellow
            End Try

            Try
                'Checks to see that the entered grade is a number
                gradeTest = CInt(GradeTextBox.Text)

                'Checks to see that the entered grade number is between 1 and 4
                'If not, it will flag the grade as an error, and add it to the errorMessage
                'If validFields is already false then it will keep the focus on the first earlier failed
                'input, else it will set the focus to GradeTextBox upon failure.
                If gradeTest < 1 Then
                    If validFields Then
                        GradeTextBox.Focus()
                    Else
                    End If
                    GradeTextBox.Text = ""
                    validFields = False
                    GradeTextBox.BackColor = Color.LightYellow
                ElseIf gradeTest > 4 Then
                    If validFields Then
                        GradeTextBox.Focus()
                    Else
                    End If
                    GradeTextBox.Text = ""
                    validFields = False
                    GradeTextBox.BackColor = Color.LightYellow
                Else
                    GradeTextBox.BackColor = Color.White
                End If

            Catch ex As Exception
                'If the entered grade cannot be converted to an integer, then it will flag it as an error
                'Adds it to the errorMessage
                If validFields Then
                    GradeTextBox.Focus()
                Else
                End If
                GradeTextBox.Text = ""
                validFields = False
                GradeTextBox.BackColor = Color.LightYellow
            End Try

            If validFields = True Then
                NameTextBox.Enabled = False
                AgeTextBox.Enabled = False
                GradeTextBox.Enabled = False
                AddRadioButton.Enabled = False
                SubtractRadioButton.Enabled = False
                MultiplyRadioButton.Enabled = False
                DivideRadioButton.Enabled = False
                SubmitButton.Enabled = True
                SummaryButton.Enabled = True
                AddRadioButton.Enabled = True
                SubtractRadioButton.Enabled = True
                MultiplyRadioButton.Enabled = True
                DivideRadioButton.Enabled = True
                NewProblem()
            Else
            End If
        Else
        End If
    End Sub

    Sub RunContest()
        Dim answerTest As Integer
        Static problemNumber As Integer
        Static trackScore As Integer

        Try
            answerTest = CInt(StudentAnswerTextBox.Text)
            StudentAnswerTextBox.BackColor = Color.White
            If CheckAnswer() Then
                trackScore += 1
            Else
            End If
            problemNumber += 1
            If problemNumber = 5 Then
                MsgBox($"{NameTextBox.Text} scored {trackScore} out of {problemNumber} problems.")
                problemNumber = 0
                trackScore = 0
                ValidateStudentInformation(True)
                NameTextBox.Enabled = True
                AgeTextBox.Enabled = True
                GradeTextBox.Enabled = True
                SubmitButton.Enabled = False
                SummaryButton.Enabled = False
                StudentAnswerTextBox.Text = ""
                FirstNumberTextBox.Text = ""
                SecondNumberTextBox.Text = ""
                AddRadioButton.Enabled = False
                SubtractRadioButton.Enabled = False
                MultiplyRadioButton.Enabled = False
                DivideRadioButton.Enabled = False
            Else
                StudentAnswerTextBox.Text = ""
                NewProblem()
            End If
            StoreRunningCorrect(trackScore)
            StoreRunningProblem(problemNumber)
        Catch ex As Exception
            If StudentAnswerTextBox.Text = "" Then
                StudentAnswerTextBox.Text = ""
                StudentAnswerTextBox.BackColor = Color.LightYellow
                MsgBox("Please enter an answer.")
            Else
                StudentAnswerTextBox.Text = ""
                StudentAnswerTextBox.BackColor = Color.LightYellow
                MsgBox("Please enter a whole number.")
            End If

        End Try
    End Sub

    Sub NewProblem()
        FirstNumberTextBox.Text = GenerateNumber()
        SecondNumberTextBox.Text = GenerateNumber()
    End Sub

    Function GenerateNumber() As String
        Dim number As Integer

        Randomize()
        number = CInt(Rnd() * 100)

        Return CStr(number)
    End Function


    Function CheckAnswer() As Boolean
        Dim correctAnswer As Boolean
        Dim answer As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        If AddRadioButton.Checked Then
            answer = (firstNumber + secondNumber)
        ElseIf SubtractRadioButton.Checked Then
            answer = (firstNumber - secondNumber)
        ElseIf MultiplyRadioButton.Checked Then
            answer = (firstNumber * secondNumber)
        ElseIf DivideRadioButton.Checked Then
            answer = (firstNumber \ secondNumber)
        End If

        If answer = CInt(StudentAnswerTextBox.Text) Then
            correctAnswer = True
            MsgBox("Your answer was correct!" & vbCrLf _
                   & vbCrLf _
                   & $"The correct answer was {answer}.")
        Else
            correctAnswer = False
            MsgBox("Your answer was incorrect." & vbCrLf _
                   & vbCrLf _
                   & $"The correct answer was {answer}.")
        End If

        Return correctAnswer
    End Function


    Sub Summary()
        Dim currentCorrect As Integer
        Dim currentProblem As Integer

        currentCorrect = StoreRunningCorrect(99)
        currentProblem = StoreRunningProblem(99)

        MsgBox($"{NameTextBox.Text} has a current score of {currentCorrect} out of {currentProblem} possible.")
    End Sub


    Function StoreRunningProblem(problemNumber As Integer) As Integer
        Static currentProblem As Integer

        If problemNumber = 99 Then
        Else
            currentProblem = problemNumber
        End If

        Return currentProblem
    End Function

    Function StoreRunningCorrect(trackScore As Integer) As Integer
        Static currentCorrect As Integer

        If trackScore = 99 Then
        Else
            currentCorrect = trackScore
        End If

        Return currentCorrect
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
        NewProblem()
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        NewProblem()
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        NewProblem()
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        NewProblem()
    End Sub

    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        RunContest()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Summary()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave, AgeTextBox.Leave, GradeTextBox.Leave
        ValidateStudentInformation(False)
    End Sub
End Class
