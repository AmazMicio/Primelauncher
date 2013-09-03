<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opzioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opzioni))
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.lbl_SieveSize = New System.Windows.Forms.Label()
        Me.num_SieveSize = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Threads = New System.Windows.Forms.Label()
        Me.rad_SieveON = New System.Windows.Forms.RadioButton()
        Me.rad_SieveOFF = New System.Windows.Forms.RadioButton()
        Me.rad_ThreadOFF = New System.Windows.Forms.RadioButton()
        Me.rad_ThreadON = New System.Windows.Forms.RadioButton()
        Me.num_Thread = New System.Windows.Forms.NumericUpDown()
        Me.rad_HideOFF = New System.Windows.Forms.RadioButton()
        Me.rad_HideON = New System.Windows.Forms.RadioButton()
        Me.lbl_Miner = New System.Windows.Forms.Label()
        Me.btn_Salva = New System.Windows.Forms.Button()
        CType(Me.num_SieveSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Thread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(12, 230)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(80, 21)
        Me.btn_Reset.TabIndex = 0
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'lbl_SieveSize
        '
        Me.lbl_SieveSize.AutoSize = True
        Me.lbl_SieveSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SieveSize.Location = New System.Drawing.Point(25, 9)
        Me.lbl_SieveSize.Name = "lbl_SieveSize"
        Me.lbl_SieveSize.Size = New System.Drawing.Size(80, 20)
        Me.lbl_SieveSize.TabIndex = 2
        Me.lbl_SieveSize.Text = "Sieve size"
        '
        'num_SieveSize
        '
        Me.num_SieveSize.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_SieveSize.Location = New System.Drawing.Point(29, 55)
        Me.num_SieveSize.Maximum = New Decimal(New Integer() {30000000, 0, 0, 0})
        Me.num_SieveSize.Minimum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_SieveSize.Name = "num_SieveSize"
        Me.num_SieveSize.Size = New System.Drawing.Size(67, 20)
        Me.num_SieveSize.TabIndex = 3
        Me.num_SieveSize.Value = New Decimal(New Integer() {1500000, 0, 0, 0})
        Me.num_SieveSize.Visible = False
        '
        'lbl_Threads
        '
        Me.lbl_Threads.AutoSize = True
        Me.lbl_Threads.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Threads.Location = New System.Drawing.Point(25, 91)
        Me.lbl_Threads.Name = "lbl_Threads"
        Me.lbl_Threads.Size = New System.Drawing.Size(67, 20)
        Me.lbl_Threads.TabIndex = 4
        Me.lbl_Threads.Text = "Threads"
        '
        'rad_SieveON
        '
        Me.rad_SieveON.AutoCheck = False
        Me.rad_SieveON.AutoSize = True
        Me.rad_SieveON.Checked = True
        Me.rad_SieveON.Location = New System.Drawing.Point(29, 32)
        Me.rad_SieveON.Name = "rad_SieveON"
        Me.rad_SieveON.Size = New System.Drawing.Size(72, 17)
        Me.rad_SieveON.TabIndex = 5
        Me.rad_SieveON.Text = "Automatic"
        Me.rad_SieveON.UseVisualStyleBackColor = True
        '
        'rad_SieveOFF
        '
        Me.rad_SieveOFF.AutoCheck = False
        Me.rad_SieveOFF.AutoSize = True
        Me.rad_SieveOFF.Location = New System.Drawing.Point(107, 32)
        Me.rad_SieveOFF.Name = "rad_SieveOFF"
        Me.rad_SieveOFF.Size = New System.Drawing.Size(60, 17)
        Me.rad_SieveOFF.TabIndex = 6
        Me.rad_SieveOFF.Text = "Manual"
        Me.rad_SieveOFF.UseVisualStyleBackColor = True
        '
        'rad_ThreadOFF
        '
        Me.rad_ThreadOFF.AutoCheck = False
        Me.rad_ThreadOFF.AutoSize = True
        Me.rad_ThreadOFF.Location = New System.Drawing.Point(107, 114)
        Me.rad_ThreadOFF.Name = "rad_ThreadOFF"
        Me.rad_ThreadOFF.Size = New System.Drawing.Size(60, 17)
        Me.rad_ThreadOFF.TabIndex = 9
        Me.rad_ThreadOFF.Text = "Manual"
        Me.rad_ThreadOFF.UseVisualStyleBackColor = True
        '
        'rad_ThreadON
        '
        Me.rad_ThreadON.AutoCheck = False
        Me.rad_ThreadON.AutoSize = True
        Me.rad_ThreadON.Checked = True
        Me.rad_ThreadON.Location = New System.Drawing.Point(29, 114)
        Me.rad_ThreadON.Name = "rad_ThreadON"
        Me.rad_ThreadON.Size = New System.Drawing.Size(72, 17)
        Me.rad_ThreadON.TabIndex = 8
        Me.rad_ThreadON.TabStop = True
        Me.rad_ThreadON.Text = "Automatic"
        Me.rad_ThreadON.UseVisualStyleBackColor = True
        '
        'num_Thread
        '
        Me.num_Thread.Location = New System.Drawing.Point(29, 137)
        Me.num_Thread.Name = "num_Thread"
        Me.num_Thread.Size = New System.Drawing.Size(46, 20)
        Me.num_Thread.TabIndex = 7
        Me.num_Thread.Value = New Decimal(New Integer() {4, 0, 0, 0})
        Me.num_Thread.Visible = False
        '
        'rad_HideOFF
        '
        Me.rad_HideOFF.AutoCheck = False
        Me.rad_HideOFF.AutoSize = True
        Me.rad_HideOFF.Checked = True
        Me.rad_HideOFF.Location = New System.Drawing.Point(29, 196)
        Me.rad_HideOFF.Name = "rad_HideOFF"
        Me.rad_HideOFF.Size = New System.Drawing.Size(39, 17)
        Me.rad_HideOFF.TabIndex = 13
        Me.rad_HideOFF.Text = "No"
        Me.rad_HideOFF.UseVisualStyleBackColor = True
        '
        'rad_HideON
        '
        Me.rad_HideON.AutoCheck = False
        Me.rad_HideON.AutoSize = True
        Me.rad_HideON.Location = New System.Drawing.Point(107, 196)
        Me.rad_HideON.Name = "rad_HideON"
        Me.rad_HideON.Size = New System.Drawing.Size(43, 17)
        Me.rad_HideON.TabIndex = 12
        Me.rad_HideON.TabStop = True
        Me.rad_HideON.Text = "Yes"
        Me.rad_HideON.UseVisualStyleBackColor = True
        '
        'lbl_Miner
        '
        Me.lbl_Miner.AutoSize = True
        Me.lbl_Miner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Miner.Location = New System.Drawing.Point(25, 173)
        Me.lbl_Miner.Name = "lbl_Miner"
        Me.lbl_Miner.Size = New System.Drawing.Size(85, 20)
        Me.lbl_Miner.TabIndex = 10
        Me.lbl_Miner.Text = "Hide miner"
        '
        'btn_Salva
        '
        Me.btn_Salva.Location = New System.Drawing.Point(95, 230)
        Me.btn_Salva.Name = "btn_Salva"
        Me.btn_Salva.Size = New System.Drawing.Size(80, 21)
        Me.btn_Salva.TabIndex = 14
        Me.btn_Salva.Text = "Save"
        Me.btn_Salva.UseVisualStyleBackColor = True
        '
        'Opzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 262)
        Me.Controls.Add(Me.btn_Salva)
        Me.Controls.Add(Me.rad_HideOFF)
        Me.Controls.Add(Me.rad_HideON)
        Me.Controls.Add(Me.lbl_Miner)
        Me.Controls.Add(Me.rad_ThreadOFF)
        Me.Controls.Add(Me.rad_ThreadON)
        Me.Controls.Add(Me.num_Thread)
        Me.Controls.Add(Me.rad_SieveOFF)
        Me.Controls.Add(Me.rad_SieveON)
        Me.Controls.Add(Me.lbl_Threads)
        Me.Controls.Add(Me.num_SieveSize)
        Me.Controls.Add(Me.lbl_SieveSize)
        Me.Controls.Add(Me.btn_Reset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Opzioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        CType(Me.num_SieveSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Thread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Reset As System.Windows.Forms.Button
    Friend WithEvents lbl_SieveSize As System.Windows.Forms.Label
    Friend WithEvents num_SieveSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_Threads As System.Windows.Forms.Label
    Friend WithEvents rad_SieveON As System.Windows.Forms.RadioButton
    Friend WithEvents rad_SieveOFF As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ThreadOFF As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ThreadON As System.Windows.Forms.RadioButton
    Friend WithEvents num_Thread As System.Windows.Forms.NumericUpDown
    Friend WithEvents rad_HideOFF As System.Windows.Forms.RadioButton
    Friend WithEvents rad_HideON As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Miner As System.Windows.Forms.Label
    Friend WithEvents btn_Salva As System.Windows.Forms.Button
End Class
