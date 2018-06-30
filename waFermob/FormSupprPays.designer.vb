<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupprPays
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
        Me.CboSupprPays = New System.Windows.Forms.ComboBox()
        Me.BtnSupprPays = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CboSupprPays
        '
        Me.CboSupprPays.FormattingEnabled = True
        Me.CboSupprPays.Location = New System.Drawing.Point(150, 64)
        Me.CboSupprPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CboSupprPays.Name = "CboSupprPays"
        Me.CboSupprPays.Size = New System.Drawing.Size(142, 25)
        Me.CboSupprPays.TabIndex = 0
        '
        'BtnSupprPays
        '
        Me.BtnSupprPays.BackColor = System.Drawing.Color.White
        Me.BtnSupprPays.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSupprPays.Location = New System.Drawing.Point(165, 97)
        Me.BtnSupprPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSupprPays.Name = "BtnSupprPays"
        Me.BtnSupprPays.Size = New System.Drawing.Size(116, 30)
        Me.BtnSupprPays.TabIndex = 1
        Me.BtnSupprPays.Text = "Suppression"
        Me.BtnSupprPays.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-4, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selectionnez un pays"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supprimer un Pays"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(254, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormSupprPays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 209)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSupprPays)
        Me.Controls.Add(Me.CboSupprPays)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSupprPays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer un pays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboSupprPays As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSupprPays As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
