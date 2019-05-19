<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_nouvelle_partie
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
<<<<<<< HEAD
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_2joueurs = New System.Windows.Forms.Button()
        Me.btn_4joueurs = New System.Windows.Forms.Button()
        Me.btn_3joueurs = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
=======
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueurs4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Joueurs4Age = New System.Windows.Forms.TextBox()
        Me.lbl_Joueurs4Age = New System.Windows.Forms.Label()
        Me.txt_Joueurs4Nom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtJoueurs3Age = New System.Windows.Forms.TextBox()
        Me.lbl_Joueurs3Age = New System.Windows.Forms.Label()
        Me.txt_Joueurs3Nom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_joueur2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Joueur2Age = New System.Windows.Forms.TextBox()
        Me.lbl_Joueur2Age = New System.Windows.Forms.Label()
        Me.txt_Joueur2Nom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Joueur1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Joueur1Age = New System.Windows.Forms.TextBox()
        Me.lbl_Joueur1Age = New System.Windows.Forms.Label()
        Me.txt_Joueur1Nom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_confirmer = New System.Windows.Forms.Button()
        Me.cmd_Retour = New System.Windows.Forms.Button()
        Me.lbl_Joueur1Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur2Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur4Nom = New System.Windows.Forms.Label()
        Me.lbl_Joueur3Nom = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
