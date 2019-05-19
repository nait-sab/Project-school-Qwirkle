<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CreationJoueurs
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Joueur1_Age = New System.Windows.Forms.TextBox()
        Me.txt_Joueur1_Nom = New System.Windows.Forms.TextBox()
        Me.lbl_Joueur1_Age = New System.Windows.Forms.Label()
        Me.lbl_Joueur1_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur4_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur4_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur4_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur4_Age = New System.Windows.Forms.TextBox()
        Me.cmd_actif_Joueur4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur3_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur3_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur3_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur3_Age = New System.Windows.Forms.TextBox()
        Me.cmd_actif_Joueur3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur2 = New System.Windows.Forms.Label()
        Me.cmd_actif_Joueur2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur2_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur2_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur2_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur2_Age = New System.Windows.Forms.TextBox()
        Me.cmd_actif_Joueur1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Joueur1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_actif_Joueur1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(394, 219)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur1_Nom, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur1_Age, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur1_Nom, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur1_Age, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 68)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(309, 148)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'txt_Joueur1_Age
        '
        Me.txt_Joueur1_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1_Age.Location = New System.Drawing.Point(154, 104)
        Me.txt_Joueur1_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur1_Age.Name = "txt_Joueur1_Age"
        Me.txt_Joueur1_Age.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur1_Age.TabIndex = 3
        '
        'txt_Joueur1_Nom
        '
        Me.txt_Joueur1_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1_Nom.Location = New System.Drawing.Point(154, 30)
        Me.txt_Joueur1_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur1_Nom.Name = "txt_Joueur1_Nom"
        Me.txt_Joueur1_Nom.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur1_Nom.TabIndex = 2
        '
        'lbl_Joueur1_Age
        '
        Me.lbl_Joueur1_Age.AutoSize = True
        Me.lbl_Joueur1_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1_Age.Location = New System.Drawing.Point(3, 74)
        Me.lbl_Joueur1_Age.Name = "lbl_Joueur1_Age"
        Me.lbl_Joueur1_Age.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur1_Age.TabIndex = 1
        Me.lbl_Joueur1_Age.Text = "Age :"
        Me.lbl_Joueur1_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur1_Nom
        '
        Me.lbl_Joueur1_Nom.AutoSize = True
        Me.lbl_Joueur1_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur1_Nom.Name = "lbl_Joueur1_Nom"
        Me.lbl_Joueur1_Nom.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur1_Nom.TabIndex = 0
        Me.lbl_Joueur1_Nom.Text = "Nom :"
        Me.lbl_Joueur1_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur1
        '
        Me.lbl_Joueur1.AutoSize = True
        Me.lbl_Joueur1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur1.Name = "lbl_Joueur1"
        Me.lbl_Joueur1.Size = New System.Drawing.Size(309, 65)
        Me.lbl_Joueur1.TabIndex = 0
        Me.lbl_Joueur1.Text = "Joueur 1"
        Me.lbl_Joueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Joueur4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cmd_actif_Joueur4, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(403, 228)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(394, 219)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lbl_Joueur4
        '
        Me.lbl_Joueur4.AutoSize = True
        Me.lbl_Joueur4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur4.Name = "lbl_Joueur4"
        Me.lbl_Joueur4.Size = New System.Drawing.Size(309, 65)
        Me.lbl_Joueur4.TabIndex = 0
        Me.lbl_Joueur4.Text = "Joueur 4"
        Me.lbl_Joueur4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur4_Nom, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur4_Age, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur4_Nom, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur4_Age, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 68)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(309, 148)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'lbl_Joueur4_Nom
        '
        Me.lbl_Joueur4_Nom.AutoSize = True
        Me.lbl_Joueur4_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur4_Nom.Name = "lbl_Joueur4_Nom"
        Me.lbl_Joueur4_Nom.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur4_Nom.TabIndex = 0
        Me.lbl_Joueur4_Nom.Text = "Nom :"
        Me.lbl_Joueur4_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur4_Age
        '
        Me.lbl_Joueur4_Age.AutoSize = True
        Me.lbl_Joueur4_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4_Age.Location = New System.Drawing.Point(3, 74)
        Me.lbl_Joueur4_Age.Name = "lbl_Joueur4_Age"
        Me.lbl_Joueur4_Age.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur4_Age.TabIndex = 1
        Me.lbl_Joueur4_Age.Text = "Age :"
        Me.lbl_Joueur4_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur4_Nom
        '
        Me.txt_Joueur4_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur4_Nom.Location = New System.Drawing.Point(154, 30)
        Me.txt_Joueur4_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur4_Nom.Name = "txt_Joueur4_Nom"
        Me.txt_Joueur4_Nom.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur4_Nom.TabIndex = 2
        '
        'txt_Joueur4_Age
        '
        Me.txt_Joueur4_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur4_Age.Location = New System.Drawing.Point(154, 104)
        Me.txt_Joueur4_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur4_Age.Name = "txt_Joueur4_Age"
        Me.txt_Joueur4_Age.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur4_Age.TabIndex = 3
        '
        'cmd_actif_Joueur4
        '
        Me.cmd_actif_Joueur4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_actif_Joueur4.Location = New System.Drawing.Point(318, 3)
        Me.cmd_actif_Joueur4.Name = "cmd_actif_Joueur4"
        Me.cmd_actif_Joueur4.Size = New System.Drawing.Size(73, 59)
        Me.cmd_actif_Joueur4.TabIndex = 2
        Me.cmd_actif_Joueur4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_Joueur3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cmd_actif_Joueur3, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 228)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(394, 219)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'lbl_Joueur3
        '
        Me.lbl_Joueur3.AutoSize = True
        Me.lbl_Joueur3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur3.Name = "lbl_Joueur3"
        Me.lbl_Joueur3.Size = New System.Drawing.Size(309, 65)
        Me.lbl_Joueur3.TabIndex = 0
        Me.lbl_Joueur3.Text = "Joueur 3"
        Me.lbl_Joueur3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Joueur3_Nom, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Joueur3_Age, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Joueur3_Nom, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Joueur3_Age, 1, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 68)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(309, 148)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'lbl_Joueur3_Nom
        '
        Me.lbl_Joueur3_Nom.AutoSize = True
        Me.lbl_Joueur3_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur3_Nom.Name = "lbl_Joueur3_Nom"
        Me.lbl_Joueur3_Nom.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur3_Nom.TabIndex = 0
        Me.lbl_Joueur3_Nom.Text = "Nom :"
        Me.lbl_Joueur3_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur3_Age
        '
        Me.lbl_Joueur3_Age.AutoSize = True
        Me.lbl_Joueur3_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3_Age.Location = New System.Drawing.Point(3, 74)
        Me.lbl_Joueur3_Age.Name = "lbl_Joueur3_Age"
        Me.lbl_Joueur3_Age.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur3_Age.TabIndex = 1
        Me.lbl_Joueur3_Age.Text = "Age :"
        Me.lbl_Joueur3_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur3_Nom
        '
        Me.txt_Joueur3_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur3_Nom.Location = New System.Drawing.Point(154, 30)
        Me.txt_Joueur3_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur3_Nom.Name = "txt_Joueur3_Nom"
        Me.txt_Joueur3_Nom.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur3_Nom.TabIndex = 2
        '
        'txt_Joueur3_Age
        '
        Me.txt_Joueur3_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur3_Age.Location = New System.Drawing.Point(154, 104)
        Me.txt_Joueur3_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur3_Age.Name = "txt_Joueur3_Age"
        Me.txt_Joueur3_Age.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur3_Age.TabIndex = 3
        '
        'cmd_actif_Joueur3
        '
        Me.cmd_actif_Joueur3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_actif_Joueur3.Location = New System.Drawing.Point(318, 3)
        Me.cmd_actif_Joueur3.Name = "cmd_actif_Joueur3"
        Me.cmd_actif_Joueur3.Size = New System.Drawing.Size(73, 59)
        Me.cmd_actif_Joueur3.TabIndex = 2
        Me.cmd_actif_Joueur3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Joueur2, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cmd_actif_Joueur2, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(403, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(394, 219)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'lbl_Joueur2
        '
        Me.lbl_Joueur2.AutoSize = True
        Me.lbl_Joueur2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur2.Name = "lbl_Joueur2"
        Me.lbl_Joueur2.Size = New System.Drawing.Size(309, 65)
        Me.lbl_Joueur2.TabIndex = 0
        Me.lbl_Joueur2.Text = "Joueur 2"
        Me.lbl_Joueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_actif_Joueur2
        '
        Me.cmd_actif_Joueur2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_actif_Joueur2.Location = New System.Drawing.Point(318, 3)
        Me.cmd_actif_Joueur2.Name = "cmd_actif_Joueur2"
        Me.cmd_actif_Joueur2.Size = New System.Drawing.Size(73, 59)
        Me.cmd_actif_Joueur2.TabIndex = 1
        Me.cmd_actif_Joueur2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.lbl_Joueur2_Nom, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lbl_Joueur2_Age, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.txt_Joueur2_Nom, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.txt_Joueur2_Age, 1, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 68)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(309, 148)
        Me.TableLayoutPanel9.TabIndex = 2
        '
        'lbl_Joueur2_Nom
        '
        Me.lbl_Joueur2_Nom.AutoSize = True
        Me.lbl_Joueur2_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur2_Nom.Name = "lbl_Joueur2_Nom"
        Me.lbl_Joueur2_Nom.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur2_Nom.TabIndex = 0
        Me.lbl_Joueur2_Nom.Text = "Nom :"
        Me.lbl_Joueur2_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur2_Age
        '
        Me.lbl_Joueur2_Age.AutoSize = True
        Me.lbl_Joueur2_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2_Age.Location = New System.Drawing.Point(3, 74)
        Me.lbl_Joueur2_Age.Name = "lbl_Joueur2_Age"
        Me.lbl_Joueur2_Age.Size = New System.Drawing.Size(148, 74)
        Me.lbl_Joueur2_Age.TabIndex = 1
        Me.lbl_Joueur2_Age.Text = "Age :"
        Me.lbl_Joueur2_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur2_Nom
        '
        Me.txt_Joueur2_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2_Nom.Location = New System.Drawing.Point(154, 30)
        Me.txt_Joueur2_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur2_Nom.Name = "txt_Joueur2_Nom"
        Me.txt_Joueur2_Nom.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur2_Nom.TabIndex = 2
        '
        'txt_Joueur2_Age
        '
        Me.txt_Joueur2_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2_Age.Location = New System.Drawing.Point(154, 104)
        Me.txt_Joueur2_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur2_Age.Name = "txt_Joueur2_Age"
        Me.txt_Joueur2_Age.Size = New System.Drawing.Size(155, 20)
        Me.txt_Joueur2_Age.TabIndex = 3
        '
        'cmd_actif_Joueur1
        '
        Me.cmd_actif_Joueur1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_actif_Joueur1.Location = New System.Drawing.Point(318, 3)
        Me.cmd_actif_Joueur1.Name = "cmd_actif_Joueur1"
        Me.cmd_actif_Joueur1.Size = New System.Drawing.Size(73, 59)
        Me.cmd_actif_Joueur1.TabIndex = 2
        Me.cmd_actif_Joueur1.UseVisualStyleBackColor = True
        '
        'frm_CreationJoueurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_CreationJoueurs"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_Joueur1 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lbl_Joueur1_Nom As Label
    Friend WithEvents lbl_Joueur1_Age As Label
    Friend WithEvents txt_Joueur1_Nom As TextBox
    Friend WithEvents txt_Joueur1_Age As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lbl_Joueur3 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lbl_Joueur3_Nom As Label
    Friend WithEvents lbl_Joueur3_Age As Label
    Friend WithEvents txt_Joueur3_Nom As TextBox
    Friend WithEvents txt_Joueur3_Age As TextBox
    Friend WithEvents cmd_actif_Joueur3 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_Joueur4 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lbl_Joueur4_Nom As Label
    Friend WithEvents lbl_Joueur4_Age As Label
    Friend WithEvents txt_Joueur4_Nom As TextBox
    Friend WithEvents txt_Joueur4_Age As TextBox
    Friend WithEvents cmd_actif_Joueur4 As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lbl_Joueur2_Nom As Label
    Friend WithEvents lbl_Joueur2_Age As Label
    Friend WithEvents txt_Joueur2_Nom As TextBox
    Friend WithEvents txt_Joueur2_Age As TextBox
    Friend WithEvents lbl_Joueur2 As Label
    Friend WithEvents cmd_actif_Joueur2 As Button
    Friend WithEvents cmd_actif_Joueur1 As Button
End Class
