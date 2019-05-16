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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_2joueurs = New System.Windows.Forms.Button()
        Me.btn_4joueurs = New System.Windows.Forms.Button()
        Me.btn_3joueurs = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
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
        '
        'frm_nouvelle_partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_nouvelle_partie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Qwirkle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_2joueurs As Button
    Friend WithEvents btn_4joueurs As Button
    Friend WithEvents btn_3joueurs As Button
    Friend WithEvents btn_retour As Button
End Class
