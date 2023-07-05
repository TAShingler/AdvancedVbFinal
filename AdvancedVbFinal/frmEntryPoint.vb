Imports System.IO

Public Class frmEntryPoint
    'Creates new File at user-selected location
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim result As DialogResult

        result = saveFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            frmRecords.FilePath = saveFileDialog.FileName
            frmRecords.isNewFile = True
            frmRecords.Show()

            Enabled = False
        End If
    End Sub

    'Opens selected File
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim result As DialogResult

        result = openFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            frmRecords.FilePath = openFileDialog.FileName
            frmRecords.Show()

            Enabled = False
        End If
    End Sub

    'Exits Application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Creates new File at user-selected location
    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        Dim result As DialogResult

        result = saveFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            frmRecords.FilePath = saveFileDialog.FileName
            frmRecords.isNewFile = True
            frmRecords.Show()

            Enabled = False
        End If
    End Sub

    'Opens Selected File
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim result As DialogResult

        result = openFileDialog.ShowDialog()

        If result = DialogResult.OK Then
            frmRecords.FilePath = openFileDialog.FileName
            frmRecords.Show()

            Enabled = False
        End If
    End Sub

    'Exits Application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Displays frmAbout
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

        Enabled = False 'disable this form
    End Sub
End Class