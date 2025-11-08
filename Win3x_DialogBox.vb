Imports System.Windows.Forms

Public Class Win3x_DialogBox

    Private wMNchittest As Integer = &H84
    Private htclient As Integer = &H1
    Private htcaption As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case wMNchittest
                If m.Result = New IntPtr(htclient) Then
                    m.Result = New IntPtr(htcaption)
                End If
        End Select
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OK_Button_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OK_Button.MouseDown
        OK_Button.Image = My.Resources.ButtonMouseDown
    End Sub

    Private Sub OK_Button_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OK_Button.MouseUp
        OK_Button.Image = My.Resources.Button
    End Sub

    Private Sub Win3x_DialogBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.CHORD, AudioPlayMode.Background)
    End Sub
End Class
