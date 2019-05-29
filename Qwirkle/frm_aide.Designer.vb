<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_aide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_aide))
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.lbl_regle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.helpclose = New System.Windows.Forms.Button()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'lbl_regle
        '
        Me.lbl_regle.AutoSize = True
        Me.lbl_regle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_regle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_regle.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_regle.Location = New System.Drawing.Point(0, 0)
        Me.lbl_regle.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_regle.Name = "lbl_regle"
        Me.lbl_regle.Size = New System.Drawing.Size(778, 99)
        Me.lbl_regle.TabIndex = 1
        Me.lbl_regle.Text = "Règles du jeu"
        Me.lbl_regle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.Qwirkle.My.Resources.Resources.arriere
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_regle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(778, 495)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox7, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 102)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(772, 340)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.Location = New System.Drawing.Point(389, 173)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.ReadOnly = True
        Me.RichTextBox7.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox7.TabIndex = 13
        Me.RichTextBox7.Text = resources.GetString("RichTextBox7.Text")
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.Location = New System.Drawing.Point(389, 88)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ReadOnly = True
        Me.RichTextBox6.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox6.TabIndex = 12
        Me.RichTextBox6.Text = resources.GetString("RichTextBox6.Text")
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.Location = New System.Drawing.Point(389, 3)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox5.TabIndex = 11
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(3, 173)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox4.TabIndex = 10
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 258)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox2.TabIndex = 8
        Me.RichTextBox2.Text = "But du jeu" & Global.Microsoft.VisualBasic.ChrW(10) & "Aligner des tuiles ayant des symboles de formes ou de couleurs indenti" &
    "ques de façon à réaliser des combinaisons rapportant un maximum de points."
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 88)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(380, 79)
        Me.RichTextBox3.TabIndex = 9
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.helpclose, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 448)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(772, 44)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'helpclose
        '
        Me.helpclose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.helpclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.helpclose.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpclose.ForeColor = System.Drawing.Color.Black
        Me.helpclose.Location = New System.Drawing.Point(260, 3)
        Me.helpclose.Name = "helpclose"
        Me.helpclose.Size = New System.Drawing.Size(251, 38)
        Me.helpclose.TabIndex = 0
        Me.helpclose.Text = "Fermer"
        Me.helpclose.UseVisualStyleBackColor = False
        '
        'frm_aide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 495)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_aide"
        Me.Text = "Qwirkle"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_regle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents helpclose As Button
End Class
