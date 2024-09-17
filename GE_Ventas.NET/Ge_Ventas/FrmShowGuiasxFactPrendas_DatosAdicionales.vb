Public Class FrmShowGuiasxFactPrendas_DatosAdicionales
    Enum ModoVentana
        DesdeShowGuiaFacturaPrendas = 1
        DesdeEmbarqueSolicitarFacturaAnticipada = 2
    End Enum

    Property ModoGUIImpresion As ModoVentana

    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER

    Public sCod_Cliente As String = String.Empty
    Public sCod_Almacen As String
    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private colEmpresa As Color
    Public sNum_MovStk, sSer_Factura, sNum_Factura, sCod_CondVent, sPre_Unitario, sCod_Moneda, sImporteGastoFinanciero, sImporte_Otros, sCod_TipoFact, sCod_TipAnexo, sCod_Anexo, sNum_Packing, sPie_Factura2, sFlg_Status_Facturacion, sCod_EstCli, sFec_Emision As String

    'VARIABLES QUE VIENEN DEL OTRO FORMULARIO
    Public sCod_Embarque, sSerie, sNum_Fac, sFecEmi, sCod_TipAnex As String

    Private Sub FrmShowGuiasxFactPrendas_DatosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtSecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecuencia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaSecuencia(1)
        End If
    End Sub
    Private Sub txtLinea1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLinea1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaSecuencia(2)
        End If
    End Sub

    Private Sub BuscaSecuencia(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "VE_AYUDA_TG_CLIENTE_LUGENT '" & sTipo & "','" & sCod_Cliente & "','" & txtSecuencia.Text & "','" & txtLinea1.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtSecuencia.Text = oTipo.dtResultados.Rows(0)("secuencia")
            txtLinea1.Text = oTipo.dtResultados.Rows(0)("linea1")
            txtCod_CondVent.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("secuencia").Width = 200
        oTipo.DGridLista.RootTable.Columns("linea1").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtSecuencia.Text = Trim(Codigo)
            txtLinea1.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCod_CondVent.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtCod_CondVent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_CondVent.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCondicionVenta(1)
        End If
    End Sub
    Private Sub txtDes_CondVent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_CondVent.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCondicionVenta(2)
        End If
    End Sub
    Private Sub BuscaCondicionVenta(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Registro "
        oTipo.sQuery = "VE_AYUDA_LG_CONDVENT '" & sTipo & "','" & Trim(txtCod_CondVent.Text) & "','" & Trim(txtDes_CondVent.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_CondVent.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_CondVent.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCartaCredito.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 200
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_CondVent.Text = Trim(Codigo)
            txtDes_CondVent.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCartaCredito.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtCartaCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCartaCredito.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCaraCredito(1)
        End If
    End Sub
    Private Sub BuscaCaraCredito(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Registro "

        oTipo.sQuery = "VE_AYUDA_TG_CARTA_CREDITO '" & sTipo & "','" & Trim(txtCartaCredito.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCartaCredito.Text = oTipo.dtResultados.Rows(0)("num_cartacredito")
            txtCod_Termino_Venta.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("num_cartacredito").Width = 200
        oTipo.DGridLista.RootTable.Columns("fec_emision").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_CondVent.Text = Trim(Codigo)
            txtDes_CondVent.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCod_Termino_Venta.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtCod_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Termino_Venta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTerminoVentas(1)
        End If
    End Sub
    Private Sub txtDes_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Termino_Venta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTerminoVentas(2)
        End If
    End Sub
    Private Sub BuscaTerminoVentas(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Registro "

        oTipo.sQuery = "VE_AYUDA_CN_TERMINO_VENTA '" & sTipo & "','" & Trim(txtCod_Termino_Venta.Text) & "','" & Trim(txtDes_Termino_Venta.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Termino_Venta.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Termino_Venta.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCod_Flete.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 200
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Termino_Venta.Text = Trim(Codigo)
            txtDes_Termino_Venta.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtDes_Flete.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtCod_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Flete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaFlete(1)
        End If
    End Sub
    Private Sub txtDes_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Flete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaFlete(2)
        End If
    End Sub
    Private Sub BuscaFlete(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Registro "

        oTipo.sQuery = "VE_AYUDA_TG_TIPOFLETE '" & sTipo & "','" & Trim(txtCod_Flete.Text) & "','" & Trim(txtDes_Flete.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Flete.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Flete.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtImp_Flete.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 200
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Flete.Text = Trim(Codigo)
            txtDes_Flete.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtImp_Flete.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtImp_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Flete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtImp_Flete.Text) = "" Then
                txtImp_Flete.Text = 0
            End If
            txtImp_Seguro.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub
    Private Sub txtImp_Seguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Seguro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtImp_Seguro.Text) = "" Then
                txtImp_Seguro.Text = 0
            End If
            txtImp_Descuento.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub
    Private Sub txtImp_Descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Descuento.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtImp_Descuento.Text) = "" Then
                txtImp_Descuento.Text = 0
            End If
            txtImp_Desaduanaje.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub
    Private Sub txtImp_Desaduanaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Desaduanaje.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtImp_Desaduanaje.Text) = "" Then
                txtImp_Desaduanaje.Text = 0
            End If
            txtImp_Transporte_Pais_Destino.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub
    Private Sub txtImp_Transporte_Pais_Destino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Transporte_Pais_Destino.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtImp_Transporte_Pais_Destino.Text) = "" Then
                txtImp_Transporte_Pais_Destino.Text = 0
            End If
            txtCod_Embarque.Select()
        Else
            ValidarSoloNumeros(e)
        End If
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

        oTipo.Text = "Seleccione un Registro "

        oTipo.sQuery = "VE_AYUDA_TG_TIPEMB '" & sTipo & "','" & Trim(txtCod_Embarque.Text) & "','" & Trim(txtDes_Embarque.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Embarque.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Embarque.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtNom_Embarque.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 200
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 200
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
    Private Sub txtNom_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Embarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(txtNom_Embarque.Text) = "" Then
                txtNom_Embarque.Select()
            Else
                txtcod_tipo.Select()
            End If
        End If
    End Sub
    Private Sub txtcod_tipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_tipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTipoTransporte(1)
        End If
    End Sub
    Private Sub txtdes_tipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdes_tipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTipoTransporte(2)
        End If
    End Sub
    Private Sub BuscaTipoTransporte(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Registro "

        oTipo.sQuery = "VE_AYUDA_TG_TIPO_TRANSPORTE '" & sTipo & "','" & Trim(txtcod_tipo.Text) & "','" & Trim(txtdes_tipo.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtcod_tipo.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtdes_tipo.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtPie_Pagina2.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 200
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtcod_tipo.Text = Trim(Codigo)
            txtdes_tipo.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtPie_Pagina2.Select()
        End If
        oTipo = Nothing
    End Sub
    Private Sub txtPie_Pagina2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPie_Pagina2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPie_Pagina1.Select()
        End If
    End Sub
    Private Sub txtPie_Pagina1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPie_Pagina1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtCod_Vendor.Select()
        End If
    End Sub
    Private Sub txtCod_Vendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Vendor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtCod_Class.Select()
        End If
    End Sub
    Private Sub txtCod_Class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Class.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPor_Comision.Select()
        End If
    End Sub
    Private Sub txtPor_Comision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPor_Comision.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtNotify.Select()
        End If
    End Sub
    Private Sub txtNotify_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotify.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Select()
        End If
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Select Case ModoGUIImpresion
            Case ModoVentana.DesdeShowGuiaFacturaPrendas
                Call ProcesarDatos()

            Case ModoVentana.DesdeEmbarqueSolicitarFacturaAnticipada
                Call ProcesarFacturaAntinipada()
        End Select
    End Sub
    Sub ProcesarDatos()
        Try
            strSQL = "EXEC Ventas_Cambio_Estado_DocAlm_Prendas"
            strSQL &= vbNewLine & String.Format(" @Cod_almacen                  = '{0}'", sCod_Almacen)
            strSQL &= vbNewLine & String.Format(",@Num_movstk                   = '{0}'", sNum_MovStk)
            strSQL &= vbNewLine & String.Format(",@Ser_Factura                  = '{0}'", sSer_Factura)
            strSQL &= vbNewLine & String.Format(",@Num_Factura		            = '{0}'", sNum_Factura)
            strSQL &= vbNewLine & String.Format(",@Cod_CondVent                 = '{0}'", Trim(txtCod_CondVent.Text))
            strSQL &= vbNewLine & String.Format(",@Pre_Unitario                 = '{0}'", sPre_Unitario)
            strSQL &= vbNewLine & String.Format(",@Cod_Moneda                   = '{0}'", sCod_Moneda)
            strSQL &= vbNewLine & String.Format(",@Imp_Gastos_Financieros       = '{0}'", sImporteGastoFinanciero)
            strSQL &= vbNewLine & String.Format(",@Imp_Otros                    = '{0}'", sImporte_Otros)
            strSQL &= vbNewLine & String.Format(",@Cod_TipoFact                 = '{0}'", sCod_TipoFact)
            strSQL &= vbNewLine & String.Format(",@cod_tipanex                  = '{0}'", sCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo                     = '{0}'", sCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Observaciones_Factura        = '{0}'", Trim(txtObservacion.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_LugEnt                   = '{0}'", Trim(txtSecuencia.Text))
            strSQL &= vbNewLine & String.Format(",@Num_CartaCredito             = '{0}'", FixNulos(Trim(txtCartaCredito.Text), 8))
            strSQL &= vbNewLine & String.Format(",@cod_cliente                  = '{0}'", sCod_Cliente)
            strSQL &= vbNewLine & String.Format(",@Imp_Flete                    = '{0}'", Trim(txtImp_Flete.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Seguro                   = '{0}'", Trim(txtImp_Seguro.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Descuento                = '{0}'", Trim(txtImp_Descuento.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Termino_Venta            = '{0}'", Trim(txtCod_Termino_Venta.Text))
            strSQL &= vbNewLine & String.Format(",@Num_Packing                  = '{0}'", sNum_Packing)
            strSQL &= vbNewLine & String.Format(",@Cod_Embarque                 = '{0}'", Trim(txtCod_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Nom_Embarque                 = '{0}'", Trim(txtNom_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Pie_Factura1                 = '{0}'", Trim(txtPie_Pagina1.Text))
            strSQL &= vbNewLine & String.Format(",@Pie_Factura2                 = '{0}'", sPie_Factura2)
            strSQL &= vbNewLine & String.Format(",@Flg_Status_Facturacion       = '{0}'", "A")
            strSQL &= vbNewLine & String.Format(",@Cod_estcli                   = '{0}'", sCod_EstCli)
            strSQL &= vbNewLine & String.Format(",@Fec_Emision                  = '{0}'", sFec_Emision)
            strSQL &= vbNewLine & String.Format(",@Cod_Vendor                   = '{0}'", Trim(txtCod_Vendor.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Class                    = '{0}'", Trim(txtCod_Class.Text))
            strSQL &= vbNewLine & String.Format(",@Num_Embarque                 = '{0}'", FixNulos(oHP.DevuelveDato("select num_embarque FROM TG_EMBARQUE where ref_embarque = '" & txtRef_Embarque.Text & "'", cCONNECT), 0))
            strSQL &= vbNewLine & String.Format(",@cod_usuario                  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Por_comision                 = '{0}'", Trim(txtPor_Comision.Text))
            strSQL &= vbNewLine & String.Format(",@imp_Desaduanaje              = '{0}'", Trim(txtImp_Desaduanaje.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Transporte_Pais_Destino  = '{0}'", Trim(txtImp_Transporte_Pais_Destino.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_TipoTransporte           = '{0}'", Trim(txtcod_tipo.Text))
            strSQL &= vbNewLine & String.Format(",@cod_flete                    = '{0}'", Trim(txtCod_Flete.Text))
            strSQL &= vbNewLine & String.Format(",@Descripcion_Resumen          = '{0}'", Trim(txtPie_Pagina2.Text))
            strSQL &= vbNewLine & String.Format(",@Notify_Factura               = '{0}'", Trim(txtNotify.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub ProcesarFacturaAntinipada()
        Try
            'NOS FALTA ESTE STORE
            strSQL = "EXEC VENTAS_GRABAR_DATOS_FACTURACION_ANTICIPADA_X_EMBARQUE"
            strSQL &= vbNewLine & String.Format(" @Num_Embarque                 = '{0}'", FixNulos(oHP.DevuelveDato("select num_embarque FROM TG_EMBARQUE where ref_embarque = '" & txtRef_Embarque.Text & "'", cCONNECT), 0))
            strSQL &= vbNewLine & String.Format(",@Ser_Factura                  = '{0}'", sSer_Factura)
            strSQL &= vbNewLine & String.Format(",@Num_Factura		            = '{0}'", sNum_Factura)
            strSQL &= vbNewLine & String.Format(",@Cod_CondVent                 = '{0}'", Trim(txtCod_CondVent.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Gastos_Financieros       = '{0}'", sImporteGastoFinanciero)
            strSQL &= vbNewLine & String.Format(",@Imp_Otros                    = '{0}'", sImporte_Otros)
            strSQL &= vbNewLine & String.Format(",@cod_tipanex                  = '{0}'", sCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo                     = '{0}'", sCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Observaciones_Factura        = '{0}'", Trim(txtObservacion.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_LugEnt                   = '{0}'", Trim(txtSecuencia.Text))
            strSQL &= vbNewLine & String.Format(",@Num_CartaCredito             = '{0}'", FixNulos(Trim(txtCartaCredito.Text), 8))
            strSQL &= vbNewLine & String.Format(",@cod_cliente                  = '{0}'", sCod_Cliente)
            strSQL &= vbNewLine & String.Format(",@Imp_Flete                    = '{0}'", Trim(txtImp_Flete.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Seguro                   = '{0}'", Trim(txtImp_Seguro.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Descuento                = '{0}'", Trim(txtImp_Descuento.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Termino_Venta            = '{0}'", Trim(txtCod_Termino_Venta.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Embarque                 = '{0}'", Trim(txtCod_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Nom_Embarque                 = '{0}'", Trim(txtNom_Embarque.Text))
            strSQL &= vbNewLine & String.Format(",@Pie_Factura1                 = '{0}'", Trim(txtPie_Pagina1.Text))
            strSQL &= vbNewLine & String.Format(",@Flg_Status_Facturacion       = '{0}'", "A")
            strSQL &= vbNewLine & String.Format(",@Fec_Emision                  = '{0}'", sFec_Emision)
            strSQL &= vbNewLine & String.Format(",@Cod_Vendor                   = '{0}'", Trim(txtCod_Vendor.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Class                    = '{0}'", Trim(txtCod_Class.Text))
            strSQL &= vbNewLine & String.Format(",@cod_usuario                  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Por_comision                 = '{0}'", Trim(txtPor_Comision.Text))
            strSQL &= vbNewLine & String.Format(",@imp_Desaduanaje              = '{0}'", Trim(txtImp_Desaduanaje.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Transporte_Pais_Destino  = '{0}'", Trim(txtImp_Transporte_Pais_Destino.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_TipoTransporte           = '{0}'", Trim(txtcod_tipo.Text))
            strSQL &= vbNewLine & String.Format(",@cod_flete                    = '{0}'", Trim(txtCod_Flete.Text))
            strSQL &= vbNewLine & String.Format(",@Descripcion_Resumen          = '{0}'", Trim(txtPie_Pagina2.Text))
            strSQL &= vbNewLine & String.Format(",@Notify_Factura               = '{0}'", Trim(txtNotify.Text))
            'strSQL &= vbNewLine & String.Format(" @Cod_almacen                  = '{0}'", sCod_Almacen)
            'strSQL &= vbNewLine & String.Format(",@Num_movstk                   = '{0}'", sNum_MovStk)
            'strSQL &= vbNewLine & String.Format(",@Pre_Unitario                 = '{0}'", sPre_Unitario)
            'strSQL &= vbNewLine & String.Format(",@Cod_Moneda                   = '{0}'", sCod_Moneda)
            'strSQL &= vbNewLine & String.Format(",@Cod_TipoFact                 = '{0}'", sCod_TipoFact)
            'strSQL &= vbNewLine & String.Format(",@Num_Packing                  = '{0}'", sNum_Packing)
            'strSQL &= vbNewLine & String.Format(",@Pie_Factura2                 = '{0}'", sPie_Factura2)
            'strSQL &= vbNewLine & String.Format(",@Cod_estcli                   = '{0}'", sCod_EstCli)
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class