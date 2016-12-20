<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preziario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preziario))
        Me.LblDataInit = New System.Windows.Forms.Label()
        Me.LblDataFin = New System.Windows.Forms.Label()
        Me.MonthCalInizio = New System.Windows.Forms.MonthCalendar()
        Me.TxtInizio = New System.Windows.Forms.TextBox()
        Me.TxtFine = New System.Windows.Forms.TextBox()
        Me.MonthCalFine = New System.Windows.Forms.MonthCalendar()
        Me.TxtPrezBilo = New System.Windows.Forms.TextBox()
        Me.TxtPrezTrilo1 = New System.Windows.Forms.TextBox()
        Me.TxtPrezTrilo2 = New System.Windows.Forms.TextBox()
        Me.LblPrezB = New System.Windows.Forms.Label()
        Me.LblPrezT1 = New System.Windows.Forms.Label()
        Me.LblPrezT2 = New System.Windows.Forms.Label()
        Me.BtnAggiungi = New System.Windows.Forms.Button()
        Me.DataGridVPrezzi = New System.Windows.Forms.DataGridView()
        Me.LblPrezzi = New System.Windows.Forms.Label()
        Me.BtnLeggi = New System.Windows.Forms.Button()
        Me.BtnScrivi = New System.Windows.Forms.Button()
        Me.BtnElimina = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        CType(Me.DataGridVPrezzi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDataInit
        '
        Me.LblDataInit.AutoSize = True
        Me.LblDataInit.Location = New System.Drawing.Point(31, 29)
        Me.LblDataInit.Name = "LblDataInit"
        Me.LblDataInit.Size = New System.Drawing.Size(57, 13)
        Me.LblDataInit.TabIndex = 0
        Me.LblDataInit.Text = "Data Inizio"
        '
        'LblDataFin
        '
        Me.LblDataFin.AutoSize = True
        Me.LblDataFin.Location = New System.Drawing.Point(148, 29)
        Me.LblDataFin.Name = "LblDataFin"
        Me.LblDataFin.Size = New System.Drawing.Size(53, 13)
        Me.LblDataFin.TabIndex = 1
        Me.LblDataFin.Text = "Data Fine"
        '
        'MonthCalInizio
        '
        Me.MonthCalInizio.Location = New System.Drawing.Point(144, 60)
        Me.MonthCalInizio.Name = "MonthCalInizio"
        Me.MonthCalInizio.TabIndex = 2
        Me.MonthCalInizio.Visible = False
        '
        'TxtInizio
        '
        Me.TxtInizio.Location = New System.Drawing.Point(35, 60)
        Me.TxtInizio.Name = "TxtInizio"
        Me.TxtInizio.ReadOnly = True
        Me.TxtInizio.Size = New System.Drawing.Size(110, 20)
        Me.TxtInizio.TabIndex = 3
        '
        'TxtFine
        '
        Me.TxtFine.Location = New System.Drawing.Point(151, 60)
        Me.TxtFine.Name = "TxtFine"
        Me.TxtFine.ReadOnly = True
        Me.TxtFine.Size = New System.Drawing.Size(120, 20)
        Me.TxtFine.TabIndex = 4
        '
        'MonthCalFine
        '
        Me.MonthCalFine.Location = New System.Drawing.Point(268, 60)
        Me.MonthCalFine.Name = "MonthCalFine"
        Me.MonthCalFine.TabIndex = 5
        Me.MonthCalFine.Visible = False
        '
        'TxtPrezBilo
        '
        Me.TxtPrezBilo.Location = New System.Drawing.Point(277, 60)
        Me.TxtPrezBilo.Name = "TxtPrezBilo"
        Me.TxtPrezBilo.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrezBilo.TabIndex = 6
        '
        'TxtPrezTrilo1
        '
        Me.TxtPrezTrilo1.Location = New System.Drawing.Point(403, 60)
        Me.TxtPrezTrilo1.Name = "TxtPrezTrilo1"
        Me.TxtPrezTrilo1.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrezTrilo1.TabIndex = 7
        '
        'TxtPrezTrilo2
        '
        Me.TxtPrezTrilo2.Location = New System.Drawing.Point(529, 60)
        Me.TxtPrezTrilo2.Name = "TxtPrezTrilo2"
        Me.TxtPrezTrilo2.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrezTrilo2.TabIndex = 8
        '
        'LblPrezB
        '
        Me.LblPrezB.AutoSize = True
        Me.LblPrezB.Location = New System.Drawing.Point(274, 29)
        Me.LblPrezB.Name = "LblPrezB"
        Me.LblPrezB.Size = New System.Drawing.Size(59, 13)
        Me.LblPrezB.TabIndex = 10
        Me.LblPrezB.Text = "Prezzo Bilo"
        '
        'LblPrezT1
        '
        Me.LblPrezT1.AutoSize = True
        Me.LblPrezT1.Location = New System.Drawing.Point(400, 29)
        Me.LblPrezT1.Name = "LblPrezT1"
        Me.LblPrezT1.Size = New System.Drawing.Size(62, 13)
        Me.LblPrezT1.TabIndex = 11
        Me.LblPrezT1.Text = "Prezzo Trilo"
        '
        'LblPrezT2
        '
        Me.LblPrezT2.AutoSize = True
        Me.LblPrezT2.Location = New System.Drawing.Point(526, 29)
        Me.LblPrezT2.Name = "LblPrezT2"
        Me.LblPrezT2.Size = New System.Drawing.Size(71, 13)
        Me.LblPrezT2.TabIndex = 12
        Me.LblPrezT2.Text = "Prezzo Trilo 2"
        '
        'BtnAggiungi
        '
        Me.BtnAggiungi.Location = New System.Drawing.Point(680, 51)
        Me.BtnAggiungi.Name = "BtnAggiungi"
        Me.BtnAggiungi.Size = New System.Drawing.Size(99, 40)
        Me.BtnAggiungi.TabIndex = 13
        Me.BtnAggiungi.Text = "Aggiungi"
        Me.BtnAggiungi.UseVisualStyleBackColor = True
        '
        'DataGridVPrezzi
        '
        Me.DataGridVPrezzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVPrezzi.Location = New System.Drawing.Point(38, 126)
        Me.DataGridVPrezzi.Name = "DataGridVPrezzi"
        Me.DataGridVPrezzi.Size = New System.Drawing.Size(610, 347)
        Me.DataGridVPrezzi.TabIndex = 14
        '
        'LblPrezzi
        '
        Me.LblPrezzi.AutoSize = True
        Me.LblPrezzi.Location = New System.Drawing.Point(35, 101)
        Me.LblPrezzi.Name = "LblPrezzi"
        Me.LblPrezzi.Size = New System.Drawing.Size(35, 13)
        Me.LblPrezzi.TabIndex = 15
        Me.LblPrezzi.Text = "Prezzi"
        '
        'BtnLeggi
        '
        Me.BtnLeggi.Location = New System.Drawing.Point(680, 101)
        Me.BtnLeggi.Name = "BtnLeggi"
        Me.BtnLeggi.Size = New System.Drawing.Size(99, 40)
        Me.BtnLeggi.TabIndex = 16
        Me.BtnLeggi.Text = "Leggi"
        Me.BtnLeggi.UseVisualStyleBackColor = True
        '
        'BtnScrivi
        '
        Me.BtnScrivi.Location = New System.Drawing.Point(680, 156)
        Me.BtnScrivi.Name = "BtnScrivi"
        Me.BtnScrivi.Size = New System.Drawing.Size(99, 40)
        Me.BtnScrivi.TabIndex = 17
        Me.BtnScrivi.Text = "Scrivi"
        Me.BtnScrivi.UseVisualStyleBackColor = True
        '
        'BtnElimina
        '
        Me.BtnElimina.Location = New System.Drawing.Point(680, 211)
        Me.BtnElimina.Name = "BtnElimina"
        Me.BtnElimina.Size = New System.Drawing.Size(99, 40)
        Me.BtnElimina.TabIndex = 18
        Me.BtnElimina.Text = "Elimina"
        Me.BtnElimina.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(680, 266)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(99, 40)
        Me.BtnOk.TabIndex = 19
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Preziario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(794, 552)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnElimina)
        Me.Controls.Add(Me.BtnScrivi)
        Me.Controls.Add(Me.BtnLeggi)
        Me.Controls.Add(Me.LblPrezzi)
        Me.Controls.Add(Me.DataGridVPrezzi)
        Me.Controls.Add(Me.BtnAggiungi)
        Me.Controls.Add(Me.LblPrezT2)
        Me.Controls.Add(Me.LblPrezT1)
        Me.Controls.Add(Me.LblPrezB)
        Me.Controls.Add(Me.TxtPrezTrilo2)
        Me.Controls.Add(Me.TxtPrezTrilo1)
        Me.Controls.Add(Me.TxtPrezBilo)
        Me.Controls.Add(Me.MonthCalFine)
        Me.Controls.Add(Me.TxtFine)
        Me.Controls.Add(Me.TxtInizio)
        Me.Controls.Add(Me.MonthCalInizio)
        Me.Controls.Add(Me.LblDataFin)
        Me.Controls.Add(Me.LblDataInit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Preziario"
        Me.Text = "Preziario"
        CType(Me.DataGridVPrezzi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDataInit As Label
    Friend WithEvents LblDataFin As Label
    Friend WithEvents MonthCalInizio As MonthCalendar
    Friend WithEvents TxtInizio As TextBox
    Friend WithEvents TxtFine As TextBox
    Friend WithEvents MonthCalFine As MonthCalendar
    Friend WithEvents TxtPrezBilo As TextBox
    Friend WithEvents TxtPrezTrilo1 As TextBox
    Friend WithEvents TxtPrezTrilo2 As TextBox
    Friend WithEvents LblPrezB As Label
    Friend WithEvents LblPrezT1 As Label
    Friend WithEvents LblPrezT2 As Label
    Friend WithEvents BtnAggiungi As Button
    Friend WithEvents DataGridVPrezzi As DataGridView
    Friend WithEvents LblPrezzi As Label
    Friend WithEvents BtnLeggi As Button
    Friend WithEvents BtnScrivi As Button
    Friend WithEvents BtnElimina As Button
    Friend WithEvents BtnOk As Button
End Class
