<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_largeurForm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_longeurForm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_hauteurPt1 = New System.Windows.Forms.TextBox()
        Me.txt_longueur = New System.Windows.Forms.TextBox()
        Me.txt_hauteurPt2 = New System.Windows.Forms.TextBox()
        Me.txt_debut = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(458, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Largeur"
        '
        'txt_largeurForm
        '
        Me.txt_largeurForm.Location = New System.Drawing.Point(450, 193)
        Me.txt_largeurForm.Name = "txt_largeurForm"
        Me.txt_largeurForm.Size = New System.Drawing.Size(70, 20)
        Me.txt_largeurForm.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Longeur"
        '
        'txt_longeurForm
        '
        Me.txt_longeurForm.Location = New System.Drawing.Point(450, 232)
        Me.txt_longeurForm.Name = "txt_longeurForm"
        Me.txt_longeurForm.Size = New System.Drawing.Size(70, 20)
        Me.txt_longeurForm.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Hauteur point 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Hauteur point 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "longueur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "debut"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_hauteurPt1
        '
        Me.txt_hauteurPt1.Location = New System.Drawing.Point(453, 115)
        Me.txt_hauteurPt1.Name = "txt_hauteurPt1"
        Me.txt_hauteurPt1.Size = New System.Drawing.Size(100, 20)
        Me.txt_hauteurPt1.TabIndex = 18
        '
        'txt_longueur
        '
        Me.txt_longueur.Location = New System.Drawing.Point(453, 67)
        Me.txt_longueur.Name = "txt_longueur"
        Me.txt_longueur.Size = New System.Drawing.Size(100, 20)
        Me.txt_longueur.TabIndex = 17
        '
        'txt_hauteurPt2
        '
        Me.txt_hauteurPt2.Location = New System.Drawing.Point(453, 154)
        Me.txt_hauteurPt2.Name = "txt_hauteurPt2"
        Me.txt_hauteurPt2.Size = New System.Drawing.Size(100, 20)
        Me.txt_hauteurPt2.TabIndex = 16
        '
        'txt_debut
        '
        Me.txt_debut.Location = New System.Drawing.Point(453, 28)
        Me.txt_debut.Name = "txt_debut"
        Me.txt_debut.Size = New System.Drawing.Size(100, 20)
        Me.txt_debut.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 445)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-53, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 21)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 506)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 474)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_largeurForm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_longeurForm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_hauteurPt1)
        Me.Controls.Add(Me.txt_longueur)
        Me.Controls.Add(Me.txt_hauteurPt2)
        Me.Controls.Add(Me.txt_debut)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_largeurForm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_longeurForm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_hauteurPt1 As TextBox
    Friend WithEvents txt_longueur As TextBox
    Friend WithEvents txt_hauteurPt2 As TextBox
    Friend WithEvents txt_debut As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
