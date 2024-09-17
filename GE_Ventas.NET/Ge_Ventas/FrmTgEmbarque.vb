Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private ColEmpresa As Color
    Public sOpcionBusqueda As String = "1"
    Private sCod_Cliente As String
    Private Const K_strColCheck As String = "SEL"
    Private FilaSeleccionada As Integer

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private Sub FrmTgEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        nUpAnio.Value = Year(Now)
        CargaComboMeses()
        ActiveControl = txtNumero
    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        FondoDegradeDiagonalEnPanel(sender, e, ColEmpresa)
    End Sub

    Sub CargaComboMeses()
        strSQL = "CF_CARGA_LG_MESES"
        cboMeses.DataSource = oHP.DevuelveDatos(strSQL, cCONNECT)
        cboMeses.ValueMember = "CODIGO"
        cboMeses.DisplayMember = "DESCRIPCION"
        cboMeses.SelectedValue = CInt(Month(Now))
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargaDatos()
    End Sub

    Public Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_EMBARQUES_MUESTRA "
            strSQL &= vbNewLine & String.Format(" @tipo		    = '{0}'", sOpcionBusqueda)
            strSQL &= vbNewLine & String.Format(",@num_embarque	= '{0}'", txtNumero.Text)
            strSQL &= vbNewLine & String.Format(",@Ref_Embarque	= '{0}'", txtReferencia.Text)
            strSQL &= vbNewLine & String.Format(",@Ano		    = '{0}'", nUpAnio.Text)
            strSQL &= vbNewLine & String.Format(",@Mes		    = '{0}'", cboMeses.SelectedValue)
            strSQL &= vbNewLine & String.Format(",@Cod_cliente	= '{0}'", sCod_Cliente)
            strSQL &= vbNewLine & String.Format(",@Flg_status	= '{0}'", txtCod_Estado.Text)
            strSQL &= vbNewLine & String.Format(",@cod_purord	= '{0}'", txtPO.Text)
            strSQL &= vbNewLine & String.Format(",@cod_ordpro	= '{0}'", txtCod_OrdPro.Text)

            GridEX1.RootTable.Columns.Clear()
            oDT = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains

                With .RootTable
                    .RowHeight = 30
                    .PreviewRow = True
                    .PreviewRowMember = "Observacion"
                    .PreviewRowLines = 4

                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("COD_DESTINO").Visible = False
                    .Columns("COD_LOCACION").Visible = False

                    With .Columns("NUM_EMBARQUE")
                        .Caption = "N° EMBARQUE"
                        .Width = 80
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("REF_EMBARQUE")
                        .Caption = "REF. EMBARQUE"
                        .Width = 120
                    End With

                    With .Columns("FACTURA_ASIGNADA")
                        .Caption = "FACTURA ASIGNADA"
                        .Width = 90
                    End With

                    With .Columns("FEC_FACTURA_ASOCIADO")
                        .Caption = "FECHA FACTURA ASOCIADA"
                        .Width = 110
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("ESTADO_PLANTA")
                        .Caption = "ESTADO PLANTA"
                        .Width = 90
                    End With

                    With .Columns("ESTADO_EMBARQUE")
                        .Caption = "ESTADO EMBARQUE"
                        .Width = 90
                    End With

                    With .Columns("ESTADO_OPS_PRODUCTOS")
                        .Caption = "ESTADO OPS PRODUCTOS"
                        .Width = 100
                    End With

                    With .Columns("DES_ANEXO")
                        .Caption = "ANEXO"
                        .Width = 110
                    End With

                    With .Columns(K_strColCheck)
                        .Caption = "SEL"
                        .Visible = True
                        .ColumnType = ColumnType.CheckBox
                        .EditType = EditType.CheckBox
                        .ActAsSelector = True
                        .Width = 25
                        .Caption = String.Empty
                    End With

                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub optNumero_Click(sender As Object, e As EventArgs) Handles optNumero.Click,
                                                                            optPeriodo.Click,
                                                                            optReferencia.Click,
                                                                            optEstado.Click,
                                                                            optPO.Click,
                                                                            optOP.Click
        grpNumero.Visible = False : grpPeriodoEstado.Visible = False : grpReferencia.Visible = False : grpEstado.Visible = False : grpPO.Visible = False : grpOP.Visible = False
        Call Limpiar()

        Select Case sender.tag
            Case "1"
                sOpcionBusqueda = "1"
                grpNumero.Visible = True
                txtNumero.Select()

            Case "2"
                sOpcionBusqueda = "2"
                grpPeriodoEstado.Visible = True
                txtCod_Cliente.Select()

            Case "3"
                sOpcionBusqueda = "3"
                grpReferencia.Visible = True
                txtReferencia.Select()

            Case "4"
                sOpcionBusqueda = "4"
                grpEstado.Visible = True
                txtCod_Estado.Select()

            Case "5"
                sOpcionBusqueda = "5"
                grpPO.Visible = True
                txtPO.Select()

            Case "6"
                sOpcionBusqueda = "6"
                grpOP.Visible = True
                txtCod_OrdPro.Select()

        End Select

    End Sub

    Sub Limpiar()
        txtNumero.Text = String.Empty
        txtDes_Cliente.Text = String.Empty
        txtReferencia.Text = String.Empty
        txtCod_Estado.Text = String.Empty
        txtDes_Estado.Text = String.Empty
        txtCod_OrdPro.Text = String.Empty
        txtPO.Text = String.Empty
        txtCod_Cliente.Text = String.Empty
        txtDes_Cliente.Text = String.Empty
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnBuscar.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtCod_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCliente()
        End If
    End Sub

    Private Sub BuscaCliente()

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un registro"
        oTipo.sQuery = "Tg_PROMPT_Clientes '" & txtCod_Cliente.Text.Trim & "'"

        oTipo.Cargar_Datos()

        oTipo.DGridLista.RootTable.Columns("Abr_Cliente").Width = 70
        oTipo.DGridLista.RootTable.Columns("Nom_Cliente").Width = 100
        oTipo.DGridLista.RootTable.Columns("Cod_Cliente").Width = 80
        oTipo.DGridLista.RootTable.Columns("Cliente").Width = 100
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Cliente.Text = Trim(Codigo)
            txtDes_Cliente.Text = Descripcion
            sCod_Cliente = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
            BtnBuscar.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Estado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Estado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaStatus(1)
        End If
    End Sub

    Private Sub txtDes_Estado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Estado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaStatus(2)
        End If
    End Sub

    Private Sub BuscaStatus(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un registro"
        oTipo.sQuery = "TG_AYUDA_TG_EMBARQUE_STATUS '" & sTipo & "','" & Trim(txtCod_Estado.Text) & "','" & Trim(txtDes_Estado.Text) & "'"

        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Estado.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Estado.Text = oTipo.dtResultados.Rows(0)("descripcion")
            BtnBuscar.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300

        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Estado.Text = Trim(Codigo)
            txtDes_Estado.Text = Trim(Descripcion)

            Codigo = "" : Descripcion = ""
            BtnBuscar.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtPO.Text.Trim = "" Then
                txtPO.Select()
            Else
                BtnBuscar.Select()
            End If
        End If
    End Sub

    Private Sub txtCod_OrdPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_OrdPro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCod_OrdPro.Text.Trim = "" Then
                txtCod_OrdPro.Select()
            Else
                txtCod_OrdPro.Text = RellenaDeCerosEnIzquierda(txtCod_OrdPro.Text, 5)
                BtnBuscar.Select()
            End If
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Call Adicionar("I")

                Case "MODIFICAR"
                    Call Adicionar("U")

                Case "ELIMINAR"
                    Call Adicionar("D")

                Case "DETALLEPRENDAS"
                    Call DetallePrendas()

                Case "DETALLETELAS"
                    Call DetalleTelas()

                Case "IMPAGCARGAPRENDA"
                    Call ImprimirAgentePrenda()

                Case "INSTRUCCION"
                    Call GenerarInstruccion()

                Case "IMPAGCARGATELAS"
                    Call ImprimirAgenteCargaTelas()

                Case "IMPAGADUANATELA"
                    Call ImprimirAgenteAduanaTelas()

                Case "IMPLISTADO"
                    Call ImprimirListado()

                Case "CAMBIOESTADO"
                    Call CambioEstado()

                Case "HOJACOSTO"
                    Call ImprimirHojaCosto()

                Case "DETALLEPRODUCTO"
                    Call VerDetalleProducto()

                Case "VISTAPRELIMINAR"
                    Call VistaPreLiminar()

                Case "IMPINSTEMBARQUE"
                    Imprimir_IntruccionEmbarque()

                    '==============================
                    'OPCIONES I
                    '==============================

                Case "ENVIOINSTRUCCION"
                    Call EnvioInstruccionAgenteCarga

                Case "ENVIOINSTRUCCIONAGADUANA"
                    Call EnvioInstruccionAgenteAduana()

                Case "DUA"
                    Call RecepcionDUA()

                Case "PENALIDADES"
                    Call Penalidades()

                Case "MODIFICARFECHAS"
                    Call ModificarFechas()

                Case "GASTOSASOCIADOS"
                    Call GastosAsociados()

                Case "ASIGNARFACTURA"
                    Call AsignarFacturas()

                Case "COPINFAC"
                    Call CopiarInstruccion()

                Case "FACTURAANTICIPADA"
                    Call FacturaAnticipada()

                Case "GENFACTANTI"
                    Call GenerarFacturaAnticipada()

                Case "EMBARQUEMERCADERIA"
                    Call SolicitudEmbarqueMercaderia()

                Case "ZARPE"
                    Call DatosZarpe()

                Case "ADVICE"
                    Call Imprimir_ShipmentAdvice

                Case "INSTRUCCIONEMBARQUECK"
                    Call ImprimirAgenteAduanaCK()

                Case "CLONAR"
                    ProcesarClonar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Imprimir_IntruccionEmbarque()
        Try
            Dim oo As Object
            Dim ruta As String
            Dim Usu As String
            Dim strSQLDATA As String

            strSQLDATA = "EXEC Ventas_Embarques_Exporta_data_Instruccion  '" & GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index) & "'"

            ruta = vRuta & "\RptDataInstrucciónEmbarque.xlt"
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(ruta)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("Reporte", strSQLDATA, cCONNECTVB6)
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Imprimir_ShipmentAdvice()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim sNum_Embarque As String
            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"

            sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)

            RouteFileXLT = RouteFileXLT & "\RptShipmentAdvice.xlt"

            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sNum_Embarque, vusu, "02")
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ImprimirAgenteAduanaCK()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim sNum_Embarque As String
            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"

            sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)

            If vemp = "01" Then
                RouteFileXLT = RouteFileXLT & "\InstrucAgenteAduanas02.xlt"
            ElseIf vemp = "03" Then
                RouteFileXLT = RouteFileXLT & "\InstrucAgenteAduanas_INKA.xlt"
            End If


            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sNum_Embarque, vusu, "02")
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DatosZarpe()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub
            FilaSeleccionada = GridEX1.CurrentRow.Position
            Using Frm As New FrmTgEmbarque_DatosdeZarpe
                With Frm
                    .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                    If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EmbarqueReal").Index)) Then
                        .dtpEmbarqueReal.Text = ""
                    Else
                        .dtpEmbarqueReal.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EmbarqueReal").Index), 10)
                    End If
                    If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Llegada_Embarque").Index)) Then
                        .dtpLlegadaEmbarque.Text = ""
                    Else
                        .dtpLlegadaEmbarque.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Llegada_Embarque").Index), 10)
                    End If
                    .txtNumGuiaArea.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Guia_Aerea").Index))
                    .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Embarque").Index)
                    If .ShowDialog = DialogResult.OK Then
                        CargaDatos()
                        GridEX1.Row = FilaSeleccionada
                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Sub SolicitudEmbarqueMercaderia()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub
            Dim List_Emb As String

            If GridEX1.GetCheckedRows.Length Then
                If (MessageBox.Show("¿Esta seguro de realizar esta accion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                    For Each oGridEXRow As GridEXRow In GridEX1.GetCheckedRows
                        List_Emb = List_Emb & GridEX1.GetValue(GridEX1.RootTable.Columns("Num_embarque").Index).ToString.PadLeft(10, "0") & ","
                    Next

                    Using Frm As New FrmTgEmbarque_SolEmbarqueMercaderia
                        With Frm
                            .List_Emb = List_Emb
                            If .ShowDialog = DialogResult.OK Then
                                Exit Sub
                            End If
                        End With
                    End Using
                    MessageBox.Show("Los Registros Fueron Eliminados Correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub GenerarFacturaAnticipada()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub
            FilaSeleccionada = GridEX1.CurrentRow.Position
            If MessageBox.Show("Esta seguro de generar la factura anticipada?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            strSQL = "EXEC VENTAS_GENERA_DOC_VENTAS_PRENDAS_ANTICIPOS"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE             = '{0}'", GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Embarque").Index))
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario_Registro     = '{0}'", vusu)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CargaDatos()
                GridEX1.Row = FilaSeleccionada
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub FacturaAnticipada()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmShowGuiasxFactPrendas_DatosAdicionales
            With Frm

                .sCod_Cliente = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Cliente").Index))
                .sCod_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Embarque").Index)
                .sSerie = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ser_Docum_Ventas_Asociado").Index))
                .sNum_Fac = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Docum_Ventas_Asociado").Index))
                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Factura_Asociado").Index)) Then
                    .sFecEmi = ""
                Else
                    .sFecEmi = GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Factura_Asociado").Index)
                End If
                .sCod_TipAnex = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_TipAnex").Index))
                .sCod_Anexo = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Anxo").Index))
                .txtRef_Embarque.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ref_Embarque").Index))
                .txtRef_Embarque.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ref_Embarque").Index))
                .txtObservacion.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Glosa_Factura").Index))

                .txtCod_CondVent.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_CondVent_Asociado").Index))
                .txtDes_CondVent.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Des_CondVent_Asociado").Index))
                .txtCartaCredito.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_CartaCredito_Asociado").Index))
                .txtCod_Termino_Venta.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Termino_venta").Index))
                .txtDes_Termino_Venta.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Des_Termino_Venta").Index))
                .txtCod_Flete.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Flete").Index))
                .txtDes_Flete.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Des_Flete_Ingles").Index))

                .txtCod_Embarque.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Embarque").Index))
                .txtDes_Embarque.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Des_Embarque").Index))
                .txtNom_Embarque.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Nom_Embarque").Index))

                .txtPie_Pagina2.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_Embarque").Index))
                .txtPie_Pagina1.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Pie_Pagina").Index))
                .txtNotify.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Notify").Index))
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub CopiarInstruccion()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_CambiarInstruccionFactura
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub AsignarFacturas()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_AsignarFactura
            With Frm
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                If GridEX1.GetValue(GridEX1.RootTable.Columns("Flg_Status").Index) <> "T" Then
                    MessageBox.Show("Embarque debe estar en Estado: En Trámite", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                'frmAsignarFacturas.SUsuario = vusu

                If Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ser_Docum_Ventas_Asociado").Index)) & Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Docum_Ventas_Asociado").Index)) = "" Then
                    .sFacAsig = "N"
                Else
                    .sFacAsig = "S"
                End If

                .sSerie = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ser_Docum_Ventas_Asociado").Index))
                .txtSerie.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ser_Docum_Ventas_Asociado").Index))
                .sNumero = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Docum_Ventas_Asociado").Index))
                .txtNumero.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Docum_Ventas_Asociado").Index))

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Factura_Asociado").Index)) Then
                    .sFecFac = Now
                    .dtpFec_Emision.Value = Now
                Else
                    .sFecFac = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Factura_Asociado").Index), 12)
                    .dtpFec_Emision.Value = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Factura_Asociado").Index), 12)
                End If

                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub GastosAsociados()
        If GridEX1.RowCount = 0 Then Exit Sub
        Using Frm As New FrmTgEmbarque_GastosAsociados
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .txtCliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_cliente").Index)
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Sub ModificarFechas()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_ModificarFechas
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Entrega_Contabilidad_Tramites_DrawBack").Index)) Then
                    .dtpEntregaDrauBack1.Text = ""
                Else
                    .dtpEntregaDrauBack1.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Entrega_Contabilidad_Tramites_DrawBack").Index), 10)
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_RecepcionDUA").Index)) Then
                    .dtpFec_RecepcionDUA1.Text = ""
                Else
                    .dtpFec_RecepcionDUA1.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_RecepcionDUA").Index), 10)
                End If
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub Penalidades()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_Penalidades
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                If GridEX1.GetValue(GridEX1.RootTable.Columns("Flg_Penalidad").Index) = "S" Then
                    .chkIncPenalidad.Checked = "1"
                    .txtImp_Flete_Aereo.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Imp_Flete_Aereo").Index)
                Else
                    .chkIncPenalidad.Checked = False
                    .txtImp_Flete_Aereo.Text = 0
                End If
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub RecepcionDUA()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_RecepcionDUA
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .txtNum_Dua.Mask = ""
                .txtNum_Dua.Text = ""
                .txtNum_Dua.Mask = "###-####-##-######"

                If RTrim(FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_DUA").Index), 8)) <> "" Then
                    .txtNum_Dua.Text = RTrim(FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_DUA").Index), 8))
                Else
                    .txtNum_Dua.Mask = ""
                    .txtNum_Dua.Text = ""
                    .txtNum_Dua.Mask = "###-####-##-######"
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_NumeracionDUA").Index)) Then
                    .dtpFec_NumeracionDua.Text = ""
                Else
                    .dtpFec_NumeracionDua.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_NumeracionDUA").Index), 10)
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Entrega_Contabilidad_Tramites_DrawBack").Index)) Then
                    .dtpEntregaDrauBack.Text = ""
                Else
                    .dtpEntregaDrauBack.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Entrega_Contabilidad_Tramites_DrawBack").Index), 10)
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EmbarqueReal").Index)) Then
                    .dtpFec_EmbarqueReal.Text = ""
                Else
                    .dtpFec_EmbarqueReal.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EmbarqueReal").Index), 10)
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_RecepcionDUA").Index)) Then
                    .dtpFec_RecepcionDUA.Text = ""
                Else
                    .dtpFec_RecepcionDUA.Text = RellenaDeCerosEnIzquierda(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_RecepcionDUA").Index), 10)
                End If
                .txtNGC.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("id_ngc").Index))

                .txtDolares.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Imp_FOB_Dol_Dua").Index), vbString)

                If .txtDolares.Text = 0 Or Trim(.txtDolares.Text) = "" Then
                    .txtDolares.Text = oHP.DevuelveDato("SELECT DBO.CN_VENTAS_PREDETERMINA_IMP_FOB_DOL_DUA('" & .sNum_Embarque & "')", cCONNECT)
                End If

                .txtNum_BL.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Bill_of_Landing").Index), 12)

                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub EnvioInstruccionAgenteAduana()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_EnvioInstruccionAGAduana
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .dtpFec_EnvioInstruccionesalAgenteAduana.Value = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioInstruccionesalAgenteAduanas").Index), 12)
                .txtObs_EnvioInstruccionesalAgenteAduanas.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_EnvioInstruccionesalAgenteAduanas").Index)
                .dtpFec_EnvioFacturaalAgenteAduanas.Value = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioFacturaalAgenteAduanas").Index), 12)
                .txtCod_AlmacenAduana.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_AlmacenAduana").Index), 8)
                .txtNom_AlmacenAduana.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Nom_AlmacenAduana").Index), 8)
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada = GridEX1.CurrentRow.Position
                End If
            End With
        End Using
    End Sub

    Sub EnvioInstruccionAgenteCarga()
        If GridEX1.RowCount = 0 Then Exit Sub
        FilaSeleccionada = GridEX1.CurrentRow.Position
        Using Frm As New FrmTgEmbarque_EnvioInstruccionAGCarga
            With Frm
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioInstruccionesalAgenteCarga").Index)) Then
                    .DtpFec_EnvioInstruccionesalAgenteCarga.Value = Now.Date
                Else
                    .DtpFec_EnvioInstruccionesalAgenteCarga.Value = GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioInstruccionesalAgenteCarga").Index)
                End If

                If IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Embarque_Prevista").Index)) Then
                    .DtpFecEmbPre.Value = Now.Date
                Else
                    .DtpFecEmbPre.Value = GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Embarque_Prevista").Index)
                End If

                .txtObs_EnvioInstruccionesalAgenteCarga.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_EnvioInstruccionesalAgenteCarga").Index)
                .txtNotify.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Notify").Index)
                .txtCod_AlmacenAduana.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_AlmacenAduana").Index), 8)
                .txtNom_AlmacenAduana.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Nom_AlmacenAduana").Index), 8)
                .txtNotFinal.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Pie_Pagina").Index)
                .txtInfAdiGuiAre.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Informacion_Adicional_Guia_Aerea").Index)
                .txtConsignatario.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Consignatario").Index)

                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                    GridEX1.Row = FilaSeleccionada
                End If
            End With
        End Using
    End Sub

    Sub InstruccionEmbarque()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            strSQL = "EXEC Ventas_Embarques_Exporta_data_Instruccion  '" & sNro_Embarque & "'"

            RouteFileXLT = RouteFileXLT & "\RptDataInstrucciónEmbarque_V2.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, strSQL, cCONNECTVB6)
            oXL.UserControl = True
            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub VistaPreLiminar()
        Using Frm As New FrmTgEmbarque_VistaPreliminar
            With Frm
                .sAccion = "P"
                .sCod_Cliente = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_cliente").Index)
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .sTipo = "P"
                .txtNum_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .txtCliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_cliente").Index)
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                End If
            End With
        End Using
    End Sub

    Sub VerDetalleProducto()
        If GridEX1.RowCount = 0 Then Exit Sub
        Using Frm As New FrmTgEmbarque_DetalleProducto
            With Frm
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)
                .txtCliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_cliente").Index)
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                End If
            End With
        End Using
    End Sub

    Sub ImprimirHojaCosto()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim RouteLogo As String
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            RouteLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            RouteFileXLT = RouteFileXLT & "\RptHojaCostoExportacion.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, RouteLogo, sNro_Embarque, cCONNECTVB6)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub CambioEstado()
        Try
            Dim sAccCli As String

            strSQL = "SELECT COD_CLIENTE FROM TG_EMBARQUE_SEGURIDAD WHERE COD_USUARIO = '" & vusu & "'"
            sAccCli = oHP.DevuelveDato(strSQL, cCONNECT)

            If sAccCli = "*****" Then
                If MessageBox.Show("Esta seguro de confirmar el cambio de estado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

                strSQL = "EXEC TG_EMBARQUE_CAMBIOESTADO"
                strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE  = '{0}'", GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index))
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO   = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    CargaDatos()
                End If
            Else
                If sAccCli = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Cliente").Index) Then
                    strSQL = "EXEC TG_EMBARQUE_CAMBIOESTADO"
                    strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE  = '{0}'", GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index))
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO   = '{0}'", vusu)

                    If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                        CargaDatos()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ImprimirListado()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            Dim sEmpresa, sRango As String

            strSQL = "SELECT DES_EMPRESA FROM SEGURIDAD..SEG_EMPRESAS WHERE COD_EMPRESA='" & vemp & "'"
            sEmpresa = oHP.DevuelveDato(strSQL, cCONNECT)

            If optNumero.Checked Then
                sRango = "Embarque: " & GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
            End If
            If optPeriodo.Checked Then
                sRango = "Período: " & GridEX1.GetValue(GridEX1.RootTable.Columns("ANO").Index) & IIf(cboMeses.Text = "", "", "/" & cboMeses.Text) & IIf(txtCod_Cliente.Text = "", "", " Cliente:" & txtDes_Cliente.Text)
            End If
            If optNumero.Checked Then
                sRango = "Ref.Embarque: " & GridEX1.GetValue(GridEX1.RootTable.Columns("REF_EMBARQUE").Index)
            End If
            If optEstado.Checked Then
                sRango = "Estado: " & GridEX1.GetValue(GridEX1.RootTable.Columns("DES_STATUS").Index)
            End If


            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            RouteFileXLT = RouteFileXLT & "\EmbarquesExportacion.xlt"

            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sRango, sOpcionBusqueda, txtNumero.Text, txtReferencia.Text, nUpAnio.TextAlign, cboMeses.SelectedValue, sCod_Cliente, txtCod_Estado.Text, sEmpresa)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ImprimirAgenteAduanaTelas()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            If vemp = "01" Then
                RouteFileXLT = RouteFileXLT & "\InstrucAgenteAduanasT.xlt"
            ElseIf vemp = "03" Then
                RouteFileXLT = RouteFileXLT & "\InstrucAgenteAduanasT_INKA.xlt"
            End If

            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sNro_Embarque)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ImprimirAgenteCargaTelas()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            RouteFileXLT = RouteFileXLT & "\InstrucAgenteCargaT.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sNro_Embarque)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub GenerarInstruccion()
        Using Frm As New FrmTgEmbarque_InstruccionEmbarque
            With Frm
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                End If
            End With
        End Using
    End Sub

    Sub ImprimirAgentePrenda()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim sNro_Embarque As String
            sNro_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("num_embarque").Index)

            RouteFileXLT = RouteFileXLT & "\InstrucAgenteCarga.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, sNro_Embarque, vemp)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DetalleTelas()
        If GridEX1.RowCount = 0 Then Exit Sub

        Using Frm As New FrmTgEmbarque_Detalle_Telas
            With Frm
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                If .ShowDialog = DialogResult.OK Then
                    CargaDatos()
                End If
            End With
        End Using
    End Sub

    Sub DetallePrendas()
        If GridEX1.RowCount = 0 Then Exit Sub
        If GridEX1.GetValue(GridEX1.RootTable.Columns("cod_origen").Index) <> "7" Then Exit Sub

        Using Frm As New FrmTgEmbarque_Detalle
            With Frm
                .sNum_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                .TxtNroEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                If .ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End With
        End Using
    End Sub

    Private Sub ProcesarClonar()
        Try
            Dim Val As String
            Dim Resp As String

            If GridEX1.RowCount = 0 Then Exit Sub
            FilaSeleccionada = GridEX1.CurrentRow.Position
            If MessageBox.Show("Desea generar embarques desde el origen seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Val = InputBox("Ingrese Cantidad de Embarques a Generar", "Clonar Embarque!")
                If Trim(Val) = "" Or Len(Trim(Val)) = 0 Then
                    MessageBox.Show("Debe Ingresar Cantidad..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            strSQL = "EXEC TG_EMBARQUE_MAN_MASIVO"
            strSQL &= vbNewLine & String.Format(" @Num_Embarque_Origen  = '{0}'", GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Embarque").Index))
            strSQL &= vbNewLine & String.Format(",@Cant_Embarque        = '{0}'", Val)
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario          = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Estacion             = '{0}'", ComputerName)
            Resp = oHP.DevuelveDato(strSQL, cCONNECT)
            MessageBox.Show("Registros Generados" & vbCrLf & Resp, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CargaDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Adicionar(Accion As String)
        Using Frm As New FrmTgEmbarque_Add
            With Frm
                If Accion = "U" Or Accion = "D" Then
                    If GridEX1.RowCount = 0 Then Exit Sub

                    .txtNum_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_EMBARQUE").Index)
                    .txtCod_Origen.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Origen").Index)
                    .txtDes_Origen.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_Origen").Index)
                    .txtCod_TipAnex.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_TipAnex").Index)
                    .txtCod_Anxo.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Anxo").Index)
                    .txtDes_Anexo.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_Anexo").Index)
                    .txtAbr_Cliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Abr_Cliente").Index)
                    .sCod_Cliente = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_Cliente").Index)
                    .txtNom_Cliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_cliente").Index)
                    .TxtCodLocacion.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_locacion").Index)
                    .TxtDesLocacion.Text = IIf(IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("Locacion").Index)), "", GridEX1.GetValue(GridEX1.RootTable.Columns("Locacion").Index))
                    .txtCod_AgenteCarga.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_AgenteCarga").Index)
                    .txtDes_AgenteCarga.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_AgenteCarga").Index)
                    .txtCod_AgenteAduana.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_AgenteAduana").Index)
                    .txtNom_AgenteAduana.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_AgenteAduana").Index)
                    .txtCod_Ejecutivo_AgenteCarga.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Ejecutivo_AgenteCarga").Index)
                    .txtNom_Ejecutivo.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Nom_Ejecutivo").Index)
                    .txtRef_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Ref_Embarque").Index)
                    .txtTip_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Tip_Embarque").Index)
                    .txtDes_TipEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Des_TipEmbarque").Index)
                    .txtObs_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_Embarque").Index)
                    .txtCod_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Embarque").Index)
                    .txtDes_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_Embarque").Index)
                    .txtNom_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("nom_Embarque").Index)
                    .txtCod_Flete.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_Flete").Index)
                    .txtDes_Flete_Ingles.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Des_Flete_ingles").Index)
                    .txtFlg_Status.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Flg_Status").Index)
                    .txtDes_Estado.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Des_status").Index)
                    .txtFec_EnvioInstruccionesalAgenteAduana.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioInstruccionesalAgenteAduanas").Index), vbString)
                    .txtObs_EnvioInstruccionesalAgenteAduanas.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_EnvioInstruccionesalAgenteAduanas").Index)
                    .txtFec_EnvioFacturaalAgenteAduanas.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioFacturaalAgenteAduanas").Index), vbString)
                    .txtFec_RecepcionDUA.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_RecepcionDua").Index), vbString)
                    .txtNum_Dua.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Dua").Index)
                    .txtFec_NumeracionDua.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_NumeracionDua").Index), vbString)
                    .txtEntregaDrauBack.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_Entrega_Contabilidad_Tramites_DrawBack").Index), vbString)
                    .txtFec_EmbarqueReal.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EmbarqueReal").Index), vbString)
                    .txtFec_EnvioInstruccionesalAgenteCarga.Text = FixNulos(GridEX1.GetValue(GridEX1.RootTable.Columns("Fec_EnvioInstruccionesalAgenteCarga").Index), vbString)
                    .txtObs_EnvioInstruccionesalAgenteCarga.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Obs_EnvioInstruccionesalAgenteCarga").Index)
                    .txtAno.Value = GridEX1.GetValue(GridEX1.RootTable.Columns("Ano").Index)
                    .txtCod_Termino_Venta.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_termino_venta").Index)
                    .txtDes_Termino_Venta.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_termino_venta").Index)
                    .txtTip_Embarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("TIP_EMBARQUE").Index)
                    .txtDes_TipEmbarque.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("DES_TIPEMBARQUE").Index)
                    .sCod_AlmacenAduana = GridEX1.GetValue(GridEX1.RootTable.Columns("COD_ALMACENADUANA").Index)
                    .sNom_AlmacenAduana = GridEX1.GetValue(GridEX1.RootTable.Columns("NOM_ALMACENADUANA").Index)
                    .txtCod_Origen.Enabled = False
                    .txtDes_Origen.Enabled = False
                    .txtAno.Enabled = False
                    .sMes = GridEX1.GetValue(GridEX1.RootTable.Columns("Mes").Index)
                    .sTipoEmbarque = GridEX1.GetValue(GridEX1.RootTable.Columns("DesTipEmb").Index)
                    .sDestino = IIf(IsDBNull(GridEX1.GetValue(GridEX1.RootTable.Columns("cod_Destino").Index)), "", GridEX1.GetValue(GridEX1.RootTable.Columns("cod_Destino").Index))
                    '.Cbo_Destino.SelectedItem = GridEX1.GetValue(GridEX1.RootTable.Columns("Destino").Index)
                    .TxtCodNaviera.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NAVCOD").Index)
                    .TxtDesNaviera.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Naviera").Index)
                    .TxtCodNave.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NVSCOD").Index)
                    .TxtDesNave.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Nave").Index)
                    .TxtCodConPago.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cod_CondVent_Asociado").Index)
                    .TxtDesConPago.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Des_CondVent_Asociado").Index)
                    .txtNumCarCre.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_CartaCredito_Asociado").Index)
                    .Cbo_TipoEmb.Enabled = False
                    .sAccion = Accion
                    .txtRef_Embarque.ReadOnly = True
                ElseIf Accion = "I" Then
                    .sAccion = "I"
                End If

                If Accion = "D" Then
                    .Panel1.Enabled = False
                End If

                If .ShowDialog = DialogResult.OK Then
                    optNumero.Checked = True
                    txtNumero.Text = .sNum_Embarque
                    CargaDatos()
                End If
            End With
        End Using
    End Sub
End Class