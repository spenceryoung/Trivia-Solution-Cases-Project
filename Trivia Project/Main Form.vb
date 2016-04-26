' Project name:         Trivia Project
' Project purpose:      Displays trivia questions and
'                       answers and the number of incorrect
'                       answers made by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TriviaDataSet.tblGame' table. You can move, or remove it, as needed.
        Me.TblGameTableAdapter.Fill(Me.TriviaDataSet.tblGame)

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs)
        ' determines whether the user's answer is correct
        ' and the number of incorrect answers

        Dim ptrPosition As Integer
        Dim userAnswer As String
        Static numIncorrect As Integer

        ' store record pointer's position
        ptrPosition = TblGameBindingSource.Position

        ' determine selected radio button
        Select Case True
            Case aRadioButton.Checked
                userAnswer = aRadioButton.Text.Substring(1, 1)
            Case bRadioButton.Checked
                userAnswer = bRadioButton.Text.Substring(1, 1)
            Case cRadioButton.Checked
                userAnswer = cRadioButton.Text.Substring(1, 1)
            Case Else
                userAnswer = dRadioButton.Text.Substring(1, 1)
        End Select

        ' if necessary, update the number of incorrect answers
        If userAnswer <>
                TriviaDataSet.tblGame(ptrPosition).CorrectAnswer Then
            numIncorrect += 1
        End If

        If ptrPosition < 8 Then
            TblGameBindingSource.MoveNext()
        Else
            MessageBox.Show("Number incorrect: " &
                            numIncorrect.ToString, "Trivia Game",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TblGameBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class
