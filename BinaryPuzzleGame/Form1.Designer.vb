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
        ListBox1 = New ListBox()
        btnTofrmStart = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(306, 407)
        ListBox1.Margin = New Padding(2, 2, 2, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(287, 224)
        ListBox1.TabIndex = 0
        ' 
        ' btnTofrmStart
        ' 
        btnTofrmStart.Location = New Point(99, 580)
        btnTofrmStart.Name = "btnTofrmStart"
        btnTofrmStart.Size = New Size(94, 29)
        btnTofrmStart.TabIndex = 1
        btnTofrmStart.Text = "To frmStart"
        btnTofrmStart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 617)
        Controls.Add(btnTofrmStart)
        Controls.Add(ListBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnTofrmStart As Button

End Class
