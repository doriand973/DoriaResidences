<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDestinatario = New System.Windows.Forms.TextBox()
        Me.TxtOggetto = New System.Windows.Forms.TextBox()
        Me.TxtTesto = New System.Windows.Forms.TextBox()
        Me.BtnInvia = New System.Windows.Forms.Button()
        Me.LstAllega = New System.Windows.Forms.ListBox()
        Me.BtnAllegaFile = New System.Windows.Forms.Button()
        Me.BtnAnnulla = New System.Windows.Forms.Button()
        Me.BtnRimuoviSel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBoxCcn = New System.Windows.Forms.CheckBox()
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
        Me.DatiPrezziario = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBoxAllega = New System.Windows.Forms.CheckBox()
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
        'TxtDestinatario
        '
        Me.TxtDestinatario.Location = New System.Drawing.Point(18, 82)
        Me.TxtDestinatario.Name = "TxtDestinatario"
        Me.TxtDestinatario.Size = New System.Drawing.Size(328, 20)
        Me.TxtDestinatario.TabIndex = 3
        '
        'TxtOggetto
        '
        Me.TxtOggetto.Location = New System.Drawing.Point(18, 138)
        Me.TxtOggetto.Name = "TxtOggetto"
        Me.TxtOggetto.Size = New System.Drawing.Size(452, 20)
        Me.TxtOggetto.TabIndex = 4
        '
        'TxtTesto
        '
        Me.TxtTesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTesto.Location = New System.Drawing.Point(18, 185)
        Me.TxtTesto.Multiline = True
        Me.TxtTesto.Name = "TxtTesto"
        Me.TxtTesto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtTesto.Size = New System.Drawing.Size(876, 200)
        Me.TxtTesto.TabIndex = 5
        '
        'BtnInvia
        '
        Me.BtnInvia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnInvia.Location = New System.Drawing.Point(23, 408)
        Me.BtnInvia.Name = "BtnInvia"
        Me.BtnInvia.Size = New System.Drawing.Size(103, 28)
        Me.BtnInvia.TabIndex = 6
        Me.BtnInvia.Text = "Invia"
        Me.BtnInvia.UseVisualStyleBackColor = True
        '
        'LstAllega
        '
        Me.LstAllega.AllowDrop = True
        Me.LstAllega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstAllega.FormattingEnabled = True
        Me.LstAllega.Location = New System.Drawing.Point(671, 33)
        Me.LstAllega.Name = "LstAllega"
        Me.LstAllega.Size = New System.Drawing.Size(210, 69)
        Me.LstAllega.TabIndex = 8
        '
        'BtnAllegaFile
        '
        Me.BtnAllegaFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAllegaFile.Location = New System.Drawing.Point(783, 108)
        Me.BtnAllegaFile.Name = "BtnAllegaFile"
        Me.BtnAllegaFile.Size = New System.Drawing.Size(98, 33)
        Me.BtnAllegaFile.TabIndex = 9
        Me.BtnAllegaFile.Text = "Allega File"
        Me.BtnAllegaFile.UseVisualStyleBackColor = True
        '
        'BtnAnnulla
        '
        Me.BtnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulla.Location = New System.Drawing.Point(152, 408)
        Me.BtnAnnulla.Name = "BtnAnnulla"
        Me.BtnAnnulla.Size = New System.Drawing.Size(103, 28)
        Me.BtnAnnulla.TabIndex = 10
        Me.BtnAnnulla.Text = "Annulla"
        Me.BtnAnnulla.UseVisualStyleBackColor = True
        '
        'BtnRimuoviSel
        '
        Me.BtnRimuoviSel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRimuoviSel.Location = New System.Drawing.Point(671, 108)
        Me.BtnRimuoviSel.Name = "BtnRimuoviSel"
        Me.BtnRimuoviSel.Size = New System.Drawing.Size(98, 33)
        Me.BtnRimuoviSel.TabIndex = 11
        Me.BtnRimuoviSel.Text = "Rimuovi sel"
        Me.BtnRimuoviSel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "G:\Documenti\000 Doria residences"
        '
        'CheckBoxCcn
        '
        Me.CheckBoxCcn.AutoSize = True
        Me.CheckBoxCcn.Checked = True
        Me.CheckBoxCcn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCcn.Location = New System.Drawing.Point(93, 49)
        Me.CheckBoxCcn.Name = "CheckBoxCcn"
        Me.CheckBoxCcn.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxCcn.TabIndex = 12
        Me.CheckBoxCcn.Text = "Ccn Doria"
        Me.CheckBoxCcn.UseVisualStyleBackColor = True
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
        Me.ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathFileLogToolStripMenuItem, Me.DatiMailToolStripMenuItem, Me.DatiPrezziario})
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
        'DatiPrezziario
        '
        Me.DatiPrezziario.Name = "DatiPrezziario"
        Me.DatiPrezziario.Size = New System.Drawing.Size(169, 22)
        Me.DatiPrezziario.Text = "Dati Prezziario"
        '
        'CheckBoxAllega
        '
        Me.CheckBoxAllega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxAllega.AutoSize = True
        Me.CheckBoxAllega.Location = New System.Drawing.Point(671, 147)
        Me.CheckBoxAllega.Name = "CheckBoxAllega"
        Me.CheckBoxAllega.Size = New System.Drawing.Size(161, 17)
        Me.CheckBoxAllega.TabIndex = 15
        Me.CheckBoxAllega.Text = "Allegati per informazioni STD"
        Me.CheckBoxAllega.UseVisualStyleBackColor = True
        '
        'FormMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 448)
        Me.Controls.Add(Me.CheckBoxAllega)
        Me.Controls.Add(Me.CheckBoxCcn)
        Me.Controls.Add(Me.BtnRimuoviSel)
        Me.Controls.Add(Me.BtnAnnulla)
        Me.Controls.Add(Me.BtnAllegaFile)
        Me.Controls.Add(Me.LstAllega)
        Me.Controls.Add(Me.BtnInvia)
        Me.Controls.Add(Me.TxtTesto)
        Me.Controls.Add(Me.TxtOggetto)
        Me.Controls.Add(Me.TxtDestinatario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMail"
        Me.Text = "Doria Residences Mail"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDestinatario As TextBox
    Friend WithEvents TxtOggetto As TextBox
    Friend WithEvents TxtTesto As TextBox
    Friend WithEvents BtnInvia As Button
    Friend WithEvents LstAllega As ListBox
    Friend WithEvents BtnAllegaFile As Button
    Friend WithEvents BtnAnnulla As Button
    Friend WithEvents BtnRimuoviSel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBoxCcn As CheckBox
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
    Friend WithEvents CheckBoxAllega As CheckBox
    Friend WithEvents BookingcomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatiPrezziario As ToolStripMenuItem
End Class
