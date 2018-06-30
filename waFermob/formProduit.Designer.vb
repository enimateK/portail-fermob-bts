<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProduit
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
        Me.lblProduit = New System.Windows.Forms.Label()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnCarac = New System.Windows.Forms.Button()
        Me.btnCollec = New System.Windows.Forms.Button()
        Me.btnCateg = New System.Windows.Forms.Button()
        Me.dgvProduit = New System.Windows.Forms.DataGridView()
        Me.btnActu = New System.Windows.Forms.Button()
        Me.BtnProdRetour = New System.Windows.Forms.Button()
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProduit
        '
        Me.lblProduit.AutoSize = True
        Me.lblProduit.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduit.ForeColor = System.Drawing.Color.White
        Me.lblProduit.Location = New System.Drawing.Point(12, 9)
        Me.lblProduit.Name = "lblProduit"
        Me.lblProduit.Size = New System.Drawing.Size(293, 39)
        Me.lblProduit.TabIndex = 0
        Me.lblProduit.Text = "Gestion des produits"
        '
        'btnAjout
        '
        Me.btnAjout.BackColor = System.Drawing.Color.White
        Me.btnAjout.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjout.Location = New System.Drawing.Point(12, 432)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(118, 62)
        Me.btnAjout.TabIndex = 1
        Me.btnAjout.Text = "Ajouter des produits"
        Me.btnAjout.UseVisualStyleBackColor = False
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppr.Location = New System.Drawing.Point(136, 433)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(118, 62)
        Me.btnSuppr.TabIndex = 2
        Me.btnSuppr.Text = "Supprimer des produits"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.White
        Me.btnModif.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(260, 433)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(118, 61)
        Me.btnModif.TabIndex = 3
        Me.btnModif.Text = "Modifier des produits"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnCarac
        '
        Me.btnCarac.BackColor = System.Drawing.Color.White
        Me.btnCarac.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarac.Location = New System.Drawing.Point(674, 275)
        Me.btnCarac.Name = "btnCarac"
        Me.btnCarac.Size = New System.Drawing.Size(137, 62)
        Me.btnCarac.TabIndex = 5
        Me.btnCarac.Text = "Caractéristiques"
        Me.btnCarac.UseVisualStyleBackColor = False
        '
        'btnCollec
        '
        Me.btnCollec.BackColor = System.Drawing.Color.White
        Me.btnCollec.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollec.Location = New System.Drawing.Point(674, 139)
        Me.btnCollec.Name = "btnCollec"
        Me.btnCollec.Size = New System.Drawing.Size(137, 62)
        Me.btnCollec.TabIndex = 6
        Me.btnCollec.Text = "Collections"
        Me.btnCollec.UseVisualStyleBackColor = False
        '
        'btnCateg
        '
        Me.btnCateg.BackColor = System.Drawing.Color.White
        Me.btnCateg.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCateg.Location = New System.Drawing.Point(674, 207)
        Me.btnCateg.Name = "btnCateg"
        Me.btnCateg.Size = New System.Drawing.Size(137, 62)
        Me.btnCateg.TabIndex = 7
        Me.btnCateg.Text = "Catégories"
        Me.btnCateg.UseVisualStyleBackColor = False
        '
        'dgvProduit
        '
        Me.dgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProduit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduit.Location = New System.Drawing.Point(12, 51)
        Me.dgvProduit.Name = "dgvProduit"
        Me.dgvProduit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProduit.Size = New System.Drawing.Size(620, 375)
        Me.dgvProduit.TabIndex = 8
        '
        'btnActu
        '
        Me.btnActu.BackColor = System.Drawing.Color.White
        Me.btnActu.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnActu.Location = New System.Drawing.Point(674, 51)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(137, 55)
        Me.btnActu.TabIndex = 9
        Me.btnActu.Text = "Actualiser"
        Me.btnActu.UseVisualStyleBackColor = False
        '
        'BtnProdRetour
        '
        Me.BtnProdRetour.BackColor = System.Drawing.Color.White
        Me.BtnProdRetour.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnProdRetour.Location = New System.Drawing.Point(674, 432)
        Me.BtnProdRetour.Name = "BtnProdRetour"
        Me.BtnProdRetour.Size = New System.Drawing.Size(137, 61)
        Me.BtnProdRetour.TabIndex = 10
        Me.BtnProdRetour.Text = "Retour"
        Me.BtnProdRetour.UseVisualStyleBackColor = False
        '
        'formProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 506)
        Me.Controls.Add(Me.BtnProdRetour)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.dgvProduit)
        Me.Controls.Add(Me.btnCateg)
        Me.Controls.Add(Me.btnCollec)
        Me.Controls.Add(Me.btnCarac)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.lblProduit)
        Me.Name = "formProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produit"
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProduit As System.Windows.Forms.Label
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnCarac As System.Windows.Forms.Button
    Friend WithEvents btnCollec As System.Windows.Forms.Button
    Friend WithEvents btnCateg As System.Windows.Forms.Button
    Friend WithEvents dgvProduit As System.Windows.Forms.DataGridView
    Friend WithEvents btnActu As System.Windows.Forms.Button
    Friend WithEvents BtnProdRetour As Button
End Class
