<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button_IN = New System.Windows.Forms.Button()
        Me.TextBox_IN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button_IN.AccessibleName = "Button_IN"
        Me.Button_IN.Location = New System.Drawing.Point(149, 55)
        Me.Button_IN.Name = "Button_IN"
        Me.Button_IN.Size = New System.Drawing.Size(75, 23)
        Me.Button_IN.TabIndex = 0
        Me.Button_IN.Text = "Browse"
        Me.Button_IN.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox_IN.AccessibleName = "TextBox_IN"
        Me.TextBox_IN.Location = New System.Drawing.Point(43, 55)
        Me.TextBox_IN.Name = "TextBox_IN"
        Me.TextBox_IN.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IN.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_IN)
        Me.Controls.Add(Me.Button_IN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_IN As Button
    Friend WithEvents TextBox_IN As TextBox
End Class
