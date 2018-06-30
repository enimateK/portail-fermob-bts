<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btnProd = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProd
        '
        Me.btnProd.BackColor = System.Drawing.Color.White
        Me.btnProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnProd.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProd.Location = New System.Drawing.Point(152, 151)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(210, 98)
        Me.btnProd.TabIndex = 0
        Me.btnProd.Text = "Gérer les produits"
        Me.btnProd.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(222, 24)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(470, 39)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Bienvenue sur le portail FERMOB"
        '
        'btnContact
        '
        Me.btnContact.BackColor = System.Drawing.Color.White
        Me.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.Location = New System.Drawing.Point(437, 151)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(198, 98)
        Me.btnContact.TabIndex = 2
        Me.btnContact.Text = "Gérer les contacts"
        Me.btnContact.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(753, 314)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.btnProd)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portail FERMOB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents btnContact As System.Windows.Forms.Button

End Class
