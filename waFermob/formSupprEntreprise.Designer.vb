<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupprEntreprise
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
        Me.cboSupprEnt = New System.Windows.Forms.ComboBox()
        Me.btnSupprEntr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSupprEnt
        '
        Me.cboSupprEnt.FormattingEnabled = True
        Me.cboSupprEnt.Location = New System.Drawing.Point(183, 54)
        Me.cboSupprEnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSupprEnt.Name = "cboSupprEnt"
        Me.cboSupprEnt.Size = New System.Drawing.Size(140, 25)
        Me.cboSupprEnt.TabIndex = 0
        '
        'btnSupprEntr
        '
        Me.btnSupprEntr.BackColor = System.Drawing.Color.White
        Me.btnSupprEntr.Location = New System.Drawing.Point(137, 87)
        Me.btnSupprEntr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSupprEntr.Name = "btnSupprEntr"
        Me.btnSupprEntr.Size = New System.Drawing.Size(116, 35)
        Me.btnSupprEntr.TabIndex = 1
        Me.btnSupprEntr.Text = "Suppression"
        Me.btnSupprEntr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Raison sociale"
        '
        'FormSupprEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSupprEntr)
        Me.Controls.Add(Me.cboSupprEnt)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSupprEntreprise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer une entreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSupprEnt As System.Windows.Forms.ComboBox
    Friend WithEvents btnSupprEntr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
