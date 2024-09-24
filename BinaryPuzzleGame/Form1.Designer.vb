<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        'ListBox1 = New ListBox()
        SuspendLayout()
        '' 
        '' ListBox1
        '' 
        'ListBox1.FormattingEnabled = True
        'ListBox1.ItemHeight = 25
        'ListBox1.Location = New Point(382, 509)
        'ListBox1.Margin = New Padding(2)
        'ListBox1.Name = "ListBox1"
        'ListBox1.Size = New Size(358, 279)
        'ListBox1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 771)
        Controls.Add(Button1)
        Controls.Add(btnTofrmStart)
        Controls.Add(ListBox1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnTofrmStart As Button
    Friend WithEvents Button1 As Button

End Class
