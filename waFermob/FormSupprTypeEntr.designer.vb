<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupprTypeEntr
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
        Me.CboSupprTypeEntr = New System.Windows.Forms.ComboBox()
        Me.BtnSupprTypeEntr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CboSupprTypeEntr
        '
        Me.CboSupprTypeEntr.FormattingEnabled = True
        Me.CboSupprTypeEntr.Location = New System.Drawing.Point(43, 88)
        Me.CboSupprTypeEntr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CboSupprTypeEntr.Name = "CboSupprTypeEntr"
        Me.CboSupprTypeEntr.Size = New System.Drawing.Size(133, 25)
        Me.CboSupprTypeEntr.TabIndex = 0
        '
        'BtnSupprTypeEntr
        '
        Me.BtnSupprTypeEntr.BackColor = System.Drawing.Color.White
        Me.BtnSupprTypeEntr.Location = New System.Drawing.Point(60, 121)
        Me.BtnSupprTypeEntr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSupprTypeEntr.Name = "BtnSupprTypeEntr"
        Me.BtnSupprTypeEntr.Size = New System.Drawing.Size(102, 27)
        Me.BtnSupprTypeEntr.TabIndex = 1
        Me.BtnSupprTypeEntr.Text = "Suppression"
        Me.BtnSupprTypeEntr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Séléctionnez un type d'entreprise"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(263, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormSupprTypeEntr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 201)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSupprTypeEntr)
        Me.Controls.Add(Me.CboSupprTypeEntr)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSupprTypeEntr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer un type d'entreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboSupprTypeEntr As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSupprTypeEntr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
