<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontEnd))
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RomfilesList = New System.Windows.Forms.ListBox()
        Me.PicturesBox = New System.Windows.Forms.PictureBox()
        Me.CreditsLabel = New System.Windows.Forms.Label()
        CType(Me.PicturesBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.White
        Me.PlayButton.Enabled = False
        Me.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.PlayButton.FlatAppearance.BorderSize = 0
        Me.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Image = Global.nespack.My.Resources.Resources.Button
        Me.PlayButton.Location = New System.Drawing.Point(352, 245)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(99, 26)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Text = "&Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.White
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Image = Global.nespack.My.Resources.Resources.Button
        Me.ExitButton.Location = New System.Drawing.Point(457, 245)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 26)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'RomfilesList
        '
        Me.RomfilesList.BackColor = System.Drawing.Color.White
        Me.RomfilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RomfilesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomfilesList.ForeColor = System.Drawing.Color.Black
        Me.RomfilesList.FormattingEnabled = True
        Me.RomfilesList.Location = New System.Drawing.Point(296, 42)
        Me.RomfilesList.Name = "RomfilesList"
        Me.RomfilesList.Size = New System.Drawing.Size(260, 197)
        Me.RomfilesList.Sorted = True
        Me.RomfilesList.TabIndex = 2
        '
        'PicturesBox
        '
        Me.PicturesBox.BackColor = System.Drawing.Color.Gray
        Me.PicturesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturesBox.Image = Global.nespack.My.Resources.Resources.nintendones
        Me.PicturesBox.Location = New System.Drawing.Point(23, 42)
        Me.PicturesBox.Name = "PicturesBox"
        Me.PicturesBox.Size = New System.Drawing.Size(256, 224)
        Me.PicturesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicturesBox.TabIndex = 3
        Me.PicturesBox.TabStop = False
        '
        'CreditsLabel
        '
        Me.CreditsLabel.AutoSize = True
        Me.CreditsLabel.BackColor = System.Drawing.Color.Black
        Me.CreditsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreditsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditsLabel.ForeColor = System.Drawing.Color.Silver
        Me.CreditsLabel.Location = New System.Drawing.Point(42, 141)
        Me.CreditsLabel.Name = "CreditsLabel"
        Me.CreditsLabel.Size = New System.Drawing.Size(218, 26)
        Me.CreditsLabel.TabIndex = 4
        Me.CreditsLabel.Text = "FrontEnd created by Christian Soares" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All roms copyrighted by Nintendo."
        Me.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrontEnd
        '
        Me.AcceptButton = Me.PlayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.nespack.My.Resources.Resources.Windows3x_Skin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(579, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.CreditsLabel)
        Me.Controls.Add(Me.PicturesBox)
        Me.Controls.Add(Me.RomfilesList)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PlayButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrontEnd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicturesBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents RomfilesList As System.Windows.Forms.ListBox
    Friend WithEvents PicturesBox As System.Windows.Forms.PictureBox
    Friend WithEvents CreditsLabel As System.Windows.Forms.Label

End Class
