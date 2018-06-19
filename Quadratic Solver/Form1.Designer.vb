<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quadraticSolver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nud_a = New System.Windows.Forms.NumericUpDown()
        Me.nud_b = New System.Windows.Forms.NumericUpDown()
        Me.nud_c = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_x1 = New System.Windows.Forms.Label()
        Me.lbl_x2 = New System.Windows.Forms.Label()
        Me.btn_solve = New System.Windows.Forms.Button()
        CType(Me.nud_a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_c, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud_a
        '
        Me.nud_a.Location = New System.Drawing.Point(53, 24)
        Me.nud_a.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_a.Name = "nud_a"
        Me.nud_a.Size = New System.Drawing.Size(48, 20)
        Me.nud_a.TabIndex = 0
        '
        'nud_b
        '
        Me.nud_b.Location = New System.Drawing.Point(53, 63)
        Me.nud_b.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_b.Name = "nud_b"
        Me.nud_b.Size = New System.Drawing.Size(48, 20)
        Me.nud_b.TabIndex = 1
        '
        'nud_c
        '
        Me.nud_c.Location = New System.Drawing.Point(53, 100)
        Me.nud_c.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_c.Name = "nud_c"
        Me.nud_c.Size = New System.Drawing.Size(48, 20)
        Me.nud_c.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "a = "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "b = "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "c = "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "x = "
        '
        'lbl_x1
        '
        Me.lbl_x1.AutoSize = True
        Me.lbl_x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_x1.Location = New System.Drawing.Point(284, 65)
        Me.lbl_x1.Name = "lbl_x1"
        Me.lbl_x1.Size = New System.Drawing.Size(24, 25)
        Me.lbl_x1.TabIndex = 8
        Me.lbl_x1.Text = "0"
        '
        'lbl_x2
        '
        Me.lbl_x2.AutoSize = True
        Me.lbl_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_x2.Location = New System.Drawing.Point(284, 100)
        Me.lbl_x2.Name = "lbl_x2"
        Me.lbl_x2.Size = New System.Drawing.Size(24, 25)
        Me.lbl_x2.TabIndex = 9
        Me.lbl_x2.Text = "0"
        '
        'btn_solve
        '
        Me.btn_solve.Location = New System.Drawing.Point(125, 97)
        Me.btn_solve.Name = "btn_solve"
        Me.btn_solve.Size = New System.Drawing.Size(75, 23)
        Me.btn_solve.TabIndex = 10
        Me.btn_solve.Text = "Solve"
        Me.btn_solve.UseVisualStyleBackColor = True
        '
        'frm_quadraticSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 151)
        Me.Controls.Add(Me.btn_solve)
        Me.Controls.Add(Me.lbl_x2)
        Me.Controls.Add(Me.lbl_x1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nud_c)
        Me.Controls.Add(Me.nud_b)
        Me.Controls.Add(Me.nud_a)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_quadraticSolver"
        Me.Text = "Quadratic Formula Solver"
        CType(Me.nud_a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_c, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nud_a As NumericUpDown
    Friend WithEvents nud_b As NumericUpDown
    Friend WithEvents nud_c As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_x1 As Label
    Friend WithEvents lbl_x2 As Label
    Friend WithEvents btn_solve As Button
End Class
