<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_Detalle_Add
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
        Me.txtCubicaje = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPeso_Neto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPeso_Bruto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNum_Cajas = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNum_Prendas = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.grpDetalleProgramado = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCubicaje_Prog = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPeso_Neto_Prog = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPeso_Bruto_Prog = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNum_Cajas_Prog = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPre_Unitario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNum_Prendas_Prog = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtarancelaria3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtarancelaria2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtarancelaria1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCod_EstCli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCod_LotPurOrd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod_PurOrd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNom_Cliente = New System.Windows.Forms.TextBox()
        Me.txtAbr_Cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlOP = New System.Windows.Forms.Panel()
        Me.txtDes_OrdPro = New System.Windows.Forms.TextBox()
        Me.txtCod_OrdPro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlClienteTemporada = New System.Windows.Forms.Panel()
        Me.txtestilo = New System.Windows.Forms.TextBox()
        Me.txtNom_TemCli = New System.Windows.Forms.TextBox()
        Me.txtCod_TemCli = New System.Windows.Forms.TextBox()
        Me.txtDes_Cliente = New System.Windows.Forms.TextBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOpcion = New Janus.Windows.EditControls.UIGroupBox()
        Me.optClienteTemporada = New Janus.Windows.EditControls.UIRadioButton()
        Me.optOP = New Janus.Windows.EditControls.UIRadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSec = New System.Windows.Forms.TextBox()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grpDetalleReal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalleReal.SuspendLayout()
        CType(Me.grpDetalleProgramado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalleProgramado.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.pnlOP.SuspendLayout()
        Me.pnlClienteTemporada.SuspendLayout()
        CType(Me.grpOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpcion.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.grpDetalleReal)
        Me.Panel1.Controls.Add(Me.grpDetalleProgramado)
        Me.Panel1.Controls.Add(Me.UiGroupBox2)
        Me.Panel1.Controls.Add(Me.pnlOP)
        Me.Panel1.Controls.Add(Me.pnlClienteTemporada)
        Me.Panel1.Controls.Add(Me.grpOpcion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 436)
        Me.Panel1.TabIndex = 0
        '
        'grpDetalleReal
        '
        Me.grpDetalleReal.Controls.Add(Me.txtCubicaje)
        Me.grpDetalleReal.Controls.Add(Me.Label18)
        Me.grpDetalleReal.Controls.Add(Me.txtPeso_Neto)
        Me.grpDetalleReal.Controls.Add(Me.Label19)
        Me.grpDetalleReal.Controls.Add(Me.txtPeso_Bruto)
        Me.grpDetalleReal.Controls.Add(Me.Label20)
        Me.grpDetalleReal.Controls.Add(Me.txtNum_Cajas)
        Me.grpDetalleReal.Controls.Add(Me.Label21)
        Me.grpDetalleReal.Controls.Add(Me.txtNum_Prendas)
        Me.grpDetalleReal.Controls.Add(Me.Label23)
        Me.grpDetalleReal.Location = New System.Drawing.Point(234, 257)
        Me.grpDetalleReal.Name = "grpDetalleReal"
        Me.grpDetalleReal.Size = New System.Drawing.Size(214, 171)
        Me.grpDetalleReal.TabIndex = 11
        Me.grpDetalleReal.Text = "Detalle Real"
        Me.grpDetalleReal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtCubicaje
        '
        Me.txtCubicaje.Location = New System.Drawing.Point(110, 139)
        Me.txtCubicaje.Name = "txtCubicaje"
        Me.txtCubicaje.Size = New System.Drawing.Size(80, 20)
        Me.txtCubicaje.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 13)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Cubicaje Prog..............."
        '
        'txtPeso_Neto
        '
        Me.txtPeso_Neto.Location = New System.Drawing.Point(110, 115)
        Me.txtPeso_Neto.Name = "txtPeso_Neto"
        Me.txtPeso_Neto.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Neto.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Peso Neto Prog..............."
        '
        'txtPeso_Bruto
        '
        Me.txtPeso_Bruto.Location = New System.Drawing.Point(110, 91)
        Me.txtPeso_Bruto.Name = "txtPeso_Bruto"
        Me.txtPeso_Bruto.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Bruto.TabIndex = 38
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Peso Bruto..............."
        '
        'txtNum_Cajas
        '
        Me.txtNum_Cajas.Location = New System.Drawing.Point(110, 67)
        Me.txtNum_Cajas.Name = "txtNum_Cajas"
        Me.txtNum_Cajas.Size = New System.Drawing.Size(80, 20)
        Me.txtNum_Cajas.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Num Cajas..............."
        '
        'txtNum_Prendas
        '
        Me.txtNum_Prendas.Location = New System.Drawing.Point(110, 19)
        Me.txtNum_Prendas.Name = "txtNum_Prendas"
        Me.txtNum_Prendas.Size = New System.Drawing.Size(80, 20)
        Me.txtNum_Prendas.TabIndex = 32
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(27, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Prendas..............."
        '
        'grpDetalleProgramado
        '
        Me.grpDetalleProgramado.Controls.Add(Me.txtCubicaje_Prog)
        Me.grpDetalleProgramado.Controls.Add(Me.Label17)
        Me.grpDetalleProgramado.Controls.Add(Me.txtPeso_Neto_Prog)
        Me.grpDetalleProgramado.Controls.Add(Me.Label16)
        Me.grpDetalleProgramado.Controls.Add(Me.txtPeso_Bruto_Prog)
        Me.grpDetalleProgramado.Controls.Add(Me.Label15)
        Me.grpDetalleProgramado.Controls.Add(Me.txtNum_Cajas_Prog)
        Me.grpDetalleProgramado.Controls.Add(Me.Label14)
        Me.grpDetalleProgramado.Controls.Add(Me.txtPre_Unitario)
        Me.grpDetalleProgramado.Controls.Add(Me.Label13)
        Me.grpDetalleProgramado.Controls.Add(Me.txtNum_Prendas_Prog)
        Me.grpDetalleProgramado.Controls.Add(Me.Label12)
        Me.grpDetalleProgramado.Location = New System.Drawing.Point(8, 257)
        Me.grpDetalleProgramado.Name = "grpDetalleProgramado"
        Me.grpDetalleProgramado.Size = New System.Drawing.Size(214, 171)
        Me.grpDetalleProgramado.TabIndex = 10
        Me.grpDetalleProgramado.Text = "Detalle Programado"
        Me.grpDetalleProgramado.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtCubicaje_Prog
        '
        Me.txtCubicaje_Prog.Location = New System.Drawing.Point(103, 139)
        Me.txtCubicaje_Prog.Name = "txtCubicaje_Prog"
        Me.txtCubicaje_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtCubicaje_Prog.TabIndex = 30
        Me.txtCubicaje_Prog.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Cubicaje Prog..............."
        '
        'txtPeso_Neto_Prog
        '
        Me.txtPeso_Neto_Prog.Location = New System.Drawing.Point(103, 115)
        Me.txtPeso_Neto_Prog.Name = "txtPeso_Neto_Prog"
        Me.txtPeso_Neto_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Neto_Prog.TabIndex = 28
        Me.txtPeso_Neto_Prog.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Peso Neto Prog..............."
        '
        'txtPeso_Bruto_Prog
        '
        Me.txtPeso_Bruto_Prog.Location = New System.Drawing.Point(103, 91)
        Me.txtPeso_Bruto_Prog.Name = "txtPeso_Bruto_Prog"
        Me.txtPeso_Bruto_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso_Bruto_Prog.TabIndex = 26
        Me.txtPeso_Bruto_Prog.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Peso Bruto..............."
        '
        'txtNum_Cajas_Prog
        '
        Me.txtNum_Cajas_Prog.Location = New System.Drawing.Point(103, 67)
        Me.txtNum_Cajas_Prog.Name = "txtNum_Cajas_Prog"
        Me.txtNum_Cajas_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtNum_Cajas_Prog.TabIndex = 24
        Me.txtNum_Cajas_Prog.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Num Cajas..............."
        '
        'txtPre_Unitario
        '
        Me.txtPre_Unitario.Location = New System.Drawing.Point(103, 43)
        Me.txtPre_Unitario.Name = "txtPre_Unitario"
        Me.txtPre_Unitario.Size = New System.Drawing.Size(80, 20)
        Me.txtPre_Unitario.TabIndex = 22
        Me.txtPre_Unitario.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Precio Unitario..............."
        '
        'txtNum_Prendas_Prog
        '
        Me.txtNum_Prendas_Prog.Location = New System.Drawing.Point(103, 19)
        Me.txtNum_Prendas_Prog.Name = "txtNum_Prendas_Prog"
        Me.txtNum_Prendas_Prog.Size = New System.Drawing.Size(80, 20)
        Me.txtNum_Prendas_Prog.TabIndex = 20
        Me.txtNum_Prendas_Prog.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Prendas..............."
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.txtarancelaria3)
        Me.UiGroupBox2.Controls.Add(Me.Label9)
        Me.UiGroupBox2.Controls.Add(Me.txtarancelaria2)
        Me.UiGroupBox2.Controls.Add(Me.Label10)
        Me.UiGroupBox2.Controls.Add(Me.txtarancelaria1)
        Me.UiGroupBox2.Controls.Add(Me.Label11)
        Me.UiGroupBox2.Controls.Add(Me.txtCod_EstCli)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.txtCod_LotPurOrd)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Controls.Add(Me.txtCod_PurOrd)
        Me.UiGroupBox2.Controls.Add(Me.Label5)
        Me.UiGroupBox2.Controls.Add(Me.txtNom_Cliente)
        Me.UiGroupBox2.Controls.Add(Me.txtAbr_Cliente)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(440, 112)
        Me.UiGroupBox2.TabIndex = 9
        Me.UiGroupBox2.Text = "Lote PO"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtarancelaria3
        '
        Me.txtarancelaria3.Location = New System.Drawing.Point(373, 66)
        Me.txtarancelaria3.Name = "txtarancelaria3"
        Me.txtarancelaria3.Size = New System.Drawing.Size(61, 20)
        Me.txtarancelaria3.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nº Categoria Internacional"
        '
        'txtarancelaria2
        '
        Me.txtarancelaria2.Location = New System.Drawing.Point(147, 89)
        Me.txtarancelaria2.Name = "txtarancelaria2"
        Me.txtarancelaria2.Size = New System.Drawing.Size(54, 20)
        Me.txtarancelaria2.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Sec Partida Arancelaria"
        '
        'txtarancelaria1
        '
        Me.txtarancelaria1.Location = New System.Drawing.Point(147, 66)
        Me.txtarancelaria1.Name = "txtarancelaria1"
        Me.txtarancelaria1.Size = New System.Drawing.Size(54, 20)
        Me.txtarancelaria1.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Nº Partida Arancelaria"
        '
        'txtCod_EstCli
        '
        Me.txtCod_EstCli.Location = New System.Drawing.Point(373, 41)
        Me.txtCod_EstCli.Name = "txtCod_EstCli"
        Me.txtCod_EstCli.Size = New System.Drawing.Size(61, 20)
        Me.txtCod_EstCli.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Estilo"
        '
        'txtCod_LotPurOrd
        '
        Me.txtCod_LotPurOrd.Location = New System.Drawing.Point(215, 41)
        Me.txtCod_LotPurOrd.Name = "txtCod_LotPurOrd"
        Me.txtCod_LotPurOrd.Size = New System.Drawing.Size(54, 20)
        Me.txtCod_LotPurOrd.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lote"
        '
        'txtCod_PurOrd
        '
        Me.txtCod_PurOrd.Location = New System.Drawing.Point(91, 41)
        Me.txtCod_PurOrd.Name = "txtCod_PurOrd"
        Me.txtCod_PurOrd.Size = New System.Drawing.Size(54, 20)
        Me.txtCod_PurOrd.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PO................"
        '
        'txtNom_Cliente
        '
        Me.txtNom_Cliente.Location = New System.Drawing.Point(147, 16)
        Me.txtNom_Cliente.Name = "txtNom_Cliente"
        Me.txtNom_Cliente.Size = New System.Drawing.Size(287, 20)
        Me.txtNom_Cliente.TabIndex = 7
        '
        'txtAbr_Cliente
        '
        Me.txtAbr_Cliente.Location = New System.Drawing.Point(91, 16)
        Me.txtAbr_Cliente.Name = "txtAbr_Cliente"
        Me.txtAbr_Cliente.Size = New System.Drawing.Size(54, 20)
        Me.txtAbr_Cliente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente................."
        '
        'pnlOP
        '
        Me.pnlOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOP.Controls.Add(Me.txtDes_OrdPro)
        Me.pnlOP.Controls.Add(Me.txtCod_OrdPro)
        Me.pnlOP.Controls.Add(Me.Label6)
        Me.pnlOP.Location = New System.Drawing.Point(8, 49)
        Me.pnlOP.Name = "pnlOP"
        Me.pnlOP.Size = New System.Drawing.Size(440, 82)
        Me.pnlOP.TabIndex = 8
        '
        'txtDes_OrdPro
        '
        Me.txtDes_OrdPro.Enabled = False
        Me.txtDes_OrdPro.Location = New System.Drawing.Point(146, 25)
        Me.txtDes_OrdPro.Name = "txtDes_OrdPro"
        Me.txtDes_OrdPro.Size = New System.Drawing.Size(287, 20)
        Me.txtDes_OrdPro.TabIndex = 4
        '
        'txtCod_OrdPro
        '
        Me.txtCod_OrdPro.Location = New System.Drawing.Point(90, 25)
        Me.txtCod_OrdPro.MaxLength = 5
        Me.txtCod_OrdPro.Name = "txtCod_OrdPro"
        Me.txtCod_OrdPro.Size = New System.Drawing.Size(54, 20)
        Me.txtCod_OrdPro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "OP................."
        '
        'pnlClienteTemporada
        '
        Me.pnlClienteTemporada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlClienteTemporada.Controls.Add(Me.txtestilo)
        Me.pnlClienteTemporada.Controls.Add(Me.txtNom_TemCli)
        Me.pnlClienteTemporada.Controls.Add(Me.txtCod_TemCli)
        Me.pnlClienteTemporada.Controls.Add(Me.txtDes_Cliente)
        Me.pnlClienteTemporada.Controls.Add(Me.txtcliente)
        Me.pnlClienteTemporada.Controls.Add(Me.Label3)
        Me.pnlClienteTemporada.Controls.Add(Me.Label2)
        Me.pnlClienteTemporada.Controls.Add(Me.Label1)
        Me.pnlClienteTemporada.Location = New System.Drawing.Point(8, 49)
        Me.pnlClienteTemporada.Name = "pnlClienteTemporada"
        Me.pnlClienteTemporada.Size = New System.Drawing.Size(440, 82)
        Me.pnlClienteTemporada.TabIndex = 4
        Me.pnlClienteTemporada.Visible = False
        '
        'txtestilo
        '
        Me.txtestilo.Location = New System.Drawing.Point(90, 51)
        Me.txtestilo.Name = "txtestilo"
        Me.txtestilo.Size = New System.Drawing.Size(117, 20)
        Me.txtestilo.TabIndex = 7
        '
        'txtNom_TemCli
        '
        Me.txtNom_TemCli.Location = New System.Drawing.Point(146, 27)
        Me.txtNom_TemCli.Name = "txtNom_TemCli"
        Me.txtNom_TemCli.Size = New System.Drawing.Size(287, 20)
        Me.txtNom_TemCli.TabIndex = 6
        '
        'txtCod_TemCli
        '
        Me.txtCod_TemCli.Location = New System.Drawing.Point(90, 27)
        Me.txtCod_TemCli.Name = "txtCod_TemCli"
        Me.txtCod_TemCli.Size = New System.Drawing.Size(54, 20)
        Me.txtCod_TemCli.TabIndex = 5
        '
        'txtDes_Cliente
        '
        Me.txtDes_Cliente.Location = New System.Drawing.Point(146, 4)
        Me.txtDes_Cliente.Name = "txtDes_Cliente"
        Me.txtDes_Cliente.Size = New System.Drawing.Size(287, 20)
        Me.txtDes_Cliente.TabIndex = 4
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(90, 4)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(54, 20)
        Me.txtcliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estilo...................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temporada.........."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente................."
        '
        'grpOpcion
        '
        Me.grpOpcion.Controls.Add(Me.optClienteTemporada)
        Me.grpOpcion.Controls.Add(Me.optOP)
        Me.grpOpcion.Location = New System.Drawing.Point(8, 2)
        Me.grpOpcion.Name = "grpOpcion"
        Me.grpOpcion.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.grpOpcion.Size = New System.Drawing.Size(440, 41)
        Me.grpOpcion.TabIndex = 3
        Me.grpOpcion.Text = "Busqueda por"
        Me.grpOpcion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'optClienteTemporada
        '
        Me.optClienteTemporada.Location = New System.Drawing.Point(238, 12)
        Me.optClienteTemporada.Name = "optClienteTemporada"
        Me.optClienteTemporada.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.optClienteTemporada.Size = New System.Drawing.Size(141, 23)
        Me.optClienteTemporada.TabIndex = 1
        Me.optClienteTemporada.Tag = "2"
        Me.optClienteTemporada.Text = "Cliente / Temporada"
        Me.optClienteTemporada.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'optOP
        '
        Me.optOP.Checked = True
        Me.optOP.Location = New System.Drawing.Point(110, 12)
        Me.optOP.Name = "optOP"
        Me.optOP.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.optOP.Size = New System.Drawing.Size(61, 23)
        Me.optOP.TabIndex = 0
        Me.optOP.TabStop = True
        Me.optOP.Tag = "1"
        Me.optOP.Text = "OP"
        Me.optOP.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 462)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(457, 30)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(250, 0)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtSec)
        Me.Panel2.Controls.Add(Me.LabelSec)
        Me.Panel2.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 26)
        Me.Panel2.TabIndex = 64
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
        'FrmTgEmbarque_Detalle_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmTgEmbarque_Detalle_Add"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Embarque Tela"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grpDetalleReal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalleReal.ResumeLayout(False)
        Me.grpDetalleReal.PerformLayout()
        CType(Me.grpDetalleProgramado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalleProgramado.ResumeLayout(False)
        Me.grpDetalleProgramado.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.pnlOP.ResumeLayout(False)
        Me.pnlOP.PerformLayout()
        Me.pnlClienteTemporada.ResumeLayout(False)
        Me.pnlClienteTemporada.PerformLayout()
        CType(Me.grpOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpcion.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpOpcion As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents optOP As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents pnlClienteTemporada As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents optClienteTemporada As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents pnlOP As Panel
    Friend WithEvents txtDes_OrdPro As TextBox
    Friend WithEvents txtCod_OrdPro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtestilo As TextBox
    Friend WithEvents txtNom_TemCli As TextBox
    Friend WithEvents txtCod_TemCli As TextBox
    Friend WithEvents txtDes_Cliente As TextBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNom_Cliente As TextBox
    Friend WithEvents txtAbr_Cliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtarancelaria3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtarancelaria2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtarancelaria1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCod_EstCli As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCod_LotPurOrd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCod_PurOrd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grpDetalleReal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDetalleProgramado As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNum_Prendas_Prog As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCubicaje_Prog As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPeso_Neto_Prog As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPeso_Bruto_Prog As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNum_Cajas_Prog As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPre_Unitario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCubicaje As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPeso_Neto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPeso_Bruto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNum_Cajas As TextBox
    Friend WithEvents txtNum_Prendas As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents TxtSec As System.Windows.Forms.TextBox
    Public WithEvents LabelSec As System.Windows.Forms.Label
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Public WithEvents Label37 As System.Windows.Forms.Label
End Class
