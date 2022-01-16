Imports System.IO
Public Class viewChangelog
    Dim changelogList() As String = Directory.GetFiles(Environ("USERPROFILE") + "\Documents\HosDB\admin\Changelogs")

    Private Sub viewChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each file As String In changelogList
            fileSelector.Items.Add(Path.GetFileName(file).Substring(0, Path.GetFileName(file).IndexOf(".txt")))
        Next
    End Sub
    Private Sub fileSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fileSelector.SelectedIndexChanged
        Dim selectedLog As String = fileSelector.FocusedItem.Text
        Dim objReader As New System.IO.StreamReader(Environ("USERPROFILE") + "\Documents\HosDB\admin\Changelogs\" + selectedLog + ".txt")
        changelogText.Text = objReader.ReadToEnd
    End Sub


End Class