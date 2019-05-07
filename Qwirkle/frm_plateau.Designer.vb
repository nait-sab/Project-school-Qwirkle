<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_plateau
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bp_confirmer = New System.Windows.Forms.Button()
        Me.bp_recommencer = New System.Windows.Forms.Button()
        Me.bp_retour = New System.Windows.Forms.Button()
        Me.bp_aide = New System.Windows.Forms.Button()
        Me.bp_abandonner = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_tuile6 = New System.Windows.Forms.PictureBox()
        Me.pb_tuile5 = New System.Windows.Forms.PictureBox()
        Me.pb_tuile4 = New System.Windows.Forms.PictureBox()
        Me.pb_tuile3 = New System.Windows.Forms.PictureBox()
        Me.pb_tuile2 = New System.Windows.Forms.PictureBox()
        Me.pb_tuile1 = New System.Windows.Forms.PictureBox()
        Me.pb_pioche = New System.Windows.Forms.PictureBox()
        Me.dg_tableau_score = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_tuile6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tuile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tuile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tuile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tuile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tuile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_pioche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_tableau_score, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bp_confirmer
        '
        Me.bp_confirmer.Location = New System.Drawing.Point(2, 12)
        Me.bp_confirmer.Name = "bp_confirmer"
        Me.bp_confirmer.Size = New System.Drawing.Size(91, 32)
        Me.bp_confirmer.TabIndex = 0
        Me.bp_confirmer.Text = "Confirmer"
        Me.bp_confirmer.UseVisualStyleBackColor = True
        '
        'bp_recommencer
        '
        Me.bp_recommencer.Location = New System.Drawing.Point(2, 72)
        Me.bp_recommencer.Name = "bp_recommencer"
        Me.bp_recommencer.Size = New System.Drawing.Size(91, 32)
        Me.bp_recommencer.TabIndex = 1
        Me.bp_recommencer.Text = "Recommencer"
        Me.bp_recommencer.UseVisualStyleBackColor = True
        '
        'bp_retour
        '
        Me.bp_retour.Location = New System.Drawing.Point(2, 138)
        Me.bp_retour.Name = "bp_retour"
        Me.bp_retour.Size = New System.Drawing.Size(91, 32)
        Me.bp_retour.TabIndex = 2
        Me.bp_retour.Text = "Retour"
        Me.bp_retour.UseVisualStyleBackColor = True
        '
        'bp_aide
        '
        Me.bp_aide.Location = New System.Drawing.Point(2, 207)
        Me.bp_aide.Name = "bp_aide"
        Me.bp_aide.Size = New System.Drawing.Size(91, 32)
        Me.bp_aide.TabIndex = 3
        Me.bp_aide.Text = "Aide"
        Me.bp_aide.UseVisualStyleBackColor = True
        '
        'bp_abandonner
        '
        Me.bp_abandonner.Location = New System.Drawing.Point(2, 281)
        Me.bp_abandonner.Name = "bp_abandonner"
        Me.bp_abandonner.Size = New System.Drawing.Size(91, 32)
        Me.bp_abandonner.TabIndex = 4
        Me.bp_abandonner.Text = "Abandonner"
        Me.bp_abandonner.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pb_tuile6)
        Me.Panel1.Controls.Add(Me.pb_tuile5)
        Me.Panel1.Controls.Add(Me.pb_tuile4)
        Me.Panel1.Controls.Add(Me.pb_tuile3)
        Me.Panel1.Controls.Add(Me.pb_tuile2)
        Me.Panel1.Controls.Add(Me.pb_tuile1)
        Me.Panel1.Location = New System.Drawing.Point(22, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 53)
        Me.Panel1.TabIndex = 5
        '
        'pb_tuile6
        '
        Me.pb_tuile6.Location = New System.Drawing.Point(283, 0)
        Me.pb_tuile6.Name = "pb_tuile6"
        Me.pb_tuile6.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile6.TabIndex = 5
        Me.pb_tuile6.TabStop = False
        '
        'pb_tuile5
        '
        Me.pb_tuile5.Location = New System.Drawing.Point(227, 0)
        Me.pb_tuile5.Name = "pb_tuile5"
        Me.pb_tuile5.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile5.TabIndex = 4
        Me.pb_tuile5.TabStop = False
        '
        'pb_tuile4
        '
        Me.pb_tuile4.Location = New System.Drawing.Point(171, 0)
        Me.pb_tuile4.Name = "pb_tuile4"
        Me.pb_tuile4.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile4.TabIndex = 3
        Me.pb_tuile4.TabStop = False
        '
        'pb_tuile3
        '
        Me.pb_tuile3.Location = New System.Drawing.Point(115, 0)
        Me.pb_tuile3.Name = "pb_tuile3"
        Me.pb_tuile3.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile3.TabIndex = 2
        Me.pb_tuile3.TabStop = False
        '
        'pb_tuile2
        '
        Me.pb_tuile2.Location = New System.Drawing.Point(59, 0)
        Me.pb_tuile2.Name = "pb_tuile2"
        Me.pb_tuile2.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile2.TabIndex = 1
        Me.pb_tuile2.TabStop = False
        '
        'pb_tuile1
        '
        Me.pb_tuile1.Location = New System.Drawing.Point(3, 0)
        Me.pb_tuile1.Name = "pb_tuile1"
        Me.pb_tuile1.Size = New System.Drawing.Size(50, 50)
        Me.pb_tuile1.TabIndex = 0
        Me.pb_tuile1.TabStop = False
        '
        'pb_pioche
        '
        Me.pb_pioche.Location = New System.Drawing.Point(398, 375)
        Me.pb_pioche.Name = "pb_pioche"
        Me.pb_pioche.Size = New System.Drawing.Size(50, 50)
        Me.pb_pioche.TabIndex = 6
        Me.pb_pioche.TabStop = False
        '
        'dg_tableau_score
        '
        Me.dg_tableau_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tableau_score.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.Age, Me.Points})
        Me.dg_tableau_score.Location = New System.Drawing.Point(625, 12)
        Me.dg_tableau_score.Name = "dg_tableau_score"
        Me.dg_tableau_score.Size = New System.Drawing.Size(163, 191)
        Me.dg_tableau_score.TabIndex = 7
        '
        'Name
        '
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Points
        '
        Me.Points.HeaderText = "Points"
        Me.Points.Name = "Points"
        '
        'frm_plateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.dg_tableau_score)
        Me.Controls.Add(Me.pb_pioche)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bp_abandonner)
        Me.Controls.Add(Me.bp_aide)
        Me.Controls.Add(Me.bp_retour)
        Me.Controls.Add(Me.bp_recommencer)
        Me.Controls.Add(Me.bp_confirmer)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_tuile6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tuile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tuile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tuile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tuile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tuile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_pioche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_tableau_score, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bp_confirmer As Button
    Friend WithEvents bp_recommencer As Button
    Friend WithEvents bp_retour As Button
    Friend WithEvents bp_aide As Button
    Friend WithEvents bp_abandonner As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_tuile6 As PictureBox
    Friend WithEvents pb_tuile5 As PictureBox
    Friend WithEvents pb_tuile4 As PictureBox
    Friend WithEvents pb_tuile3 As PictureBox
    Friend WithEvents pb_tuile2 As PictureBox
    Friend WithEvents pb_tuile1 As PictureBox
    Friend WithEvents pb_pioche As PictureBox
    Friend WithEvents dg_tableau_score As DataGridView
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Points As DataGridViewTextBoxColumn
End Class
