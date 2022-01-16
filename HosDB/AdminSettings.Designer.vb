<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSettings
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
        Me.newEmployeeButton = New System.Windows.Forms.Button()
        Me.ChangelogButton = New System.Windows.Forms.Button()
        Me.deleteEmployeeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'newEmployeeButton
        '
        Me.newEmployeeButton.Location = New System.Drawing.Point(319, 155)
        Me.newEmployeeButton.Name = "newEmployeeButton"
        Me.newEmployeeButton.Size = New System.Drawing.Size(158, 23)
        Me.newEmployeeButton.TabIndex = 0
        Me.newEmployeeButton.Text = "New Employee"
        Me.newEmployeeButton.UseVisualStyleBackColor = True
        '
        'ChangelogButton
        '
        Me.ChangelogButton.Location = New System.Drawing.Point(319, 236)
        Me.ChangelogButton.Name = "ChangelogButton"
        Me.ChangelogButton.Size = New System.Drawing.Size(158, 23)
        Me.ChangelogButton.TabIndex = 1
        Me.ChangelogButton.Text = "View Changelog"
        Me.ChangelogButton.UseVisualStyleBackColor = True
        '
        'deleteEmployeeButton
        '
        Me.deleteEmployeeButton.Location = New System.Drawing.Point(319, 184)
        Me.deleteEmployeeButton.Name = "deleteEmployeeButton"
        Me.deleteEmployeeButton.Size = New System.Drawing.Size(158, 23)
        Me.deleteEmployeeButton.TabIndex = 3
        Me.deleteEmployeeButton.Text = "Delete Employee"
        Me.deleteEmployeeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Administrator Settings:"
        '
        'AdminSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deleteEmployeeButton)
        Me.Controls.Add(Me.ChangelogButton)
        Me.Controls.Add(Me.newEmployeeButton)
        Me.Name = "AdminSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newEmployeeButton As Button
    Friend WithEvents ChangelogButton As Button
    Friend WithEvents deleteEmployeeButton As Button
    Friend WithEvents Label1 As Label
End Class
