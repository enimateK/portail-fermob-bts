<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifContact
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
        Me.cboNomContact = New System.Windows.Forms.ComboBox()
        Me.txtNomContact = New System.Windows.Forms.TextBox()
        Me.txtPrenomContact = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelInterne = New System.Windows.Forms.TextBox()
        Me.txtTelPortable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPrenomContact = New System.Windows.Forms.ComboBox()
        Me.cboEntreprise = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIdContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTitre = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboNomContact
        '
        Me.cboNomContact.FormattingEnabled = True
        Me.cboNomContact.Location = New System.Drawing.Point(642, 116)
        Me.cboNomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNomContact.Name = "cboNomContact"
        Me.cboNomContact.Size = New System.Drawing.Size(191, 25)
        Me.cboNomContact.TabIndex = 0
        '
        'txtNomContact
        '
        Me.txtNomContact.Location = New System.Drawing.Point(154, 109)
        Me.txtNomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomContact.Name = "txtNomContact"
        Me.txtNomContact.Size = New System.Drawing.Size(116, 24)
        Me.txtNomContact.TabIndex = 2
        '
        'txtPrenomContact
        '
        Me.txtPrenomContact.Location = New System.Drawing.Point(154, 156)
        Me.txtPrenomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrenomContact.Name = "txtPrenomContact"
        Me.txtPrenomContact.Size = New System.Drawing.Size(116, 24)
        Me.txtPrenomContact.TabIndex = 3
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(154, 203)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(116, 24)
        Me.txtMail.TabIndex = 4
        '
        'txtTelInterne
        '
        Me.txtTelInterne.Location = New System.Drawing.Point(154, 250)
        Me.txtTelInterne.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelInterne.Name = "txtTelInterne"
        Me.txtTelInterne.Size = New System.Drawing.Size(116, 24)
        Me.txtTelInterne.TabIndex = 5
        '
        'txtTelPortable
        '
        Me.txtTelPortable.Location = New System.Drawing.Point(154, 300)
        Me.txtTelPortable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelPortable.Name = "txtTelPortable"
        Me.txtTelPortable.Size = New System.Drawing.Size(177, 24)
        Me.txtTelPortable.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Titre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nom Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Prenom Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(79, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tel Interne"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tel portable"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Entreprise"
        '
        'cboPrenomContact
        '
        Me.cboPrenomContact.FormattingEnabled = True
        Me.cboPrenomContact.Location = New System.Drawing.Point(642, 159)
        Me.cboPrenomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPrenomContact.Name = "cboPrenomContact"
        Me.cboPrenomContact.Size = New System.Drawing.Size(191, 25)
        Me.cboPrenomContact.TabIndex = 15
        '
        'cboEntreprise
        '
        Me.cboEntreprise.FormattingEnabled = True
        Me.cboEntreprise.Location = New System.Drawing.Point(154, 348)
        Me.cboEntreprise.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEntreprise.Name = "cboEntreprise"
        Me.cboEntreprise.Size = New System.Drawing.Size(177, 25)
        Me.cboEntreprise.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(673, 225)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 72)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Modifier le contact"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtIdContact
        '
        Me.txtIdContact.Location = New System.Drawing.Point(292, 110)
        Me.txtIdContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdContact.Name = "txtIdContact"
        Me.txtIdContact.Size = New System.Drawing.Size(116, 24)
        Me.txtIdContact.TabIndex = 18
        Me.txtIdContact.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(579, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(563, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Prénom"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(543, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(370, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Séléctionner le Nom et le Prénom du contact à modifier"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(351, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 26)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Modifier un Contact"
        '
        'cboTitre
        '
        Me.cboTitre.FormattingEnabled = True
        Me.cboTitre.Location = New System.Drawing.Point(154, 63)
        Me.cboTitre.Name = "cboTitre"
        Me.cboTitre.Size = New System.Drawing.Size(121, 25)
        Me.cboTitre.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(820, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 34)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormModifContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 409)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboTitre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdContact)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboEntreprise)
        Me.Controls.Add(Me.cboPrenomContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTelPortable)
        Me.Controls.Add(Me.txtTelInterne)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtPrenomContact)
        Me.Controls.Add(Me.txtNomContact)
        Me.Controls.Add(Me.cboNomContact)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormModifContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormModifContact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboNomContact As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomContact As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenomContact As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelInterne As System.Windows.Forms.TextBox
    Friend WithEvents txtTelPortable As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPrenomContact As System.Windows.Forms.ComboBox
    Friend WithEvents cboEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtIdContact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTitre As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As Button
End Class
