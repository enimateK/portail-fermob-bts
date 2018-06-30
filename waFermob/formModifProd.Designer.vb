<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formModifProd
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
        Me.cboProd = New System.Windows.Forms.ComboBox()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblLibelle = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.cboCollection = New System.Windows.Forms.ComboBox()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.lblCollection = New System.Windows.Forms.Label()
        Me.lblCateg = New System.Windows.Forms.Label()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblModif = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboProd
        '
        Me.cboProd.FormattingEnabled = True
        Me.cboProd.Location = New System.Drawing.Point(169, 125)
        Me.cboProd.Name = "cboProd"
        Me.cboProd.Size = New System.Drawing.Size(120, 21)
        Me.cboProd.TabIndex = 0
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.ForeColor = System.Drawing.Color.White
        Me.lblProd.Location = New System.Drawing.Point(12, 123)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(137, 21)
        Me.lblProd.TabIndex = 1
        Me.lblProd.Text = "Produit à modifier"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(387, 86)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(120, 20)
        Me.txtNom.TabIndex = 2
        '
        'lblLibelle
        '
        Me.lblLibelle.AutoSize = True
        Me.lblLibelle.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibelle.ForeColor = System.Drawing.Color.White
        Me.lblLibelle.Location = New System.Drawing.Point(314, 84)
        Me.lblLibelle.Name = "lblLibelle"
        Me.lblLibelle.Size = New System.Drawing.Size(44, 21)
        Me.lblLibelle.TabIndex = 3
        Me.lblLibelle.Text = "Nom"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(387, 203)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(120, 93)
        Me.txtDesc.TabIndex = 4
        Me.txtDesc.Text = ""
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(387, 148)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(120, 20)
        Me.txtPrix.TabIndex = 5
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.ForeColor = System.Drawing.Color.White
        Me.lblPrix.Location = New System.Drawing.Point(314, 145)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(39, 21)
        Me.lblPrix.TabIndex = 6
        Me.lblPrix.Text = "Prix"
        '
        'cboCollection
        '
        Me.cboCollection.FormattingEnabled = True
        Me.cboCollection.Location = New System.Drawing.Point(665, 86)
        Me.cboCollection.Name = "cboCollection"
        Me.cboCollection.Size = New System.Drawing.Size(121, 21)
        Me.cboCollection.TabIndex = 8
        '
        'cboCateg
        '
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Location = New System.Drawing.Point(665, 147)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(121, 21)
        Me.cboCateg.TabIndex = 9
        '
        'lblCollection
        '
        Me.lblCollection.AutoSize = True
        Me.lblCollection.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollection.ForeColor = System.Drawing.Color.White
        Me.lblCollection.Location = New System.Drawing.Point(560, 84)
        Me.lblCollection.Name = "lblCollection"
        Me.lblCollection.Size = New System.Drawing.Size(81, 21)
        Me.lblCollection.TabIndex = 10
        Me.lblCollection.Text = "Collection"
        '
        'lblCateg
        '
        Me.lblCateg.AutoSize = True
        Me.lblCateg.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateg.ForeColor = System.Drawing.Color.White
        Me.lblCateg.Location = New System.Drawing.Point(560, 145)
        Me.lblCateg.Name = "lblCateg"
        Me.lblCateg.Size = New System.Drawing.Size(76, 21)
        Me.lblCateg.TabIndex = 11
        Me.lblCateg.Text = "Catégorie"
        '
        'btnValid
        '
        Me.btnValid.BackColor = System.Drawing.Color.White
        Me.btnValid.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValid.Location = New System.Drawing.Point(665, 203)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(121, 43)
        Me.btnValid.TabIndex = 12
        Me.btnValid.Text = "Valider"
        Me.btnValid.UseVisualStyleBackColor = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(266, 235)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(92, 21)
        Me.lblDesc.TabIndex = 13
        Me.lblDesc.Text = "Description"
        '
        'lblModif
        '
        Me.lblModif.AutoSize = True
        Me.lblModif.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModif.ForeColor = System.Drawing.Color.White
        Me.lblModif.Location = New System.Drawing.Point(38, 40)
        Me.lblModif.Name = "lblModif"
        Me.lblModif.Size = New System.Drawing.Size(285, 39)
        Me.lblModif.TabIndex = 14
        Me.lblModif.Text = "Modifier un produit"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(688, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formModifProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 367)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblModif)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnValid)
        Me.Controls.Add(Me.lblCateg)
        Me.Controls.Add(Me.lblCollection)
        Me.Controls.Add(Me.cboCateg)
        Me.Controls.Add(Me.cboCollection)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblLibelle)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.cboProd)
        Me.Name = "formModifProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier un produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProd As System.Windows.Forms.ComboBox
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblLibelle As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents lblPrix As System.Windows.Forms.Label
    Friend WithEvents cboCollection As System.Windows.Forms.ComboBox
    Friend WithEvents cboCateg As System.Windows.Forms.ComboBox
    Friend WithEvents lblCollection As System.Windows.Forms.Label
    Friend WithEvents lblCateg As System.Windows.Forms.Label
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblModif As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
