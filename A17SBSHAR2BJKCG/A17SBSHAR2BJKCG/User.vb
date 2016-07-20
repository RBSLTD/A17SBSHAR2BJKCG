Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dir1 As String = "C:\Users\Public\RBSLTD\Customers"

        If (Not System.IO.Directory.Exists(dir1)) Then
            System.IO.Directory.CreateDirectory(dir1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customername As String = TextBox1.Text & TextBox2.Text
        Dim customernumber As String = TextBox3.Text
        Dim customerdir As String = "C:\Users\Public\RBSLTD\Customers\" & customername & "-" & customernumber

        MsgBox(customerdir)
        If (Not System.IO.Directory.Exists(customerdir)) Then
            MsgBox("Customer does not exist")
        Else
            Dim firstname As String
            Dim lastname As String
            Dim phonenumber As String
            Dim address As String
            Dim duepayments As String
            Dim workcarriedout As String

            Dim dirfirstname As String = customerdir & "\first name.txt"
            Dim dirlastname As String = customerdir & "\last name.txt"
            Dim dirphonenumber As String = customerdir & "\phonenumber.txt"
            Dim diraddress As String = customerdir & "\address.txt"
            Dim dirduepayments As String = customerdir & "\due-payments.txt"
            Dim dirworkcarriedout As String = customerdir & "\work-done.txt"

            firstname = My.Computer.FileSystem.ReadAllText(dirfirstname)
            lastname = My.Computer.FileSystem.ReadAllText(dirlastname)
            phonenumber = My.Computer.FileSystem.ReadAllText(dirphonenumber)
            address = My.Computer.FileSystem.ReadAllText(diraddress)
            duepayments = My.Computer.FileSystem.ReadAllText(dirduepayments)
            workcarriedout = My.Computer.FileSystem.ReadAllText(dirworkcarriedout)

            MsgBox("First name : " & firstname + Environment.NewLine + "Last name : " & lastname + Environment.NewLine + "Phone number : " & phonenumber + Environment.NewLine + "Address : " & address + Environment.NewLine + "Work done : " & workcarriedout + Environment.NewLine + "Payments due : " & duepayments)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newcustomeruser.Show()
        Me.Hide()
    End Sub
End Class