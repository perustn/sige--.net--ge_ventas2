<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_Detalle_Telas_EmbarqueTelas
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
        Me.grpDetalleReal = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUnidadesReal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKgsReal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUbicajeReal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRollosReal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPeso_Neto_Real = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPeso_Bruto_Real = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUnidadesProg = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtKgsProg = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUbicajeProg = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRollosProg = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPeso_Neto_Prog = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPeso_Bruto_Prog = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDesUniMedida = New System.Windows.Forms.TextBox()
        Me.txtCodUniMedida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesColor = New System.Windows.Forms.TextBox()
        Me.txtCodColor = New System.Windows.Forms.TextBox()
        Me.txtDesComb = New System.Windows.Forms.TextBox()
        Me.txtCodComb = New System.Windows.Forms.TextBox()
        Me.txtDesTela = New System.Windows.Forms.TextBox()
        Me.txtCodTela = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtSec = New System.Windows.Forms.TextBox()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grpDetalleReal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalleReal.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.grpDetalleReal)
        Me.Panel1.Controls.Add(Me.UiGroupBox3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 332)
        Me.Panel1.TabIndex = 0
        '
        'grpDetalleReal
        '
        Me.grpDetalleReal.Controls.Add(Me.txtUnidadesReal)
        Me.grpDetalleReal.Controls.Add(Me.Label5)
        Me.grpDetalleReal.Controls.Add(Me.txtKgsReal)
        Me.grpDetalleReal.Controls.Add(Me.Label6)
        Me.grpDetalleReal.Controls.Add(Me.txtUbicajeReal)
        Me.grpDetalleReal.Controls.Add(Me.Label7)
        Me.grpDetalleReal.Controls.Add(Me.txtRollosReal)
        Me.grpDetalleReal.Controls.Add(Me.Label8)
        Me.grpDetalleReal.Controls.Add(Me.txtPeso_Neto_Real)
        Me.grpDetalleReal.Controls.Add(Me.Label9)
        Me.grpDetalleReal.Controls.Add(Me.txtPeso_Bruto_Real)
        Me.grpDetalleReal.Controls.Add(Me.Label10)
        Me.grpDetalleReal.Enabled = False
        Me.grpDetalleReal.Location = New System.Drawing.Point(252, 133)
        Me.grpDetalleReal.Name = "grpDetalleReal"
        Me.grpDetalleReal.Size = New System.Drawing.Size(214, 187)
        Me.grpDetalleReal.TabIndex = 31
        Me.grpDetalleReal.Text = "DETALLE REAL"
        Me.grpDetalleReal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtUnidadesReal
        '
        Me.txtUnidadesReal.Location = New System.Drawing.Point(103, 155)
        Me.txtUnidadesReal.Name = "txtUnidadesReal"
        Me.txtUnidadesReal.Size = New System.Drawing.Size(80, 20)
        Me.txtUnidadesReal.TabIndex = 30
        Me.txtUnidadesReal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Unidades..............."
        '
        'txtKgsReal
        '
        Me.txtKgsReal.Location = New System.Drawing.Point(103, 127)
        Me.txtKgsReal.Name = "txtKgsReal"
        Me.txtKgsReal.Size = New System.Drawing.Size(80, 20)
        Me.txtKgsReal.TabIndex = 28
        Me.txtKgsReal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Kgs........................."
        '
        'txtUbicajeReal
        '
        Me.txtUbicajeReal.Location = New System.Drawing.Point(103, 100)
        Me.txtUbicajeReal.Name = "txtUbicajeReal"
        Me.txtUbicajeReal.Size = New System.Drawing.Size(80, 20)
        Me.txtUbicajeReal.TabIndex = 26
        Me.txtUbicajeReal.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Cubicaje..............."
        '
        'txtRollosReal
        '
        Me.txtRollosReal.Location = New System.Drawing.Point(103, 72)
        Me.txtRollosReal.Name = "txtRollosReal"
        Me.txtRollosReal.Size = New System.Drawing.Size(80, 20)
        Me.txtRollosReal.TabIndex = 24
        Me.txtRollosReal.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Rollos..............."
        '
        'txtPeso_Neto_Real
        '
        Me.txtPeso_Neto_Real.Location = New System.Drawing.Point(103, 45)
        Me.txtPeso_Neto_Real.Name = "txtPeso_Neto_Real"
        Me.txtPeso_Neto_Real.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Neto_Real.TabIndex = 22
        Me.txtPeso_Neto_Real.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Peso Neto..............."
        '
        'txtPeso_Bruto_Real
        '
        Me.txtPeso_Bruto_Real.Location = New System.Drawing.Point(103, 19)
        Me.txtPeso_Bruto_Real.Name = "txtPeso_Bruto_Real"
        Me.txtPeso_Bruto_Real.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Bruto_Real.TabIndex = 20
        Me.txtPeso_Bruto_Real.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Peso Bruto..............."
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.txtUnidadesProg)
        Me.UiGroupBox3.Controls.Add(Me.Label17)
        Me.UiGroupBox3.Controls.Add(Me.txtKgsProg)
        Me.UiGroupBox3.Controls.Add(Me.Label16)
        Me.UiGroupBox3.Controls.Add(Me.txtUbicajeProg)
        Me.UiGroupBox3.Controls.Add(Me.Label15)
        Me.UiGroupBox3.Controls.Add(Me.txtRollosProg)
        Me.UiGroupBox3.Controls.Add(Me.Label14)
        Me.UiGroupBox3.Controls.Add(Me.txtPeso_Neto_Prog)
        Me.UiGroupBox3.Controls.Add(Me.Label13)
        Me.UiGroupBox3.Controls.Add(Me.txtPeso_Bruto_Prog)
        Me.UiGroupBox3.Controls.Add(Me.Label12)
        Me.UiGroupBox3.Location = New System.Drawing.Point(11, 133)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(214, 187)
        Me.UiGroupBox3.TabIndex = 12
        Me.UiGroupBox3.Text = "DETALLE PROGRAMADO"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtUnidadesProg
        '
        Me.txtUnidadesProg.Location = New System.Drawing.Point(103, 155)
        Me.txtUnidadesProg.Name = "txtUnidadesProg"
        Me.txtUnidadesProg.Size = New System.Drawing.Size(80, 20)
        Me.txtUnidadesProg.TabIndex = 30
        Me.txtUnidadesProg.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Unidades..............."
        '
        'txtKgsProg
        '
        Me.txtKgsProg.Location = New System.Drawing.Point(103, 127)
        Me.txtKgsProg.Name = "txtKgsProg"
        Me.txtKgsProg.Size = New System.Drawing.Size(80, 20)
        Me.txtKgsProg.TabIndex = 28
        Me.txtKgsProg.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Kgs........................."
        '
        'txtUbicajeProg
        '
        Me.txtUbicajeProg.Location = New System.Drawing.Point(103, 100)
        Me.txtUbicajeProg.Name = "txtUbicajeProg"
        Me.txtUbicajeProg.Size = New System.Drawing.Size(80, 20)
        Me.txtUbicajeProg.TabIndex = 26
        Me.txtUbicajeProg.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Cubicaje..............."
        '
        'txtRollosProg
        '
        Me.txtRollosProg.Location = New System.Drawing.Point(103, 72)
        Me.txtRollosProg.Name = "txtRollosProg"
        Me.txtRollosProg.Size = New System.Drawing.Size(80, 20)
        Me.txtRollosProg.TabIndex = 24
        Me.txtRollosProg.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Rollos..............."
        '
        'txtPeso_Neto_Prog
        '
        Me.txtPeso_Neto_Prog.Location = New System.Drawing.Point(103, 45)
        Me.txtPeso_Neto_Prog.Name = "txtPeso_Neto_Prog"
        Me.txtPeso_Neto_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Neto_Prog.TabIndex = 22
        Me.txtPeso_Neto_Prog.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Peso Neto..............."
        '
        'txtPeso_Bruto_Prog
        '
        Me.txtPeso_Bruto_Prog.Location = New System.Drawing.Point(103, 19)
        Me.txtPeso_Bruto_Prog.Name = "txtPeso_Bruto_Prog"
        Me.txtPeso_Bruto_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Bruto_Prog.TabIndex = 20
        Me.txtPeso_Bruto_Prog.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Peso Bruto..............."
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtDesUniMedida)
        Me.Panel2.Controls.Add(Me.txtCodUniMedida)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtDesColor)
        Me.Panel2.Controls.Add(Me.txtCodColor)
        Me.Panel2.Controls.Add(Me.txtDesComb)
        Me.Panel2.Controls.Add(Me.txtCodComb)
        Me.Panel2.Controls.Add(Me.txtDesTela)
        Me.Panel2.Controls.Add(Me.txtCodTela)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(11, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 115)
        Me.Panel2.TabIndex = 0
        '
        'txtDesUniMedida
        '
        Me.txtDesUniMedida.Location = New System.Drawing.Point(172, 81)
        Me.txtDesUniMedida.Name = "txtDesUniMedida"
        Me.txtDesUniMedida.Size = New System.Drawing.Size(251, 20)
        Me.txtDesUniMedida.TabIndex = 11
        '
        'txtCodUniMedida
        '
        Me.txtCodUniMedida.Location = New System.Drawing.Point(106, 81)
        Me.txtCodUniMedida.Name = "txtCodUniMedida"
        Me.txtCodUniMedida.Size = New System.Drawing.Size(63, 20)
        Me.txtCodUniMedida.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Unidad Medida......................."
        '
        'txtDesColor
        '
        Me.txtDesColor.Location = New System.Drawing.Point(172, 55)
        Me.txtDesColor.Name = "txtDesColor"
        Me.txtDesColor.Size = New System.Drawing.Size(251, 20)
        Me.txtDesColor.TabIndex = 8
        '
        'txtCodColor
        '
        Me.txtCodColor.Location = New System.Drawing.Point(106, 55)
        Me.txtCodColor.Name = "txtCodColor"
        Me.txtCodColor.Size = New System.Drawing.Size(63, 20)
        Me.txtCodColor.TabIndex = 7
        '
        'txtDesComb
        '
        Me.txtDesComb.Location = New System.Drawing.Point(172, 31)
        Me.txtDesComb.Name = "txtDesComb"
        Me.txtDesComb.Size = New System.Drawing.Size(251, 20)
        Me.txtDesComb.TabIndex = 6
        '
        'txtCodComb
        '
        Me.txtCodComb.Location = New System.Drawing.Point(106, 31)
        Me.txtCodComb.Name = "txtCodComb"
        Me.txtCodComb.Size = New System.Drawing.Size(63, 20)
        Me.txtCodComb.TabIndex = 5
        '
        'txtDesTela
        '
        Me.txtDesTela.Location = New System.Drawing.Point(172, 8)
        Me.txtDesTela.Name = "txtDesTela"
        Me.txtDesTela.Size = New System.Drawing.Size(251, 20)
        Me.txtDesTela.TabIndex = 4
        '
        'txtCodTela
        '
        Me.txtCodTela.Location = New System.Drawing.Point(106, 8)
        Me.txtCodTela.Name = "txtCodTela"
        Me.txtCodTela.Size = New System.Drawing.Size(63, 20)
        Me.txtCodTela.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Color......................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Combinacion..........."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tela......................"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 358)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(475, 30)
        Me.Panel4.TabIndex = 32
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(268, 0)
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
        Me.Panel3.Controls.Add(Me.TxtSec)
        Me.Panel3.Controls.Add(Me.LabelSec)
        Me.Panel3.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(475, 26)
        Me.Panel3.TabIndex = 65
        '
        'TxtSec
        '
        Me.TxtSec.AcceptsReturn = True
        Me.TxtSec.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSec.Location = New System.Drawing.Point(248, 3)
        Me.TxtSec.MaxLength = 0
        Me.TxtSec.Name = "TxtSec"
        Me.TxtSec.ReadOnly = True
        Me.TxtSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSec.Size = New System.Drawing.Size(38, 20)
        Me.TxtSec.TabIndex = 88
        Me.TxtSec.Visible = False
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.BackColor = System.Drawing.Color.Transparent
        Me.LabelSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSec.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSec.ForeColor = System.Drawing.Color.Gold
        Me.LabelSec.Location = New System.Drawing.Point(215, 7)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSec.Size = New System.Drawing.Size(23, 12)
        Me.LabelSec.TabIndex = 87
        Me.LabelSec.Text = "SEC"
        Me.LabelSec.Visible = False
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
        'FrmTgEmbarque_Detalle_Telas_EmbarqueTelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmTgEmbarque_Detalle_Telas_EmbarqueTelas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Embarque Telas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grpDetalleReal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalleReal.ResumeLayout(False)
        Me.grpDetalleReal.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
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
    Friend WithEvents txtDesUniMedida As TextBox
    Friend WithEvents txtCodUniMedida As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDesColor As TextBox
    Friend WithEvents txtCodColor As TextBox
    Friend WithEvents txtDesComb As TextBox
    Friend WithEvents txtCodComb As TextBox
    Friend WithEvents txtDesTela As TextBox
    Friend WithEvents txtCodTela As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpDetalleReal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtUnidadesReal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKgsReal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUbicajeReal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRollosReal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPeso_Neto_Real As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPeso_Bruto_Real As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtUnidadesProg As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtKgsProg As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtUbicajeProg As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRollosProg As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPeso_Neto_Prog As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPeso_Bruto_Prog As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents TxtSec As System.Windows.Forms.TextBox
    Public WithEvents LabelSec As System.Windows.Forms.Label
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Public WithEvents Label37 As System.Windows.Forms.Label
End Class
