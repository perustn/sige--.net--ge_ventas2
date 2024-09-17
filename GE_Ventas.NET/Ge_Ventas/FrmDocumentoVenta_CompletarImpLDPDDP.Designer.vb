<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_CompletarImpLDPDDP
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLdp = New System.Windows.Forms.TextBox()
        Me.txtCif = New System.Windows.Forms.TextBox()
        Me.txtFob = New System.Windows.Forms.TextBox()
        Me.txtTransporte = New System.Windows.Forms.TextBox()
        Me.txtDesaduanaje = New System.Windows.Forms.TextBox()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDdp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(296, 28)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 234)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 30)
        Me.Panel2.TabIndex = 256
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(89, 0)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtDdp)
        Me.Panel1.Controls.Add(Me.txtLdp)
        Me.Panel1.Controls.Add(Me.txtCif)
        Me.Panel1.Controls.Add(Me.txtFob)
        Me.Panel1.Controls.Add(Me.txtTransporte)
        Me.Panel1.Controls.Add(Me.txtDesaduanaje)
        Me.Panel1.Controls.Add(Me.txtFlete)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 206)
        Me.Panel1.TabIndex = 261
        '
        'txtLdp
        '
        Me.txtLdp.AcceptsReturn = True
        Me.txtLdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtLdp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLdp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLdp.Location = New System.Drawing.Point(178, 144)
        Me.txtLdp.MaxLength = 25
        Me.txtLdp.Name = "txtLdp"
        Me.txtLdp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLdp.Size = New System.Drawing.Size(88, 20)
        Me.txtLdp.TabIndex = 335
        '
        'txtCif
        '
        Me.txtCif.AcceptsReturn = True
        Me.txtCif.BackColor = System.Drawing.SystemColors.Window
        Me.txtCif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCif.Location = New System.Drawing.Point(178, 118)
        Me.txtCif.MaxLength = 25
        Me.txtCif.Name = "txtCif"
        Me.txtCif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCif.Size = New System.Drawing.Size(88, 20)
        Me.txtCif.TabIndex = 333
        '
        'txtFob
        '
        Me.txtFob.AcceptsReturn = True
        Me.txtFob.BackColor = System.Drawing.SystemColors.Window
        Me.txtFob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFob.Location = New System.Drawing.Point(178, 92)
        Me.txtFob.MaxLength = 25
        Me.txtFob.Name = "txtFob"
        Me.txtFob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFob.Size = New System.Drawing.Size(88, 20)
        Me.txtFob.TabIndex = 331
        '
        'txtTransporte
        '
        Me.txtTransporte.AcceptsReturn = True
        Me.txtTransporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtTransporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTransporte.Location = New System.Drawing.Point(178, 66)
        Me.txtTransporte.MaxLength = 25
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTransporte.Size = New System.Drawing.Size(88, 20)
        Me.txtTransporte.TabIndex = 329
        '
        'txtDesaduanaje
        '
        Me.txtDesaduanaje.AcceptsReturn = True
        Me.txtDesaduanaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesaduanaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesaduanaje.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDesaduanaje.Location = New System.Drawing.Point(178, 40)
        Me.txtDesaduanaje.MaxLength = 25
        Me.txtDesaduanaje.Name = "txtDesaduanaje"
        Me.txtDesaduanaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesaduanaje.Size = New System.Drawing.Size(88, 20)
        Me.txtDesaduanaje.TabIndex = 327
        '
        'txtFlete
        '
        Me.txtFlete.AcceptsReturn = True
        Me.txtFlete.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlete.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFlete.Location = New System.Drawing.Point(178, 14)
        Me.txtFlete.MaxLength = 25
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlete.Size = New System.Drawing.Size(88, 20)
        Me.txtFlete.TabIndex = 325
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(27, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(162, 13)
        Me.Label7.TabIndex = 334
        Me.Label7.Text = "Importe LDP ..............................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(27, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(160, 13)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Importe CIF ................................"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(27, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(159, 13)
        Me.Label6.TabIndex = 330
        Me.Label6.Text = "Importe FOB .............................."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(27, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Transporte en País Destino ......."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(27, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 326
        Me.Label2.Text = "Desaduanaje ..............................."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 324
        Me.Label1.Text = "Flete ............................................"
        '
        'txtDdp
        '
        Me.txtDdp.AcceptsReturn = True
        Me.txtDdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtDdp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDdp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDdp.Location = New System.Drawing.Point(178, 170)
        Me.txtDdp.MaxLength = 25
        Me.txtDdp.Name = "txtDdp"
        Me.txtDdp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDdp.Size = New System.Drawing.Size(88, 20)
        Me.txtDdp.TabIndex = 337
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(27, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 336
        Me.Label8.Text = "Importe DDP .............................."
        '
        'FrmDocumentoVenta_CompletarImpLDPDDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_CompletarImpLDPDDP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Completar Importes LDP / DDP"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As Panel
    Public WithEvents txtDdp As TextBox
    Public WithEvents txtLdp As TextBox
    Public WithEvents txtCif As TextBox
    Public WithEvents txtFob As TextBox
    Public WithEvents txtTransporte As TextBox
    Public WithEvents txtDesaduanaje As TextBox
    Public WithEvents txtFlete As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
End Class
