Imports System.IO

Public Class FrontEnd

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FrontEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim dir As DirectoryInfo = New DirectoryInfo("romfiles")
        Dim oFileInfoCollection() As FileInfo
        Dim oFileInfo As FileInfo
        Dim i As Integer

        oFileInfoCollection = dir.GetFiles.Where(Function(fi) fi.Extension = ".nes" OrElse fi.Extension = ".NES").ToArray

        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            RomfilesList.Items.Add(oFileInfo.Name.Replace(".nes", "").Replace(".NES", ""))
        Next

        Dim number As Integer
        Dim numberGenerator As Random = New Random()

        number = numberGenerator.Next(1, 7)

        Select Case number
            Case 1
                My.Computer.Audio.Play(My.Resources.music001, AudioPlayMode.Background)
            Case 2
                My.Computer.Audio.Play(My.Resources.music002, AudioPlayMode.Background)
            Case 3
                My.Computer.Audio.Play(My.Resources.music003, AudioPlayMode.Background)
            Case 4
                My.Computer.Audio.Play(My.Resources.music004, AudioPlayMode.Background)
            Case 5
                My.Computer.Audio.Play(My.Resources.music005, AudioPlayMode.Background)
            Case 6
                My.Computer.Audio.Play(My.Resources.music006, AudioPlayMode.Background)
        End Select
    End Sub

    Private Sub RomfilesList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RomfilesList.SelectedIndexChanged
        If CreditsLabel.Visible = True Then CreditsLabel.Visible = False
        If PlayButton.Enabled = False Then PlayButton.Enabled = True

        If File.Exists("snaps\" & RomfilesList.Text & "-0.png") Then
            PicturesBox.Image = Bitmap.FromFile("snaps\" & RomfilesList.Text & "-0.png")
            Exit Sub
        ElseIf File.Exists("snaps\" & RomfilesList.Text & ".png") Then
            PicturesBox.Image = Bitmap.FromFile("snaps\" & RomfilesList.Text & ".png")
            Exit Sub
        Else
            PicturesBox.BackColor = Color.Black
            PicturesBox.Image = My.Resources.NOPIC
        End If
    End Sub

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        StartGame()
    End Sub

    Private Sub RomfilesList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RomfilesList.MouseDoubleClick
        StartGame()
    End Sub

    Sub StartGame()
        On Error Resume Next
        Dim romfilesDir As String = "romfiles\"
        Dim emulatorDir As String = "fceux.exe "

        My.Computer.Audio.Stop()

        If Not File.Exists(emulatorDir) Then
            Win3x_DialogBox.Label1.Text = "An emulator '" & emulatorDir & "' is required to continue."
            Win3x_DialogBox.Show()
            Exit Sub
        End If

        If File.Exists(romfilesDir & RomfilesList.Text & ".nes") Then
            Shell(emulatorDir & """" & romfilesDir & RomfilesList.Text & ".nes""", AppWinStyle.NormalFocus)
            Exit Sub
        End If
    End Sub

    Private Sub PlayButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PlayButton.MouseDown
        PlayButton.Image = My.Resources.ButtonMouseDown
    End Sub

    Private Sub PlayButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PlayButton.MouseUp
        PlayButton.Image = My.Resources.Button
    End Sub

    Private Sub ExitButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ExitButton.MouseDown
        ExitButton.Image = My.Resources.ButtonMouseDown
    End Sub

    Private Sub ExitButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ExitButton.MouseUp
        ExitButton.Image = My.Resources.Button
    End Sub

    Private Sub CreditsLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsLabel.Click
        Process.Start("https://gameherobrazil.blogspot.com/")
    End Sub

    Private Sub CreditsLabel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreditsLabel.MouseHover
        CreditsLabel.ForeColor = Color.White
    End Sub

    Private Sub CreditsLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreditsLabel.MouseLeave
        CreditsLabel.ForeColor = Color.Silver
    End Sub
End Class
