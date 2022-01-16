<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPatient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cityBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stateBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.companyNameBox = New System.Windows.Forms.TextBox()
        Me.LabelNew = New System.Windows.Forms.Label()
        Me.companyStreetBox = New System.Windows.Forms.TextBox()
        Me.companyCityBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.companyStateBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.companyEmployerBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ssnBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numberBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.companyNumberBox = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(473, 328)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Name (First, Middle, Last):"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(259, 23)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(304, 20)
        Me.nameBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Street Address:"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(134, 53)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(144, 20)
        Me.addressBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "City:"
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(324, 54)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(130, 20)
        Me.cityBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(462, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "State:"
        '
        'stateBox
        '
        Me.stateBox.Location = New System.Drawing.Point(516, 54)
        Me.stateBox.Name = "stateBox"
        Me.stateBox.Size = New System.Drawing.Size(55, 20)
        Me.stateBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Workplace Name:"
        '
        'companyNameBox
        '
        Me.companyNameBox.Location = New System.Drawing.Point(150, 189)
        Me.companyNameBox.Name = "companyNameBox"
        Me.companyNameBox.Size = New System.Drawing.Size(144, 20)
        Me.companyNameBox.TabIndex = 13
        '
        'LabelNew
        '
        Me.LabelNew.AutoSize = True
        Me.LabelNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNew.Location = New System.Drawing.Point(12, 222)
        Me.LabelNew.Name = "LabelNew"
        Me.LabelNew.Size = New System.Drawing.Size(194, 16)
        Me.LabelNew.TabIndex = 14
        Me.LabelNew.Text = "Workplace Street Address:"
        '
        'companyStreetBox
        '
        Me.companyStreetBox.Location = New System.Drawing.Point(212, 221)
        Me.companyStreetBox.Name = "companyStreetBox"
        Me.companyStreetBox.Size = New System.Drawing.Size(144, 20)
        Me.companyStreetBox.TabIndex = 15
        '
        'companyCityBox
        '
        Me.companyCityBox.Location = New System.Drawing.Point(404, 221)
        Me.companyCityBox.Name = "companyCityBox"
        Me.companyCityBox.Size = New System.Drawing.Size(105, 20)
        Me.companyCityBox.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "City:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(515, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "State:"
        '
        'companyStateBox
        '
        Me.companyStateBox.Location = New System.Drawing.Point(564, 221)
        Me.companyStateBox.Name = "companyStateBox"
        Me.companyStateBox.Size = New System.Drawing.Size(55, 20)
        Me.companyStateBox.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Workplace Employer:"
        '
        'companyEmployerBox
        '
        Me.companyEmployerBox.Location = New System.Drawing.Point(173, 253)
        Me.companyEmployerBox.Name = "companyEmployerBox"
        Me.companyEmployerBox.Size = New System.Drawing.Size(144, 20)
        Me.companyEmployerBox.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "SSN:"
        '
        'ssnBox
        '
        Me.ssnBox.Location = New System.Drawing.Point(63, 111)
        Me.ssnBox.Name = "ssnBox"
        Me.ssnBox.Size = New System.Drawing.Size(144, 20)
        Me.ssnBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Phone Number:"
        '
        'numberBox
        '
        Me.numberBox.Location = New System.Drawing.Point(133, 85)
        Me.numberBox.Name = "numberBox"
        Me.numberBox.Size = New System.Drawing.Size(144, 20)
        Me.numberBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Workplace Phone Number:"
        '
        'companyNumberBox
        '
        Me.companyNumberBox.Location = New System.Drawing.Point(212, 285)
        Me.companyNumberBox.Name = "companyNumberBox"
        Me.companyNumberBox.Size = New System.Drawing.Size(144, 20)
        Me.companyNumberBox.TabIndex = 23
        '
        'editPatient
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(631, 369)
        Me.Controls.Add(Me.companyNumberBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numberBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ssnBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.companyEmployerBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.companyStateBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.companyCityBox)
        Me.Controls.Add(Me.companyStreetBox)
        Me.Controls.Add(Me.LabelNew)
        Me.Controls.Add(Me.companyNameBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.stateBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cityBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Patient"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addressBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cityBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stateBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents companyNameBox As TextBox
    Friend WithEvents LabelNew As Label
    Friend WithEvents companyStreetBox As TextBox
    Friend WithEvents companyCityBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents companyStateBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents companyEmployerBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ssnBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numberBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents companyNumberBox As TextBox
End Class
