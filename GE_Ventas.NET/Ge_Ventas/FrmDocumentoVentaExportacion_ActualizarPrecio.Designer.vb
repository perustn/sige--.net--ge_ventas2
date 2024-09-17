<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_ActualizarPrecio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtImpFleAer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.txtImpFleMar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImpFleDif = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpFleDDP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImpOtrPen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtImpOtrPen)
        Me.Panel1.Controls.Add(Me.txtImpFleDDP)
        Me.Panel1.Controls.Add(Me.txtImpFleDif)
        Me.Panel1.Controls.Add(Me.txtImpFleMar)
        Me.Panel1.Controls.Add(Me.txtImpFleAer)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 158)
        Me.Panel1.TabIndex = 252
        '
        'txtImpFleAer
        '
        Me.txtImpFleAer.AcceptsReturn = True
        Me.txtImpFleAer.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpFleAer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpFleAer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpFleAer.Location = New System.Drawing.Point(197, 15)
        Me.txtImpFleAer.MaxLength = 100
        Me.txtImpFleAer.Name = "txtImpFleAer"
        Me.txtImpFleAer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpFleAer.Size = New System.Drawing.Size(93, 20)
        Me.txtImpFleAer.TabIndex = 101
        Me.txtImpFleAer.Text = "0.00"
        Me.txtImpFleAer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(33, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Importe Flete Aéreo ......................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 30)
        Me.Panel2.TabIndex = 251
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(118, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 30)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(325, 28)
        Me.Panel4.TabIndex = 250
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(104, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO CORRELATIVO"
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'txtImpFleMar
        '
        Me.txtImpFleMar.AcceptsReturn = True
        Me.txtImpFleMar.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpFleMar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpFleMar.Enabled = False
        Me.txtImpFleMar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpFleMar.Location = New System.Drawing.Point(197, 41)
        Me.txtImpFleMar.MaxLength = 100
        Me.txtImpFleMar.Name = "txtImpFleMar"
        Me.txtImpFleMar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpFleMar.Size = New System.Drawing.Size(93, 20)
        Me.txtImpFleMar.TabIndex = 103
        Me.txtImpFleMar.Text = "0.00"
        Me.txtImpFleMar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(33, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Importe Flete Marítimo ...................."
        '
        'txtImpFleDif
        '
        Me.txtImpFleDif.AcceptsReturn = True
        Me.txtImpFleDif.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpFleDif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpFleDif.Enabled = False
        Me.txtImpFleDif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpFleDif.Location = New System.Drawing.Point(197, 67)
        Me.txtImpFleDif.MaxLength = 100
        Me.txtImpFleDif.Name = "txtImpFleDif"
        Me.txtImpFleDif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpFleDif.Size = New System.Drawing.Size(93, 20)
        Me.txtImpFleDif.TabIndex = 105
        Me.txtImpFleDif.Text = "0.00"
        Me.txtImpFleDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(33, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Diferencia Aéreo - Marítimo .........."
        '
        'txtImpFleDDP
        '
        Me.txtImpFleDDP.AcceptsReturn = True
        Me.txtImpFleDDP.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpFleDDP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpFleDDP.Enabled = False
        Me.txtImpFleDDP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpFleDDP.Location = New System.Drawing.Point(197, 93)
        Me.txtImpFleDDP.MaxLength = 100
        Me.txtImpFleDDP.Name = "txtImpFleDDP"
        Me.txtImpFleDDP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpFleDDP.Size = New System.Drawing.Size(93, 20)
        Me.txtImpFleDDP.TabIndex = 107
        Me.txtImpFleDDP.Text = "0.00"
        Me.txtImpFleDDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(33, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(167, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Importe DDP ................................"
        '
        'txtImpOtrPen
        '
        Me.txtImpOtrPen.AcceptsReturn = True
        Me.txtImpOtrPen.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpOtrPen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpOtrPen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpOtrPen.Location = New System.Drawing.Point(197, 119)
        Me.txtImpOtrPen.MaxLength = 100
        Me.txtImpOtrPen.Name = "txtImpOtrPen"
        Me.txtImpOtrPen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpOtrPen.Size = New System.Drawing.Size(93, 20)
        Me.txtImpOtrPen.TabIndex = 109
        Me.txtImpOtrPen.Text = "0.00"
        Me.txtImpOtrPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(33, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(178, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Importe Otros Gastos ......................."
        '
        'FrmDocumentoVentaExportacion_ActualizarPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVentaExportacion_ActualizarPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importe Flete Aéreo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents txtImpOtrPen As System.Windows.Forms.TextBox
    Public WithEvents txtImpFleDDP As System.Windows.Forms.TextBox
    Public WithEvents txtImpFleDif As System.Windows.Forms.TextBox
    Public WithEvents txtImpFleMar As System.Windows.Forms.TextBox
    Public WithEvents txtImpFleAer As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
End Class
