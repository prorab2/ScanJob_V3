Public Class Form1
    Private Sub Button_IN_Click(sender As Object, e As EventArgs) Handles Button_IN.Click
        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = Application.StartupPath
        If DialogResult.OK = dialog.ShowDialog() Then
            TextBox_IN.Text = dialog.SelectedPath
        End If
    End Sub
End Class
