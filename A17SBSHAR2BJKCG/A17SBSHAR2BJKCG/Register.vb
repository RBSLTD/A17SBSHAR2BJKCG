Imports System
Imports System.IO
Imports System.Text
Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminname As String
        Dim adminpass As String
        Dim adminlevel As String
        Dim pathname As String
        Dim pathpass As String
        Dim pathlevel As String
        Dim nameread As String
        Dim passread As String
        adminname = TextBox1.Text
        adminpass = TextBox2.Text

        If (Not System.IO.Directory.Exists("C:\Users\Public\RBSLTD\logins\" & adminname)) Then
            MsgBox("User does not exist ")
        Else
            pathname = "C:\Users\Public\RBSLTD\logins\" & adminname & "\username.txt"
            pathpass = "C:\Users\Public\RBSLTD\logins\" & adminname & "\password.txt"
            pathlevel = "C:\Users\Public\RBSLTD\logins\" & adminname & "\userlevel.txt"
            nameread = My.Computer.FileSystem.ReadAllText(pathname)
            passread = My.Computer.FileSystem.ReadAllText(pathpass)
            adminlevel = My.Computer.FileSystem.ReadAllText(pathlevel)
            If adminname = nameread Then
                If adminpass = passread Then
                    If adminlevel = "Admin" Then
                        Dim useruser As String = TextBox3.Text
                        Dim userpass As String = TextBox4.Text
                        Dim userlevel As String = ComboBox2.Text

                        Dim dim1 As String = "C:\Users\Public\RBSLTD\logins\" & useruser
                        Dim dim2 As String = dim1 & "\username.txt"
                        Dim dim3 As String = dim1 & "\password.txt"
                        Dim dim4 As String = dim1 & "\userlevel.txt"

                        If (Not System.IO.Directory.Exists(dim1)) Then
                            System.IO.Directory.CreateDirectory(dim1)
                            System.IO.File.CreateText(dim2).Close()
                            My.Computer.FileSystem.WriteAllText(dim2,
useruser, True)
                            System.IO.File.CreateText(dim3).Close()
                            My.Computer.FileSystem.WriteAllText(dim3,
userpass, True)
                            System.IO.File.CreateText(dim4).Close()
                            My.Computer.FileSystem.WriteAllText(dim4,
userlevel, True)
                            MsgBox("User created")

                            SignIn.Show()
                            Me.Close()
                        Else
                            MsgBox("Username taken")
                        End If
                    Else
                        MsgBox("User does not have sufficent permissions to create user accounts")
                    End If

                Else
                        MsgBox("Invalid username or password")
                End If
            Else
                MsgBox("Invalid username or password")
            End If
        End If
    End Sub
End Class