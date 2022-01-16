Imports System.Windows.Forms

Public Class newPatient

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim patientFolderName As String = (firstNameBox.Text.ToString + " " + middleNameBox.Text.ToString + " " + lastNameBox.Text.ToString).ToString
        Database.CreateFile(("N/A"), Database.filePath & "\" & patientFolderName & "\", "moreInfo.txt")
        Database.CreateFile((firstNameBox.Text.ToString + " " + middleNameBox.Text.ToString + " " + lastNameBox.Text.ToString + ","), Database.filePath & "\" & patientFolderName & "\", "basicInfo.txt")
        Database.CreateFile(("N/A"), Database.filePath & "\" & patientFolderName & "\", "notes.txt")

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
