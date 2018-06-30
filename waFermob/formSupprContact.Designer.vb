<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupprContact
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
        Me.cboSupprNom = New System.Windows.Forms.ComboBox()
        Me.cboSupprPrenom = New System.Windows.Forms.ComboBox()
        Me.btnSupprCon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboSupprNom
        '
        Me.cboSupprNom.FormattingEnabled = True
        Me.cboSupprNom.Location = New System.Drawing.Point(145, 65)
        Me.cboSupprNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSupprNom.Name = "cboSupprNom"
        Me.cboSupprNom.Size = New System.Drawing.Size(140, 25)
        Me.cboSupprNom.TabIndex = 0
        '
        'cboSupprPrenom
        '
        Me.cboSupprPrenom.FormattingEnabled = True
        Me.cboSupprPrenom.Location = New System.Drawing.Point(145, 98)
        Me.cboSupprPrenom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSupprPrenom.Name = "cboSupprPrenom"
        Me.cboSupprPrenom.Size = New System.Drawing.Size(140, 25)
        Me.cboSupprPrenom.TabIndex = 1
        '
        'btnSupprCon
        '
        Me.btnSupprCon.BackColor = System.Drawing.Color.White
        Me.btnSupprCon.Location = New System.Drawing.Point(156, 131)
        Me.btnSupprCon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSupprCon.Name = "btnSupprCon"
        Me.btnSupprCon.Size = New System.Drawing.Size(119, 35)
        Me.btnSupprCon.TabIndex = 2
        Me.btnSupprCon.Text = "Supprimer"
        Me.btnSupprCon.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom du contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prenom du contact"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(118, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 26)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Supprimer un Contact"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(344, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 33)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormSupprContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(446, 274)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSupprCon)
        Me.Controls.Add(Me.cboSupprPrenom)
        Me.Controls.Add(Me.cboSupprNom)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSupprContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer un contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSupprNom As System.Windows.Forms.ComboBox
    Friend WithEvents cboSupprPrenom As System.Windows.Forms.ComboBox
    Friend WithEvents btnSupprCon As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
