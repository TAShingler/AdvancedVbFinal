<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
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
        Me.groupBoxCheckingDetails = New System.Windows.Forms.GroupBox()
        Me.btnCheckingClear = New System.Windows.Forms.Button()
        Me.btnUpdateCheckingRecord = New System.Windows.Forms.Button()
        Me.txtBoxCheckingAccBal = New System.Windows.Forms.TextBox()
        Me.btnDeleteCheckingRecord = New System.Windows.Forms.Button()
        Me.lblCheckingAccBalance = New System.Windows.Forms.Label()
        Me.btnAddCheckingRecord = New System.Windows.Forms.Button()
        Me.txtBoxCheckingLName = New System.Windows.Forms.TextBox()
        Me.lblCheckingLastName = New System.Windows.Forms.Label()
        Me.txtBoxCheckingFName = New System.Windows.Forms.TextBox()
        Me.lblCheckingFirstName = New System.Windows.Forms.Label()
        Me.txtBoxCheckingAccNum = New System.Windows.Forms.TextBox()
        Me.lblCheckingAccNumber = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewSavings = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewChecking = New System.Windows.Forms.DataGridView()
        Me.groupBoxSavingsDetails = New System.Windows.Forms.GroupBox()
        Me.btnSavingsClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateSavingsRecord = New System.Windows.Forms.Button()
        Me.btnDeleteSavingsRecord = New System.Windows.Forms.Button()
        Me.btnAddSavingsRecord = New System.Windows.Forms.Button()
        Me.comboTermLength = New System.Windows.Forms.ComboBox()
        Me.comboAccType = New System.Windows.Forms.ComboBox()
        Me.txtBoxSavingsAccBal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxSavingsLName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxSavingsFName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxSavingsAccNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupBoxCheckingDetails.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewSavings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewChecking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxSavingsDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxCheckingDetails
        '
        Me.groupBoxCheckingDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxCheckingDetails.Controls.Add(Me.btnCheckingClear)
        Me.groupBoxCheckingDetails.Controls.Add(Me.btnUpdateCheckingRecord)
        Me.groupBoxCheckingDetails.Controls.Add(Me.txtBoxCheckingAccBal)
        Me.groupBoxCheckingDetails.Controls.Add(Me.btnDeleteCheckingRecord)
        Me.groupBoxCheckingDetails.Controls.Add(Me.lblCheckingAccBalance)
        Me.groupBoxCheckingDetails.Controls.Add(Me.btnAddCheckingRecord)
        Me.groupBoxCheckingDetails.Controls.Add(Me.txtBoxCheckingLName)
        Me.groupBoxCheckingDetails.Controls.Add(Me.lblCheckingLastName)
        Me.groupBoxCheckingDetails.Controls.Add(Me.txtBoxCheckingFName)
        Me.groupBoxCheckingDetails.Controls.Add(Me.lblCheckingFirstName)
        Me.groupBoxCheckingDetails.Controls.Add(Me.txtBoxCheckingAccNum)
        Me.groupBoxCheckingDetails.Controls.Add(Me.lblCheckingAccNumber)
        Me.groupBoxCheckingDetails.Location = New System.Drawing.Point(12, 3)
        Me.groupBoxCheckingDetails.Name = "groupBoxCheckingDetails"
        Me.groupBoxCheckingDetails.Size = New System.Drawing.Size(476, 274)
        Me.groupBoxCheckingDetails.TabIndex = 1
        Me.groupBoxCheckingDetails.TabStop = False
        Me.groupBoxCheckingDetails.Text = "Checking Account Details"
        '
        'btnCheckingClear
        '
        Me.btnCheckingClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckingClear.Location = New System.Drawing.Point(360, 238)
        Me.btnCheckingClear.Name = "btnCheckingClear"
        Me.btnCheckingClear.Size = New System.Drawing.Size(110, 30)
        Me.btnCheckingClear.TabIndex = 7
        Me.btnCheckingClear.Text = "Clear Fields"
        Me.btnCheckingClear.UseVisualStyleBackColor = True
        '
        'btnUpdateCheckingRecord
        '
        Me.btnUpdateCheckingRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCheckingRecord.Location = New System.Drawing.Point(6, 202)
        Me.btnUpdateCheckingRecord.Name = "btnUpdateCheckingRecord"
        Me.btnUpdateCheckingRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnUpdateCheckingRecord.TabIndex = 5
        Me.btnUpdateCheckingRecord.Text = "Update Record"
        Me.btnUpdateCheckingRecord.UseVisualStyleBackColor = True
        '
        'txtBoxCheckingAccBal
        '
        Me.txtBoxCheckingAccBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCheckingAccBal.Location = New System.Drawing.Point(282, 114)
        Me.txtBoxCheckingAccBal.Name = "txtBoxCheckingAccBal"
        Me.txtBoxCheckingAccBal.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxCheckingAccBal.TabIndex = 3
        '
        'btnDeleteCheckingRecord
        '
        Me.btnDeleteCheckingRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCheckingRecord.Location = New System.Drawing.Point(6, 238)
        Me.btnDeleteCheckingRecord.Name = "btnDeleteCheckingRecord"
        Me.btnDeleteCheckingRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnDeleteCheckingRecord.TabIndex = 6
        Me.btnDeleteCheckingRecord.Text = "Delete Record"
        Me.btnDeleteCheckingRecord.UseVisualStyleBackColor = True
        '
        'lblCheckingAccBalance
        '
        Me.lblCheckingAccBalance.AutoSize = True
        Me.lblCheckingAccBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckingAccBalance.Location = New System.Drawing.Point(164, 117)
        Me.lblCheckingAccBalance.Name = "lblCheckingAccBalance"
        Me.lblCheckingAccBalance.Size = New System.Drawing.Size(112, 16)
        Me.lblCheckingAccBalance.TabIndex = 8
        Me.lblCheckingAccBalance.Text = "Account Balance:"
        '
        'btnAddCheckingRecord
        '
        Me.btnAddCheckingRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCheckingRecord.Location = New System.Drawing.Point(6, 166)
        Me.btnAddCheckingRecord.Name = "btnAddCheckingRecord"
        Me.btnAddCheckingRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnAddCheckingRecord.TabIndex = 4
        Me.btnAddCheckingRecord.Text = "Add Record"
        Me.btnAddCheckingRecord.UseVisualStyleBackColor = True
        '
        'txtBoxCheckingLName
        '
        Me.txtBoxCheckingLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCheckingLName.Location = New System.Drawing.Point(282, 86)
        Me.txtBoxCheckingLName.Name = "txtBoxCheckingLName"
        Me.txtBoxCheckingLName.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxCheckingLName.TabIndex = 2
        '
        'lblCheckingLastName
        '
        Me.lblCheckingLastName.AutoSize = True
        Me.lblCheckingLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckingLastName.Location = New System.Drawing.Point(200, 89)
        Me.lblCheckingLastName.Name = "lblCheckingLastName"
        Me.lblCheckingLastName.Size = New System.Drawing.Size(76, 16)
        Me.lblCheckingLastName.TabIndex = 6
        Me.lblCheckingLastName.Text = "Last Name:"
        '
        'txtBoxCheckingFName
        '
        Me.txtBoxCheckingFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCheckingFName.Location = New System.Drawing.Point(282, 58)
        Me.txtBoxCheckingFName.Name = "txtBoxCheckingFName"
        Me.txtBoxCheckingFName.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxCheckingFName.TabIndex = 1
        '
        'lblCheckingFirstName
        '
        Me.lblCheckingFirstName.AutoSize = True
        Me.lblCheckingFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckingFirstName.Location = New System.Drawing.Point(200, 61)
        Me.lblCheckingFirstName.Name = "lblCheckingFirstName"
        Me.lblCheckingFirstName.Size = New System.Drawing.Size(76, 16)
        Me.lblCheckingFirstName.TabIndex = 4
        Me.lblCheckingFirstName.Text = "First Name:"
        '
        'txtBoxCheckingAccNum
        '
        Me.txtBoxCheckingAccNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCheckingAccNum.Location = New System.Drawing.Point(282, 30)
        Me.txtBoxCheckingAccNum.Name = "txtBoxCheckingAccNum"
        Me.txtBoxCheckingAccNum.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxCheckingAccNum.TabIndex = 0
        '
        'lblCheckingAccNumber
        '
        Me.lblCheckingAccNumber.AutoSize = True
        Me.lblCheckingAccNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckingAccNumber.Location = New System.Drawing.Point(166, 33)
        Me.lblCheckingAccNumber.Name = "lblCheckingAccNumber"
        Me.lblCheckingAccNumber.Size = New System.Drawing.Size(110, 16)
        Me.lblCheckingAccNumber.TabIndex = 1
        Me.lblCheckingAccNumber.Text = "Account Number:"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1084, 24)
        Me.menuStrip.TabIndex = 2
        Me.menuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupBoxSavingsDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupBoxCheckingDetails)
        Me.SplitContainer1.Size = New System.Drawing.Size(1084, 587)
        Me.SplitContainer1.SplitterDistance = 294
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridViewSavings)
        Me.GroupBox4.Location = New System.Drawing.Point(494, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(578, 288)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of Savings Accounts"
        '
        'DataGridViewSavings
        '
        Me.DataGridViewSavings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSavings.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewSavings.Name = "DataGridViewSavings"
        Me.DataGridViewSavings.ReadOnly = True
        Me.DataGridViewSavings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSavings.Size = New System.Drawing.Size(566, 263)
        Me.DataGridViewSavings.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridViewChecking)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 288)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Checking Accounts"
        '
        'DataGridViewChecking
        '
        Me.DataGridViewChecking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewChecking.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewChecking.Name = "DataGridViewChecking"
        Me.DataGridViewChecking.ReadOnly = True
        Me.DataGridViewChecking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewChecking.Size = New System.Drawing.Size(464, 263)
        Me.DataGridViewChecking.TabIndex = 0
        '
        'groupBoxSavingsDetails
        '
        Me.groupBoxSavingsDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxSavingsDetails.Controls.Add(Me.btnSavingsClear)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label6)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label5)
        Me.groupBoxSavingsDetails.Controls.Add(Me.btnUpdateSavingsRecord)
        Me.groupBoxSavingsDetails.Controls.Add(Me.btnDeleteSavingsRecord)
        Me.groupBoxSavingsDetails.Controls.Add(Me.btnAddSavingsRecord)
        Me.groupBoxSavingsDetails.Controls.Add(Me.comboTermLength)
        Me.groupBoxSavingsDetails.Controls.Add(Me.comboAccType)
        Me.groupBoxSavingsDetails.Controls.Add(Me.txtBoxSavingsAccBal)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label1)
        Me.groupBoxSavingsDetails.Controls.Add(Me.txtBoxSavingsLName)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label2)
        Me.groupBoxSavingsDetails.Controls.Add(Me.txtBoxSavingsFName)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label3)
        Me.groupBoxSavingsDetails.Controls.Add(Me.txtBoxSavingsAccNum)
        Me.groupBoxSavingsDetails.Controls.Add(Me.Label4)
        Me.groupBoxSavingsDetails.Location = New System.Drawing.Point(494, 3)
        Me.groupBoxSavingsDetails.Name = "groupBoxSavingsDetails"
        Me.groupBoxSavingsDetails.Size = New System.Drawing.Size(578, 274)
        Me.groupBoxSavingsDetails.TabIndex = 15
        Me.groupBoxSavingsDetails.TabStop = False
        Me.groupBoxSavingsDetails.Text = "Savings Account Details"
        '
        'btnSavingsClear
        '
        Me.btnSavingsClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavingsClear.Location = New System.Drawing.Point(462, 237)
        Me.btnSavingsClear.Name = "btnSavingsClear"
        Me.btnSavingsClear.Size = New System.Drawing.Size(110, 30)
        Me.btnSavingsClear.TabIndex = 17
        Me.btnSavingsClear.Text = "Clear Fields"
        Me.btnSavingsClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Term Length:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Savings Account Type:"
        '
        'btnUpdateSavingsRecord
        '
        Me.btnUpdateSavingsRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSavingsRecord.Location = New System.Drawing.Point(6, 201)
        Me.btnUpdateSavingsRecord.Name = "btnUpdateSavingsRecord"
        Me.btnUpdateSavingsRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnUpdateSavingsRecord.TabIndex = 15
        Me.btnUpdateSavingsRecord.Text = "Update Record"
        Me.btnUpdateSavingsRecord.UseVisualStyleBackColor = True
        '
        'btnDeleteSavingsRecord
        '
        Me.btnDeleteSavingsRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSavingsRecord.Location = New System.Drawing.Point(6, 237)
        Me.btnDeleteSavingsRecord.Name = "btnDeleteSavingsRecord"
        Me.btnDeleteSavingsRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnDeleteSavingsRecord.TabIndex = 16
        Me.btnDeleteSavingsRecord.Text = "Delete Record"
        Me.btnDeleteSavingsRecord.UseVisualStyleBackColor = True
        '
        'btnAddSavingsRecord
        '
        Me.btnAddSavingsRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSavingsRecord.Location = New System.Drawing.Point(6, 165)
        Me.btnAddSavingsRecord.Name = "btnAddSavingsRecord"
        Me.btnAddSavingsRecord.Size = New System.Drawing.Size(110, 30)
        Me.btnAddSavingsRecord.TabIndex = 14
        Me.btnAddSavingsRecord.Text = "Add Record"
        Me.btnAddSavingsRecord.UseVisualStyleBackColor = True
        '
        'comboTermLength
        '
        Me.comboTermLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTermLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTermLength.FormattingEnabled = True
        Me.comboTermLength.Location = New System.Drawing.Point(378, 171)
        Me.comboTermLength.Name = "comboTermLength"
        Me.comboTermLength.Size = New System.Drawing.Size(194, 24)
        Me.comboTermLength.TabIndex = 13
        '
        'comboAccType
        '
        Me.comboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAccType.FormattingEnabled = True
        Me.comboAccType.Location = New System.Drawing.Point(378, 141)
        Me.comboAccType.Name = "comboAccType"
        Me.comboAccType.Size = New System.Drawing.Size(194, 24)
        Me.comboAccType.TabIndex = 12
        '
        'txtBoxSavingsAccBal
        '
        Me.txtBoxSavingsAccBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSavingsAccBal.Location = New System.Drawing.Point(378, 113)
        Me.txtBoxSavingsAccBal.Name = "txtBoxSavingsAccBal"
        Me.txtBoxSavingsAccBal.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxSavingsAccBal.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Account Balance:"
        '
        'txtBoxSavingsLName
        '
        Me.txtBoxSavingsLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSavingsLName.Location = New System.Drawing.Point(378, 85)
        Me.txtBoxSavingsLName.Name = "txtBoxSavingsLName"
        Me.txtBoxSavingsLName.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxSavingsLName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Last Name:"
        '
        'txtBoxSavingsFName
        '
        Me.txtBoxSavingsFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSavingsFName.Location = New System.Drawing.Point(378, 57)
        Me.txtBoxSavingsFName.Name = "txtBoxSavingsFName"
        Me.txtBoxSavingsFName.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxSavingsFName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "First Name:"
        '
        'txtBoxSavingsAccNum
        '
        Me.txtBoxSavingsAccNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSavingsAccNum.Location = New System.Drawing.Point(378, 29)
        Me.txtBoxSavingsAccNum.Name = "txtBoxSavingsAccNum"
        Me.txtBoxSavingsAccNum.Size = New System.Drawing.Size(194, 22)
        Me.txtBoxSavingsAccNum.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Account Number:"
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.menuStrip)
        Me.MaximumSize = New System.Drawing.Size(1100, 650)
        Me.MinimumSize = New System.Drawing.Size(1100, 650)
        Me.Name = "frmRecords"
        Me.Text = "Accounts Viewer/Editor"
        Me.groupBoxCheckingDetails.ResumeLayout(False)
        Me.groupBoxCheckingDetails.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewSavings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridViewChecking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxSavingsDetails.ResumeLayout(False)
        Me.groupBoxSavingsDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupBoxCheckingDetails As GroupBox
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblCheckingAccNumber As Label
    Friend WithEvents txtBoxCheckingAccNum As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewSavings As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridViewChecking As DataGridView
    Friend WithEvents txtBoxCheckingAccBal As TextBox
    Friend WithEvents lblCheckingAccBalance As Label
    Friend WithEvents txtBoxCheckingLName As TextBox
    Friend WithEvents lblCheckingLastName As Label
    Friend WithEvents txtBoxCheckingFName As TextBox
    Friend WithEvents lblCheckingFirstName As Label
    Friend WithEvents btnUpdateCheckingRecord As Button
    Friend WithEvents btnDeleteCheckingRecord As Button
    Friend WithEvents btnAddCheckingRecord As Button
    Friend WithEvents groupBoxSavingsDetails As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdateSavingsRecord As Button
    Friend WithEvents btnDeleteSavingsRecord As Button
    Friend WithEvents btnAddSavingsRecord As Button
    Friend WithEvents comboTermLength As ComboBox
    Friend WithEvents comboAccType As ComboBox
    Friend WithEvents txtBoxSavingsAccBal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxSavingsLName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxSavingsFName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxSavingsAccNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCheckingClear As Button
    Friend WithEvents btnSavingsClear As Button
End Class
