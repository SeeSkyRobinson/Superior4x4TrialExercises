Imports WinFormsApp1.DatabaseConnector

Public Class LoginForm
    Private ReadOnly dbConnector As New DatabaseConnector()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If dbConnector.ValidateUser(username, password) Then
            dbConnector.AddSuccessfulLogin(username)

            Dim successfulLoginForm As New SuccessfulLoginForm()
            successfulLoginForm.dgvLog.DataSource = dbConnector.GetSuccessfulLogins(username)
            successfulLoginForm.ShowDialog()
        Else
            Dim invalidLoginForm As New InvalidLoginForm()
            invalidLoginForm.ShowDialog()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

