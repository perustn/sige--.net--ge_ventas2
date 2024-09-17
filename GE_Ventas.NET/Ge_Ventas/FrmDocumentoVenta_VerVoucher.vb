Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_VerVoucher
    Private strSQL As String = String.Empty
    Private strSQLTraza As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sCod_TipoDiario As String
    Public sano As String
    Public smes As String
    Public lNum_Registro As Long
    Public Num_Corre As String
    Public dImporte As Double
    Public sAccion As String
    Public sItem As String, sccta As String
    Dim sEsCtaCte As String, sdebehaber As String, sEstado As String
    Public sFec_Transaccion As String, smoneda As String

    Public sSecuencia As Integer

    Private Sub FrmDocumentoVenta_VerVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel2.BackColor = colEmpresa

        Me.ActiveControl = GrdLista
    End Sub

    Public Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Fi_Muestra_Voucher_Contable"
        strSQL &= vbNewLine & String.Format(" @cod_tipodiario   = '{0}'", sCod_TipoDiario)
        strSQL &= vbNewLine & String.Format(",@ano              = '{0}'", sano)
        strSQL &= vbNewLine & String.Format(",@mes              = '{0}'", smes)
        strSQL &= vbNewLine & String.Format(",@num_registro     =  {0} ", Val(lNum_Registro))
        strSQLTraza = strSQL

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdLista.DataSource = oDT
        CheckLayoutGridEx(GrdLista)

        With GrdLista
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next
            End With
        End With
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "IMPRIMIR"
                    Imprimir()

                Case "GENERAR"
                    Generar

                Case "REVERTIR"
                    Revertir()

                Case "ADICIONAR"
                    sAccion = "I"
                    sItem = ""
                    txtSer_Docum.Enabled = True
                    txtNum_Docum.Enabled = True
                    txtDoc_Sunat.Enabled = True

                    txtCuenta.Text = ""
                    txtDes_Cuenta.Text = ""
                    txtTipodeCambio.Text = 0
                    txtDebe.Text = 0
                    txtDebeDol.Text = 0
                    txtHaber.Text = 0
                    txtHaberDol.Text = 0
                    txtGlosa.Text = ""
                    txtGlosa.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCIO").Index)
                    txtDoc_Sunat.Text = ""
                    txtSer_Docum.Text = ""
                    txtNum_Docum.Text = ""
                    txtCuenta.Enabled = True
                    Me.fraDatos.Visible = True

                Case "MODIFCUENTA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    sAccion = "U"
                    sItem = GrdLista.GetValue(GrdLista.RootTable.Columns("item").Index)
                    txtCuenta.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CUENTA").Index)

                    sEstado = oHP.DevuelveDato("select DBO.CN_Status_CierreTipoDiario('" & sano & "','" & smes & "','" & sCod_TipoDiario & "','')", cCONNECT)

                    If sEstado = "S" Then
                        MessageBox.Show("DIARIO /SUBDIARIO SE ENCUENTRA CERRADO. VERIFICAR CON EL USUARIO RESPONSABLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    sEsCtaCte = oHP.DevuelveDato("select DBO.CN_EvaluaCuenta_Contable_Es_Cta_Cte('" & sano & "','" & txtCuenta.Text & "')", cCONNECT)
                    If UCase(sEsCtaCte) = "S" Then
                        txtSer_Docum.Enabled = False
                        txtNum_Docum.Enabled = False
                        txtDoc_Sunat.Enabled = False
                    Else
                        txtSer_Docum.Enabled = True
                        txtNum_Docum.Enabled = True
                        txtDoc_Sunat.Enabled = True
                    End If

                    txtDes_Cuenta.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                    txtTipodeCambio.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPCAM").Index)
                    smoneda = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Moneda_Docum").Index)
                    sdebehaber = GrdLista.GetValue(GrdLista.RootTable.Columns("FLG_DEBE_HABER").Index)
                    txtDebe.Text = 0
                    txtDebeDol.Text = 0
                    txtHaber.Text = 0
                    txtHaberDol.Text = 0

                    If GrdLista.GetValue(GrdLista.RootTable.Columns("FLG_DEBE_HABER").Index) = "D" Then
                        txtDebe.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("IMPORTE").Index)
                        txtDebeDol.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DOLARES").Index)
                    Else
                        txtHaber.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("IMPORTE").Index)
                        txtHaberDol.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DOLARES").Index)
                    End If
                    txtGlosa.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCIO").Index)
                    txtDoc_Sunat.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index))
                    txtDes_Cuenta.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("DES_TIPDOC").Index))
                    txtSer_Docum.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("SERIE").Index))
                    txtNum_Docum.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("NUMERO").Index))
                    txtCuenta.Enabled = True
                    Me.fraDatos.Visible = True
                    txtCuenta.Focus()

                Case "ELIMINAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    sAccion = "D"
                    sItem = GrdLista.GetValue(GrdLista.RootTable.Columns("item").Index)
                    txtCuenta.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CUENTA").Index)
                    txtDes_Cuenta.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                    txtTipodeCambio.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPCAM").Index)

                    txtDebe.Text = 0
                    txtDebeDol.Text = 0
                    txtHaber.Text = 0
                    txtHaberDol.Text = 0

                    sEsCtaCte = oHP.DevuelveDato("select DBO.CN_EvaluaCuenta_Contable_Es_Cta_Cte('" & sano & "','" & txtCuenta.Text & "')", cCONNECT)
                    If UCase(sEsCtaCte) = "S" Then
                        txtSer_Docum.Enabled = False
                        txtNum_Docum.Enabled = False
                        txtDoc_Sunat.Enabled = False
                    Else
                        txtSer_Docum.Enabled = True
                        txtNum_Docum.Enabled = True
                        txtDoc_Sunat.Enabled = True
                    End If

                    If GrdLista.GetValue(GrdLista.RootTable.Columns("FLG_DEBE_HABER").Index) = "D" Then
                        txtDebe.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("IMPORTE").Index)
                        txtDebeDol.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DOLARES").Index)
                    Else
                        txtHaber.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("IMPORTE").Index)
                        txtHaberDol.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DOLARES").Index)
                    End If
                    txtGlosa.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCIO").Index)
                    txtDoc_Sunat.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index))
                    txtDes_Cuenta.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("DES_TIPDOC").Index))
                    txtSer_Docum.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("SERIE").Index))
                    txtNum_Docum.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("NUMERO").Index))
                    txtCuenta.Enabled = False
                    Me.fraDatos.Visible = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Imprimir()
        Dim oo As Object
        Dim ruta As String
        Dim sModoEjecutarTransaccion As String
        Dim strSQL As String
        Dim sEmpresa As String

        sEmpresa = oHP.DevuelveDato("SELECT des_empresa FROM seg_empresas WHERE Cod_Empresa ='" & vemp & "'", cSEGURIDAD)

        If RTrim(sCod_TipoDiario) = "21" Or RTrim(sCod_TipoDiario) = "24" Or RTrim(sCod_TipoDiario) = "25" Then
            ruta = vRuta & "\RptVoucherVentas.XLT"
        Else
            ruta = vRuta & "\RptVoucherVentas2.XLT"
        End If
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(ruta)
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("Reporte", cCONNECTVB6, sCod_TipoDiario, sano, smes, lNum_Registro, Num_Corre, sEmpresa)
        oo = Nothing
    End Sub

    Public Sub Generar()
        Try
            If MessageBox.Show("Confirma Voucher de Ventas ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = "CN_GENERA_ASIENTO_VENTAS_LETRAS_X_COBRAR '" & Num_Corre & "'"
                oHP.EjecutaOperacion(strSQL, cCONNECT)

                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC FI_Muestra_Datos_Transaccion"
                strSQL &= vbNewLine & String.Format(" @NUM_TRANSACCION      = '{0}'", Num_Corre)
                Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                Dim oDr As DataRow
                If Not oDtResult Is Nothing Then
                    If oDtResult.Rows.Count = 0 Then Exit Sub
                    oDr = oDtResult.Rows(0)
                    sCod_TipoDiario = oDr("Cod_TipoDiario")
                    sano = oDr("Ano_Contable")
                    smes = oDr("Mes_Contable")
                    lNum_Registro = oDr("Num_Registro")
                    dImporte = oDr("Importe")
                End If
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Revertir()
        If MessageBox.Show("¿Confirma REVERSION DE MOVIMIENTO BANCARIO ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_REVIERTE_ASIENTO_VENTAS"
            strSQL &= vbNewLine & String.Format(" @Num_Corre = '{0}'", Num_Corre)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_GRID()
                'GrdLista.Row = FilaSeleccionada
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If RTrim(txtCuenta.Text) = "" Then
                BUSCA_CUENTACONTABLE(3)
            Else
                BUSCA_CUENTACONTABLE(1)
            End If
        End If
    End Sub

    Private Sub BUSCA_CUENTACONTABLE(Tipo As Integer)
        Select Case Tipo
            Case 1
                strSQL = "SELECT COD_CTACONT as 'Código', DES_CTACONT as 'Descripción' " &
                         "FROM CN_PLANCONTABLE  WHERE ANO = '" & sano & "' AND   COD_CTACONT like '" & Trim(txtCuenta.Text) & "%' ORDER BY COD_CTACONT"

            Case 2, 3
                strSQL = "SELECT COD_CTACONT AS 'Código', " &
                " DES_CTACONT as 'Descripción' " &
                "FROM CN_PLANCONTABLE " &
                "WHERE ANO = '" & sano & "' AND  DES_CTACONT LIKE '%" & Trim(Me.txtDes_Cuenta.Text) _
                & "%' AND DATALENGTH(RTRIM(COD_CTACONT )) = 8 ORDER BY 2"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.sQuery = strSQL
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCuenta.Text = Trim(oTipo.dtResultados.Rows(0)("Código"))
            txtDes_Cuenta.Text = Trim(oTipo.dtResultados.Rows(0)("Descripción"))
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCuenta.Text = Trim(oTipo.RegistroSeleccionado.Cells("Código").Value)
                txtDes_Cuenta.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripción").Value)
            End If
        End If
        If sdebehaber = "D" Then
            If smoneda = "SOL" Then
                txtDebe.Focus()
            Else
                txtDebeDol.Focus()
            End If
        Else
            If smoneda = "SOL" Then
                txtHaber.Focus()
            Else
                txtHaberDol.Focus()
            End If

        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""

        oTipo = Nothing
    End Sub

    Private Sub txtDes_Cuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Cuenta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtTipodeCambio.Focus()
        End If
    End Sub

    Private Sub txtTipodeCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipodeCambio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDebe.Focus()
        End If
    End Sub

    Private Sub txtDebe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebe.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDebeDol.Text = Math.Round(Val(txtDebe.Text) / Val(txtTipodeCambio.Text), 2)
            If txtDebe.Text = 0 Then
                txtHaber.Focus()
            Else
                BtnAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub txtHaber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHaber.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtHaberDol.Text = Math.Round(Val(txtHaber.Text) / Val(txtTipodeCambio.Text), 2)
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub txtDebeDol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebeDol.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDebe.Text = Math.Round(Val(txtDebeDol.Text) * Val(txtTipodeCambio.Text), 2)
            If txtDebeDol.Text = 0 Then
                txtHaberDol.Focus()
            Else
                BtnAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub txtHaberDol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHaberDol.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtHaber.Text = Math.Round(Val(txtHaberDol.Text) * Val(txtTipodeCambio.Text), 2)
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub txtDoc_Sunat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDoc_Sunat.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_TipoDocuSunat
        End If
    End Sub

    Sub Busca_TipoDocuSunat()
        Dim oTipo As New frmBusGeneral7
        oTipo.sQuery = "select Doc_Sunat as Codigo, cod_TipDoc as Tip_Doc, Des_TipDoc as Descripcion from cn_tiposdocum where Doc_Sunat LIKE '%" & Trim(txtDoc_Sunat.Text) & "%' order by Doc_Sunat"
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtDoc_Sunat.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
            txtDes_TipDoc.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
            txtSer_Docum.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtDoc_Sunat.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                txtDes_TipDoc.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                txtSer_Docum.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtDes_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipDoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDes_Cuenta.Focus()
        End If
    End Sub

    Private Sub txtSer_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSer_Docum.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDes_Cuenta.Focus()
        End If
    End Sub

    Private Sub txtNum_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Docum.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDes_Cuenta.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim sTipodeImpo As String
            Dim xImporte As Double
            Dim xImporteDolares As Double

            If Val(txtDebe) + Val(txtDebeDol) > 0 Then
                sTipodeImpo = "1"
                xImporte = txtDebe.Text
                xImporteDolares = txtDebeDol.Text

            Else
                sTipodeImpo = "2"
                xImporte = txtHaber.Text
                xImporteDolares = txtHaberDol.Text
            End If

            Num_Corre = GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_CORRE_DET").Index)

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_CambiaCuenta_Movim"
            strSQL &= vbNewLine & String.Format(" @Ano              = '{0}'", sano)
            strSQL &= vbNewLine & String.Format(",@Mes              = '{0}'", smes)
            strSQL &= vbNewLine & String.Format(",@Cod_TipoDiario   = '{0}'", sCod_TipoDiario)
            strSQL &= vbNewLine & String.Format(",@COMPROB          = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("comprob").Index))
            strSQL &= vbNewLine & String.Format(",@ITEM             = '{0}'", sItem)
            strSQL &= vbNewLine & String.Format(",@COD_CTACONT      = '{0}'", txtCuenta.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_TRANSACCION  =  {0} ", 0)
            strSQL &= vbNewLine & String.Format(",@ACCION           = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@TIPO_CAMBIO_DOLARES  =  {0} ", txtTipodeCambio.Text)
            strSQL &= vbNewLine & String.Format(",@TIPODEIMPO       = '{0}'", sTipodeImpo)
            strSQL &= vbNewLine & String.Format(",@IMPORTE_SOLES    =  {0} ", xImporte)
            strSQL &= vbNewLine & String.Format(",@IMPORTE_DOLARES  =  {0} ", xImporteDolares)
            strSQL &= vbNewLine & String.Format(",@GLOSA            = '{0}'", txtGlosa.Text)
            strSQL &= vbNewLine & String.Format(",@DOC_SUNAT        = '{0}'", txtDoc_Sunat.Text)
            strSQL &= vbNewLine & String.Format(",@SER_DOCUM        = '{0}'", txtSer_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_DOCUM        = '{0}'", txtNum_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE_VENTAS = '{0}'", Num_Corre)
            strSQL &= vbNewLine & String.Format(",@FEC_TRANSACCION  = '{0}'", sFec_Transaccion)
            strSQL &= vbNewLine & String.Format(",@SECUENCIA        =  {0} ", sSecuencia)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                Me.fraDatos.Visible = False
                CARGA_GRID()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.fraDatos.Visible = False
    End Sub
End Class