<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSupprCarac
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
        Me.btnSuppr.Location = New System.Drawing.Point(141, 83)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(121, 31)
        Me.btnSuppr.TabIndex = 8
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'lblSuppr
        '
        Me.lblSuppr.AutoSize = True
        Me.lblSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppr.ForeColor = System.Drawing.Color.White
        Me.lblSuppr.Location = New System.Drawing.Point(12, 54)
        Me.lblSuppr.Name = "lblSuppr"
        Me.lblSuppr.Size = New System.Drawing.Size(118, 21)
        Me.lblSuppr.TabIndex = 7
        Me.lblSuppr.Text = "Caractéristique"
        '
        'cboSuppr
        '
        Me.cboSuppr.FormattingEnabled = True
        Me.cboSuppr.Location = New System.Drawing.Point(141, 56)
        Me.cboSuppr.Name = "cboSuppr"
        Me.cboSuppr.Size = New System.Drawing.Size(121, 21)
        Me.cboSuppr.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Supprimer une caractéristique"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(292, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formSupprCarac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 240)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.lblSuppr)
        Me.Controls.Add(Me.cboSuppr)
        Me.Name = "formSupprCarac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer une caractéristique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents lblSuppr As System.Windows.Forms.Label
    Friend WithEvents cboSuppr As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
