<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAllegati
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAllegati))
        Me.BtnAnnulDati = New System.Windows.Forms.Button()
        Me.BtnOkDati = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAllega4 = New System.Windows.Forms.TextBox()
        Me.TxtAllega3 = New System.Windows.Forms.TextBox()
        Me.TxtAllega2 = New System.Windows.Forms.TextBox()
        Me.TxtAllega1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'BtnAnnulDati
        '
        Me.BtnAnnulDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulDati.Location = New System.Drawing.Point(379, 202)
        Me.BtnAnnulDati.Name = "BtnAnnulDati"
        Me.BtnAnnulDati.Size = New System.Drawing.Size(80, 30)
        Me.BtnAnnulDati.TabIndex = 19
        Me.BtnAnnulDati.Text = "Annulla"
        Me.BtnAnnulDati.UseVisualStyleBackColor = True
        '
        'BtnOkDati
        '
        Me.BtnOkDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkDati.Location = New System.Drawing.Point(465, 202)
        Me.BtnOkDati.Name = "BtnOkDati"
        Me.BtnOkDati.Size = New System.Drawing.Size(80, 30)
        Me.BtnOkDati.TabIndex = 18
        Me.BtnOkDati.Text = "Ok"
        Me.BtnOkDati.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Allegato 2 ENG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Allegato 1 ENG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Allegato 2 ITA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Allegato 1 ITA"
        '
        'TxtAllega4
        '
        Me.TxtAllega4.Location = New System.Drawing.Point(21, 161)
        Me.TxtAllega4.Name = "TxtAllega4"
        Me.TxtAllega4.Size = New System.Drawing.Size(524, 20)
        Me.TxtAllega4.TabIndex = 13
        '
        'TxtAllega3
        '
        Me.TxtAllega3.Location = New System.Drawing.Point(21, 122)
        Me.TxtAllega3.Name = "TxtAllega3"
        Me.TxtAllega3.Size = New System.Drawing.Size(524, 20)
        Me.TxtAllega3.TabIndex = 12
        '
        'TxtAllega2
        '
        Me.TxtAllega2.Location = New System.Drawing.Point(21, 83)
        Me.TxtAllega2.Name = "TxtAllega2"
        Me.TxtAllega2.Size = New System.Drawing.Size(524, 20)
        Me.TxtAllega2.TabIndex = 11
        '
        'TxtAllega1
        '
        Me.TxtAllega1.Location = New System.Drawing.Point(21, 44)
        Me.TxtAllega1.Name = "TxtAllega1"
        Me.TxtAllega1.Size = New System.Drawing.Size(524, 20)
        Me.TxtAllega1.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormAllegati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 261)
        Me.Controls.Add(Me.BtnAnnulDati)
        Me.Controls.Add(Me.BtnOkDati)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAllega4)
        Me.Controls.Add(Me.TxtAllega3)
        Me.Controls.Add(Me.TxtAllega2)
        Me.Controls.Add(Me.TxtAllega1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAllegati"
        Me.Text = "FormAllegati"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAnnulDati As Button
    Friend WithEvents BtnOkDati As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAllega4 As TextBox
    Friend WithEvents TxtAllega3 As TextBox
    Friend WithEvents TxtAllega2 As TextBox
    Friend WithEvents TxtAllega1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
