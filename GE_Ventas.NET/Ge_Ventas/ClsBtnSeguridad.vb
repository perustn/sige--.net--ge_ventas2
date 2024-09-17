Imports Janus.Windows.GridEX

Public Class ClsBtnSeguridad
    Dim strSql As String
    Dim oHP As New clsHELPER
    Public Sub GetBotonesJanus(xPerfil As String, xEmpresa As String, xFormulario As String, NombreBarra As Janus.Windows.ButtonBar.ButtonBar, KeyNames As String)
        Try
            KeyNames = GetAccessButton(xPerfil, xEmpresa, xFormulario, KeyNames)
            'Habilitar los Botones
            HabilitaBotonesBar(NombreBarra, KeyNames)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetAccessButton(xPerfil As String, xEmpresa As String,
                                            xFormulario As String,
                                            KeyNames As String) As String
        Try
            If String.IsNullOrEmpty(KeyNames) Then
                'Consultar en la BD los botones que tiene acceso el perfil
                Dim b As Short
                strSql = "SEG_MUESTRA_ACCESOS_FORMULARIOS_FUNCION '" & xPerfil & "','" & xEmpresa & "','" & xFormulario & "'"
                Dim DtBotones As DataTable = oHP.DevuelveDatos(strSql, cSEGURIDAD)
                For b = 0 To DtBotones.Rows.Count - 1
                    KeyNames += DtBotones.Rows(b)(0).ToString + "/"
                Next
            End If
            GetAccessButton = KeyNames
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Sub DefinirSeguridadEnGrillaJanus(ByRef grxJanus As GridEX,
                                       ByVal strCodPerfilUsuario As String,
                                       ByVal strCodEmpresa As String,
                                       ByVal strGUI As String,
                                       Optional KeyNames As String = "")
        Try
            KeyNames = GetAccessButton(strCodPerfilUsuario, strCodEmpresa, strGUI, KeyNames)
            Dim Matriz As Object
            Matriz = Split(KeyNames, "/")

            Dim oFormatoBotonDesactivado As New GridEXFormatStyle With {.BackColor = Color.LightGray,
                                                                        .ForeColor = Color.Gray,
                                                                        .FontBold = TriState.True
                                                                        }
            Dim bolSW As Boolean
            Dim TieneFiltro As Boolean
            Dim x As Integer
            With grxJanus
                If .FilterMode <> FilterMode.None Then
                    TieneFiltro = True
                End If

                For Each oGridEXTable As GridEXTable In .Tables

                    For Each oGridEXColumn As GridEXColumn In oGridEXTable.Columns

                        With oGridEXColumn

                            If .ButtonStyle = ButtonStyle.ButtonCell Then
                                bolSW = False
                                'For Each oDataRow As DataRow In oDtAccesos.Rows
                                For x = 0 To UBound(Matriz) - 1
                                    If .Key.ToString.Trim.ToUpper = Matriz(x).ToString.ToUpper Then
                                        bolSW = True
                                        Exit For
                                    End If
                                Next
                                If bolSW = False Then
                                    .ButtonStyle = ButtonStyle.NoButton
                                    With .CellStyle
                                        .BackColor = Color.LightGray
                                        .ForeColor = Color.Gray
                                        .FontBold = TriState.True
                                    End With

                                End If
                            End If
                        End With
                    Next
                Next
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "DefinirSeguridadEnGrillaJanus")
        End Try

    End Sub

    Public Sub HabilitaBotonesBar(NombreBarra As Janus.Windows.ButtonBar.ButtonBar, KeyNames As String)
        Try
            Dim y, x, i As Short
            'Obtener la cantidad de grupos de la barra
            Dim totalgrupos As Integer = NombreBarra.Groups.Count
            For y = 0 To totalgrupos - 1
                'Inhabilitar todos los botones de la barra de cada grupo
                Dim totalbotones As Integer = NombreBarra.Groups(y).Items.Count
                For x = 0 To totalbotones - 1
                    NombreBarra.Groups(y).Items(x).Enabled = False
                Next
            Next

            'Habilitar los botones (KeyNames)
            Dim Matriz As Object
            Dim Mayor As Integer

            Matriz = Split(KeyNames, "/")
            Mayor = UBound(Matriz)
            For y = 0 To totalgrupos - 1
                'Habilitar todos los botones que concidan con los nombres de la matriz
                Dim totalbotones As Integer = NombreBarra.Groups(y).Items.Count
                For x = 0 To totalbotones - 1
                    For i = 0 To Mayor
                        If NombreBarra.Groups(y).Items(x).Key = Matriz(i).ToString Then
                            NombreBarra.Groups(y).Items(Matriz(i).ToString).Enabled = True
                        End If
                    Next i
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

