<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifEntreprise
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
        Me.cboNomEntreprise = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRaisonSociale = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.cboPays = New System.Windows.Forms.ComboBox()
        Me.cboTypeEntreprise = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdEnt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboNomEntreprise
        '
        Me.cboNomEntreprise.FormattingEnabled = True
        Me.cboNomEntreprise.Location = New System.Drawing.Point(137, 30)
        Me.cboNomEntreprise.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNomEntreprise.Name = "cboNomEntreprise"
        Me.cboNomEntreprise.Size = New System.Drawing.Size(140, 25)
        Me.cboNomEntreprise.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Raison Sociale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Adresse Rue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Code Postal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pays"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 456)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Type Entreprise"
        '
        'txtRaisonSociale
        '
        Me.txtRaisonSociale.Location = New System.Drawing.Point(163, 99)
        Me.txtRaisonSociale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRaisonSociale.Name = "txtRaisonSociale"
        Me.txtRaisonSociale.Size = New System.Drawing.Size(140, 24)
        Me.txtRaisonSociale.TabIndex = 7
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(163, 163)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(140, 24)
        Me.txtAdresse.TabIndex = 10
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(163, 232)
        Me.txtCodePostal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(140, 24)
        Me.txtCodePostal.TabIndex = 11
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(163, 307)
        Me.txtVille.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(140, 24)
        Me.txtVille.TabIndex = 12
        '
        'cboPays
        '
        Me.cboPays.FormattingEnabled = True
        Me.cboPays.Location = New System.Drawing.Point(163, 379)
        Me.cboPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPays.Name = "cboPays"
        Me.cboPays.Size = New System.Drawing.Size(140, 25)
        Me.cboPays.TabIndex = 13
        '
        'cboTypeEntreprise
        '
        Me.cboTypeEntreprise.FormattingEnabled = True
        Me.cboTypeEntreprise.Location = New System.Drawing.Point(163, 445)
        Me.cboTypeEntreprise.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTypeEntreprise.Name = "cboTypeEntreprise"
        Me.cboTypeEntreprise.Size = New System.Drawing.Size(140, 25)
        Me.cboTypeEntreprise.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 500)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Id"
        Me.Label7.Visible = False
        '
        'txtIdEnt
        '
        Me.txtIdEnt.Location = New System.Drawing.Point(488, 496)
        Me.txtIdEnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdEnt.Name = "txtIdEnt"
        Me.txtIdEnt.Size = New System.Drawing.Size(116, 24)
        Me.txtIdEnt.TabIndex = 16
        Me.txtIdEnt.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(389, 189)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 69)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Modifier l'entreprise"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(87, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Veuillez séléctionner l'entreprise a modifier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(364, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Modifier une Entreprise"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(389, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 47)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormModifEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdEnt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTypeEntreprise)
        Me.Controls.Add(Me.cboPays)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtRaisonSociale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNomEntreprise)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormModifEntreprise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboNomEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRaisonSociale As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents txtCodePostal As System.Windows.Forms.TextBox
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents cboPays As System.Windows.Forms.ComboBox
    Friend WithEvents cboTypeEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdEnt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
End Class
