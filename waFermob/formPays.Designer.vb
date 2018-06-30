<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPays
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
        Me.dgvPays = New System.Windows.Forms.DataGridView()
        Me.btnAjoutPays = New System.Windows.Forms.Button()
        Me.btnSupprPays = New System.Windows.Forms.Button()
        Me.btnModifPays = New System.Windows.Forms.Button()
        Me.btnActu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvPays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPays
        '
        Me.dgvPays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPays.Location = New System.Drawing.Point(0, 0)
        Me.dgvPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPays.Name = "dgvPays"
        Me.dgvPays.Size = New System.Drawing.Size(285, 297)
        Me.dgvPays.TabIndex = 0
        '
        'btnAjoutPays
        '
        Me.btnAjoutPays.BackColor = System.Drawing.Color.White
        Me.btnAjoutPays.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjoutPays.Location = New System.Drawing.Point(324, 85)
        Me.btnAjoutPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAjoutPays.Name = "btnAjoutPays"
        Me.btnAjoutPays.Size = New System.Drawing.Size(140, 40)
        Me.btnAjoutPays.TabIndex = 1
        Me.btnAjoutPays.Text = "Ajouter"
        Me.btnAjoutPays.UseVisualStyleBackColor = False
        '
        'btnSupprPays
        '
        Me.btnSupprPays.BackColor = System.Drawing.Color.White
        Me.btnSupprPays.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupprPays.Location = New System.Drawing.Point(324, 133)
        Me.btnSupprPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSupprPays.Name = "btnSupprPays"
        Me.btnSupprPays.Size = New System.Drawing.Size(140, 40)
        Me.btnSupprPays.TabIndex = 2
        Me.btnSupprPays.Text = "Supprimer"
        Me.btnSupprPays.UseVisualStyleBackColor = False
        '
        'btnModifPays
        '
        Me.btnModifPays.BackColor = System.Drawing.Color.White
        Me.btnModifPays.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifPays.Location = New System.Drawing.Point(324, 181)
        Me.btnModifPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModifPays.Name = "btnModifPays"
        Me.btnModifPays.Size = New System.Drawing.Size(140, 40)
        Me.btnModifPays.TabIndex = 3
        Me.btnModifPays.Text = "Modifier"
        Me.btnModifPays.UseVisualStyleBackColor = False
        '
        'btnActu
        '
        Me.btnActu.BackColor = System.Drawing.Color.White
        Me.btnActu.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActu.Location = New System.Drawing.Point(324, 0)
        Me.btnActu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(140, 47)
        Me.btnActu.TabIndex = 4
        Me.btnActu.Text = "Actualiser"
        Me.btnActu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(424, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formPays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.btnModifPays)
        Me.Controls.Add(Me.btnSupprPays)
        Me.Controls.Add(Me.btnAjoutPays)
        Me.Controls.Add(Me.dgvPays)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formPays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pays"
        CType(Me.dgvPays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPays As System.Windows.Forms.DataGridView
    Friend WithEvents btnAjoutPays As System.Windows.Forms.Button
    Friend WithEvents btnSupprPays As System.Windows.Forms.Button
    Friend WithEvents btnModifPays As System.Windows.Forms.Button
    Friend WithEvents btnActu As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
