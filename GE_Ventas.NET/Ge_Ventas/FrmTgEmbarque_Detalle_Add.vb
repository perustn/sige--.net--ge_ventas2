Public Class FrmTgEmbarque_Detalle_Add
    Enum ModoVentana
        DesdeDetalleProducto = 2
    End Enum

    Property ModoGUIImpresion As ModoVentana

    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private colEmpresa As Color
    Public sCod_Cliente As String
    Public sNum_Embarque, sSec_Embarque As String
    Public sAccion As String

    Private Sub FrmTgEmbarque_Detalle_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Select Case ModoGUIImpresion

            Case ModoVentana.DesdeDetalleProducto
                Me.Height = 350
                Me.grpDetalleProgramado.Visible = False
                Me.grpDetalleReal.Visible = False
                txtarancelaria1.Visible = False
                txtarancelaria2.Visible = False
                txtarancelaria3.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                optClienteTemporada.Visible = False
                Label6.Text = "OP................."
            Case Else
                Label6.Text = "NP................."
                'Call ImprimirTransferencias()
        End Select

        ActiveControl = txtCod_OrdPro
    End Sub

    Private Sub optOP_Click(sender As Object, e As EventArgs) Handles optOP.Click,
                                                                      optClienteTemporada.Click
        pnlOP.Visible = False : pnlClienteTemporada.Visible = False
        Limpiar()

        Select Case sender.tag
            Case "1"
                pnlOP.Visible = True
                txtCod_OrdPro.Select()

            Case "2"
                pnlClienteTemporada.Visible = True
                txtcliente.Select()
        End Select
    End Sub

    Sub Limpiar()
        txtcliente.Text = String.Empty
        txtDes_Cliente.Text = String.Empty
        txtCod_TemCli.Text = String.Empty
        txtNom_TemCli.Text = String.Empty
        txtestilo.Text = String.Empty
        txtCod_OrdPro.Text = String.Empty
        txtDes_OrdPro.Text = String.Empty
    End Sub
    Private Sub txtcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCliente(1)
        End If
    End Sub

    Private Sub txtDes_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCliente(2)
        End If
    End Sub

    Private Sub BuscaCliente(sTipo As Integer)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_TG_CLIENTE '" & sTipo & "','" & Trim(txtcliente.Text) & "','" & Trim(txtDes_Cliente.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            sCod_Cliente = oTipo.dtResultados.Rows(0)("CODIGO")
            txtcliente.Text = oTipo.dtResultados.Rows(0)("ABR_CLIENTE")
            txtDes_Cliente.Text = oTipo.dtResultados.Rows(0)("NOMBRE_CLIENTE")
            txtCod_TemCli.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("CODIGO").Width = 80
        oTipo.DGridLista.RootTable.Columns("ABR_CLIENTE").Width = 90
        oTipo.DGridLista.RootTable.Columns("NOMBRE_CLIENTE").Width = 200
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            sCod_Cliente = Trim(Codigo)
            txtcliente.Text = Trim(Descripcion)
            txtDes_Cliente.Text = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
            txtCod_TemCli.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_TemCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TemCli.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTemporada(1)
        End If
    End Sub

    Private Sub txtNom_TemCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_TemCli.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTemporada(2)
        End If
    End Sub

    Private Sub BuscaTemporada(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "cf_ayuda_TG_TemCli '" & sTipo & "','" & sCod_Cliente & "','" & Trim(txtCod_TemCli.Text) & "','" & Trim(txtNom_TemCli.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_TemCli.Text = oTipo.dtResultados.Rows(0)("CODIGO")
            txtNom_TemCli.Text = oTipo.dtResultados.Rows(0)("DESCRIPCION")
            txtestilo.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("CODIGO").Width = 90
        oTipo.DGridLista.RootTable.Columns("DESCRIPCION").Width = 90
        oTipo.DGridLista.RootTable.Columns("COD_CLIENTE").Width = 90
        oTipo.DGridLista.RootTable.Columns("NOM_CLIENTE").Width = 90
        'oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_TemCli.Text = Trim(Codigo)
            txtNom_TemCli.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtestilo.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtestilo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestilo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEstilo()
        End If
    End Sub

    Private Sub txtCod_OrdPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_OrdPro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCod_OrdPro.Text.Trim = "" Then
                txtCod_OrdPro.Select()
            Else
                txtCod_OrdPro.Text = RellenaDeCerosEnIzquierda(txtCod_OrdPro.Text, 5)
                Call BuscaOP(txtCod_OrdPro.Text)
            End If
        Else
            ValidarSoloNumeros(e, False)
        End If
    End Sub

    Sub BuscaOP(sOP As String)
        Dim consulta As String
        consulta = "SM_MUESTRA_Cod_OrdPro '001','" & sOP & "'"
        Dim odt As DataTable = oHP.DevuelveDatos(consulta, cCONNECT)

        If odt.Rows.Count > 0 Then
            txtDes_OrdPro.Text = odt.Rows(0)("DES_ESTPRO")
            txtAbr_Cliente.Text = odt.Rows(0)("abr_cliente")
            sCod_Cliente = odt.Rows(0)("Cod_Cliente")
            txtNom_Cliente.Text = odt.Rows(0)("nom_cliente")
            txtCod_PurOrd.Text = odt.Rows(0)("cod_purord")
            txtCod_LotPurOrd.Select()
        Else
            MessageBox.Show("OP no existe, favor validar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCod_OrdPro.Text = String.Empty
            txtDes_OrdPro.Text = String.Empty
            txtCod_OrdPro.Select()
            Exit Sub
        End If
    End Sub

    Private Sub BuscaEstilo()

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "SM_TG_EstCliEst_ViewxCliente '" & sCod_Cliente & "','" & txtCod_TemCli.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtestilo.Text = oTipo.dtResultados.Rows(0)("COD_ESTCLI")

            txtestilo.Select()
            Call BuscaDetalle(txtestilo.Text)
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("COD_ESTCLI").Width = 80
        oTipo.DGridLista.RootTable.Columns("DES_ESTCLI").Width = 100
        oTipo.DGridLista.RootTable.Columns("COD_ESTPRO").Width = 70
        oTipo.DGridLista.RootTable.Columns("COD_VERSION").Width = 50
        oTipo.DGridLista.RootTable.Columns("CLIENTE").Width = 80
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtestilo.Text = Trim(Codigo)

            Codigo = "" : Descripcion = ""
            txtestilo.Select()
            Call BuscaDetalle(txtestilo.Text)
        End If
        oTipo = Nothing
    End Sub

    Private Sub BuscaDetalle(sCod_Estilo As String)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "TG_MUESTRA_LOTES_CLIENTE_TEMPORADA_ESTILO '" & sCod_Cliente & "','" & Trim(txtCod_TemCli.Text) & "','" & Trim(txtestilo.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtAbr_Cliente.Text = txtcliente.Text
            txtNom_Cliente.Text = txtDes_Cliente.Text
            txtCod_PurOrd.Text = oTipo.dtResultados.Rows(0)("PO")
            txtCod_LotPurOrd.Text = oTipo.dtResultados.Rows(0)("LOTE")
            txtCod_EstCli.Text = oTipo.dtResultados.Rows(0)("ESTILO")

            txtarancelaria1.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("PO").Width = 90
        oTipo.DGridLista.RootTable.Columns("LOTE").Width = 100
        oTipo.DGridLista.RootTable.Columns("ESTILO").Width = 100

        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtAbr_Cliente.Text = txtcliente.Text
            txtNom_Cliente.Text = txtDes_Cliente.Text
            txtCod_PurOrd.Text = Trim(Codigo)
            txtCod_LotPurOrd.Text = Trim(Descripcion)
            txtCod_EstCli.Text = Trim(TipoAdd)
            Codigo = "" : Descripcion = ""
            txtarancelaria1.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_LotPurOrd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_LotPurOrd.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaPO(1)
        End If
    End Sub

    Private Sub BuscaPO(sTipo As String)

        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "TG_EMBARQUE_MUESTRA_LOTE_PO_PARTIDA_ARANCELARIA '" & sCod_Cliente & "','" & Trim(txtCod_PurOrd.Text) & "','" & Trim(txtCod_LotPurOrd.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_LotPurOrd.Text = oTipo.dtResultados.Rows(0)("COD_LOTPURORD")
            txtCod_EstCli.Text = oTipo.dtResultados.Rows(0)("COD_ESTCLI")
            txtarancelaria1.Text = oTipo.dtResultados.Rows(0)("NUM_PARTIDA_ARANCELARIA")
            txtarancelaria2.Text = oTipo.dtResultados.Rows(0)("SEC_PARTIDA_ARANCELARIA")
            txtarancelaria3.Text = oTipo.dtResultados.Rows(0)("NUM_CATEGORIA_INTERNACIONAL")
            txtarancelaria1.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("COD_LOTPURORD").Width = 80
        oTipo.DGridLista.RootTable.Columns("COD_ESTCLI").Width = 80
        oTipo.DGridLista.RootTable.Columns("NUM_PARTIDA_ARANCELARIA").Width = 80
        oTipo.DGridLista.RootTable.Columns("SEC_PARTIDA_ARANCELARIA").Width = 80
        oTipo.DGridLista.RootTable.Columns("NUM_CATEGORIA_INTERNACIONAL").Width = 80

        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_LotPurOrd.Text = oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("COD_LOTPURORD").Index)
            txtCod_EstCli.Text = oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("COD_ESTCLI").Index)
            txtarancelaria1.Text = oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("NUM_PARTIDA_ARANCELARIA").Index)
            txtarancelaria2.Text = oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("SEC_PARTIDA_ARANCELARIA").Index)
            txtarancelaria3.Text = oTipo.DGridLista.GetValue(oTipo.DGridLista.RootTable.Columns("NUM_CATEGORIA_INTERNACIONAL").Index)

            Dim DT As DataTable = oHP.DevuelveDatos("SM_DATOS_PURORD_LOTE '" & sCod_Cliente & "','" & txtCod_PurOrd.Text & "','" & txtCod_LotPurOrd.Text & "','" & txtCod_EstCli.Text & "'", cCONNECT)

            If DT.Rows.Count > 0 Then
                txtNum_Cajas_Prog.Text = DT.Rows(0)("Num_Cajas").ToString
                txtNum_Prendas_Prog.Text = DT.Rows(0)("Num_Prendas").ToString
            End If


            Codigo = "" : Descripcion = ""
            txtarancelaria1.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_EstCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_EstCli.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtarancelaria1.Select()
        End If
    End Sub

    Private Sub txtarancelaria1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarancelaria1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtarancelaria2.Select()
        End If
    End Sub

    Private Sub txtarancelaria2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarancelaria2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtarancelaria3.Select()
        End If
    End Sub

    Private Sub txtarancelaria3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarancelaria3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtNum_Prendas_Prog.Select()
        End If
    End Sub

    Private Sub txtNum_Prendas_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Prendas_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPre_Unitario.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtPre_Unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPre_Unitario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtNum_Cajas_Prog.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtNum_Cajas_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Cajas_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPeso_Bruto_Prog.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtPeso_Bruto_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Bruto_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPeso_Neto_Prog.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtPeso_Neto_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Neto_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtCubicaje_Prog.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtCubicaje_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCubicaje_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            Select Case ModoGUIImpresion

                Case ModoVentana.DesdeDetalleProducto
                    strSQL = "EXEC TG_EMBARQUE_PRODUCTOS_MAN"
                    strSQL &= vbNewLine & String.Format(" @Accion             = '{0}'", sAccion)
                    strSQL &= vbNewLine & String.Format(",@num_embarque       = '{0}'", sNum_Embarque)
                    strSQL &= vbNewLine & String.Format(",@Sec_Embarque       = '{0}'", Trim(sSec_Embarque))
                    strSQL &= vbNewLine & String.Format(",@Cod_Cliente		  = '{0}'", sCod_Cliente)
                    strSQL &= vbNewLine & String.Format(",@Cod_PurOrd         = '{0}'", Trim(txtCod_PurOrd.Text))
                    strSQL &= vbNewLine & String.Format(",@Cod_LotPurOrd      = '{0}'", Trim(txtCod_LotPurOrd.Text))
                    strSQL &= vbNewLine & String.Format(",@Cod_Estcli         = '{0}'", Trim(txtCod_EstCli.Text))
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO        = '{0}'", vusu)

                    If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Case Else
                    strSQL = "EXEC TG_EMBARQUE_PRENDAS_MAN"

                    strSQL &= vbNewLine & String.Format(" @Accion                       = '{0}'", sAccion)
                    strSQL &= vbNewLine & String.Format(",@num_embarque                 = '{0}'", sNum_Embarque)
                    strSQL &= vbNewLine & String.Format(",@Sec_Embarque                 = '{0}'", Trim(sSec_Embarque))
                    strSQL &= vbNewLine & String.Format(",@Cod_Cliente		            = '{0}'", sCod_Cliente)
                    strSQL &= vbNewLine & String.Format(",@Cod_PurOrd                   = '{0}'", Trim(txtCod_PurOrd.Text))
                    strSQL &= vbNewLine & String.Format(",@Cod_LotPurOrd                = '{0}'", Trim(txtCod_LotPurOrd.Text))
                    strSQL &= vbNewLine & String.Format(",@Cod_Estcli                   = '{0}'", Trim(txtCod_EstCli.Text))
                    strSQL &= vbNewLine & String.Format(",@Num_Prendas_Prog		        = '{0}'", Trim(txtNum_Prendas_Prog.Text))
                    strSQL &= vbNewLine & String.Format(",@Pre_Unitario                 = '{0}'", Trim(txtPre_Unitario.Text))
                    strSQL &= vbNewLine & String.Format(",@Num_Cajas_Prog               = '{0}'", Trim(txtNum_Cajas_Prog.Text))
                    strSQL &= vbNewLine & String.Format(",@Peso_Bruto_Prog              = '{0}'", Trim(txtPeso_Bruto_Prog.Text))
                    strSQL &= vbNewLine & String.Format(",@Peso_Neto_Prog		        = '{0}'", Trim(txtPeso_Neto_Prog.Text))
                    strSQL &= vbNewLine & String.Format(",@Cubicaje_Prog		        = '{0}'", Trim(txtCubicaje_Prog.Text))
                    strSQL &= vbNewLine & String.Format(",@Num_Partida_Arancelaria      = '{0}'", Trim(txtarancelaria1.Text))
                    strSQL &= vbNewLine & String.Format(",@Sec_Partida_Arancelaria      = '{0}'", Trim(txtarancelaria2.Text))
                    strSQL &= vbNewLine & String.Format(",@Num_Categoria_Internacional  = '{0}'", Trim(txtarancelaria3.Text))

                    If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class