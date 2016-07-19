Imports System
Imports System.IO
Imports System.Text

Public Class SignIn
    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dim1 As String = "C:\Users\Public\RBSLTD"
        Dim dim2 As String = "C:\Users\Public\RBSLTD\logins"
        If (Not System.IO.Directory.Exists(dim1)) Then
            System.IO.Directory.CreateDirectory(dim1)
            If (Not System.IO.Directory.Exists(dim2)) Then
                System.IO.Directory.CreateDirectory(dim2)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim pass As String
        Dim pathname As String
        Dim pathpass As String
        Dim nameread As String
        Dim passread As String
        name = TextBox1.Text
        pass = TextBox2.Text

        If (Not System.IO.Directory.Exists("C:\Users\Public\RBSLTD\logins\" & name)) Then
            MsgBox("User does not exist ")
        Else
            pathname = "C:\Users\Public\RBSLTD\logins\" & name & "\username.txt"
            pathpass = "C:\Users\Public\RBSLTD\logins\" & name & "\password.txt"
            nameread = My.Computer.FileSystem.ReadAllText(pathname)
            passread = My.Computer.FileSystem.ReadAllText(pathpass)
            If name = nameread Then
                If pass = passread Then
                    MsgBox("Successfully logged in")
                Else
                    MsgBox("Invalid username or password")
                End If
            Else
                MsgBox("Invalid username or password")
            End If
        End If
    End Sub
End Class