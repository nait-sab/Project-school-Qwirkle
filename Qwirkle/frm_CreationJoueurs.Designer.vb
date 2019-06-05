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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pannelj4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur4_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur4_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur4_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur4_Age = New System.Windows.Forms.TextBox()
        Me.check_j4 = New System.Windows.Forms.CheckBox()
        Me.pannelj3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur3_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur3_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur3_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur3_Age = New System.Windows.Forms.TextBox()
        Me.check_j3 = New System.Windows.Forms.CheckBox()
        Me.pannelj2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur2_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur2_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur2_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur2_Age = New System.Windows.Forms.TextBox()
        Me.check_j2 = New System.Windows.Forms.CheckBox()
        Me.pannelj1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur1_Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur1_Age = New System.Windows.Forms.Label()
        Me.txt_Joueur1_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Joueur1_Age = New System.Windows.Forms.TextBox()
        Me.check_j1 = New System.Windows.Forms.CheckBox()
        Me.tableconfirmation = New System.Windows.Forms.TableLayoutPanel()
        Me.boutonvalidation = New System.Windows.Forms.Button()
        Me.cmd_Retour = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pannelj4.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.pannelj3.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.pannelj2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.pannelj1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tableconfirmation.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.Qwirkle.My.Resources.Resources.arriere
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tableconfirmation, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pannelj4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pannelj3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pannelj2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pannelj1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 399)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'pannelj4
        '
        Me.pannelj4.ColumnCount = 2
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.pannelj4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.pannelj4.Controls.Add(Me.lbl_Joueur4, 0, 0)
        Me.pannelj4.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.pannelj4.Controls.Add(Me.check_j4, 1, 0)
        Me.pannelj4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj4.Location = New System.Drawing.Point(400, 202)
        Me.pannelj4.Name = "pannelj4"
        Me.pannelj4.RowCount = 2
        Me.pannelj4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.pannelj4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.pannelj4.Size = New System.Drawing.Size(391, 194)
        Me.pannelj4.TabIndex = 3
        '
        'lbl_Joueur4
        '
        Me.lbl_Joueur4.AutoSize = True
        Me.lbl_Joueur4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur4.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur4.Name = "lbl_Joueur4"
        Me.lbl_Joueur4.Size = New System.Drawing.Size(306, 58)
        Me.lbl_Joueur4.TabIndex = 0
        Me.lbl_Joueur4.Text = "Joueur 4"
        Me.lbl_Joueur4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.lbl_Joueur4_Nom, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lbl_Joueur4_Age, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Joueur4_Nom, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Joueur4_Age, 1, 1)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 61)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(306, 130)
        Me.TableLayoutPanel10.TabIndex = 2
        '
        'lbl_Joueur4_Nom
        '
        Me.lbl_Joueur4_Nom.AutoSize = True
        Me.lbl_Joueur4_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4_Nom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur4_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur4_Nom.Name = "lbl_Joueur4_Nom"
        Me.lbl_Joueur4_Nom.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur4_Nom.TabIndex = 0
        Me.lbl_Joueur4_Nom.Text = "Nom :"
        Me.lbl_Joueur4_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur4_Age
        '
        Me.lbl_Joueur4_Age.AutoSize = True
        Me.lbl_Joueur4_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4_Age.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur4_Age.Location = New System.Drawing.Point(3, 65)
        Me.lbl_Joueur4_Age.Name = "lbl_Joueur4_Age"
        Me.lbl_Joueur4_Age.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur4_Age.TabIndex = 1
        Me.lbl_Joueur4_Age.Text = "Âge :"
        Me.lbl_Joueur4_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur4_Nom
        '
        Me.txt_Joueur4_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur4_Nom.Location = New System.Drawing.Point(153, 30)
        Me.txt_Joueur4_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur4_Nom.Name = "txt_Joueur4_Nom"
        Me.txt_Joueur4_Nom.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur4_Nom.TabIndex = 2
        '
        'txt_Joueur4_Age
        '
        Me.txt_Joueur4_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur4_Age.Location = New System.Drawing.Point(153, 95)
        Me.txt_Joueur4_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur4_Age.Name = "txt_Joueur4_Age"
        Me.txt_Joueur4_Age.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur4_Age.TabIndex = 3
        '
        'check_j4
        '
        Me.check_j4.AutoSize = True
        Me.check_j4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.check_j4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_j4.Location = New System.Drawing.Point(315, 3)
        Me.check_j4.Name = "check_j4"
        Me.check_j4.Size = New System.Drawing.Size(73, 52)
        Me.check_j4.TabIndex = 3
        Me.check_j4.Text = "Valider"
        Me.check_j4.UseVisualStyleBackColor = True
        '
        'pannelj3
        '
        Me.pannelj3.ColumnCount = 2
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.pannelj3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.pannelj3.Controls.Add(Me.lbl_Joueur3, 0, 0)
        Me.pannelj3.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.pannelj3.Controls.Add(Me.check_j3, 1, 0)
        Me.pannelj3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj3.Location = New System.Drawing.Point(3, 202)
        Me.pannelj3.Name = "pannelj3"
        Me.pannelj3.RowCount = 2
        Me.pannelj3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.pannelj3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.pannelj3.Size = New System.Drawing.Size(391, 194)
        Me.pannelj3.TabIndex = 2
        '
        'lbl_Joueur3
        '
        Me.lbl_Joueur3.AutoSize = True
        Me.lbl_Joueur3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur3.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur3.Name = "lbl_Joueur3"
        Me.lbl_Joueur3.Size = New System.Drawing.Size(306, 58)
        Me.lbl_Joueur3.TabIndex = 0
        Me.lbl_Joueur3.Text = "Joueur 3"
        Me.lbl_Joueur3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Joueur3_Nom, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Joueur3_Age, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Joueur3_Nom, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Joueur3_Age, 1, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 61)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(306, 130)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'lbl_Joueur3_Nom
        '
        Me.lbl_Joueur3_Nom.AutoSize = True
        Me.lbl_Joueur3_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3_Nom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur3_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur3_Nom.Name = "lbl_Joueur3_Nom"
        Me.lbl_Joueur3_Nom.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur3_Nom.TabIndex = 0
        Me.lbl_Joueur3_Nom.Text = "Nom :"
        Me.lbl_Joueur3_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur3_Age
        '
        Me.lbl_Joueur3_Age.AutoSize = True
        Me.lbl_Joueur3_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3_Age.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur3_Age.Location = New System.Drawing.Point(3, 65)
        Me.lbl_Joueur3_Age.Name = "lbl_Joueur3_Age"
        Me.lbl_Joueur3_Age.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur3_Age.TabIndex = 1
        Me.lbl_Joueur3_Age.Text = "Âge :"
        Me.lbl_Joueur3_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur3_Nom
        '
        Me.txt_Joueur3_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur3_Nom.Location = New System.Drawing.Point(153, 30)
        Me.txt_Joueur3_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur3_Nom.Name = "txt_Joueur3_Nom"
        Me.txt_Joueur3_Nom.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur3_Nom.TabIndex = 2
        '
        'txt_Joueur3_Age
        '
        Me.txt_Joueur3_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur3_Age.Location = New System.Drawing.Point(153, 95)
        Me.txt_Joueur3_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur3_Age.Name = "txt_Joueur3_Age"
        Me.txt_Joueur3_Age.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur3_Age.TabIndex = 3
        '
        'check_j3
        '
        Me.check_j3.AutoSize = True
        Me.check_j3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.check_j3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_j3.Location = New System.Drawing.Point(315, 3)
        Me.check_j3.Name = "check_j3"
        Me.check_j3.Size = New System.Drawing.Size(73, 52)
        Me.check_j3.TabIndex = 3
        Me.check_j3.Text = "Valider"
        Me.check_j3.UseVisualStyleBackColor = True
        '
        'pannelj2
        '
        Me.pannelj2.ColumnCount = 2
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.pannelj2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.pannelj2.Controls.Add(Me.lbl_Joueur2, 0, 0)
        Me.pannelj2.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.pannelj2.Controls.Add(Me.check_j2, 1, 0)
        Me.pannelj2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj2.Location = New System.Drawing.Point(400, 3)
        Me.pannelj2.Name = "pannelj2"
        Me.pannelj2.RowCount = 2
        Me.pannelj2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.pannelj2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.pannelj2.Size = New System.Drawing.Size(391, 193)
        Me.pannelj2.TabIndex = 1
        '
        'lbl_Joueur2
        '
        Me.lbl_Joueur2.AutoSize = True
        Me.lbl_Joueur2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur2.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur2.Name = "lbl_Joueur2"
        Me.lbl_Joueur2.Size = New System.Drawing.Size(306, 57)
        Me.lbl_Joueur2.TabIndex = 0
        Me.lbl_Joueur2.Text = "Joueur 2"
        Me.lbl_Joueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur2_Nom, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur2_Age, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur2_Nom, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur2_Age, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 60)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(306, 130)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'lbl_Joueur2_Nom
        '
        Me.lbl_Joueur2_Nom.AutoSize = True
        Me.lbl_Joueur2_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2_Nom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur2_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur2_Nom.Name = "lbl_Joueur2_Nom"
        Me.lbl_Joueur2_Nom.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur2_Nom.TabIndex = 0
        Me.lbl_Joueur2_Nom.Text = "Nom :"
        Me.lbl_Joueur2_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur2_Age
        '
        Me.lbl_Joueur2_Age.AutoSize = True
        Me.lbl_Joueur2_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2_Age.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur2_Age.Location = New System.Drawing.Point(3, 65)
        Me.lbl_Joueur2_Age.Name = "lbl_Joueur2_Age"
        Me.lbl_Joueur2_Age.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur2_Age.TabIndex = 1
        Me.lbl_Joueur2_Age.Text = "Âge :"
        Me.lbl_Joueur2_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur2_Nom
        '
        Me.txt_Joueur2_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2_Nom.Location = New System.Drawing.Point(153, 30)
        Me.txt_Joueur2_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur2_Nom.Name = "txt_Joueur2_Nom"
        Me.txt_Joueur2_Nom.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur2_Nom.TabIndex = 2
        '
        'txt_Joueur2_Age
        '
        Me.txt_Joueur2_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2_Age.Location = New System.Drawing.Point(153, 95)
        Me.txt_Joueur2_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur2_Age.Name = "txt_Joueur2_Age"
        Me.txt_Joueur2_Age.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur2_Age.TabIndex = 3
        '
        'check_j2
        '
        Me.check_j2.AutoSize = True
        Me.check_j2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.check_j2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_j2.Location = New System.Drawing.Point(315, 3)
        Me.check_j2.Name = "check_j2"
        Me.check_j2.Size = New System.Drawing.Size(73, 51)
        Me.check_j2.TabIndex = 3
        Me.check_j2.Text = "Valider"
        Me.check_j2.UseVisualStyleBackColor = True
        '
        'pannelj1
        '
        Me.pannelj1.ColumnCount = 2
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.pannelj1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.pannelj1.Controls.Add(Me.lbl_Joueur1, 0, 0)
        Me.pannelj1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.pannelj1.Controls.Add(Me.check_j1, 1, 0)
        Me.pannelj1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pannelj1.Location = New System.Drawing.Point(3, 3)
        Me.pannelj1.Name = "pannelj1"
        Me.pannelj1.RowCount = 2
        Me.pannelj1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.pannelj1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.pannelj1.Size = New System.Drawing.Size(391, 193)
        Me.pannelj1.TabIndex = 0
        '
        'lbl_Joueur1
        '
        Me.lbl_Joueur1.AutoSize = True
        Me.lbl_Joueur1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur1.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur1.Name = "lbl_Joueur1"
        Me.lbl_Joueur1.Size = New System.Drawing.Size(306, 57)
        Me.lbl_Joueur1.TabIndex = 0
        Me.lbl_Joueur1.Text = "Joueur 1"
        Me.lbl_Joueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur1_Nom, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur1_Age, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur1_Nom, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur1_Age, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 60)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(306, 130)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'lbl_Joueur1_Nom
        '
        Me.lbl_Joueur1_Nom.AutoSize = True
        Me.lbl_Joueur1_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1_Nom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur1_Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur1_Nom.Name = "lbl_Joueur1_Nom"
        Me.lbl_Joueur1_Nom.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur1_Nom.TabIndex = 0
        Me.lbl_Joueur1_Nom.Text = "Nom :"
        Me.lbl_Joueur1_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur1_Age
        '
        Me.lbl_Joueur1_Age.AutoSize = True
        Me.lbl_Joueur1_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1_Age.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_Joueur1_Age.Location = New System.Drawing.Point(3, 65)
        Me.lbl_Joueur1_Age.Name = "lbl_Joueur1_Age"
        Me.lbl_Joueur1_Age.Size = New System.Drawing.Size(147, 65)
        Me.lbl_Joueur1_Age.TabIndex = 1
        Me.lbl_Joueur1_Age.Text = "Âge :"
        Me.lbl_Joueur1_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur1_Nom
        '
        Me.txt_Joueur1_Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1_Nom.Location = New System.Drawing.Point(153, 30)
        Me.txt_Joueur1_Nom.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur1_Nom.Name = "txt_Joueur1_Nom"
        Me.txt_Joueur1_Nom.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur1_Nom.TabIndex = 2
        '
        'txt_Joueur1_Age
        '
        Me.txt_Joueur1_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1_Age.Location = New System.Drawing.Point(153, 95)
        Me.txt_Joueur1_Age.Margin = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.txt_Joueur1_Age.Name = "txt_Joueur1_Age"
        Me.txt_Joueur1_Age.Size = New System.Drawing.Size(153, 20)
        Me.txt_Joueur1_Age.TabIndex = 3
        '
        'check_j1
        '
        Me.check_j1.AutoSize = True
        Me.check_j1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.check_j1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_j1.Location = New System.Drawing.Point(315, 3)
        Me.check_j1.Name = "check_j1"
        Me.check_j1.Size = New System.Drawing.Size(73, 51)
        Me.check_j1.TabIndex = 3
        Me.check_j1.Text = "Valider"
        Me.check_j1.UseVisualStyleBackColor = True
        '
        'tableconfirmation
        '
        Me.tableconfirmation.ColumnCount = 2
        Me.tableconfirmation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tableconfirmation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableconfirmation.Controls.Add(Me.boutonvalidation, 0, 0)
        Me.tableconfirmation.Controls.Add(Me.cmd_Retour, 1, 0)
        Me.tableconfirmation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableconfirmation.Location = New System.Drawing.Point(3, 408)
        Me.tableconfirmation.Name = "tableconfirmation"
        Me.tableconfirmation.RowCount = 1
        Me.tableconfirmation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableconfirmation.Size = New System.Drawing.Size(794, 39)
        Me.tableconfirmation.TabIndex = 4
        '
        'boutonvalidation
        '
        Me.boutonvalidation.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.boutonvalidation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boutonvalidation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boutonvalidation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boutonvalidation.ForeColor = System.Drawing.Color.Black
        Me.boutonvalidation.Location = New System.Drawing.Point(100, 3)
        Me.boutonvalidation.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.boutonvalidation.Name = "boutonvalidation"
        Me.boutonvalidation.Size = New System.Drawing.Size(435, 33)
        Me.boutonvalidation.TabIndex = 0
        Me.boutonvalidation.Text = "Valider création joueurs"
        Me.boutonvalidation.UseVisualStyleBackColor = False
        '
        'cmd_Retour
        '
        Me.cmd_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmd_Retour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Retour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Retour.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Retour.ForeColor = System.Drawing.Color.Black
        Me.cmd_Retour.Location = New System.Drawing.Point(635, 3)
        Me.cmd_Retour.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.cmd_Retour.Name = "cmd_Retour"
        Me.cmd_Retour.Size = New System.Drawing.Size(159, 33)
        Me.cmd_Retour.TabIndex = 1
        Me.cmd_Retour.Text = "Retour"
        Me.cmd_Retour.UseVisualStyleBackColor = False
        '
        'frm_CreationJoueurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_CreationJoueurs"
        Me.Text = "frm_CreationJoueurs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pannelj4.ResumeLayout(False)
        Me.pannelj4.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.pannelj3.ResumeLayout(False)
        Me.pannelj3.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.pannelj2.ResumeLayout(False)
        Me.pannelj2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.pannelj1.ResumeLayout(False)
        Me.pannelj1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tableconfirmation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pannelj4 As TableLayoutPanel
    Friend WithEvents lbl_Joueur4 As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents lbl_Joueur4_Nom As Label
    Friend WithEvents lbl_Joueur4_Age As Label
    Friend WithEvents txt_Joueur4_Nom As TextBox
    Friend WithEvents txt_Joueur4_Age As TextBox
    Friend WithEvents pannelj3 As TableLayoutPanel
    Friend WithEvents lbl_Joueur3 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lbl_Joueur3_Nom As Label
    Friend WithEvents lbl_Joueur3_Age As Label
    Friend WithEvents txt_Joueur3_Nom As TextBox
    Friend WithEvents txt_Joueur3_Age As TextBox
    Friend WithEvents pannelj2 As TableLayoutPanel
    Friend WithEvents lbl_Joueur2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lbl_Joueur2_Nom As Label
    Friend WithEvents lbl_Joueur2_Age As Label
    Friend WithEvents txt_Joueur2_Nom As TextBox
    Friend WithEvents txt_Joueur2_Age As TextBox
    Friend WithEvents pannelj1 As TableLayoutPanel
    Friend WithEvents lbl_Joueur1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lbl_Joueur1_Nom As Label
    Friend WithEvents lbl_Joueur1_Age As Label
    Friend WithEvents txt_Joueur1_Nom As TextBox
    Friend WithEvents txt_Joueur1_Age As TextBox
    Friend WithEvents check_j4 As CheckBox
    Friend WithEvents check_j3 As CheckBox
    Friend WithEvents check_j2 As CheckBox
    Friend WithEvents check_j1 As CheckBox
    Friend WithEvents tableconfirmation As TableLayoutPanel
    Friend WithEvents boutonvalidation As Button
    Friend WithEvents cmd_Retour As Button
End Class
