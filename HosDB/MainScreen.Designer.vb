<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.loginButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.userBox = New System.Windows.Forms.TextBox()
        Me.passBox = New System.Windows.Forms.TextBox()
        Me.mainLabel = New System.Windows.Forms.Label()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.loginTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(358, 254)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 0
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(265, 158)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(87, 20)
        Me.userLabel.TabIndex = 1
        Me.userLabel.Text = "Username:"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(265, 195)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(82, 20)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password:"
        '
        'userBox
        '
        Me.userBox.Location = New System.Drawing.Point(358, 158)
        Me.userBox.Name = "userBox"
        Me.userBox.Size = New System.Drawing.Size(162, 20)
        Me.userBox.TabIndex = 3
        '
        'passBox
        '
        Me.passBox.Location = New System.Drawing.Point(358, 195)
        Me.passBox.Name = "passBox"
        Me.passBox.Size = New System.Drawing.Size(162, 20)
        Me.passBox.TabIndex = 4
        Me.passBox.UseSystemPasswordChar = True
        '
        'mainLabel
        '
        Me.mainLabel.AutoSize = True
        Me.mainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainLabel.Location = New System.Drawing.Point(353, 111)
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(84, 25)
        Me.mainLabel.TabIndex = 5
        Me.mainLabel.Text = "HosDB"
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(307, 227)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(0, 20)
        Me.msgLabel.TabIndex = 6
        Me.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginTimer
        '
        Me.loginTimer.Interval = 1000
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.mainLabel)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.loginButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HosDB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginButton As Button
    Friend WithEvents userLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents userBox As TextBox
    Friend WithEvents passBox As TextBox
    Friend WithEvents mainLabel As Label
    Friend WithEvents msgLabel As Label
    Friend WithEvents loginTimer As Timer
End Class
