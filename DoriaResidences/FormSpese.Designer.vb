<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpese
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSpese))
        Me.BtnAnnulSpese = New System.Windows.Forms.Button()
        Me.BtnOkSpese = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSpese1 = New System.Windows.Forms.TextBox()
        Me.TxtAnimali = New System.Windows.Forms.TextBox()
        Me.TxtExtra = New System.Windows.Forms.TextBox()
        Me.TxtPulizie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSpese3 = New System.Windows.Forms.TextBox()
        Me.TxtSpese2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAnnulSpese
        '
        Me.BtnAnnulSpese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulSpese.Location = New System.Drawing.Point(97, 291)
        Me.BtnAnnulSpese.Name = "BtnAnnulSpese"
        Me.BtnAnnulSpese.Size = New System.Drawing.Size(80, 30)
        Me.BtnAnnulSpese.TabIndex = 19
        Me.BtnAnnulSpese.Text = "Annulla"
        Me.BtnAnnulSpese.UseVisualStyleBackColor = True
        '
        'BtnOkSpese
        '
        Me.BtnOkSpese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkSpese.Location = New System.Drawing.Point(183, 291)
        Me.BtnOkSpese.Name = "BtnOkSpese"
        Me.BtnOkSpese.Size = New System.Drawing.Size(80, 30)
        Me.BtnOkSpese.TabIndex = 18
        Me.BtnOkSpese.Text = "Ok"
        Me.BtnOkSpese.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Spese 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Spese Animali Domestici"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Spese Extra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Spese Pulizie"
        '
        'TxtSpese1
        '
        Me.TxtSpese1.Location = New System.Drawing.Point(21, 161)
        Me.TxtSpese1.Name = "TxtSpese1"
        Me.TxtSpese1.Size = New System.Drawing.Size(242, 20)
        Me.TxtSpese1.TabIndex = 13
        '
        'TxtAnimali
        '
        Me.TxtAnimali.Location = New System.Drawing.Point(21, 122)
        Me.TxtAnimali.Name = "TxtAnimali"
        Me.TxtAnimali.Size = New System.Drawing.Size(242, 20)
        Me.TxtAnimali.TabIndex = 12
        '
        'TxtExtra
        '
        Me.TxtExtra.Location = New System.Drawing.Point(21, 83)
        Me.TxtExtra.Name = "TxtExtra"
        Me.TxtExtra.Size = New System.Drawing.Size(242, 20)
        Me.TxtExtra.TabIndex = 11
        '
        'TxtPulizie
        '
        Me.TxtPulizie.Location = New System.Drawing.Point(21, 44)
        Me.TxtPulizie.Name = "TxtPulizie"
        Me.TxtPulizie.Size = New System.Drawing.Size(242, 20)
        Me.TxtPulizie.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Spese 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Spese 2"
        '
        'TxtSpese3
        '
        Me.TxtSpese3.Location = New System.Drawing.Point(21, 241)
        Me.TxtSpese3.Name = "TxtSpese3"
        Me.TxtSpese3.Size = New System.Drawing.Size(242, 20)
        Me.TxtSpese3.TabIndex = 21
        '
        'TxtSpese2
        '
        Me.TxtSpese2.Location = New System.Drawing.Point(21, 202)
        Me.TxtSpese2.Name = "TxtSpese2"
        Me.TxtSpese2.Size = New System.Drawing.Size(242, 20)
        Me.TxtSpese2.TabIndex = 20
        '
        'FormSpese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 350)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSpese3)
        Me.Controls.Add(Me.TxtSpese2)
        Me.Controls.Add(Me.BtnAnnulSpese)
        Me.Controls.Add(Me.BtnOkSpese)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSpese1)
        Me.Controls.Add(Me.TxtAnimali)
        Me.Controls.Add(Me.TxtExtra)
        Me.Controls.Add(Me.TxtPulizie)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSpese"
        Me.Text = "Spese"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAnnulSpese As Button
    Friend WithEvents BtnOkSpese As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSpese1 As TextBox
    Friend WithEvents TxtAnimali As TextBox
    Friend WithEvents TxtExtra As TextBox
    Friend WithEvents TxtPulizie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSpese3 As TextBox
    Friend WithEvents TxtSpese2 As TextBox
End Class
