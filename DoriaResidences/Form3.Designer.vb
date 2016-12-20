<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TxtIdAccount = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtSmtp = New System.Windows.Forms.TextBox()
        Me.TxtCcnMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnOkDati = New System.Windows.Forms.Button()
        Me.BtnAnnulDati = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtIdAccount
        '
        Me.TxtIdAccount.Location = New System.Drawing.Point(9, 25)
        Me.TxtIdAccount.Name = "TxtIdAccount"
        Me.TxtIdAccount.Size = New System.Drawing.Size(242, 20)
        Me.TxtIdAccount.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(9, 64)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(242, 20)
        Me.TxtPassword.TabIndex = 1
        '
        'TxtSmtp
        '
        Me.TxtSmtp.Location = New System.Drawing.Point(9, 103)
        Me.TxtSmtp.Name = "TxtSmtp"
        Me.TxtSmtp.Size = New System.Drawing.Size(242, 20)
        Me.TxtSmtp.TabIndex = 2
        '
        'TxtCcnMail
        '
        Me.TxtCcnMail.Location = New System.Drawing.Point(9, 142)
        Me.TxtCcnMail.Name = "TxtCcnMail"
        Me.TxtCcnMail.Size = New System.Drawing.Size(242, 20)
        Me.TxtCcnMail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Smtp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ccn mail"
        '
        'BtnOkDati
        '
        Me.BtnOkDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkDati.Location = New System.Drawing.Point(171, 183)
        Me.BtnOkDati.Name = "BtnOkDati"
        Me.BtnOkDati.Size = New System.Drawing.Size(80, 30)
        Me.BtnOkDati.TabIndex = 8
        Me.BtnOkDati.Text = "Ok"
        Me.BtnOkDati.UseVisualStyleBackColor = True
        '
        'BtnAnnulDati
        '
        Me.BtnAnnulDati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulDati.Location = New System.Drawing.Point(85, 183)
        Me.BtnAnnulDati.Name = "BtnAnnulDati"
        Me.BtnAnnulDati.Size = New System.Drawing.Size(80, 30)
        Me.BtnAnnulDati.TabIndex = 9
        Me.BtnAnnulDati.Text = "Annulla"
        Me.BtnAnnulDati.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 230)
        Me.Controls.Add(Me.BtnAnnulDati)
        Me.Controls.Add(Me.BtnOkDati)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCcnMail)
        Me.Controls.Add(Me.TxtSmtp)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtIdAccount)
        Me.Name = "Form3"
        Me.Text = "Dati Account Mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIdAccount As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtSmtp As TextBox
    Friend WithEvents TxtCcnMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnOkDati As Button
    Friend WithEvents BtnAnnulDati As Button
End Class
