<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_VerStatusFact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVenta_VerStatusFact))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrdLista = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtCodTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDesTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtDesEnvio = New System.Windows.Forms.TextBox()
        Me.txtCodEnvio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesProceso = New System.Windows.Forms.TextBox()
        Me.txtCodProceso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesValidacion = New System.Windows.Forms.TextBox()
        Me.txtCodValidacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.UiGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 123)
        Me.Panel1.TabIndex = 0
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
        Me.GrdLista.Location = New System.Drawing.Point(0, 148)
        Me.GrdLista.Name = "GrdLista"
        Me.GrdLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdLista.RecordNavigator = True
        Me.GrdLista.Size = New System.Drawing.Size(1073, 452)
        Me.GrdLista.TabIndex = 261
        Me.GrdLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "ACTEST"
        BarraOpciones_Item_0_0.SmallImageIndex = 42
        BarraOpciones_Item_0_0.Text = "Actualizar Estado"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "IMPDF"
        BarraOpciones_Item_0_1.SmallImageIndex = 40
        BarraOpciones_Item_0_1.Text = "Ver Archivo PDF"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "IMTEXT"
        BarraOpciones_Item_0_2.LargeImageIndex = 17
        BarraOpciones_Item_0_2.SmallImageIndex = 39
        BarraOpciones_Item_0_2.Text = "Ver Archivo Texto"
        BarraOpciones_Item_0_3.Image = CType(resources.GetObject("BarraOpciones_Item_0_3.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_3.Key = "IMCDR"
        BarraOpciones_Item_0_3.LargeImageIndex = 22
        BarraOpciones_Item_0_3.SmallImageIndex = 45
        BarraOpciones_Item_0_3.Text = "Ver Archivo CDR"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2, BarraOpciones_Item_0_3})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 123)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(1073, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 260
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.BtnBuscar)
        Me.UiGroupBox1.Controls.Add(Me.TxtNumero)
        Me.UiGroupBox1.Controls.Add(Me.Label8)
        Me.UiGroupBox1.Controls.Add(Me.TxtSerie)
        Me.UiGroupBox1.Controls.Add(Me.Label7)
        Me.UiGroupBox1.Controls.Add(Me.dtpFin)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.txtDesValidacion)
        Me.UiGroupBox1.Controls.Add(Me.txtCodValidacion)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.txtDesProceso)
        Me.UiGroupBox1.Controls.Add(Me.txtCodProceso)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.dtpInicio)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.txtDesEnvio)
        Me.UiGroupBox1.Controls.Add(Me.txtCodEnvio)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.TxtDesTipoDoc)
        Me.UiGroupBox1.Controls.Add(Me.TxtCodTipoDoc)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(1062, 104)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Filtros de Búsqueda"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtCodTipoDoc
        '
        Me.TxtCodTipoDoc.AcceptsReturn = True
        Me.TxtCodTipoDoc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCodTipoDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodTipoDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCodTipoDoc.Location = New System.Drawing.Point(99, 19)
        Me.TxtCodTipoDoc.MaxLength = 100
        Me.TxtCodTipoDoc.Name = "TxtCodTipoDoc"
        Me.TxtCodTipoDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodTipoDoc.Size = New System.Drawing.Size(58, 20)
        Me.TxtCodTipoDoc.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Tipo Doc .............."
        '
        'TxtDesTipoDoc
        '
        Me.TxtDesTipoDoc.AcceptsReturn = True
        Me.TxtDesTipoDoc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDesTipoDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDesTipoDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDesTipoDoc.Location = New System.Drawing.Point(159, 19)
        Me.TxtDesTipoDoc.MaxLength = 100
        Me.TxtDesTipoDoc.Name = "TxtDesTipoDoc"
        Me.TxtDesTipoDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDesTipoDoc.Size = New System.Drawing.Size(218, 20)
        Me.TxtDesTipoDoc.TabIndex = 106
        '
        'txtDesEnvio
        '
        Me.txtDesEnvio.AcceptsReturn = True
        Me.txtDesEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesEnvio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesEnvio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDesEnvio.Location = New System.Drawing.Point(159, 73)
        Me.txtDesEnvio.MaxLength = 100
        Me.txtDesEnvio.Name = "txtDesEnvio"
        Me.txtDesEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesEnvio.Size = New System.Drawing.Size(218, 20)
        Me.txtDesEnvio.TabIndex = 109
        '
        'txtCodEnvio
        '
        Me.txtCodEnvio.AcceptsReturn = True
        Me.txtCodEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodEnvio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodEnvio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCodEnvio.Location = New System.Drawing.Point(99, 73)
        Me.txtCodEnvio.MaxLength = 100
        Me.txtCodEnvio.Name = "txtCodEnvio"
        Me.txtCodEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodEnvio.Size = New System.Drawing.Size(58, 20)
        Me.txtCodEnvio.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Envío ..................."
        '
        'dtpInicio
        '
        Me.dtpInicio.Checked = False
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(99, 46)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(101, 20)
        Me.dtpInicio.TabIndex = 334
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Fecha Inicio ................."
        '
        'txtDesProceso
        '
        Me.txtDesProceso.AcceptsReturn = True
        Me.txtDesProceso.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesProceso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesProceso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDesProceso.Location = New System.Drawing.Point(548, 73)
        Me.txtDesProceso.MaxLength = 100
        Me.txtDesProceso.Name = "txtDesProceso"
        Me.txtDesProceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesProceso.Size = New System.Drawing.Size(163, 20)
        Me.txtDesProceso.TabIndex = 337
        '
        'txtCodProceso
        '
        Me.txtCodProceso.AcceptsReturn = True
        Me.txtCodProceso.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodProceso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodProceso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCodProceso.Location = New System.Drawing.Point(488, 73)
        Me.txtCodProceso.MaxLength = 100
        Me.txtCodProceso.Name = "txtCodProceso"
        Me.txtCodProceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodProceso.Size = New System.Drawing.Size(58, 20)
        Me.txtCodProceso.TabIndex = 336
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(405, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 335
        Me.Label4.Text = "Proceso ..............."
        '
        'txtDesValidacion
        '
        Me.txtDesValidacion.AcceptsReturn = True
        Me.txtDesValidacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesValidacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesValidacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDesValidacion.Location = New System.Drawing.Point(874, 73)
        Me.txtDesValidacion.MaxLength = 100
        Me.txtDesValidacion.Name = "txtDesValidacion"
        Me.txtDesValidacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesValidacion.Size = New System.Drawing.Size(163, 20)
        Me.txtDesValidacion.TabIndex = 340
        '
        'txtCodValidacion
        '
        Me.txtCodValidacion.AcceptsReturn = True
        Me.txtCodValidacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodValidacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodValidacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCodValidacion.Location = New System.Drawing.Point(814, 73)
        Me.txtCodValidacion.MaxLength = 100
        Me.txtCodValidacion.Name = "txtCodValidacion"
        Me.txtCodValidacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodValidacion.Size = New System.Drawing.Size(58, 20)
        Me.txtCodValidacion.TabIndex = 339
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(734, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 338
        Me.Label5.Text = "Validación .........."
        '
        'dtpFin
        '
        Me.dtpFin.Checked = False
        Me.dtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(488, 46)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(101, 20)
        Me.dtpFin.TabIndex = 342
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(405, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 341
        Me.Label6.Text = "Fecha Fin ............"
        '
        'TxtSerie
        '
        Me.TxtSerie.AcceptsReturn = True
        Me.TxtSerie.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSerie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSerie.Location = New System.Drawing.Point(488, 19)
        Me.TxtSerie.MaxLength = 100
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSerie.Size = New System.Drawing.Size(58, 20)
        Me.TxtSerie.TabIndex = 344
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(405, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Serie ...................."
        '
        'TxtNumero
        '
        Me.TxtNumero.AcceptsReturn = True
        Me.TxtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNumero.Location = New System.Drawing.Point(706, 19)
        Me.TxtNumero.MaxLength = 100
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNumero.Size = New System.Drawing.Size(117, 20)
        Me.TxtNumero.TabIndex = 346
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(623, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 345
        Me.Label8.Text = "Número ..............................."
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.Location = New System.Drawing.Point(866, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(182, 29)
        Me.BtnBuscar.TabIndex = 347
        Me.BtnBuscar.Text = "Realizar Búsqueda"
        Me.BtnBuscar.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_VerStatusFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 600)
        Me.Controls.Add(Me.GrdLista)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_VerStatusFact"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Status Factura Electrónica"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents GrdLista As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtDesEnvio As TextBox
    Public WithEvents txtCodEnvio As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents TxtDesTipoDoc As TextBox
    Public WithEvents TxtCodTipoDoc As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents TxtNumero As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents TxtSerie As TextBox
    Public WithEvents Label7 As Label
    Friend WithEvents dtpFin As DateTimePicker
    Public WithEvents Label6 As Label
    Public WithEvents txtDesValidacion As TextBox
    Public WithEvents txtCodValidacion As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtDesProceso As TextBox
    Public WithEvents txtCodProceso As TextBox
    Public WithEvents Label4 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Public WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
End Class
