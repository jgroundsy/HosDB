<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
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
        Me.components = New System.ComponentModel.Container()
        Me.patientList = New System.Windows.Forms.ListBox()
        Me.newPatientButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.nameInfo = New System.Windows.Forms.Label()
        Me.addressInfo = New System.Windows.Forms.Label()
        Me.ssLabel = New System.Windows.Forms.Label()
        Me.aaaaaaaaa = New System.Windows.Forms.Label()
        Me.wpAddressLabel = New System.Windows.Forms.Label()
        Me.wpCompanyInfo = New System.Windows.Forms.Label()
        Me.wpCompanyLabel = New System.Windows.Forms.Label()
        Me.wpAddressInfo = New System.Windows.Forms.Label()
        Me.wpEmployerLabel = New System.Windows.Forms.Label()
        Me.wpEmployerInfo = New System.Windows.Forms.Label()
        Me.ssnInfo = New System.Windows.Forms.Label()
        Me.AFKTimer = New System.Windows.Forms.Timer(Me.components)
        Me.editPatientButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numberInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wpNumberInfo = New System.Windows.Forms.Label()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.deletePatientButton = New System.Windows.Forms.Button()
        Me.changePasswordButton = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.basicInfoTab = New System.Windows.Forms.TabPage()
        Me.moreInfoTab = New System.Windows.Forms.TabPage()
        Me.groupNameLabel = New System.Windows.Forms.Label()
        Me.gNumberLabel = New System.Windows.Forms.Label()
        Me.pNumberLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sexLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.weightLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dobLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.notesTab = New System.Windows.Forms.TabPage()
        Me.saveNotesButton = New System.Windows.Forms.Button()
        Me.NotesBox = New System.Windows.Forms.RichTextBox()
        Me.billingTab = New System.Windows.Forms.TabPage()
        Me.statementBox = New System.Windows.Forms.PictureBox()
        Me.printButton = New System.Windows.Forms.Button()
        Me.PrintStatement = New System.Drawing.Printing.PrintDocument()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl.SuspendLayout()
        Me.basicInfoTab.SuspendLayout()
        Me.moreInfoTab.SuspendLayout()
        Me.notesTab.SuspendLayout()
        Me.billingTab.SuspendLayout()
        CType(Me.statementBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientList
        '
        Me.patientList.FormattingEnabled = True
        Me.patientList.Location = New System.Drawing.Point(12, 13)
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(354, 394)
        Me.patientList.TabIndex = 1
        '
        'newPatientButton
        '
        Me.newPatientButton.Location = New System.Drawing.Point(61, 415)
        Me.newPatientButton.Name = "newPatientButton"
        Me.newPatientButton.Size = New System.Drawing.Size(75, 23)
        Me.newPatientButton.TabIndex = 2
        Me.newPatientButton.Text = "New Patient"
        Me.newPatientButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(13, 11)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(76, 20)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Patient: "
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(13, 40)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(80, 20)
        Me.addressLabel.TabIndex = 4
        Me.addressLabel.Text = "Address:"
        '
        'nameInfo
        '
        Me.nameInfo.AutoSize = True
        Me.nameInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInfo.Location = New System.Drawing.Point(95, 14)
        Me.nameInfo.Name = "nameInfo"
        Me.nameInfo.Size = New System.Drawing.Size(116, 16)
        Me.nameInfo.TabIndex = 5
        Me.nameInfo.Text = "---------------------------"
        '
        'addressInfo
        '
        Me.addressInfo.AutoSize = True
        Me.addressInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInfo.Location = New System.Drawing.Point(99, 44)
        Me.addressInfo.Name = "addressInfo"
        Me.addressInfo.Size = New System.Drawing.Size(136, 16)
        Me.addressInfo.TabIndex = 6
        Me.addressInfo.Text = "--------------------------------"
        '
        'ssLabel
        '
        Me.ssLabel.AutoSize = True
        Me.ssLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssLabel.Location = New System.Drawing.Point(13, 100)
        Me.ssLabel.Name = "ssLabel"
        Me.ssLabel.Size = New System.Drawing.Size(50, 20)
        Me.ssLabel.TabIndex = 7
        Me.ssLabel.Text = "SSN:"
        '
        'aaaaaaaaa
        '
        Me.aaaaaaaaa.AutoSize = True
        Me.aaaaaaaaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aaaaaaaaa.Location = New System.Drawing.Point(13, 192)
        Me.aaaaaaaaa.Name = "aaaaaaaaa"
        Me.aaaaaaaaa.Size = New System.Drawing.Size(98, 20)
        Me.aaaaaaaaa.TabIndex = 8
        Me.aaaaaaaaa.Text = "Workplace:"
        '
        'wpAddressLabel
        '
        Me.wpAddressLabel.AutoSize = True
        Me.wpAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpAddressLabel.Location = New System.Drawing.Point(21, 254)
        Me.wpAddressLabel.Name = "wpAddressLabel"
        Me.wpAddressLabel.Size = New System.Drawing.Size(80, 20)
        Me.wpAddressLabel.TabIndex = 9
        Me.wpAddressLabel.Text = "Address:"
        '
        'wpCompanyInfo
        '
        Me.wpCompanyInfo.AutoSize = True
        Me.wpCompanyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpCompanyInfo.Location = New System.Drawing.Point(107, 228)
        Me.wpCompanyInfo.Name = "wpCompanyInfo"
        Me.wpCompanyInfo.Size = New System.Drawing.Size(136, 16)
        Me.wpCompanyInfo.TabIndex = 10
        Me.wpCompanyInfo.Text = "--------------------------------"
        '
        'wpCompanyLabel
        '
        Me.wpCompanyLabel.AutoSize = True
        Me.wpCompanyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpCompanyLabel.Location = New System.Drawing.Point(13, 225)
        Me.wpCompanyLabel.Name = "wpCompanyLabel"
        Me.wpCompanyLabel.Size = New System.Drawing.Size(88, 20)
        Me.wpCompanyLabel.TabIndex = 11
        Me.wpCompanyLabel.Text = "Company:"
        '
        'wpAddressInfo
        '
        Me.wpAddressInfo.AutoSize = True
        Me.wpAddressInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpAddressInfo.Location = New System.Drawing.Point(107, 257)
        Me.wpAddressInfo.Name = "wpAddressInfo"
        Me.wpAddressInfo.Size = New System.Drawing.Size(136, 16)
        Me.wpAddressInfo.TabIndex = 12
        Me.wpAddressInfo.Text = "--------------------------------"
        '
        'wpEmployerLabel
        '
        Me.wpEmployerLabel.AutoSize = True
        Me.wpEmployerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpEmployerLabel.Location = New System.Drawing.Point(13, 283)
        Me.wpEmployerLabel.Name = "wpEmployerLabel"
        Me.wpEmployerLabel.Size = New System.Drawing.Size(88, 20)
        Me.wpEmployerLabel.TabIndex = 13
        Me.wpEmployerLabel.Text = "Employer:"
        '
        'wpEmployerInfo
        '
        Me.wpEmployerInfo.AutoSize = True
        Me.wpEmployerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpEmployerInfo.Location = New System.Drawing.Point(107, 287)
        Me.wpEmployerInfo.Name = "wpEmployerInfo"
        Me.wpEmployerInfo.Size = New System.Drawing.Size(136, 16)
        Me.wpEmployerInfo.TabIndex = 14
        Me.wpEmployerInfo.Text = "--------------------------------"
        '
        'ssnInfo
        '
        Me.ssnInfo.AutoSize = True
        Me.ssnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssnInfo.Location = New System.Drawing.Point(69, 103)
        Me.ssnInfo.Name = "ssnInfo"
        Me.ssnInfo.Size = New System.Drawing.Size(136, 16)
        Me.ssnInfo.TabIndex = 15
        Me.ssnInfo.Text = "--------------------------------"
        '
        'AFKTimer
        '
        Me.AFKTimer.Enabled = True
        Me.AFKTimer.Interval = 1000
        '
        'editPatientButton
        '
        Me.editPatientButton.Location = New System.Drawing.Point(142, 415)
        Me.editPatientButton.Name = "editPatientButton"
        Me.editPatientButton.Size = New System.Drawing.Size(75, 23)
        Me.editPatientButton.TabIndex = 17
        Me.editPatientButton.Text = "Edit Patient"
        Me.editPatientButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Phone Number:"
        '
        'numberInfo
        '
        Me.numberInfo.AutoSize = True
        Me.numberInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberInfo.Location = New System.Drawing.Point(151, 73)
        Me.numberInfo.Name = "numberInfo"
        Me.numberInfo.Size = New System.Drawing.Size(136, 16)
        Me.numberInfo.TabIndex = 19
        Me.numberInfo.Text = "--------------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Phone Number:"
        '
        'wpNumberInfo
        '
        Me.wpNumberInfo.AutoSize = True
        Me.wpNumberInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wpNumberInfo.Location = New System.Drawing.Point(151, 317)
        Me.wpNumberInfo.Name = "wpNumberInfo"
        Me.wpNumberInfo.Size = New System.Drawing.Size(136, 16)
        Me.wpNumberInfo.TabIndex = 21
        Me.wpNumberInfo.Text = "--------------------------------"
        '
        'logoutButton
        '
        Me.logoutButton.Location = New System.Drawing.Point(605, 415)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(75, 23)
        Me.logoutButton.TabIndex = 22
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'deletePatientButton
        '
        Me.deletePatientButton.Location = New System.Drawing.Point(223, 415)
        Me.deletePatientButton.Name = "deletePatientButton"
        Me.deletePatientButton.Size = New System.Drawing.Size(88, 23)
        Me.deletePatientButton.TabIndex = 25
        Me.deletePatientButton.Text = "Delete Patient"
        Me.deletePatientButton.UseVisualStyleBackColor = True
        '
        'changePasswordButton
        '
        Me.changePasswordButton.Location = New System.Drawing.Point(686, 415)
        Me.changePasswordButton.Name = "changePasswordButton"
        Me.changePasswordButton.Size = New System.Drawing.Size(102, 23)
        Me.changePasswordButton.TabIndex = 26
        Me.changePasswordButton.Text = "Change Password"
        Me.changePasswordButton.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.basicInfoTab)
        Me.tabControl.Controls.Add(Me.moreInfoTab)
        Me.tabControl.Controls.Add(Me.notesTab)
        Me.tabControl.Controls.Add(Me.billingTab)
        Me.tabControl.Location = New System.Drawing.Point(372, 13)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(416, 396)
        Me.tabControl.TabIndex = 27
        '
        'basicInfoTab
        '
        Me.basicInfoTab.Controls.Add(Me.nameLabel)
        Me.basicInfoTab.Controls.Add(Me.addressLabel)
        Me.basicInfoTab.Controls.Add(Me.nameInfo)
        Me.basicInfoTab.Controls.Add(Me.addressInfo)
        Me.basicInfoTab.Controls.Add(Me.ssLabel)
        Me.basicInfoTab.Controls.Add(Me.aaaaaaaaa)
        Me.basicInfoTab.Controls.Add(Me.wpNumberInfo)
        Me.basicInfoTab.Controls.Add(Me.wpAddressLabel)
        Me.basicInfoTab.Controls.Add(Me.Label2)
        Me.basicInfoTab.Controls.Add(Me.wpCompanyInfo)
        Me.basicInfoTab.Controls.Add(Me.numberInfo)
        Me.basicInfoTab.Controls.Add(Me.wpCompanyLabel)
        Me.basicInfoTab.Controls.Add(Me.Label1)
        Me.basicInfoTab.Controls.Add(Me.wpAddressInfo)
        Me.basicInfoTab.Controls.Add(Me.wpEmployerLabel)
        Me.basicInfoTab.Controls.Add(Me.wpEmployerInfo)
        Me.basicInfoTab.Controls.Add(Me.ssnInfo)
        Me.basicInfoTab.Location = New System.Drawing.Point(4, 22)
        Me.basicInfoTab.Name = "basicInfoTab"
        Me.basicInfoTab.Size = New System.Drawing.Size(408, 370)
        Me.basicInfoTab.TabIndex = 0
        Me.basicInfoTab.Text = "Basic Info"
        Me.basicInfoTab.UseVisualStyleBackColor = True
        '
        'moreInfoTab
        '
        Me.moreInfoTab.Controls.Add(Me.groupNameLabel)
        Me.moreInfoTab.Controls.Add(Me.gNumberLabel)
        Me.moreInfoTab.Controls.Add(Me.pNumberLabel)
        Me.moreInfoTab.Controls.Add(Me.Label13)
        Me.moreInfoTab.Controls.Add(Me.Label12)
        Me.moreInfoTab.Controls.Add(Me.Label11)
        Me.moreInfoTab.Controls.Add(Me.dateLabel)
        Me.moreInfoTab.Controls.Add(Me.Label10)
        Me.moreInfoTab.Controls.Add(Me.Label9)
        Me.moreInfoTab.Controls.Add(Me.ageLabel)
        Me.moreInfoTab.Controls.Add(Me.Label8)
        Me.moreInfoTab.Controls.Add(Me.sexLabel)
        Me.moreInfoTab.Controls.Add(Me.Label7)
        Me.moreInfoTab.Controls.Add(Me.weightLabel)
        Me.moreInfoTab.Controls.Add(Me.Label6)
        Me.moreInfoTab.Controls.Add(Me.Label5)
        Me.moreInfoTab.Controls.Add(Me.Label3)
        Me.moreInfoTab.Controls.Add(Me.Label4)
        Me.moreInfoTab.Controls.Add(Me.dobLabel)
        Me.moreInfoTab.Controls.Add(Me.heightLabel)
        Me.moreInfoTab.Location = New System.Drawing.Point(4, 22)
        Me.moreInfoTab.Name = "moreInfoTab"
        Me.moreInfoTab.Size = New System.Drawing.Size(408, 370)
        Me.moreInfoTab.TabIndex = 1
        Me.moreInfoTab.Text = "More Info"
        Me.moreInfoTab.UseVisualStyleBackColor = True
        '
        'groupNameLabel
        '
        Me.groupNameLabel.AutoSize = True
        Me.groupNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupNameLabel.Location = New System.Drawing.Point(139, 259)
        Me.groupNameLabel.Name = "groupNameLabel"
        Me.groupNameLabel.Size = New System.Drawing.Size(116, 16)
        Me.groupNameLabel.TabIndex = 26
        Me.groupNameLabel.Text = "---------------------------"
        '
        'gNumberLabel
        '
        Me.gNumberLabel.AutoSize = True
        Me.gNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gNumberLabel.Location = New System.Drawing.Point(144, 230)
        Me.gNumberLabel.Name = "gNumberLabel"
        Me.gNumberLabel.Size = New System.Drawing.Size(116, 16)
        Me.gNumberLabel.TabIndex = 25
        Me.gNumberLabel.Text = "---------------------------"
        '
        'pNumberLabel
        '
        Me.pNumberLabel.AutoSize = True
        Me.pNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pNumberLabel.Location = New System.Drawing.Point(144, 201)
        Me.pNumberLabel.Name = "pNumberLabel"
        Me.pNumberLabel.Size = New System.Drawing.Size(116, 16)
        Me.pNumberLabel.TabIndex = 24
        Me.pNumberLabel.Text = "---------------------------"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Group Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Group Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Policy Number:"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(154, 104)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(48, 16)
        Me.dateLabel.TabIndex = 20
        Me.dateLabel.Text = "--/--/----"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Date Admitted:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Insurance:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.Location = New System.Drawing.Point(266, 46)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(24, 16)
        Me.ageLabel.TabIndex = 17
        Me.ageLabel.Text = "----"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(214, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Age:"
        '
        'sexLabel
        '
        Me.sexLabel.AutoSize = True
        Me.sexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexLabel.Location = New System.Drawing.Point(299, 74)
        Me.sexLabel.Name = "sexLabel"
        Me.sexLabel.Size = New System.Drawing.Size(28, 16)
        Me.sexLabel.TabIndex = 15
        Me.sexLabel.Text = "-----"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sex:"
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightLabel.Location = New System.Drawing.Point(215, 74)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(28, 16)
        Me.weightLabel.TabIndex = 13
        Me.weightLabel.Text = "-----"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Weight:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Patient: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DOB:"
        '
        'dobLabel
        '
        Me.dobLabel.AutoSize = True
        Me.dobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dobLabel.Location = New System.Drawing.Point(76, 46)
        Me.dobLabel.Name = "dobLabel"
        Me.dobLabel.Size = New System.Drawing.Size(116, 16)
        Me.dobLabel.TabIndex = 9
        Me.dobLabel.Text = "---------------------------"
        '
        'heightLabel
        '
        Me.heightLabel.AutoSize = True
        Me.heightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightLabel.Location = New System.Drawing.Point(91, 74)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(28, 16)
        Me.heightLabel.TabIndex = 10
        Me.heightLabel.Text = "-----"
        '
        'notesTab
        '
        Me.notesTab.Controls.Add(Me.saveNotesButton)
        Me.notesTab.Controls.Add(Me.NotesBox)
        Me.notesTab.Location = New System.Drawing.Point(4, 22)
        Me.notesTab.Name = "notesTab"
        Me.notesTab.Size = New System.Drawing.Size(408, 370)
        Me.notesTab.TabIndex = 2
        Me.notesTab.Text = "Notes"
        Me.notesTab.UseVisualStyleBackColor = True
        '
        'saveNotesButton
        '
        Me.saveNotesButton.Location = New System.Drawing.Point(177, 321)
        Me.saveNotesButton.Name = "saveNotesButton"
        Me.saveNotesButton.Size = New System.Drawing.Size(75, 23)
        Me.saveNotesButton.TabIndex = 28
        Me.saveNotesButton.Text = "Save"
        Me.saveNotesButton.UseVisualStyleBackColor = True
        '
        'NotesBox
        '
        Me.NotesBox.Location = New System.Drawing.Point(3, 3)
        Me.NotesBox.Name = "NotesBox"
        Me.NotesBox.Size = New System.Drawing.Size(402, 312)
        Me.NotesBox.TabIndex = 0
        Me.NotesBox.Text = ""
        '
        'billingTab
        '
        Me.billingTab.Controls.Add(Me.uploadButton)
        Me.billingTab.Controls.Add(Me.printButton)
        Me.billingTab.Controls.Add(Me.statementBox)
        Me.billingTab.Location = New System.Drawing.Point(4, 22)
        Me.billingTab.Name = "billingTab"
        Me.billingTab.Size = New System.Drawing.Size(408, 370)
        Me.billingTab.TabIndex = 3
        Me.billingTab.Text = "Billing & Statements"
        Me.billingTab.UseVisualStyleBackColor = True
        '
        'statementBox
        '
        Me.statementBox.Location = New System.Drawing.Point(84, 0)
        Me.statementBox.Name = "statementBox"
        Me.statementBox.Size = New System.Drawing.Size(261, 364)
        Me.statementBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.statementBox.TabIndex = 0
        Me.statementBox.TabStop = False
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(3, 341)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 28
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'PrintStatement
        '
        '
        'uploadButton
        '
        Me.uploadButton.Location = New System.Drawing.Point(3, 312)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(75, 23)
        Me.uploadButton.TabIndex = 29
        Me.uploadButton.Text = "Upload"
        Me.uploadButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.changePasswordButton)
        Me.Controls.Add(Me.deletePatientButton)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.editPatientButton)
        Me.Controls.Add(Me.newPatientButton)
        Me.Controls.Add(Me.patientList)
        Me.Name = "Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HosDB"
        Me.tabControl.ResumeLayout(False)
        Me.basicInfoTab.ResumeLayout(False)
        Me.basicInfoTab.PerformLayout()
        Me.moreInfoTab.ResumeLayout(False)
        Me.moreInfoTab.PerformLayout()
        Me.notesTab.ResumeLayout(False)
        Me.billingTab.ResumeLayout(False)
        CType(Me.statementBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientList As ListBox
    Friend WithEvents newPatientButton As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents nameInfo As Label
    Friend WithEvents addressInfo As Label
    Friend WithEvents ssLabel As Label
    Friend WithEvents aaaaaaaaa As Label
    Friend WithEvents wpAddressLabel As Label
    Friend WithEvents wpCompanyInfo As Label
    Friend WithEvents wpCompanyLabel As Label
    Friend WithEvents wpAddressInfo As Label
    Friend WithEvents wpEmployerLabel As Label
    Friend WithEvents wpEmployerInfo As Label
    Friend WithEvents ssnInfo As Label
    Friend WithEvents AFKTimer As Timer
    Friend WithEvents editPatientButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents numberInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents wpNumberInfo As Label
    Friend WithEvents logoutButton As Button
    Friend WithEvents deletePatientButton As Button
    Friend WithEvents changePasswordButton As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents basicInfoTab As TabPage
    Friend WithEvents moreInfoTab As TabPage
    Friend WithEvents notesTab As TabPage
    Friend WithEvents billingTab As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dobLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents groupNameLabel As Label
    Friend WithEvents gNumberLabel As Label
    Friend WithEvents pNumberLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sexLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents weightLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents saveNotesButton As Button
    Friend WithEvents NotesBox As RichTextBox
    Friend WithEvents statementBox As PictureBox
    Friend WithEvents printButton As Button
    Friend WithEvents PrintStatement As Printing.PrintDocument
    Friend WithEvents uploadButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
