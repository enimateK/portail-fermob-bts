<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjoutAction
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
        Me.txtCommentaire = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPrenomContact = New System.Windows.Forms.ComboBox()
        Me.cboTypeAction = New System.Windows.Forms.ComboBox()
        Me.cboNomContact = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDateRelance = New System.Windows.Forms.TextBox()
        Me.txtDateAction = New System.Windows.Forms.TextBox()
        Me.txtIdContact = New System.Windows.Forms.TextBox()
        Me.cboRelance = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCommentaire
        '
        Me.txtCommentaire.Location = New System.Drawing.Point(183, 121)
        Me.txtCommentaire.Multiline = True
        Me.txtCommentaire.Name = "txtCommentaire"
        Me.txtCommentaire.Size = New System.Drawing.Size(338, 60)
        Me.txtCommentaire.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Date Action"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Commentaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "A Relancer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date Relance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Contact"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Type d'action"
        '
        'cboPrenomContact
        '
        Me.cboPrenomContact.FormattingEnabled = True
        Me.cboPrenomContact.Location = New System.Drawing.Point(322, 296)
        Me.cboPrenomContact.Name = "cboPrenomContact"
        Me.cboPrenomContact.Size = New System.Drawing.Size(121, 21)
        Me.cboPrenomContact.TabIndex = 14
        '
        'cboTypeAction
        '
        Me.cboTypeAction.FormattingEnabled = True
        Me.cboTypeAction.Location = New System.Drawing.Point(183, 350)
        Me.cboTypeAction.Name = "cboTypeAction"
        Me.cboTypeAction.Size = New System.Drawing.Size(121, 21)
        Me.cboTypeAction.TabIndex = 15
        '
        'cboNomContact
        '
        Me.cboNomContact.FormattingEnabled = True
        Me.cboNomContact.Location = New System.Drawing.Point(183, 295)
        Me.cboNomContact.Name = "cboNomContact"
        Me.cboNomContact.Size = New System.Drawing.Size(121, 21)
        Me.cboNomContact.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(230, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 53)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ajouter l'action"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtDateRelance
        '
        Me.txtDateRelance.Location = New System.Drawing.Point(183, 243)
        Me.txtDateRelance.Name = "txtDateRelance"
        Me.txtDateRelance.Size = New System.Drawing.Size(100, 20)
        Me.txtDateRelance.TabIndex = 19
        '
        'txtDateAction
        '
        Me.txtDateAction.Location = New System.Drawing.Point(183, 65)
        Me.txtDateAction.Name = "txtDateAction"
        Me.txtDateAction.Size = New System.Drawing.Size(100, 20)
        Me.txtDateAction.TabIndex = 20
        '
        'txtIdContact
        '
        Me.txtIdContact.Location = New System.Drawing.Point(555, 299)
        Me.txtIdContact.Name = "txtIdContact"
        Me.txtIdContact.Size = New System.Drawing.Size(100, 20)
        Me.txtIdContact.TabIndex = 21
        Me.txtIdContact.Visible = False
        '
        'cboRelance
        '
        Me.cboRelance.FormattingEnabled = True
        Me.cboRelance.Location = New System.Drawing.Point(183, 191)
        Me.cboRelance.Name = "cboRelance"
        Me.cboRelance.Size = New System.Drawing.Size(121, 21)
        Me.cboRelance.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyyMMdd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyyMMdd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(183, 243)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker2.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(225, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 26)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Ajouter une Action"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(458, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Créer contact"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(317, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Créer action"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(566, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 32)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Retour"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FormAjoutAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(667, 447)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cboRelance)
        Me.Controls.Add(Me.txtDateAction)
        Me.Controls.Add(Me.txtDateRelance)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboNomContact)
        Me.Controls.Add(Me.cboTypeAction)
        Me.Controls.Add(Me.cboPrenomContact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCommentaire)
        Me.Controls.Add(Me.txtIdContact)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FormAjoutAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter une action"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPrenomContact As System.Windows.Forms.ComboBox
    Friend WithEvents cboTypeAction As System.Windows.Forms.ComboBox
    Friend WithEvents cboNomContact As System.Windows.Forms.ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDateRelance As System.Windows.Forms.TextBox
    Friend WithEvents txtDateAction As System.Windows.Forms.TextBox
    Friend WithEvents txtIdContact As System.Windows.Forms.TextBox
    Friend WithEvents cboRelance As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
End Class
