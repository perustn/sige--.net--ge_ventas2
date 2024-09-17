<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_Redondear
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkRedondeo = New Janus.Windows.EditControls.UICheckBox()
        Me.cmdResta = New Janus.Windows.EditControls.UIButton()
        Me.cmdSuma = New Janus.Windows.EditControls.UIButton()
        Me.cmdRecalcular = New Janus.Windows.EditControls.UIButton()
        Me.txtValorRedondeo = New System.Windows.Forms.TextBox()
        Me.txtImpTotalActual = New System.Windows.Forms.TextBox()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.txtImporteOtros = New System.Windows.Forms.TextBox()
        Me.txtImporteDscto = New System.Windows.Forms.TextBox()
        Me.txtImporteGastosFinan = New System.Windows.Forms.TextBox()
        Me.txtImporteIgv = New System.Windows.Forms.TextBox()
        Me.txtImporteNeto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.BtnDesHacer = New Janus.Windows.EditControls.UIButton()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtDocumento)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(467, 28)
        Me.Panel4.TabIndex = 254
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
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO DOCUMENTO"
        '
        'TxtDocumento
        '
        Me.TxtDocumento.AcceptsReturn = True
        Me.TxtDocumento.BackColor = System.Drawing.Color.LightCyan
        Me.TxtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDocumento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDocumento.Location = New System.Drawing.Point(116, 4)
        Me.TxtDocumento.MaxLength = 0
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.ReadOnly = True
        Me.TxtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDocumento.Size = New System.Drawing.Size(101, 20)
        Me.TxtDocumento.TabIndex = 121
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.chkRedondeo)
        Me.Panel1.Controls.Add(Me.cmdResta)
        Me.Panel1.Controls.Add(Me.cmdSuma)
        Me.Panel1.Controls.Add(Me.cmdRecalcular)
        Me.Panel1.Controls.Add(Me.txtValorRedondeo)
        Me.Panel1.Controls.Add(Me.txtImpTotalActual)
        Me.Panel1.Controls.Add(Me.txtImporteTotal)
        Me.Panel1.Controls.Add(Me.txtImporteOtros)
        Me.Panel1.Controls.Add(Me.txtImporteDscto)
        Me.Panel1.Controls.Add(Me.txtImporteGastosFinan)
        Me.Panel1.Controls.Add(Me.txtImporteIgv)
        Me.Panel1.Controls.Add(Me.txtImporteNeto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 200)
        Me.Panel1.TabIndex = 260
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(341, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 336
        Me.Label8.Text = "Importe Total Actual"
        '
        'chkRedondeo
        '
        Me.chkRedondeo.AutoSize = True
        Me.chkRedondeo.Location = New System.Drawing.Point(341, 8)
        Me.chkRedondeo.Name = "chkRedondeo"
        Me.chkRedondeo.Size = New System.Drawing.Size(98, 17)
        Me.chkRedondeo.TabIndex = 340
        Me.chkRedondeo.Text = "Valor Redondeo"
        Me.chkRedondeo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdResta
        '
        Me.cmdResta.Enabled = False
        Me.cmdResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResta.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdResta.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdResta.Location = New System.Drawing.Point(371, 53)
        Me.cmdResta.Name = "cmdResta"
        Me.cmdResta.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdResta.Size = New System.Drawing.Size(29, 24)
        Me.cmdResta.TabIndex = 342
        Me.cmdResta.Text = "-"
        Me.cmdResta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdSuma
        '
        Me.cmdSuma.Enabled = False
        Me.cmdSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuma.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdSuma.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdSuma.Location = New System.Drawing.Point(341, 53)
        Me.cmdSuma.Name = "cmdSuma"
        Me.cmdSuma.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdSuma.Size = New System.Drawing.Size(29, 24)
        Me.cmdSuma.TabIndex = 341
        Me.cmdSuma.Text = "+"
        Me.cmdSuma.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdRecalcular
        '
        Me.cmdRecalcular.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdRecalcular.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdRecalcular.Location = New System.Drawing.Point(249, 167)
        Me.cmdRecalcular.Name = "cmdRecalcular"
        Me.cmdRecalcular.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdRecalcular.Size = New System.Drawing.Size(63, 24)
        Me.cmdRecalcular.TabIndex = 339
        Me.cmdRecalcular.Text = "Recalcular"
        Me.cmdRecalcular.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtValorRedondeo
        '
        Me.txtValorRedondeo.AcceptsReturn = True
        Me.txtValorRedondeo.BackColor = System.Drawing.SystemColors.Window
        Me.txtValorRedondeo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValorRedondeo.Enabled = False
        Me.txtValorRedondeo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValorRedondeo.Location = New System.Drawing.Point(341, 30)
        Me.txtValorRedondeo.MaxLength = 25
        Me.txtValorRedondeo.Name = "txtValorRedondeo"
        Me.txtValorRedondeo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValorRedondeo.Size = New System.Drawing.Size(110, 20)
        Me.txtValorRedondeo.TabIndex = 338
        Me.txtValorRedondeo.Text = "0.00"
        Me.txtValorRedondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpTotalActual
        '
        Me.txtImpTotalActual.AcceptsReturn = True
        Me.txtImpTotalActual.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtImpTotalActual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpTotalActual.Enabled = False
        Me.txtImpTotalActual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImpTotalActual.Location = New System.Drawing.Point(341, 168)
        Me.txtImpTotalActual.MaxLength = 25
        Me.txtImpTotalActual.Name = "txtImpTotalActual"
        Me.txtImpTotalActual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpTotalActual.Size = New System.Drawing.Size(110, 20)
        Me.txtImpTotalActual.TabIndex = 337
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.AcceptsReturn = True
        Me.txtImporteTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteTotal.Location = New System.Drawing.Point(133, 168)
        Me.txtImporteTotal.MaxLength = 25
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteTotal.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteTotal.TabIndex = 335
        '
        'txtImporteOtros
        '
        Me.txtImporteOtros.AcceptsReturn = True
        Me.txtImporteOtros.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteOtros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteOtros.Enabled = False
        Me.txtImporteOtros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteOtros.Location = New System.Drawing.Point(133, 131)
        Me.txtImporteOtros.MaxLength = 25
        Me.txtImporteOtros.Name = "txtImporteOtros"
        Me.txtImporteOtros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteOtros.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteOtros.TabIndex = 333
        '
        'txtImporteDscto
        '
        Me.txtImporteDscto.AcceptsReturn = True
        Me.txtImporteDscto.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteDscto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteDscto.Enabled = False
        Me.txtImporteDscto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteDscto.Location = New System.Drawing.Point(133, 105)
        Me.txtImporteDscto.MaxLength = 25
        Me.txtImporteDscto.Name = "txtImporteDscto"
        Me.txtImporteDscto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteDscto.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteDscto.TabIndex = 331
        '
        'txtImporteGastosFinan
        '
        Me.txtImporteGastosFinan.AcceptsReturn = True
        Me.txtImporteGastosFinan.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteGastosFinan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteGastosFinan.Enabled = False
        Me.txtImporteGastosFinan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteGastosFinan.Location = New System.Drawing.Point(133, 79)
        Me.txtImporteGastosFinan.MaxLength = 25
        Me.txtImporteGastosFinan.Name = "txtImporteGastosFinan"
        Me.txtImporteGastosFinan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteGastosFinan.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteGastosFinan.TabIndex = 329
        '
        'txtImporteIgv
        '
        Me.txtImporteIgv.AcceptsReturn = True
        Me.txtImporteIgv.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteIgv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteIgv.Enabled = False
        Me.txtImporteIgv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteIgv.Location = New System.Drawing.Point(133, 53)
        Me.txtImporteIgv.MaxLength = 25
        Me.txtImporteIgv.Name = "txtImporteIgv"
        Me.txtImporteIgv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteIgv.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteIgv.TabIndex = 327
        '
        'txtImporteNeto
        '
        Me.txtImporteNeto.AcceptsReturn = True
        Me.txtImporteNeto.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporteNeto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporteNeto.Enabled = False
        Me.txtImporteNeto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporteNeto.Location = New System.Drawing.Point(133, 27)
        Me.txtImporteNeto.MaxLength = 25
        Me.txtImporteNeto.Name = "txtImporteNeto"
        Me.txtImporteNeto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporteNeto.Size = New System.Drawing.Size(110, 20)
        Me.txtImporteNeto.TabIndex = 325
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 334
        Me.Label7.Text = "Importe Total .................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Imp. Otros ....................."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 330
        Me.Label6.Text = "Imp. Descuento .............."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Imp. Gastos Finan. .........."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 326
        Me.Label2.Text = "Imp. IGV ......................."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 324
        Me.Label1.Text = "Imp. Neto ......................"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 30)
        Me.Panel2.TabIndex = 259
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnDesHacer)
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(143, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 30)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(220, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Salir"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(113, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Guardar Redondeo"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnDesHacer
        '
        Me.BtnDesHacer.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnDesHacer.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnDesHacer.Location = New System.Drawing.Point(119, 3)
        Me.BtnDesHacer.Name = "BtnDesHacer"
        Me.BtnDesHacer.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnDesHacer.Size = New System.Drawing.Size(98, 24)
        Me.BtnDesHacer.TabIndex = 7
        Me.BtnDesHacer.Text = "Deshacer"
        Me.BtnDesHacer.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_Redondear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_Redondear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Redondea Importe"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtDocumento As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdResta As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdSuma As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdRecalcular As Janus.Windows.EditControls.UIButton
    Public WithEvents txtValorRedondeo As TextBox
    Public WithEvents txtImpTotalActual As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents txtImporteTotal As TextBox
    Public WithEvents txtImporteOtros As TextBox
    Public WithEvents txtImporteDscto As TextBox
    Public WithEvents txtImporteGastosFinan As TextBox
    Public WithEvents txtImporteIgv As TextBox
    Public WithEvents txtImporteNeto As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents chkRedondeo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnDesHacer As Janus.Windows.EditControls.UIButton
End Class
