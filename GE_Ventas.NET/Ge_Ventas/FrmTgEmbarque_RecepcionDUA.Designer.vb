<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_RecepcionDUA
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNum_Dua = New System.Windows.Forms.MaskedTextBox()
        Me.txtNum_BL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDolares = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNGC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtpFec_NumeracionDua = New System.Windows.Forms.MaskedTextBox()
        Me.dtpEntregaDrauBack = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFec_RecepcionDUA = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFec_EmbarqueReal = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 153)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpFec_RecepcionDUA)
        Me.Panel2.Controls.Add(Me.dtpFec_EmbarqueReal)
        Me.Panel2.Controls.Add(Me.dtpEntregaDrauBack)
        Me.Panel2.Controls.Add(Me.dtpFec_NumeracionDua)
        Me.Panel2.Controls.Add(Me.txtNum_Dua)
        Me.Panel2.Controls.Add(Me.txtNum_BL)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtDolares)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNGC)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(7, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 140)
        Me.Panel2.TabIndex = 0
        '
        'txtNum_Dua
        '
        Me.txtNum_Dua.Location = New System.Drawing.Point(132, 8)
        Me.txtNum_Dua.Mask = "###-####-##-######"
        Me.txtNum_Dua.Name = "txtNum_Dua"
        Me.txtNum_Dua.Size = New System.Drawing.Size(132, 20)
        Me.txtNum_Dua.TabIndex = 16
        '
        'txtNum_BL
        '
        Me.txtNum_BL.Location = New System.Drawing.Point(444, 102)
        Me.txtNum_BL.Name = "txtNum_BL"
        Me.txtNum_BL.Size = New System.Drawing.Size(132, 20)
        Me.txtNum_BL.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Numero Bill of landing................"
        '
        'txtDolares
        '
        Me.txtDolares.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDolares.Location = New System.Drawing.Point(444, 72)
        Me.txtDolares.Name = "txtDolares"
        Me.txtDolares.Size = New System.Drawing.Size(132, 20)
        Me.txtDolares.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Importe FOB  $ DUA................"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha Recepción................"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Real Embarque................"
        '
        'txtNGC
        '
        Me.txtNGC.Location = New System.Drawing.Point(132, 102)
        Me.txtNGC.Name = "txtNGC"
        Me.txtNGC.Size = New System.Drawing.Size(132, 20)
        Me.txtNGC.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID NGC.........................."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(25, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Entrega Tramine Drau Back.."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Numeración................"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero DUA................"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 179)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(609, 30)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(402, 0)
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
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 26)
        Me.Panel3.TabIndex = 64
        '
        'TxtNroEmbarque
        '
        Me.TxtNroEmbarque.AcceptsReturn = True
        Me.TxtNroEmbarque.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroEmbarque.Location = New System.Drawing.Point(103, 3)
        Me.TxtNroEmbarque.MaxLength = 0
        Me.TxtNroEmbarque.Name = "TxtNroEmbarque"
        Me.TxtNroEmbarque.ReadOnly = True
        Me.TxtNroEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroEmbarque.Size = New System.Drawing.Size(92, 20)
        Me.TxtNroEmbarque.TabIndex = 86
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Gold
        Me.Label37.Location = New System.Drawing.Point(17, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(77, 12)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Nº EMBARQUE"
        '
        'dtpFec_NumeracionDua
        '
        Me.dtpFec_NumeracionDua.Location = New System.Drawing.Point(132, 37)
        Me.dtpFec_NumeracionDua.Mask = "00/00/0000"
        Me.dtpFec_NumeracionDua.Name = "dtpFec_NumeracionDua"
        Me.dtpFec_NumeracionDua.Size = New System.Drawing.Size(123, 20)
        Me.dtpFec_NumeracionDua.TabIndex = 302
        '
        'dtpEntregaDrauBack
        '
        Me.dtpEntregaDrauBack.Location = New System.Drawing.Point(132, 72)
        Me.dtpEntregaDrauBack.Mask = "00/00/0000"
        Me.dtpEntregaDrauBack.Name = "dtpEntregaDrauBack"
        Me.dtpEntregaDrauBack.Size = New System.Drawing.Size(123, 20)
        Me.dtpEntregaDrauBack.TabIndex = 303
        '
        'dtpFec_RecepcionDUA
        '
        Me.dtpFec_RecepcionDUA.Location = New System.Drawing.Point(444, 38)
        Me.dtpFec_RecepcionDUA.Mask = "00/00/0000"
        Me.dtpFec_RecepcionDUA.Name = "dtpFec_RecepcionDUA"
        Me.dtpFec_RecepcionDUA.Size = New System.Drawing.Size(123, 20)
        Me.dtpFec_RecepcionDUA.TabIndex = 305
        '
        'dtpFec_EmbarqueReal
        '
        Me.dtpFec_EmbarqueReal.Location = New System.Drawing.Point(444, 9)
        Me.dtpFec_EmbarqueReal.Mask = "00/00/0000"
        Me.dtpFec_EmbarqueReal.Name = "dtpFec_EmbarqueReal"
        Me.dtpFec_EmbarqueReal.Size = New System.Drawing.Size(123, 20)
        Me.dtpFec_EmbarqueReal.TabIndex = 304
        '
        'FrmTgEmbarque_RecepcionDUA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmTgEmbarque_RecepcionDUA"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción DUA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNum_BL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDolares As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNGC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents txtNum_Dua As MaskedTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents dtpFec_RecepcionDUA As System.Windows.Forms.MaskedTextBox
    Public WithEvents dtpFec_EmbarqueReal As System.Windows.Forms.MaskedTextBox
    Public WithEvents dtpEntregaDrauBack As System.Windows.Forms.MaskedTextBox
    Public WithEvents dtpFec_NumeracionDua As System.Windows.Forms.MaskedTextBox
End Class
