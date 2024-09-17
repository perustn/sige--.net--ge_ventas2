<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_CopiaDatosFactura
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSerFactDst = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSerieOrigen = New System.Windows.Forms.TextBox()
        Me.txtNumFactDst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDocumentoOrigen = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtNumFactDst)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSerFactDst)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 55)
        Me.Panel1.TabIndex = 246
        '
        'txtSerFactDst
        '
        Me.txtSerFactDst.AcceptsReturn = True
        Me.txtSerFactDst.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerFactDst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerFactDst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSerFactDst.Location = New System.Drawing.Point(142, 17)
        Me.txtSerFactDst.MaxLength = 100
        Me.txtSerFactDst.Name = "txtSerFactDst"
        Me.txtSerFactDst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerFactDst.Size = New System.Drawing.Size(57, 20)
        Me.txtSerFactDst.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(42, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(136, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Serie Factura ....................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 30)
        Me.Panel2.TabIndex = 245
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(273, 0)
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtDocumentoOrigen)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtSerieOrigen)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(480, 27)
        Me.Panel4.TabIndex = 244
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(78, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "SERIE ORIGEN"
        '
        'TxtSerieOrigen
        '
        Me.TxtSerieOrigen.AcceptsReturn = True
        Me.TxtSerieOrigen.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSerieOrigen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSerieOrigen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSerieOrigen.Location = New System.Drawing.Point(94, 3)
        Me.TxtSerieOrigen.MaxLength = 0
        Me.TxtSerieOrigen.Name = "TxtSerieOrigen"
        Me.TxtSerieOrigen.ReadOnly = True
        Me.TxtSerieOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSerieOrigen.Size = New System.Drawing.Size(57, 20)
        Me.TxtSerieOrigen.TabIndex = 121
        '
        'txtNumFactDst
        '
        Me.txtNumFactDst.AcceptsReturn = True
        Me.txtNumFactDst.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumFactDst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumFactDst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumFactDst.Location = New System.Drawing.Point(335, 17)
        Me.txtNumFactDst.MaxLength = 100
        Me.txtNumFactDst.Name = "txtNumFactDst"
        Me.txtNumFactDst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumFactDst.Size = New System.Drawing.Size(105, 20)
        Me.txtNumFactDst.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(231, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Número Factura .............."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(170, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(111, 12)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "DOCUMENTO ORIGEN"
        '
        'TxtDocumentoOrigen
        '
        Me.TxtDocumentoOrigen.AcceptsReturn = True
        Me.TxtDocumentoOrigen.BackColor = System.Drawing.Color.LightCyan
        Me.TxtDocumentoOrigen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDocumentoOrigen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDocumentoOrigen.Location = New System.Drawing.Point(289, 3)
        Me.TxtDocumentoOrigen.MaxLength = 0
        Me.TxtDocumentoOrigen.Name = "TxtDocumentoOrigen"
        Me.TxtDocumentoOrigen.ReadOnly = True
        Me.TxtDocumentoOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDocumentoOrigen.Size = New System.Drawing.Size(126, 20)
        Me.TxtDocumentoOrigen.TabIndex = 123
        '
        'FrmDocumentoVentaExportacion_CopiaDatosFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVentaExportacion_CopiaDatosFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copia Datos desde Factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents txtSerFactDst As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtSerieOrigen As System.Windows.Forms.TextBox
    Public WithEvents txtNumFactDst As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtDocumentoOrigen As System.Windows.Forms.TextBox
End Class
