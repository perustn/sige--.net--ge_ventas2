<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTgEmbarque_Add))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fraDua = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtEntregaDrauBack = New System.Windows.Forms.DateTimePicker()
        Me.txtFec_RecepcionDUA = New System.Windows.Forms.DateTimePicker()
        Me.txtFec_NumeracionDua = New System.Windows.Forms.DateTimePicker()
        Me.txtFec_EmbarqueReal = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtNum_Dua = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.fraAgenteCarga = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObs_EnvioInstruccionesalAgenteCarga = New System.Windows.Forms.TextBox()
        Me.txtFec_EnvioInstruccionesalAgenteCarga = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.fraEnvioAgenteAduanas = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObs_EnvioInstruccionesalAgenteAduanas = New System.Windows.Forms.TextBox()
        Me.txtFec_EnvioFacturaalAgenteAduanas = New System.Windows.Forms.DateTimePicker()
        Me.txtFec_EnvioInstruccionesalAgenteAduana = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNumCarCre = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtDesConPago = New System.Windows.Forms.TextBox()
        Me.TxtCodConPago = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDes_Termino_Venta = New System.Windows.Forms.TextBox()
        Me.txtCod_Termino_Venta = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDes_Flete_Ingles = New System.Windows.Forms.TextBox()
        Me.txtCod_Flete = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtObs_Embarque = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAgenteAduana = New Janus.Windows.EditControls.UIButton()
        Me.txtNom_AgenteAduana = New System.Windows.Forms.TextBox()
        Me.txtCod_AgenteAduana = New System.Windows.Forms.TextBox()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEjecutivoAgenteCarga = New Janus.Windows.EditControls.UIButton()
        Me.btnAgenteCarga = New Janus.Windows.EditControls.UIButton()
        Me.txtNom_Ejecutivo = New System.Windows.Forms.TextBox()
        Me.txtCod_Ejecutivo_AgenteCarga = New System.Windows.Forms.TextBox()
        Me.txtDes_AgenteCarga = New System.Windows.Forms.TextBox()
        Me.txtCod_AgenteCarga = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNave = New Janus.Windows.EditControls.UIButton()
        Me.TxtDesNave = New System.Windows.Forms.TextBox()
        Me.TxtCodNave = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDes_TipEmbarque = New System.Windows.Forms.TextBox()
        Me.txtTip_Embarque = New System.Windows.Forms.TextBox()
        Me.btnMantenimientoNaviera = New Janus.Windows.EditControls.UIButton()
        Me.TxtDesNaviera = New System.Windows.Forms.TextBox()
        Me.TxtCodNaviera = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txtNom_Embarque = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDes_Embarque = New System.Windows.Forms.TextBox()
        Me.txtCod_Embarque = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCodLocacion = New System.Windows.Forms.TextBox()
        Me.TxtDesLocacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cbo_Destino = New Janus.Windows.EditControls.UIComboBox()
        Me.txtRef_Embarque = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCod_Anxo = New System.Windows.Forms.TextBox()
        Me.txtDes_Anexo = New System.Windows.Forms.TextBox()
        Me.txtCod_TipAnex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNom_Cliente = New System.Windows.Forms.TextBox()
        Me.txtAbr_Cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMeses = New Janus.Windows.EditControls.UIComboBox()
        Me.txtAno = New System.Windows.Forms.NumericUpDown()
        Me.txtDes_Origen = New System.Windows.Forms.TextBox()
        Me.txtCod_Origen = New System.Windows.Forms.TextBox()
        Me.Cbo_TipoEmb = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDes_Estado = New System.Windows.Forms.TextBox()
        Me.txtFlg_Status = New System.Windows.Forms.TextBox()
        Me.txtNum_Embarque = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1.SuspendLayout()
        CType(Me.fraDua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDua.SuspendLayout()
        CType(Me.fraAgenteCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAgenteCarga.SuspendLayout()
        CType(Me.fraEnvioAgenteAduanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraEnvioAgenteAduanas.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.txtAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fraDua)
        Me.Panel1.Controls.Add(Me.fraAgenteCarga)
        Me.Panel1.Controls.Add(Me.fraEnvioAgenteAduanas)
        Me.Panel1.Controls.Add(Me.txtNumCarCre)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TxtDesConPago)
        Me.Panel1.Controls.Add(Me.TxtCodConPago)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtDes_Termino_Venta)
        Me.Panel1.Controls.Add(Me.txtCod_Termino_Venta)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtDes_Flete_Ingles)
        Me.Panel1.Controls.Add(Me.txtCod_Flete)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtObs_Embarque)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.btnAgenteAduana)
        Me.Panel1.Controls.Add(Me.txtNom_AgenteAduana)
        Me.Panel1.Controls.Add(Me.txtCod_AgenteAduana)
        Me.Panel1.Controls.Add(Me.UiGroupBox3)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.UiGroupBox2)
        Me.Panel1.Controls.Add(Me.TxtCodLocacion)
        Me.Panel1.Controls.Add(Me.TxtDesLocacion)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Cbo_Destino)
        Me.Panel1.Controls.Add(Me.txtRef_Embarque)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCod_Anxo)
        Me.Panel1.Controls.Add(Me.txtDes_Anexo)
        Me.Panel1.Controls.Add(Me.txtCod_TipAnex)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNom_Cliente)
        Me.Panel1.Controls.Add(Me.txtAbr_Cliente)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 468)
        Me.Panel1.TabIndex = 0
        '
        'fraDua
        '
        Me.fraDua.Controls.Add(Me.txtEntregaDrauBack)
        Me.fraDua.Controls.Add(Me.txtFec_RecepcionDUA)
        Me.fraDua.Controls.Add(Me.txtFec_NumeracionDua)
        Me.fraDua.Controls.Add(Me.txtFec_EmbarqueReal)
        Me.fraDua.Controls.Add(Me.txtNum_Dua)
        Me.fraDua.Controls.Add(Me.Label34)
        Me.fraDua.Controls.Add(Me.Label31)
        Me.fraDua.Controls.Add(Me.Label33)
        Me.fraDua.Controls.Add(Me.Label32)
        Me.fraDua.Controls.Add(Me.Label30)
        Me.fraDua.Enabled = False
        Me.fraDua.Location = New System.Drawing.Point(7, 399)
        Me.fraDua.Name = "fraDua"
        Me.fraDua.Size = New System.Drawing.Size(968, 63)
        Me.fraDua.TabIndex = 0
        Me.fraDua.Text = "Número DUA"
        Me.fraDua.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtEntregaDrauBack
        '
        Me.txtEntregaDrauBack.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEntregaDrauBack.Location = New System.Drawing.Point(796, 16)
        Me.txtEntregaDrauBack.Name = "txtEntregaDrauBack"
        Me.txtEntregaDrauBack.Size = New System.Drawing.Size(137, 20)
        Me.txtEntregaDrauBack.TabIndex = 0
        '
        'txtFec_RecepcionDUA
        '
        Me.txtFec_RecepcionDUA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_RecepcionDUA.Location = New System.Drawing.Point(445, 38)
        Me.txtFec_RecepcionDUA.Name = "txtFec_RecepcionDUA"
        Me.txtFec_RecepcionDUA.Size = New System.Drawing.Size(131, 20)
        Me.txtFec_RecepcionDUA.TabIndex = 8
        '
        'txtFec_NumeracionDua
        '
        Me.txtFec_NumeracionDua.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_NumeracionDua.Location = New System.Drawing.Point(103, 38)
        Me.txtFec_NumeracionDua.Name = "txtFec_NumeracionDua"
        Me.txtFec_NumeracionDua.Size = New System.Drawing.Size(178, 20)
        Me.txtFec_NumeracionDua.TabIndex = 6
        '
        'txtFec_EmbarqueReal
        '
        Me.txtFec_EmbarqueReal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_EmbarqueReal.Location = New System.Drawing.Point(445, 16)
        Me.txtFec_EmbarqueReal.Name = "txtFec_EmbarqueReal"
        Me.txtFec_EmbarqueReal.Size = New System.Drawing.Size(131, 20)
        Me.txtFec_EmbarqueReal.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(319, 23)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(125, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Fecha Real Embarque...."
        '
        'txtNum_Dua
        '
        Me.txtNum_Dua.Location = New System.Drawing.Point(103, 16)
        Me.txtNum_Dua.Name = "txtNum_Dua"
        Me.txtNum_Dua.Size = New System.Drawing.Size(178, 20)
        Me.txtNum_Dua.TabIndex = 2
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(7, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(82, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Número DUA...."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(603, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(204, 13)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Fecha Entrega Tramite Draw Back..........."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(320, 45)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 13)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Fecha Recepción..........."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 45)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(118, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Fecha Numeracion......."
        '
        'fraAgenteCarga
        '
        Me.fraAgenteCarga.Controls.Add(Me.txtObs_EnvioInstruccionesalAgenteCarga)
        Me.fraAgenteCarga.Controls.Add(Me.txtFec_EnvioInstruccionesalAgenteCarga)
        Me.fraAgenteCarga.Controls.Add(Me.Label27)
        Me.fraAgenteCarga.Controls.Add(Me.Label29)
        Me.fraAgenteCarga.Enabled = False
        Me.fraAgenteCarga.Location = New System.Drawing.Point(494, 319)
        Me.fraAgenteCarga.Name = "fraAgenteCarga"
        Me.fraAgenteCarga.Size = New System.Drawing.Size(482, 78)
        Me.fraAgenteCarga.TabIndex = 41
        Me.fraAgenteCarga.Text = "Envio Instrucciones al Agente de Carga"
        Me.fraAgenteCarga.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtObs_EnvioInstruccionesalAgenteCarga
        '
        Me.txtObs_EnvioInstruccionesalAgenteCarga.Location = New System.Drawing.Point(103, 42)
        Me.txtObs_EnvioInstruccionesalAgenteCarga.Multiline = True
        Me.txtObs_EnvioInstruccionesalAgenteCarga.Name = "txtObs_EnvioInstruccionesalAgenteCarga"
        Me.txtObs_EnvioInstruccionesalAgenteCarga.Size = New System.Drawing.Size(369, 32)
        Me.txtObs_EnvioInstruccionesalAgenteCarga.TabIndex = 3
        '
        'txtFec_EnvioInstruccionesalAgenteCarga
        '
        Me.txtFec_EnvioInstruccionesalAgenteCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_EnvioInstruccionesalAgenteCarga.Location = New System.Drawing.Point(103, 19)
        Me.txtFec_EnvioInstruccionesalAgenteCarga.Name = "txtFec_EnvioInstruccionesalAgenteCarga"
        Me.txtFec_EnvioInstruccionesalAgenteCarga.Size = New System.Drawing.Size(101, 20)
        Me.txtFec_EnvioInstruccionesalAgenteCarga.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Observaciones.............."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 26)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(109, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Fecha Envio.............."
        '
        'fraEnvioAgenteAduanas
        '
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.txtObs_EnvioInstruccionesalAgenteAduanas)
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.txtFec_EnvioFacturaalAgenteAduanas)
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.txtFec_EnvioInstruccionesalAgenteAduana)
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.Label24)
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.Label25)
        Me.fraEnvioAgenteAduanas.Controls.Add(Me.Label26)
        Me.fraEnvioAgenteAduanas.Enabled = False
        Me.fraEnvioAgenteAduanas.Location = New System.Drawing.Point(7, 319)
        Me.fraEnvioAgenteAduanas.Name = "fraEnvioAgenteAduanas"
        Me.fraEnvioAgenteAduanas.Size = New System.Drawing.Size(482, 78)
        Me.fraEnvioAgenteAduanas.TabIndex = 40
        Me.fraEnvioAgenteAduanas.Text = "Envio Instrucciones al Agente de Aduana"
        Me.fraEnvioAgenteAduanas.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtObs_EnvioInstruccionesalAgenteAduanas
        '
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Location = New System.Drawing.Point(103, 42)
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Multiline = True
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Name = "txtObs_EnvioInstruccionesalAgenteAduanas"
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.Size = New System.Drawing.Size(369, 32)
        Me.txtObs_EnvioInstruccionesalAgenteAduanas.TabIndex = 5
        '
        'txtFec_EnvioFacturaalAgenteAduanas
        '
        Me.txtFec_EnvioFacturaalAgenteAduanas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_EnvioFacturaalAgenteAduanas.Location = New System.Drawing.Point(337, 19)
        Me.txtFec_EnvioFacturaalAgenteAduanas.Name = "txtFec_EnvioFacturaalAgenteAduanas"
        Me.txtFec_EnvioFacturaalAgenteAduanas.Size = New System.Drawing.Size(101, 20)
        Me.txtFec_EnvioFacturaalAgenteAduanas.TabIndex = 3
        '
        'txtFec_EnvioInstruccionesalAgenteAduana
        '
        Me.txtFec_EnvioInstruccionesalAgenteAduana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFec_EnvioInstruccionesalAgenteAduana.Location = New System.Drawing.Point(103, 19)
        Me.txtFec_EnvioInstruccionesalAgenteAduana.Name = "txtFec_EnvioInstruccionesalAgenteAduana"
        Me.txtFec_EnvioInstruccionesalAgenteAduana.Size = New System.Drawing.Size(101, 20)
        Me.txtFec_EnvioInstruccionesalAgenteAduana.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(220, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Fecha Envio Factura......"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Fecha Envio.............."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Observaciones.............."
        '
        'txtNumCarCre
        '
        Me.txtNumCarCre.Location = New System.Drawing.Point(651, 291)
        Me.txtNumCarCre.Name = "txtNumCarCre"
        Me.txtNumCarCre.Size = New System.Drawing.Size(310, 20)
        Me.txtNumCarCre.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(535, 298)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 13)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Num Carta Credito.............."
        '
        'TxtDesConPago
        '
        Me.TxtDesConPago.Location = New System.Drawing.Point(190, 291)
        Me.TxtDesConPago.Name = "TxtDesConPago"
        Me.TxtDesConPago.Size = New System.Drawing.Size(253, 20)
        Me.TxtDesConPago.TabIndex = 37
        '
        'TxtCodConPago
        '
        Me.TxtCodConPago.Location = New System.Drawing.Point(109, 291)
        Me.TxtCodConPago.Name = "TxtCodConPago"
        Me.TxtCodConPago.Size = New System.Drawing.Size(78, 20)
        Me.TxtCodConPago.TabIndex = 36
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 298)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Condicion Pago.............."
        '
        'txtDes_Termino_Venta
        '
        Me.txtDes_Termino_Venta.Location = New System.Drawing.Point(724, 269)
        Me.txtDes_Termino_Venta.Name = "txtDes_Termino_Venta"
        Me.txtDes_Termino_Venta.Size = New System.Drawing.Size(237, 20)
        Me.txtDes_Termino_Venta.TabIndex = 33
        '
        'txtCod_Termino_Venta
        '
        Me.txtCod_Termino_Venta.Location = New System.Drawing.Point(651, 269)
        Me.txtCod_Termino_Venta.Name = "txtCod_Termino_Venta"
        Me.txtCod_Termino_Venta.Size = New System.Drawing.Size(71, 20)
        Me.txtCod_Termino_Venta.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(535, 276)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Termino Venta.............."
        '
        'txtDes_Flete_Ingles
        '
        Me.txtDes_Flete_Ingles.Location = New System.Drawing.Point(190, 269)
        Me.txtDes_Flete_Ingles.Name = "txtDes_Flete_Ingles"
        Me.txtDes_Flete_Ingles.Size = New System.Drawing.Size(253, 20)
        Me.txtDes_Flete_Ingles.TabIndex = 28
        '
        'txtCod_Flete
        '
        Me.txtCod_Flete.Location = New System.Drawing.Point(109, 269)
        Me.txtCod_Flete.Name = "txtCod_Flete"
        Me.txtCod_Flete.Size = New System.Drawing.Size(78, 20)
        Me.txtCod_Flete.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Tipo Flete.............."
        '
        'txtObs_Embarque
        '
        Me.txtObs_Embarque.Location = New System.Drawing.Point(109, 236)
        Me.txtObs_Embarque.Multiline = True
        Me.txtObs_Embarque.Name = "txtObs_Embarque"
        Me.txtObs_Embarque.Size = New System.Drawing.Size(852, 31)
        Me.txtObs_Embarque.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(14, 239)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 32)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Resumen de embarque.............."
        '
        'btnAgenteAduana
        '
        Me.btnAgenteAduana.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenteAduana.Image = CType(resources.GetObject("btnAgenteAduana.Image"), System.Drawing.Image)
        Me.btnAgenteAduana.ImageIndex = 12
        Me.btnAgenteAduana.Location = New System.Drawing.Point(447, 214)
        Me.btnAgenteAduana.Name = "btnAgenteAduana"
        Me.btnAgenteAduana.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnAgenteAduana.Size = New System.Drawing.Size(23, 19)
        Me.btnAgenteAduana.TabIndex = 21
        Me.btnAgenteAduana.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtNom_AgenteAduana
        '
        Me.txtNom_AgenteAduana.Location = New System.Drawing.Point(190, 213)
        Me.txtNom_AgenteAduana.Name = "txtNom_AgenteAduana"
        Me.txtNom_AgenteAduana.Size = New System.Drawing.Size(253, 20)
        Me.txtNom_AgenteAduana.TabIndex = 20
        '
        'txtCod_AgenteAduana
        '
        Me.txtCod_AgenteAduana.Location = New System.Drawing.Point(109, 213)
        Me.txtCod_AgenteAduana.Name = "txtCod_AgenteAduana"
        Me.txtCod_AgenteAduana.Size = New System.Drawing.Size(78, 20)
        Me.txtCod_AgenteAduana.TabIndex = 19
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.btnEjecutivoAgenteCarga)
        Me.UiGroupBox3.Controls.Add(Me.btnAgenteCarga)
        Me.UiGroupBox3.Controls.Add(Me.txtNom_Ejecutivo)
        Me.UiGroupBox3.Controls.Add(Me.txtCod_Ejecutivo_AgenteCarga)
        Me.UiGroupBox3.Controls.Add(Me.txtDes_AgenteCarga)
        Me.UiGroupBox3.Controls.Add(Me.txtCod_AgenteCarga)
        Me.UiGroupBox3.Controls.Add(Me.Label19)
        Me.UiGroupBox3.Controls.Add(Me.Label20)
        Me.UiGroupBox3.Location = New System.Drawing.Point(7, 168)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(968, 41)
        Me.UiGroupBox3.TabIndex = 17
        Me.UiGroupBox3.Text = "Datos de Carga"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'btnEjecutivoAgenteCarga
        '
        Me.btnEjecutivoAgenteCarga.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutivoAgenteCarga.Image = CType(resources.GetObject("btnEjecutivoAgenteCarga.Image"), System.Drawing.Image)
        Me.btnEjecutivoAgenteCarga.ImageIndex = 12
        Me.btnEjecutivoAgenteCarga.Location = New System.Drawing.Point(936, 18)
        Me.btnEjecutivoAgenteCarga.Name = "btnEjecutivoAgenteCarga"
        Me.btnEjecutivoAgenteCarga.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnEjecutivoAgenteCarga.Size = New System.Drawing.Size(23, 20)
        Me.btnEjecutivoAgenteCarga.TabIndex = 0
        Me.btnEjecutivoAgenteCarga.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'btnAgenteCarga
        '
        Me.btnAgenteCarga.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenteCarga.Image = CType(resources.GetObject("btnAgenteCarga.Image"), System.Drawing.Image)
        Me.btnAgenteCarga.ImageIndex = 12
        Me.btnAgenteCarga.Location = New System.Drawing.Point(440, 18)
        Me.btnAgenteCarga.Name = "btnAgenteCarga"
        Me.btnAgenteCarga.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnAgenteCarga.Size = New System.Drawing.Size(23, 19)
        Me.btnAgenteCarga.TabIndex = 4
        Me.btnAgenteCarga.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtNom_Ejecutivo
        '
        Me.txtNom_Ejecutivo.Location = New System.Drawing.Point(717, 17)
        Me.txtNom_Ejecutivo.Name = "txtNom_Ejecutivo"
        Me.txtNom_Ejecutivo.Size = New System.Drawing.Size(215, 20)
        Me.txtNom_Ejecutivo.TabIndex = 7
        '
        'txtCod_Ejecutivo_AgenteCarga
        '
        Me.txtCod_Ejecutivo_AgenteCarga.Location = New System.Drawing.Point(644, 17)
        Me.txtCod_Ejecutivo_AgenteCarga.Name = "txtCod_Ejecutivo_AgenteCarga"
        Me.txtCod_Ejecutivo_AgenteCarga.Size = New System.Drawing.Size(71, 20)
        Me.txtCod_Ejecutivo_AgenteCarga.TabIndex = 6
        '
        'txtDes_AgenteCarga
        '
        Me.txtDes_AgenteCarga.Location = New System.Drawing.Point(183, 17)
        Me.txtDes_AgenteCarga.Name = "txtDes_AgenteCarga"
        Me.txtDes_AgenteCarga.Size = New System.Drawing.Size(253, 20)
        Me.txtDes_AgenteCarga.TabIndex = 3
        '
        'txtCod_AgenteCarga
        '
        Me.txtCod_AgenteCarga.Location = New System.Drawing.Point(102, 17)
        Me.txtCod_AgenteCarga.Name = "txtCod_AgenteCarga"
        Me.txtCod_AgenteCarga.Size = New System.Drawing.Size(78, 20)
        Me.txtCod_AgenteCarga.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(521, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(131, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Ejecutivo Agente Carga...."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Agente Carga.............."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Agente Aduana.............."
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.btnNave)
        Me.UiGroupBox2.Controls.Add(Me.TxtDesNave)
        Me.UiGroupBox2.Controls.Add(Me.TxtCodNave)
        Me.UiGroupBox2.Controls.Add(Me.Label15)
        Me.UiGroupBox2.Controls.Add(Me.txtDes_TipEmbarque)
        Me.UiGroupBox2.Controls.Add(Me.txtTip_Embarque)
        Me.UiGroupBox2.Controls.Add(Me.btnMantenimientoNaviera)
        Me.UiGroupBox2.Controls.Add(Me.TxtDesNaviera)
        Me.UiGroupBox2.Controls.Add(Me.TxtCodNaviera)
        Me.UiGroupBox2.Controls.Add(Me.Label13)
        Me.UiGroupBox2.Controls.Add(Me.BtnBuscar)
        Me.UiGroupBox2.Controls.Add(Me.txtNom_Embarque)
        Me.UiGroupBox2.Controls.Add(Me.Label12)
        Me.UiGroupBox2.Controls.Add(Me.txtDes_Embarque)
        Me.UiGroupBox2.Controls.Add(Me.txtCod_Embarque)
        Me.UiGroupBox2.Controls.Add(Me.Label11)
        Me.UiGroupBox2.Controls.Add(Me.Label14)
        Me.UiGroupBox2.Location = New System.Drawing.Point(7, 101)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(968, 64)
        Me.UiGroupBox2.TabIndex = 15
        Me.UiGroupBox2.Text = "Datos de Embarque"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'btnNave
        '
        Me.btnNave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNave.Image = CType(resources.GetObject("btnNave.Image"), System.Drawing.Image)
        Me.btnNave.ImageIndex = 12
        Me.btnNave.Location = New System.Drawing.Point(936, 40)
        Me.btnNave.Name = "btnNave"
        Me.btnNave.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnNave.Size = New System.Drawing.Size(23, 20)
        Me.btnNave.TabIndex = 16
        Me.btnNave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'TxtDesNave
        '
        Me.TxtDesNave.Location = New System.Drawing.Point(776, 40)
        Me.TxtDesNave.Name = "TxtDesNave"
        Me.TxtDesNave.Size = New System.Drawing.Size(156, 20)
        Me.TxtDesNave.TabIndex = 15
        '
        'TxtCodNave
        '
        Me.TxtCodNave.Location = New System.Drawing.Point(726, 40)
        Me.TxtCodNave.Name = "TxtCodNave"
        Me.TxtCodNave.Size = New System.Drawing.Size(48, 20)
        Me.TxtCodNave.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(672, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Nave..........."
        '
        'txtDes_TipEmbarque
        '
        Me.txtDes_TipEmbarque.Location = New System.Drawing.Point(153, 40)
        Me.txtDes_TipEmbarque.Name = "txtDes_TipEmbarque"
        Me.txtDes_TipEmbarque.Size = New System.Drawing.Size(128, 20)
        Me.txtDes_TipEmbarque.TabIndex = 12
        '
        'txtTip_Embarque
        '
        Me.txtTip_Embarque.Location = New System.Drawing.Point(102, 40)
        Me.txtTip_Embarque.Name = "txtTip_Embarque"
        Me.txtTip_Embarque.Size = New System.Drawing.Size(48, 20)
        Me.txtTip_Embarque.TabIndex = 11
        '
        'btnMantenimientoNaviera
        '
        Me.btnMantenimientoNaviera.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimientoNaviera.Image = CType(resources.GetObject("btnMantenimientoNaviera.Image"), System.Drawing.Image)
        Me.btnMantenimientoNaviera.ImageIndex = 12
        Me.btnMantenimientoNaviera.Location = New System.Drawing.Point(936, 18)
        Me.btnMantenimientoNaviera.Name = "btnMantenimientoNaviera"
        Me.btnMantenimientoNaviera.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnMantenimientoNaviera.Size = New System.Drawing.Size(23, 20)
        Me.btnMantenimientoNaviera.TabIndex = 9
        Me.btnMantenimientoNaviera.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'TxtDesNaviera
        '
        Me.TxtDesNaviera.Location = New System.Drawing.Point(776, 18)
        Me.TxtDesNaviera.Name = "TxtDesNaviera"
        Me.TxtDesNaviera.Size = New System.Drawing.Size(156, 20)
        Me.TxtDesNaviera.TabIndex = 8
        '
        'TxtCodNaviera
        '
        Me.TxtCodNaviera.Location = New System.Drawing.Point(726, 18)
        Me.TxtCodNaviera.Name = "TxtCodNaviera"
        Me.TxtCodNaviera.Size = New System.Drawing.Size(48, 20)
        Me.TxtCodNaviera.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(672, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Naviera...."
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.Ge_Ventas.My.Resources.Resources.ic_table_header_edit_48x48
        Me.BtnBuscar.ImageIndex = 12
        Me.BtnBuscar.Location = New System.Drawing.Point(285, 19)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(23, 19)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtNom_Embarque
        '
        Me.txtNom_Embarque.Location = New System.Drawing.Point(437, 18)
        Me.txtNom_Embarque.Name = "txtNom_Embarque"
        Me.txtNom_Embarque.Size = New System.Drawing.Size(208, 20)
        Me.txtNom_Embarque.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Nombre Embarque...."
        '
        'txtDes_Embarque
        '
        Me.txtDes_Embarque.Location = New System.Drawing.Point(153, 18)
        Me.txtDes_Embarque.Name = "txtDes_Embarque"
        Me.txtDes_Embarque.Size = New System.Drawing.Size(128, 20)
        Me.txtDes_Embarque.TabIndex = 2
        '
        'txtCod_Embarque
        '
        Me.txtCod_Embarque.Location = New System.Drawing.Point(102, 18)
        Me.txtCod_Embarque.Name = "txtCod_Embarque"
        Me.txtCod_Embarque.Size = New System.Drawing.Size(48, 20)
        Me.txtCod_Embarque.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Modo Embarque...."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Tipo Embarque......."
        '
        'TxtCodLocacion
        '
        Me.TxtCodLocacion.Location = New System.Drawing.Point(398, 73)
        Me.TxtCodLocacion.Name = "TxtCodLocacion"
        Me.TxtCodLocacion.Size = New System.Drawing.Size(33, 20)
        Me.TxtCodLocacion.TabIndex = 13
        '
        'TxtDesLocacion
        '
        Me.TxtDesLocacion.Location = New System.Drawing.Point(434, 73)
        Me.TxtDesLocacion.Name = "TxtDesLocacion"
        Me.TxtDesLocacion.Size = New System.Drawing.Size(218, 20)
        Me.TxtDesLocacion.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(340, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Locacion...."
        '
        'Cbo_Destino
        '
        Me.Cbo_Destino.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.Cbo_Destino.Location = New System.Drawing.Point(65, 73)
        Me.Cbo_Destino.Name = "Cbo_Destino"
        Me.Cbo_Destino.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.Cbo_Destino.Size = New System.Drawing.Size(225, 20)
        Me.Cbo_Destino.TabIndex = 11
        Me.Cbo_Destino.Text = "============SELECT==========="
        Me.Cbo_Destino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtRef_Embarque
        '
        Me.txtRef_Embarque.Location = New System.Drawing.Point(742, 51)
        Me.txtRef_Embarque.Name = "txtRef_Embarque"
        Me.txtRef_Embarque.Size = New System.Drawing.Size(197, 20)
        Me.txtRef_Embarque.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(677, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Referencia...."
        '
        'txtCod_Anxo
        '
        Me.txtCod_Anxo.Location = New System.Drawing.Point(422, 51)
        Me.txtCod_Anxo.Name = "txtCod_Anxo"
        Me.txtCod_Anxo.Size = New System.Drawing.Size(33, 20)
        Me.txtCod_Anxo.TabIndex = 6
        '
        'txtDes_Anexo
        '
        Me.txtDes_Anexo.Location = New System.Drawing.Point(458, 51)
        Me.txtDes_Anexo.Name = "txtDes_Anexo"
        Me.txtDes_Anexo.Size = New System.Drawing.Size(194, 20)
        Me.txtDes_Anexo.TabIndex = 7
        '
        'txtCod_TipAnex
        '
        Me.txtCod_TipAnex.Enabled = False
        Me.txtCod_TipAnex.Location = New System.Drawing.Point(398, 51)
        Me.txtCod_TipAnex.Name = "txtCod_TipAnex"
        Me.txtCod_TipAnex.Size = New System.Drawing.Size(22, 20)
        Me.txtCod_TipAnex.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Anexo........"
        '
        'txtNom_Cliente
        '
        Me.txtNom_Cliente.Location = New System.Drawing.Point(115, 51)
        Me.txtNom_Cliente.Name = "txtNom_Cliente"
        Me.txtNom_Cliente.Size = New System.Drawing.Size(175, 20)
        Me.txtNom_Cliente.TabIndex = 3
        '
        'txtAbr_Cliente
        '
        Me.txtAbr_Cliente.Location = New System.Drawing.Point(65, 51)
        Me.txtAbr_Cliente.Name = "txtAbr_Cliente"
        Me.txtAbr_Cliente.Size = New System.Drawing.Size(48, 20)
        Me.txtAbr_Cliente.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cliente...."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 45)
        Me.Panel2.TabIndex = 0
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.cboMeses)
        Me.UiGroupBox1.Controls.Add(Me.txtAno)
        Me.UiGroupBox1.Controls.Add(Me.txtDes_Origen)
        Me.UiGroupBox1.Controls.Add(Me.txtCod_Origen)
        Me.UiGroupBox1.Controls.Add(Me.Cbo_TipoEmb)
        Me.UiGroupBox1.Controls.Add(Me.txtDes_Estado)
        Me.UiGroupBox1.Controls.Add(Me.txtFlg_Status)
        Me.UiGroupBox1.Controls.Add(Me.txtNum_Embarque)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(969, 35)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'cboMeses
        '
        Me.cboMeses.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboMeses.Location = New System.Drawing.Point(834, 11)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cboMeses.Size = New System.Drawing.Size(115, 20)
        Me.cboMeses.TabIndex = 12
        Me.cboMeses.Text = "===MESES==="
        Me.cboMeses.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(776, 11)
        Me.txtAno.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtAno.Minimum = New Decimal(New Integer() {2015, 0, 0, 0})
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(54, 20)
        Me.txtAno.TabIndex = 11
        Me.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAno.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'txtDes_Origen
        '
        Me.txtDes_Origen.Location = New System.Drawing.Point(617, 11)
        Me.txtDes_Origen.Name = "txtDes_Origen"
        Me.txtDes_Origen.Size = New System.Drawing.Size(90, 20)
        Me.txtDes_Origen.TabIndex = 9
        '
        'txtCod_Origen
        '
        Me.txtCod_Origen.Location = New System.Drawing.Point(566, 11)
        Me.txtCod_Origen.Name = "txtCod_Origen"
        Me.txtCod_Origen.Size = New System.Drawing.Size(48, 20)
        Me.txtCod_Origen.TabIndex = 8
        '
        'Cbo_TipoEmb
        '
        Me.Cbo_TipoEmb.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.Cbo_TipoEmb.Location = New System.Drawing.Point(369, 11)
        Me.Cbo_TipoEmb.Name = "Cbo_TipoEmb"
        Me.Cbo_TipoEmb.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.Cbo_TipoEmb.Size = New System.Drawing.Size(134, 20)
        Me.Cbo_TipoEmb.TabIndex = 6
        Me.Cbo_TipoEmb.Text = "==SELECT=="
        Me.Cbo_TipoEmb.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtDes_Estado
        '
        Me.txtDes_Estado.Enabled = False
        Me.txtDes_Estado.Location = New System.Drawing.Point(229, 11)
        Me.txtDes_Estado.Name = "txtDes_Estado"
        Me.txtDes_Estado.Size = New System.Drawing.Size(90, 20)
        Me.txtDes_Estado.TabIndex = 4
        '
        'txtFlg_Status
        '
        Me.txtFlg_Status.Enabled = False
        Me.txtFlg_Status.Location = New System.Drawing.Point(202, 11)
        Me.txtFlg_Status.Name = "txtFlg_Status"
        Me.txtFlg_Status.Size = New System.Drawing.Size(26, 20)
        Me.txtFlg_Status.TabIndex = 3
        '
        'txtNum_Embarque
        '
        Me.txtNum_Embarque.Enabled = False
        Me.txtNum_Embarque.Location = New System.Drawing.Point(59, 11)
        Me.txtNum_Embarque.Name = "txtNum_Embarque"
        Me.txtNum_Embarque.Size = New System.Drawing.Size(71, 20)
        Me.txtNum_Embarque.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(733, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pedido...."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Origen...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado...."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo......."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Destino...."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 468)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(984, 30)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnCancelar)
        Me.Panel5.Controls.Add(Me.BtnAceptar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(777, 0)
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
        'FrmTgEmbarque_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 498)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTgEmbarque_Add"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Embarque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fraDua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDua.ResumeLayout(False)
        Me.fraDua.PerformLayout()
        CType(Me.fraAgenteCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAgenteCarga.ResumeLayout(False)
        Me.fraAgenteCarga.PerformLayout()
        CType(Me.fraEnvioAgenteAduanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraEnvioAgenteAduanas.ResumeLayout(False)
        Me.fraEnvioAgenteAduanas.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.txtAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFlg_Status As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum_Embarque As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDes_Estado As TextBox
    Friend WithEvents txtDes_Origen As TextBox
    Friend WithEvents txtCod_Origen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbo_TipoEmb As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAbr_Cliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDes_Anexo As TextBox
    Friend WithEvents txtCod_TipAnex As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNom_Cliente As TextBox
    Friend WithEvents txtRef_Embarque As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCod_Anxo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDes_Embarque As TextBox
    Friend WithEvents txtCod_Embarque As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents TxtCodLocacion As TextBox
    Friend WithEvents TxtDesLocacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cbo_Destino As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNom_Embarque As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtDesNaviera As TextBox
    Friend WithEvents TxtCodNaviera As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDes_TipEmbarque As TextBox
    Friend WithEvents txtTip_Embarque As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnMantenimientoNaviera As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtDesNave As TextBox
    Friend WithEvents TxtCodNave As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnEjecutivoAgenteCarga As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgenteCarga As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNom_Ejecutivo As TextBox
    Friend WithEvents txtCod_Ejecutivo_AgenteCarga As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtDes_AgenteCarga As TextBox
    Friend WithEvents txtCod_AgenteCarga As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnAgenteAduana As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNom_AgenteAduana As TextBox
    Friend WithEvents txtCod_AgenteAduana As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtObs_Embarque As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDes_Flete_Ingles As TextBox
    Friend WithEvents txtCod_Flete As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDes_Termino_Venta As TextBox
    Friend WithEvents txtCod_Termino_Venta As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNumCarCre As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtDesConPago As TextBox
    Friend WithEvents TxtCodConPago As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents fraEnvioAgenteAduanas As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtFec_EnvioFacturaalAgenteAduanas As DateTimePicker
    Friend WithEvents txtFec_EnvioInstruccionesalAgenteAduana As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents txtObs_EnvioInstruccionesalAgenteAduanas As TextBox
    Friend WithEvents fraAgenteCarga As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtObs_EnvioInstruccionesalAgenteCarga As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtFec_EnvioInstruccionesalAgenteCarga As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents fraDua As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFec_NumeracionDua As DateTimePicker
    Friend WithEvents txtFec_EmbarqueReal As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtNum_Dua As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtEntregaDrauBack As DateTimePicker
    Friend WithEvents Label32 As Label
    Friend WithEvents txtFec_RecepcionDUA As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAno As NumericUpDown
    Friend WithEvents cboMeses As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnNave As Janus.Windows.EditControls.UIButton
End Class
