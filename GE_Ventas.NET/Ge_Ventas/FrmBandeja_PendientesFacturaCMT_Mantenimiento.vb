Imports Janus.Windows.GridEX
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient

Public Class FrmBandeja_PendientesFacturaCMT_Mantenimiento
    'Dim oBtnSeguridad As New clsBtnSeguridadJanus
    Dim strSQL As String
    Dim oHP As New clsHELPER
    Private ds As New DataTable
    Private Const K_strColCheckItem As String = "ColCheckItem"
    Private sender_address As String
    Private colEmpresa As Color
    Private rs As New ADODB.Recordset
    Private sTipoEnvio_Correo As String

    Private Sub Bandeja_PendientesFacturaCMT_Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel1.BackColor = colEmpresa
        Asigna_ComboBox()
        Lista_Usuarios()
        Listar_Correos_Agregados()
    End Sub
    Private Sub Asigna_ComboBox()
        Try
            Dim dt As New DataTable
            Dim query As String = "EXEC SP_MANTENIMIENTO_EMAIL_LOG_FACTURA 'B','','','',''"

            Using conexion As New SqlConnection(cCONNECT)
                Using comando As New SqlCommand(query, conexion)
                    conexion.Open()
                    Dim adaptador As New SqlDataAdapter(comando)
                    adaptador.Fill(dt)
                End Using
            End Using

            cmbTipoEnvio.DataSource = dt
            cmbTipoEnvio.DisplayMember = "Descripcion"
            cmbTipoEnvio.ValueMember = "Codigo"

            If cmbTipoEnvio.Items.Count > 0 Then
                cmbTipoEnvio.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Lista_Usuarios()
        strSQL = ""
        strSQL = $"EXEC SP_MUESTRA_LISTA_USUARIOS_CORREOS_FACTURAS_CMT"

        ds = oHP.DevuelveDatos(strSQL, cCONNECT)

        GridEX1.DataSource = Nothing
        GridEX1.DataSource = ds

        CheckLayoutGridEx(GridEX1)
        'AdicionarCheckGridEx(GridEX1, 0)


        With GridEX1
            .FilterMode = FilterMode.Automatic
            .DefaultFilterRowComparison = FilterConditionOperator.Contains

            With .RootTable
                .RowHeight = 25
                .PreviewRow = True
                .PreviewRowMember = "Observacion"
                .PreviewRowLines = 4

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .FilterEditType = FilterEditType.Combo

                    End With
                Next

                With GridEX1.RootTable
                    If .Columns.Count > 0 Then
                        .Columns("Cod_usuario").Width = 70
                        .Columns("Cod_usuario").Caption = "COD USUARIO"

                        .Columns("Usuario").Width = 180
                        .Columns("Usuario").Caption = "USUARIO"

                        .Columns("email").Width = 180
                        .Columns("email").Caption = "EMAIL"
                    End If

                    If Not .Columns.Contains(K_strColCheckItem) Then
                        .Columns.Add(New GridEXColumn With {
                        .Key = K_strColCheckItem,
                        .Caption = String.Empty,
                        .Width = 35,
                        .ColumnType = ColumnType.CheckBox,
                         .EditType = EditType.CheckBox,
                        .ActAsSelector = True,
                        .Visible = True
                        })
                    End If
                    .Columns(K_strColCheckItem).Position = 0

                End With
            End With

        End With

        'OcultaColumnasGridEx(GridEX1, New String() {"Cod_usuario"})

        'FormatoColumnas(GridEX1, New List(Of ModelGridEx) From {
        '    New ModelGridEx With {.columna = "Cod_usuario", .ancho_columna = 70, .texto_cabecera = "COD USUARIO"},
        '    New ModelGridEx With {.columna = "Usuario", .ancho_columna = 180, .texto_cabecera = "USUARIO"},
        '    New ModelGridEx With {.columna = "email", .ancho_columna = 180, .texto_cabecera = "EMAIL"}
        '})

    End Sub

    Private Sub Listar_Correos_Agregados()

        If Not cmbTipoEnvio.SelectedValue Is Nothing Then
            sTipoEnvio_Correo = cmbTipoEnvio.SelectedValue.ToString()
        End If


        strSQL = ""
        strSQL = $"EXEC SP_MANTENIMIENTO_EMAIL_LOG_FACTURA 'V','','','','{sTipoEnvio_Correo}'"

        ds = oHP.DevuelveDatos(strSQL, cCONNECT)

        GridEX2.DataSource = Nothing
        GridEX2.DataSource = ds

        CheckLayoutGridEx(GridEX2)
        'AdicionarCheckGridEx(GridEX2, 0)

        With GridEX2
            .FilterMode = FilterMode.Automatic
            .DefaultFilterRowComparison = FilterConditionOperator.Contains

            With .RootTable
                .RowHeight = 25
                .PreviewRow = True
                .PreviewRowMember = "Observacion"
                .PreviewRowLines = 4

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                With GridEX2.RootTable
                    If .Columns.Count > 0 Then
                        .Columns("Secuencia").Width = 35
                        .Columns("Secuencia").TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
                        .Columns("Secuencia").Caption = "SEC"

                        .Columns("Cod_usuario").Width = 60
                        .Columns("Cod_usuario").Caption = "COD USUARIO"

                        .Columns("Nom_Usuario").Width = 155
                        .Columns("Nom_Usuario").Caption = "USUARIO"

                        .Columns("email").Width = 145
                        .Columns("email").Caption = "EMAIL"

                        .Columns("Tipo").Width = 65
                        .Columns("Tipo").Caption = "TIPO"

                    End If

                    If Not .Columns.Contains(K_strColCheckItem) Then
                        .Columns.Add(New GridEXColumn With {
                        .Key = K_strColCheckItem,
                        .Caption = String.Empty,
                        .Width = 35,
                        .ColumnType = ColumnType.CheckBox,
                         .EditType = EditType.CheckBox,
                        .ActAsSelector = True,
                        .Visible = True
                        })
                    End If
                    .Columns(K_strColCheckItem).Position = 0

                End With
            End With


        End With



        'OcultaColumnasGridEx(GridEX2, New String() {"Cod_usuario"})

        'FormatoColumnas(GridEX2, New List(Of ModelGridEx) From {
        '    New ModelGridEx With {.columna = "Secuencia", .ancho_columna = 35, .alineacion = TextAlignment.Center, .texto_cabecera = "SEC"},
        '    New ModelGridEx With {.columna = "Cod_usuario", .ancho_columna = 60, .texto_cabecera = "COD USUARIO"},
        '    New ModelGridEx With {.columna = "Nom_Usuario", .ancho_columna = 155, .texto_cabecera = "USUARIO"},
        '    New ModelGridEx With {.columna = "email", .ancho_columna = 145, .texto_cabecera = "EMAIL"},
        '    New ModelGridEx With {.columna = "Tipo", .ancho_columna = 65, .texto_cabecera = "TIPO"}
        '})
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim FilasCheck = GridEX1.GetCheckedRows()
        If FilasCheck.Length = 0 Then
            MessageBox.Show("Debe seleccionar los usuarios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not cmbTipoEnvio.SelectedValue Is Nothing Then
            sTipoEnvio_Correo = cmbTipoEnvio.SelectedValue.ToString
        End If

        Try
            For Each row As Janus.Windows.GridEX.GridEXRow In GridEX1.GetCheckedRows()
                If Not IsDBNull(row.Cells("Cod_usuario").Value) Then

                    Dim Cod_Usuario As String = row.Cells("Cod_usuario").Value.ToString().Trim()
                    Dim Email As String = row.Cells("email").Value.ToString().Trim()
                    Dim TipoCorreo As String = row.Cells("email").Value.ToString().Trim()

                    strSQL = ""
                    strSQL = $"EXEC SP_MANTENIMIENTO_EMAIL_LOG_FACTURA 'I','{Cod_Usuario}','','{Email}',{sTipoEnvio_Correo}"
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                End If
            Next

            MessageBox.Show("Usuarios guardados correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Listar_Correos_Agregados()
            Call Lista_Usuarios()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim FilasCheck = GridEX2.GetCheckedRows()
        If FilasCheck.Length = 0 Then
            MessageBox.Show("Debe seleccionar los usuarios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not cmbTipoEnvio.SelectedValue Is Nothing Then
            sTipoEnvio_Correo = cmbTipoEnvio.SelectedValue.ToString
        End If

        Try
            For Each row As Janus.Windows.GridEX.GridEXRow In GridEX2.GetCheckedRows()

                If Not IsDBNull(row.Cells("Cod_usuario").Value) Then
                    Dim Cod_Usuario As String = row.Cells("Cod_usuario").Value.ToString().Trim()
                    Dim Secuencia As String = row.Cells("Secuencia").Value.ToString().Trim()
                    Dim Email As String = row.Cells("email").Value.ToString().Trim()

                    strSQL = ""
                    strSQL = $"EXEC SP_MANTENIMIENTO_EMAIL_LOG_FACTURA 'D','{Cod_Usuario}','{Secuencia}','{Email}','{sTipoEnvio_Correo}'"
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                End If
                'row.Cells(K_strColCheckItem).Value = False
            Next
            'If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
            MessageBox.Show("Usuarios Eliminados correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            Call Listar_Correos_Agregados()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbTipoEnvio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEnvio.SelectedIndexChanged
        Listar_Correos_Agregados()
    End Sub
End Class