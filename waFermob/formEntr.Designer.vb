<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntr
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
        Me.btnAjoutEntr = New System.Windows.Forms.Button()
        Me.btnSupprEntr = New System.Windows.Forms.Button()
        Me.btnModifEntr = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnPays = New System.Windows.Forms.Button()
        Me.dgvVisuEntr = New System.Windows.Forms.DataGridView()
        Me.btnActu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvVisuEntr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAjoutEntr
        '
        Me.btnAjoutEntr.BackColor = System.Drawing.Color.White
        Me.btnAjoutEntr.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjoutEntr.Location = New System.Drawing.Point(82, 341)
        Me.btnAjoutEntr.Name = "btnAjoutEntr"
        Me.btnAjoutEntr.Size = New System.Drawing.Size(149, 51)
        Me.btnAjoutEntr.TabIndex = 0
        Me.btnAjoutEntr.Text = "Ajouter une entreprise"
        Me.btnAjoutEntr.UseVisualStyleBackColor = False
        '
        'btnSupprEntr
        '
        Me.btnSupprEntr.BackColor = System.Drawing.Color.White
        Me.btnSupprEntr.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupprEntr.Location = New System.Drawing.Point(430, 341)
        Me.btnSupprEntr.Name = "btnSupprEntr"
        Me.btnSupprEntr.Size = New System.Drawing.Size(149, 51)
        Me.btnSupprEntr.TabIndex = 1
        Me.btnSupprEntr.Text = "Supprimer une entreprise"
        Me.btnSupprEntr.UseVisualStyleBackColor = False
        '
        'btnModifEntr
        '
        Me.btnModifEntr.BackColor = System.Drawing.Color.White
        Me.btnModifEntr.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifEntr.Location = New System.Drawing.Point(257, 341)
        Me.btnModifEntr.Name = "btnModifEntr"
        Me.btnModifEntr.Size = New System.Drawing.Size(149, 51)
        Me.btnModifEntr.TabIndex = 2
        Me.btnModifEntr.Text = "Modifier une entreprise"
        Me.btnModifEntr.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(673, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 48)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Type d'entreprise"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnPays
        '
        Me.btnPays.BackColor = System.Drawing.Color.White
        Me.btnPays.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPays.Location = New System.Drawing.Point(673, 105)
        Me.btnPays.Name = "btnPays"
        Me.btnPays.Size = New System.Drawing.Size(126, 46)
        Me.btnPays.TabIndex = 4
        Me.btnPays.Text = "Pays"
        Me.btnPays.UseVisualStyleBackColor = False
        '
        'dgvVisuEntr
        '
        Me.dgvVisuEntr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVisuEntr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisuEntr.Location = New System.Drawing.Point(12, 0)
        Me.dgvVisuEntr.Name = "dgvVisuEntr"
        Me.dgvVisuEntr.Size = New System.Drawing.Size(653, 335)
        Me.dgvVisuEntr.TabIndex = 5
        '
        'btnActu
        '
        Me.btnActu.BackColor = System.Drawing.Color.White
        Me.btnActu.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActu.Location = New System.Drawing.Point(673, 12)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(126, 35)
        Me.btnActu.TabIndex = 6
        Me.btnActu.Text = "Actualiser"
        Me.btnActu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(697, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 51)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormEntr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.dgvVisuEntr)
        Me.Controls.Add(Me.btnPays)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnModifEntr)
        Me.Controls.Add(Me.btnSupprEntr)
        Me.Controls.Add(Me.btnAjoutEntr)
        Me.Name = "FormEntr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entreprise"
        CType(Me.dgvVisuEntr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAjoutEntr As System.Windows.Forms.Button
    Friend WithEvents btnSupprEntr As System.Windows.Forms.Button
    Friend WithEvents btnModifEntr As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnPays As System.Windows.Forms.Button
    Friend WithEvents dgvVisuEntr As System.Windows.Forms.DataGridView
    Friend WithEvents btnActu As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
