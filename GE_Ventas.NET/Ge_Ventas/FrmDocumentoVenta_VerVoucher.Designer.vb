<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_VerVoucher
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
        Dim GrdLista_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVenta_VerVoucher))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRegistro = New System.Windows.Forms.TextBox()
        Me.GrdLista = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDes_TipVenta = New System.Windows.Forms.TextBox()
        Me.txtDes_Cuenta = New System.Windows.Forms.TextBox()
        Me.txtTipodeCambio = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.txtHaberDol = New System.Windows.Forms.TextBox()
        Me.txtDebeDol = New System.Windows.Forms.TextBox()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDes_TipDoc = New System.Windows.Forms.TextBox()
        Me.txtDoc_Sunat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNum_Docum = New System.Windows.Forms.TextBox()
        Me.txtSer_Docum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtRegistro)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(829, 28)
        Me.Panel4.TabIndex = 255
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
        Me.Label3.Size = New System.Drawing.Size(82, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO REGISTRO"
        '
        'TxtRegistro
        '
        Me.TxtRegistro.AcceptsReturn = True
        Me.TxtRegistro.BackColor = System.Drawing.Color.LightCyan
        Me.TxtRegistro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRegistro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtRegistro.Location = New System.Drawing.Point(116, 4)
        Me.TxtRegistro.MaxLength = 0
        Me.TxtRegistro.Name = "TxtRegistro"
        Me.TxtRegistro.ReadOnly = True
        Me.TxtRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRegistro.Size = New System.Drawing.Size(101, 20)
        Me.TxtRegistro.TabIndex = 121
        '
        'GrdLista
        '
        Me.GrdLista.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdLista.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdLista_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GrdLista.DesignTimeLayout = GrdLista_DesignTimeLayout
        Me.GrdLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdLista.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdLista.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLista.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdLista.GroupByBoxVisible = False
        Me.GrdLista.Location = New System.Drawing.Point(0, 53)
        Me.GrdLista.Name = "GrdLista"
        Me.GrdLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdLista.RecordNavigator = True
        Me.GrdLista.Size = New System.Drawing.Size(829, 349)
        Me.GrdLista.TabIndex = 261
        Me.GrdLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "IMPRIMIR"
        BarraOpciones_Item_0_0.LargeImageIndex = 21
        BarraOpciones_Item_0_0.SmallImageIndex = 44
        BarraOpciones_Item_0_0.Text = "Imprimir"
        BarraOpciones_Item_0_1.Enabled = False
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "GENERAR"
        BarraOpciones_Item_0_1.Text = "Generar"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ADICIONAR"
        BarraOpciones_Item_0_2.SmallImageIndex = 42
        BarraOpciones_Item_0_2.Text = "Adicionar Cuenta"
        BarraOpciones_Item_0_3.Image = CType(resources.GetObject("BarraOpciones_Item_0_3.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_3.Key = "MODIFICAR"
        BarraOpciones_Item_0_3.SmallImageIndex = 40
        BarraOpciones_Item_0_3.Text = "Modificar Cuenta"
        BarraOpciones_Item_0_4.Image = CType(resources.GetObject("BarraOpciones_Item_0_4.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_4.Key = "ELIMINAR"
        BarraOpciones_Item_0_4.LargeImageIndex = 17
        BarraOpciones_Item_0_4.SmallImageIndex = 39
        BarraOpciones_Item_0_4.Text = "Eliminar Cuenta"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2, BarraOpciones_Item_0_3, BarraOpciones_Item_0_4})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 28)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(829, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 260
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.UiGroupBox1)
        Me.fraDatos.Controls.Add(Me.Panel2)
        Me.fraDatos.Location = New System.Drawing.Point(144, 101)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(540, 225)
        Me.fraDatos.TabIndex = 262
        Me.fraDatos.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 30)
        Me.Panel2.TabIndex = 259
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(333, 0)
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
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.txtNum_Docum)
        Me.UiGroupBox1.Controls.Add(Me.txtSer_Docum)
        Me.UiGroupBox1.Controls.Add(Me.txtDes_TipDoc)
        Me.UiGroupBox1.Controls.Add(Me.txtDoc_Sunat)
        Me.UiGroupBox1.Controls.Add(Me.txtGlosa)
        Me.UiGroupBox1.Controls.Add(Me.txtHaberDol)
        Me.UiGroupBox1.Controls.Add(Me.txtDebeDol)
        Me.UiGroupBox1.Controls.Add(Me.txtHaber)
        Me.UiGroupBox1.Controls.Add(Me.txtDebe)
        Me.UiGroupBox1.Controls.Add(Me.TextBox4)
        Me.UiGroupBox1.Controls.Add(Me.TextBox5)
        Me.UiGroupBox1.Controls.Add(Me.TextBox3)
        Me.UiGroupBox1.Controls.Add(Me.TextBox2)
        Me.UiGroupBox1.Controls.Add(Me.TextBox1)
        Me.UiGroupBox1.Controls.Add(Me.txtDes_TipVenta)
        Me.UiGroupBox1.Controls.Add(Me.txtDes_Cuenta)
        Me.UiGroupBox1.Controls.Add(Me.txtTipodeCambio)
        Me.UiGroupBox1.Controls.Add(Me.txtCuenta)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(525, 188)
        Me.UiGroupBox1.TabIndex = 260
        Me.UiGroupBox1.Text = "Reingrese Cuenta Contable"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtDes_TipVenta
        '
        Me.txtDes_TipVenta.AcceptsReturn = True
        Me.txtDes_TipVenta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDes_TipVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_TipVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDes_TipVenta.ForeColor = System.Drawing.Color.Blue
        Me.txtDes_TipVenta.Location = New System.Drawing.Point(198, 42)
        Me.txtDes_TipVenta.MaxLength = 25
        Me.txtDes_TipVenta.Name = "txtDes_TipVenta"
        Me.txtDes_TipVenta.ReadOnly = True
        Me.txtDes_TipVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_TipVenta.Size = New System.Drawing.Size(153, 19)
        Me.txtDes_TipVenta.TabIndex = 348
        Me.txtDes_TipVenta.Text = "SOLES"
        Me.txtDes_TipVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDes_Cuenta
        '
        Me.txtDes_Cuenta.AcceptsReturn = True
        Me.txtDes_Cuenta.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Cuenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Cuenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_Cuenta.Location = New System.Drawing.Point(198, 19)
        Me.txtDes_Cuenta.MaxLength = 25
        Me.txtDes_Cuenta.Name = "txtDes_Cuenta"
        Me.txtDes_Cuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Cuenta.Size = New System.Drawing.Size(311, 20)
        Me.txtDes_Cuenta.TabIndex = 347
        '
        'txtTipodeCambio
        '
        Me.txtTipodeCambio.AcceptsReturn = True
        Me.txtTipodeCambio.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipodeCambio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipodeCambio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTipodeCambio.Location = New System.Drawing.Point(117, 42)
        Me.txtTipodeCambio.MaxLength = 25
        Me.txtTipodeCambio.Name = "txtTipodeCambio"
        Me.txtTipodeCambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipodeCambio.Size = New System.Drawing.Size(79, 20)
        Me.txtTipodeCambio.TabIndex = 346
        '
        'txtCuenta
        '
        Me.txtCuenta.AcceptsReturn = True
        Me.txtCuenta.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCuenta.Location = New System.Drawing.Point(117, 19)
        Me.txtCuenta.MaxLength = 25
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuenta.Size = New System.Drawing.Size(79, 20)
        Me.txtCuenta.TabIndex = 344
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "Tipo de Cambio ..................."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "Cuenta Contable ................."
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(356, 42)
        Me.TextBox1.MaxLength = 25
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(153, 19)
        Me.TextBox1.TabIndex = 349
        Me.TextBox1.Text = "DOLARES"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(198, 64)
        Me.TextBox2.MaxLength = 25
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(74, 19)
        Me.TextBox2.TabIndex = 350
        Me.TextBox2.Text = "DEBE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Blue
        Me.TextBox3.Location = New System.Drawing.Point(277, 64)
        Me.TextBox3.MaxLength = 25
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(74, 19)
        Me.TextBox3.TabIndex = 351
        Me.TextBox3.Text = "HABER"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Blue
        Me.TextBox4.Location = New System.Drawing.Point(435, 64)
        Me.TextBox4.MaxLength = 25
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(74, 19)
        Me.TextBox4.TabIndex = 353
        Me.TextBox4.Text = "HABER"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Blue
        Me.TextBox5.Location = New System.Drawing.Point(356, 64)
        Me.TextBox5.MaxLength = 25
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(74, 19)
        Me.TextBox5.TabIndex = 352
        Me.TextBox5.Text = "DEBE"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHaber
        '
        Me.txtHaber.AcceptsReturn = True
        Me.txtHaber.BackColor = System.Drawing.SystemColors.Window
        Me.txtHaber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHaber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHaber.Location = New System.Drawing.Point(277, 87)
        Me.txtHaber.MaxLength = 25
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHaber.Size = New System.Drawing.Size(74, 20)
        Me.txtHaber.TabIndex = 355
        '
        'txtDebe
        '
        Me.txtDebe.AcceptsReturn = True
        Me.txtDebe.BackColor = System.Drawing.SystemColors.Window
        Me.txtDebe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDebe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDebe.Location = New System.Drawing.Point(198, 87)
        Me.txtDebe.MaxLength = 25
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDebe.Size = New System.Drawing.Size(74, 20)
        Me.txtDebe.TabIndex = 354
        '
        'txtHaberDol
        '
        Me.txtHaberDol.AcceptsReturn = True
        Me.txtHaberDol.BackColor = System.Drawing.SystemColors.Window
        Me.txtHaberDol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHaberDol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHaberDol.Location = New System.Drawing.Point(435, 87)
        Me.txtHaberDol.MaxLength = 25
        Me.txtHaberDol.Name = "txtHaberDol"
        Me.txtHaberDol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHaberDol.Size = New System.Drawing.Size(74, 20)
        Me.txtHaberDol.TabIndex = 357
        '
        'txtDebeDol
        '
        Me.txtDebeDol.AcceptsReturn = True
        Me.txtDebeDol.BackColor = System.Drawing.SystemColors.Window
        Me.txtDebeDol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDebeDol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDebeDol.Location = New System.Drawing.Point(356, 87)
        Me.txtDebeDol.MaxLength = 25
        Me.txtDebeDol.Name = "txtDebeDol"
        Me.txtDebeDol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDebeDol.Size = New System.Drawing.Size(74, 20)
        Me.txtDebeDol.TabIndex = 356
        '
        'txtGlosa
        '
        Me.txtGlosa.AcceptsReturn = True
        Me.txtGlosa.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtGlosa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGlosa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGlosa.Location = New System.Drawing.Point(117, 113)
        Me.txtGlosa.MaxLength = 25
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.ReadOnly = True
        Me.txtGlosa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGlosa.Size = New System.Drawing.Size(392, 20)
        Me.txtGlosa.TabIndex = 359
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 358
        Me.Label4.Text = "Glosa .............................."
        '
        'txtDes_TipDoc
        '
        Me.txtDes_TipDoc.AcceptsReturn = True
        Me.txtDes_TipDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_TipDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_TipDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_TipDoc.Location = New System.Drawing.Point(198, 136)
        Me.txtDes_TipDoc.MaxLength = 25
        Me.txtDes_TipDoc.Name = "txtDes_TipDoc"
        Me.txtDes_TipDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_TipDoc.Size = New System.Drawing.Size(311, 20)
        Me.txtDes_TipDoc.TabIndex = 362
        '
        'txtDoc_Sunat
        '
        Me.txtDoc_Sunat.AcceptsReturn = True
        Me.txtDoc_Sunat.BackColor = System.Drawing.SystemColors.Window
        Me.txtDoc_Sunat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDoc_Sunat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDoc_Sunat.Location = New System.Drawing.Point(117, 136)
        Me.txtDoc_Sunat.MaxLength = 25
        Me.txtDoc_Sunat.Name = "txtDoc_Sunat"
        Me.txtDoc_Sunat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDoc_Sunat.Size = New System.Drawing.Size(79, 20)
        Me.txtDoc_Sunat.TabIndex = 361
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 360
        Me.Label5.Text = "Tipo Doc. ........................."
        '
        'txtNum_Docum
        '
        Me.txtNum_Docum.AcceptsReturn = True
        Me.txtNum_Docum.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Docum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Docum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNum_Docum.Location = New System.Drawing.Point(198, 159)
        Me.txtNum_Docum.MaxLength = 25
        Me.txtNum_Docum.Name = "txtNum_Docum"
        Me.txtNum_Docum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Docum.Size = New System.Drawing.Size(311, 20)
        Me.txtNum_Docum.TabIndex = 365
        '
        'txtSer_Docum
        '
        Me.txtSer_Docum.AcceptsReturn = True
        Me.txtSer_Docum.BackColor = System.Drawing.SystemColors.Window
        Me.txtSer_Docum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSer_Docum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSer_Docum.Location = New System.Drawing.Point(117, 159)
        Me.txtSer_Docum.MaxLength = 25
        Me.txtSer_Docum.Name = "txtSer_Docum"
        Me.txtSer_Docum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSer_Docum.Size = New System.Drawing.Size(79, 20)
        Me.txtSer_Docum.TabIndex = 364
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(13, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "Serie / Número ..............."
        '
        'FrmDocumentoVenta_VerVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 402)
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.GrdLista)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVenta_VerVoucher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Voucher Contable"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtRegistro As TextBox
    Public WithEvents GrdLista As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtNum_Docum As TextBox
    Public WithEvents txtSer_Docum As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtDes_TipDoc As TextBox
    Public WithEvents txtDoc_Sunat As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtGlosa As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtHaberDol As TextBox
    Public WithEvents txtDebeDol As TextBox
    Public WithEvents txtHaber As TextBox
    Public WithEvents txtDebe As TextBox
    Public WithEvents TextBox4 As TextBox
    Public WithEvents TextBox5 As TextBox
    Public WithEvents TextBox3 As TextBox
    Public WithEvents TextBox2 As TextBox
    Public WithEvents TextBox1 As TextBox
    Public WithEvents txtDes_TipVenta As TextBox
    Public WithEvents txtDes_Cuenta As TextBox
    Public WithEvents txtTipodeCambio As TextBox
    Public WithEvents txtCuenta As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
End Class
