<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        btnStartGame = New Button()
        btnHelp = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnStartGame
        ' 
        btnStartGame.Location = New Point(354, 215)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(94, 29)
        btnStartGame.TabIndex = 0
        btnStartGame.Text = "START"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' btnHelp
        ' 
        btnHelp.Location = New Point(354, 250)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(94, 29)
        btnHelp.TabIndex = 1
        btnHelp.Text = "HELP"
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(354, 285)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 2
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnHelp)
        Controls.Add(btnStartGame)
        Name = "frmStart"
        Text = "frmStart"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnExit As Button
End Class
