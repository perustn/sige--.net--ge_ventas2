<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_GuiaLocal
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
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtLicencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.TxtDireccionTransp = New System.Windows.Forms.TextBox()
        Me.TxtRucTransp = New System.Windows.Forms.TextBox()
        Me.TxtTransp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.UiGroupBox2)
        Me.Panel1.Controls.Add(Me.UiGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 168)
        Me.Panel1.TabIndex = 249
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.DTPicker1)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.TxtNumero)
        Me.UiGroupBox2.Controls.Add(Me.Label6)
        Me.UiGroupBox2.Controls.Add(Me.TxtSerie)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Location = New System.Drawing.Point(5, 106)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(675, 54)
        Me.UiGroupBox2.TabIndex = 99
        Me.UiGroupBox2.Text = "Datos de la Guía"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(554, 21)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(107, 20)
        Me.DTPicker1.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(463, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Fecha ........................"
        '
        'TxtNumero
        '
        Me.TxtNumero.AcceptsReturn = True
        Me.TxtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNumero.Location = New System.Drawing.Point(346, 21)
        Me.TxtNumero.MaxLength = 100
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNumero.Size = New System.Drawing.Size(101, 20)
        Me.TxtNumero.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(260, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Número ..............."
        '
        'TxtSerie
        '
        Me.TxtSerie.AcceptsReturn = True
        Me.TxtSerie.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSerie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSerie.Location = New System.Drawing.Point(140, 21)
        Me.TxtSerie.MaxLength = 100
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSerie.Size = New System.Drawing.Size(101, 20)
        Me.TxtSerie.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(54, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Serie ...................."
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.TxtLicencia)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.TxtMarca)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.TxtPlaca)
        Me.UiGroupBox1.Controls.Add(Me.TxtDireccionTransp)
        Me.UiGroupBox1.Controls.Add(Me.TxtRucTransp)
        Me.UiGroupBox1.Controls.Add(Me.TxtTransp)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label13)
        Me.UiGroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(675, 96)
        Me.UiGroupBox1.TabIndex = 98
        Me.UiGroupBox1.Text = "Datos Transportista"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtLicencia
        '
        Me.TxtLicencia.AcceptsReturn = True
        Me.TxtLicencia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLicencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLicencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtLicencia.Location = New System.Drawing.Point(560, 66)
        Me.TxtLicencia.MaxLength = 100
        Me.TxtLicencia.Name = "TxtLicencia"
        Me.TxtLicencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtLicencia.Size = New System.Drawing.Size(101, 20)
        Me.TxtLicencia.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(474, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Licencia ............."
        '
        'TxtMarca
        '
        Me.TxtMarca.AcceptsReturn = True
        Me.TxtMarca.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMarca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtMarca.Location = New System.Drawing.Point(354, 66)
        Me.TxtMarca.MaxLength = 100
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMarca.Size = New System.Drawing.Size(101, 20)
        Me.TxtMarca.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(268, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Marca ...................."
        '
        'TxtPlaca
        '
        Me.TxtPlaca.AcceptsReturn = True
        Me.TxtPlaca.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPlaca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPlaca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPlaca.Location = New System.Drawing.Point(140, 66)
        Me.TxtPlaca.MaxLength = 100
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPlaca.Size = New System.Drawing.Size(101, 20)
        Me.TxtPlaca.TabIndex = 101
        '
        'TxtDireccionTransp
        '
        Me.TxtDireccionTransp.AcceptsReturn = True
        Me.TxtDireccionTransp.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccionTransp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDireccionTransp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDireccionTransp.Location = New System.Drawing.Point(140, 42)
        Me.TxtDireccionTransp.MaxLength = 100
        Me.TxtDireccionTransp.Name = "TxtDireccionTransp"
        Me.TxtDireccionTransp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDireccionTransp.Size = New System.Drawing.Size(521, 20)
        Me.TxtDireccionTransp.TabIndex = 99
        '
        'TxtRucTransp
        '
        Me.TxtRucTransp.AcceptsReturn = True
        Me.TxtRucTransp.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRucTransp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRucTransp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRucTransp.Location = New System.Drawing.Point(140, 18)
        Me.TxtRucTransp.MaxLength = 100
        Me.TxtRucTransp.Name = "TxtRucTransp"
        Me.TxtRucTransp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRucTransp.Size = New System.Drawing.Size(101, 20)
        Me.TxtRucTransp.TabIndex = 96
        '
        'TxtTransp
        '
        Me.TxtTransp.AcceptsReturn = True
        Me.TxtTransp.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTransp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTransp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtTransp.Location = New System.Drawing.Point(242, 18)
        Me.TxtTransp.MaxLength = 100
        Me.TxtTransp.Name = "TxtTransp"
        Me.TxtTransp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTransp.Size = New System.Drawing.Size(419, 20)
        Me.TxtTransp.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "N° Placa ............................"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Domicilio ............................"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(11, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(137, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "RUC / Razón Social .........."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 30)
        Me.Panel2.TabIndex = 248
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(479, 0)
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
        Me.BtnAceptar.Text = "&Imprimir"
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
        Me.Panel4.Size = New System.Drawing.Size(686, 27)
        Me.Panel4.TabIndex = 247
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 7)
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
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 3)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'FrmDocumentoVentaExportacion_GuiaLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVentaExportacion_GuiaLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Impresión de Guía - Venta Local"
        Me.Panel1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents TxtTransp As System.Windows.Forms.TextBox
    Public WithEvents TxtRucTransp As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtPlaca As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtDireccionTransp As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtNumero As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents TxtSerie As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents TxtLicencia As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtMarca As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label8 As System.Windows.Forms.Label
End Class
