<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_jeu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_jeu))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_abandonner = New System.Windows.Forms.Button()
        Me.btn_recommencer = New System.Windows.Forms.Button()
        Me.btn_aide = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_confirmer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.picBox6 = New System.Windows.Forms.PictureBox()
        Me.picBox5 = New System.Windows.Forms.PictureBox()
        Me.picBox4 = New System.Windows.Forms.PictureBox()
        Me.picBox3 = New System.Windows.Forms.PictureBox()
        Me.picBox2 = New System.Windows.Forms.PictureBox()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.grille_1_1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grille_1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(884, 561)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_abandonner, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_recommencer, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_aide, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_annuler, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_confirmer, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(144, 442)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_abandonner
        '
        Me.btn_abandonner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_abandonner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abandonner.Location = New System.Drawing.Point(3, 223)
        Me.btn_abandonner.Name = "btn_abandonner"
        Me.btn_abandonner.Size = New System.Drawing.Size(138, 49)
        Me.btn_abandonner.TabIndex = 4
        Me.btn_abandonner.Text = "Abandonner"
        Me.btn_abandonner.UseVisualStyleBackColor = True
        '
        'btn_recommencer
        '
        Me.btn_recommencer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_recommencer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recommencer.Location = New System.Drawing.Point(3, 168)
        Me.btn_recommencer.Name = "btn_recommencer"
        Me.btn_recommencer.Size = New System.Drawing.Size(138, 49)
        Me.btn_recommencer.TabIndex = 3
        Me.btn_recommencer.Text = "Recommencer"
        Me.btn_recommencer.UseVisualStyleBackColor = True
        '
        'btn_aide
        '
        Me.btn_aide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aide.Location = New System.Drawing.Point(3, 113)
        Me.btn_aide.Name = "btn_aide"
        Me.btn_aide.Size = New System.Drawing.Size(138, 49)
        Me.btn_aide.TabIndex = 2
        Me.btn_aide.Text = "Aide"
        Me.btn_aide.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(3, 58)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(138, 49)
        Me.btn_annuler.TabIndex = 1
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_confirmer
        '
        Me.btn_confirmer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirmer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmer.Location = New System.Drawing.Point(3, 3)
        Me.btn_confirmer.Name = "btn_confirmer"
        Me.btn_confirmer.Size = New System.Drawing.Size(138, 49)
        Me.btn_confirmer.TabIndex = 0
        Me.btn_confirmer.Text = "Confirmer"
        Me.btn_confirmer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Controls.Add(Me.picBox6, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox4, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picBox1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(153, 451)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(612, 107)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'picBox6
        '
        Me.picBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox6.Image = CType(resources.GetObject("picBox6.Image"), System.Drawing.Image)
        Me.picBox6.Location = New System.Drawing.Point(508, 3)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(101, 101)
        Me.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox6.TabIndex = 5
        Me.picBox6.TabStop = False
        '
        'picBox5
        '
        Me.picBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox5.Image = CType(resources.GetObject("picBox5.Image"), System.Drawing.Image)
        Me.picBox5.Location = New System.Drawing.Point(407, 3)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(95, 101)
        Me.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox5.TabIndex = 4
        Me.picBox5.TabStop = False
        '
        'picBox4
        '
        Me.picBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox4.Image = CType(resources.GetObject("picBox4.Image"), System.Drawing.Image)
        Me.picBox4.Location = New System.Drawing.Point(306, 3)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(95, 101)
        Me.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox4.TabIndex = 3
        Me.picBox4.TabStop = False
        '
        'picBox3
        '
        Me.picBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox3.Image = CType(resources.GetObject("picBox3.Image"), System.Drawing.Image)
        Me.picBox3.Location = New System.Drawing.Point(205, 3)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(95, 101)
        Me.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox3.TabIndex = 2
        Me.picBox3.TabStop = False
        '
        'picBox2
        '
        Me.picBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox2.Image = CType(resources.GetObject("picBox2.Image"), System.Drawing.Image)
        Me.picBox2.Location = New System.Drawing.Point(104, 3)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(95, 101)
        Me.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox2.TabIndex = 1
        Me.picBox2.TabStop = False
        '
        'picBox1
        '
        Me.picBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox1.Image = CType(resources.GetObject("picBox1.Image"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(3, 3)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(95, 101)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 0
        Me.picBox1.TabStop = False
        '
        'grille_1_1
        '
        Me.grille_1_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grille_1_1.Location = New System.Drawing.Point(4, 4)
        Me.grille_1_1.Name = "grille_1_1"
        Me.grille_1_1.Size = New System.Drawing.Size(14, 8)
        Me.grille_1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.grille_1_1.TabIndex = 0
        Me.grille_1_1.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 30
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.grille_1_1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(153, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 30
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(612, 442)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'frm_jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grille_1_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_abandonner As Button
    Friend WithEvents btn_recommencer As Button
    Friend WithEvents btn_aide As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_confirmer As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents picBox6 As PictureBox
    Friend WithEvents picBox5 As PictureBox
    Friend WithEvents picBox4 As PictureBox
    Friend WithEvents picBox3 As PictureBox
    Friend WithEvents picBox2 As PictureBox
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents grille_1_1 As PictureBox
End Class
