<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupprAction
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
        Me.BtnSupprAction = New System.Windows.Forms.Button()
        Me.CboSupprPrenomContact = New System.Windows.Forms.ComboBox()
        Me.CboSupprNomContact = New System.Windows.Forms.ComboBox()
        Me.dgvSupprAction = New System.Windows.Forms.DataGridView()
        Me.btnChoixContact = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvSupprAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSupprAction
        '
        Me.BtnSupprAction.BackColor = System.Drawing.Color.White
        Me.BtnSupprAction.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSupprAction.Location = New System.Drawing.Point(255, 327)
        Me.BtnSupprAction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSupprAction.Name = "BtnSupprAction"
        Me.BtnSupprAction.Size = New System.Drawing.Size(200, 39)
        Me.BtnSupprAction.TabIndex = 1
        Me.BtnSupprAction.Text = "Suppression"
        Me.BtnSupprAction.UseVisualStyleBackColor = False
        '
        'CboSupprPrenomContact
        '
        Me.CboSupprPrenomContact.FormattingEnabled = True
        Me.CboSupprPrenomContact.Location = New System.Drawing.Point(216, 59)
        Me.CboSupprPrenomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CboSupprPrenomContact.Name = "CboSupprPrenomContact"
        Me.CboSupprPrenomContact.Size = New System.Drawing.Size(143, 25)
        Me.CboSupprPrenomContact.TabIndex = 2
        '
        'CboSupprNomContact
        '
        Me.CboSupprNomContact.FormattingEnabled = True
        Me.CboSupprNomContact.Location = New System.Drawing.Point(50, 59)
        Me.CboSupprNomContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CboSupprNomContact.Name = "CboSupprNomContact"
        Me.CboSupprNomContact.Size = New System.Drawing.Size(137, 25)
        Me.CboSupprNomContact.TabIndex = 4
        '
        'dgvSupprAction
        '
        Me.dgvSupprAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSupprAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupprAction.Location = New System.Drawing.Point(34, 96)
        Me.dgvSupprAction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSupprAction.Name = "dgvSupprAction"
        Me.dgvSupprAction.Size = New System.Drawing.Size(642, 223)
        Me.dgvSupprAction.TabIndex = 5
        '
        'btnChoixContact
        '
        Me.btnChoixContact.BackColor = System.Drawing.Color.White
        Me.btnChoixContact.Location = New System.Drawing.Point(393, 52)
        Me.btnChoixContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChoixContact.Name = "btnChoixContact"
        Me.btnChoixContact.Size = New System.Drawing.Size(158, 36)
        Me.btnChoixContact.TabIndex = 6
        Me.btnChoixContact.Text = "Générer les Actions"
        Me.btnChoixContact.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Prénom Contact"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(655, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormSupprAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChoixContact)
        Me.Controls.Add(Me.dgvSupprAction)
        Me.Controls.Add(Me.CboSupprNomContact)
        Me.Controls.Add(Me.CboSupprPrenomContact)
        Me.Controls.Add(Me.BtnSupprAction)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSupprAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSupprAction"
        CType(Me.dgvSupprAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSupprAction As System.Windows.Forms.Button
    Friend WithEvents CboSupprPrenomContact As System.Windows.Forms.ComboBox
    Friend WithEvents CboSupprNomContact As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSupprAction As System.Windows.Forms.DataGridView
    Friend WithEvents btnChoixContact As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
