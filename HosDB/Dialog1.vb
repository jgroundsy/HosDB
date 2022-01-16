Imports System.Windows.Forms

Public Class newEmployee

    Private Sub newEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameBox.Text = ""
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If usernameBox.Text <> "" AndAlso Dir(Environ("USERPROFILE") + "\Documents\HosDB\" + usernameBox.Text) Is "" Then
            Dim username As String = usernameBox.Text
            Dim rndnumber As Random
            Dim pin1 As Integer
            Dim pin2 As Integer
            Dim pin3 As Integer
            Dim password As String

            rndnumber = New Random

            pin1 = rndnumber.Next(0, 10000)
            pin2 = rndnumber.Next(0, 10000)
            pin3 = rndnumber.Next(0, 10000)

            password = (pin1.ToString & "-" & pin2.ToString & "-" & pin3.ToString)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            My.Computer.FileSystem.CreateDirectory(Environ("USERPROFILE") + "\Documents\HosDB\" + username.ToString + "\Patients\")

            Database.CreateFile(username.ToString & "," & password.ToString, Environ("USERPROFILE") + "\Documents\HosDB\" + username.ToString + "\", "data.txt")

            Me.Close()
            MsgBox("User successfully created!" + vbNewLine + "Password: " + password)
            Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Created a new employee (" & username.ToString & "). Temp PIN: " & password.ToString, Database.changelogPath, Database.changelogFilename)
        Else
            MsgBox("Usename is already taken.")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
