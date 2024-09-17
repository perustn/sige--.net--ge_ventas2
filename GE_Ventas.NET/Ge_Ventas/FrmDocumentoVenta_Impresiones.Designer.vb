<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_Impresiones
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
        Me.DEVANLAY = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FraImpFactura = New System.Windows.Forms.Panel()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.OptFactSun = New Janus.Windows.EditControls.UICheckBox()
        Me.OptFactCli = New Janus.Windows.EditControls.UICheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.FORMACLIENTE = New Janus.Windows.EditControls.UIButton()
        Me.DECLAJURADADVL = New Janus.Windows.EditControls.UIButton()
        Me.DECLAJURADA = New Janus.Windows.EditControls.UIButton()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FraImpFactura.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(248, 28)
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
        'DEVANLAY
        '
        Me.DEVANLAY.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.DEVANLAY.ImageSize = New System.Drawing.Size(32, 32)
        Me.DEVANLAY.Location = New System.Drawing.Point(24, 21)
        Me.DEVANLAY.Name = "DEVANLAY"
        Me.DEVANLAY.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.DEVANLAY.Size = New System.Drawing.Size(199, 24)
        Me.DEVANLAY.TabIndex = 256
        Me.DEVANLAY.Text = "-- &Impresion --"
        Me.DEVANLAY.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.FraImpFactura)
        Me.Panel1.Controls.Add(Me.FORMACLIENTE)
        Me.Panel1.Controls.Add(Me.DECLAJURADADVL)
        Me.Panel1.Controls.Add(Me.DECLAJURADA)
        Me.Panel1.Controls.Add(Me.DEVANLAY)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 288)
        Me.Panel1.TabIndex = 257
        '
        'FraImpFactura
        '
        Me.FraImpFactura.Controls.Add(Me.UiGroupBox1)
        Me.FraImpFactura.Controls.Add(Me.Panel3)
        Me.FraImpFactura.Enabled = False
        Me.FraImpFactura.Location = New System.Drawing.Point(24, 153)
        Me.FraImpFactura.Name = "FraImpFactura"
        Me.FraImpFactura.Size = New System.Drawing.Size(199, 128)
        Me.FraImpFactura.TabIndex = 260
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.OptFactSun)
        Me.UiGroupBox1.Controls.Add(Me.OptFactCli)
        Me.UiGroupBox1.Location = New System.Drawing.Point(17, 5)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(168, 89)
        Me.UiGroupBox1.TabIndex = 256
        Me.UiGroupBox1.Text = "Impresión de Factura"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'OptFactSun
        '
        Me.OptFactSun.AutoSize = True
        Me.OptFactSun.Location = New System.Drawing.Point(31, 56)
        Me.OptFactSun.Name = "OptFactSun"
        Me.OptFactSun.Size = New System.Drawing.Size(88, 17)
        Me.OptFactSun.TabIndex = 1
        Me.OptFactSun.Text = "Factura Sunat"
        '
        'OptFactCli
        '
        Me.OptFactCli.AutoSize = True
        Me.OptFactCli.Location = New System.Drawing.Point(31, 26)
        Me.OptFactCli.Name = "OptFactCli"
        Me.OptFactCli.Size = New System.Drawing.Size(92, 17)
        Me.OptFactCli.TabIndex = 0
        Me.OptFactCli.Text = "Factura Cliente"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 30)
        Me.Panel3.TabIndex = 255
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(125, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(74, 30)
        Me.Panel5.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(66, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FORMACLIENTE
        '
        Me.FORMACLIENTE.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.FORMACLIENTE.ImageSize = New System.Drawing.Size(32, 32)
        Me.FORMACLIENTE.Location = New System.Drawing.Point(24, 111)
        Me.FORMACLIENTE.Name = "FORMACLIENTE"
        Me.FORMACLIENTE.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FORMACLIENTE.Size = New System.Drawing.Size(199, 24)
        Me.FORMACLIENTE.TabIndex = 259
        Me.FORMACLIENTE.Text = "&Formato Cliente"
        Me.FORMACLIENTE.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'DECLAJURADADVL
        '
        Me.DECLAJURADADVL.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.DECLAJURADADVL.ImageSize = New System.Drawing.Size(32, 32)
        Me.DECLAJURADADVL.Location = New System.Drawing.Point(24, 81)
        Me.DECLAJURADADVL.Name = "DECLAJURADADVL"
        Me.DECLAJURADADVL.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.DECLAJURADADVL.Size = New System.Drawing.Size(199, 24)
        Me.DECLAJURADADVL.TabIndex = 258
        Me.DECLAJURADADVL.Text = "&Impression Declaración Jurada DVL"
        Me.DECLAJURADADVL.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'DECLAJURADA
        '
        Me.DECLAJURADA.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.DECLAJURADA.ImageSize = New System.Drawing.Size(32, 32)
        Me.DECLAJURADA.Location = New System.Drawing.Point(24, 51)
        Me.DECLAJURADA.Name = "DECLAJURADA"
        Me.DECLAJURADA.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.DECLAJURADA.Size = New System.Drawing.Size(199, 24)
        Me.DECLAJURADA.TabIndex = 257
        Me.DECLAJURADA.Text = "&Impression Declaración Jurada"
        Me.DECLAJURADA.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_Impresiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 316)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVenta_Impresiones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir Facturas"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FraImpFactura.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents DEVANLAY As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FORMACLIENTE As Janus.Windows.EditControls.UIButton
    Friend WithEvents DECLAJURADADVL As Janus.Windows.EditControls.UIButton
    Friend WithEvents DECLAJURADA As Janus.Windows.EditControls.UIButton
    Friend WithEvents FraImpFactura As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents OptFactSun As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents OptFactCli As Janus.Windows.EditControls.UICheckBox
End Class
