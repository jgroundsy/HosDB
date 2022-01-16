Imports System.Windows.Forms

Public Class editPatient
    Public patientName As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim newFileText As String = (nameBox.Text + "," + addressBox.Text + "," + cityBox.Text + "," + stateBox.Text + "," + numberBox.Text + "," + ssnBox.Text + "," + companyNameBox.Text + "," + companyStreetBox.Text + "," + companyCityBox.Text + "," +
            companyStateBox.Text + "," + companyEmployerBox.Text + "," + companyNumberBox.Text)

        If nameBox.Text.ToString <> Database.selectedUser Then
            My.Computer.FileSystem.RenameDirectory(Database.filePath + Database.selectedUser + "\", nameBox.Text)
            Database.OverwriteFile(newFileText.ToString, Database.filePath & nameBox.Text & "\", "basicInfo.txt")
        Else
            Database.OverwriteFile(newFileText.ToString, Database.filePath & nameBox.Text & "\", "basicInfo.txt")
        End If

        Database.addPatients()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub editPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientName = Database.getPatientItem(0)
        Dim patientAddress As String = Database.getPatientItem(1)
        Dim patientCity As String = Database.getPatientItem(2)
        Dim patientState As String = Database.getPatientItem(3)
        Dim patientNumber As String = Database.getPatientItem(4)
        Dim patientSSN As String = Database.getPatientItem(5)
        Dim workplaceCompany As String = Database.getPatientItem(6)
        Dim workplaceAddress As String = Database.getPatientItem(7)
        Dim workplaceCity As String = Database.getPatientItem(8)
        Dim workplaceState As String = Database.getPatientItem(9)
        Dim workplaceEmployer As String = Database.getPatientItem(10)
        Dim workplaceNumber As String = Database.getPatientItem(11)

        nameBox.Text = patientName
        addressBox.Text = patientAddress
        cityBox.Text = patientCity
        stateBox.Text = patientState
        numberBox.Text = patientNumber
        ssnBox.Text = patientSSN
        companyNameBox.Text = workplaceCompany
        companyStreetBox.Text = workplaceAddress
        companyCityBox.Text = workplaceCity
        companyStateBox.Text = workplaceState
        companyEmployerBox.Text = workplaceEmployer
        companyNumberBox.Text = workplaceNumber



    End Sub

End Class
