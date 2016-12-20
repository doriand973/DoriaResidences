<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.MonthCalArrivo = New System.Windows.Forms.MonthCalendar()
        Me.TxtDataArrivo = New System.Windows.Forms.TextBox()
        Me.TxtDataPartenza = New System.Windows.Forms.TextBox()
        Me.MonthCalPartenza = New System.Windows.Forms.MonthCalendar()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnCalcola = New System.Windows.Forms.Button()
        Me.ComboBoxAppartamento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAnnulCalc = New System.Windows.Forms.Button()
        Me.BtnOkPreventivo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrezzoFinale = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxAnimali = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExtra = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'MonthCalArrivo
        '
        Me.MonthCalArrivo.Location = New System.Drawing.Point(305, 18)
        Me.MonthCalArrivo.Name = "MonthCalArrivo"
        Me.MonthCalArrivo.ShowToday = False
        Me.MonthCalArrivo.TabIndex = 0
        Me.MonthCalArrivo.Visible = False
        '
        'TxtDataArrivo
        '
        Me.TxtDataArrivo.Location = New System.Drawing.Point(109, 25)
        Me.TxtDataArrivo.Name = "TxtDataArrivo"
        Me.TxtDataArrivo.Size = New System.Drawing.Size(184, 20)
        Me.TxtDataArrivo.TabIndex = 2
        '
        'TxtDataPartenza
        '
        Me.TxtDataPartenza.Location = New System.Drawing.Point(109, 68)
        Me.TxtDataPartenza.Name = "TxtDataPartenza"
        Me.TxtDataPartenza.Size = New System.Drawing.Size(184, 20)
        Me.TxtDataPartenza.TabIndex = 5
        '
        'MonthCalPartenza
        '
        Me.MonthCalPartenza.Location = New System.Drawing.Point(305, 68)
        Me.MonthCalPartenza.Name = "MonthCalPartenza"
        Me.MonthCalPartenza.ShowToday = False
        Me.MonthCalPartenza.TabIndex = 3
        Me.MonthCalPartenza.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(15, 145)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(738, 193)
        Me.TextBox3.TabIndex = 6
        '
        'BtnCalcola
        '
        Me.BtnCalcola.Location = New System.Drawing.Point(15, 102)
        Me.BtnCalcola.Name = "BtnCalcola"
        Me.BtnCalcola.Size = New System.Drawing.Size(95, 32)
        Me.BtnCalcola.TabIndex = 7
        Me.BtnCalcola.Text = "Calcola"
        Me.BtnCalcola.UseVisualStyleBackColor = True
        '
        'ComboBoxAppartamento
        '
        Me.ComboBoxAppartamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxAppartamento.FormattingEnabled = True
        Me.ComboBoxAppartamento.Items.AddRange(New Object() {"Bilo", "Trilo", "Trilo 2"})
        Me.ComboBoxAppartamento.Location = New System.Drawing.Point(646, 25)
        Me.ComboBoxAppartamento.Name = "ComboBoxAppartamento"
        Me.ComboBoxAppartamento.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxAppartamento.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(544, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo appartamento"
        '
        'BtnAnnulCalc
        '
        Me.BtnAnnulCalc.Location = New System.Drawing.Point(126, 102)
        Me.BtnAnnulCalc.Name = "BtnAnnulCalc"
        Me.BtnAnnulCalc.Size = New System.Drawing.Size(95, 32)
        Me.BtnAnnulCalc.TabIndex = 10
        Me.BtnAnnulCalc.Text = "Annulla"
        Me.BtnAnnulCalc.UseVisualStyleBackColor = True
        '
        'BtnOkPreventivo
        '
        Me.BtnOkPreventivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkPreventivo.Location = New System.Drawing.Point(650, 347)
        Me.BtnOkPreventivo.Name = "BtnOkPreventivo"
        Me.BtnOkPreventivo.Size = New System.Drawing.Size(95, 32)
        Me.BtnOkPreventivo.TabIndex = 14
        Me.BtnOkPreventivo.Text = "Ok"
        Me.BtnOkPreventivo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Data Arrivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Data Partenza"
        '
        'TxtPrezzoFinale
        '
        Me.TxtPrezzoFinale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrezzoFinale.Location = New System.Drawing.Point(646, 61)
        Me.TxtPrezzoFinale.Name = "TxtPrezzoFinale"
        Me.TxtPrezzoFinale.Size = New System.Drawing.Size(107, 20)
        Me.TxtPrezzoFinale.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Prezzo Finale"
        '
        'CheckBoxAnimali
        '
        Me.CheckBoxAnimali.AutoSize = True
        Me.CheckBoxAnimali.Location = New System.Drawing.Point(646, 102)
        Me.CheckBoxAnimali.Name = "CheckBoxAnimali"
        Me.CheckBoxAnimali.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxAnimali.TabIndex = 19
        Me.CheckBoxAnimali.Text = "Animali"
        Me.CheckBoxAnimali.UseVisualStyleBackColor = True
        '
        'CheckBoxExtra
        '
        Me.CheckBoxExtra.AutoSize = True
        Me.CheckBoxExtra.Location = New System.Drawing.Point(646, 122)
        Me.CheckBoxExtra.Name = "CheckBoxExtra"
        Me.CheckBoxExtra.Size = New System.Drawing.Size(50, 17)
        Me.CheckBoxExtra.TabIndex = 20
        Me.CheckBoxExtra.Text = "Extra"
        Me.CheckBoxExtra.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 391)
        Me.Controls.Add(Me.CheckBoxExtra)
        Me.Controls.Add(Me.CheckBoxAnimali)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPrezzoFinale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnOkPreventivo)
        Me.Controls.Add(Me.BtnAnnulCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxAppartamento)
        Me.Controls.Add(Me.BtnCalcola)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TxtDataPartenza)
        Me.Controls.Add(Me.MonthCalPartenza)
        Me.Controls.Add(Me.TxtDataArrivo)
        Me.Controls.Add(Me.MonthCalArrivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalArrivo As MonthCalendar
    Friend WithEvents TxtDataArrivo As TextBox
    Friend WithEvents TxtDataPartenza As TextBox
    Friend WithEvents MonthCalPartenza As MonthCalendar
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnCalcola As Button
    Friend WithEvents ComboBoxAppartamento As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAnnulCalc As Button
    Friend WithEvents BtnOkPreventivo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrezzoFinale As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxAnimali As CheckBox
    Friend WithEvents CheckBoxExtra As CheckBox
End Class
