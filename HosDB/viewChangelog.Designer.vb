<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewChangelog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fileSelector = New System.Windows.Forms.ListView()
        Me.changelogText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'fileSelector
        '
        Me.fileSelector.LabelWrap = False
        Me.fileSelector.Location = New System.Drawing.Point(12, 35)
        Me.fileSelector.Name = "fileSelector"
        Me.fileSelector.Size = New System.Drawing.Size(392, 403)
        Me.fileSelector.TabIndex = 0
        Me.fileSelector.UseCompatibleStateImageBehavior = False
        '
        'changelogText
        '
        Me.changelogText.Location = New System.Drawing.Point(410, 35)
        Me.changelogText.Name = "changelogText"
        Me.changelogText.ReadOnly = True
        Me.changelogText.Size = New System.Drawing.Size(378, 403)
        Me.changelogText.TabIndex = 1
        Me.changelogText.Text = ""
        '
        'viewChangelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.changelogText)
        Me.Controls.Add(Me.fileSelector)
        Me.Name = "viewChangelog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changelog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fileSelector As ListView
    Friend WithEvents changelogText As RichTextBox
End Class
