<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_qwirkle_menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_quitter = New System.Windows.Forms.Label()
        Me.bp_nouvelle_partie = New System.Windows.Forms.Button()
        Me.bp_aide = New System.Windows.Forms.Button()
        Me.bp_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qwirkle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_quitter
        '
        Me.btn_quitter.AutoSize = True
        Me.btn_quitter.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(839, 0)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(61, 71)
        Me.btn_quitter.TabIndex = 1
        Me.btn_quitter.Text = "X"
        '
        'bp_nouvelle_partie
        '
        Me.bp_nouvelle_partie.Location = New System.Drawing.Point(373, 168)
        Me.bp_nouvelle_partie.Name = "bp_nouvelle_partie"
        Me.bp_nouvelle_partie.Size = New System.Drawing.Size(129, 31)
        Me.bp_nouvelle_partie.TabIndex = 2
        Me.bp_nouvelle_partie.Text = "Nouvelle partie"
        Me.bp_nouvelle_partie.UseVisualStyleBackColor = True
        '
        'bp_aide
        '
        Me.bp_aide.Location = New System.Drawing.Point(373, 252)
        Me.bp_aide.Name = "bp_aide"
        Me.bp_aide.Size = New System.Drawing.Size(129, 31)
        Me.bp_aide.TabIndex = 3
        Me.bp_aide.Text = "Aide"
        Me.bp_aide.UseVisualStyleBackColor = True
        '
        'bp_quitter
        '
        Me.bp_quitter.Location = New System.Drawing.Point(373, 348)
        Me.bp_quitter.Name = "bp_quitter"
        Me.bp_quitter.Size = New System.Drawing.Size(129, 31)
        Me.bp_quitter.TabIndex = 4
        Me.bp_quitter.Text = "Quitter"
        Me.bp_quitter.UseVisualStyleBackColor = True
        '
        'frm_qwirkle_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.bp_quitter)
        Me.Controls.Add(Me.bp_aide)
        Me.Controls.Add(Me.bp_nouvelle_partie)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_qwirkle_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_quitter As Label
    Friend WithEvents bp_nouvelle_partie As Button
    Friend WithEvents bp_aide As Button
    Friend WithEvents bp_quitter As Button
End Class
