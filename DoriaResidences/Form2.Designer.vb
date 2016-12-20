<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNomeDest = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioBtnPreventivo = New System.Windows.Forms.RadioButton()
        Me.RadioBtnConferma = New System.Windows.Forms.RadioButton()
        Me.RadioBtnInfo = New System.Windows.Forms.RadioButton()
        Me.RadioBtnFattura = New System.Windows.Forms.RadioButton()
        Me.RadioBtnConfPrenot = New System.Windows.Forms.RadioButton()
        Me.RadioBtnBooking = New System.Windows.Forms.RadioButton()
        Me.RadioBtnUomo = New System.Windows.Forms.RadioButton()
        Me.RadioBtnDonna = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioBtnTO = New System.Windows.Forms.RadioButton()
        Me.RadioBtnGenerale = New System.Windows.Forms.RadioButton()
        Me.BtnAvvia = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destinatario"
        '
        'TxtNomeDest
        '
        Me.TxtNomeDest.Location = New System.Drawing.Point(28, 51)
        Me.TxtNomeDest.Name = "TxtNomeDest"
        Me.TxtNomeDest.Size = New System.Drawing.Size(233, 20)
        Me.TxtNomeDest.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioBtnPreventivo)
        Me.GroupBox2.Controls.Add(Me.RadioBtnConferma)
        Me.GroupBox2.Controls.Add(Me.RadioBtnInfo)
        Me.GroupBox2.Controls.Add(Me.RadioBtnFattura)
        Me.GroupBox2.Controls.Add(Me.RadioBtnConfPrenot)
        Me.GroupBox2.Controls.Add(Me.RadioBtnBooking)
        Me.GroupBox2.Location = New System.Drawing.Point(176, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 174)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Mail"
        '
        'RadioBtnPreventivo
        '
        Me.RadioBtnPreventivo.AutoSize = True
        Me.RadioBtnPreventivo.Location = New System.Drawing.Point(6, 148)
        Me.RadioBtnPreventivo.Name = "RadioBtnPreventivo"
        Me.RadioBtnPreventivo.Size = New System.Drawing.Size(76, 17)
        Me.RadioBtnPreventivo.TabIndex = 10
        Me.RadioBtnPreventivo.TabStop = True
        Me.RadioBtnPreventivo.Text = "Preventivo"
        Me.RadioBtnPreventivo.UseVisualStyleBackColor = True
        '
        'RadioBtnConferma
        '
        Me.RadioBtnConferma.AutoSize = True
        Me.RadioBtnConferma.Location = New System.Drawing.Point(6, 125)
        Me.RadioBtnConferma.Name = "RadioBtnConferma"
        Me.RadioBtnConferma.Size = New System.Drawing.Size(70, 17)
        Me.RadioBtnConferma.TabIndex = 9
        Me.RadioBtnConferma.TabStop = True
        Me.RadioBtnConferma.Text = "Conferma"
        Me.RadioBtnConferma.UseVisualStyleBackColor = True
        '
        'RadioBtnInfo
        '
        Me.RadioBtnInfo.AutoSize = True
        Me.RadioBtnInfo.Location = New System.Drawing.Point(6, 102)
        Me.RadioBtnInfo.Name = "RadioBtnInfo"
        Me.RadioBtnInfo.Size = New System.Drawing.Size(81, 17)
        Me.RadioBtnInfo.TabIndex = 8
        Me.RadioBtnInfo.TabStop = True
        Me.RadioBtnInfo.Text = "Informazioni"
        Me.RadioBtnInfo.UseVisualStyleBackColor = True
        '
        'RadioBtnFattura
        '
        Me.RadioBtnFattura.AutoSize = True
        Me.RadioBtnFattura.Location = New System.Drawing.Point(6, 79)
        Me.RadioBtnFattura.Name = "RadioBtnFattura"
        Me.RadioBtnFattura.Size = New System.Drawing.Size(103, 17)
        Me.RadioBtnFattura.TabIndex = 7
        Me.RadioBtnFattura.TabStop = True
        Me.RadioBtnFattura.Text = "Fattura Deposito"
        Me.RadioBtnFattura.UseVisualStyleBackColor = True
        '
        'RadioBtnConfPrenot
        '
        Me.RadioBtnConfPrenot.AutoSize = True
        Me.RadioBtnConfPrenot.Location = New System.Drawing.Point(6, 55)
        Me.RadioBtnConfPrenot.Name = "RadioBtnConfPrenot"
        Me.RadioBtnConfPrenot.Size = New System.Drawing.Size(135, 17)
        Me.RadioBtnConfPrenot.TabIndex = 6
        Me.RadioBtnConfPrenot.TabStop = True
        Me.RadioBtnConfPrenot.Text = "Conferma Prenotazione"
        Me.RadioBtnConfPrenot.UseVisualStyleBackColor = True
        '
        'RadioBtnBooking
        '
        Me.RadioBtnBooking.AutoSize = True
        Me.RadioBtnBooking.Location = New System.Drawing.Point(6, 32)
        Me.RadioBtnBooking.Name = "RadioBtnBooking"
        Me.RadioBtnBooking.Size = New System.Drawing.Size(90, 17)
        Me.RadioBtnBooking.TabIndex = 5
        Me.RadioBtnBooking.TabStop = True
        Me.RadioBtnBooking.Text = "Booking Form"
        Me.RadioBtnBooking.UseVisualStyleBackColor = True
        '
        'RadioBtnUomo
        '
        Me.RadioBtnUomo.AutoSize = True
        Me.RadioBtnUomo.Location = New System.Drawing.Point(9, 32)
        Me.RadioBtnUomo.Name = "RadioBtnUomo"
        Me.RadioBtnUomo.Size = New System.Drawing.Size(53, 17)
        Me.RadioBtnUomo.TabIndex = 5
        Me.RadioBtnUomo.TabStop = True
        Me.RadioBtnUomo.Text = "Uomo"
        Me.RadioBtnUomo.UseVisualStyleBackColor = True
        '
        'RadioBtnDonna
        '
        Me.RadioBtnDonna.AutoSize = True
        Me.RadioBtnDonna.Location = New System.Drawing.Point(9, 55)
        Me.RadioBtnDonna.Name = "RadioBtnDonna"
        Me.RadioBtnDonna.Size = New System.Drawing.Size(57, 17)
        Me.RadioBtnDonna.TabIndex = 8
        Me.RadioBtnDonna.TabStop = True
        Me.RadioBtnDonna.Text = "Donna"
        Me.RadioBtnDonna.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioBtnTO)
        Me.GroupBox3.Controls.Add(Me.RadioBtnUomo)
        Me.GroupBox3.Controls.Add(Me.RadioBtnDonna)
        Me.GroupBox3.Controls.Add(Me.RadioBtnGenerale)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(105, 125)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo destinatario"
        '
        'RadioBtnTO
        '
        Me.RadioBtnTO.AutoSize = True
        Me.RadioBtnTO.Location = New System.Drawing.Point(9, 102)
        Me.RadioBtnTO.Name = "RadioBtnTO"
        Me.RadioBtnTO.Size = New System.Drawing.Size(46, 17)
        Me.RadioBtnTO.TabIndex = 10
        Me.RadioBtnTO.TabStop = True
        Me.RadioBtnTO.Text = "T.O."
        Me.RadioBtnTO.UseVisualStyleBackColor = True
        '
        'RadioBtnGenerale
        '
        Me.RadioBtnGenerale.AutoSize = True
        Me.RadioBtnGenerale.Location = New System.Drawing.Point(9, 79)
        Me.RadioBtnGenerale.Name = "RadioBtnGenerale"
        Me.RadioBtnGenerale.Size = New System.Drawing.Size(68, 17)
        Me.RadioBtnGenerale.TabIndex = 9
        Me.RadioBtnGenerale.TabStop = True
        Me.RadioBtnGenerale.Text = "Generale"
        Me.RadioBtnGenerale.UseVisualStyleBackColor = True
        '
        'BtnAvvia
        '
        Me.BtnAvvia.Location = New System.Drawing.Point(176, 342)
        Me.BtnAvvia.Name = "BtnAvvia"
        Me.BtnAvvia.Size = New System.Drawing.Size(156, 65)
        Me.BtnAvvia.TabIndex = 10
        Me.BtnAvvia.Text = "Avvia"
        Me.BtnAvvia.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 419)
        Me.Controls.Add(Me.BtnAvvia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtNomeDest)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Tipologia Mail"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNomeDest As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioBtnFattura As RadioButton
    Friend WithEvents RadioBtnConfPrenot As RadioButton
    Friend WithEvents RadioBtnBooking As RadioButton
    Friend WithEvents RadioBtnUomo As RadioButton
    Friend WithEvents RadioBtnDonna As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioBtnInfo As RadioButton
    Friend WithEvents RadioBtnGenerale As RadioButton
    Friend WithEvents BtnAvvia As Button
    Friend WithEvents RadioBtnConferma As RadioButton
    Friend WithEvents RadioBtnTO As RadioButton
    Friend WithEvents RadioBtnPreventivo As RadioButton
End Class
