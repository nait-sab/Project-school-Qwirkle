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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_Confirmer = New System.Windows.Forms.Button()
        Me.cmd_recommencer = New System.Windows.Forms.Button()
        Me.cmd_Retour = New System.Windows.Forms.Button()
        Me.cmd_aide = New System.Windows.Forms.Button()
        Me.cmd_Abandonner = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox_Tuile1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Tuile2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Tuile3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Tuile4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Tuile5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Tuile6 = New System.Windows.Forms.PictureBox()
        Me.Picture_box_Pioche = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox_Tuile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Tuile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Tuile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Tuile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Tuile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Tuile6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_box_Pioche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.75862!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.93104!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19192!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Picture_box_Pioche, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.33089!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.6691!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(874, 547)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_Confirmer, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_recommencer, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_Retour, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_aide, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_Abandonner, 0, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(105, 185)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cmd_Confirmer
        '
        Me.cmd_Confirmer.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Confirmer.Name = "cmd_Confirmer"
        Me.cmd_Confirmer.Size = New System.Drawing.Size(99, 31)
        Me.cmd_Confirmer.TabIndex = 0
        Me.cmd_Confirmer.Text = "Confirmer"
        Me.cmd_Confirmer.UseVisualStyleBackColor = True
        '
        'cmd_recommencer
        '
        Me.cmd_recommencer.Location = New System.Drawing.Point(3, 40)
        Me.cmd_recommencer.Name = "cmd_recommencer"
        Me.cmd_recommencer.Size = New System.Drawing.Size(99, 31)
        Me.cmd_recommencer.TabIndex = 1
        Me.cmd_recommencer.Text = "Recommencer"
        Me.cmd_recommencer.UseVisualStyleBackColor = True
        '
        'cmd_Retour
        '
        Me.cmd_Retour.Location = New System.Drawing.Point(3, 77)
        Me.cmd_Retour.Name = "cmd_Retour"
        Me.cmd_Retour.Size = New System.Drawing.Size(99, 31)
        Me.cmd_Retour.TabIndex = 2
        Me.cmd_Retour.Text = "Retour"
        Me.cmd_Retour.UseVisualStyleBackColor = True
        '
        'cmd_aide
        '
        Me.cmd_aide.Location = New System.Drawing.Point(3, 114)
        Me.cmd_aide.Name = "cmd_aide"
        Me.cmd_aide.Size = New System.Drawing.Size(99, 31)
        Me.cmd_aide.TabIndex = 3
        Me.cmd_aide.Text = "Aide"
        Me.cmd_aide.UseVisualStyleBackColor = True
        '
        'cmd_Abandonner
        '
        Me.cmd_Abandonner.Location = New System.Drawing.Point(3, 151)
        Me.cmd_Abandonner.Name = "cmd_Abandonner"
        Me.cmd_Abandonner.Size = New System.Drawing.Size(99, 31)
        Me.cmd_Abandonner.TabIndex = 4
        Me.cmd_Abandonner.Text = "Abandonner"
        Me.cmd_Abandonner.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile4, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox_Tuile6, 5, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(114, 426)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(582, 118)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'PictureBox_Tuile1
        '
        Me.PictureBox_Tuile1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox_Tuile1.Name = "PictureBox_Tuile1"
        Me.PictureBox_Tuile1.Size = New System.Drawing.Size(90, 112)
        Me.PictureBox_Tuile1.TabIndex = 0
        Me.PictureBox_Tuile1.TabStop = False
        '
        'PictureBox_Tuile2
        '
        Me.PictureBox_Tuile2.Location = New System.Drawing.Point(99, 3)
        Me.PictureBox_Tuile2.Name = "PictureBox_Tuile2"
        Me.PictureBox_Tuile2.Size = New System.Drawing.Size(90, 112)
        Me.PictureBox_Tuile2.TabIndex = 1
        Me.PictureBox_Tuile2.TabStop = False
        '
        'PictureBox_Tuile3
        '
        Me.PictureBox_Tuile3.Location = New System.Drawing.Point(195, 3)
        Me.PictureBox_Tuile3.Name = "PictureBox_Tuile3"
        Me.PictureBox_Tuile3.Size = New System.Drawing.Size(90, 112)
        Me.PictureBox_Tuile3.TabIndex = 2
        Me.PictureBox_Tuile3.TabStop = False
        '
        'PictureBox_Tuile4
        '
        Me.PictureBox_Tuile4.Location = New System.Drawing.Point(291, 3)
        Me.PictureBox_Tuile4.Name = "PictureBox_Tuile4"
        Me.PictureBox_Tuile4.Size = New System.Drawing.Size(90, 112)
        Me.PictureBox_Tuile4.TabIndex = 3
        Me.PictureBox_Tuile4.TabStop = False
        '
        'PictureBox_Tuile5
        '
        Me.PictureBox_Tuile5.Location = New System.Drawing.Point(387, 3)
        Me.PictureBox_Tuile5.Name = "PictureBox_Tuile5"
        Me.PictureBox_Tuile5.Size = New System.Drawing.Size(90, 112)
        Me.PictureBox_Tuile5.TabIndex = 4
        Me.PictureBox_Tuile5.TabStop = False
        '
        'PictureBox_Tuile6
        '
        Me.PictureBox_Tuile6.Location = New System.Drawing.Point(483, 3)
        Me.PictureBox_Tuile6.Name = "PictureBox_Tuile6"
        Me.PictureBox_Tuile6.Size = New System.Drawing.Size(91, 112)
        Me.PictureBox_Tuile6.TabIndex = 5
        Me.PictureBox_Tuile6.TabStop = False
        '
        'Picture_box_Pioche
        '
        Me.Picture_box_Pioche.Location = New System.Drawing.Point(3, 426)
        Me.Picture_box_Pioche.Name = "Picture_box_Pioche"
        Me.Picture_box_Pioche.Size = New System.Drawing.Size(100, 116)
        Me.Picture_box_Pioche.TabIndex = 3
        Me.Picture_box_Pioche.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(708, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(0, 0)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(114, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(585, 416)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 30
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 30
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(576, 410)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'frm_plateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_plateau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox_Tuile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Tuile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Tuile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Tuile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Tuile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Tuile6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_box_Pioche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmd_Confirmer As Button
    Friend WithEvents cmd_recommencer As Button
    Friend WithEvents cmd_Retour As Button
    Friend WithEvents cmd_aide As Button
    Friend WithEvents cmd_Abandonner As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox_Tuile1 As PictureBox
    Friend WithEvents PictureBox_Tuile2 As PictureBox
    Friend WithEvents PictureBox_Tuile3 As PictureBox
    Friend WithEvents PictureBox_Tuile4 As PictureBox
    Friend WithEvents PictureBox_Tuile5 As PictureBox
    Friend WithEvents PictureBox_Tuile6 As PictureBox
    Friend WithEvents Picture_box_Pioche As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
End Class