>>>>>>> master
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
<<<<<<< HEAD
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_2joueurs, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_4joueurs, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_3joueurs, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_retour, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(884, 561)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 50, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(878, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Commencer une nouvelle partie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_2joueurs
        '
        Me.btn_2joueurs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_2joueurs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2joueurs.Location = New System.Drawing.Point(300, 134)
        Me.btn_2joueurs.Margin = New System.Windows.Forms.Padding(300, 30, 300, 30)
        Me.btn_2joueurs.Name = "btn_2joueurs"
        Me.btn_2joueurs.Size = New System.Drawing.Size(284, 50)
        Me.btn_2joueurs.TabIndex = 2
        Me.btn_2joueurs.Text = "2 joueurs"
        Me.btn_2joueurs.UseVisualStyleBackColor = True
        '
        'btn_4joueurs
        '
        Me.btn_4joueurs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_4joueurs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4joueurs.Location = New System.Drawing.Point(300, 354)
        Me.btn_4joueurs.Margin = New System.Windows.Forms.Padding(300, 30, 300, 30)
        Me.btn_4joueurs.Name = "btn_4joueurs"
        Me.btn_4joueurs.Size = New System.Drawing.Size(284, 50)
        Me.btn_4joueurs.TabIndex = 4
        Me.btn_4joueurs.Text = "4 joueurs"
        Me.btn_4joueurs.UseVisualStyleBackColor = True
        '
        'btn_3joueurs
        '
        Me.btn_3joueurs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_3joueurs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3joueurs.Location = New System.Drawing.Point(300, 244)
        Me.btn_3joueurs.Margin = New System.Windows.Forms.Padding(300, 30, 300, 30)
        Me.btn_3joueurs.Name = "btn_3joueurs"
        Me.btn_3joueurs.Size = New System.Drawing.Size(284, 50)
        Me.btn_3joueurs.TabIndex = 3
        Me.btn_3joueurs.Text = "3 joueurs"
        Me.btn_3joueurs.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(300, 464)
        Me.btn_retour.Margin = New System.Windows.Forms.Padding(300, 30, 300, 30)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(284, 50)
        Me.btn_retour.TabIndex = 5
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = True
=======
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel11, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(884, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel9, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(878, 498)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.lbl_Joueurs4, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 1, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(442, 252)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(433, 243)
        Me.TableLayoutPanel9.TabIndex = 3
        '
        'lbl_Joueurs4
        '
        Me.lbl_Joueurs4.AutoSize = True
        Me.lbl_Joueurs4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueurs4.Location = New System.Drawing.Point(89, 0)
        Me.lbl_Joueurs4.Name = "lbl_Joueurs4"
        Me.lbl_Joueurs4.Size = New System.Drawing.Size(341, 48)
        Me.lbl_Joueurs4.TabIndex = 0
        Me.lbl_Joueurs4.Text = "Joueur 4"
        Me.lbl_Joueurs4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Joueurs4Age, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.lbl_Joueurs4Age, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Joueurs4Nom, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lbl_Joueur4Nom, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(89, 51)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(341, 189)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'txt_Joueurs4Age
        '
        Me.txt_Joueurs4Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueurs4Age.Location = New System.Drawing.Point(88, 131)
        Me.txt_Joueurs4Age.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueurs4Age.Name = "txt_Joueurs4Age"
        Me.txt_Joueurs4Age.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueurs4Age.TabIndex = 3
        Me.txt_Joueurs4Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Joueurs4Age
        '
        Me.lbl_Joueurs4Age.AutoSize = True
        Me.lbl_Joueurs4Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueurs4Age.Location = New System.Drawing.Point(3, 94)
        Me.lbl_Joueurs4Age.Name = "lbl_Joueurs4Age"
        Me.lbl_Joueurs4Age.Size = New System.Drawing.Size(79, 95)
        Me.lbl_Joueurs4Age.TabIndex = 1
        Me.lbl_Joueurs4Age.Text = "Age:"
        Me.lbl_Joueurs4Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueurs4Nom
        '
        Me.txt_Joueurs4Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueurs4Nom.Location = New System.Drawing.Point(88, 37)
        Me.txt_Joueurs4Nom.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueurs4Nom.Name = "txt_Joueurs4Nom"
        Me.txt_Joueurs4Nom.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueurs4Nom.TabIndex = 2
        Me.txt_Joueurs4Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Joueur3, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 252)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(433, 243)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'lbl_Joueur3
        '
        Me.lbl_Joueur3.AutoSize = True
        Me.lbl_Joueur3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3.Location = New System.Drawing.Point(89, 0)
        Me.lbl_Joueur3.Name = "lbl_Joueur3"
        Me.lbl_Joueur3.Size = New System.Drawing.Size(341, 48)
        Me.lbl_Joueur3.TabIndex = 0
        Me.lbl_Joueur3.Text = "Joueur 3"
        Me.lbl_Joueur3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.txtJoueurs3Age, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Joueurs3Age, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Joueurs3Nom, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Joueur3Nom, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(89, 51)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(341, 189)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'txtJoueurs3Age
        '
        Me.txtJoueurs3Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJoueurs3Age.Location = New System.Drawing.Point(88, 131)
        Me.txtJoueurs3Age.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txtJoueurs3Age.Name = "txtJoueurs3Age"
        Me.txtJoueurs3Age.Size = New System.Drawing.Size(250, 20)
        Me.txtJoueurs3Age.TabIndex = 3
        Me.txtJoueurs3Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Joueurs3Age
        '
        Me.lbl_Joueurs3Age.AutoSize = True
        Me.lbl_Joueurs3Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueurs3Age.Location = New System.Drawing.Point(3, 94)
        Me.lbl_Joueurs3Age.Name = "lbl_Joueurs3Age"
        Me.lbl_Joueurs3Age.Size = New System.Drawing.Size(79, 95)
        Me.lbl_Joueurs3Age.TabIndex = 1
        Me.lbl_Joueurs3Age.Text = "Age:"
        Me.lbl_Joueurs3Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueurs3Nom
        '
        Me.txt_Joueurs3Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueurs3Nom.Location = New System.Drawing.Point(88, 37)
        Me.txt_Joueurs3Nom.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueurs3Nom.Name = "txt_Joueurs3Nom"
        Me.txt_Joueurs3Nom.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueurs3Nom.TabIndex = 2
        Me.txt_Joueurs3Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_joueur2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(442, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(433, 243)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'lbl_joueur2
        '
        Me.lbl_joueur2.AutoSize = True
        Me.lbl_joueur2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_joueur2.Location = New System.Drawing.Point(89, 0)
        Me.lbl_joueur2.Name = "lbl_joueur2"
        Me.lbl_joueur2.Size = New System.Drawing.Size(341, 48)
        Me.lbl_joueur2.TabIndex = 0
        Me.lbl_joueur2.Text = "Joueur 2"
        Me.lbl_joueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur2Age, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur2Age, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Joueur2Nom, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Joueur2Nom, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(89, 51)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(341, 189)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'txt_Joueur2Age
        '
        Me.txt_Joueur2Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2Age.Location = New System.Drawing.Point(88, 131)
        Me.txt_Joueur2Age.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueur2Age.Name = "txt_Joueur2Age"
        Me.txt_Joueur2Age.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueur2Age.TabIndex = 3
        Me.txt_Joueur2Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Joueur2Age
        '
        Me.lbl_Joueur2Age.AutoSize = True
        Me.lbl_Joueur2Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2Age.Location = New System.Drawing.Point(3, 94)
        Me.lbl_Joueur2Age.Name = "lbl_Joueur2Age"
        Me.lbl_Joueur2Age.Size = New System.Drawing.Size(79, 95)
        Me.lbl_Joueur2Age.TabIndex = 1
        Me.lbl_Joueur2Age.Text = "Age:"
        Me.lbl_Joueur2Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur2Nom
        '
        Me.txt_Joueur2Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur2Nom.Location = New System.Drawing.Point(88, 37)
        Me.txt_Joueur2Nom.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueur2Nom.Name = "txt_Joueur2Nom"
        Me.txt_Joueur2Nom.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueur2Nom.TabIndex = 2
        Me.txt_Joueur2Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Joueur1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(433, 243)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'lbl_Joueur1
        '
        Me.lbl_Joueur1.AutoSize = True
        Me.lbl_Joueur1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1.Location = New System.Drawing.Point(89, 0)
        Me.lbl_Joueur1.Name = "lbl_Joueur1"
        Me.lbl_Joueur1.Size = New System.Drawing.Size(341, 48)
        Me.lbl_Joueur1.TabIndex = 0
        Me.lbl_Joueur1.Text = "Joueur 1"
        Me.lbl_Joueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur1Age, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur1Age, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Joueur1Nom, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Joueur1Nom, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(89, 51)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(341, 189)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txt_Joueur1Age
        '
        Me.txt_Joueur1Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1Age.Location = New System.Drawing.Point(88, 131)
        Me.txt_Joueur1Age.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueur1Age.Name = "txt_Joueur1Age"
        Me.txt_Joueur1Age.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueur1Age.TabIndex = 3
        Me.txt_Joueur1Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Joueur1Age
        '
        Me.lbl_Joueur1Age.AutoSize = True
        Me.lbl_Joueur1Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1Age.Location = New System.Drawing.Point(3, 94)
        Me.lbl_Joueur1Age.Name = "lbl_Joueur1Age"
        Me.lbl_Joueur1Age.Size = New System.Drawing.Size(79, 95)
        Me.lbl_Joueur1Age.TabIndex = 1
        Me.lbl_Joueur1Age.Text = "Age:"
        Me.lbl_Joueur1Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Joueur1Nom
        '
        Me.txt_Joueur1Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Joueur1Nom.Location = New System.Drawing.Point(88, 37)
        Me.txt_Joueur1Nom.Margin = New System.Windows.Forms.Padding(3, 37, 3, 37)
        Me.txt_Joueur1Nom.Name = "txt_Joueur1Nom"
        Me.txt_Joueur1Nom.Size = New System.Drawing.Size(250, 20)
        Me.txt_Joueur1Nom.TabIndex = 2
        Me.txt_Joueur1Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.cmd_confirmer, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.cmd_Retour, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 507)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(878, 51)
        Me.TableLayoutPanel11.TabIndex = 2
        '
        'cmd_confirmer
        '
        Me.cmd_confirmer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_confirmer.Location = New System.Drawing.Point(3, 3)
        Me.cmd_confirmer.Name = "cmd_confirmer"
        Me.cmd_confirmer.Size = New System.Drawing.Size(433, 45)
        Me.cmd_confirmer.TabIndex = 0
        Me.cmd_confirmer.Text = "Confirmer"
        Me.cmd_confirmer.UseVisualStyleBackColor = True
        '
        'cmd_Retour
        '
        Me.cmd_Retour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Retour.Location = New System.Drawing.Point(442, 3)
        Me.cmd_Retour.Name = "cmd_Retour"
        Me.cmd_Retour.Size = New System.Drawing.Size(433, 45)
        Me.cmd_Retour.TabIndex = 1
        Me.cmd_Retour.Text = "Retour"
        Me.cmd_Retour.UseVisualStyleBackColor = True
        '
        'lbl_Joueur1Nom
        '
        Me.lbl_Joueur1Nom.AutoSize = True
        Me.lbl_Joueur1Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur1Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur1Nom.Name = "lbl_Joueur1Nom"
        Me.lbl_Joueur1Nom.Size = New System.Drawing.Size(79, 94)
        Me.lbl_Joueur1Nom.TabIndex = 4
        Me.lbl_Joueur1Nom.Text = "Nom:"
        Me.lbl_Joueur1Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur2Nom
        '
        Me.lbl_Joueur2Nom.AutoSize = True
        Me.lbl_Joueur2Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur2Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur2Nom.Name = "lbl_Joueur2Nom"
        Me.lbl_Joueur2Nom.Size = New System.Drawing.Size(79, 94)
        Me.lbl_Joueur2Nom.TabIndex = 4
        Me.lbl_Joueur2Nom.Text = "Nom:"
        Me.lbl_Joueur2Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur4Nom
        '
        Me.lbl_Joueur4Nom.AutoSize = True
        Me.lbl_Joueur4Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur4Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur4Nom.Name = "lbl_Joueur4Nom"
        Me.lbl_Joueur4Nom.Size = New System.Drawing.Size(79, 94)
        Me.lbl_Joueur4Nom.TabIndex = 4
        Me.lbl_Joueur4Nom.Text = "Nom:"
        Me.lbl_Joueur4Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Joueur3Nom
        '
        Me.lbl_Joueur3Nom.AutoSize = True
        Me.lbl_Joueur3Nom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Joueur3Nom.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Joueur3Nom.Name = "lbl_Joueur3Nom"
        Me.lbl_Joueur3Nom.Size = New System.Drawing.Size(79, 94)
        Me.lbl_Joueur3Nom.TabIndex = 4
        Me.lbl_Joueur3Nom.Text = "Nom:"
        Me.lbl_Joueur3Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
>>>>>>> master
        '
        'frm_nouvelle_partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_nouvelle_partie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.TableLayoutPanel1.ResumeLayout(False)
<<<<<<< HEAD
        Me.TableLayoutPanel1.PerformLayout()
=======
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
>>>>>>> master
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
<<<<<<< HEAD
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_2joueurs As Button
    Friend WithEvents btn_4joueurs As Button
    Friend WithEvents btn_3joueurs As Button
    Friend WithEvents btn_retour As Button
=======
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lbl_Joueurs4 As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents txt_Joueurs4Age As TextBox
    Friend WithEvents lbl_Joueurs4Age As Label
    Friend WithEvents txt_Joueurs4Nom As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lbl_Joueur3 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txtJoueurs3Age As TextBox
    Friend WithEvents lbl_Joueurs3Age As Label
    Friend WithEvents txt_Joueurs3Nom As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lbl_joueur2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents txt_Joueur2Age As TextBox
    Friend WithEvents lbl_Joueur2Age As Label
    Friend WithEvents txt_Joueur2Nom As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_Joueur1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_Joueur1Age As TextBox
    Friend WithEvents lbl_Joueur1Age As Label
    Friend WithEvents txt_Joueur1Nom As TextBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents cmd_confirmer As Button
    Friend WithEvents cmd_Retour As Button
    Friend WithEvents lbl_Joueur4Nom As Label
    Friend WithEvents lbl_Joueur3Nom As Label
    Friend WithEvents lbl_Joueur2Nom As Label
    Friend WithEvents lbl_Joueur1Nom As Label
>>>>>>> master
End Class
