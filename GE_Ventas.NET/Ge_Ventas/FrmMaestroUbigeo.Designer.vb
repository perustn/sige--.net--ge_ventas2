<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaestroUbigeo
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
        Me.txtCod_Depar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.txtDes_Depar = New System.Windows.Forms.TextBox()
        Me.txtDes_Prov = New System.Windows.Forms.TextBox()
        Me.txtCod_Prov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDes_Dist = New System.Windows.Forms.TextBox()
        Me.txtCod_Dist = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtDes_Dist)
        Me.Panel1.Controls.Add(Me.txtCod_Dist)
        Me.Panel1.Controls.Add(Me.txtDes_Prov)
        Me.Panel1.Controls.Add(Me.txtCod_Prov)
        Me.Panel1.Controls.Add(Me.txtDes_Depar)
        Me.Panel1.Controls.Add(Me.txtCod_Depar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 92)
        Me.Panel1.TabIndex = 267
        '
        'txtCod_Depar
        '
        Me.txtCod_Depar.AcceptsReturn = True
        Me.txtCod_Depar.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Depar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Depar.Enabled = False
        Me.txtCod_Depar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Depar.Location = New System.Drawing.Point(135, 11)
        Me.txtCod_Depar.MaxLength = 100
        Me.txtCod_Depar.Name = "txtCod_Depar"
        Me.txtCod_Depar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Depar.Size = New System.Drawing.Size(55, 20)
        Me.txtCod_Depar.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Departamento .................."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(515, 5)
        Me.Panel4.TabIndex = 266
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 30)
        Me.Panel2.TabIndex = 265
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(308, 0)
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
        'txtDes_Depar
        '
        Me.txtDes_Depar.AcceptsReturn = True
        Me.txtDes_Depar.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Depar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Depar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_Depar.Location = New System.Drawing.Point(192, 11)
        Me.txtDes_Depar.MaxLength = 100
        Me.txtDes_Depar.Name = "txtDes_Depar"
        Me.txtDes_Depar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Depar.Size = New System.Drawing.Size(291, 20)
        Me.txtDes_Depar.TabIndex = 104
        '
        'txtDes_Prov
        '
        Me.txtDes_Prov.AcceptsReturn = True
        Me.txtDes_Prov.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Prov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_Prov.Location = New System.Drawing.Point(192, 37)
        Me.txtDes_Prov.MaxLength = 100
        Me.txtDes_Prov.Name = "txtDes_Prov"
        Me.txtDes_Prov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Prov.Size = New System.Drawing.Size(291, 20)
        Me.txtDes_Prov.TabIndex = 107
        '
        'txtCod_Prov
        '
        Me.txtCod_Prov.AcceptsReturn = True
        Me.txtCod_Prov.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Prov.Enabled = False
        Me.txtCod_Prov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Prov.Location = New System.Drawing.Point(135, 37)
        Me.txtCod_Prov.MaxLength = 100
        Me.txtCod_Prov.Name = "txtCod_Prov"
        Me.txtCod_Prov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Prov.Size = New System.Drawing.Size(55, 20)
        Me.txtCod_Prov.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Provincia .........................."
        '
        'txtDes_Dist
        '
        Me.txtDes_Dist.AcceptsReturn = True
        Me.txtDes_Dist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Dist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Dist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_Dist.Location = New System.Drawing.Point(192, 63)
        Me.txtDes_Dist.MaxLength = 100
        Me.txtDes_Dist.Name = "txtDes_Dist"
        Me.txtDes_Dist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Dist.Size = New System.Drawing.Size(291, 20)
        Me.txtDes_Dist.TabIndex = 110
        '
        'txtCod_Dist
        '
        Me.txtCod_Dist.AcceptsReturn = True
        Me.txtCod_Dist.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Dist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Dist.Enabled = False
        Me.txtCod_Dist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Dist.Location = New System.Drawing.Point(135, 63)
        Me.txtCod_Dist.MaxLength = 100
        Me.txtCod_Dist.Name = "txtCod_Dist"
        Me.txtCod_Dist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Dist.Size = New System.Drawing.Size(55, 20)
        Me.txtCod_Dist.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(18, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Distrito ..............................."
        '
        'FrmMaestroUbigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMaestroUbigeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ubigeo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents txtCod_Depar As TextBox
    Public WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents txtDes_Dist As TextBox
    Public WithEvents txtCod_Dist As TextBox
    Public WithEvents txtDes_Prov As TextBox
    Public WithEvents txtCod_Prov As TextBox
    Public WithEvents txtDes_Depar As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents Label1 As Label
End Class
