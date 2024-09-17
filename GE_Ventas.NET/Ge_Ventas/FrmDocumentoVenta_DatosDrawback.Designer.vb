<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_DatosDrawback
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
        Me.txtNota_credito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPenalidad = New System.Windows.Forms.TextBox()
        Me.TxtNota_Debito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtcomisiones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAjuste = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Controls.Add(Me.TxtAjuste)
        Me.Panel1.Controls.Add(Me.Txtcomisiones)
        Me.Panel1.Controls.Add(Me.TxtNota_Debito)
        Me.Panel1.Controls.Add(Me.TxtPenalidad)
        Me.Panel1.Controls.Add(Me.txtNota_credito)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 161)
        Me.Panel1.TabIndex = 261
        '
        'txtNota_credito
        '
        Me.txtNota_credito.AcceptsReturn = True
        Me.txtNota_credito.BackColor = System.Drawing.SystemColors.Window
        Me.txtNota_credito.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNota_credito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNota_credito.Location = New System.Drawing.Point(177, 44)
        Me.txtNota_credito.MaxLength = 100
        Me.txtNota_credito.Name = "txtNota_credito"
        Me.txtNota_credito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNota_credito.Size = New System.Drawing.Size(76, 20)
        Me.txtNota_credito.TabIndex = 329
        Me.txtNota_credito.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(37, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Nota de Crédito ($/.) .............."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 30)
        Me.Panel2.TabIndex = 260
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(89, 0)
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
        Me.Panel4.Size = New System.Drawing.Size(296, 28)
        Me.Panel4.TabIndex = 259
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
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(122, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 328
        Me.Label1.Text = "Penalidad ($/.) ......................"
        '
        'TxtPenalidad
        '
        Me.TxtPenalidad.AcceptsReturn = True
        Me.TxtPenalidad.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPenalidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPenalidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPenalidad.Location = New System.Drawing.Point(177, 18)
        Me.TxtPenalidad.MaxLength = 100
        Me.TxtPenalidad.Name = "TxtPenalidad"
        Me.TxtPenalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPenalidad.Size = New System.Drawing.Size(76, 20)
        Me.TxtPenalidad.TabIndex = 329
        Me.TxtPenalidad.Text = "0"
        '
        'TxtNota_Debito
        '
        Me.TxtNota_Debito.AcceptsReturn = True
        Me.TxtNota_Debito.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNota_Debito.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNota_Debito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNota_Debito.Location = New System.Drawing.Point(177, 70)
        Me.TxtNota_Debito.MaxLength = 100
        Me.TxtNota_Debito.Name = "TxtNota_Debito"
        Me.TxtNota_Debito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNota_Debito.Size = New System.Drawing.Size(76, 20)
        Me.TxtNota_Debito.TabIndex = 331
        Me.TxtNota_Debito.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(37, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 330
        Me.Label2.Text = "Nota de Débito ($/.) ..............."
        '
        'Txtcomisiones
        '
        Me.Txtcomisiones.AcceptsReturn = True
        Me.Txtcomisiones.BackColor = System.Drawing.SystemColors.Window
        Me.Txtcomisiones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcomisiones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtcomisiones.Location = New System.Drawing.Point(177, 96)
        Me.Txtcomisiones.MaxLength = 100
        Me.Txtcomisiones.Name = "Txtcomisiones"
        Me.Txtcomisiones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtcomisiones.Size = New System.Drawing.Size(76, 20)
        Me.Txtcomisiones.TabIndex = 333
        Me.Txtcomisiones.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(37, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 332
        Me.Label4.Text = "Comisiones ($/.) ......................"
        '
        'TxtAjuste
        '
        Me.TxtAjuste.AcceptsReturn = True
        Me.TxtAjuste.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAjuste.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAjuste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAjuste.Location = New System.Drawing.Point(177, 122)
        Me.TxtAjuste.MaxLength = 100
        Me.TxtAjuste.Name = "TxtAjuste"
        Me.TxtAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAjuste.Size = New System.Drawing.Size(76, 20)
        Me.TxtAjuste.TabIndex = 335
        Me.TxtAjuste.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(37, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 334
        Me.Label6.Text = "Ajuste ($/.) ............................."
        '
        'FrmDocumentoVenta_DatosDrawback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_DatosDrawback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Adicionales Provisión Drawback "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents TxtAjuste As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents Txtcomisiones As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents TxtNota_Debito As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents TxtPenalidad As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtNota_credito As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
End Class
