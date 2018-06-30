<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSupprProd
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboSuppr = New System.Windows.Forms.ComboBox()
        Me.lblSuppr = New System.Windows.Forms.Label()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.IdProdSuppr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboSuppr
        '
        Me.cboSuppr.FormattingEnabled = True
        Me.cboSuppr.Location = New System.Drawing.Point(105, 47)
        Me.cboSuppr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSuppr.Name = "cboSuppr"
        Me.cboSuppr.Size = New System.Drawing.Size(140, 25)
        Me.cboSuppr.TabIndex = 0
        '
        'lblSuppr
        '
        Me.lblSuppr.AutoSize = True
        Me.lblSuppr.ForeColor = System.Drawing.Color.White
        Me.lblSuppr.Location = New System.Drawing.Point(12, 50)
        Me.lblSuppr.Name = "lblSuppr"
        Me.lblSuppr.Size = New System.Drawing.Size(87, 17)
        Me.lblSuppr.TabIndex = 1
        Me.lblSuppr.Text = "Libellé produit"
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Location = New System.Drawing.Point(116, 80)
        Me.btnSuppr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(113, 30)
        Me.btnSuppr.TabIndex = 2
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'IdProdSuppr
        '
        Me.IdProdSuppr.Location = New System.Drawing.Point(12, 146)
        Me.IdProdSuppr.Name = "IdProdSuppr"
        Me.IdProdSuppr.Size = New System.Drawing.Size(140, 24)
        Me.IdProdSuppr.TabIndex = 3
        Me.IdProdSuppr.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Supprimer un produit"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(248, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formSupprProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(341, 182)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdProdSuppr)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.lblSuppr)
        Me.Controls.Add(Me.cboSuppr)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formSupprProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer un produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSuppr As System.Windows.Forms.ComboBox
    Friend WithEvents lblSuppr As System.Windows.Forms.Label
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents IdProdSuppr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
