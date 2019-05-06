<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plateau
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
        Me.bp_confirmer = New System.Windows.Forms.Button()
        Me.bp_recommencer = New System.Windows.Forms.Button()
        Me.bp_retour = New System.Windows.Forms.Button()
        Me.bp_aide = New System.Windows.Forms.Button()
        Me.bp_abandonner = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bp_confirmer
        '
        Me.bp_confirmer.Location = New System.Drawing.Point(38, 26)
        Me.bp_confirmer.Name = "bp_confirmer"
        Me.bp_confirmer.Size = New System.Drawing.Size(91, 32)
        Me.bp_confirmer.TabIndex = 0
        Me.bp_confirmer.Text = "Confirmer"
        Me.bp_confirmer.UseVisualStyleBackColor = True
        '
        'bp_recommencer
        '
        Me.bp_recommencer.Location = New System.Drawing.Point(38, 86)
        Me.bp_recommencer.Name = "bp_recommencer"
        Me.bp_recommencer.Size = New System.Drawing.Size(91, 32)
        Me.bp_recommencer.TabIndex = 1
        Me.bp_recommencer.Text = "Recommencer"
        Me.bp_recommencer.UseVisualStyleBackColor = True
        '
        'bp_retour
        '
        Me.bp_retour.Location = New System.Drawing.Point(38, 152)
        Me.bp_retour.Name = "bp_retour"
        Me.bp_retour.Size = New System.Drawing.Size(91, 32)
        Me.bp_retour.TabIndex = 2
        Me.bp_retour.Text = "Retour"
        Me.bp_retour.UseVisualStyleBackColor = True
        '
        'bp_aide
        '
        Me.bp_aide.Location = New System.Drawing.Point(38, 221)
        Me.bp_aide.Name = "bp_aide"
        Me.bp_aide.Size = New System.Drawing.Size(91, 32)
        Me.bp_aide.TabIndex = 3
        Me.bp_aide.Text = "Aide"
        Me.bp_aide.UseVisualStyleBackColor = True
        '
        'bp_abandonner
        '
        Me.bp_abandonner.Location = New System.Drawing.Point(38, 295)
        Me.bp_abandonner.Name = "bp_abandonner"
        Me.bp_abandonner.Size = New System.Drawing.Size(91, 32)
        Me.bp_abandonner.TabIndex = 4
        Me.bp_abandonner.Text = "Abandonner"
        Me.bp_abandonner.UseVisualStyleBackColor = True
        '
        'plateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bp_abandonner)
        Me.Controls.Add(Me.bp_aide)
        Me.Controls.Add(Me.bp_retour)
        Me.Controls.Add(Me.bp_recommencer)
        Me.Controls.Add(Me.bp_confirmer)
        Me.Name = "plateau"
        Me.Text = "plateau"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bp_confirmer As Button
    Friend WithEvents bp_recommencer As Button
    Friend WithEvents bp_retour As Button
    Friend WithEvents bp_aide As Button
    Friend WithEvents bp_abandonner As Button
End Class
