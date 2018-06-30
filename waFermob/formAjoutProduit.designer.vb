<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAjoutProduit
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
        Me.TxtLibelleProduit = New System.Windows.Forms.TextBox()
        Me.TxtDescProduit = New System.Windows.Forms.TextBox()
        Me.TxtPUProduit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCollection = New System.Windows.Forms.ComboBox()
        Me.cboCategorie = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoutonAjouter = New System.Windows.Forms.Button()
        Me.ChecklistCara = New System.Windows.Forms.CheckedListBox()
        Me.lblModif = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAjoutProdRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtLibelleProduit
        '
        Me.TxtLibelleProduit.Location = New System.Drawing.Point(173, 98)
        Me.TxtLibelleProduit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLibelleProduit.Name = "TxtLibelleProduit"
        Me.TxtLibelleProduit.Size = New System.Drawing.Size(137, 24)
        Me.TxtLibelleProduit.TabIndex = 1
        '
        'TxtDescProduit
        '
        Me.TxtDescProduit.Location = New System.Drawing.Point(173, 132)
        Me.TxtDescProduit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDescProduit.Name = "TxtDescProduit"
        Me.TxtDescProduit.Size = New System.Drawing.Size(137, 24)
        Me.TxtDescProduit.TabIndex = 2
        '
        'TxtPUProduit
        '
        Me.TxtPUProduit.Location = New System.Drawing.Point(173, 166)
        Me.TxtPUProduit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPUProduit.Name = "TxtPUProduit"
        Me.TxtPUProduit.Size = New System.Drawing.Size(137, 24)
        Me.TxtPUProduit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nom du Produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description du Produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prix a l'unité du Produit"
        '
        'cboCollection
        '
        Me.cboCollection.FormattingEnabled = True
        Me.cboCollection.Location = New System.Drawing.Point(173, 200)
        Me.cboCollection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCollection.Name = "cboCollection"
        Me.cboCollection.Size = New System.Drawing.Size(137, 25)
        Me.cboCollection.TabIndex = 9
        '
        'cboCategorie
        '
        Me.cboCategorie.FormattingEnabled = True
        Me.cboCategorie.Location = New System.Drawing.Point(173, 235)
        Me.cboCategorie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCategorie.Name = "cboCategorie"
        Me.cboCategorie.Size = New System.Drawing.Size(137, 25)
        Me.cboCategorie.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Collection"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Catégorie"
        '
        'BoutonAjouter
        '
        Me.BoutonAjouter.BackColor = System.Drawing.Color.White
        Me.BoutonAjouter.Location = New System.Drawing.Point(339, 331)
        Me.BoutonAjouter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BoutonAjouter.Name = "BoutonAjouter"
        Me.BoutonAjouter.Size = New System.Drawing.Size(143, 46)
        Me.BoutonAjouter.TabIndex = 4
        Me.BoutonAjouter.Text = "Ajouter le Produit"
        Me.BoutonAjouter.UseVisualStyleBackColor = False
        '
        'ChecklistCara
        '
        Me.ChecklistCara.FormattingEnabled = True
        Me.ChecklistCara.Location = New System.Drawing.Point(171, 278)
        Me.ChecklistCara.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChecklistCara.Name = "ChecklistCara"
        Me.ChecklistCara.Size = New System.Drawing.Size(139, 99)
        Me.ChecklistCara.TabIndex = 15
        '
        'lblModif
        '
        Me.lblModif.AutoSize = True
        Me.lblModif.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModif.ForeColor = System.Drawing.Color.White
        Me.lblModif.Location = New System.Drawing.Point(29, 22)
        Me.lblModif.Name = "lblModif"
        Me.lblModif.Size = New System.Drawing.Size(271, 39)
        Me.lblModif.TabIndex = 16
        Me.lblModif.Text = "Ajouter un produit"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(339, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Créer collection"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(339, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Créer catégorie"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAjoutProdRetour
        '
        Me.BtnAjoutProdRetour.BackColor = System.Drawing.Color.White
        Me.BtnAjoutProdRetour.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAjoutProdRetour.Location = New System.Drawing.Point(663, 391)
        Me.BtnAjoutProdRetour.Name = "BtnAjoutProdRetour"
        Me.BtnAjoutProdRetour.Size = New System.Drawing.Size(115, 46)
        Me.BtnAjoutProdRetour.TabIndex = 19
        Me.BtnAjoutProdRetour.Text = "Retour"
        Me.BtnAjoutProdRetour.UseVisualStyleBackColor = False
        '
        'formAjoutProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.BtnAjoutProdRetour)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblModif)
        Me.Controls.Add(Me.ChecklistCara)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCategorie)
        Me.Controls.Add(Me.cboCollection)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BoutonAjouter)
        Me.Controls.Add(Me.TxtPUProduit)
        Me.Controls.Add(Me.TxtDescProduit)
        Me.Controls.Add(Me.TxtLibelleProduit)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formAjoutProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter un produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLibelleProduit As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescProduit As System.Windows.Forms.TextBox
    Friend WithEvents TxtPUProduit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BoutonAjouter As System.Windows.Forms.Button
    Friend WithEvents ChecklistCara As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblModif As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnAjoutProdRetour As Button
    Private WithEvents cboCollection As ComboBox
End Class
