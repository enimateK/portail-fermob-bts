<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjoutEntreprise
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboIdTypeEnt = New System.Windows.Forms.ComboBox()
        Me.cboCodePays = New System.Windows.Forms.ComboBox()
        Me.txtRaisonSocial = New System.Windows.Forms.TextBox()
        Me.txtAdresseRue = New System.Windows.Forms.TextBox()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Raison Sociale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Code Postal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(62, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(62, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pays"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(62, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Type d'entreprise"
        '
        'cboIdTypeEnt
        '
        Me.cboIdTypeEnt.FormattingEnabled = True
        Me.cboIdTypeEnt.Location = New System.Drawing.Point(230, 317)
        Me.cboIdTypeEnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIdTypeEnt.Name = "cboIdTypeEnt"
        Me.cboIdTypeEnt.Size = New System.Drawing.Size(140, 25)
        Me.cboIdTypeEnt.TabIndex = 6
        '
        'cboCodePays
        '
        Me.cboCodePays.FormattingEnabled = True
        Me.cboCodePays.Location = New System.Drawing.Point(230, 271)
        Me.cboCodePays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCodePays.Name = "cboCodePays"
        Me.cboCodePays.Size = New System.Drawing.Size(140, 25)
        Me.cboCodePays.TabIndex = 7
        '
        'txtRaisonSocial
        '
        Me.txtRaisonSocial.Location = New System.Drawing.Point(230, 84)
        Me.txtRaisonSocial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRaisonSocial.Name = "txtRaisonSocial"
        Me.txtRaisonSocial.Size = New System.Drawing.Size(116, 24)
        Me.txtRaisonSocial.TabIndex = 8
        '
        'txtAdresseRue
        '
        Me.txtAdresseRue.Location = New System.Drawing.Point(230, 139)
        Me.txtAdresseRue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdresseRue.Name = "txtAdresseRue"
        Me.txtAdresseRue.Size = New System.Drawing.Size(116, 24)
        Me.txtAdresseRue.TabIndex = 9
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(230, 188)
        Me.txtCodePostal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(116, 24)
        Me.txtCodePostal.TabIndex = 10
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(230, 229)
        Me.txtVille.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(116, 24)
        Me.txtVille.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(230, 363)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ajouter l'entreprise"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(87, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 26)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ajouter une entreprise"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(395, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Créer pays"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(395, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Créer entreprise"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(463, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 37)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Retour"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FormAjoutEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 440)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtAdresseRue)
        Me.Controls.Add(Me.txtRaisonSocial)
        Me.Controls.Add(Me.cboCodePays)
        Me.Controls.Add(Me.cboIdTypeEnt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormAjoutEntreprise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter une entreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboIdTypeEnt As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodePays As System.Windows.Forms.ComboBox
    Friend WithEvents txtRaisonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresseRue As System.Windows.Forms.TextBox
    Friend WithEvents txtCodePostal As System.Windows.Forms.TextBox
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
End Class
