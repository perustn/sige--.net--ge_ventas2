<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_OtrosGastos_Mant
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
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.TxtSec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDes_TipConp = New System.Windows.Forms.TextBox()
        Me.txtCod_TipConp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.LabelSec)
        Me.Panel4.Controls.Add(Me.TxtSec)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(519, 28)
        Me.Panel4.TabIndex = 246
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.BackColor = System.Drawing.Color.Transparent
        Me.LabelSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSec.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSec.ForeColor = System.Drawing.Color.Gold
        Me.LabelSec.Location = New System.Drawing.Point(251, 8)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSec.Size = New System.Drawing.Size(23, 12)
        Me.LabelSec.TabIndex = 122
        Me.LabelSec.Text = "SEC"
        '
        'TxtSec
        '
        Me.TxtSec.AcceptsReturn = True
        Me.TxtSec.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSec.Location = New System.Drawing.Point(280, 4)
        Me.TxtSec.MaxLength = 0
        Me.TxtSec.Name = "TxtSec"
        Me.TxtSec.ReadOnly = True
        Me.TxtSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSec.Size = New System.Drawing.Size(36, 20)
        Me.TxtSec.TabIndex = 123
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
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 4)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 30)
        Me.Panel2.TabIndex = 248
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(312, 0)
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
        Me.Panel1.Controls.Add(Me.txtImporte)
        Me.Panel1.Controls.Add(Me.txtConcepto)
        Me.Panel1.Controls.Add(Me.txtDes_TipConp)
        Me.Panel1.Controls.Add(Me.txtCod_TipConp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 104)
        Me.Panel1.TabIndex = 249
        '
        'txtDes_TipConp
        '
        Me.txtDes_TipConp.AcceptsReturn = True
        Me.txtDes_TipConp.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_TipConp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_TipConp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_TipConp.Location = New System.Drawing.Point(214, 16)
        Me.txtDes_TipConp.MaxLength = 100
        Me.txtDes_TipConp.Name = "txtDes_TipConp"
        Me.txtDes_TipConp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_TipConp.Size = New System.Drawing.Size(277, 20)
        Me.txtDes_TipConp.TabIndex = 97
        '
        'txtCod_TipConp
        '
        Me.txtCod_TipConp.AcceptsReturn = True
        Me.txtCod_TipConp.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_TipConp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_TipConp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_TipConp.Location = New System.Drawing.Point(147, 16)
        Me.txtCod_TipConp.MaxLength = 100
        Me.txtCod_TipConp.Name = "txtCod_TipConp"
        Me.txtCod_TipConp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_TipConp.Size = New System.Drawing.Size(65, 20)
        Me.txtCod_TipConp.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(36, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(140, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Tipo Concepto ...................."
        '
        'txtConcepto
        '
        Me.txtConcepto.AcceptsReturn = True
        Me.txtConcepto.BackColor = System.Drawing.SystemColors.Window
        Me.txtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConcepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtConcepto.Location = New System.Drawing.Point(147, 42)
        Me.txtConcepto.MaxLength = 100
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConcepto.Size = New System.Drawing.Size(344, 20)
        Me.txtConcepto.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(36, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Concepto ....................."
        '
        'txtImporte
        '
        Me.txtImporte.AcceptsReturn = True
        Me.txtImporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImporte.Location = New System.Drawing.Point(147, 68)
        Me.txtImporte.MaxLength = 100
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImporte.Size = New System.Drawing.Size(65, 20)
        Me.txtImporte.TabIndex = 101
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(36, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Importe ......................."
        '
        'FrmDocumentoVentaExportacion_OtrosGastos_Mant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVentaExportacion_OtrosGastos_Mant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Otros Gastos / Descuentos"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents LabelSec As System.Windows.Forms.Label
    Public WithEvents TxtSec As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents txtImporte As System.Windows.Forms.TextBox
    Public WithEvents txtConcepto As System.Windows.Forms.TextBox
    Public WithEvents txtDes_TipConp As System.Windows.Forms.TextBox
    Public WithEvents txtCod_TipConp As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
End Class
