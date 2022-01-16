Imports System.Windows.Forms

Imports System.IO
Public Class deleteEmployee

    Dim transferEmployee
    Dim currentEmployee

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If currentEmployeesList.SelectedItem IsNot "" And transferEmployeesList.SelectedItem IsNot "" Then
            Dim currentEmployeeDirectory As String = Environ("USERPROFILE") + "\Documents\HosDB\" & currentEmployee & "\Patients\"
            Dim transferEmployeeDirectory As String = Environ("USERPROFILE") + "\Documents\HosDB\" & transferEmployee & "\Patients\"
            For Each file In My.Computer.FileSystem.GetFiles(currentEmployeeDirectory)
                Dim newFile() As String = file.Split("\")
                My.Computer.FileSystem.CopyFile(file.ToString, transferEmployeeDirectory & newFile.GetValue(7))
            Next

            MsgBox(currentEmployee & " was deleted and all patients were transferred to " & transferEmployee)
            Database.CreateFile(vbNewLine + Now.ToLocalTime + ": Deleted employee (" & currentEmployee & ") and transferred their patients to " & transferEmployee, Database.changelogPath, Database.changelogFilename)
            My.Computer.FileSystem.DeleteDirectory(Environ("USERPROFILE") + "\Documents\HosDB\" & currentEmployee, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Else
            MsgBox("Please selected an employee to delete and an employee to transfer their patients to.")
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub currentEmployeesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles currentEmployeesList.SelectedIndexChanged
        currentEmployee = currentEmployeesList.SelectedItem
        transferEmployeesList.Items.Clear()

        For Each folder As String In My.Computer.FileSystem.GetDirectories(Environ("USERPROFILE") + "\Documents\HosDB\")
            transferEmployeesList.Items.Add(Path.GetFileName(folder))
        Next
        transferEmployeesList.Items.Remove(MainScreen.loggedUser)
        transferEmployeesList.Items.Remove(currentEmployee)

    End Sub

    Private Sub transferEmployeesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles transferEmployeesList.SelectedIndexChanged
        transferEmployee = transferEmployeesList.SelectedItem
    End Sub

    Private Sub deleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each folder As String In My.Computer.FileSystem.GetDirectories(Environ("USERPROFILE") + "\Documents\HosDB\")
            currentEmployeesList.Items.Add(Path.GetFileName(folder))
        Next
        currentEmployeesList.Items.Remove(MainScreen.loggedUser)

        For Each folder As String In My.Computer.FileSystem.GetDirectories(Environ("USERPROFILE") + "\Documents\HosDB\")
            transferEmployeesList.Items.Add(Path.GetFileName(folder))
        Next
        transferEmployeesList.Items.Remove(MainScreen.loggedUser)
    End Sub
End Class
