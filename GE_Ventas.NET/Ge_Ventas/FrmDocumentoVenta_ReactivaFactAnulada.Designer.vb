<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_ReactivaFactAnulada
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
        Me.txtNum_Docum2 = New System.Windows.Forms.TextBox()
        Me.txtSer_Docum2 = New System.Windows.Forms.TextBox()
        Me.txtCod_TipDoc2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtNum_Docum2)
        Me.Panel1.Controls.Add(Me.txtSer_Docum2)
        Me.Panel1.Controls.Add(Me.txtCod_TipDoc2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 100)
        Me.Panel1.TabIndex = 256
        '
        'txtNum_Docum2
        '
        Me.txtNum_Docum2.AcceptsReturn = True
        Me.txtNum_Docum2.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Docum2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Docum2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNum_Docum2.Location = New System.Drawing.Point(150, 67)
        Me.txtNum_Docum2.MaxLength = 100
        Me.txtNum_Docum2.Name = "txtNum_Docum2"
        Me.txtNum_Docum2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Docum2.Size = New System.Drawing.Size(104, 20)
        Me.txtNum_Docum2.TabIndex = 105
        '
        'txtSer_Docum2
        '
        Me.txtSer_Docum2.AcceptsReturn = True
        Me.txtSer_Docum2.BackColor = System.Drawing.SystemColors.Window
        Me.txtSer_Docum2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSer_Docum2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSer_Docum2.Location = New System.Drawing.Point(150, 41)
        Me.txtSer_Docum2.MaxLength = 100
        Me.txtSer_Docum2.Name = "txtSer_Docum2"
        Me.txtSer_Docum2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSer_Docum2.Size = New System.Drawing.Size(104, 20)
        Me.txtSer_Docum2.TabIndex = 103
        '
        'txtCod_TipDoc2
        '
        Me.txtCod_TipDoc2.AcceptsReturn = True
        Me.txtCod_TipDoc2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_TipDoc2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_TipDoc2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_TipDoc2.Location = New System.Drawing.Point(150, 15)
        Me.txtCod_TipDoc2.MaxLength = 100
        Me.txtCod_TipDoc2.Name = "txtCod_TipDoc2"
        Me.txtCod_TipDoc2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_TipDoc2.Size = New System.Drawing.Size(31, 20)
        Me.txtCod_TipDoc2.TabIndex = 101
        Me.txtCod_TipDoc2.Text = "FA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(33, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Número ............................"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(33, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Serie .................................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(33, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Tipo Doc. ......................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 30)
        Me.Panel2.TabIndex = 255
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(80, 0)
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
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 10)
        Me.Panel4.TabIndex = 254
        '
        'FrmDocumentoVenta_ReactivaFactAnulada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 140)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_ReactivaFactAnulada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reactiva Factura Anulada"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents txtSer_Docum2 As TextBox
    Public WithEvents txtCod_TipDoc2 As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As Panel
    Public WithEvents txtNum_Docum2 As TextBox
    Public WithEvents Label3 As Label
End Class
