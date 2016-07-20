Imports System
Imports System.IO
Imports System.Text

Public Class SignIn
    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dim1 As String = "C:\Users\Public\RBSLTD"
        Dim dim2 As String = "C:\Users\Public\RBSLTD\logins"
        Dim dim3 As String = "C:\Users\Public\RBSLTD\logins\admin"
        Dim dim4 As String = "C:\Users\Public\RBSLTD\logins\admin\username.txt"
        Dim dim5 As String = "C:\Users\Public\RBSLTD\logins\admin\password.txt"
        Dim dim6 As String = "C:\Users\Public\RBSLTD\logins\admin\userlevel.txt"
        If (Not System.IO.Directory.Exists(dim1)) Then
            System.IO.Directory.CreateDirectory(dim1)
            If (Not System.IO.Directory.Exists(dim2)) Then
                System.IO.Directory.CreateDirectory(dim2)
            End If
        End If
        System.IO.Directory.CreateDirectory(dim3)
        System.IO.File.CreateText(dim4).Close()

        My.Computer.FileSystem.WriteAllText(dim4,
"admin", True)

        System.IO.File.CreateText(dim5).Close()
        My.Computer.FileSystem.WriteAllText(dim5,
"Admin", True)
        System.IO.File.CreateText(dim6).Close()
        My.Computer.FileSystem.WriteAllText(dim6,
"Admin", True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim pass As String
        Dim pathname As String
        Dim pathpass As String
        Dim nameread As String
        Dim passread As String
        Dim userlevel As String
        Dim levelread As String
        name = TextBox1.Text
        pass = TextBox2.Text

        If (Not System.IO.Directory.Exists("C:\Users\Public\RBSLTD\logins\" & name)) Then
            MsgBox("User does not exist ")
        Else
            pathname = "C:\Users\Public\RBSLTD\logins\" & name & "\username.txt"
            pathpass = "C:\Users\Public\RBSLTD\logins\" & name & "\password.txt"
            userlevel = "C:\Users\Public\RBSLTD\logins\" & name & "\userlevel.txt"
            nameread = My.Computer.FileSystem.ReadAllText(pathname)
            passread = My.Computer.FileSystem.ReadAllText(pathpass)
            levelread = My.Computer.FileSystem.ReadAllText(userlevel)
            If name = nameread Then
                If pass = passread Then
                    If levelread = "User" Then
                        User.Show()
                        Me.Hide()
                    Else
                        If levelread = "Moderator" Then
                            Moderator.Show()
                            Me.Hide()
                        Else
                        End If
                        If levelread = "Admin" Then
                            Admin.Show()
                            Me.Hide()
                        Else
                        End If
                    End If
                Else
                    MsgBox("Invalid username or password")
                End If
            Else
                MsgBox("Invalid username or password")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register.Show()
    End Sub
End Class