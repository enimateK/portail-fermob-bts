<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formModifAction
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
        Me.btnChoixContact = New System.Windows.Forms.Button()
        Me.dgvModifAction = New System.Windows.Forms.DataGridView()
        Me.CboNomContact = New System.Windows.Forms.ComboBox()
        Me.CboPrenomContact = New System.Windows.Forms.ComboBox()
        Me.BtnModifAction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvModifAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChoixContact
        '
        Me.btnChoixContact.BackColor = System.Drawing.Color.White
        Me.btnChoixContact.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnChoixContact.Location = New System.Drawing.Point(352, 53)
        Me.btnChoixContact.Name = "btnChoixContact"
        Me.btnChoixContact.Size = New System.Drawing.Size(102, 32)
        Me.btnChoixContact.TabIndex = 11
        Me.btnChoixContact.Text = "Valider"
        Me.btnChoixContact.UseVisualStyleBackColor = False
        '
        'dgvModifAction
        '
        Me.dgvModifAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvModifAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModifAction.Location = New System.Drawing.Point(43, 100)
        Me.dgvModifAction.Name = "dgvModifAction"
        Me.dgvModifAction.Size = New System.Drawing.Size(481, 186)
        Me.dgvModifAction.TabIndex = 10
        '
        'CboNomContact
        '
        Me.CboNomContact.FormattingEnabled = True
        Me.CboNomContact.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CboNomContact.Location = New System.Drawing.Point(57, 59)
        Me.CboNomContact.Name = "CboNomContact"
        Me.CboNomContact.Size = New System.Drawing.Size(126, 21)
        Me.CboNomContact.TabIndex = 9
        '
        'CboPrenomContact
        '
        Me.CboPrenomContact.FormattingEnabled = True
        Me.CboPrenomContact.Location = New System.Drawing.Point(210, 59)
        Me.CboPrenomContact.Name = "CboPrenomContact"
        Me.CboPrenomContact.Size = New System.Drawing.Size(111, 21)
        Me.CboPrenomContact.TabIndex = 8
        '
        'BtnModifAction
        '
        Me.BtnModifAction.BackColor = System.Drawing.Color.White
        Me.BtnModifAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModifAction.Location = New System.Drawing.Point(194, 292)
        Me.BtnModifAction.Name = "BtnModifAction"
        Me.BtnModifAction.Size = New System.Drawing.Size(168, 41)
        Me.BtnModifAction.TabIndex = 7
        Me.BtnModifAction.Text = "Modification"
        Me.BtnModifAction.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Prenom du contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nom du contact"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(509, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formModifAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 389)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChoixContact)
        Me.Controls.Add(Me.dgvModifAction)
        Me.Controls.Add(Me.CboNomContact)
        Me.Controls.Add(Me.CboPrenomContact)
        Me.Controls.Add(Me.BtnModifAction)
        Me.Name = "formModifAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier une action"
        CType(Me.dgvModifAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChoixContact As System.Windows.Forms.Button
    Friend WithEvents dgvModifAction As System.Windows.Forms.DataGridView
    Friend WithEvents CboNomContact As System.Windows.Forms.ComboBox
    Friend WithEvents CboPrenomContact As System.Windows.Forms.ComboBox
    Friend WithEvents BtnModifAction As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
