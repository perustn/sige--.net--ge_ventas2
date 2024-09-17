Public Class FrmTgEmbarque_Add
    Private oHP As New clsHELPER
    Private strSQL As String = String.Empty

    Public sAccion As String
    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Public sCod_Cliente As String = String.Empty
    Dim sConsultaLlenaCombo As String
    Private Eventos_Parametrizables_Locaciones_307 As String
    Private sFlg_Courier_Carga As String

    'VARIABLE PARA ALMACENAR EL EMBARQUE QUE SE ACABA DE CREAR
    Public sNum_Embarque, sConMod, sRef_Embarque As String
    Public sCod_AlmacenAduana, sNom_AlmacenAduana As String
    Private colEmpresa As Color
    Public sMes, sTipoEmbarque, sDestino As String

    Private Sub FrmTgEmbarque_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        CargaMeses()

        If sAccion = "I" Then
            txtCod_TipAnex.Text = oHP.DevuelveDato("SELECT Prefijo_Anexo_Ventas_Exportacion FROM cn_control ", cCONNECT)
            txtCod_Origen.Text = "7"
            txtDes_Origen.Text = oHP.DevuelveDato("select Descripcion from CN_Ventas_Origen_Factura where Cod_Origen = '" & txtCod_Origen.Text & "'", cCONNECT)
            txtAno.Value = Now.Year
            cboMeses.SelectedValue = CInt(Now.Month)
        End If

        FillTipoEmb()

        If sAccion <> "I" Then
            FillDestinoxCliente()
            cboMeses.SelectedValue = sMes
            Cbo_TipoEmb.SelectedValue = sTipoEmbarque
            Cbo_Destino.SelectedValue = sDestino
        End If

        Eventos_Parametrizables_Locaciones_307 = oHP.DevuelveDato("select dbo.sm_valida_Tg_Eventos_Parametrizables(307)", cCONNECT)

        If Eventos_Parametrizables_Locaciones_307 = "S" Then
            TxtCodLocacion.Enabled = True
            TxtDesLocacion.Enabled = True
        Else
            TxtCodLocacion.Enabled = False
            TxtDesLocacion.Enabled = False
        End If
    End Sub

    Public Sub CargaMeses()
        sConsultaLlenaCombo = "CF_CARGA_LG_MESES"
        LlenaComboNET(cboMeses, sConsultaLlenaCombo, cCONNECT)
    End Sub

    Public Sub FillTipoEmb()
        sConsultaLlenaCombo = "Ventas_Ayuda_Tipo_Embarque"
        Call LlenaComboNET(Cbo_TipoEmb, sConsultaLlenaCombo, cCONNECT)
    End Sub

    Public Sub FillDestinoxCliente()
        sConsultaLlenaCombo = "Ventas_Ayuda_DestinoxCliente_BASE '" & sCod_Cliente & "'"
        Call LlenaComboNET(Cbo_Destino, sConsultaLlenaCombo, cCONNECT)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCod_Origen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Origen.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaOrigen(1)
        End If
    End Sub

    Private Sub txtDes_Origen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Origen.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaOrigen(2)
        End If
    End Sub

    Private Sub BuscaOrigen(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_CN_VENTAS_ORIGEN_FACTURA '" & sTipo & "','" & Trim(txtCod_Origen.Text) & "','" & Trim(txtDes_Origen.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Origen.Text = oTipo.dtResultados.Rows(0)("CODIGO")
            txtDes_Origen.Text = oTipo.dtResultados.Rows(0)("DESCRIPCION")
            txtAbr_Cliente.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("CODIGO").Width = 100
        oTipo.DGridLista.RootTable.Columns("DESCRIPCION").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Origen.Text = Trim(Codigo)
            txtDes_Origen.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtAbr_Cliente.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtNom_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCliente(2)
        End If
    End Sub

    Private Sub txtAbr_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbr_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCliente(1)
        End If
    End Sub

    Private Sub BuscaCliente(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "cf_ayuda_TG_CLIENTE '" & sTipo & "','" & Trim(txtAbr_Cliente.Text) & "','" & Trim(txtNom_Cliente.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            sCod_Cliente = oTipo.dtResultados.Rows(0)("CODIGO")
            txtAbr_Cliente.Text = oTipo.dtResultados.Rows(0)("ABR_CLIENTE")
            txtNom_Cliente.Text = oTipo.dtResultados.Rows(0)("NOMBRE_CLIENTE")

            GoTo Fin
        End If

        oTipo.DGridLista.RootTable.Columns("CODIGO").Width = 60
        oTipo.DGridLista.RootTable.Columns("ABR_CLIENTE").Width = 90
        oTipo.DGridLista.RootTable.Columns("NOMBRE_CLIENTE").Width = 250
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            sCod_Cliente = Trim(Codigo)
            txtAbr_Cliente.Text = Trim(Descripcion)
            txtNom_Cliente.Text = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
        End If
        oTipo = Nothing

Fin:
        FillDestinoxCliente()
        txtCod_Anxo.Select()
    End Sub

    Private Sub txtCod_Anxo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Anxo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAnexo(1)
        End If
    End Sub

    Private Sub txtDes_Anexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Anexo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAnexo(2)
        End If
    End Sub

    Private Sub BuscaAnexo(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "TG_MUESTRA_ANEXOS_CONT_CLIENTE '" & txtAbr_Cliente.Text & "','" & Trim(txtCod_Anxo.Text) & "','" & Trim(txtDes_Anexo.Text) & "','" & sTipo & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Anxo.Text = oTipo.dtResultados.Rows(0)("COD_ANXO")
            txtDes_Anexo.Text = oTipo.dtResultados.Rows(0)("DES_ANEXO")
            txtCod_TipAnex.Text = oTipo.dtResultados.Rows(0)("COD_TIPANEX")
            txtRef_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("COD_CLIENTE").Visible = False
        oTipo.DGridLista.RootTable.Columns("PIE_FACTURA1").Visible = False
        oTipo.DGridLista.RootTable.Columns("PIE_FACTURA2").Visible = False

        oTipo.DGridLista.RootTable.Columns("COD_ANXO").Width = 90
        oTipo.DGridLista.RootTable.Columns("DES_ANEXO").Width = 100
        oTipo.DGridLista.RootTable.Columns("COD_TIPANEX").Width = 100
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Anxo.Text = Trim(Codigo)
            txtDes_Anexo.Text = Trim(Descripcion)
            txtCod_TipAnex.Text = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
            txtRef_Embarque.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtRef_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRef_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtCodLocacion.Select()
        End If
    End Sub

    Private Sub TxtCodLocacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodLocacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaLocacion()
        End If
    End Sub

    Private Sub TxtDesLocacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesLocacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaLocacion()
        End If
    End Sub

    Private Sub BuscaLocacion()
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        If Cbo_Destino.Text.Trim = "" Then
            MessageBox.Show("Debe Seleccionar un destino", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cbo_Destino.Select()
            Exit Sub
        End If

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "SM_MUESTRA_LOCACIONES_CLIENTE '" & sCod_Cliente & "','" & Cbo_Destino.SelectedValue & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            TxtCodLocacion.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("Cod_Locacion")), "", oTipo.dtResultados.Rows(0)("Cod_Locacion"))
            TxtDesLocacion.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("Locacion")), "", oTipo.dtResultados.Rows(0)("Locacion"))
            TxtCodConPago.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("cod_condvent")), "", oTipo.dtResultados.Rows(0)("cod_condvent"))
            TxtDesConPago.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("des_condvent")), "", oTipo.dtResultados.Rows(0)("des_condvent"))
            txtCod_Termino_Venta.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("cod_pagemb")), "", oTipo.dtResultados.Rows(0)("cod_pagemb"))
            txtDes_Termino_Venta.Text = IIf(IsDBNull(oTipo.dtResultados.Rows(0)("Des_PagEmb")), "", oTipo.dtResultados.Rows(0)("Des_PagEmb"))
            txtCod_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("Cod_Locacion").Width = 60
        oTipo.DGridLista.RootTable.Columns("Cod_Locacion").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        oTipo.DGridLista.RootTable.Columns("Cod_Locacion").Caption = "COD"
        oTipo.DGridLista.RootTable.Columns("Locacion").Width = 150
        oTipo.DGridLista.RootTable.Columns("cod_condvent").Width = 60
        oTipo.DGridLista.RootTable.Columns("cod_condvent").Caption = "COD CONDVENT"
        oTipo.DGridLista.RootTable.Columns("des_condvent").Width = 120
        oTipo.DGridLista.RootTable.Columns("cod_pagemb").Width = 80
        oTipo.DGridLista.RootTable.Columns("cod_pagemb").Caption = "COD PAGEMB"
        oTipo.DGridLista.RootTable.Columns("Des_PagEmb").Width = 120
        oTipo.DGridLista.RootTable.Columns("COD_PAIS").Visible = False
        oTipo.Size = New Size(650, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            TxtCodLocacion.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Cod_Locacion").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Cod_Locacion").Index))
            TxtDesLocacion.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Locacion").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Locacion").Index))
            TxtCodConPago.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("cod_condvent").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("cod_condvent").Index))
            TxtDesConPago.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("des_condvent").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("des_condvent").Index))
            txtCod_Termino_Venta.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("cod_pagemb").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("cod_pagemb").Index))
            txtDes_Termino_Venta.Text = IIf(IsDBNull(oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Des_PagEmb").Index)), "", oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("Des_PagEmb").Index))

            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            txtCod_Embarque.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEmbarque(1)
        End If
    End Sub

    Private Sub txtDes_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEmbarque(2)
        End If
    End Sub

    Private Sub BuscaEmbarque(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "ve_tg_tipemb '" & sTipo & "','" & Trim(txtCod_Embarque.Text) & "','" & Trim(txtDes_Embarque.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Embarque.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Embarque.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtNom_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Embarque.Text = Trim(Codigo)
            txtDes_Embarque.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtNom_Embarque.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Using Frm As New FrmMantenimientoModoEmbarque
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub txtNom_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtCodNaviera.Select()
        End If
    End Sub

    Private Sub TxtCodNaviera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodNaviera.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNaviera(1)
        End If
    End Sub

    Private Sub TxtDesNaviera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesNaviera.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNaviera(2)
        End If

    End Sub

    Private Sub BuscaNaviera(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "cf_tg_navieras '" & sTipo & "','" & Trim(txtCod_Embarque.Text) & "','" & Trim(TxtCodNaviera.Text) & "','" & Trim(TxtDesNaviera.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            TxtCodNaviera.Text = oTipo.dtResultados.Rows(0)("codigo")
            TxtDesNaviera.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtTip_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            TxtCodNaviera.Text = Trim(Codigo)
            TxtDesNaviera.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtTip_Embarque.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtTip_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTip_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTipoEmbarque(1)
        End If
    End Sub

    Private Sub txtDes_TipEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipEmbarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTipoEmbarque(2)
        End If
    End Sub

    Private Sub BuscaTipoEmbarque(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "ve_tg_tipoembarque '" & sTipo & "','" & Trim(txtTip_Embarque.Text) & "','" & Trim(txtDes_TipEmbarque.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtTip_Embarque.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_TipEmbarque.Text = oTipo.dtResultados.Rows(0)("descripcion")
            sFlg_Courier_Carga = oTipo.dtResultados.Rows(0)("flg_courier_carga")
            TxtCodNave.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtTip_Embarque.Text = Trim(Codigo)
            txtDes_TipEmbarque.Text = Trim(Descripcion)
            sFlg_Courier_Carga = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
            TxtCodNave.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCodNave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodNave.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNave(1)
        End If
    End Sub

    Private Sub TxtDesNave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesNave.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNave(2)
        End If
    End Sub

    Private Sub BuscaNave(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "ve_tg_naves '" & sTipo & "','" & Trim(TxtCodNaviera.Text) & "','" & Trim(TxtCodNave.Text) & "','" & Trim(TxtDesNave.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            TxtCodNave.Text = oTipo.dtResultados.Rows(0)("codigo")
            TxtDesNave.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCod_AgenteCarga.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            TxtCodNave.Text = Trim(Codigo)
            TxtDesNave.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtCod_AgenteCarga.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_AgenteCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_AgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteCarga(1)
        End If
    End Sub

    Private Sub txtDes_AgenteCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_AgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteCarga(2)
        End If
    End Sub

    Private Sub BuscaAgenteCarga(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_TG_AGENTECARGA '" & sTipo & "','" & Trim(sFlg_Courier_Carga) & "','" & Trim(txtCod_AgenteCarga.Text) & "','" & Trim(txtDes_AgenteCarga.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_AgenteCarga.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_AgenteCarga.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCod_Ejecutivo_AgenteCarga.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_AgenteCarga.Text = Trim(Codigo)
            txtDes_AgenteCarga.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtCod_Ejecutivo_AgenteCarga.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Ejecutivo_AgenteCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Ejecutivo_AgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEjecutivoAgenteCarga(1)
        End If
    End Sub

    Private Sub txtNom_Ejecutivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Ejecutivo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEjecutivoAgenteCarga(2)
        End If
    End Sub

    Private Sub BuscaEjecutivoAgenteCarga(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_TG_AGENTECARGA_EJECUTIVO '" & sTipo & "','" & Trim(txtCod_AgenteCarga.Text) & "','" & Trim(txtCod_Ejecutivo_AgenteCarga.Text) & "','" & Trim(txtNom_Ejecutivo.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Ejecutivo_AgenteCarga.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtNom_Ejecutivo.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCod_AgenteAduana.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Ejecutivo_AgenteCarga.Text = Trim(Codigo)
            txtNom_Ejecutivo.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtCod_AgenteAduana.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_AgenteAduana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_AgenteAduana.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteAduana(1)
        End If
    End Sub

    Private Sub txtNom_AgenteAduana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_AgenteAduana.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteAduana(2)
        End If
    End Sub

    Private Sub BuscaAgenteAduana(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_TG_AGENTEADUANA '" & sTipo & "','" & Trim(txtCod_AgenteAduana.Text) & "','" & Trim(txtNom_AgenteAduana.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_AgenteAduana.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtNom_AgenteAduana.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtObs_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_AgenteAduana.Text = Trim(Codigo)
            txtNom_AgenteAduana.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtObs_Embarque.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtObs_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            txtCod_Flete.Select()
        End If
    End Sub

    Private Sub txtCod_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Flete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaFlete(1)
        End If
    End Sub

    Private Sub txtDes_Flete_Ingles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Flete_Ingles.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaFlete(2)
        End If
    End Sub

    Private Sub BuscaFlete(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_TG_TIPOFLETE '" & sTipo & "','" & Trim(txtCod_Flete.Text) & "','" & Trim(txtDes_Flete_Ingles.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Flete.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Flete_Ingles.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCod_Termino_Venta.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Flete.Text = Trim(Codigo)
            txtDes_Flete_Ingles.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtCod_Termino_Venta.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Termino_Venta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTerminoVenta(1)
        End If
    End Sub

    Private Sub txtDes_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Termino_Venta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTerminoVenta(2)
        End If
    End Sub

    Private Sub BuscaTerminoVenta(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_CN_TERMINO_VENTA '" & sTipo & "','" & Trim(txtCod_Termino_Venta.Text) & "','" & Trim(txtDes_Termino_Venta.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Termino_Venta.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Termino_Venta.Text = oTipo.dtResultados.Rows(0)("descripcion")
            TxtCodConPago.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Termino_Venta.Text = Trim(Codigo)
            txtDes_Termino_Venta.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            TxtCodConPago.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCodConPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodConPago.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCondicionPago(1)
        End If
    End Sub

    Private Sub TxtDesConPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesConPago.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCondicionPago(2)
        End If
    End Sub

    Private Sub btnMantenimientoNaviera_Click(sender As Object, e As EventArgs) Handles btnMantenimientoNaviera.Click
        Using Frm As New FrmMantenimientoNavieras
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub btnNave_Click(sender As Object, e As EventArgs) Handles btnNave.Click
        Using Frm As New FrmMantenimientoNaves
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub btnAgenteCarga_Click(sender As Object, e As EventArgs) Handles btnAgenteCarga.Click
        Using Frm As New FrmMantenimientoAgenteCarga
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub btnEjecutivoAgenteCarga_Click(sender As Object, e As EventArgs) Handles btnEjecutivoAgenteCarga.Click
        Using Frm As New FrmMantenimientoEjecutivoCarga
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub btnAgenteAduana_Click(sender As Object, e As EventArgs) Handles btnAgenteAduana.Click
        Using Frm As New FrmMantenimientoAgenteAduana
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub BuscaCondicionPago(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"

        oTipo.sQuery = "ve_ayuda_lg_condVent '" & sTipo & "','" & Trim(TxtCodConPago.Text) & "','" & Trim(TxtDesConPago.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            TxtCodConPago.Text = oTipo.dtResultados.Rows(0)("codigo")
            TxtDesConPago.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtNumCarCre.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            TxtCodConPago.Text = Trim(Codigo)
            TxtDesConPago.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            txtNumCarCre.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtNumCarCre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumCarCre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtObs_EnvioInstruccionesalAgenteAduanas.Select()
        End If
    End Sub

    Private Sub txtObs_EnvioInstruccionesalAgenteAduanas_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            txtObs_EnvioInstruccionesalAgenteCarga.Select()
        End If
    End Sub

    Private Sub txtObs_EnvioInstruccionesalAgenteCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObs_EnvioInstruccionesalAgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtNum_Dua.Select()
        End If
    End Sub

    Private Sub txtNum_Dua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Dua.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Select()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            If sAccion = "D" Then
                If MessageBox.Show("Esta Seguro de elininar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            End If

            strSQL = "EXEC TG_EMBARQUE_MAN"
            strSQL &= vbNewLine & String.Format(" @accion                       = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@Num_Embarque                 = '{0}'", txtNum_Embarque.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Origen                   = '{0}'", Trim(txtCod_Origen.Text))
            strSQL &= vbNewLine & String.Format(",@Ano		                    = '{0}'", Trim(txtAno.Value))
            strSQL &= vbNewLine & String.Format(",@Mes                          = '{0}'", Trim(cboMeses.SelectedValue))
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex                  = '{0}'", Trim(txtCod_TipAnex.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo                     = '{0}'", Trim(txtCod_Anxo.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Cliente		            = '{0}'", sCod_Cliente)
            strSQL &= vbNewLine & String.Format(",@Cod_AgenteAduana             = '{0}'", Trim(txtCod_AgenteAduana.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_AgenteCarga              = '{0}'", Trim(txtCod_AgenteCarga.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Ejecutivo_AgenteCarga    = '{0}'", Trim(txtCod_Ejecutivo_AgenteCarga.Text))
            strSQL &= vbNewLine & String.Format(",@Tip_Embarque		            = '{0}'", Trim(txtTip_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Obs_Embarque                 = '{0}'", Trim(txtObs_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Embarque                 = '{0}'", Trim(txtCod_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Nom_Embarque                 = '{0}'", Trim(txtNom_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Flete		            = '{0}'", Trim(txtCod_Flete.Text))
            strSQL &= vbNewLine & String.Format(",@COD_TERMINO_VENTA            = '{0}'", Trim(txtCod_Termino_Venta.Text))
            strSQL &= vbNewLine & String.Format(",@cod_usuario                  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@cod_Estacion                 = '{0}'", ComputerName)
            strSQL &= vbNewLine & String.Format(",@Cod_Pais		                = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@Cod_TipoEmb                  = '{0}'", Trim(Cbo_TipoEmb.SelectedValue))
            strSQL &= vbNewLine & String.Format(",@Cod_Naviera                  = '{0}'", Trim(TxtCodNaviera.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Nave                     = '{0}'", Trim(TxtCodNave.Text))
            strSQL &= vbNewLine & String.Format(",@COD_DESTINO		            = '{0}'", Trim(Cbo_Destino.SelectedValue))
            strSQL &= vbNewLine & String.Format(",@Cod_CondVent_Asociado        = '{0}'", Trim(TxtCodConPago.Text))
            strSQL &= vbNewLine & String.Format(",@Num_CartaCredito_Asociado    = '{0}'", Trim(txtNumCarCre.Text))
            strSQL &= vbNewLine & String.Format(",@cod_locacion                 = '{0}'", Trim(TxtCodLocacion.Text))

            Dim Dt As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            If Dt.Rows.Count > 0 Then
                sNum_Embarque = Dt.Rows(0)("NUM_EMBARQUE")
                sRef_Embarque = Dt.Rows(0)("REF_EMBARQUE")
                sConMod = "1"
                DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class