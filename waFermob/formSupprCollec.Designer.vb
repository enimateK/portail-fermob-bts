<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSupprCollec
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
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.lblSuppr = New System.Windows.Forms.Label()
        Me.cboSuppr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppr.Location = New System.Drawing.Point(141, 94)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(121, 28)
        Me.btnSuppr.TabIndex = 8
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'lblSuppr
        '
        Me.lblSuppr.AutoSize = True
        Me.lblSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppr.ForeColor = System.Drawing.Color.White
        Me.lblSuppr.Location = New System.Drawing.Point(44, 52)
        Me.lblSuppr.Name = "lblSuppr"
        Me.lblSuppr.Size = New System.Drawing.Size(76, 21)
        Me.lblSuppr.TabIndex = 7
        Me.lblSuppr.Text = "Catégorie"
        '
        'cboSuppr
        '
        Me.cboSuppr.FormattingEnabled = True
        Me.cboSuppr.Location = New System.Drawing.Point(141, 54)
        Me.cboSuppr.Name = "cboSuppr"
        Me.cboSuppr.Size = New System.Drawing.Size(121, 21)
        Me.cboSuppr.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Supprimer une collection"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(280, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formSupprCollec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 229)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.lblSuppr)
        Me.Controls.Add(Me.cboSuppr)
        Me.Name = "formSupprCollec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer une collection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents lblSuppr As System.Windows.Forms.Label
    Friend WithEvents cboSuppr As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
