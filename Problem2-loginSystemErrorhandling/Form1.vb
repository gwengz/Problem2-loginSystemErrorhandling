
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text.Trim()

            lblResult.Text = ""

            If username = "" Then
                Throw New EmptyFieldException("Username field cannot be empty.")
            End If

            If password = "" Then
                Throw New EmptyFieldException("Password field cannot be empty.")
            End If

            If username = "gwynethgoze" And password = "this_isDpassword" Then
                lblResult.Text = "Login successful!"
            Else
                lblResult.Text = "Invalid username or password."
            End If

        Catch ex As EmptyFieldException
            lblResult.Text = ex.Message

        Catch ex As Exception
            lblResult.Text = "An unexpected error occurred: " & ex.Message

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
