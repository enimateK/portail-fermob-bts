<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarac
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
        Me.lblCarac = New System.Windows.Forms.Label()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCarac
        '
        Me.lblCarac.AutoSize = True
        Me.lblCarac.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarac.Location = New System.Drawing.Point(111, 18)
        Me.lblCarac.Name = "lblCarac"
        Me.lblCarac.Size = New System.Drawing.Size(234, 39)
        Me.lblCarac.TabIndex = 8
        Me.lblCarac.Text = "Caractéristiques"
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppr.ForeColor = System.Drawing.Color.Black
        Me.btnSuppr.Location = New System.Drawing.Point(254, 77)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(120, 61)
        Me.btnSuppr.TabIndex = 7
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'btnAjout
        '
        Me.btnAjout.BackColor = System.Drawing.Color.White
        Me.btnAjout.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjout.ForeColor = System.Drawing.Color.Black
        Me.btnAjout.Location = New System.Drawing.Point(58, 77)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(120, 61)
        Me.btnAjout.TabIndex = 6
        Me.btnAjout.Text = "Ajouter"
        Me.btnAjout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(331, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 36)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formCarac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 246)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCarac)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "formCarac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formCarac"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCarac As System.Windows.Forms.Label
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
