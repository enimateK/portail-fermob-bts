<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAction
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
        Me.btnAjoutAction = New System.Windows.Forms.Button()
        Me.btnSupprAction = New System.Windows.Forms.Button()
        Me.btnModifAction = New System.Windows.Forms.Button()
        Me.dgvVisuAction = New System.Windows.Forms.DataGridView()
        Me.btnTypeAction = New System.Windows.Forms.Button()
        Me.btnActu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvVisuAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAjoutAction
        '
        Me.btnAjoutAction.BackColor = System.Drawing.Color.White
        Me.btnAjoutAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAjoutAction.Location = New System.Drawing.Point(92, 363)
        Me.btnAjoutAction.Name = "btnAjoutAction"
        Me.btnAjoutAction.Size = New System.Drawing.Size(161, 44)
        Me.btnAjoutAction.TabIndex = 0
        Me.btnAjoutAction.Text = "Ajouter une action"
        Me.btnAjoutAction.UseVisualStyleBackColor = False
        '
        'btnSupprAction
        '
        Me.btnSupprAction.BackColor = System.Drawing.Color.White
        Me.btnSupprAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupprAction.Location = New System.Drawing.Point(489, 363)
        Me.btnSupprAction.Name = "btnSupprAction"
        Me.btnSupprAction.Size = New System.Drawing.Size(161, 44)
        Me.btnSupprAction.TabIndex = 1
        Me.btnSupprAction.Text = "Supprimer une action"
        Me.btnSupprAction.UseVisualStyleBackColor = False
        '
        'btnModifAction
        '
        Me.btnModifAction.BackColor = System.Drawing.Color.White
        Me.btnModifAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifAction.Location = New System.Drawing.Point(296, 363)
        Me.btnModifAction.Name = "btnModifAction"
        Me.btnModifAction.Size = New System.Drawing.Size(161, 44)
        Me.btnModifAction.TabIndex = 2
        Me.btnModifAction.Text = "Modifier une action"
        Me.btnModifAction.UseVisualStyleBackColor = False
        '
        'dgvVisuAction
        '
        Me.dgvVisuAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVisuAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisuAction.Location = New System.Drawing.Point(12, 47)
        Me.dgvVisuAction.Name = "dgvVisuAction"
        Me.dgvVisuAction.Size = New System.Drawing.Size(807, 293)
        Me.dgvVisuAction.TabIndex = 3
        '
        'btnTypeAction
        '
        Me.btnTypeAction.BackColor = System.Drawing.Color.White
        Me.btnTypeAction.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypeAction.Location = New System.Drawing.Point(841, 161)
        Me.btnTypeAction.Name = "btnTypeAction"
        Me.btnTypeAction.Size = New System.Drawing.Size(101, 51)
        Me.btnTypeAction.TabIndex = 4
        Me.btnTypeAction.Text = "Type d'action"
        Me.btnTypeAction.UseVisualStyleBackColor = False
        '
        'btnActu
        '
        Me.btnActu.BackColor = System.Drawing.Color.White
        Me.btnActu.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActu.Location = New System.Drawing.Point(841, 47)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Size = New System.Drawing.Size(101, 50)
        Me.btnActu.TabIndex = 5
        Me.btnActu.Text = "Actualiser"
        Me.btnActu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Gestion des actions"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(841, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 465)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnActu)
        Me.Controls.Add(Me.btnTypeAction)
        Me.Controls.Add(Me.dgvVisuAction)
        Me.Controls.Add(Me.btnModifAction)
        Me.Controls.Add(Me.btnSupprAction)
        Me.Controls.Add(Me.btnAjoutAction)
        Me.Name = "formAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actions"
        CType(Me.dgvVisuAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAjoutAction As System.Windows.Forms.Button
    Friend WithEvents btnSupprAction As System.Windows.Forms.Button
    Friend WithEvents btnModifAction As System.Windows.Forms.Button
    Friend WithEvents dgvVisuAction As System.Windows.Forms.DataGridView
    Friend WithEvents btnTypeAction As System.Windows.Forms.Button
    Friend WithEvents btnActu As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
