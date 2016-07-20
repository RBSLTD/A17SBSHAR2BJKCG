Public Class newcustomeruser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstname As String = TextBox1.Text
        Dim lastname As String = TextBox2.Text
        Dim name As String = firstname & lastname
        Dim number As String = TextBox3.Text
        Dim address As String = TextBox4.Text
        Dim dir As String = name & "-" & number
        Dim dirnewname As String = "C:\Users\Public\RBSLTD\Customers\" & dir
        Dim dirfirstname As String = dirnewname & "\first name.txt"
        Dim dirlastname As String = dirnewname & "\last name.txt"
        Dim dirnumber As String = dirnewname & "\phonenumber.txt"
        Dim diraddress As String = dirnewname & "\address.txt"
        Dim dirduepay As String = dirnewname & "\due-payments.txt"
        Dim dirworkcarriedout As String = dirnewname & "\work-done.txt"

        If (Not System.IO.Directory.Exists(dirnewname)) Then
            System.IO.Directory.CreateDirectory(dirnewname)
            System.IO.File.CreateText(dirfirstname).Close()
            System.IO.File.CreateText(dirlastname).Close()
            System.IO.File.CreateText(dirnumber).Close()
            System.IO.File.CreateText(diraddress).Close()
            System.IO.File.CreateText(dirduepay).Close()
            System.IO.File.CreateText(dirworkcarriedout).Close()

            My.Computer.FileSystem.WriteAllText(dirfirstname, firstname, True)
            My.Computer.FileSystem.WriteAllText(dirlastname, lastname, True)
            My.Computer.FileSystem.WriteAllText(dirnumber, number, True)
            My.Computer.FileSystem.WriteAllText(diraddress, address, True)

            MsgBox("Customer added")
            User.Show()
            Me.Hide()
        Else
            MsgBox("Customer already exists - contact a moderator if you believe their is an error")
        End If
    End Sub
End Class