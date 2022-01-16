Imports System.IO
Public Class Database
    Public selectedUser As String
    Public changelogPath As String = (Environ("USERPROFILE") + "\Documents\HosDB\admin\Changelogs\")
    Public changelogFilename As String = ("changelog_" + DateTime.Now.ToString("MM.dd.yyyy") + ".txt")

    Public mouseXCheck As Decimal
    Public mouseYCheck As Decimal
    Public ActivityTime As Decimal
    Public filePath As String = (Environ("USERPROFILE") + "\Documents\HosDB\" + MainScreen.loggedUser.ToString + "\Patients\")
    Dim patientDatabase() As String = Directory.GetDirectories(filePath)

    Public BillingStatement As Image


    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statementBox.ImageLocation = (Environ("USERPROFILE") + "\Documents\HosDB\statement.jpg")
        Me.Text = ("HosDB: Logged in as " + MainScreen.loggedUser)
        addPatients()

        If MainScreen.loggedUser = "admin" Then
            AdminSettings.Show()
            Me.Hide()
            Me.CreateFile(vbNewLine + Now.ToLocalTime + ": ***ENTERING ADMINISTRATOR MODE***", Me.changelogPath, Me.changelogFilename)
        End If
    End Sub

    Function addPatients()

        patientList.Items.Clear()
        patientDatabase = Directory.GetDirectories(filePath)
        Dim di As New IO.DirectoryInfo(filePath)
        Dim patients() As IO.DirectoryInfo = di.GetDirectories()

        For Each folder As IO.DirectoryInfo In patients
            patientList.Items.Add(folder.Name.ToString)
        Next

        patientList.Items.Remove("")
        patientList.Items.Remove("")
    End Function

    Public Sub patientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientList.SelectedIndexChanged
        selectedUser = patientList.SelectedItem
        If My.Computer.FileSystem.FileExists(Environ("USERPROFILE") + "\Documents\HosDB\" + MainScreen.loggedUser + "\Patients\" + selectedUser + "\notes.txt") Then
            Dim objReader As New System.IO.StreamReader(Environ("USERPROFILE") + "\Documents\HosDB\" + MainScreen.loggedUser + "\Patients\" + selectedUser + "\notes.txt")
            NotesBox.Text = objReader.ReadToEnd
            objReader.Close()
        End If



        Me.CreateFile(vbNewLine + Now.ToLocalTime + ": " + MainScreen.loggedUser + " viewed patient " + selectedUser + "'s file", Me.changelogPath, Me.changelogFilename)

        Dim patientName As String = getPatientItem(0)
        Dim patientAddress As String = (getPatientItem(1) + " " + getPatientItem(2) + ", " + getPatientItem(3))
        Dim patientNumber As String = getPatientItem(4)
        Dim patientSSN As String = getPatientItem(5)
        Dim workplaceCompany As String = getPatientItem(6)
        Dim workplaceAddress As String = (getPatientItem(7) + " " + getPatientItem(8) + ", " + getPatientItem(9))
        Dim workplaceEmployer As String = getPatientItem(10)
        Dim workplaceNumber As String = getPatientItem(11)

        Dim patientDOB As String = getPatientMore(0)
        Dim patientAge As String = getPatientMore(1)
        Dim patientHeight As String = getPatientMore(2)
        Dim patientWeight As String = getPatientMore(3)
        Dim patientSex As String = getPatientMore(4)
        Dim patientDate As String = getPatientMore(5)
        Dim insurancePNumber As String = getPatientMore(6)
        Dim insuranceGNumber As String = getPatientMore(7)
        Dim patientGName As String = getPatientMore(8)


        nameInfo.Text = patientName
        addressInfo.Text = patientAddress
        numberInfo.Text = patientNumber
        wpAddressInfo.Text = workplaceAddress
        wpCompanyInfo.Text = workplaceCompany
        wpEmployerInfo.Text = workplaceEmployer
        wpNumberInfo.Text = workplaceNumber
        ssnInfo.Text = patientSSN
        dobLabel.Text = patientDOB
        ageLabel.Text = patientAge
        heightLabel.Text = patientHeight
        weightLabel.Text = patientWeight
        sexLabel.Text = patientSex
        dateLabel.Text = patientDate
        pNumberLabel.Text = insurancePNumber
        gNumberLabel.Text = insuranceGNumber
        groupNameLabel.Text = patientGName


    End Sub

    Function getPatientItem(item As Integer) As String
        If selectedUser IsNot Nothing And Dir(Environ("USERPROFILE") + "\Documents\HosDB\" + MainScreen.loggedUser + "\Patients\" + selectedUser) IsNot "" Then
            Dim patientFile() As String = Split(File.ReadAllText(filePath & "\" & selectedUser & "\" & "basicInfo.txt"), ",")

            If patientFile.Count > 10 Then
                Return patientFile.GetValue(item)
            Else
                Return "N/A"
            End If
        Else
            'do nothing. No valid patient was selected
        End If
    End Function

    Function getPatientMore(item As Integer) As String

        If selectedUser IsNot Nothing And My.Computer.FileSystem.DirectoryExists((Environ("USERPROFILE") + "\Documents\HosDB\" + MainScreen.loggedUser + "\Patients\" + selectedUser)) Then
            Dim patientFile() As String = Split(File.ReadAllText(filePath & "\" & selectedUser & "\" & "moreInfo.txt"), ",")

            If patientFile.Count > 7 Then
                Return patientFile.GetValue(item)
            Else
                Return "N/A"
            End If
        Else
            'do nothing. No valid patient was selected
        End If
    End Function


    Function logOut() As String
        Application.Restart()

    End Function
    Public Sub CreateFile(text As String, directory As String, fileName As String)
        If Dir(directory) IsNot "" Then
            Dim fs As New IO.StreamWriter(directory & fileName, True)
            fs.WriteLine(text.ToString)
            fs.Close()
        Else
            My.Computer.FileSystem.CreateDirectory(directory)
            Dim fs As New IO.StreamWriter(directory & fileName, True)
            fs.WriteLine(text.ToString)
            fs.Close()
        End If

    End Sub

    Public Sub OverwriteFile(text As String, directory As String, fileName As String)
        If Dir(directory) IsNot "" Then
            Dim fs As New IO.StreamWriter(directory & fileName, False)
            fs.WriteLine(text.ToString)
            fs.Close()
        Else
            My.Computer.FileSystem.CreateDirectory(directory)
            Dim fs As New IO.StreamWriter(directory & fileName, True)
            fs.WriteLine(text.ToString)
            fs.Close()
        End If

    End Sub

    Private Sub newPatientButton_Click(sender As Object, e As EventArgs) Handles newPatientButton.Click

        If newPatient.ShowDialog = DialogResult.OK Then
            addPatients()
            Me.CreateFile(vbNewLine + Now.ToLocalTime + ": " & MainScreen.loggedUser.ToString & " added patient " & newPatient.firstNameBox.Text & " " & newPatient.middleNameBox.Text & " " & newPatient.lastNameBox.Text, Me.changelogPath, Me.changelogFilename)
        Else
            'cancels new patient operation
        End If

    End Sub

    Public Sub AFKTimer_Tick(sender As Object, e As EventArgs) Handles AFKTimer.Tick

        If ActivityTime = 300 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            ActivityMonitor.Show()
        End If

        If mouseXCheck = Cursor.Position.X And mouseYCheck = Cursor.Position.Y Then
            ActivityTime = ActivityTime + 1
        Else
            ActivityTime = 0
        End If

        mouseXCheck = Cursor.Position.X
        mouseYCheck = Cursor.Position.Y



    End Sub
    Private Sub editPatientButton_Click(sender As Object, e As EventArgs) Handles editPatientButton.Click

        If tabControl.SelectedTab.ToString = "TabPage: {Basic Info}" Then

            If editPatient.ShowDialog = DialogResult.OK Then
                addPatients()
                Me.CreateFile(vbNewLine + Now.ToLocalTime + ": " & MainScreen.loggedUser & " edited the file of patient " & editPatient.patientName.ToString, Me.changelogPath, Me.changelogFilename)
            Else
                'cancels edit patient operation
            End If
        End If


        If tabControl.SelectedTab.ToString = "TabPage: {More Info}" Then
            If editPatientMore.ShowDialog = DialogResult.OK Then

                Dim patientDOB As String = getPatientMore(0)
                Dim patientAge As String = getPatientMore(1)
                Dim patientHeight As String = getPatientMore(2)
                Dim patientWeight As String = getPatientMore(3)
                Dim patientSex As String = getPatientMore(4)
                Dim patientDate As String = getPatientMore(5)
                Dim insurancePNumber As String = getPatientMore(6)
                Dim insuranceGNumber As String = getPatientMore(7)
                Dim patientGName As String = getPatientMore(8)

                dobLabel.Text = patientDOB
                ageLabel.Text = patientAge
                heightLabel.Text = patientHeight
                weightLabel.Text = patientWeight
                sexLabel.Text = patientSex
                dateLabel.Text = patientDate
                pNumberLabel.Text = insurancePNumber
                gNumberLabel.Text = insuranceGNumber
                groupNameLabel.Text = patientGName
            Else
                'cancel edit patient operation
            End If
        End If


        If tabControl.SelectedTab.ToString = "TabPage: {Notes}" Then
            MsgBox("Use the embedded notes editor within the tab.")
        End If


        If tabControl.SelectedTab.ToString = "TabPage: {Billing & Statements}" Then
            MsgBox("Please edit the billing statement .pdf directly.")

        Else
            'do nothing

        End If



    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        logOut()
    End Sub


    Private Sub deletePatientButton_Click(sender As Object, e As EventArgs) Handles deletePatientButton.Click
        If My.Computer.FileSystem.DirectoryExists(Me.filePath & selectedUser & "\") Then
            MsgBox(selectedUser & " was successfully deleted!")
            Me.CreateFile(vbNewLine + Now.ToLocalTime + ": " & MainScreen.loggedUser.ToString & " deleted patient " & selectedUser, Me.changelogPath, Me.changelogFilename)
            My.Computer.FileSystem.DeleteDirectory(Me.filePath + selectedUser + "\", FileIO.DeleteDirectoryOption.DeleteAllContents)
            addPatients()
            patientList.ClearSelected()

        Else
            MsgBox("This patient directory does not exit.")
        End If
    End Sub

    Private Sub saveNotesButton_Click(sender As Object, e As EventArgs) Handles saveNotesButton.Click
        Dim text As String = NotesBox.Text
        OverwriteFile(text, Me.filePath & selectedUser & "\", "notes.txt")
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        If tabControl.SelectedTab.ToString = "TabPage: {Billing & Statements}" Then
            BillingStatement = Image.FromFile(Environ("USERPROFILE") + "\Documents\HosDB\statement.jpg")
            PrintStatement.Print()

        Else
            MsgBox("Please select the 'Billing & Statements' tab")
        End If
    End Sub

    Private Sub PrintStatement_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintStatement.PrintPage
        e.Graphics.DrawImage(BillingStatement, 0, 0)
    End Sub

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
    End Sub
End Class