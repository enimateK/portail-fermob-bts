<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifPays
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
        Me.cboPays = New System.Windows.Forms.ComboBox()
        Me.txtCodePays = New System.Windows.Forms.TextBox()
        Me.txtLibPays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPays
        '
        Me.cboPays.FormattingEnabled = True
        Me.cboPays.Location = New System.Drawing.Point(304, 27)
        Me.cboPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPays.Name = "cboPays"
        Me.cboPays.Size = New System.Drawing.Size(116, 25)
        Me.cboPays.TabIndex = 0
        '
        'txtCodePays
        '
        Me.txtCodePays.Location = New System.Drawing.Point(118, 89)
        Me.txtCodePays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodePays.Name = "txtCodePays"
        Me.txtCodePays.Size = New System.Drawing.Size(116, 24)
        Me.txtCodePays.TabIndex = 1
        '
        'txtLibPays
        '
        Me.txtLibPays.Location = New System.Drawing.Point(118, 121)
        Me.txtLibPays.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLibPays.Name = "txtLibPays"
        Me.txtLibPays.Size = New System.Drawing.Size(116, 24)
        Me.txtLibPays.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Code Pays"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Libellé Pays"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(118, 165)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Modifier le pays"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Veuillez séléctionner le pays a modifier"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(401, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormModifPays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 219)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLibPays)
        Me.Controls.Add(Me.txtCodePays)
        Me.Controls.Add(Me.cboPays)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormModifPays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormModifPays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPays As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodePays As System.Windows.Forms.TextBox
    Friend WithEvents txtLibPays As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
End Class
