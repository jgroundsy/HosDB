Imports System.Windows.Forms

Public Class editPatientMore

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim newFileText As String = (dobBox.Text + "," + ageBox.Text + "," + weightBox.Text + "," + heightBox.Text + "," + sexBox.Text + "," + dateBox.Text + "," + pnumberBox.Text + "," + gNumberBox.Text + "," + groupNameBox.Text)
        Database.OverwriteFile(newFileText.ToString, Database.filePath & Database.selectedUser & "\", "moreInfo.txt")

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub editPatientMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patientDOB As String = Database.getPatientMore(0)
        Dim patientAge As String = Database.getPatientMore(1)
        Dim patientHeight As String = Database.getPatientMore(2)
        Dim patientWeight As String = Database.getPatientMore(3)
        Dim patientSex As String = Database.getPatientMore(4)
        Dim patientDate As String = Database.getPatientMore(5)
        Dim insurancePNumber As String = Database.getPatientMore(6)
        Dim insuranceGNumber As String = Database.getPatientMore(7)
        Dim insuranceGName As String = Database.getPatientMore(8)


        dobBox.Text = patientDOB
        ageBox.Text = patientAge
        heightBox.Text = patientHeight
        weightBox.Text = patientWeight
        sexBox.Text = patientSex
        dateBox.Text = patientDate
        pnumberBox.Text = insurancePNumber
        gNumberBox.Text = insuranceGNumber
        groupNameBox.Text = insuranceGName


    End Sub
End Class
