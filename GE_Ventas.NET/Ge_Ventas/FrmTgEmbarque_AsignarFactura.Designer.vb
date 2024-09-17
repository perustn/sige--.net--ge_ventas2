<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_AsignarFactura
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGenerarFactura = New Janus.Windows.EditControls.UIButton()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFec_Emision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(308, 30)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.btnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(101, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(207, 30)
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
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'btnAceptar
        '
        Me.btnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.btnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnGenerarFactura)
        Me.Panel2.Controls.Add(Me.txtNumero)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpFec_Emision)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(7, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 100)
        Me.Panel2.TabIndex = 0
        '
        'btnGenerarFactura
        '
        Me.btnGenerarFactura.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.btnGenerarFactura.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnGenerarFactura.Location = New System.Drawing.Point(199, 36)
        Me.btnGenerarFactura.Name = "btnGenerarFactura"
        Me.btnGenerarFactura.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnGenerarFactura.Size = New System.Drawing.Size(74, 46)
        Me.btnGenerarFactura.TabIndex = 6
        Me.btnGenerarFactura.Text = "Generar Número Factura"
        Me.btnGenerarFactura.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(114, 62)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Número......................"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(114, 36)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(72, 20)
        Me.txtSerie.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serie......................."
        '
        'dtpFec_Emision
        '
        Me.dtpFec_Emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec_Emision.Location = New System.Drawing.Point(114, 8)
        Me.dtpFec_Emision.Name = "dtpFec_Emision"
        Me.dtpFec_Emision.Size = New System.Drawing.Size(159, 20)
        Me.dtpFec_Emision.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Emision........"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(308, 28)
        Me.Panel3.TabIndex = 251
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(87, 12)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "NRO EMBARQUE"
        '
        'TxtNroEmbarque
        '
        Me.TxtNroEmbarque.AcceptsReturn = True
        Me.TxtNroEmbarque.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroEmbarque.Location = New System.Drawing.Point(111, 4)
        Me.TxtNroEmbarque.MaxLength = 0
        Me.TxtNroEmbarque.Name = "TxtNroEmbarque"
        Me.TxtNroEmbarque.ReadOnly = True
        Me.TxtNroEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroEmbarque.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroEmbarque.TabIndex = 121
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 114)
        Me.Panel6.TabIndex = 252
        '
        'FrmTgEmbarque_AsignarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 172)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmTgEmbarque_AsignarFactura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Factura"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFec_Emision As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGenerarFactura As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
