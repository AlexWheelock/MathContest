<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        NameTextBox = New TextBox()
        FirstNumberTextBox = New TextBox()
        SecondNumberTextBox = New TextBox()
        StudentAnswerTextBox = New TextBox()
        AgeTextBox = New TextBox()
        AddRadioButton = New RadioButton()
        SubtractRadioButton = New RadioButton()
        MultiplyRadioButton = New RadioButton()
        DivideRadioButton = New RadioButton()
        SubmitButton = New Button()
        ClearButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        StudentInformationGroupBox = New GroupBox()
        GradeLabel = New Label()
        AgeLabel = New Label()
        NameLabel = New Label()
        GradeTextBox = New TextBox()
        CurrentMathProblemGroupBox = New GroupBox()
        StudentAnswerLabel = New Label()
        SecondNumberLabel = New Label()
        FirstNumberLabel = New Label()
        MathProblemTypeGroupBox = New GroupBox()
        ButtonGroupBox = New GroupBox()
        StudentInformationGroupBox.SuspendLayout()
        CurrentMathProblemGroupBox.SuspendLayout()
        MathProblemTypeGroupBox.SuspendLayout()
        ButtonGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(6, 57)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(209, 27)
        NameTextBox.TabIndex = 0
        ' 
        ' FirstNumberTextBox
        ' 
        FirstNumberTextBox.Location = New Point(6, 57)
        FirstNumberTextBox.Name = "FirstNumberTextBox"
        FirstNumberTextBox.ReadOnly = True
        FirstNumberTextBox.Size = New Size(209, 27)
        FirstNumberTextBox.TabIndex = 3
        ' 
        ' SecondNumberTextBox
        ' 
        SecondNumberTextBox.Location = New Point(6, 115)
        SecondNumberTextBox.Name = "SecondNumberTextBox"
        SecondNumberTextBox.ReadOnly = True
        SecondNumberTextBox.Size = New Size(209, 27)
        SecondNumberTextBox.TabIndex = 4
        ' 
        ' StudentAnswerTextBox
        ' 
        StudentAnswerTextBox.Location = New Point(6, 175)
        StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        StudentAnswerTextBox.Size = New Size(209, 27)
        StudentAnswerTextBox.TabIndex = 5
        ' 
        ' AgeTextBox
        ' 
        AgeTextBox.Location = New Point(241, 57)
        AgeTextBox.Name = "AgeTextBox"
        AgeTextBox.Size = New Size(42, 27)
        AgeTextBox.TabIndex = 1
        ' 
        ' AddRadioButton
        ' 
        AddRadioButton.AutoSize = True
        AddRadioButton.Location = New Point(13, 34)
        AddRadioButton.Name = "AddRadioButton"
        AddRadioButton.Size = New Size(58, 24)
        AddRadioButton.TabIndex = 6
        AddRadioButton.TabStop = True
        AddRadioButton.Text = "Add"
        AddRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractRadioButton
        ' 
        SubtractRadioButton.AutoSize = True
        SubtractRadioButton.Location = New Point(13, 64)
        SubtractRadioButton.Name = "SubtractRadioButton"
        SubtractRadioButton.Size = New Size(85, 24)
        SubtractRadioButton.TabIndex = 7
        SubtractRadioButton.TabStop = True
        SubtractRadioButton.Text = "Subtract"
        SubtractRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MultiplyRadioButton
        ' 
        MultiplyRadioButton.AutoSize = True
        MultiplyRadioButton.Location = New Point(13, 94)
        MultiplyRadioButton.Name = "MultiplyRadioButton"
        MultiplyRadioButton.Size = New Size(84, 24)
        MultiplyRadioButton.TabIndex = 8
        MultiplyRadioButton.TabStop = True
        MultiplyRadioButton.Text = "Multiply"
        MultiplyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DivideRadioButton
        ' 
        DivideRadioButton.AutoSize = True
        DivideRadioButton.Location = New Point(13, 124)
        DivideRadioButton.Name = "DivideRadioButton"
        DivideRadioButton.Size = New Size(73, 24)
        DivideRadioButton.TabIndex = 9
        DivideRadioButton.TabStop = True
        DivideRadioButton.Text = "Divide"
        DivideRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(6, 26)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(142, 58)
        SubmitButton.TabIndex = 10
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(6, 90)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(142, 58)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(6, 154)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(142, 58)
        SummaryButton.TabIndex = 12
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(6, 218)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(142, 58)
        ExitButton.TabIndex = 13
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' StudentInformationGroupBox
        ' 
        StudentInformationGroupBox.Controls.Add(GradeLabel)
        StudentInformationGroupBox.Controls.Add(AgeLabel)
        StudentInformationGroupBox.Controls.Add(NameLabel)
        StudentInformationGroupBox.Controls.Add(GradeTextBox)
        StudentInformationGroupBox.Controls.Add(NameTextBox)
        StudentInformationGroupBox.Controls.Add(AgeTextBox)
        StudentInformationGroupBox.Location = New Point(12, 12)
        StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        StudentInformationGroupBox.Size = New Size(380, 91)
        StudentInformationGroupBox.TabIndex = 14
        StudentInformationGroupBox.TabStop = False
        StudentInformationGroupBox.Text = "Student Information"
        ' 
        ' GradeLabel
        ' 
        GradeLabel.AutoSize = True
        GradeLabel.Location = New Point(309, 34)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New Size(49, 20)
        GradeLabel.TabIndex = 18
        GradeLabel.Text = "Grade"
        ' 
        ' AgeLabel
        ' 
        AgeLabel.AutoSize = True
        AgeLabel.Location = New Point(241, 34)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New Size(36, 20)
        AgeLabel.TabIndex = 17
        AgeLabel.Text = "Age"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(6, 34)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(49, 20)
        NameLabel.TabIndex = 16
        NameLabel.Text = "Name"
        ' 
        ' GradeTextBox
        ' 
        GradeTextBox.Location = New Point(310, 57)
        GradeTextBox.Name = "GradeTextBox"
        GradeTextBox.Size = New Size(42, 27)
        GradeTextBox.TabIndex = 2
        ' 
        ' CurrentMathProblemGroupBox
        ' 
        CurrentMathProblemGroupBox.Controls.Add(StudentAnswerLabel)
        CurrentMathProblemGroupBox.Controls.Add(SecondNumberLabel)
        CurrentMathProblemGroupBox.Controls.Add(FirstNumberLabel)
        CurrentMathProblemGroupBox.Controls.Add(FirstNumberTextBox)
        CurrentMathProblemGroupBox.Controls.Add(SecondNumberTextBox)
        CurrentMathProblemGroupBox.Controls.Add(StudentAnswerTextBox)
        CurrentMathProblemGroupBox.Location = New Point(12, 109)
        CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        CurrentMathProblemGroupBox.Size = New Size(222, 209)
        CurrentMathProblemGroupBox.TabIndex = 15
        CurrentMathProblemGroupBox.TabStop = False
        CurrentMathProblemGroupBox.Text = "Current Math Problem"
        ' 
        ' StudentAnswerLabel
        ' 
        StudentAnswerLabel.AutoSize = True
        StudentAnswerLabel.Location = New Point(6, 152)
        StudentAnswerLabel.Name = "StudentAnswerLabel"
        StudentAnswerLabel.Size = New Size(112, 20)
        StudentAnswerLabel.TabIndex = 21
        StudentAnswerLabel.Text = "Student Answer"
        ' 
        ' SecondNumberLabel
        ' 
        SecondNumberLabel.AutoSize = True
        SecondNumberLabel.Location = New Point(6, 92)
        SecondNumberLabel.Name = "SecondNumberLabel"
        SecondNumberLabel.Size = New Size(92, 20)
        SecondNumberLabel.TabIndex = 20
        SecondNumberLabel.Text = "2nd Number"
        ' 
        ' FirstNumberLabel
        ' 
        FirstNumberLabel.AutoSize = True
        FirstNumberLabel.Location = New Point(6, 34)
        FirstNumberLabel.Name = "FirstNumberLabel"
        FirstNumberLabel.Size = New Size(86, 20)
        FirstNumberLabel.TabIndex = 19
        FirstNumberLabel.Text = "1st Number"
        ' 
        ' MathProblemTypeGroupBox
        ' 
        MathProblemTypeGroupBox.Controls.Add(AddRadioButton)
        MathProblemTypeGroupBox.Controls.Add(SubtractRadioButton)
        MathProblemTypeGroupBox.Controls.Add(MultiplyRadioButton)
        MathProblemTypeGroupBox.Controls.Add(DivideRadioButton)
        MathProblemTypeGroupBox.Location = New Point(240, 109)
        MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        MathProblemTypeGroupBox.Size = New Size(152, 209)
        MathProblemTypeGroupBox.TabIndex = 16
        MathProblemTypeGroupBox.TabStop = False
        MathProblemTypeGroupBox.Text = "Math Problem Type"
        ' 
        ' ButtonGroupBox
        ' 
        ButtonGroupBox.Controls.Add(ExitButton)
        ButtonGroupBox.Controls.Add(SubmitButton)
        ButtonGroupBox.Controls.Add(SummaryButton)
        ButtonGroupBox.Controls.Add(ClearButton)
        ButtonGroupBox.Location = New Point(398, 12)
        ButtonGroupBox.Name = "ButtonGroupBox"
        ButtonGroupBox.Size = New Size(153, 306)
        ButtonGroupBox.TabIndex = 17
        ButtonGroupBox.TabStop = False
        ' 
        ' MathContestForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 330)
        Controls.Add(StudentInformationGroupBox)
        Controls.Add(CurrentMathProblemGroupBox)
        Controls.Add(MathProblemTypeGroupBox)
        Controls.Add(ButtonGroupBox)
        Name = "MathContestForm"
        Text = "Math Contest"
        StudentInformationGroupBox.ResumeLayout(False)
        StudentInformationGroupBox.PerformLayout()
        CurrentMathProblemGroupBox.ResumeLayout(False)
        CurrentMathProblemGroupBox.PerformLayout()
        MathProblemTypeGroupBox.ResumeLayout(False)
        MathProblemTypeGroupBox.PerformLayout()
        ButtonGroupBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label

End Class
