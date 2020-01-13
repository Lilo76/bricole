<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.subtractButton = New System.Windows.Forms.Button()
        Me.txt_x = New System.Windows.Forms.TextBox()
        Me.txt_y = New System.Windows.Forms.TextBox()
        Me.PanelSF = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'subtractButton
        '
        Me.subtractButton.Location = New System.Drawing.Point(689, 397)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(75, 23)
        Me.subtractButton.TabIndex = 0
        Me.subtractButton.Text = "Button1"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'txt_x
        '
        Me.txt_x.Location = New System.Drawing.Point(69, 23)
        Me.txt_x.Name = "txt_x"
        Me.txt_x.Size = New System.Drawing.Size(100, 20)
        Me.txt_x.TabIndex = 3
        '
        'txt_y
        '
        Me.txt_y.Location = New System.Drawing.Point(209, 22)
        Me.txt_y.Name = "txt_y"
        Me.txt_y.Size = New System.Drawing.Size(100, 20)
        Me.txt_y.TabIndex = 4
        '
        'PanelSF
        '
        Me.PanelSF.Location = New System.Drawing.Point(69, 137)
        Me.PanelSF.Name = "PanelSF"
        Me.PanelSF.Size = New System.Drawing.Size(378, 283)
        Me.PanelSF.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelSF)
        Me.Controls.Add(Me.txt_y)
        Me.Controls.Add(Me.txt_x)
        Me.Controls.Add(Me.subtractButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subtractButton As Button
    Friend WithEvents txt_x As TextBox
    Friend WithEvents txt_y As TextBox
    Friend WithEvents PanelSF As Panel
End Class
