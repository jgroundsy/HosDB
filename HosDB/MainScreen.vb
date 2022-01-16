Imports System.IO

Public Class MainScreen
    Dim sr As StreamReader
    Public attempts As Integer = 3
    Public loggedUser As String
    Dim clientversion As Decimal = 1.5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim versionFile As String = File.ReadAllText(Environ("USERPROFILE") + "\Documents\HosDB\version.txt").ToString
        Dim listedversion() As String = Split(versionFile, ",")


        If listedversion.GetValue(0).ToString <> clientversion.ToString Then
            MsgBox(listedversion.GetValue(1))
        End If

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim userCredentials() As String
        Dim user As String = Rnd()
        Dim pass As String = Rnd()

        If My.Computer.FileSystem.DirectoryExists(Environ("USERPROFILE") + "\Documents\HosDB\" + userBox.Text.ToString) Then
            Dim dataPath As String = (Environ("USERPROFILE") + "\Documents\HosDB\" + userBox.Text.ToString + "\data.txt")
            Dim userdata As String = File.ReadAllText(dataPath.ToString).ToString
            userCredentials = Split(userdata, ",")
            user = userCredentials.GetValue(0).ToString
            pass = userCredentials.GetValue(1).ToString
            loggedUser = userBox.Text

            If userBox.Text.ToString = user AndAlso passBox.Text.ToString = pass.TrimEnd(" ") AndAlso (attempts > 0) Then
                msgLabel.ForeColor = Color.Green
                msgLabel.Text = ("Welcome, " + user + ".")
                Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Successfully logged in " + userBox.Text, Database.changelogPath, Database.changelogFilename)
                loginTimer.Start()
            ElseIf userBox.Text.ToString IsNot user Or passBox.Text.ToString IsNot pass AndAlso (attempts > 0) Then
                attempts = attempts - 1
                msgLabel.ForeColor = Color.Red
                msgLabel.Text = ("Invalid Credentials - Attempts: " + attempts.ToString + ".")
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Invalid Credentials for " + userBox.Text + ". Attempts: " + attempts.ToString, Database.changelogPath, Database.changelogFilename)
            Else
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox("Error logged. Try again.")
                Database.CreateFile(vbNewLine + Now.ToLocalTime + ": ERROR OCCURRED.", Database.changelogPath, Database.changelogFilename)
            End If

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            msgLabel.ForeColor = Color.Red
            msgLabel.Text = ("Invalid Credentials - Attempts: " + attempts.ToString + ".")
            Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Invalid Credentials for " + userBox.Text + ". Attempts: " + attempts.ToString, Database.changelogPath, Database.changelogFilename)
        End If


        If (attempts <= 0) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            msgLabel.ForeColor = Color.Red
            msgLabel.Text = ("Too many login attempts.")
            loginButton.Enabled = False
            Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Too many login attempts for " + userBox.Text, Database.changelogPath, Database.changelogFilename)
        End If

    End Sub

    Private Sub loginTimer_Tick(sender As Object, e As EventArgs) Handles loginTimer.Tick
        Dim time As Int16
        If (time > 0) Then
            time = time - 1
        Else loginTimer.Stop()
            Me.Hide()
            Database.Show()

        End If
    End Sub
End Class
