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
        Me.btn_CreateAndCopy = New System.Windows.Forms.Button()
        Me.txt_nomTable = New System.Windows.Forms.TextBox()
        Me.TxtBox_Dir = New System.Windows.Forms.TextBox()
        Me.btn_page_import = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_serv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_form2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CreateAndCopy
        '
        Me.btn_CreateAndCopy.Location = New System.Drawing.Point(12, 40)
        Me.btn_CreateAndCopy.Name = "btn_CreateAndCopy"
        Me.btn_CreateAndCopy.Size = New System.Drawing.Size(95, 23)
        Me.btn_CreateAndCopy.TabIndex = 11
        Me.btn_CreateAndCopy.Text = "Create And Copy"
        Me.btn_CreateAndCopy.UseVisualStyleBackColor = True
        '
        'txt_nomTable
        '
        Me.txt_nomTable.Location = New System.Drawing.Point(113, 40)
        Me.txt_nomTable.Name = "txt_nomTable"
        Me.txt_nomTable.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomTable.TabIndex = 10
        '
        'TxtBox_Dir
        '
        Me.TxtBox_Dir.Location = New System.Drawing.Point(93, 14)
        Me.TxtBox_Dir.Name = "TxtBox_Dir"
        Me.TxtBox_Dir.Size = New System.Drawing.Size(186, 20)
        Me.TxtBox_Dir.TabIndex = 9
        '
        'btn_page_import
        '
        Me.btn_page_import.Location = New System.Drawing.Point(12, 12)
        Me.btn_page_import.Name = "btn_page_import"
        Me.btn_page_import.Size = New System.Drawing.Size(75, 23)
        Me.btn_page_import.TabIndex = 8
        Me.btn_page_import.Text = "Import"
        Me.btn_page_import.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(764, 37)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(705, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(705, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Pass"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(764, 64)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(705, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "database"
        '
        'txt_dt
        '
        Me.txt_dt.Location = New System.Drawing.Point(764, 92)
        Me.txt_dt.Name = "txt_dt"
        Me.txt_dt.Size = New System.Drawing.Size(100, 20)
        Me.txt_dt.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(705, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Server"
        '
        'txt_serv
        '
        Me.txt_serv.Location = New System.Drawing.Point(764, 11)
        Me.txt_serv.Name = "txt_serv"
        Me.txt_serv.Size = New System.Drawing.Size(100, 20)
        Me.txt_serv.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(615, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_form2
        '
        Me.btn_form2.Location = New System.Drawing.Point(13, 70)
        Me.btn_form2.Name = "btn_form2"
        Me.btn_form2.Size = New System.Drawing.Size(75, 23)
        Me.btn_form2.TabIndex = 21
        Me.btn_form2.Text = "go form 2"
        Me.btn_form2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(307, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_form2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_serv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.btn_CreateAndCopy)
        Me.Controls.Add(Me.txt_nomTable)
        Me.Controls.Add(Me.TxtBox_Dir)
        Me.Controls.Add(Me.btn_page_import)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_CreateAndCopy As Button
    Friend WithEvents txt_nomTable As TextBox
    Friend WithEvents TxtBox_Dir As TextBox
    Friend WithEvents btn_page_import As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_dt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_serv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_form2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
