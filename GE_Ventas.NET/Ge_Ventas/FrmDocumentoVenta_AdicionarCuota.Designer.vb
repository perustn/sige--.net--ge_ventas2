<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_AdicionarCuota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVenta_AdicionarCuota))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrdLista = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroMonto = New System.Windows.Forms.TextBox()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblDetra = New System.Windows.Forms.Label()
        Me.txtDetra = New System.Windows.Forms.TextBox()
        Me.btnCalcDetra = New Janus.Windows.EditControls.UIButton()
        Me.FraFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtMontoDetra = New System.Windows.Forms.TextBox()
        Me.lblMontoDetra = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFiltro.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(559, 28)
        Me.Panel4.TabIndex = 257
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.FraFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 75)
        Me.Panel1.TabIndex = 261
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
        Me.GrdLista.Location = New System.Drawing.Point(0, 128)
        Me.GrdLista.Name = "GrdLista"
        Me.GrdLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdLista.RecordNavigator = True
        Me.GrdLista.Size = New System.Drawing.Size(559, 253)
        Me.GrdLista.TabIndex = 263
        Me.GrdLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "GRABAR"
        BarraOpciones_Item_0_0.SmallImageIndex = 42
        BarraOpciones_Item_0_0.Text = "Grabar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "ACTUALIZAR"
        BarraOpciones_Item_0_1.SmallImageIndex = 40
        BarraOpciones_Item_0_1.Text = "Actualizar"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ELIMINAR"
        BarraOpciones_Item_0_2.LargeImageIndex = 17
        BarraOpciones_Item_0_2.SmallImageIndex = 39
        BarraOpciones_Item_0_2.Text = "Eliminar"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 103)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(559, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 262
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(276, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 331
        Me.Label2.Text = "Fecha Venc ............"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Nro ..............."
        '
        'txtNroMonto
        '
        Me.txtNroMonto.AcceptsReturn = True
        Me.txtNroMonto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNroMonto.Enabled = False
        Me.txtNroMonto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNroMonto.Location = New System.Drawing.Point(79, 15)
        Me.txtNroMonto.MaxLength = 100
        Me.txtNroMonto.Name = "txtNroMonto"
        Me.txtNroMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNroMonto.Size = New System.Drawing.Size(50, 20)
        Me.txtNroMonto.TabIndex = 99
        '
        'dtPicker
        '
        Me.dtPicker.Checked = False
        Me.dtPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPicker.Location = New System.Drawing.Point(366, 16)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(101, 20)
        Me.dtPicker.TabIndex = 332
        '
        'lblDetra
        '
        Me.lblDetra.AutoSize = True
        Me.lblDetra.BackColor = System.Drawing.Color.Transparent
        Me.lblDetra.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDetra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDetra.Location = New System.Drawing.Point(13, 48)
        Me.lblDetra.Name = "lblDetra"
        Me.lblDetra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDetra.Size = New System.Drawing.Size(86, 13)
        Me.lblDetra.TabIndex = 333
        Me.lblDetra.Text = "% Detra ............."
        Me.lblDetra.Visible = False
        '
        'txtDetra
        '
        Me.txtDetra.AcceptsReturn = True
        Me.txtDetra.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDetra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDetra.Location = New System.Drawing.Point(79, 41)
        Me.txtDetra.MaxLength = 100
        Me.txtDetra.Name = "txtDetra"
        Me.txtDetra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDetra.Size = New System.Drawing.Size(50, 20)
        Me.txtDetra.TabIndex = 334
        Me.txtDetra.Visible = False
        '
        'btnCalcDetra
        '
        Me.btnCalcDetra.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.btnCalcDetra.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCalcDetra.Location = New System.Drawing.Point(135, 41)
        Me.btnCalcDetra.Name = "btnCalcDetra"
        Me.btnCalcDetra.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnCalcDetra.Size = New System.Drawing.Size(98, 20)
        Me.btnCalcDetra.TabIndex = 335
        Me.btnCalcDetra.Text = "Calc. Detra."
        Me.btnCalcDetra.Visible = False
        Me.btnCalcDetra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FraFiltro
        '
        Me.FraFiltro.Controls.Add(Me.txtMontoDetra)
        Me.FraFiltro.Controls.Add(Me.btnCalcDetra)
        Me.FraFiltro.Controls.Add(Me.txtDetra)
        Me.FraFiltro.Controls.Add(Me.dtPicker)
        Me.FraFiltro.Controls.Add(Me.txtMonto)
        Me.FraFiltro.Controls.Add(Me.txtNroMonto)
        Me.FraFiltro.Controls.Add(Me.lblMontoDetra)
        Me.FraFiltro.Controls.Add(Me.lblDetra)
        Me.FraFiltro.Controls.Add(Me.Label1)
        Me.FraFiltro.Controls.Add(Me.Label7)
        Me.FraFiltro.Controls.Add(Me.Label2)
        Me.FraFiltro.Location = New System.Drawing.Point(4, 1)
        Me.FraFiltro.Name = "FraFiltro"
        Me.FraFiltro.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraFiltro.Size = New System.Drawing.Size(537, 68)
        Me.FraFiltro.TabIndex = 102
        Me.FraFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(151, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Monto ..........."
        '
        'txtMonto
        '
        Me.txtMonto.AcceptsReturn = True
        Me.txtMonto.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMonto.Location = New System.Drawing.Point(205, 15)
        Me.txtMonto.MaxLength = 100
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMonto.Size = New System.Drawing.Size(50, 20)
        Me.txtMonto.TabIndex = 101
        '
        'txtMontoDetra
        '
        Me.txtMontoDetra.AcceptsReturn = True
        Me.txtMontoDetra.BackColor = System.Drawing.SystemColors.Window
        Me.txtMontoDetra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontoDetra.Enabled = False
        Me.txtMontoDetra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMontoDetra.Location = New System.Drawing.Point(366, 41)
        Me.txtMontoDetra.MaxLength = 100
        Me.txtMontoDetra.Name = "txtMontoDetra"
        Me.txtMontoDetra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMontoDetra.Size = New System.Drawing.Size(101, 20)
        Me.txtMontoDetra.TabIndex = 337
        Me.txtMontoDetra.Visible = False
        '
        'lblMontoDetra
        '
        Me.lblMontoDetra.AutoSize = True
        Me.lblMontoDetra.BackColor = System.Drawing.Color.Transparent
        Me.lblMontoDetra.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMontoDetra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMontoDetra.Location = New System.Drawing.Point(276, 48)
        Me.lblMontoDetra.Name = "lblMontoDetra"
        Me.lblMontoDetra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMontoDetra.Size = New System.Drawing.Size(112, 13)
        Me.lblMontoDetra.TabIndex = 336
        Me.lblMontoDetra.Text = "Monto Máximo ..........."
        Me.lblMontoDetra.Visible = False
        '
        'FrmDocumentoVenta_AdicionarCuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 381)
        Me.Controls.Add(Me.GrdLista)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVenta_AdicionarCuota"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cuotas"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFiltro.ResumeLayout(False)
        Me.FraFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents Panel1 As Panel
    Public WithEvents GrdLista As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents FraFiltro As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtMontoDetra As TextBox
    Friend WithEvents btnCalcDetra As Janus.Windows.EditControls.UIButton
    Public WithEvents txtDetra As TextBox
    Friend WithEvents dtPicker As DateTimePicker
    Public WithEvents txtMonto As TextBox
    Public WithEvents txtNroMonto As TextBox
    Public WithEvents lblMontoDetra As Label
    Public WithEvents lblDetra As Label
    Public WithEvents Label1 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label2 As Label
End Class
