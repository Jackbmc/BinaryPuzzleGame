<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        btnReturn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(323, 362)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(146, 29)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Return to Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(344, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 46)
        Label1.TabIndex = 1
        Label1.Text = "Rules"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(753, 20)
        Label2.TabIndex = 2
        Label2.Text = "Fill in every box with either a 1 or 0 and ensure that no row or colums are the same as well as have no more than "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 20)
        Label3.TabIndex = 3
        Label3.Text = "two of the same numbers next to each other.4"
        ' 
        ' frmHelp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReturn)
        Name = "frmHelp"
        Text = "frmHelp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
