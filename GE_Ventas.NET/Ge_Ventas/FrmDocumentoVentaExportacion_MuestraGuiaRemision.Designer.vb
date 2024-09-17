<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_MuestraGuiaRemision
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
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtLicencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSec_Chofer = New System.Windows.Forms.TextBox()
        Me.TxtChofer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtSec_Vehiculo = New System.Windows.Forms.TextBox()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtCod_Transporte = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRuc = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox4.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(534, 28)
        Me.Panel4.TabIndex = 256
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 30)
        Me.Panel2.TabIndex = 257
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(327, 0)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.UiGroupBox4)
        Me.Panel1.Controls.Add(Me.UiGroupBox3)
        Me.Panel1.Controls.Add(Me.UiGroupBox2)
        Me.Panel1.Controls.Add(Me.UiGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 265)
        Me.Panel1.TabIndex = 262
        '
        'UiGroupBox4
        '
        Me.UiGroupBox4.Controls.Add(Me.Text1)
        Me.UiGroupBox4.Controls.Add(Me.Text5)
        Me.UiGroupBox4.Controls.Add(Me.Label8)
        Me.UiGroupBox4.Controls.Add(Me.Label9)
        Me.UiGroupBox4.Location = New System.Drawing.Point(6, 210)
        Me.UiGroupBox4.Name = "UiGroupBox4"
        Me.UiGroupBox4.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox4.Size = New System.Drawing.Size(520, 45)
        Me.UiGroupBox4.TabIndex = 331
        Me.UiGroupBox4.Text = "Datos GR"
        Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Text1.Location = New System.Drawing.Point(407, 18)
        Me.Text1.MaxLength = 25
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(109, 20)
        Me.Text1.TabIndex = 331
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(323, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "Número ...................."
        '
        'Text5
        '
        Me.Text5.AcceptsReturn = True
        Me.Text5.BackColor = System.Drawing.SystemColors.Window
        Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Text5.Location = New System.Drawing.Point(126, 18)
        Me.Text5.MaxLength = 25
        Me.Text5.Name = "Text5"
        Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text5.Size = New System.Drawing.Size(88, 20)
        Me.Text5.TabIndex = 329
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(25, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 328
        Me.Label9.Text = "Serie .............................."
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.TxtLicencia)
        Me.UiGroupBox3.Controls.Add(Me.TxtNombres)
        Me.UiGroupBox3.Controls.Add(Me.TxtSec_Chofer)
        Me.UiGroupBox3.Controls.Add(Me.TxtChofer)
        Me.UiGroupBox3.Controls.Add(Me.Label7)
        Me.UiGroupBox3.Controls.Add(Me.Label4)
        Me.UiGroupBox3.Controls.Add(Me.Label6)
        Me.UiGroupBox3.Location = New System.Drawing.Point(6, 134)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox3.Size = New System.Drawing.Size(520, 70)
        Me.UiGroupBox3.TabIndex = 330
        Me.UiGroupBox3.Text = "Datos Chofer"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtLicencia
        '
        Me.TxtLicencia.AcceptsReturn = True
        Me.TxtLicencia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLicencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLicencia.Enabled = False
        Me.TxtLicencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtLicencia.Location = New System.Drawing.Point(407, 43)
        Me.TxtLicencia.MaxLength = 25
        Me.TxtLicencia.Name = "TxtLicencia"
        Me.TxtLicencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtLicencia.Size = New System.Drawing.Size(109, 20)
        Me.TxtLicencia.TabIndex = 331
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(323, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 330
        Me.Label7.Text = "Licencia ..................."
        '
        'TxtNombres
        '
        Me.TxtNombres.AcceptsReturn = True
        Me.TxtNombres.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNombres.Enabled = False
        Me.TxtNombres.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNombres.Location = New System.Drawing.Point(126, 43)
        Me.TxtNombres.MaxLength = 25
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNombres.Size = New System.Drawing.Size(88, 20)
        Me.TxtNombres.TabIndex = 329
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(25, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Nro Documento ............"
        '
        'TxtSec_Chofer
        '
        Me.TxtSec_Chofer.AcceptsReturn = True
        Me.TxtSec_Chofer.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSec_Chofer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSec_Chofer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSec_Chofer.Location = New System.Drawing.Point(126, 19)
        Me.TxtSec_Chofer.MaxLength = 25
        Me.TxtSec_Chofer.Name = "TxtSec_Chofer"
        Me.TxtSec_Chofer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSec_Chofer.Size = New System.Drawing.Size(88, 20)
        Me.TxtSec_Chofer.TabIndex = 325
        '
        'TxtChofer
        '
        Me.TxtChofer.AcceptsReturn = True
        Me.TxtChofer.BackColor = System.Drawing.SystemColors.Window
        Me.TxtChofer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChofer.Enabled = False
        Me.TxtChofer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtChofer.Location = New System.Drawing.Point(216, 19)
        Me.TxtChofer.MaxLength = 25
        Me.TxtChofer.Name = "TxtChofer"
        Me.TxtChofer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtChofer.Size = New System.Drawing.Size(300, 20)
        Me.TxtChofer.TabIndex = 327
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(25, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 324
        Me.Label6.Text = "Chofer ........................."
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.TxtSec_Vehiculo)
        Me.UiGroupBox2.Controls.Add(Me.TxtPlaca)
        Me.UiGroupBox2.Controls.Add(Me.Label5)
        Me.UiGroupBox2.Location = New System.Drawing.Point(6, 82)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(520, 45)
        Me.UiGroupBox2.TabIndex = 329
        Me.UiGroupBox2.Text = "Datos Vehiculo"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtSec_Vehiculo
        '
        Me.TxtSec_Vehiculo.AcceptsReturn = True
        Me.TxtSec_Vehiculo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSec_Vehiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSec_Vehiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSec_Vehiculo.Location = New System.Drawing.Point(126, 18)
        Me.TxtSec_Vehiculo.MaxLength = 25
        Me.TxtSec_Vehiculo.Name = "TxtSec_Vehiculo"
        Me.TxtSec_Vehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSec_Vehiculo.Size = New System.Drawing.Size(88, 20)
        Me.TxtSec_Vehiculo.TabIndex = 325
        '
        'TxtPlaca
        '
        Me.TxtPlaca.AcceptsReturn = True
        Me.TxtPlaca.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPlaca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPlaca.Enabled = False
        Me.TxtPlaca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPlaca.Location = New System.Drawing.Point(216, 18)
        Me.TxtPlaca.MaxLength = 25
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPlaca.Size = New System.Drawing.Size(300, 20)
        Me.TxtPlaca.TabIndex = 327
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(25, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 324
        Me.Label5.Text = "Vehículo ..................."
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.TxtCod_Transporte)
        Me.UiGroupBox1.Controls.Add(Me.TxtDireccion)
        Me.UiGroupBox1.Controls.Add(Me.TxtRuc)
        Me.UiGroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(520, 70)
        Me.UiGroupBox1.TabIndex = 328
        Me.UiGroupBox1.Text = "Datos Transportista"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtCod_Transporte
        '
        Me.TxtCod_Transporte.AcceptsReturn = True
        Me.TxtCod_Transporte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_Transporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_Transporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_Transporte.Location = New System.Drawing.Point(428, 19)
        Me.TxtCod_Transporte.MaxLength = 25
        Me.TxtCod_Transporte.Name = "TxtCod_Transporte"
        Me.TxtCod_Transporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_Transporte.Size = New System.Drawing.Size(88, 20)
        Me.TxtCod_Transporte.TabIndex = 330
        Me.TxtCod_Transporte.Visible = False
        '
        'TxtDireccion
        '
        Me.TxtDireccion.AcceptsReturn = True
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDireccion.Location = New System.Drawing.Point(126, 43)
        Me.TxtDireccion.MaxLength = 25
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDireccion.Size = New System.Drawing.Size(390, 20)
        Me.TxtDireccion.TabIndex = 329
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(25, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 328
        Me.Label2.Text = "Dirección ..................."
        '
        'TxtRuc
        '
        Me.TxtRuc.AcceptsReturn = True
        Me.TxtRuc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRuc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRuc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRuc.Location = New System.Drawing.Point(126, 19)
        Me.TxtRuc.MaxLength = 25
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRuc.Size = New System.Drawing.Size(88, 20)
        Me.TxtRuc.TabIndex = 325
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.AcceptsReturn = True
        Me.TxtRazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRazonSocial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRazonSocial.Location = New System.Drawing.Point(216, 19)
        Me.TxtRazonSocial.MaxLength = 25
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRazonSocial.Size = New System.Drawing.Size(300, 20)
        Me.TxtRazonSocial.TabIndex = 327
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 324
        Me.Label1.Text = "Razón Social ................."
        '
        'FrmDocumentoVentaExportacion_MuestraGuiaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 323)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVentaExportacion_MuestraGuiaRemision"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Guía de Remisión"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox4.ResumeLayout(False)
        Me.UiGroupBox4.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Text1 As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents Text5 As TextBox
    Public WithEvents Label9 As Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtLicencia As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents TxtNombres As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents TxtSec_Chofer As TextBox
    Public WithEvents TxtChofer As TextBox
    Public WithEvents Label6 As Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtSec_Vehiculo As TextBox
    Public WithEvents TxtPlaca As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtDireccion As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents TxtRuc As TextBox
    Public WithEvents TxtRazonSocial As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents TxtCod_Transporte As TextBox
End Class
