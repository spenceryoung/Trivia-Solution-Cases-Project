

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private numIncorrect As Integer
    Private isAnswered(8) As Boolean

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TriviaDataSet.tblGame' table. You can move, or remove it, as needed.
        Me.TblGameTableAdapter.Fill(Me.TriviaDataSet.tblGame)
        incorrectButton.Enabled = False
        changeButton.Enabled = False
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click

        TblGameBindingSource.MovePrevious()
        If isAnswered(TblGameBindingSource.Position) = True Then
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                    control.Enabled = False
                End If
            Next
            submitButton.Enabled = False
            incorrectButton.Enabled = True
            changeButton.Enabled = True
        Else
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                    control.Enabled = True
                End If
            Next
            submitButton.Enabled = True
            incorrectButton.Enabled = False
            changeButton.Enabled = False
        End If
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        TblGameBindingSource.MoveNext()
        If isAnswered(TblGameBindingSource.Position) = True Then
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                    control.Enabled = False
                End If
            Next
            submitButton.Enabled = False
            incorrectButton.Enabled = True
            changeButton.Enabled = True
        Else
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                    control.Enabled = True
                End If
            Next
            submitButton.Enabled = True
            incorrectButton.Enabled = False
            changeButton.Enabled = False
        End If
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' determines whether the user's answer is correct
        ' and the number of incorrect answers

        Dim ptrPosition As Integer
        Dim userAnswer As String

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

        isAnswered(TblGameBindingSource.Position) = True

        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                control.Enabled = False
            End If
        Next
        submitButton.Enabled = False
        incorrectButton.Enabled = True
        changeButton.Enabled = True

    End Sub

    Private Sub changeButton_Click(sender As Object, e As EventArgs) Handles changeButton.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Or TypeOf control Is RadioButton Then
                control.Enabled = True
            End If
        Next
        submitButton.Enabled = True
    End Sub

    Private Sub incorrectButton_Click(sender As Object, e As EventArgs) Handles incorrectButton.Click
        MessageBox.Show("Number incorrect: " &
                            numIncorrect.ToString, "Trivia Game",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class