<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmazPrimelauncher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AmazPrimelauncher))
        Me.txt_Pool = New System.Windows.Forms.TextBox()
        Me.lbl_Pool = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.btn_Mining = New System.Windows.Forms.Button()
        Me.btn_Opzioni = New System.Windows.Forms.Button()
        Me.Notifica = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lnk_Info = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'txt_Pool
        '
        Me.txt_Pool.Location = New System.Drawing.Point(86, 16)
        Me.txt_Pool.Name = "txt_Pool"
        Me.txt_Pool.Size = New System.Drawing.Size(121, 20)
        Me.txt_Pool.TabIndex = 0
        '
        'lbl_Pool
        '
        Me.lbl_Pool.AutoSize = True
        Me.lbl_Pool.Location = New System.Drawing.Point(53, 19)
        Me.lbl_Pool.Name = "lbl_Pool"
        Me.lbl_Pool.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Pool.TabIndex = 1
        Me.lbl_Pool.Text = "Pool:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(14, 45)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Username.TabIndex = 2
        Me.lbl_Username.Text = "User.Worker:"
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(86, 42)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(121, 20)
        Me.txt_Username.TabIndex = 3
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(86, 68)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(121, 20)
        Me.txt_Password.TabIndex = 4
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Location = New System.Drawing.Point(28, 71)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Password.TabIndex = 5
        Me.lbl_Password.Text = "Password:"
        '
        'btn_Mining
        '
        Me.btn_Mining.Location = New System.Drawing.Point(127, 94)
        Me.btn_Mining.Name = "btn_Mining"
        Me.btn_Mining.Size = New System.Drawing.Size(80, 21)
        Me.btn_Mining.TabIndex = 0
        Me.btn_Mining.Text = "Start mining"
        Me.btn_Mining.UseVisualStyleBackColor = True
        '
        'btn_Opzioni
        '
        Me.btn_Opzioni.Location = New System.Drawing.Point(12, 94)
        Me.btn_Opzioni.Name = "btn_Opzioni"
        Me.btn_Opzioni.Size = New System.Drawing.Size(80, 21)
        Me.btn_Opzioni.TabIndex = 6
        Me.btn_Opzioni.Text = "Options"
        Me.btn_Opzioni.UseVisualStyleBackColor = True
        '
        'Notifica
        '
        Me.Notifica.Icon = CType(resources.GetObject("Notifica.Icon"), System.Drawing.Icon)
        Me.Notifica.Text = "Amaz Primelauncher"
        Me.Notifica.Visible = True
        '
        'lnk_Info
        '
        Me.lnk_Info.AutoSize = True
        Me.lnk_Info.Location = New System.Drawing.Point(103, 98)
        Me.lnk_Info.Name = "lnk_Info"
        Me.lnk_Info.Size = New System.Drawing.Size(13, 13)
        Me.lnk_Info.TabIndex = 7
        Me.lnk_Info.TabStop = True
        Me.lnk_Info.Text = "?"
        '
        'AmazPrimelauncher
        '
        Me.AcceptButton = Me.btn_Mining
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 125)
        Me.Controls.Add(Me.lnk_Info)
        Me.Controls.Add(Me.btn_Opzioni)
        Me.Controls.Add(Me.btn_Mining)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Pool)
        Me.Controls.Add(Me.txt_Pool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AmazPrimelauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amaz Primelauncher"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Pool As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Pool As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents btn_Mining As System.Windows.Forms.Button
    Friend WithEvents btn_Opzioni As System.Windows.Forms.Button
    Friend WithEvents Notifica As System.Windows.Forms.NotifyIcon
    Friend WithEvents lnk_Info As System.Windows.Forms.LinkLabel

End Class
