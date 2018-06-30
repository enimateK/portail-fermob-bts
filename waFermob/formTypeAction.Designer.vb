<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTypeAction
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
        Me.lblTypeAction = New System.Windows.Forms.Label()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTypeAction
        '
        Me.lblTypeAction.AutoSize = True
        Me.lblTypeAction.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeAction.ForeColor = System.Drawing.Color.White
        Me.lblTypeAction.Location = New System.Drawing.Point(94, 24)
        Me.lblTypeAction.Name = "lblTypeAction"
        Me.lblTypeAction.Size = New System.Drawing.Size(199, 39)
        Me.lblTypeAction.TabIndex = 11
        Me.lblTypeAction.Text = "Type d'action"
        '
        'btnAjout
        '
        Me.btnAjout.BackColor = System.Drawing.Color.White
        Me.btnAjout.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjout.Location = New System.Drawing.Point(42, 82)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(120, 61)
        Me.btnAjout.TabIndex = 9
        Me.btnAjout.Text = "Ajouter"
        Me.btnAjout.UseVisualStyleBackColor = False
        '
        'btnSuppr
        '
        Me.btnSuppr.BackColor = System.Drawing.Color.White
        Me.btnSuppr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppr.Location = New System.Drawing.Point(226, 82)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(120, 61)
        Me.btnSuppr.TabIndex = 10
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(282, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formTypeAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 230)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTypeAction)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnAjout)
        Me.Name = "formTypeAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type d'action"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTypeAction As System.Windows.Forms.Label
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As Button
    Friend WithEvents Button1 As Button
End Class
