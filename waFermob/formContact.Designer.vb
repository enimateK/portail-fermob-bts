<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formContact
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
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.btnEntr = New System.Windows.Forms.Button()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.dgvContact = New System.Windows.Forms.DataGridView()
        Me.BtnContactRetour = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.White
        Me.btnModif.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(345, 374)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(118, 61)
        Me.btnModif.TabIndex = 8
        Me.btnModif.Text = "Modifier des contacts"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppr.Location = New System.Drawing.Point(504, 374)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(130, 61)
        Me.btnSuppr.TabIndex = 7
        Me.btnSuppr.Text = "Supprimer des contacts"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'btnAjout
        '
        Me.btnAjout.BackColor = System.Drawing.Color.White
        Me.btnAjout.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjout.Location = New System.Drawing.Point(183, 374)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(118, 61)
        Me.btnAjout.TabIndex = 6
        Me.btnAjout.Text = "Ajouter des contacts"
        Me.btnAjout.UseVisualStyleBackColor = False
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.White
        Me.lblContact.Location = New System.Drawing.Point(12, 9)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(289, 39)
        Me.lblContact.TabIndex = 5
        Me.lblContact.Text = "Gestion des contacts"
        '
        'btnEntr
        '
        Me.btnEntr.BackColor = System.Drawing.Color.White
        Me.btnEntr.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntr.Location = New System.Drawing.Point(805, 153)
        Me.btnEntr.Name = "btnEntr"
        Me.btnEntr.Size = New System.Drawing.Size(131, 53)
        Me.btnEntr.TabIndex = 11
        Me.btnEntr.Text = "Gérer les entreprises"
        Me.btnEntr.UseVisualStyleBackColor = False
        '
        'btnAction
        '
        Me.btnAction.BackColor = System.Drawing.Color.White
        Me.btnAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAction.Location = New System.Drawing.Point(805, 212)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(131, 49)
        Me.btnAction.TabIndex = 12
        Me.btnAction.Text = "Gérer les actions"
        Me.btnAction.UseVisualStyleBackColor = False
        '
        'dgvContact
        '
        Me.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContact.Location = New System.Drawing.Point(12, 53)
        Me.dgvContact.Name = "dgvContact"
        Me.dgvContact.Size = New System.Drawing.Size(787, 315)
        Me.dgvContact.TabIndex = 13
        '
        'BtnContactRetour
        '
        Me.BtnContactRetour.BackColor = System.Drawing.Color.White
        Me.BtnContactRetour.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnContactRetour.Location = New System.Drawing.Point(834, 397)
        Me.BtnContactRetour.Name = "BtnContactRetour"
        Me.BtnContactRetour.Size = New System.Drawing.Size(93, 38)
        Me.BtnContactRetour.TabIndex = 14
        Me.BtnContactRetour.Text = "Retour"
        Me.BtnContactRetour.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(805, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 53)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Actualiser"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(939, 447)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnContactRetour)
        Me.Controls.Add(Me.dgvContact)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.btnEntr)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.lblContact)
        Me.Name = "formContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact"
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents btnEntr As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents dgvContact As System.Windows.Forms.DataGridView
    Friend WithEvents BtnContactRetour As Button
    Friend WithEvents Button1 As Button
End Class
