Imports MySql.Data.MySqlClient

Public Class DatabaseConnector
    Private connectionString As String

    Public Sub New()
        connectionString = "server=localhost;userid=root;password=;database=testdb;"
    End Sub

    Public Function ValidateUser(username As String, password As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)

            Using reader As MySqlDataReader = command.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Public Function GetSuccessfulLogins(username As String) As DataTable
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM successful_logins WHERE username = @username", connection)
            command.Parameters.AddWithValue("@username", username)

            Dim dataTable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using

            Return dataTable
        End Using
    End Function

    Public Sub AddSuccessfulLogin(username As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("INSERT INTO successful_logins (username, login_time) VALUES (@username, CURRENT_TIMESTAMP)", connection)
            command.Parameters.AddWithValue("@username", username)
            command.ExecuteNonQuery()
        End Using
    End Sub



End Class
