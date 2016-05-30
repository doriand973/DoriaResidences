<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StrumentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DettagliMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreventivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinguaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalianoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngleseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathFileLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatiMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destinatario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Oggetto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(596, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Allegati"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(18, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(452, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(18, 185)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(876, 200)
        Me.TextBox3.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(23, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Invia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(671, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 69)
        Me.ListBox1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(783, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Allega File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(152, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 28)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Annulla"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(671, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 33)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Rimuovi sel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "G:\Documenti\000 Doria residences"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(93, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Ccn Doria"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StrumentiToolStripMenuItem, Me.LinguaToolStripMenuItem, Me.ImpostazioniToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(906, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DettagliMailToolStripMenuItem, Me.PreventivoToolStripMenuItem, Me.BookingcomToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        Me.StrumentiToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.StrumentiToolStripMenuItem.Text = "Strumenti"
        '
        'DettagliMailToolStripMenuItem
        '
        Me.DettagliMailToolStripMenuItem.Name = "DettagliMailToolStripMenuItem"
        Me.DettagliMailToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DettagliMailToolStripMenuItem.Text = "Dettagli Mail"
        '
        'PreventivoToolStripMenuItem
        '
        Me.PreventivoToolStripMenuItem.Name = "PreventivoToolStripMenuItem"
        Me.PreventivoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PreventivoToolStripMenuItem.Text = "Preventivo"
        '
        'BookingcomToolStripMenuItem
        '
        Me.BookingcomToolStripMenuItem.Name = "BookingcomToolStripMenuItem"
        Me.BookingcomToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BookingcomToolStripMenuItem.Text = "Booking.com"
        '
        'LinguaToolStripMenuItem
        '
        Me.LinguaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItalianoToolStripMenuItem, Me.IngleseToolStripMenuItem})
        Me.LinguaToolStripMenuItem.Name = "LinguaToolStripMenuItem"
        Me.LinguaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LinguaToolStripMenuItem.Text = "Lingua"
        '
        'ItalianoToolStripMenuItem
        '
        Me.ItalianoToolStripMenuItem.Checked = True
        Me.ItalianoToolStripMenuItem.CheckOnClick = True
        Me.ItalianoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItalianoToolStripMenuItem.Name = "ItalianoToolStripMenuItem"
        Me.ItalianoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ItalianoToolStripMenuItem.Text = "Italiano"
        '
        'IngleseToolStripMenuItem
        '
        Me.IngleseToolStripMenuItem.CheckOnClick = True
        Me.IngleseToolStripMenuItem.Name = "IngleseToolStripMenuItem"
        Me.IngleseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.IngleseToolStripMenuItem.Text = "Inglese"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathFileLogToolStripMenuItem, Me.DatiMailToolStripMenuItem})
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'PathFileLogToolStripMenuItem
        '
        Me.PathFileLogToolStripMenuItem.Name = "PathFileLogToolStripMenuItem"
        Me.PathFileLogToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PathFileLogToolStripMenuItem.Text = "Path file Log"
        '
        'DatiMailToolStripMenuItem
        '
        Me.DatiMailToolStripMenuItem.Name = "DatiMailToolStripMenuItem"
        Me.DatiMailToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DatiMailToolStripMenuItem.Text = "Dati Account Mail"
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(671, 147)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(161, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Allegati per informazioni STD"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 448)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Doria Residences Mail"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StrumentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DettagliMailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreventivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinguaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalianoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngleseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PathFileLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents DatiMailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BookingcomToolStripMenuItem As ToolStripMenuItem
End Class
