<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_AgruparFacturas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FraFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNom_Organizacion = New System.Windows.Forms.TextBox()
        Me.txtCod_Organizacion = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.FraFactura = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelarFactura = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptarFactura = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFacturaAgrupada = New System.Windows.Forms.TextBox()
        Me.txtSerieAgrupada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFiltro.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FraFactura.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.FraFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 58)
        Me.Panel1.TabIndex = 239
        '
        'FraFiltro
        '
        Me.FraFiltro.Controls.Add(Me.dtpFecha)
        Me.FraFiltro.Controls.Add(Me.txtNom_Organizacion)
        Me.FraFiltro.Controls.Add(Me.txtCod_Organizacion)
        Me.FraFiltro.Controls.Add(Me.BtnBuscar)
        Me.FraFiltro.Controls.Add(Me.Label7)
        Me.FraFiltro.Controls.Add(Me.Label13)
        Me.FraFiltro.Location = New System.Drawing.Point(6, 3)
        Me.FraFiltro.Name = "FraFiltro"
        Me.FraFiltro.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraFiltro.Size = New System.Drawing.Size(779, 49)
        Me.FraFiltro.TabIndex = 102
        Me.FraFiltro.Text = "Filtro de Búsqueda"
        Me.FraFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(514, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecha.TabIndex = 106
        '
        'txtNom_Organizacion
        '
        Me.txtNom_Organizacion.AcceptsReturn = True
        Me.txtNom_Organizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtNom_Organizacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom_Organizacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNom_Organizacion.Location = New System.Drawing.Point(171, 19)
        Me.txtNom_Organizacion.MaxLength = 100
        Me.txtNom_Organizacion.Name = "txtNom_Organizacion"
        Me.txtNom_Organizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNom_Organizacion.Size = New System.Drawing.Size(242, 20)
        Me.txtNom_Organizacion.TabIndex = 104
        '
        'txtCod_Organizacion
        '
        Me.txtCod_Organizacion.AcceptsReturn = True
        Me.txtCod_Organizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Organizacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Organizacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Organizacion.Location = New System.Drawing.Point(119, 19)
        Me.txtCod_Organizacion.MaxLength = 100
        Me.txtCod_Organizacion.Name = "txtCod_Organizacion"
        Me.txtCod_Organizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Organizacion.Size = New System.Drawing.Size(50, 20)
        Me.txtCod_Organizacion.TabIndex = 99
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.Location = New System.Drawing.Point(653, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(118, 30)
        Me.BtnBuscar.TabIndex = 102
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(24, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Organización ..............."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(444, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(112, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Fecha ........................"
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowColumnDrag = False
        Me.GrdDatos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdDatos.AlternatingColors = True
        Me.GrdDatos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GrdDatos.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdDatos_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GrdDatos.DesignTimeLayout = GrdDatos_DesignTimeLayout
        Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdDatos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDatos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdDatos.GroupByBoxVisible = False
        Me.GrdDatos.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDatos.Location = New System.Drawing.Point(0, 58)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(789, 347)
        Me.GrdDatos.TabIndex = 250
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 405)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 30)
        Me.Panel2.TabIndex = 249
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(269, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 30)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(147, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(141, 24)
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
        Me.BtnAceptar.Size = New System.Drawing.Size(141, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Agrupar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FraFactura
        '
        Me.FraFactura.BackColor = System.Drawing.Color.White
        Me.FraFactura.Controls.Add(Me.Panel4)
        Me.FraFactura.Controls.Add(Me.UiGroupBox1)
        Me.FraFactura.Location = New System.Drawing.Point(192, 128)
        Me.FraFactura.Name = "FraFactura"
        Me.FraFactura.Size = New System.Drawing.Size(370, 103)
        Me.FraFactura.TabIndex = 251
        Me.FraFactura.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 73)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(370, 30)
        Me.Panel4.TabIndex = 251
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelarFactura)
        Me.Panel5.Controls.Add(Me.BtnAceptarFactura)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(163, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(207, 30)
        Me.Panel5.TabIndex = 0
        '
        'BtnCancelarFactura
        '
        Me.BtnCancelarFactura.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelarFactura.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelarFactura.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelarFactura.Name = "BtnCancelarFactura"
        Me.BtnCancelarFactura.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelarFactura.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelarFactura.TabIndex = 6
        Me.BtnCancelarFactura.Text = "&Cancelar"
        Me.BtnCancelarFactura.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptarFactura
        '
        Me.BtnAceptarFactura.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptarFactura.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptarFactura.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptarFactura.Name = "BtnAceptarFactura"
        Me.BtnAceptarFactura.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptarFactura.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptarFactura.TabIndex = 5
        Me.BtnAceptarFactura.Text = "&Aceptar"
        Me.BtnAceptarFactura.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.txtFacturaAgrupada)
        Me.UiGroupBox1.Controls.Add(Me.txtSerieAgrupada)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(356, 63)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Factura Agrupada"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtFacturaAgrupada
        '
        Me.txtFacturaAgrupada.AcceptsReturn = True
        Me.txtFacturaAgrupada.BackColor = System.Drawing.SystemColors.Window
        Me.txtFacturaAgrupada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFacturaAgrupada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFacturaAgrupada.Location = New System.Drawing.Point(156, 25)
        Me.txtFacturaAgrupada.MaxLength = 100
        Me.txtFacturaAgrupada.Name = "txtFacturaAgrupada"
        Me.txtFacturaAgrupada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFacturaAgrupada.Size = New System.Drawing.Size(182, 20)
        Me.txtFacturaAgrupada.TabIndex = 107
        '
        'txtSerieAgrupada
        '
        Me.txtSerieAgrupada.AcceptsReturn = True
        Me.txtSerieAgrupada.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerieAgrupada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerieAgrupada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSerieAgrupada.Location = New System.Drawing.Point(104, 25)
        Me.txtSerieAgrupada.MaxLength = 100
        Me.txtSerieAgrupada.Name = "txtSerieAgrupada"
        Me.txtSerieAgrupada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerieAgrupada.Size = New System.Drawing.Size(50, 20)
        Me.txtSerieAgrupada.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "# Factura ..............."
        '
        'FrmDocumentoVentaExportacion_AgruparFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 435)
        Me.Controls.Add(Me.FraFactura)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVentaExportacion_AgruparFacturas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agrupar de Facturas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFiltro.ResumeLayout(False)
        Me.FraFiltro.PerformLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.FraFactura.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FraFiltro As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtNom_Organizacion As System.Windows.Forms.TextBox
    Public WithEvents txtCod_Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FraFactura As System.Windows.Forms.Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtFacturaAgrupada As System.Windows.Forms.TextBox
    Public WithEvents txtSerieAgrupada As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarFactura As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptarFactura As Janus.Windows.EditControls.UIButton
End Class
