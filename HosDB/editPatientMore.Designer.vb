<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPatientMore
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dobBox = New System.Windows.Forms.TextBox()
        Me.ageBox = New System.Windows.Forms.TextBox()
        Me.heightBox = New System.Windows.Forms.TextBox()
        Me.weightBox = New System.Windows.Forms.TextBox()
        Me.sexBox = New System.Windows.Forms.TextBox()
        Me.dateBox = New System.Windows.Forms.TextBox()
        Me.pnumberBox = New System.Windows.Forms.TextBox()
        Me.gNumberBox = New System.Windows.Forms.TextBox()
        Me.groupNameBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(401, 289)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Group Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 20)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Group Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Policy Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Date Admitted:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Insurance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(257, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Weight:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Patient: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "DOB:"
        '
        'dobBox
        '
        Me.dobBox.Location = New System.Drawing.Point(84, 51)
        Me.dobBox.Name = "dobBox"
        Me.dobBox.Size = New System.Drawing.Size(100, 20)
        Me.dobBox.TabIndex = 35
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(254, 51)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(35, 20)
        Me.ageBox.TabIndex = 36
        '
        'heightBox
        '
        Me.heightBox.Location = New System.Drawing.Point(99, 79)
        Me.heightBox.Name = "heightBox"
        Me.heightBox.Size = New System.Drawing.Size(35, 20)
        Me.heightBox.TabIndex = 37
        '
        'weightBox
        '
        Me.weightBox.Location = New System.Drawing.Point(213, 81)
        Me.weightBox.Name = "weightBox"
        Me.weightBox.Size = New System.Drawing.Size(35, 20)
        Me.weightBox.TabIndex = 38
        '
        'sexBox
        '
        Me.sexBox.Location = New System.Drawing.Point(307, 79)
        Me.sexBox.Name = "sexBox"
        Me.sexBox.Size = New System.Drawing.Size(35, 20)
        Me.sexBox.TabIndex = 39
        '
        'dateBox
        '
        Me.dateBox.Location = New System.Drawing.Point(162, 110)
        Me.dateBox.Name = "dateBox"
        Me.dateBox.Size = New System.Drawing.Size(75, 20)
        Me.dateBox.TabIndex = 40
        '
        'pnumberBox
        '
        Me.pnumberBox.Location = New System.Drawing.Point(159, 207)
        Me.pnumberBox.Name = "pnumberBox"
        Me.pnumberBox.Size = New System.Drawing.Size(163, 20)
        Me.pnumberBox.TabIndex = 41
        '
        'gNumberBox
        '
        Me.gNumberBox.Location = New System.Drawing.Point(159, 236)
        Me.gNumberBox.Name = "gNumberBox"
        Me.gNumberBox.Size = New System.Drawing.Size(163, 20)
        Me.gNumberBox.TabIndex = 42
        '
        'groupNameBox
        '
        Me.groupNameBox.Location = New System.Drawing.Point(147, 265)
        Me.groupNameBox.Name = "groupNameBox"
        Me.groupNameBox.Size = New System.Drawing.Size(163, 20)
        Me.groupNameBox.TabIndex = 43
        '
        'editPatientMore
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(559, 330)
        Me.Controls.Add(Me.groupNameBox)
        Me.Controls.Add(Me.gNumberBox)
        Me.Controls.Add(Me.pnumberBox)
        Me.Controls.Add(Me.dateBox)
        Me.Controls.Add(Me.sexBox)
        Me.Controls.Add(Me.weightBox)
        Me.Controls.Add(Me.heightBox)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.dobBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editPatientMore"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Patient More"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dobBox As TextBox
    Friend WithEvents ageBox As TextBox
    Friend WithEvents heightBox As TextBox
    Friend WithEvents weightBox As TextBox
    Friend WithEvents sexBox As TextBox
    Friend WithEvents dateBox As TextBox
    Friend WithEvents pnumberBox As TextBox
    Friend WithEvents gNumberBox As TextBox
    Friend WithEvents groupNameBox As TextBox
End Class
