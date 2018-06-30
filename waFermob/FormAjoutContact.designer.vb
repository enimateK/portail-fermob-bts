<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjoutContact
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
        Me.txtNomContact = New System.Windows.Forms.TextBox()
        Me.txtPrenomContact = New System.Windows.Forms.TextBox()
        Me.txtNumIntern = New System.Windows.Forms.TextBox()
        Me.txtNumeroDePortable = New System.Windows.Forms.TextBox()
        Me.NomContact = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMailContact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectEntreprise = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboTitre = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNomContact
        '
        Me.txtNomContact.Location = New System.Drawing.Point(224, 138)
        Me.txtNomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomContact.Name = "txtNomContact"
        Me.txtNomContact.Size = New System.Drawing.Size(193, 24)
        Me.txtNomContact.TabIndex = 0
        '
        'txtPrenomContact
        '
        Me.txtPrenomContact.Location = New System.Drawing.Point(224, 189)
        Me.txtPrenomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrenomContact.Name = "txtPrenomContact"
        Me.txtPrenomContact.Size = New System.Drawing.Size(193, 24)
        Me.txtPrenomContact.TabIndex = 1
        '
        'txtNumIntern
        '
        Me.txtNumIntern.Location = New System.Drawing.Point(224, 267)
        Me.txtNumIntern.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumIntern.Name = "txtNumIntern"
        Me.txtNumIntern.Size = New System.Drawing.Size(193, 24)
        Me.txtNumIntern.TabIndex = 2
        '
        'txtNumeroDePortable
        '
        Me.txtNumeroDePortable.Location = New System.Drawing.Point(224, 319)
        Me.txtNumeroDePortable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumeroDePortable.Name = "txtNumeroDePortable"
        Me.txtNumeroDePortable.Size = New System.Drawing.Size(193, 24)
        Me.txtNumeroDePortable.TabIndex = 3
        '
        'NomContact
        '
        Me.NomContact.AutoSize = True
        Me.NomContact.ForeColor = System.Drawing.Color.White
        Me.NomContact.Location = New System.Drawing.Point(129, 141)
        Me.NomContact.Name = "NomContact"
        Me.NomContact.Size = New System.Drawing.Size(81, 17)
        Me.NomContact.TabIndex = 4
        Me.NomContact.Text = "Nom Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(113, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numéro de téléphone Interne"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Numéro de téléphone portable"
        '
        'txtMailContact
        '
        Me.txtMailContact.Location = New System.Drawing.Point(224, 223)
        Me.txtMailContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMailContact.Name = "txtMailContact"
        Me.txtMailContact.Size = New System.Drawing.Size(193, 24)
        Me.txtMailContact.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(133, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mail Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(175, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Titre"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(164, 416)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ajouter le contact"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(147, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Entreprise"
        '
        'SelectEntreprise
        '
        Me.SelectEntreprise.FormattingEnabled = True
        Me.SelectEntreprise.Location = New System.Drawing.Point(224, 361)
        Me.SelectEntreprise.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SelectEntreprise.Name = "SelectEntreprise"
        Me.SelectEntreprise.Size = New System.Drawing.Size(193, 25)
        Me.SelectEntreprise.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(159, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Ajouter une contact"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(432, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Créer entreprise"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cboTitre
        '
        Me.cboTitre.FormattingEnabled = True
        Me.cboTitre.Location = New System.Drawing.Point(224, 84)
        Me.cboTitre.Name = "cboTitre"
        Me.cboTitre.Size = New System.Drawing.Size(121, 25)
        Me.cboTitre.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(476, 416)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 31)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Retour"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormAjoutContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 459)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cboTitre)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SelectEntreprise)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMailContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NomContact)
        Me.Controls.Add(Me.txtNumeroDePortable)
        Me.Controls.Add(Me.txtNumIntern)
        Me.Controls.Add(Me.txtPrenomContact)
        Me.Controls.Add(Me.txtNomContact)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormAjoutContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter un contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomContact As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenomContact As System.Windows.Forms.TextBox
    Friend WithEvents txtNumIntern As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroDePortable As System.Windows.Forms.TextBox
    Friend WithEvents NomContact As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMailContact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SelectEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboTitre As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As Button
End Class
