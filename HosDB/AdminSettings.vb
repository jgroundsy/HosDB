Public Class AdminSettings
    Dim test
    Private Sub AdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChangelogButton_Click(sender As Object, e As EventArgs) Handles ChangelogButton.Click
        Me.Hide()
        viewChangelog.Show()
    End Sub

    Private Sub newEmployeeButton_Click(sender As Object, e As EventArgs) Handles newEmployeeButton.Click
        newEmployee.ShowDialog()

    End Sub

    Private Sub deleteEmployeeButton_Click(sender As Object, e As EventArgs) Handles deleteEmployeeButton.Click
        deleteEmployee.ShowDialog()

    End Sub
End Class