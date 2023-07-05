<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntryPoint
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOpen = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(418, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'lblOpen
        '
        Me.lblOpen.AutoSize = True
        Me.lblOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpen.Location = New System.Drawing.Point(23, 85)
        Me.lblOpen.Name = "lblOpen"
        Me.lblOpen.Size = New System.Drawing.Size(246, 20)
        Me.lblOpen.TabIndex = 4
        Me.lblOpen.Text = "Open file to view and edit records:"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(275, 80)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(115, 30)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Open File..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(275, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'openFileDialog
        '
        Me.openFileDialog.DefaultExt = "txt"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(82, 49)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(187, 20)
        Me.lblNew.TabIndex = 7
        Me.lblNew.Text = "Create new accounts file:"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(275, 44)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(115, 30)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New File..."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewFileToolStripMenuItem.Text = "New File..."
        '
        'saveFileDialog
        '
        Me.saveFileDialog.DefaultExt = "txt"
        '
        'frmEntryPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 167)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOpen)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmEntryPoint"
        Me.Text = "Accounts Viewer/Editor"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblOpen As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNew As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents NewFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveFileDialog As SaveFileDialog
End Class
