Imports System.IO
Imports System.Net

Public Class frmSettings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbDebug.Checked = My.Settings.DebugMode
            cmbLang.SelectedItem = My.Settings.Language

            Translate()
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.DebugMode = cbDebug.Checked
        My.Settings.Language = cmbLang.SelectedItem
        My.Settings.Save()
        Me.Close()
    End Sub

    Public Sub Translate()
        Select Case My.Settings.Language
            Case "English"
                Me.Text = "Settings"
                NsTheme1.Text = Me.Text
                cbDebug.Text = "Debug Mode"
                Label21.Text = "Launcher Language"
                btnSave.Text = "Save"
            Case "Chinese"
                Me.Text = "設定"
                NsTheme1.Text = Me.Text
                cbDebug.Text = "調試模式"
                Label21.Text = "登陸器語言"
                btnSave.Text = "保存"
            Case "French"
                Me.Text = "Réglages"
                NsTheme1.Text = Me.Text
                cbDebug.Text = "Mode Debug"
                Label21.Text = "Langue"
                btnSave.Text = "Sauv"
        End Select
    End Sub

    Private Sub frmSettings_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Me.Location.Y <= -1 Then
            Me.Location = New Point(Me.Location.X, 0)
        End If
    End Sub
End Class