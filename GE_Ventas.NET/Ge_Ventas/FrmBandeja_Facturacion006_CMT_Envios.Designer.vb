<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBandeja_Facturacion006_CMT_Envios
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNro_Doc = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.LblEstilo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblPO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCorrelativo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGuia = New System.Windows.Forms.TextBox()
        Me.TxtGlosaFinal = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 42)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(807, 335)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNro_Doc)
        Me.Panel1.Controls.Add(Me.txtSerie)
        Me.Panel1.Controls.Add(Me.LblEstilo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LblPO)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblCorrelativo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 42)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(123, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "Nro. Doc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Serie"
        '
        'txtNro_Doc
        '
        Me.txtNro_Doc.Enabled = False
        Me.txtNro_Doc.Location = New System.Drawing.Point(190, 10)
        Me.txtNro_Doc.Name = "txtNro_Doc"
        Me.txtNro_Doc.Size = New System.Drawing.Size(83, 20)
        Me.txtNro_Doc.TabIndex = 347
        Me.txtNro_Doc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Location = New System.Drawing.Point(54, 10)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(50, 20)
        Me.txtSerie.TabIndex = 346
        Me.txtSerie.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'LblEstilo
        '
        Me.LblEstilo.AutoSize = True
        Me.LblEstilo.BackColor = System.Drawing.Color.Transparent
        Me.LblEstilo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEstilo.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.LblEstilo.ForeColor = System.Drawing.Color.Gold
        Me.LblEstilo.Location = New System.Drawing.Point(653, 6)
        Me.LblEstilo.Name = "LblEstilo"
        Me.LblEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEstilo.Size = New System.Drawing.Size(19, 14)
        Me.LblEstilo.TabIndex = 345
        Me.LblEstilo.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(597, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 344
        Me.Label7.Text = "Estilo :"
        '
        'LblPO
        '
        Me.LblPO.AutoSize = True
        Me.LblPO.BackColor = System.Drawing.Color.Transparent
        Me.LblPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPO.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.LblPO.ForeColor = System.Drawing.Color.Gold
        Me.LblPO.Location = New System.Drawing.Point(450, 23)
        Me.LblPO.Name = "LblPO"
        Me.LblPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPO.Size = New System.Drawing.Size(19, 14)
        Me.LblPO.TabIndex = 343
        Me.LblPO.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(400, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 342
        Me.Label5.Text = "PO :"
        '
        'LblCorrelativo
        '
        Me.LblCorrelativo.AutoSize = True
        Me.LblCorrelativo.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrelativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCorrelativo.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.LblCorrelativo.ForeColor = System.Drawing.Color.Gold
        Me.LblCorrelativo.Location = New System.Drawing.Point(450, 6)
        Me.LblCorrelativo.Name = "LblCorrelativo"
        Me.LblCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCorrelativo.Size = New System.Drawing.Size(19, 14)
        Me.LblCorrelativo.TabIndex = 341
        Me.LblCorrelativo.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(324, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(125, 14)
        Me.Label1.TabIndex = 340
        Me.Label1.Text = "Correlativo Mov. :"
        '
        'TxtGuia
        '
        Me.TxtGuia.AcceptsReturn = True
        Me.TxtGuia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGuia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGuia.Enabled = False
        Me.TxtGuia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtGuia.Location = New System.Drawing.Point(667, 14)
        Me.TxtGuia.MaxLength = 25
        Me.TxtGuia.Name = "TxtGuia"
        Me.TxtGuia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGuia.Size = New System.Drawing.Size(109, 20)
        Me.TxtGuia.TabIndex = 338
        '
        'TxtGlosaFinal
        '
        Me.TxtGlosaFinal.AcceptsReturn = True
        Me.TxtGlosaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosaFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosaFinal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtGlosaFinal.Location = New System.Drawing.Point(87, 14)
        Me.TxtGlosaFinal.MaxLength = 25
        Me.TxtGlosaFinal.Multiline = True
        Me.TxtGlosaFinal.Name = "TxtGlosaFinal"
        Me.TxtGlosaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosaFinal.Size = New System.Drawing.Size(471, 52)
        Me.TxtGlosaFinal.TabIndex = 336
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 461)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(807, 30)
        Me.Panel2.TabIndex = 334
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(324, 0)
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
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(586, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "Guía .............."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(5, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 335
        Me.Label9.Text = "Glosa Final ....."
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.TxtGlosaFinal)
        Me.UiGroupBox1.Controls.Add(Me.TxtGuia)
        Me.UiGroupBox1.Controls.Add(Me.Label9)
        Me.UiGroupBox1.Controls.Add(Me.Label8)
        Me.UiGroupBox1.Location = New System.Drawing.Point(7, 383)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(792, 72)
        Me.UiGroupBox1.TabIndex = 339
        Me.UiGroupBox1.Text = "Datos Generales"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'FrmBandeja_Facturacion006_CMT_Envios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 491)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmBandeja_Facturacion006_CMT_Envios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bandeja Envios Facturacion 006"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As Panel
    Public WithEvents TxtGuia As TextBox
    Public WithEvents TxtGlosaFinal As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label8 As Label
    Public WithEvents Label9 As Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents LblEstilo As Label
    Public WithEvents Label7 As Label
    Public WithEvents LblPO As Label
    Public WithEvents Label5 As Label
    Public WithEvents LblCorrelativo As Label
    Public WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNro_Doc As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.EditBox
End Class
