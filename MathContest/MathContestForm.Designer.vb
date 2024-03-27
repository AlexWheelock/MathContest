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
        components = New ComponentModel.Container()
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
        MainToolTip = New ToolTip(components)
        StudentInformationGroupBox.SuspendLayout()
        CurrentMathProblemGroupBox.SuspendLayout()
        MathProblemTypeGroupBox.SuspendLayout()
        ButtonGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(5, 38)
        NameTextBox.Margin = New Padding(3, 2, 3, 2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(183, 23)
        NameTextBox.TabIndex = 0
        ' 
        ' FirstNumberTextBox
        ' 
        FirstNumberTextBox.Location = New Point(5, 43)
        FirstNumberTextBox.Margin = New Padding(3, 2, 3, 2)
        FirstNumberTextBox.Name = "FirstNumberTextBox"
        FirstNumberTextBox.ReadOnly = True
        FirstNumberTextBox.Size = New Size(183, 23)
        FirstNumberTextBox.TabIndex = 3
        FirstNumberTextBox.TabStop = False
        ' 
        ' SecondNumberTextBox
        ' 
        SecondNumberTextBox.Location = New Point(5, 86)
        SecondNumberTextBox.Margin = New Padding(3, 2, 3, 2)
        SecondNumberTextBox.Name = "SecondNumberTextBox"
        SecondNumberTextBox.ReadOnly = True
        SecondNumberTextBox.Size = New Size(183, 23)
        SecondNumberTextBox.TabIndex = 4
        SecondNumberTextBox.TabStop = False
        ' 
        ' StudentAnswerTextBox
        ' 
        StudentAnswerTextBox.Location = New Point(5, 131)
        StudentAnswerTextBox.Margin = New Padding(3, 2, 3, 2)
        StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        StudentAnswerTextBox.Size = New Size(183, 23)
        StudentAnswerTextBox.TabIndex = 3
        ' 
        ' AgeTextBox
        ' 
        AgeTextBox.Location = New Point(211, 38)
        AgeTextBox.Margin = New Padding(3, 2, 3, 2)
        AgeTextBox.Name = "AgeTextBox"
        AgeTextBox.Size = New Size(37, 23)
        AgeTextBox.TabIndex = 1
        ' 
        ' AddRadioButton
        ' 
        AddRadioButton.AutoSize = True
        AddRadioButton.Checked = True
        AddRadioButton.Location = New Point(11, 26)
        AddRadioButton.Margin = New Padding(3, 2, 3, 2)
        AddRadioButton.Name = "AddRadioButton"
        AddRadioButton.Size = New Size(47, 19)
        AddRadioButton.TabIndex = 4
        AddRadioButton.TabStop = True
        AddRadioButton.Text = "Add"
        AddRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractRadioButton
        ' 
        SubtractRadioButton.AutoSize = True
        SubtractRadioButton.Location = New Point(11, 48)
        SubtractRadioButton.Margin = New Padding(3, 2, 3, 2)
        SubtractRadioButton.Name = "SubtractRadioButton"
        SubtractRadioButton.Size = New Size(69, 19)
        SubtractRadioButton.TabIndex = 5
        SubtractRadioButton.Text = "Subtract"
        SubtractRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MultiplyRadioButton
        ' 
        MultiplyRadioButton.AutoSize = True
        MultiplyRadioButton.Location = New Point(11, 70)
        MultiplyRadioButton.Margin = New Padding(3, 2, 3, 2)
        MultiplyRadioButton.Name = "MultiplyRadioButton"
        MultiplyRadioButton.Size = New Size(69, 19)
        MultiplyRadioButton.TabIndex = 6
        MultiplyRadioButton.Text = "Multiply"
        MultiplyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DivideRadioButton
        ' 
        DivideRadioButton.AutoSize = True
        DivideRadioButton.Location = New Point(11, 93)
        DivideRadioButton.Margin = New Padding(3, 2, 3, 2)
        DivideRadioButton.Name = "DivideRadioButton"
        DivideRadioButton.Size = New Size(58, 19)
        DivideRadioButton.TabIndex = 7
        DivideRadioButton.Text = "Divide"
        DivideRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(4, 17)
        SubmitButton.Margin = New Padding(3, 2, 3, 2)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(124, 44)
        SubmitButton.TabIndex = 8
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(4, 65)
        ClearButton.Margin = New Padding(3, 2, 3, 2)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(124, 44)
        ClearButton.TabIndex = 9
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(5, 113)
        SummaryButton.Margin = New Padding(3, 2, 3, 2)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(124, 44)
        SummaryButton.TabIndex = 10
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(5, 161)
        ExitButton.Margin = New Padding(3, 2, 3, 2)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(124, 44)
        ExitButton.TabIndex = 11
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
        StudentInformationGroupBox.Location = New Point(10, 9)
        StudentInformationGroupBox.Margin = New Padding(3, 2, 3, 2)
        StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        StudentInformationGroupBox.Padding = New Padding(3, 2, 3, 2)
        StudentInformationGroupBox.Size = New Size(332, 68)
        StudentInformationGroupBox.TabIndex = 14
        StudentInformationGroupBox.TabStop = False
        StudentInformationGroupBox.Text = "Student Information"
        ' 
        ' GradeLabel
        ' 
        GradeLabel.AutoSize = True
        GradeLabel.Location = New Point(271, 21)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New Size(38, 15)
        GradeLabel.TabIndex = 18
        GradeLabel.Text = "Grade"
        ' 
        ' AgeLabel
        ' 
        AgeLabel.AutoSize = True
        AgeLabel.Location = New Point(211, 21)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New Size(28, 15)
        AgeLabel.TabIndex = 17
        AgeLabel.Text = "Age"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(5, 21)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(39, 15)
        NameLabel.TabIndex = 16
        NameLabel.Text = "Name"
        ' 
        ' GradeTextBox
        ' 
        GradeTextBox.Location = New Point(271, 38)
        GradeTextBox.Margin = New Padding(3, 2, 3, 2)
        GradeTextBox.Name = "GradeTextBox"
        GradeTextBox.Size = New Size(37, 23)
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
        CurrentMathProblemGroupBox.Location = New Point(10, 82)
        CurrentMathProblemGroupBox.Margin = New Padding(3, 2, 3, 2)
        CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        CurrentMathProblemGroupBox.Padding = New Padding(3, 2, 3, 2)
        CurrentMathProblemGroupBox.Size = New Size(194, 162)
        CurrentMathProblemGroupBox.TabIndex = 15
        CurrentMathProblemGroupBox.TabStop = False
        CurrentMathProblemGroupBox.Text = "Current Math Problem"
        ' 
        ' StudentAnswerLabel
        ' 
        StudentAnswerLabel.AutoSize = True
        StudentAnswerLabel.Location = New Point(5, 114)
        StudentAnswerLabel.Name = "StudentAnswerLabel"
        StudentAnswerLabel.Size = New Size(90, 15)
        StudentAnswerLabel.TabIndex = 21
        StudentAnswerLabel.Text = "Student Answer"
        ' 
        ' SecondNumberLabel
        ' 
        SecondNumberLabel.AutoSize = True
        SecondNumberLabel.Location = New Point(5, 69)
        SecondNumberLabel.Name = "SecondNumberLabel"
        SecondNumberLabel.Size = New Size(74, 15)
        SecondNumberLabel.TabIndex = 20
        SecondNumberLabel.Text = "2nd Number"
        ' 
        ' FirstNumberLabel
        ' 
        FirstNumberLabel.AutoSize = True
        FirstNumberLabel.Location = New Point(5, 26)
        FirstNumberLabel.Name = "FirstNumberLabel"
        FirstNumberLabel.Size = New Size(69, 15)
        FirstNumberLabel.TabIndex = 19
        FirstNumberLabel.Text = "1st Number"
        ' 
        ' MathProblemTypeGroupBox
        ' 
        MathProblemTypeGroupBox.Controls.Add(AddRadioButton)
        MathProblemTypeGroupBox.Controls.Add(SubtractRadioButton)
        MathProblemTypeGroupBox.Controls.Add(MultiplyRadioButton)
        MathProblemTypeGroupBox.Controls.Add(DivideRadioButton)
        MathProblemTypeGroupBox.Location = New Point(210, 82)
        MathProblemTypeGroupBox.Margin = New Padding(3, 2, 3, 2)
        MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        MathProblemTypeGroupBox.Padding = New Padding(3, 2, 3, 2)
        MathProblemTypeGroupBox.Size = New Size(133, 162)
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
        ButtonGroupBox.Location = New Point(348, 9)
        ButtonGroupBox.Margin = New Padding(3, 2, 3, 2)
        ButtonGroupBox.Name = "ButtonGroupBox"
        ButtonGroupBox.Padding = New Padding(3, 2, 3, 2)
        ButtonGroupBox.Size = New Size(134, 235)
        ButtonGroupBox.TabIndex = 17
        ButtonGroupBox.TabStop = False
        ' 
        ' MainToolTip
        ' 
        ' 
        ' MathContestForm
        ' 
        AcceptButton = SubmitButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ExitButton
        ClientSize = New Size(494, 254)
        Controls.Add(StudentInformationGroupBox)
        Controls.Add(CurrentMathProblemGroupBox)
        Controls.Add(MathProblemTypeGroupBox)
        Controls.Add(ButtonGroupBox)
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents MainToolTip As ToolTip

End Class
