<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_EventoComprometido
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
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FraArchivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.DtpHoraECR = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFec_ECR = New System.Windows.Forms.MaskedTextBox()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.FraArchivos = New Janus.Windows.EditControls.UIGroupBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.BtnGrabar = New Janus.Windows.EditControls.UIButton()
        Me.BtnArchivos = New Janus.Windows.EditControls.UIButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.FraArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraArchivo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FraArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraArchivos.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(687, 27)
        Me.Panel4.TabIndex = 242
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 468)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 30)
        Me.Panel2.TabIndex = 243
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnGrabar)
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnArchivos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(334, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 30)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(245, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cerrar"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(284, 12)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "REGISTRO EVENTO COMPROMETIDO REAL - ARCHIVOS "
        '
        'FraArchivo
        '
        Me.FraArchivo.Controls.Add(Me.TxtRutaArchivo)
        Me.FraArchivo.Controls.Add(Me.Label7)
        Me.FraArchivo.Location = New System.Drawing.Point(5, 296)
        Me.FraArchivo.Name = "FraArchivo"
        Me.FraArchivo.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraArchivo.Size = New System.Drawing.Size(675, 54)
        Me.FraArchivo.TabIndex = 244
        Me.FraArchivo.Text = "Archivo Seleccionado"
        Me.FraArchivo.Visible = False
        Me.FraArchivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'DtpHoraECR
        '
        Me.DtpHoraECR.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraECR.Location = New System.Drawing.Point(521, 10)
        Me.DtpHoraECR.Name = "DtpHoraECR"
        Me.DtpHoraECR.Size = New System.Drawing.Size(107, 20)
        Me.DtpHoraECR.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(450, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Hora ......................"
        '
        'TxtRutaArchivo
        '
        Me.TxtRutaArchivo.AcceptsReturn = True
        Me.TxtRutaArchivo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRutaArchivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRutaArchivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtRutaArchivo.Location = New System.Drawing.Point(113, 21)
        Me.TxtRutaArchivo.MaxLength = 100
        Me.TxtRutaArchivo.Name = "TxtRutaArchivo"
        Me.TxtRutaArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRutaArchivo.Size = New System.Drawing.Size(527, 20)
        Me.TxtRutaArchivo.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(43, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Ruta ................."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.FraArchivo)
        Me.Panel1.Controls.Add(Me.FraArchivos)
        Me.Panel1.Controls.Add(Me.UiGroupBox1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 441)
        Me.Panel1.TabIndex = 245
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DtpHoraECR)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtFec_ECR)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(5, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(675, 43)
        Me.Panel5.TabIndex = 245
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(274, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Fecha Evento Comprometido Real (DD/MM/YYYY) ......."
        '
        'txtFec_ECR
        '
        Me.txtFec_ECR.Location = New System.Drawing.Point(305, 10)
        Me.txtFec_ECR.Mask = "00/00/0000"
        Me.txtFec_ECR.Name = "txtFec_ECR"
        Me.txtFec_ECR.Size = New System.Drawing.Size(95, 20)
        Me.txtFec_ECR.TabIndex = 298
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.GridEX2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(5, 51)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(675, 217)
        Me.UiGroupBox1.TabIndex = 246
        Me.UiGroupBox1.Text = "Lista de Facturas Seleccionadas"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'GridEX2
        '
        Me.GridEX2.AllowColumnDrag = False
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        Me.GridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX2.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX2_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GridEX2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX2.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX2.Location = New System.Drawing.Point(3, 16)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.Size = New System.Drawing.Size(669, 198)
        Me.GridEX2.TabIndex = 251
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FraArchivos
        '
        Me.FraArchivos.Controls.Add(Me.GridEX1)
        Me.FraArchivos.Location = New System.Drawing.Point(5, 271)
        Me.FraArchivos.Name = "FraArchivos"
        Me.FraArchivos.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraArchivos.Size = New System.Drawing.Size(675, 166)
        Me.FraArchivos.TabIndex = 247
        Me.FraArchivos.Text = "Lista de Archivos Adjuntos"
        Me.FraArchivos.Visible = False
        Me.FraArchivos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'GridEX1
        '
        Me.GridEX1.AllowColumnDrag = False
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX1.Location = New System.Drawing.Point(3, 16)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(669, 147)
        Me.GridEX1.TabIndex = 251
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.Ge_Ventas.My.Resources.Resources.save_16x16
        Me.BtnGrabar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnGrabar.Location = New System.Drawing.Point(139, 3)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnGrabar.Size = New System.Drawing.Size(98, 24)
        Me.BtnGrabar.TabIndex = 7
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnArchivos
        '
        Me.BtnArchivos.Image = Global.Ge_Ventas.My.Resources.Resources.ic_warehouse_up_48x48
        Me.BtnArchivos.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnArchivos.Location = New System.Drawing.Point(3, 3)
        Me.BtnArchivos.Name = "BtnArchivos"
        Me.BtnArchivos.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnArchivos.Size = New System.Drawing.Size(129, 24)
        Me.BtnArchivos.TabIndex = 5
        Me.BtnArchivos.Text = "Cargar Archivos"
        Me.BtnArchivos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmDocumentoVentaExportacion_EventoComprometido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVentaExportacion_EventoComprometido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.FraArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraArchivo.ResumeLayout(False)
        Me.FraArchivo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FraArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraArchivos.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnArchivos As Janus.Windows.EditControls.UIButton
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FraArchivo As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtRutaArchivo As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpHoraECR As System.Windows.Forms.DateTimePicker
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents txtFec_ECR As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents FraArchivos As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnGrabar As Janus.Windows.EditControls.UIButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
