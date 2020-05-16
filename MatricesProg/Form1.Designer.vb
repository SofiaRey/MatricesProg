<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrimeraMatriz = New System.Windows.Forms.Label()
        Me.lblSegundaMatriz = New System.Windows.Forms.Label()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.cbxOperation = New System.Windows.Forms.ComboBox()
        Me.inputPrimeraMatriz = New System.Windows.Forms.TextBox()
        Me.inputSegundaMatriz = New System.Windows.Forms.TextBox()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblARes = New System.Windows.Forms.Label()
        Me.lblBRes = New System.Windows.Forms.Label()
        Me.lblCRes = New System.Windows.Forms.Label()
        Me.lblDRes = New System.Windows.Forms.Label()
        Me.lblERes = New System.Windows.Forms.Label()
        Me.lblFRes = New System.Windows.Forms.Label()
        Me.lblGRes = New System.Windows.Forms.Label()
        Me.lblHRes = New System.Windows.Forms.Label()
        Me.lblIRes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblTitle.Location = New System.Drawing.Point(110, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(273, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Calculadora de matrices"
        '
        'lblPrimeraMatriz
        '
        Me.lblPrimeraMatriz.AutoSize = True
        Me.lblPrimeraMatriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPrimeraMatriz.Location = New System.Drawing.Point(58, 51)
        Me.lblPrimeraMatriz.Name = "lblPrimeraMatriz"
        Me.lblPrimeraMatriz.Size = New System.Drawing.Size(110, 20)
        Me.lblPrimeraMatriz.TabIndex = 1
        Me.lblPrimeraMatriz.Text = "Primera Matriz"
        '
        'lblSegundaMatriz
        '
        Me.lblSegundaMatriz.AutoSize = True
        Me.lblSegundaMatriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSegundaMatriz.Location = New System.Drawing.Point(58, 132)
        Me.lblSegundaMatriz.Name = "lblSegundaMatriz"
        Me.lblSegundaMatriz.Size = New System.Drawing.Size(121, 20)
        Me.lblSegundaMatriz.TabIndex = 2
        Me.lblSegundaMatriz.Text = "Segunda Matriz"
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblOperacion.Location = New System.Drawing.Point(59, 105)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(172, 17)
        Me.lblOperacion.TabIndex = 3
        Me.lblOperacion.Text = "Selecciona una operación"
        '
        'cbxOperation
        '
        Me.cbxOperation.AllowDrop = True
        Me.cbxOperation.DisplayMember = "+"
        Me.cbxOperation.FormattingEnabled = True
        Me.cbxOperation.Items.AddRange(New Object() {"+", "-", "x"})
        Me.cbxOperation.Location = New System.Drawing.Point(237, 104)
        Me.cbxOperation.Name = "cbxOperation"
        Me.cbxOperation.Size = New System.Drawing.Size(48, 21)
        Me.cbxOperation.TabIndex = 4
        Me.cbxOperation.Text = "+"
        '
        'inputPrimeraMatriz
        '
        Me.inputPrimeraMatriz.Location = New System.Drawing.Point(62, 74)
        Me.inputPrimeraMatriz.Name = "inputPrimeraMatriz"
        Me.inputPrimeraMatriz.Size = New System.Drawing.Size(375, 20)
        Me.inputPrimeraMatriz.TabIndex = 5
        '
        'inputSegundaMatriz
        '
        Me.inputSegundaMatriz.Location = New System.Drawing.Point(62, 155)
        Me.inputSegundaMatriz.Name = "inputSegundaMatriz"
        Me.inputSegundaMatriz.Size = New System.Drawing.Size(375, 20)
        Me.inputSegundaMatriz.TabIndex = 6
        '
        'btnEqual
        '
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnEqual.Location = New System.Drawing.Point(220, 193)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(29, 31)
        Me.btnEqual.TabIndex = 7
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblResultado.Location = New System.Drawing.Point(194, 242)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(82, 20)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.Text = "Resultado"
        '
        'lblARes
        '
        Me.lblARes.AutoSize = True
        Me.lblARes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblARes.Location = New System.Drawing.Point(197, 269)
        Me.lblARes.Name = "lblARes"
        Me.lblARes.Size = New System.Drawing.Size(14, 20)
        Me.lblARes.TabIndex = 9
        Me.lblARes.Text = "-"
        '
        'lblBRes
        '
        Me.lblBRes.AutoSize = True
        Me.lblBRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblBRes.Location = New System.Drawing.Point(227, 269)
        Me.lblBRes.Name = "lblBRes"
        Me.lblBRes.Size = New System.Drawing.Size(14, 20)
        Me.lblBRes.TabIndex = 11
        Me.lblBRes.Text = "-"
        '
        'lblCRes
        '
        Me.lblCRes.AutoSize = True
        Me.lblCRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCRes.Location = New System.Drawing.Point(257, 269)
        Me.lblCRes.Name = "lblCRes"
        Me.lblCRes.Size = New System.Drawing.Size(14, 20)
        Me.lblCRes.TabIndex = 12
        Me.lblCRes.Text = "-"
        '
        'lblDRes
        '
        Me.lblDRes.AutoSize = True
        Me.lblDRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDRes.Location = New System.Drawing.Point(197, 296)
        Me.lblDRes.Name = "lblDRes"
        Me.lblDRes.Size = New System.Drawing.Size(14, 20)
        Me.lblDRes.TabIndex = 13
        Me.lblDRes.Text = "-"
        '
        'lblERes
        '
        Me.lblERes.AutoSize = True
        Me.lblERes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblERes.Location = New System.Drawing.Point(227, 296)
        Me.lblERes.Name = "lblERes"
        Me.lblERes.Size = New System.Drawing.Size(14, 20)
        Me.lblERes.TabIndex = 14
        Me.lblERes.Text = "-"
        '
        'lblFRes
        '
        Me.lblFRes.AutoSize = True
        Me.lblFRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFRes.Location = New System.Drawing.Point(257, 296)
        Me.lblFRes.Name = "lblFRes"
        Me.lblFRes.Size = New System.Drawing.Size(14, 20)
        Me.lblFRes.TabIndex = 15
        Me.lblFRes.Text = "-"
        '
        'lblGRes
        '
        Me.lblGRes.AutoSize = True
        Me.lblGRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGRes.Location = New System.Drawing.Point(197, 322)
        Me.lblGRes.Name = "lblGRes"
        Me.lblGRes.Size = New System.Drawing.Size(14, 20)
        Me.lblGRes.TabIndex = 16
        Me.lblGRes.Text = "-"
        '
        'lblHRes
        '
        Me.lblHRes.AutoSize = True
        Me.lblHRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHRes.Location = New System.Drawing.Point(227, 322)
        Me.lblHRes.Name = "lblHRes"
        Me.lblHRes.Size = New System.Drawing.Size(14, 20)
        Me.lblHRes.TabIndex = 17
        Me.lblHRes.Text = "-"
        '
        'lblIRes
        '
        Me.lblIRes.AutoSize = True
        Me.lblIRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblIRes.Location = New System.Drawing.Point(257, 322)
        Me.lblIRes.Name = "lblIRes"
        Me.lblIRes.Size = New System.Drawing.Size(14, 20)
        Me.lblIRes.TabIndex = 18
        Me.lblIRes.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 384)
        Me.Controls.Add(Me.lblIRes)
        Me.Controls.Add(Me.lblHRes)
        Me.Controls.Add(Me.lblGRes)
        Me.Controls.Add(Me.lblFRes)
        Me.Controls.Add(Me.lblERes)
        Me.Controls.Add(Me.lblDRes)
        Me.Controls.Add(Me.lblCRes)
        Me.Controls.Add(Me.lblBRes)
        Me.Controls.Add(Me.lblARes)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.inputSegundaMatriz)
        Me.Controls.Add(Me.inputPrimeraMatriz)
        Me.Controls.Add(Me.cbxOperation)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.lblSegundaMatriz)
        Me.Controls.Add(Me.lblPrimeraMatriz)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrimeraMatriz As Label
    Friend WithEvents lblSegundaMatriz As Label
    Friend WithEvents lblOperacion As Label
    Friend WithEvents cbxOperation As ComboBox
    Friend WithEvents inputPrimeraMatriz As TextBox
    Friend WithEvents inputSegundaMatriz As TextBox
    Friend WithEvents btnEqual As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblARes As Label
    Friend WithEvents lblBRes As Label
    Friend WithEvents lblCRes As Label
    Friend WithEvents lblDRes As Label
    Friend WithEvents lblERes As Label
    Friend WithEvents lblFRes As Label
    Friend WithEvents lblGRes As Label
    Friend WithEvents lblHRes As Label
    Friend WithEvents lblIRes As Label
End Class
