<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fin
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.menubutton = New System.Windows.Forms.Button()
        Me.quitbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomgagnant = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.pannelj1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labj1 = New System.Windows.Forms.Label()
        Me.labscorej1 = New System.Windows.Forms.Label()
        Me.pannelj2 = New System.Windows.Forms.TableLayoutPanel()
        Me.labj2 = New System.Windows.Forms.Label()
        Me.labscorej2 = New System.Windows.Forms.Label()
        Me.pannelj3 = New System.Windows.Forms.TableLayoutPanel()
        Me.labj3 = New System.Windows.Forms.Label()
        Me.labscorej3 = New System.Windows.Forms.Label()
        Me.pannelj4 = New System.Windows.Forms.TableLayoutPanel()
        Me.labj4 = New System.Windows.Forms.Label()
        Me.labscorej4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.pannelj1.SuspendLayout()
        Me.pannelj2.SuspendLayout()
        Me.pannelj3.SuspendLayout()
        Me.pannelj4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.Qwirkle.My.Resources.Resources.arriere
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.593023!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.40697!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(884, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.22922!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.77078!))
        Me.TableLayoutPanel2.Controls.Add(Me.menubutton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.quitbutton, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 464)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(878, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'menubutton
        '
        Me.menubutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menubutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menubutton.Location = New System.Drawing.Point(50, 20)
        Me.menubutton.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.menubutton.Name = "menubutton"
        Me.menubutton.Size = New System.Drawing.Size(314, 54)
        Me.menubutton.TabIndex = 0
        Me.menubutton.Text = "Recommencer"
        Me.menubutton.UseVisualStyleBackColor = True
        '
        'quitbutton
        '
        Me.quitbutton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quitbutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitbutton.Location = New System.Drawing.Point(464, 20)
        Me.quitbutton.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.quitbutton.Name = "quitbutton"
        Me.quitbutton.Size = New System.Drawing.Size(364, 54)
        Me.quitbutton.TabIndex = 1
        Me.quitbutton.Text = "Quitter"
        Me.quitbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(878, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fin de partie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.90032!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.09968!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(878, 411)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20304!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.79695!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.nomgagnant, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(872, 79)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 59)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Joueur gagnant :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nomgagnant
        '
        Me.nomgagnant.AutoSize = True
        Me.nomgagnant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nomgagnant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomgagnant.Location = New System.Drawing.Point(273, 10)
        Me.nomgagnant.Margin = New System.Windows.Forms.Padding(10)
        Me.nomgagnant.Name = "nomgagnant"
        Me.nomgagnant.Size = New System.Drawing.Size(589, 59)
        Me.nomgagnant.TabIndex = 1
        Me.nomgagnant.Text = "Nom du joueur gagnant"
        Me.nomgagnant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 88)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(872, 320)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(850, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tableau des scores"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.pannelj1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.pannelj2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.pannelj3, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.pannelj4, 0, 3)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 50)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(864, 266)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'pannelj1
        '
        Me.pannelj1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj1.ColumnCount = 2
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.Controls.Add(Me.labj1, 0, 0)
        Me.pannelj1.Controls.Add(Me.labscorej1, 1, 0)
        Me.pannelj1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj1.Location = New System.Drawing.Point(3, 3)
        Me.pannelj1.Name = "pannelj1"
        Me.pannelj1.RowCount = 1
        Me.pannelj1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj1.Size = New System.Drawing.Size(858, 60)
        Me.pannelj1.TabIndex = 0
        '
        'labj1
        '
        Me.labj1.AutoSize = True
        Me.labj1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labj1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labj1.Location = New System.Drawing.Point(4, 1)
        Me.labj1.Name = "labj1"
        Me.labj1.Size = New System.Drawing.Size(421, 58)
        Me.labj1.TabIndex = 0
        Me.labj1.Text = "Nom du joueur 1"
        Me.labj1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labscorej1
        '
        Me.labscorej1.AutoSize = True
        Me.labscorej1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labscorej1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labscorej1.Location = New System.Drawing.Point(432, 1)
        Me.labscorej1.Name = "labscorej1"
        Me.labscorej1.Size = New System.Drawing.Size(422, 58)
        Me.labscorej1.TabIndex = 1
        Me.labscorej1.Text = "Score du joueur 1"
        Me.labscorej1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj2
        '
        Me.pannelj2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj2.ColumnCount = 2
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.Controls.Add(Me.labj2, 0, 0)
        Me.pannelj2.Controls.Add(Me.labscorej2, 1, 0)
        Me.pannelj2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj2.Location = New System.Drawing.Point(3, 69)
        Me.pannelj2.Name = "pannelj2"
        Me.pannelj2.RowCount = 1
        Me.pannelj2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj2.Size = New System.Drawing.Size(858, 60)
        Me.pannelj2.TabIndex = 1
        '
        'labj2
        '
        Me.labj2.AutoSize = True
        Me.labj2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labj2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labj2.Location = New System.Drawing.Point(4, 1)
        Me.labj2.Name = "labj2"
        Me.labj2.Size = New System.Drawing.Size(421, 58)
        Me.labj2.TabIndex = 0
        Me.labj2.Text = "Nom du joueur 2"
        Me.labj2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labscorej2
        '
        Me.labscorej2.AutoSize = True
        Me.labscorej2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labscorej2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labscorej2.Location = New System.Drawing.Point(432, 1)
        Me.labscorej2.Name = "labscorej2"
        Me.labscorej2.Size = New System.Drawing.Size(422, 58)
        Me.labscorej2.TabIndex = 1
        Me.labscorej2.Text = "Score du joueur 2"
        Me.labscorej2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj3
        '
        Me.pannelj3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj3.ColumnCount = 2
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.Controls.Add(Me.labj3, 0, 0)
        Me.pannelj3.Controls.Add(Me.labscorej3, 1, 0)
        Me.pannelj3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj3.Location = New System.Drawing.Point(3, 135)
        Me.pannelj3.Name = "pannelj3"
        Me.pannelj3.RowCount = 1
        Me.pannelj3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj3.Size = New System.Drawing.Size(858, 60)
        Me.pannelj3.TabIndex = 2
        '
        'labj3
        '
        Me.labj3.AutoSize = True
        Me.labj3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labj3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labj3.Location = New System.Drawing.Point(4, 1)
        Me.labj3.Name = "labj3"
        Me.labj3.Size = New System.Drawing.Size(421, 58)
        Me.labj3.TabIndex = 0
        Me.labj3.Text = "Nom du joueur 3"
        Me.labj3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labscorej3
        '
        Me.labscorej3.AutoSize = True
        Me.labscorej3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labscorej3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labscorej3.Location = New System.Drawing.Point(432, 1)
        Me.labscorej3.Name = "labscorej3"
        Me.labscorej3.Size = New System.Drawing.Size(422, 58)
        Me.labscorej3.TabIndex = 1
        Me.labscorej3.Text = "Score du joueur 3"
        Me.labscorej3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pannelj4
        '
        Me.pannelj4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pannelj4.ColumnCount = 2
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.Controls.Add(Me.labj4, 0, 0)
        Me.pannelj4.Controls.Add(Me.labscorej4, 1, 0)
        Me.pannelj4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj4.Location = New System.Drawing.Point(3, 201)
        Me.pannelj4.Name = "pannelj4"
        Me.pannelj4.RowCount = 1
        Me.pannelj4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pannelj4.Size = New System.Drawing.Size(858, 62)
        Me.pannelj4.TabIndex = 3
        '
        'labj4
        '
        Me.labj4.AutoSize = True
        Me.labj4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labj4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labj4.Location = New System.Drawing.Point(4, 1)
        Me.labj4.Name = "labj4"
        Me.labj4.Size = New System.Drawing.Size(421, 60)
        Me.labj4.TabIndex = 0
        Me.labj4.Text = "Nom du joueur 4"
        Me.labj4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labscorej4
        '
        Me.labscorej4.AutoSize = True
        Me.labscorej4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labscorej4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labscorej4.Location = New System.Drawing.Point(432, 1)
        Me.labscorej4.Name = "labscorej4"
        Me.labscorej4.Size = New System.Drawing.Size(422, 60)
        Me.labscorej4.TabIndex = 1
        Me.labscorej4.Text = "Score du joueur 4"
        Me.labscorej4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_fin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_fin"
        Me.Text = "frm_fin"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.pannelj1.ResumeLayout(False)
        Me.pannelj1.PerformLayout()
        Me.pannelj2.ResumeLayout(False)
        Me.pannelj2.PerformLayout()
        Me.pannelj3.ResumeLayout(False)
        Me.pannelj3.PerformLayout()
        Me.pannelj4.ResumeLayout(False)
        Me.pannelj4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents menubutton As Button
    Friend WithEvents quitbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents nomgagnant As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents pannelj1 As TableLayoutPanel
    Friend WithEvents pannelj2 As TableLayoutPanel
    Friend WithEvents pannelj3 As TableLayoutPanel
    Friend WithEvents pannelj4 As TableLayoutPanel
    Friend WithEvents labj1 As Label
    Friend WithEvents labscorej1 As Label
    Friend WithEvents labj2 As Label
    Friend WithEvents labscorej2 As Label
    Friend WithEvents labj3 As Label
    Friend WithEvents labscorej3 As Label
    Friend WithEvents labj4 As Label
    Friend WithEvents labscorej4 As Label
End Class
