
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin

    Public userLogin As String
    Public loginAttempt As Integer = 0
    Public existingUsers() As String = {"Bkassin scooter3", "Djeter kstate21", "Ljames hooper31", "Lwayne shawty1"}

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Need to check the user database for credintals. 
        'If credintals match allow user to login in to correct home screen view
        'If incorrect give error message and number of attempts. If user exceeds 3 attempts lock user out

        ConnectToSQL()

    End Sub

    'Connect to SQL method

    Private Sub ConnectToSQL()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Password As String
        Dim Password2 As String
        Dim userName As String



        Try
            If
                'change the data source and initial catalog according to your sql server engine and data base
                con.ConnectionString = "Data Source = Azure; Initial Catalog = YOUR-DB; Integrated Security = True"
                con.Open()

                cmd.Connection = con
                'change the data fields names and table according to your database
                cmd.CommandText = " SELECT  UserName, Password FROM   Table-Name WHERE   (UserName = '" & txtUsername.Text & "' ) AND (Password = '" & txtPassword.Text & "')"

                Dim lrd As SqlDataReader = cmd.ExecuteReader()
                If lrd.HasRows Then
                    While lrd.Read()

                        'Do something here
                        Password = lrd("Password").ToString()
                        userName = lrd("UserName").ToString()

                        Password2 = txtPassword.Text()

                        If Password = Password2 And userName = txtUsername.Text Then

                            MessageBox.Show("Logged in successfully as " & userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information
                                        )
                            frmMain.Show()
                            Me.Hide()

                            'Clear all fields
                            txtPassword.Text = ""
                            txtUsername.Text = ""

                        End If

                    End While

                Else
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Clear all fields
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

        Finally
            con.Close() 'Whether there is error or not. Close the connection.

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'btnCancel will cancel the login operations and close the system.
        Me.Close()
    End Sub

End Class
