<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_EnvioInstruccionAGAduana
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNom_AlmacenAduana = New System.Windows.Forms.TextBox()
        Me.txtCod_AlmacenAduana = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObs_EnvioInstruccionesalAgenteAduanas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFec_EnvioFacturaalAgenteAduanas = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFec_EnvioInstruccionesalAgenteAduana = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 152)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 178)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(676, 30)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(469, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(207, 30)
        Me.Panel5.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 1
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
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNom_AlmacenAduana)
        Me.Panel2.Controls.Add(Me.txtCod_AlmacenAduana)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtObs_EnvioInstruccionesalAgenteAduanas)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpFec_EnvioFacturaalAgenteAduanas)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpFec_EnvioInstruccionesalAgenteAduana)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 138)
        Me.Panel2.TabIndex = 1
        '
        'txtNom_AlmacenAduana
        '
        Me.txtNom_AlmacenAduana.Location = New System.Drawing.Point(205, 79)
        Me.txtNom_AlmacenAduana.Name = "txtNom_AlmacenAduana"
        Me.txtNom_AlmacenAduana.Size = New System.Drawing.Size(445, 20)
        Me.txtNom_AlmacenAduana.TabIndex = 12
        '
        'txtCod_AlmacenAduana
        '
        Me.txtCod_AlmacenAduana.Location = New System.Drawing.Point(142, 79)
        Me.txtCod_AlmacenAduana.Name = "txtCod_AlmacenAduana"
        Me.txtCod_AlmacenAduana.Size = New System.Drawing.Size(61, 20)
        Me.txtCod_AlmacenAduana.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Almacen de Aduana.........................."
        '
        'txtObs_EnvioInstruccionesalAgenteAduanas
        '
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Location = New System.Drawing.Point(142, 33)
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Multiline = True
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Name = "txtObs_EnvioInstruccionesalAgenteAduanas"
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Size = New System.Drawing.Size(508, 42)
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observaciones..............................."
        '
        'dtpFec_EnvioFacturaalAgenteAduanas
        '
        Me.dtpFec_EnvioFacturaalAgenteAduanas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec_EnvioFacturaalAgenteAduanas.Location = New System.Drawing.Point(142, 103)
        Me.dtpFec_EnvioFacturaalAgenteAduanas.Name = "dtpFec_EnvioFacturaalAgenteAduanas"
        Me.dtpFec_EnvioFacturaalAgenteAduanas.Size = New System.Drawing.Size(120, 20)
        Me.dtpFec_EnvioFacturaalAgenteAduanas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Envio Factura............"
        '
        'dtpFec_EnvioInstruccionesalAgenteAduana
        '
        Me.dtpFec_EnvioInstruccionesalAgenteAduana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec_EnvioInstruccionesalAgenteAduana.Location = New System.Drawing.Point(142, 9)
        Me.dtpFec_EnvioInstruccionesalAgenteAduana.Name = "dtpFec_EnvioInstruccionesalAgenteAduana"
        Me.dtpFec_EnvioInstruccionesalAgenteAduana.Size = New System.Drawing.Size(120, 20)
        Me.dtpFec_EnvioInstruccionesalAgenteAduana.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Envio......................."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(676, 26)
        Me.Panel3.TabIndex = 65
        '
        'TxtNroEmbarque
        '
        Me.TxtNroEmbarque.AcceptsReturn = True
        Me.TxtNroEmbarque.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroEmbarque.Location = New System.Drawing.Point(103, 3)
        Me.TxtNroEmbarque.MaxLength = 0
        Me.TxtNroEmbarque.Name = "TxtNroEmbarque"
        Me.TxtNroEmbarque.ReadOnly = True
        Me.TxtNroEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroEmbarque.Size = New System.Drawing.Size(92, 20)
        Me.TxtNroEmbarque.TabIndex = 86
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Gold
        Me.Label37.Location = New System.Drawing.Point(17, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(77, 12)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Nº EMBARQUE"
        '
        'FrmTgEmbarque_EnvioInstruccionAGAduana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmTgEmbarque_EnvioInstruccionAGAduana"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envio Instruccion Agente Aduana"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNom_AlmacenAduana As TextBox
    Friend WithEvents txtCod_AlmacenAduana As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObs_EnvioInstruccionesalAgenteAduanas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFec_EnvioFacturaalAgenteAduanas As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFec_EnvioInstruccionesalAgenteAduana As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Public WithEvents Label37 As System.Windows.Forms.Label
End Class
