<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTypeEnt
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
        Me.lblTypeEnt = New System.Windows.Forms.Label()
        Me.btnSupprTypeEnt = New System.Windows.Forms.Button()
        Me.btnAjoutTypeEnt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTypeEnt
        '
        Me.lblTypeEnt.AutoSize = True
        Me.lblTypeEnt.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeEnt.ForeColor = System.Drawing.Color.White
        Me.lblTypeEnt.Location = New System.Drawing.Point(82, 30)
        Me.lblTypeEnt.Name = "lblTypeEnt"
        Me.lblTypeEnt.Size = New System.Drawing.Size(253, 39)
        Me.lblTypeEnt.TabIndex = 5
        Me.lblTypeEnt.Text = "Type d'entreprise"
        '
        'btnSupprTypeEnt
        '
        Me.btnSupprTypeEnt.BackColor = System.Drawing.Color.White
        Me.btnSupprTypeEnt.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprTypeEnt.Location = New System.Drawing.Point(235, 94)
        Me.btnSupprTypeEnt.Name = "btnSupprTypeEnt"
        Me.btnSupprTypeEnt.Size = New System.Drawing.Size(109, 48)
        Me.btnSupprTypeEnt.TabIndex = 4
        Me.btnSupprTypeEnt.Text = "Supprimer"
        Me.btnSupprTypeEnt.UseVisualStyleBackColor = False
        '
        'btnAjoutTypeEnt
        '
        Me.btnAjoutTypeEnt.BackColor = System.Drawing.Color.White
        Me.btnAjoutTypeEnt.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjoutTypeEnt.Location = New System.Drawing.Point(54, 94)
        Me.btnAjoutTypeEnt.Name = "btnAjoutTypeEnt"
        Me.btnAjoutTypeEnt.Size = New System.Drawing.Size(119, 48)
        Me.btnAjoutTypeEnt.TabIndex = 3
        Me.btnAjoutTypeEnt.Text = "Ajouter"
        Me.btnAjoutTypeEnt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(300, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formTypeEnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 232)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTypeEnt)
        Me.Controls.Add(Me.btnSupprTypeEnt)
        Me.Controls.Add(Me.btnAjoutTypeEnt)
        Me.Name = "formTypeEnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type d'entreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTypeEnt As System.Windows.Forms.Label
    Friend WithEvents btnSupprTypeEnt As System.Windows.Forms.Button
    Friend WithEvents btnAjoutTypeEnt As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
