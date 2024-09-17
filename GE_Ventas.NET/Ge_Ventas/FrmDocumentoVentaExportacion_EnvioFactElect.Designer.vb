<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_EnvioFactElect
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblCorrelativoFact = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtGuia = New System.Windows.Forms.TextBox()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtGlosa3 = New System.Windows.Forms.TextBox()
        Me.TxtGlosa2 = New System.Windows.Forms.TextBox()
        Me.TxtGlosa1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.LblCorrelativoFact)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtFecha)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtFactura)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 28)
        Me.Panel4.TabIndex = 243
        '
        'LblCorrelativoFact
        '
        Me.LblCorrelativoFact.AutoSize = True
        Me.LblCorrelativoFact.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrelativoFact.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCorrelativoFact.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblCorrelativoFact.ForeColor = System.Drawing.Color.Red
        Me.LblCorrelativoFact.Location = New System.Drawing.Point(668, 6)
        Me.LblCorrelativoFact.Name = "LblCorrelativoFact"
        Me.LblCorrelativoFact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCorrelativoFact.Size = New System.Drawing.Size(23, 17)
        Me.LblCorrelativoFact.TabIndex = 128
        Me.LblCorrelativoFact.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(466, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(38, 12)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "FECHA"
        '
        'TxtFecha
        '
        Me.TxtFecha.AcceptsReturn = True
        Me.TxtFecha.BackColor = System.Drawing.Color.LightCyan
        Me.TxtFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFecha.Location = New System.Drawing.Point(510, 4)
        Me.TxtFecha.MaxLength = 0
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFecha.Size = New System.Drawing.Size(101, 20)
        Me.TxtFecha.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(256, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "FACTURA"
        '
        'TxtFactura
        '
        Me.TxtFactura.AcceptsReturn = True
        Me.TxtFactura.BackColor = System.Drawing.Color.LightCyan
        Me.TxtFactura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFactura.Location = New System.Drawing.Point(315, 4)
        Me.TxtFactura.MaxLength = 0
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.ReadOnly = True
        Me.TxtFactura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFactura.Size = New System.Drawing.Size(117, 20)
        Me.TxtFactura.TabIndex = 123
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
        Me.TxtNroCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(119, 4)
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
        Me.Panel1.Controls.Add(Me.TxtGuia)
        Me.Panel1.Controls.Add(Me.TxtPeso)
        Me.Panel1.Controls.Add(Me.TxtGlosa3)
        Me.Panel1.Controls.Add(Me.TxtGlosa2)
        Me.Panel1.Controls.Add(Me.TxtGlosa1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 111)
        Me.Panel1.TabIndex = 244
        '
        'TxtGuia
        '
        Me.TxtGuia.AcceptsReturn = True
        Me.TxtGuia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGuia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGuia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtGuia.Location = New System.Drawing.Point(838, 23)
        Me.TxtGuia.MaxLength = 0
        Me.TxtGuia.Multiline = True
        Me.TxtGuia.Name = "TxtGuia"
        Me.TxtGuia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGuia.Size = New System.Drawing.Size(74, 32)
        Me.TxtGuia.TabIndex = 130
        '
        'TxtPeso
        '
        Me.TxtPeso.AcceptsReturn = True
        Me.TxtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPeso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPeso.Location = New System.Drawing.Point(755, 23)
        Me.TxtPeso.MaxLength = 0
        Me.TxtPeso.Multiline = True
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPeso.Size = New System.Drawing.Size(74, 32)
        Me.TxtPeso.TabIndex = 128
        Me.TxtPeso.Text = "^^PESO: "
        '
        'TxtGlosa3
        '
        Me.TxtGlosa3.AcceptsReturn = True
        Me.TxtGlosa3.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosa3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosa3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtGlosa3.Location = New System.Drawing.Point(6, 76)
        Me.TxtGlosa3.MaxLength = 0
        Me.TxtGlosa3.Multiline = True
        Me.TxtGlosa3.Name = "TxtGlosa3"
        Me.TxtGlosa3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosa3.Size = New System.Drawing.Size(906, 32)
        Me.TxtGlosa3.TabIndex = 126
        Me.TxtGlosa3.Text = "^^DESCRIPCION CONTIENE : OF./ESTILO/TEMPORADA/COLOR/DESCRIPCION PRENDA"
        '
        'TxtGlosa2
        '
        Me.TxtGlosa2.AcceptsReturn = True
        Me.TxtGlosa2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosa2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosa2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtGlosa2.Location = New System.Drawing.Point(380, 23)
        Me.TxtGlosa2.MaxLength = 0
        Me.TxtGlosa2.Multiline = True
        Me.TxtGlosa2.Name = "TxtGlosa2"
        Me.TxtGlosa2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosa2.Size = New System.Drawing.Size(366, 32)
        Me.TxtGlosa2.TabIndex = 124
        Me.TxtGlosa2.Text = "^^PRENDAS DE PRIMERA CALIDAD"
        '
        'TxtGlosa1
        '
        Me.TxtGlosa1.AcceptsReturn = True
        Me.TxtGlosa1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosa1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosa1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtGlosa1.Location = New System.Drawing.Point(6, 23)
        Me.TxtGlosa1.MaxLength = 0
        Me.TxtGlosa1.Multiline = True
        Me.TxtGlosa1.Name = "TxtGlosa1"
        Me.TxtGlosa1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosa1.Size = New System.Drawing.Size(366, 32)
        Me.TxtGlosa1.TabIndex = 122
        Me.TxtGlosa1.Text = "^^^SERVICIO DE FABRICACION POR ENCARGO SEGUN CONTRATO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.4!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(838, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(30, 12)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Guía"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.4!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(755, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(33, 12)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Peso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.4!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(105, 12)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Glosa Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.4!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(380, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(80, 12)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Glosa Calidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.4!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 12)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Glosa Principal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 506)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 35)
        Me.Panel2.TabIndex = 245
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(357, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(563, 35)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(117, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 29)
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
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 29)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
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
        Me.GrdDatos.Location = New System.Drawing.Point(0, 139)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(920, 367)
        Me.GrdDatos.TabIndex = 247
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmDocumentoVentaExportacion_EnvioFactElect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 541)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVentaExportacion_EnvioFactElect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos para Factura Electrónica"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label1 As Label
    Public WithEvents TxtFactura As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Public WithEvents Label2 As Label
    Public WithEvents TxtFecha As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents TxtPeso As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents TxtGlosa3 As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents TxtGlosa2 As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents TxtGlosa1 As TextBox
    Public WithEvents TxtGuia As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents LblCorrelativoFact As Label
End Class
