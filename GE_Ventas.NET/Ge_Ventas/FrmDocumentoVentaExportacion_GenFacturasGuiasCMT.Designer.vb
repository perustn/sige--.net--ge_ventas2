<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMT
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
        Dim GrdDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVentaExportacion_GenFacturasGuiasCMT))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Frm_Guia_Electronica = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtSerie_Electronica = New System.Windows.Forms.TextBox()
        Me.TxtNumero_Electronico = New System.Windows.Forms.TextBox()
        Me.LblEstilo = New System.Windows.Forms.Label()
        Me.LblPO = New System.Windows.Forms.Label()
        Me.LblCodCliente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frm_Guia_Electronica.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtCorrelativo)
        Me.Panel4.Controls.Add(Me.txtNumero)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtSerie)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 27)
        Me.Panel4.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(349, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(104, 12)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "NRO CORRELATIVO"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.AcceptsReturn = True
        Me.txtCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.txtCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrelativo.Location = New System.Drawing.Point(466, 3)
        Me.txtCorrelativo.MaxLength = 0
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.ReadOnly = True
        Me.txtCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.txtCorrelativo.TabIndex = 124
        '
        'txtNumero
        '
        Me.txtNumero.AcceptsReturn = True
        Me.txtNumero.BackColor = System.Drawing.Color.LightCyan
        Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero.Location = New System.Drawing.Point(158, 3)
        Me.txtNumero.MaxLength = 0
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumero.Size = New System.Drawing.Size(160, 20)
        Me.txtNumero.TabIndex = 122
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
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO DOCUMENTO"
        '
        'txtSerie
        '
        Me.txtSerie.AcceptsReturn = True
        Me.txtSerie.BackColor = System.Drawing.Color.LightCyan
        Me.txtSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerie.Location = New System.Drawing.Point(108, 3)
        Me.txtSerie.MaxLength = 0
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerie.Size = New System.Drawing.Size(49, 20)
        Me.txtSerie.TabIndex = 121
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowColumnDrag = False
        Me.GrdDatos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdDatos.AlternatingColors = True
        Me.GrdDatos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GrdDatos.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdDatos_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GrdDatos.DesignTimeLayout = GrdDatos_DesignTimeLayout
        Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdDatos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDatos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdDatos.GroupByBoxVisible = False
        Me.GrdDatos.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDatos.Location = New System.Drawing.Point(0, 49)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(800, 401)
        Me.GrdDatos.TabIndex = 253
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Top
        ButtonBar1_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "PROCESAR"
        ButtonBar1_Item_0_0.Text = "Procesar"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "GENERARFACT"
        ButtonBar1_Item_0_1.Text = "Generar Factura CMT"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "VERFACTURA"
        ButtonBar1_Item_0_2.Text = "Ver Factura CMT"
        ButtonBar1_Item_0_3.Image = CType(resources.GetObject("ButtonBar1_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_3.Key = "IMPGUIAMEC"
        ButtonBar1_Item_0_3.Text = "Imprimir Guía Mecanizada"
        ButtonBar1_Item_0_4.Image = CType(resources.GetObject("ButtonBar1_Item_0_4.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_4.Key = "IMPGUIAELEC"
        ButtonBar1_Item_0_4.Text = "Imprimir Guía Electrónica"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2, ButtonBar1_Item_0_3, ButtonBar1_Item_0_4})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 27)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(800, 22)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.ButtonBar1.TabIndex = 252
        Me.ButtonBar1.Text = "ButtonBar2"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Frm_Guia_Electronica
        '
        Me.Frm_Guia_Electronica.Controls.Add(Me.Panel7)
        Me.Frm_Guia_Electronica.Controls.Add(Me.Panel5)
        Me.Frm_Guia_Electronica.Controls.Add(Me.Label36)
        Me.Frm_Guia_Electronica.Location = New System.Drawing.Point(130, 130)
        Me.Frm_Guia_Electronica.Name = "Frm_Guia_Electronica"
        Me.Frm_Guia_Electronica.Size = New System.Drawing.Size(461, 190)
        Me.Frm_Guia_Electronica.TabIndex = 254
        Me.Frm_Guia_Electronica.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.DTPicker1)
        Me.Panel7.Controls.Add(Me.TxtSerie_Electronica)
        Me.Panel7.Controls.Add(Me.TxtNumero_Electronico)
        Me.Panel7.Controls.Add(Me.LblEstilo)
        Me.Panel7.Controls.Add(Me.LblPO)
        Me.Panel7.Controls.Add(Me.LblCodCliente)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 20)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(461, 140)
        Me.Panel7.TabIndex = 265
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(118, 88)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(107, 20)
        Me.DTPicker1.TabIndex = 330
        '
        'TxtSerie_Electronica
        '
        Me.TxtSerie_Electronica.AcceptsReturn = True
        Me.TxtSerie_Electronica.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSerie_Electronica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSerie_Electronica.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TxtSerie_Electronica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSerie_Electronica.Location = New System.Drawing.Point(118, 114)
        Me.TxtSerie_Electronica.MaxLength = 25
        Me.TxtSerie_Electronica.Name = "TxtSerie_Electronica"
        Me.TxtSerie_Electronica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSerie_Electronica.Size = New System.Drawing.Size(88, 22)
        Me.TxtSerie_Electronica.TabIndex = 328
        '
        'TxtNumero_Electronico
        '
        Me.TxtNumero_Electronico.AcceptsReturn = True
        Me.TxtNumero_Electronico.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNumero_Electronico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNumero_Electronico.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TxtNumero_Electronico.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtNumero_Electronico.Location = New System.Drawing.Point(207, 114)
        Me.TxtNumero_Electronico.MaxLength = 25
        Me.TxtNumero_Electronico.Name = "TxtNumero_Electronico"
        Me.TxtNumero_Electronico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNumero_Electronico.Size = New System.Drawing.Size(250, 22)
        Me.TxtNumero_Electronico.TabIndex = 329
        '
        'LblEstilo
        '
        Me.LblEstilo.BackColor = System.Drawing.Color.Transparent
        Me.LblEstilo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEstilo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.LblEstilo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblEstilo.Location = New System.Drawing.Point(115, 62)
        Me.LblEstilo.Name = "LblEstilo"
        Me.LblEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEstilo.Size = New System.Drawing.Size(331, 20)
        Me.LblEstilo.TabIndex = 271
        '
        'LblPO
        '
        Me.LblPO.BackColor = System.Drawing.Color.Transparent
        Me.LblPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPO.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.LblPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblPO.Location = New System.Drawing.Point(115, 36)
        Me.LblPO.Name = "LblPO"
        Me.LblPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPO.Size = New System.Drawing.Size(331, 20)
        Me.LblPO.TabIndex = 270
        '
        'LblCodCliente
        '
        Me.LblCodCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblCodCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCodCliente.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.LblCodCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblCodCliente.Location = New System.Drawing.Point(115, 10)
        Me.LblCodCliente.Name = "LblCodCliente"
        Me.LblCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCodCliente.Size = New System.Drawing.Size(331, 20)
        Me.LblCodCliente.TabIndex = 269
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MistyRose
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(3, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 268
        Me.Label6.Text = "SERIE:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(3, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 267
        Me.Label5.Text = "FECHA:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MistyRose
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "ESTILO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MistyRose
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "PO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MistyRose
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "COD CLIENTE:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 160)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(461, 30)
        Me.Panel5.TabIndex = 264
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnCancelar)
        Me.Panel6.Controls.Add(Me.BtnAceptar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(136, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 30)
        Me.Panel6.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(103, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
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
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Gold
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label36.Location = New System.Drawing.Point(0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(461, 20)
        Me.Label36.TabIndex = 263
        Me.Label36.Text = "Generar Guía Electrónica"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDocumentoVentaExportacion_GenFacturasGuiasCMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Frm_Guia_Electronica)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVentaExportacion_GenFacturasGuiasCMT"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generación Facturas - Guías CMT"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frm_Guia_Electronica.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents txtNumero As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtSerie As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtCorrelativo As TextBox
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Frm_Guia_Electronica As Panel
    Friend WithEvents Panel7 As Panel
    Public WithEvents LblEstilo As Label
    Public WithEvents LblPO As Label
    Public WithEvents LblCodCliente As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label36 As Label
    Public WithEvents TxtSerie_Electronica As TextBox
    Public WithEvents TxtNumero_Electronico As TextBox
    Friend WithEvents DTPicker1 As DateTimePicker
End Class
