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

    'Clears everything and sets it back to default settings when NameTextBox is enabled
    'which is when the contest is running
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

    'Validates the input student information when one of the student information text boxes are left
    'Invalid inputs will mark validFields false, not allowing it to run the contest
    Sub ValidateStudentInformation(newContest As Boolean)
        Dim validFields As Boolean = True
        Dim nameTest As Integer = 0
        Dim ageTest As Integer = 0
        Dim gradeTest As Integer = 0

        'Tests to see if the name can be converted to a number, if so it flags it as an error
        'Sets the focus to NameTextBox, and makes it light yellow to signal that it is invalid
        If newContest = False Then
            Try
                nameTest = CInt(NameTextBox.Text)
                NameTextBox.Text = ""
                NameTextBox.Focus()
                validFields = False
                NameTextBox.BackColor = Color.LightYellow
            Catch ex As Exception
                'Makes sure that something was put into NameTextBox
                'if not then validFields is marked false and NameTextBox is cleared and made light yellow
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
                'If not, it will make validFields false, change the focus
                'if NameTextBox is valid, make it yellow, and clear it
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
                'If validFields is already false, then it keeps the focus on the earlier invalid input
                'else it will clear, make light yellow, and set the focus to the AgeTextBox upon failure.
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
                'If not, it will make validFields false, then TextBox becomes yellow, and clears.
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

            'If all StudentInformation inputs are valid, then it will disable the information inputs,
            'enable the submit and summary buttons, enable the radio buttons, and give a new problem.
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

    'Runs the contest, when the submit button is pressed
    Sub RunContest()
        Dim answerTest As Integer
        Static problemNumber As Integer
        Static trackScore As Integer

        'Validates the student answer, if it is invalid then it will display a message to the contestant
        'If answer is valid then it will carry on with the contest
        Try
            answerTest = CInt(StudentAnswerTextBox.Text)
            StudentAnswerTextBox.BackColor = Color.White

            'checks answer, and if it returns true then add 1 to trackScore
            If CheckAnswer() Then
                trackScore += 1
            Else
            End If

            'Valid answer will add 1 to problemNumber
            problemNumber += 1

            'Then check the problemNumber to determine if 5 problems have occurred/been answered
            'If problemNumber = 5 then it will display the total score of the student,
            'reset trackScore and problemNumber, and SetDefaults()
            'Otherwise, it continues the contest, giving the student a new problem
            'and clearing StudentAnswerTextBox
            If problemNumber = 5 Then
                MsgBox($"{NameTextBox.Text} scored {trackScore} out of {problemNumber} problems.")
                problemNumber = 0
                trackScore = 0
                ValidateStudentInformation(True)
                NameTextBox.Enabled = True
                SetDefaults()
            Else
                StudentAnswerTextBox.Text = ""
                NewProblem()
            End If

            'Stores the problem number and trackScore into their own Functions, so that they
            'may be pulled when the SummaryButton is pressed.
            StoreRunningCorrect(trackScore)
            StoreRunningProblem(problemNumber)
        Catch ex As Exception
            'Invalid input will result in one of the two messages being displayed,
            'as well as the AnswerTextBox being cleared, and made light yellow
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

    'Calling this sub will generate a new math problem for the student,
    'changing the numbers in the first and second number text boxes
    Sub NewProblem()
        FirstNumberTextBox.Text = GenerateNumber()
        SecondNumberTextBox.Text = GenerateNumber()
    End Sub

    'Generates random integer between 0 and 100 for the math problem that is given to the student
    Function GenerateNumber() As String
        Dim number As Integer

        Randomize()
        number = CInt(Rnd() * 100)

        Return CStr(number)
    End Function

    'Compares the student answer to the correct answer, and returns a Boolean value
    'to determine whether or not it was correct.
    Function CheckAnswer() As Boolean
        Dim correctAnswer As Boolean
        Dim answer As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        'Determines what kind of problem it is, based on which radio button is checked.
        'Solves for the correct answer
        If AddRadioButton.Checked Then
            answer = (firstNumber + secondNumber)
        ElseIf SubtractRadioButton.Checked Then
            answer = (firstNumber - secondNumber)
        ElseIf MultiplyRadioButton.Checked Then
            answer = (firstNumber * secondNumber)
        ElseIf DivideRadioButton.Checked Then
            answer = (firstNumber \ secondNumber)
        End If

        'Compares the answer to the correct answer to determine whether or not they are the same.
        'If correct then it will make correctAnswer true and display a Msgbox saying the answer was correct.
        'If incorrect then it will make correctAnswer false and display a Msgbox saying that the answer was incorrect.
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

    'Calls the problem number and the number of problems correct from each of their own
    'subs, then displays a Msgbox to the user of their score out of the amount possible.
    Sub Summary()
        Dim currentCorrect As Integer
        Dim currentProblem As Integer

        currentCorrect = StoreRunningCorrect(99)
        currentProblem = StoreRunningProblem(99)

        MsgBox($"{NameTextBox.Text} has a current score of {currentCorrect} out of {currentProblem} possible.")
    End Sub

    'Stores the problem number of the contest
    'If problemNumber = 99 then that means Summary() is calling for the current values
    'If true then it will not overwrite the currentProblem number and return it instead.
    'Else, it makes currentProblem = problemNumber overwriting it.
    Function StoreRunningProblem(problemNumber As Integer) As Integer
        Static currentProblem As Integer

        If problemNumber = 99 Then
        Else
            currentProblem = problemNumber
        End If

        Return currentProblem
    End Function

    'Stores the running total of correct answers of the contest
    'If trackScore = 99 then that means Summary() is calling for the current values
    'If true then it will not overwrite the currentCorrect number and return it instead.
    'Else, it makes currentCorrect = trackScore overwriting it.
    Function StoreRunningCorrect(trackScore As Integer) As Integer
        Static currentCorrect As Integer

        If trackScore = 99 Then
        Else
            currentCorrect = trackScore
        End If

        Return currentCorrect
    End Function


    'Event handlers below this point

    'Calls the SetDefaults() sub, initializing the form to a default status
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    'Changing the chosen radio button generates a new problem for the contestant
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        NewProblem()
    End Sub

    'Changing the chosen radio button generates a new problem for the contestant
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        NewProblem()
    End Sub

    'Changing the chosen radio button generates a new problem for the contestant
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        NewProblem()
    End Sub
    'Changing the chosen radio button generates a new problem for the contestant

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        NewProblem()
    End Sub

    'Clicking SubmitButton runs the contest validation and answer checking from the RunContest() sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        RunContest()
    End Sub

    'Clicking the ClearButton will set the form and the items within it to default
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    'Clicking the SummaryButton will display a message box to the user of the current score, handled by the Summary() sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Summary()
    End Sub

    'Clicking the ExitButton will close the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'When a student information text box is left, it will try to validate the student information
    'False is given to the ValidateStudentInformation() sub, telling it that it is not starting a new contest
    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave, AgeTextBox.Leave, GradeTextBox.Leave
        ValidateStudentInformation(False)
    End Sub

    'Label for NameTextBox
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    'Text box that allows the contestant to input their name
    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    'Group box that houses the Name, Age, and Grade Text Boxes
    Private Sub StudentInformationGroupBox_Enter(sender As Object, e As EventArgs) Handles StudentInformationGroupBox.Enter

    End Sub

    'Label for AgeTextBox
    Private Sub AgeLabel_Click(sender As Object, e As EventArgs) Handles AgeLabel.Click

    End Sub

    'Text box for the contestant to input their age into
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged

    End Sub

    'Label for GradeTextBox
    Private Sub GradeLabel_Click(sender As Object, e As EventArgs) Handles GradeLabel.Click

    End Sub

    'Text box for the contestant to input their grade number
    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged

    End Sub

    'Group box that contains the first and second number text boxes, as well as the StudentAnswerTextBox
    Private Sub CurrentMathProblemGroupBox_Enter(sender As Object, e As EventArgs) Handles CurrentMathProblemGroupBox.Enter

    End Sub

    'Label for the FirstNumberTextBox
    Private Sub FirstNumberLabel_Click(sender As Object, e As EventArgs) Handles FirstNumberLabel.Click

    End Sub

    'TextBox that contains the first number for the math problem given to the contestant
    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged

    End Sub

    'Label for the SecondNumberTextBox
    Private Sub SecondNumberLabel_Click(sender As Object, e As EventArgs) Handles SecondNumberLabel.Click

    End Sub

    'Text box that contains the second number for the math problem given to the contestant
    Private Sub SecondNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTextBox.TextChanged

    End Sub

    'Label for the StudentAnswerTextBox
    Private Sub StudentAnswerLabel_Click(sender As Object, e As EventArgs) Handles StudentAnswerLabel.Click

    End Sub

    'Text box which the student puts their answers into
    Private Sub StudentAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.TextChanged

    End Sub

    'Contains the add, subtract, multiply, and divide radio boxes together
    Private Sub MathProblemTypeGroupBox_Enter(sender As Object, e As EventArgs) Handles MathProblemTypeGroupBox.Enter

    End Sub

    'Contains the exit, submit, clear, and summary buttons together
    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    'Handles the tool tips for each input and button for the form
    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub


End Class
