Imports System.Windows.Forms

Public Class ActivityMonitor

    Dim seconds As Integer = 5

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ActivityMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles labelCount.Tick
        If seconds <= 0 Then
            Database.logOut()
        End If

        activityLabel.Text = ("Are you there? Logging out in " + seconds.ToString + " seconds.")
        seconds = seconds - 1


    End Sub
End Class
