<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact
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
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtEstilo = New System.Windows.Forms.TextBox()
        Me.TxtPO = New System.Windows.Forms.TextBox()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnFactura = New Janus.Windows.EditControls.UIButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.LblTipoCambio = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New Janus.Windows.EditControls.UIButton()
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblEstilo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblPO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCorrelativo = New System.Windows.Forms.Label()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.TxtGuia = New System.Windows.Forms.TextBox()
        Me.TxtGlosaFinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.TxtEstilo)
        Me.Panel4.Controls.Add(Me.TxtPO)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 28)
        Me.Panel4.TabIndex = 258
        '
        'TxtEstilo
        '
        Me.TxtEstilo.AcceptsReturn = True
        Me.TxtEstilo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtEstilo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEstilo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtEstilo.Location = New System.Drawing.Point(352, 4)
        Me.TxtEstilo.MaxLength = 0
        Me.TxtEstilo.Name = "TxtEstilo"
        Me.TxtEstilo.ReadOnly = True
        Me.TxtEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEstilo.Size = New System.Drawing.Size(90, 20)
        Me.TxtEstilo.TabIndex = 125
        '
        'TxtPO
        '
        Me.TxtPO.AcceptsReturn = True
        Me.TxtPO.BackColor = System.Drawing.Color.LightCyan
        Me.TxtPO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPO.Location = New System.Drawing.Point(206, 4)
        Me.TxtPO.MaxLength = 0
        Me.TxtPO.Name = "TxtPO"
        Me.TxtPO.ReadOnly = True
        Me.TxtPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPO.Size = New System.Drawing.Size(90, 20)
        Me.TxtPO.TabIndex = 123
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(69, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(306, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(42, 12)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "ESTILO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(179, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(20, 12)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "PO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(7, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO CORR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnFactura)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 410)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 40)
        Me.Panel2.TabIndex = 259
        '
        'BtnFactura
        '
        Me.BtnFactura.Image = Global.Ge_Ventas.My.Resources.Resources.document_512x512
        Me.BtnFactura.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnFactura.Location = New System.Drawing.Point(12, 5)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnFactura.Size = New System.Drawing.Size(144, 30)
        Me.BtnFactura.TabIndex = 6
        Me.BtnFactura.Text = "Factura Electrónica"
        Me.BtnFactura.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnImprimir)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(644, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 40)
        Me.Panel3.TabIndex = 0
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Ge_Ventas.My.Resources.Resources.ic_excel_down_16x16
        Me.BtnImprimir.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnImprimir.Location = New System.Drawing.Point(3, 5)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnImprimir.Size = New System.Drawing.Size(144, 30)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
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
        Me.GrdDatos.Location = New System.Drawing.Point(0, 28)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(800, 382)
        Me.GrdDatos.TabIndex = 260
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.UiGroupBox1)
        Me.Frame1.Location = New System.Drawing.Point(3, 6)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(794, 437)
        Me.Frame1.TabIndex = 261
        Me.Frame1.Visible = False
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.LblTipoCambio)
        Me.UiGroupBox1.Controls.Add(Me.Label14)
        Me.UiGroupBox1.Controls.Add(Me.BtnCalcular)
        Me.UiGroupBox1.Controls.Add(Me.DTPicker1)
        Me.UiGroupBox1.Controls.Add(Me.Label12)
        Me.UiGroupBox1.Controls.Add(Me.LblEstilo)
        Me.UiGroupBox1.Controls.Add(Me.Label7)
        Me.UiGroupBox1.Controls.Add(Me.LblPO)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.LblCorrelativo)
        Me.UiGroupBox1.Controls.Add(Me.GridEX2)
        Me.UiGroupBox1.Controls.Add(Me.TxtGuia)
        Me.UiGroupBox1.Controls.Add(Me.TxtGlosaFinal)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Panel1)
        Me.UiGroupBox1.Controls.Add(Me.Label8)
        Me.UiGroupBox1.Controls.Add(Me.Label9)
        Me.UiGroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(786, 427)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Emitir Factura Electronica"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'LblTipoCambio
        '
        Me.LblTipoCambio.AutoSize = True
        Me.LblTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoCambio.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTipoCambio.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.LblTipoCambio.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblTipoCambio.Location = New System.Drawing.Point(741, 25)
        Me.LblTipoCambio.Name = "LblTipoCambio"
        Me.LblTipoCambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblTipoCambio.Size = New System.Drawing.Size(17, 12)
        Me.LblTipoCambio.TabIndex = 344
        Me.LblTipoCambio.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(640, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(97, 12)
        Me.Label14.TabIndex = 343
        Me.Label14.Text = "Tipo de Cambio :"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnCalcular.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCalcular.Location = New System.Drawing.Point(541, 13)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCalcular.Size = New System.Drawing.Size(88, 30)
        Me.BtnCalcular.TabIndex = 342
        Me.BtnCalcular.Text = "Calcular x Tipo Cambio"
        Me.BtnCalcular.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'DTPicker1
        '
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker1.Location = New System.Drawing.Point(428, 17)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(107, 20)
        Me.DTPicker1.TabIndex = 341
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(376, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(46, 12)
        Me.Label12.TabIndex = 340
        Me.Label12.Text = "Fecha :"
        '
        'LblEstilo
        '
        Me.LblEstilo.AutoSize = True
        Me.LblEstilo.BackColor = System.Drawing.Color.Transparent
        Me.LblEstilo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEstilo.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.LblEstilo.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblEstilo.Location = New System.Drawing.Point(284, 25)
        Me.LblEstilo.Name = "LblEstilo"
        Me.LblEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEstilo.Size = New System.Drawing.Size(17, 12)
        Me.LblEstilo.TabIndex = 339
        Me.LblEstilo.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(237, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(43, 12)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "Estilo :"
        '
        'LblPO
        '
        Me.LblPO.AutoSize = True
        Me.LblPO.BackColor = System.Drawing.Color.Transparent
        Me.LblPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPO.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.LblPO.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblPO.Location = New System.Drawing.Point(118, 42)
        Me.LblPO.Name = "LblPO"
        Me.LblPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPO.Size = New System.Drawing.Size(17, 12)
        Me.LblPO.TabIndex = 337
        Me.LblPO.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(83, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 336
        Me.Label5.Text = "PO :"
        '
        'LblCorrelativo
        '
        Me.LblCorrelativo.AutoSize = True
        Me.LblCorrelativo.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrelativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCorrelativo.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.LblCorrelativo.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblCorrelativo.Location = New System.Drawing.Point(118, 25)
        Me.LblCorrelativo.Name = "LblCorrelativo"
        Me.LblCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCorrelativo.Size = New System.Drawing.Size(17, 12)
        Me.LblCorrelativo.TabIndex = 335
        Me.LblCorrelativo.Text = "..."
        '
        'GridEX2
        '
        Me.GridEX2.AllowColumnDrag = False
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        Me.GridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX2.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX2_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GridEX2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX2.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX2.Location = New System.Drawing.Point(7, 60)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.Size = New System.Drawing.Size(771, 273)
        Me.GridEX2.TabIndex = 334
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'TxtGuia
        '
        Me.TxtGuia.AcceptsReturn = True
        Me.TxtGuia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGuia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGuia.Enabled = False
        Me.TxtGuia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtGuia.Location = New System.Drawing.Point(668, 338)
        Me.TxtGuia.MaxLength = 25
        Me.TxtGuia.Name = "TxtGuia"
        Me.TxtGuia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGuia.Size = New System.Drawing.Size(109, 20)
        Me.TxtGuia.TabIndex = 333
        '
        'TxtGlosaFinal
        '
        Me.TxtGlosaFinal.AcceptsReturn = True
        Me.TxtGlosaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosaFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosaFinal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtGlosaFinal.Location = New System.Drawing.Point(88, 338)
        Me.TxtGlosaFinal.MaxLength = 25
        Me.TxtGlosaFinal.Multiline = True
        Me.TxtGlosaFinal.Name = "TxtGlosaFinal"
        Me.TxtGlosaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosaFinal.Size = New System.Drawing.Size(471, 52)
        Me.TxtGlosaFinal.TabIndex = 331
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 12)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Correlativo Mov. :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 394)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 30)
        Me.Panel1.TabIndex = 259
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(297, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(483, 30)
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
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(587, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "Guía ...................."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 330
        Me.Label9.Text = "Glosa Final ..............."
        '
        'FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ver Factura CMT"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents TxtEstilo As TextBox
    Public WithEvents TxtPO As TextBox
    Public WithEvents TxtNroCorrelativo As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFactura As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Friend WithEvents Frame1 As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label1 As Label
    Public WithEvents TxtGlosaFinal As TextBox
    Public WithEvents Label9 As Label
    Public WithEvents TxtGuia As TextBox
    Public WithEvents Label8 As Label
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Public WithEvents Label12 As Label
    Public WithEvents LblEstilo As Label
    Public WithEvents Label7 As Label
    Public WithEvents LblPO As Label
    Public WithEvents Label5 As Label
    Public WithEvents LblCorrelativo As Label
    Public WithEvents LblTipoCambio As Label
    Public WithEvents Label14 As Label
    Friend WithEvents BtnCalcular As Janus.Windows.EditControls.UIButton
    Friend WithEvents DTPicker1 As DateTimePicker
End Class
