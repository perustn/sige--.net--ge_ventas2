Option Strict Off
Option Explicit On
Module ModRutinas
#If DEBUG Then
    Public ReadOnly IsDebugMode As Boolean = True
    Public sCadena As String = String.Empty
#Else
    Public ReadOnly IsDebugMode As Boolean = False
    Public sCadena As String = String.Empty
#End If

    '    Function ExisteCampo(ByRef pCampo As String, ByRef pTabla As String, ByRef pValor As Object, ByRef Conexion As String, Optional ByRef pEsStringValor As Boolean = True) As Boolean
    '        On Error GoTo hand

    '        If pEsStringValor Then
    '            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pValor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevuelveCampo(select count( & pCampo & ) from  & pTabla &  where  & pCampo &  = ' & pValor & ', Conexion). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            If DevuelveCampo("select count(" & pCampo & ") from " & pTabla & " where " & pCampo & " = '" & pValor & "'", Conexion) > 0 Then
    '                ExisteCampo = True
    '            Else
    '                ExisteCampo = False
    '            End If
    '        Else
    '            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pValor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevuelveCampo(select count( & pCampo & ) from  & pTabla &  where  & pCampo &  =  & pValor, Conexion). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            If DevuelveCampo("select count(" & pCampo & ") from " & pTabla & " where " & pCampo & " = " & pValor, Conexion) > 0 Then
    '                ExisteCampo = True
    '            Else
    '                ExisteCampo = False
    '            End If
    '        End If
    '        Exit Function
    'hand:
    '        ErrorHandler(Err, "ExisteCampo")
    '        ExisteCampo = False
    '    End Function
    Public Sub Aviso(ByRef Mensaje As String, ByRef Tipo As Short)
        Select Case Tipo
            Case 1
                MsgBox(Mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Case 2
                MsgBox(Mensaje, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "Mensaje")
            Case 3
                MsgBox(Mensaje, MsgBoxStyle.Critical, "Error Grave")
        End Select
    End Sub
    Function FixNulos(ByRef wtexto As Object, ByRef wTipo As Short) As Object
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(wtexto) Then
            Select Case wTipo
                Case 2, 3, 4, 5
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = 0
                Case 7
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = Nothing '(" Empty 'Format$("", "mm/dd/yyyy")
                Case 8
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = ""
                Case 11
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = False
                Case 12
                    wtexto = Now
            End Select
        ElseIf Len(Trim(wtexto)) = 0 Then
            Select Case wTipo
                Case 2, 3, 4, 5
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = 0
                Case 7
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = Nothing '(" Empty 'Format$("", "mm/dd/yyyy")
                Case 8
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = ""
                Case 11
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wtexto = False
            End Select
        End If
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto wtexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto FixNulos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FixNulos = wtexto
    End Function
    Public Sub LlenaComboNET(objComboBox As Janus.Windows.EditControls.UIComboBox, strQuery As String, Conexion As String)

        Dim Registros As New DataTable
        Dim oHP As New clsHELPER
        Registros = oHP.DevuelveDatos(strQuery, Conexion)

        If Registros.Rows.Count > 0 Then
            With objComboBox
                objComboBox.DataSource = Registros
                objComboBox.ValueMember = Registros.Columns(0).ColumnName()
                objComboBox.DisplayMember = Registros.Columns(1).ColumnName()
                'objComboBox.SelectedIndex = 0
            End With
        Else
            objComboBox.DataSource = Nothing
            objComboBox.Text = "===SIN REGISTROS === "
        End If
    End Sub
    Public Sub ImpresionCIP(sFabrica As String, sOrden As String, sSecuencia As String)
        'CREAMOS EL ARCHIVO DONDE GUARDAREMOS EL CODIFO ZPL
        Const ArchivoCips As String = "C:\TEMP\SIP.txt"

        'INSTANCIAMOS DE LA CLASE PRINTER
        'Dim Printer As New Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer        
        Dim strSQL As String = String.Empty
        Dim oHP As New clsHELPER
        Dim sw As New System.IO.StreamWriter(ArchivoCips)

        strSQL = "CF_GENERA_DATOS_TICKETS_PRENDAS_A_TRANSMITIR '" & sFabrica & "','" & sOrden & "'"

        Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)


        If (Dt.Rows.Count <= 0) Then
            MessageBox.Show("La Orden Nro: " & sOrden & "-" & sSecuencia & " , No Cuenta Con Tips Generados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Parametro de po se le pasa codest
        Dim CodEst As String
        'Dim oDt As New ADODB.Recordset
        Dim NumSol As String
        Dim MatTip(80, 6) As String
        Dim i As Integer
        Dim TotTip As Integer
        Dim NSEASON As String
        Dim CTEMP As String
        Dim CSEASON As String

        'Creacion de variables para controlar la impresión
        Dim TotGen As Integer
        Dim TotCol As Integer
        Dim TmpCol As String
        Dim TmpTal As String
        Dim NumPos As Integer

        'Creacion de variables para la impresion de Tips
        Dim NumPed As String
        Dim CodTip As String
        Dim CodCol As String
        Dim NomCol As String
        Dim CodTal As String
        Dim DesTal As String
        Dim DesPred As String
        Dim ColRef As String
        Dim FindFlg As String

        Dim Texto As String
        Dim TextoResumenGeneral As String
        Dim FinLinea As String
        Dim NumDoc As Integer
        Dim a, j As Integer
        Dim CCanti As String

        Dim NumTip As Integer

        FinLinea = Chr(10) & Chr(13)

        For i = 0 To 79
            MatTip(i, 1) = ""
            MatTip(i, 2) = ""
            MatTip(i, 3) = ""
            MatTip(i, 4) = ""
            MatTip(i, 5) = ""
        Next

        TotGen = 0
        TotCol = 0
        TmpCol = ""
        TmpTal = ""
        NumPos = 0
        NumPed = ""

        For Each Row As DataRow In Dt.Rows
            CodTip = Trim(Row("Id"))
            NumPed = Trim(Row("Pedido"))
            CodCol = Trim(Row("Color"))
            NomCol = Trim(Row("Color"))
            ColRef = Trim(Row("Color_2"))
            CodTal = Trim(Row("Cod_Talla"))
            DesTal = Trim(Row("Cod_Talla"))
            DesPred = Trim(Row("Nombre_Estilo"))


            If (Len(DesPred) > 25) Then
                DesPred = Mid(DesPred, 1, 25)
            End If

            TotTip = TotTip + 1
            TotCol = 1
            FindFlg = "0"

            Do While (TotCol <= TotGen And TotGen <= 80)
                TmpCol = Trim(MatTip(TotCol, 1))
                TmpTal = Trim(MatTip(TotCol, 2))
                If (TmpCol = CodCol And TmpTal = CodTal) Then
                    FindFlg = "1"
                    Exit Do
                End If
                TotCol = TotCol + 1
            Loop

            If (FindFlg = "0") Then
                TotGen = TotGen + 1
                MatTip(TotGen, 1) = CodCol
                MatTip(TotGen, 2) = CodTal
                MatTip(TotGen, 3) = "1"
                MatTip(TotGen, 4) = NomCol
                MatTip(TotGen, 5) = DesTal
            Else
                MatTip(TotCol, 3) = CStr(CInt(MatTip(TotCol, 3)) + 1)
            End If

            Select Case NumPos
                Case 0
                    Texto = Chr(126) + "L" + FinLinea
                    'H10 Define la temperatura para la impresión, de acuerdo a esto saldra el color
                    'Este valor es por defecto Hn donde n = 10 , a mayor n mayor negrita
                    Texto = Texto + "H10" + FinLinea
                    'D11 Define la cabecera de un label que se va a imprimir
                    Texto = Texto + "D11" + FinLinea
                    'Q0001 indica el tipo de label que se va a usar en este caso Cantidad
                    Texto = Texto + "Q0001" + FinLinea
                    Texto = Texto + "191100100560005 T: " + CodTip + FinLinea
                    Texto = Texto + "191100100560072 Ped: " + NumPed + FinLinea
                    Texto = Texto + "191100100470005 " + DesPred + FinLinea
                    Texto = Texto + "191100100380005 C.Ref: " + Mid(Trim(ColRef), 1, 15) + FinLinea
                    '                Texto = Texto + "191100100300005 Color: " + Trim(CodCol) + " " + Mid(Trim(NomCol), 1, 7) + FinLinea
                    Texto = Texto + "191100100300005 Color: " + Mid(Trim(NomCol), 1, 12) + FinLinea
                    Texto = Texto + "191100100300095 S: " + DesTal + FinLinea

                    If (Len(Trim(CodTip)) = 10) Then
                        Texto = Texto + "1E2202100000025C" + Trim(CodTip) + FinLinea
                    End If

                    NumPos = 1
                Case 1
                    Texto = Texto + "191100100560140 T: " + CodTip + FinLinea
                    Texto = Texto + "191100100560207 Ped: " + NumPed + FinLinea
                    Texto = Texto + "191100100470140 " + DesPred + FinLinea
                    Texto = Texto + "191100100380140 C.Ref: " + Mid(Trim(ColRef), 1, 15) + FinLinea
                    '                Texto = Texto + "191100100300140 Color: " + Trim(CodCol) + " " + Mid(Trim(NomCol), 1, 7) + FinLinea
                    Texto = Texto + "191100100300140 Color: " + Mid(Trim(NomCol), 1, 12) + FinLinea
                    Texto = Texto + "191100100300230 S: " + DesTal + FinLinea

                    If Len(Trim(CodTip)) = 10 Then
                        Texto = Texto + "1E2202100000155C" + Trim(CodTip) + FinLinea
                    End If
                    NumPos = 2
                Case 2
                    Texto = Texto + "191100100560275 T: " + CodTip + FinLinea
                    Texto = Texto + "191100100560342 Ped: " + NumPed + FinLinea
                    Texto = Texto + "191100100470275 " + DesPred + FinLinea
                    Texto = Texto + "191100100380275 C.Ref: " + Mid(Trim(ColRef), 1, 15) + FinLinea
                    '                Texto = Texto + "191100100300275 Color: " + Trim(CodCol) + " " + Mid(Trim(NomCol), 1, 7) + FinLinea
                    Texto = Texto + "191100100300275 Color: " + Mid(Trim(NomCol), 1, 12) + FinLinea
                    Texto = Texto + "191100100300365 S: " + DesTal + FinLinea

                    If Len(Trim(CodTip)) = 10 Then
                        Texto = Texto + "1E2202100000300C" + Trim(CodTip) + FinLinea
                    End If
                    'E indica que termino el label
                    Texto = Texto + "E" + FinLinea

                    sw.WriteLine(Texto)
                    NumPos = 0
            End Select
            'ACA SE DEBE DE ACTUALIZAR EL TIP            
        Next

        If (NumPos = 1 Or NumPos = 2) Then
            Texto = Texto + "E" + FinLinea
            'Aca tambien se debe de imprimir
            sw.WriteLine(Texto)
        End If

        NumPos = 0
        NumDoc = 1

        If (TotTip > 0) Then
            'Etiquetas de Resumen General
            NumTip = CInt(TotGen / 5)
            NumTip = IIf(NumTip < (TotGen / 5), NumTip + 1, NumTip)
            TextoResumenGeneral = ""
            For j = 1 To NumDoc

                NumPos = 0
                Dim NumIte As Integer
                Dim strTotTip As String
                NumIte = 1
                strTotTip = CStr(TotTip)

                For i = 1 To NumTip
                    Select Case NumPos
                        Case 0
                            TextoResumenGeneral = TextoResumenGeneral + Chr(126) + "L" + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "H10" + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "D11" + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "Q0001" + FinLinea

                            TextoResumenGeneral = TextoResumenGeneral + "191100100610008" + Trim(CStr(i)) + "/" + Trim(CStr(NumTip)) + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100610058 Ped: " + NumPed + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510005 TIP's: " + strTotTip + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510058 Est: " + Trim(CodEst) + FinLinea

                            TotCol = 1
                            Do While (TotCol <= TotGen)
                                CodCol = Mid(Trim(MatTip(NumIte, 1)), 1, 5)
                                DesTal = Mid(Trim(MatTip(NumIte, 5)), 1, 5)
                                CCanti = Trim(MatTip(NumIte, 3))
                                '                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 10)
                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 13)
                                Select Case TotCol
                                    Case 1
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100410012" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100410043" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410012" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410093" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410109" + CCanti + FinLinea
                                    Case 2
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100310012" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100310043" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310012" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310093" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310109" + CCanti + FinLinea
                                    Case 3
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100210012" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100210043" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210012" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210093" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210109" + CCanti + FinLinea
                                    Case 4
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100110012" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100110043" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110012" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110093" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110109" + CCanti + FinLinea
                                    Case 5
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100010012" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100010043" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010012" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010093" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010109" + CCanti + FinLinea
                                End Select

                                TotCol = TotCol + 1
                                NumIte = NumIte + 1
                                NumPos = 1
                                If (TotCol > 5) Then
                                    Exit Do
                                End If
                            Loop

                        Case 1
                            TextoResumenGeneral = TextoResumenGeneral + "191100100610147" + Trim(CStr(i)) + "/" + Trim(CStr(NumTip)) + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100610197 Ped: " + NumPed + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510140 TIP's: " + strTotTip + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510197 Est: " + CodEst + FinLinea

                            TotCol = 1
                            Do While TotCol <= TotGen
                                CodCol = Trim(MatTip(NumIte, 1))
                                DesTal = Mid(Trim(MatTip(NumIte, 5)), 1, 5)
                                CCanti = Trim(MatTip(NumIte, 3))
                                '                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 10)
                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 13)
                                Select Case TotCol
                                    Case 1
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100410147" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100410178" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410147" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410227" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410247" + CCanti + FinLinea
                                    Case 2
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100310147" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100310178" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310147" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310227" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310247" + CCanti + FinLinea
                                    Case 3
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100210147" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100210178" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210147" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210227" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210247" + CCanti + FinLinea
                                    Case 4
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100110147" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100110178" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110147" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110227" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110247" + CCanti + FinLinea
                                    Case 5
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100010147" + CodCol + FinLinea
                                        '                                    TextoResumenGeneral = TextoResumenGeneral + "191100100010178" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010147" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010227" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010247" + CCanti + FinLinea
                                End Select

                                TotCol = TotCol + 1
                                NumIte = NumIte + 1
                                NumPos = 2
                                If TotCol > 5 Then
                                    Exit Do
                                End If
                            Loop
                        Case 2
                            TextoResumenGeneral = TextoResumenGeneral + "191100100610286" + Trim(CStr(i)) + "/" + Trim(CStr(NumTip)) + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100610336 Ped: " + NumPed + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510275 TIP's: " + strTotTip + FinLinea
                            TextoResumenGeneral = TextoResumenGeneral + "191100100510336 Est: " + CodEst + FinLinea
                            TotCol = 1

                            Do While TotCol <= TotGen
                                CodCol = Trim(MatTip(NumIte, 1))
                                DesTal = Mid(Trim(MatTip(NumIte, 5)), 1, 5)
                                CCanti = Trim(MatTip(NumIte, 3))
                                '                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 10)
                                NomCol = Mid(Trim(MatTip(NumIte, 4)), 1, 13)
                                Select Case TotCol
                                    Case 1
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100410284" + CodCol + FinLinea
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100410315" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410284" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410367" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100410387" + CCanti + FinLinea
                                    Case 2
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100310284" + CodCol + FinLinea
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100310315" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310284" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310367" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100310387" + CCanti + FinLinea
                                    Case 3
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100210284" + CodCol + FinLinea
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100210315" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210284" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210367" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100210387" + CCanti + FinLinea
                                    Case 4
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100110284" + CodCol + FinLinea
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100110315" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110284" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110367" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100110387" + CCanti + FinLinea
                                    Case 5
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100010284" + CodCol + FinLinea
                                        '                                            TextoResumenGeneral = TextoResumenGeneral + "191100100010315" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010284" + Trim(NomCol) + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010367" + DesTal + FinLinea
                                        TextoResumenGeneral = TextoResumenGeneral + "191100100010387" + CCanti + FinLinea

                                End Select

                                TotCol = TotCol + 1
                                NumIte = NumIte + 1
                                NumPos = 0
                                If TotCol > 5 Then
                                    Exit Do
                                End If
                            Loop
                            TextoResumenGeneral = TextoResumenGeneral + "E" + FinLinea
                            sw.WriteLine(TextoResumenGeneral)
                    End Select
                Next
                If NumPos = 1 Or NumPos = 2 Then
                    TextoResumenGeneral = TextoResumenGeneral + "E" + FinLinea
                    sw.WriteLine(TextoResumenGeneral)
                End If
            Next
            sw.Close()
            Call ImprimirArchivo(ArchivoCips) 'LLAMAMOS AL METODO DE IMPRESION
        End If
    End Sub
    Public Sub Imprime_ICA_ZPL(NUM_CAJA As String)
        'CREAMOS EL ARCHIVO DONDE GUARDAREMOS EL CODIFO ZPL
        Const ArchivoCips As String = "C:\TEMP\SIP.txt"

        'INSTANCIAMOS DE LA CLASE PRINTER
        'Dim Printer As New Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer
        Dim strSQL As String = String.Empty
        Dim oHP As New clsHELPER
        Dim sw As New System.IO.StreamWriter(ArchivoCips)

        strSQL = "ETIQUETA_CAJA_SALDO '" & NUM_CAJA & "','" & vusu & "','C'"

        Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

        'DECLARAMOS VARIABLES QUE USAREMOS PARA CAPTURAR LOS CAMPOS DE LA BD
        Dim zlpNroCaja, zlpCodCal, zlpCalidad, zlpCliente, zlpPO, zlpEstilo, zlpcantprendas, zlpusuario, zlppesocaja, zlpFec_Impresion, NomEmpresa As String
        Dim Cad1, Cad2, Cad3 As String
        Dim zlpfila1, zlpfila2, zlpfila3, zlpfila4, zlpfila5, zlpfila6, zlpfila7, zlpfila8, zlpfila9, zlpfila10, zlpfila11, zlpfila12, zlpfila13, zlpfila14, zlpfila15 As Integer
        Dim stFinal As String
        Dim xcol, xDet1, xFil, xRow, xReg1 As Integer

        For Each Row As DataRow In Dt.Rows
            zlpNroCaja = Row("num_caja")
            zlpCodCal = Row("COD_CALIDAD_CAJA_SALDOS")
            zlpCalidad = Row("DES_CALIDAD_SALDOS")
            zlpCliente = Row("Nom_Cliente")
            zlpPO = Row("Cod_PurOrd")
            zlpEstilo = Row("Cod_EstCli")
            zlpcantprendas = Row("Num_Prendas")
            zlpusuario = Row("Cod_Usuario_Encajado")
            zlppesocaja = Row("PesoBrutoCaja")
            zlpFec_Impresion = CStr(Row("fec_impresion"))
            NomEmpresa = Row("NomEmpresa")

            zlpfila1 = 590
            zlpfila2 = 570
            zlpfila3 = 540
            zlpfila4 = 360
            zlpfila5 = 590
            zlpfila6 = 520
            zlpfila7 = 390
            ' zlpfila8 = 455
            zlpfila8 = 550

            zlpfila9 = 560
            zlpfila10 = 490
            zlpfila11 = 470
            zlpfila12 = 440
            zlpfila13 = 420
            zlpfila14 = 400

            zlpfila15 = 525

            Cad1 = "^XA" & Chr(13) & Chr(10) &
                    "" & Chr(13) & Chr(10) &
                    "^FX" & Chr(13) & Chr(10) &
                    "^CFA,30" & Chr(13) & Chr(10)

            Cad2 = ""
            Cad3 = ""

            strSQL = "[ETIQUETA_CAJA_PRODUCCION_DETALLE_SALDOS] 0 ," & CStr(NUM_CAJA)
            Dim Dt1 As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

            Cad1 = Cad1 + "^FT140,80^A0N,028,010^FD" & NomEmpresa & "^FS" & Chr(13) & Chr(10) &
                        "^FT330,20^ABN,015,010^FD" & zlpCalidad & "^FS" & Chr(13) & Chr(10) &
                        "^FT340,60^ABN,015,010^FDPO:^FS" & Chr(13) & Chr(10) &
                        "^FT370,60^A0N,017,022^FD" & zlpPO & "^FS" & Chr(13) & Chr(10) &
                        "^FT180,175^ABN,015,010^FDEstilo^FS" & Chr(13) & Chr(10) &
                        "^FT" & Trim(Str(zlpfila2)) & ",335^A0N,017,022^FD" & zlpEstilo & "^FS" & Chr(13) & Chr(10) &
                        "^FT200,60^ABN,015,010^FDCliente:^FS" & Chr(13) & Chr(10) &
                        "^FT280,60^A0N,017,022^FD" & Trim(zlpCliente) & "^FS" & Chr(13) & Chr(10) &
                        "^FT570,60^ABN,015,010^FDPdas:^FS" & Chr(13) & Chr(10) &
                        "^FT630,60^A0N,017,022^FD" & Trim(Str(zlpcantprendas)) & "^FS" & Chr(13) & Chr(10) &
                        "^FT260,175^ABN,015,010^FDColor^FS" & Chr(13) & Chr(10)
            xcol = 200

            For xDet1 = 7 To Dt1.Columns.Count - 1
                xcol = xcol + 10 'Tallas
                'MessageBox.Show(Microsoft.VisualBasic.Left(Dt1.Rows(0)(xDet1), 5))
                Cad2 = Cad2 + "^FT" & Trim(Str(zlpfila4)) & "," & 175 & "^ABN,015,010^FD" & Microsoft.VisualBasic.Left(Dt1.Columns(xDet1).ToString, 5) & "^FS" & Chr(13) & Chr(10)
                zlpfila4 = zlpfila4 + 50
            Next

            xFil = 175
            xcol = 380
            xRow = 380
            'rsDetalleCajaImp.MoveFirst
            For Each Row1 As DataRow In Dt1.Rows
                xFil = xFil + 20
                xRow = xRow + 50 'Color
                xcol = 360
                Cad2 = Cad2 + "^FT260," & Trim(Str(xFil)) & "^ABN,015,010^FD" & Trim(Row1("NOMBRE COLOR")) & "^FS" & Chr(13) & Chr(10)
                Cad2 = Cad2 + "^FT180," & Trim(Str(xFil)) & "^ABN,015,010^FD" & Trim(Row1("COD_ESTCLI")) & "^FS" & Chr(13) & Chr(10)
                For xDet1 = 7 To Dt1.Columns.Count - 1
                    Cad2 = Cad2 + "^FT" & xcol & "," & xFil & "^ABN,015,010^FD" & Dt1.Rows(0)(xDet1) & "^FS" & Chr(13) & Chr(10)
                    xcol = xcol + 50
                Next
                xcol = 160
            Next

            Cad3 = "^FT300,135^BY2,3,^B3N,N,60,Y,N^FD" & zlpNroCaja & "^FS" & Chr(13) & Chr(10) &
                                    "^FT" & Trim(Str(zlpfila8)) & ",153^AON,012,002^FD" & zlpFec_Impresion & "^FS" & Chr(13) & Chr(10)
            'Código de barra
            stFinal = Cad1 + Cad2 + Cad3

            stFinal = stFinal + "^XZ"

            sw.WriteLine(stFinal)
        Next

        sw.Close()
        Call ImprimirArchivo(ArchivoCips) 'LLAMAMOS AL METODO DE IMPRESION
    End Sub
    Public Sub Imprime_ICA_ZEBRA_PRODUCCION(NUM_CAJA As String)

        'CREAMOS EL ARCHIVO DONDE GUARDAREMOS EL CODIFO ZPL
        Const ArchivoZPL As String = "C:\TEMP\ICA.txt"

        Dim strSQL As String = String.Empty
        Dim oHP As New clsHELPER
        'INSTANCIAMOS DE LA CLASE PRINTER
        'Dim Printer As New Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer

        Dim sw As New System.IO.StreamWriter(ArchivoZPL)

        strSQL = "EXEC ETIQUETA_CAJA_PRODUCCION '" & NUM_CAJA & "'"

        Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

        If Dt.Rows.Count = 0 Then
            MessageBox.Show("No Se Encontraron Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sw.Close()
            Exit Sub
        End If

        Dim FinLinea As String
        Dim FinLinea_2 As String
        Dim Texto As String

        FinLinea = Chr(13) & Chr(10)
        FinLinea_2 = Chr(34) + Chr(13) & Chr(10)

        Dim xCont, Cad1, Cad2, Cad3, X, xContImp As String

        Cad1 = ""
        Cad1 = Cad1 + "Q304,19" + FinLinea
        Cad1 = Cad1 + "q831" + FinLinea
        Cad1 = Cad1 + "rN" + FinLinea
        Cad1 = Cad1 + "S4" + FinLinea
        Cad1 = Cad1 + "D7" + FinLinea
        Cad1 = Cad1 + "ZT" + FinLinea
        Cad1 = Cad1 + "JB" + FinLinea
        Cad1 = Cad1 + "OD" + FinLinea
        Cad1 = Cad1 + "R161,0" + FinLinea
        Cad1 = Cad1 + "N" + FinLinea
        Cad1 = Cad1 + "FK" + FinLinea

        For Each Row As DataRow In Dt.Rows
            Cad1 = Cad1 + "A010,001,0,2,1,1,N," & Chr(34) & Trim(Row("Nom_Fabrica")) & FinLinea_2      'Empresa
            Cad1 = Cad1 + "A005,027,0,2,2,1,N," & Chr(34) & "PO:" & Trim(Row("Cod_PurOrd")) & FinLinea_2          'PO
            Cad1 = Cad1 + "A290,025,0,2,1,1,N," & Chr(34) & "CAJA:" & Trim(CStr(Row("Num_Caja"))) & FinLinea_2   'Caja
            Cad1 = Cad1 + "A290,045,0,2,1,1,N," & Chr(34) & "EST:" & Trim(Row("Cod_EstCli")) & FinLinea_2     'Estilo
            Cad1 = Cad1 + "A010,053,0,1,1,1,N," & Chr(34) & "CLTE:" & Microsoft.VisualBasic.Left(Trim(Row("Nom_Cliente")), 20) & FinLinea_2  'Cliente
            Cad1 = Cad1 + "A290,068,0,1,1,1,N," & Chr(34) & "PDAS: " & CStr(Row("Num_Prendas_Caja")) & FinLinea_2  'Prendas
            Cad1 = Cad1 + "A390,068,0,1,1,1,N," & Chr(34) & "CALD: " & Trim(Row("cod_calidad")) & FinLinea_2      'Calidad
            Cad1 = Cad1 + "A010,080,0,1,1,1,N," & Chr(34) & "COLOR" & FinLinea_2


            strSQL = "ETIQUETA_CAJA_PRODUCCION_DETALLE '" & Row("Num_Packing") & "','" & CStr(NUM_CAJA) & "'"
            Dim Dt1 As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)


            Dim xcol, xDet1, xFil, xReg1 As Integer
            'Descripcion de Tallas
            xcol = 200
            For xDet1 = 6 To Dt1.Columns.Count - 1
                Cad2 = Cad2 + "A" & CStr(xcol) & ",080,0,1,1,1,N," & Chr(34) & Left(Dt1.Columns(xDet1).ToString, 5) & FinLinea_2
                xcol = xcol + 50
            Next

            'Detalle x Color / Talla
            xFil = 100
            xcol = 200

            For xReg1 = 1 To Dt1.Rows.Count

                Cad2 = Cad2 + "A010," & CStr(xFil) & ",0,1,1,1,N," & Chr(34) & Left(Trim(Dt1.Rows(0)(xReg1)), 22) & FinLinea_2      'Descripcion del Color Partida

                For xDet1 = 6 To Dt1.Columns.Count - 1
                    Cad2 = Cad2 + "A" & CStr(xcol) & "," & CStr(xFil) & ",0,2,1,1,N," & Chr(34) & Dt1.Rows(0)(xDet1) & FinLinea_2
                    xcol = xcol + 50
                Next

                xFil = xFil + 25
                xcol = 200
            Next

            Cad3 = Cad3 + "A310,210,0,1,1,1,N," & Chr(34) & "Peso Neto :" & Row("PesoNetoCaja") & FinLinea_2  'Kgs. Prendas
            Cad3 = Cad3 + "A310,225,0,1,1,1,N," & Chr(34) & "Tara      :" & Row("Peso_Tara_Caja") & FinLinea_2      'Kgs. Tara
            Cad3 = Cad3 + "A310,240,0,1,1,1,N," & Chr(34) & "Peso Bruto:" & Row("PesoBrutoCaja") & FinLinea_2     'Kgs. Neto

            'Cad3 = Cad3 + "A310,210,0,1,1,1,N," & Chr(34) & "Peso Neto :" & VB6.Format(CStr(Row("PesoNetoCaja")), "#0") & FinLinea_2  'Kgs. Prendas
            'Cad3 = Cad3 + "A310,225,0,1,1,1,N," & Chr(34) & "Tara      :" & VB6.Format(CStr(Row("Peso_Tara_Caja")), "#0") & FinLinea_2      'Kgs. Tara
            'Cad3 = Cad3 + "A310,240,0,1,1,1,N," & Chr(34) & "Peso Bruto:" & VB6.Format(CStr(Row("PesoBrutoCaja")), "#0") & FinLinea_2     'Kgs. Neto
            Cad3 = Cad3 + "B015,185,4,1,3,0,50,B," & Chr(34) & Trim(CStr(Row("Num_Caja"))) & FinLinea_2          'Codigo Barra
            Cad3 = Cad3 + "A010,270,0,1,1,1,N," & Chr(34) & "Usuario: " & Trim(Row("Cod_Usuario_Encajado")) & FinLinea_2 'Usuario
            Cad3 = Cad3 + "A280,270,0,1,1,1,N," & Chr(34) & CStr(Row("fecha_servidor")) & FinLinea_2   'Fecha y Hora

            Texto = Cad1 + Cad2 + Cad3 + "P1" + FinLinea

            sw.WriteLine(Texto)
        Next

        sw.Close()

        Call ImprimirArchivo(ArchivoZPL) 'LLAMAMOS AL METODO DE IMPRESION

    End Sub
    Public Sub IMPRIME_ZPL(NUM_CAJA As String) 'ESTE METODO RECIBE  UN ARRAY EJEM: "538174,538175,538179"

        'CONVERTIMOS EL TEXTO EN 
        Dim CaracterSeparador() As String = {","}
        Dim NumeroCajas() As String

        'SEPARAMOS LAS CAJAS
        NumeroCajas = NUM_CAJA.Split(CaracterSeparador, StringSplitOptions.None)

        'CREAMOS EL ARCHIVO DONDE GUARDAREMOS EL CODIFO ZPL
        Const ArchivoZPL As String = "C:\TEMP\ZPL_ICA.txt"

        'ABRIMOS EL ARCHIVO PARA SU ESCRITURA
        Dim sw As New System.IO.StreamWriter(ArchivoZPL)

        'RECORREMOS TODAS LAS CAJAS
        For Each NumeroCaja As String In NumeroCajas

            Dim strSQL As String = String.Empty
            Dim oHP As New clsHELPER

            'INSTANCIAMOS DE LA CLASE PRINTER
            'Dim Printer As New Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer

            strSQL = "EXEC CF_CajaDespacho_GetEtiqueta '1','" & NumeroCaja & "',0,0,'" & vusu & "','" & ComputerName() & "'"

            Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

            If Dt.Rows.Count = 0 Then
                MessageBox.Show("No Se Pudo Imprimir La Caja [" & NumeroCaja & "]" & " Ya que No Cuenta Con Prendas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'sw.Close()
                'Exit Sub
                Continue For
            End If

            'DECLARAMOS VARIABLES QUE USAREMOS PARA CAPTURAR LOS CAMPOS DE LA BD
            Dim zplCliente, zplCalidad, zplOp, zplEpv, zplCodigo, zplColor, zplTalla, zplCantidad, zplNumeroDeCaja, zplPo, zplEstado, zplPesoNeto, zplPesoTara, zplPesoBruto, zplUsuario, zplFecha, zplTotalDePrendas As String
            Dim CadenaInicial, CadenaCabecera, CadenaContenido, CadenaFinal As String
            Dim CadenaCuadroContenido, CadenaCuadroResumen, CadenaCodigoBarra, CadenaUsuarioFecha As String
            Dim mbLetras, mbCuadro, mbInicialTotalPrendas, mbInicialLineaResumen As Integer
            'Dim PosicionDerecha, IncrementadorDerecha, x, y As Integer

            CadenaInicial = "^XA^FS " & Chr(13) & Chr(10) &
                            "^POI" & Chr(13) & Chr(10) &
                            "^PR4^FS" & Chr(13) & Chr(10) &
                            "^LH5, 40 ^ FS" & Chr(13) & Chr(10)

            CadenaContenido = ""
            CadenaCodigoBarra = ""
            CadenaCuadroResumen = ""
            CadenaCuadroContenido = ""

            CadenaFinal = "^XZ" & Chr(13) & Chr(10)


            'AQUI TRAEMOS AL CLIENTE Y LA CALIDAD
            'For Each Row As DataRow In Dt.Rows
            '    zplCliente = Row("Cliente")
            '    zplCalidad = Row("Calidad")
            'Next

            'PINTAMOS CABECERA
            CadenaCabecera = "^FO580, 1 ^ GB205, 35, 1 ^ FS" & Chr(13) & Chr(10) &
                            "^FO060, 1 ^ GB725, 35, 1 ^ FS" & Chr(13) & Chr(10) &
                            "^FO700, 1 ^ GB85, 35, 1 ^ FS" & Chr(13) & Chr(10) &
                            "^FO060, 1 ^ GB95, 35, 1 ^ FS" & Chr(13) & Chr(10) &
                            "^FT070, 25 ^ A0, 20, 20 ^ FDCLIENTE: ^FS" & Chr(13) & Chr(10) &
                            "^FT170,025^A0,020,020^FD" & Dt.Rows(0)("CLIENTE") & "^FS" & Chr(13) & Chr(10) &
                            "^FT600,025^A0,020,020^FDCALIDAD:^FS" & Chr(13) & Chr(10) &
                            "^FT710,025^A0,020,020^FD" & Dt.Rows(0)("CALIDAD") & "^FS" & Chr(13) & Chr(10) &
                            "^FO060,051^GB725,030,1^FS" & Chr(13) & Chr(10) &
                            "^FO115,051^GB572,030,1^FS" & Chr(13) & Chr(10) &
                            "^FO204,051^GB379,030,1^FS" & Chr(13) & Chr(10) &
                            "^FO302,051^GB281,030,1^FS" & Chr(13) & Chr(10) &
                            "^FT080,070^A0,015,015^FDOP^FS" & Chr(13) & Chr(10) &
                            "^FT145,070^A0,015,015^FDEPV^FS" & Chr(13) & Chr(10) &
                            "^FT230,070^A0,015,015^FDCODIGO^FS" & Chr(13) & Chr(10) &
                            "^FT380,070^A0,015,015^FDCOLOR^FS" & Chr(13) & Chr(10) &
                            "^FT612,070^A0,015,015^FDTALLA^FS" & Chr(13) & Chr(10) &
                            "^FT703,070^A0,015,015^FDCANTIDAD^FS" & Chr(13) & Chr(10)

            Dim Position As Array = {10, 20, 70, 130, 230, 320, 630, 735}
            Dim i As Integer = 0

            'Margin Button
            mbLetras = 100
            mbCuadro = 25
            mbInicialTotalPrendas = 105
            mbInicialLineaResumen = 80

            For Each Row As DataRow In Dt.Rows
                zplCliente = Row("Cliente")
                zplCalidad = Row("Calidad")
                zplOp = Row("OP")
                zplEpv = Row("EPV")
                zplCodigo = Row("Cod_ColCli")
                zplColor = Row("Nom_ColCli")
                zplTalla = Row("Cod_Talla")
                zplCantidad = Row("Num_Prendas")
                zplNumeroDeCaja = Row("Num_Caja")
                zplPo = Row("Cod_PurOrd")
                zplEstado = Row("Estado")
                zplPesoNeto = Row("PesoNetoCaja")
                zplPesoTara = Row("Peso_Tara_Caja")
                zplPesoBruto = Row("PesoBrutoCaja")
                zplUsuario = Row("Usuario")
                zplFecha = Row("Fecha")
                zplTotalDePrendas = Row("total_prendas_por_caja")

                If mbLetras > 500 Then
                    'CadenaContenido = CadenaContenido + CadenaFinal + "^XA^FS" & Chr(13) & Chr(10)
                    CadenaContenido = CadenaContenido + CadenaFinal + "^XA^FS" & Chr(13) & Chr(10) & CadenaCabecera
                    mbLetras = 100
                    mbCuadro = 25
                    mbInicialTotalPrendas = 105
                    mbInicialLineaResumen = 80
                End If

                Dim xReg1 As Integer
                For xReg1 = 2 To Dt.Columns.Count - 11
                    'CadenaContenido = CadenaContenido + "^FT" & Position(xReg1) & "," & mbLetras & "^A0,015,015^FD" & Trim(Rs_Tickets.Fields(xReg1)) & "^FS" & Chr(13) & Chr(10)
                    CadenaContenido = CadenaContenido + "^FT" & Position(xReg1) & "," & mbLetras & "^A0,015,015^FD" & Dt.Rows(i)(xReg1).ToString.Trim & "^FS" & Chr(13) & Chr(10) &
                                                        "^FO060,080^GB725," & mbCuadro & ",1^FS" & Chr(13) & Chr(10) &
                                                        "^FO115,080^GB572," & mbCuadro & ",1^FS" & Chr(13) & Chr(10) &
                                                        "^FO204,080^GB379," & mbCuadro & ",1^FS" & Chr(13) & Chr(10) &
                                                        "^FO204,080^GB99," & mbCuadro & ",1^FS" & Chr(13) & Chr(10)
                Next

                i = i + 1
                'SUMAMOS EL ESPACIO ENTRE REGISTRO

                mbLetras = mbLetras + 25
                mbCuadro = mbCuadro + 25
            Next

            'PINTAMOS EL TOTAL DE PRENDAS
            CadenaCuadroContenido = "^FT545," & mbCuadro + mbInicialTotalPrendas & "^A0,020,020^FD" & "TOTAL PRENDAS" & "^FS" & Chr(13) & Chr(10) &
                                "^FT735," & mbCuadro + mbInicialTotalPrendas & "^A0,020,020^FD" & zplTotalDePrendas & "^FS" & Chr(13) & Chr(10)

            mbLetras = mbLetras + 100   ' + 100 POR QUE HAY 4 ESPACIOS ENTRE ESE CUADRO Y EL SIGUIENTE 25 CADA ESPACIO
            mbCuadro = mbCuadro + 75
            mbInicialLineaResumen = mbInicialLineaResumen + mbCuadro

            'PINTAMOS EL CUADRO DE RESUMEN

            Dim j As Integer
            For j = 1 To 3

                If mbLetras > 500 Then
                    CadenaCuadroResumen = CadenaCuadroResumen + CadenaFinal + "^XA^FS" & Chr(13) & Chr(10)
                    mbLetras = 100
                    mbCuadro = 25
                    mbInicialTotalPrendas = 105
                    mbInicialLineaResumen = 80
                End If

                Dim strTexto1, strTexto2, strVar1, strVar2 As String
                If j = 1 Then
                    strTexto1 = "NRO CAJA"
                    strTexto2 = "PESO NETO"
                    strVar1 = Trim(zplNumeroDeCaja)
                    strVar2 = Trim(zplPesoNeto) & " KG"
                ElseIf j = 2 Then
                    strTexto1 = "PO"
                    strTexto2 = "PESO TARA"
                    strVar1 = Trim(zplPo)
                    strVar2 = Trim(zplPesoTara) & " KG"
                ElseIf j = 3 Then
                    strTexto1 = "ESTADO"
                    strTexto2 = "PESO BRUTO"
                    strVar1 = Trim(zplEstado)
                    strVar2 = Trim(zplPesoBruto) & " KG"
                End If



                CadenaCuadroResumen = CadenaCuadroResumen + "^FO125," & mbInicialLineaResumen & "^GB600,25,1^FS" & Chr(13) & Chr(10) &
                    "^FO209," & mbInicialLineaResumen & "^GB340,25,1^FS" & Chr(13) & Chr(10) &
                    "^FO209," & mbInicialLineaResumen & "^GB170,25,1^FS" & Chr(13) & Chr(10) &
                    "^FT140," & mbLetras & "^A0,015,015^FD" & strTexto1 & "^FS" & Chr(13) & Chr(10) &
                    "^FT420," & mbLetras & "^A0,015,015^FD" & strTexto2 & "^FS" & Chr(13) & Chr(10) &
                    "^FT220," & mbLetras & "^A0,015,015^FD" & strVar1 & "^FS" & Chr(13) & Chr(10) &
                    "^FT575," & mbLetras & "^A0,015,015^FD" & strVar2 & "^FS" & Chr(13) & Chr(10)

                mbLetras = mbLetras + 25
                mbInicialLineaResumen = mbInicialLineaResumen + 25

            Next

            mbLetras = mbLetras + 25

            If (500 - mbLetras) < 50 Then '74 CONDICION PARA POSICCIONAR EL CODIGO DE BARRA
                'CadenaContenido = CadenaContenido + CadenaFinal + "^XA^FS" & Chr(13) & Chr(10)
                CadenaCodigoBarra = CadenaCodigoBarra + CadenaFinal + "^XA^FS" & Chr(13) & Chr(10)
                mbLetras = 100
                mbCuadro = 25
                mbInicialTotalPrendas = 105
                mbInicialLineaResumen = 80
            End If

            'PINTAMOS EL CODIGO DE BARRA
            CadenaCodigoBarra = CadenaCodigoBarra + "^FT295," & mbLetras + 40 & "^A0,010,010^BY4^B2N,60,Y,N,N^FD" & zplNumeroDeCaja & "^FS" & Chr(13) & Chr(10)

            mbLetras = mbLetras + 100

            'PINTAMOS USUARIO Y FECHA
            CadenaUsuarioFecha = "^FT150," & mbLetras & "^A0,015,015^FD" & "Usuario : " & UCase(Trim(zplUsuario)) & "^FS" & Chr(13) & Chr(10) &
                "^FT555," & mbLetras & "^A0,015,015^FD " & zplFecha & "^FS" & Chr(13) & Chr(10)

            'mbLetras = mbLetras + 25

            Dim stFinal As String
            stFinal = CadenaInicial + CadenaCabecera + CadenaContenido + CadenaCuadroContenido + CadenaCuadroResumen + CadenaCodigoBarra + CadenaUsuarioFecha + CadenaFinal

            '"^XA^CFD" & Chr(13) & Chr(10) & "^PON"  NO BORRAR ESO ES PARA ESTABLECER LA IMPRESION DE MANERA NORMAL
            '^PON -> IMPRIME DE MANERA NORMAL
            'POI^ -> IMPRIME DE MANERA INVERSA(LETRAS VOLTEADAS)
            'stFinal = stFinal + "^XA^CFD" & Chr(13) & Chr(10) & "^PON" & Chr(13) & Chr(10) + "^XZ"
            stFinal = stFinal
            sw.WriteLine(stFinal)
        Next

        Dim Final As String
        Final = "^XA^CFD" & Chr(13) & Chr(10) & "^PON" & Chr(13) & Chr(10) + "^XZ"
        sw.WriteLine(Final)

        sw.Close()
        Call ImprimirArchivo(ArchivoZPL) 'LLAMAMOS AL METODO DE IMPRESION
    End Sub
    Public Sub ImpresionTickets()
        'CREAMOS EL ARCHIVO DONDE GUARDAREMOS EL CODIFO ZPL
        Const ArchivoTicketCostura As String = "C:\TEMP\TICKETS_COSTURA.txt"

        'INSTANCIAMOS DE LA CLASE PRINTER             
        Dim strSQL As String = String.Empty
        Dim oHP As New clsHELPER
        Dim sw As New System.IO.StreamWriter(ArchivoTicketCostura)

        strSQL = "SELECT * FROM TICKETS"

        Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        If (Dt.Rows.Count <= 0) Then
            MessageBox.Show("No Existen Tickets Para Imprimir, Favor Validar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Creacion de variables para la impresion de Tips        
        Dim nCol As Integer

        For Each Row As DataRow In Dt.Rows

            If Trim(Row("tip_reg")) = "2" Then
                nCol = 0
                If Trim(Row("Cod_pq1")) <> "" Then nCol = 1
                If Trim(Row("Cod_pq2")) <> "" Then nCol = 2
                Call ImpresionNuevoFormato(1, nCol, Row)
            Else
                If Trim(Row("tip_reg")) = "1" Then
                    Call ImpresionNuevoFormato(2, nCol, Row)
                Else
                    If Trim(Row("tip_reg").Value) = "3" Then
                        Call ImpresionNuevoFormato(3, nCol, Row)
                    End If
                End If
            End If
        Next
        sw.WriteLine(sCadena)
        sw.Close()
        ImprimirArchivo(ArchivoTicketCostura)
    End Sub
    Sub ImpresionNuevoFormato(sFlag As Integer, sColumna As Integer, sRow As DataRow)
        Dim oHP As New clsHELPER
        Dim FinLinea, sTipo As String
        sTipo = oHP.DevuelveDato("select Coordenada_Sticker_Confecciones from tg_control", cCONNECT)

        FinLinea = Chr(10)

        sCadena = sCadena & "   ^XA^JMA^FS" & FinLinea
        sCadena = sCadena & "   ^MD2^FS" & FinLinea
        sCadena = sCadena & "   ^FWN" & FinLinea
        sCadena = sCadena & "   ^PRC^FS" & FinLinea
        sCadena = sCadena & "   ^BY2,2:0^FS" & FinLinea

        If sFlag = 1 Then

            If sTipo = 2 Then
                sCadena = sCadena & "   ^LH006,00^FS" & FinLinea
            Else
                sCadena = sCadena & "   ^LH10,00^FS" & FinLinea
            End If

            sCadena = sCadena & "   ^FO016,015^A0N,23,18^FDBLOQUE:^FS" & FinLinea
            sCadena = sCadena & "   ^FO090,015^A0N,23,18^FD" & Trim(sRow("des_blo")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO210,015^A0N,23,18^FDQPQ:^FS" & FinLinea
            sCadena = sCadena & "   ^FO255,015^A0N,23,18^FD" & Format(sRow("NRO_PR1")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO290,015^A0N,23,18^FDTAL:^FS" & FinLinea
            sCadena = sCadena & "   ^FO330,015^A0N,23,18^FD" & Trim(sRow("TALLA1")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO016,035^A0N,23,18^FDPQ:^FS" & FinLinea
            sCadena = sCadena & "   ^FO050,035^A0N,23,18^FD" & Trim(sRow("COD_PQ1")) & "-" & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO210,035^A0N,23,18^FDOP:^FS" & FinLinea
            sCadena = sCadena & "   ^FO250,035^A0N,23,18^FD" & Trim(sRow("NRO_OP")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO016,055^A0N,23,18^FDQOC:^FS" & FinLinea
            sCadena = sCadena & "   ^FO090,055^A0N,23,18^FD" & Trim(sRow("NUM_PRENDAS_TOTALES")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO210,055^A0N,23,18^FDEST CL:^FS" & FinLinea
            sCadena = sCadena & "   ^FO285,055^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO016,075^A0N,23,18^FDEstilo TSC:^FS" & FinLinea
            sCadena = sCadena & "   ^FO099,075^A0N,23,18^FD" & Trim(sRow("ESTILO_VERSION")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO116,075^A0N,23,18^FD^FS" & FinLinea
            sCadena = sCadena & "   ^FO210,075^A0N,23,18^FD" & Trim(sRow("COLOR1")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO070,100^A0N,23,18^FD" & Trim(sRow("COD_OPE1")) & " - " & Trim(sRow("Des_ope1")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO280,125^A0N,23,18^FDPH:^FS" & FinLinea
            sCadena = sCadena & "   ^FO310,125^A0N,23,18^FD" & Trim(sRow("PR_HR1")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO280,145^A0N,23,18^FDOC:^FS" & FinLinea
            sCadena = sCadena & "   ^FO310,145^A0N,23,18^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

            sCadena = sCadena & "   ^FO016,125^A0N,23,18^FD^FS" & FinLinea
            sCadena = sCadena & "   ^FO070,125^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br1")) & "^FS" & FinLinea


            If sColumna > 1 And Trim(sRow("Cod_pq2")) <> "" Then

                If sTipo = 2 Then
                    sCadena = sCadena & "   ^LH410,00^FS" & FinLinea 'seteo el nuevo origen en la 2da etiqueta
                Else
                    sCadena = sCadena & "   ^LH410,00^FS" & FinLinea 'seteo el nuevo origen en la 2da etiqueta
                End If

                sCadena = sCadena & "   ^FO016,015^A0N,23,18^FDBLOQUE:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,015^A0N,23,18^FD" & Trim(sRow("DES_BLO")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO210,015^A0N,23,18^FDQPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO255,015^A0N,23,18^FD" & Format(sRow("NRO_PR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO290,015^A0N,23,18^FDTAL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO330,015^A0N,23,18^FD" & Format(sRow("TALLA2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,035^A0N,23,18^FDPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO050,035^A0N,23,18^FD" & Trim(sRow("COD_PQ2")) & "-" & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO210,035^A0N,23,18^FDOP:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,035^A0N,23,18^FD" & Trim(sRow("NRO_OP")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,055^A0N,23,18^FDQOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,055^A0N,23,18^FD" & Trim(sRow("NUM_PRENDAS_TOTALES")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO210,055^A0N,23,18^FDEST CL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO285,055^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,075^A0N,23,18^FDEstilo TSC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO099,075^A0N,23,18^FD" & Trim(sRow("ESTILO_VERSION")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO160,075^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,075^A0N,23,18^FD" & Trim(sRow("COLOR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO070,100^A0N,23,18^FD" & Trim(sRow("COD_OPE2")) & " - " & Trim(sRow("Des_ope2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,125^A0N,23,18^FDPH:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,125^A0N,23,18^FD" & Trim(sRow("PR_HR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,145^A0N,23,18^FDOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,145^A0N,23,18^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,125^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,125^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br2")) & "^FS" & FinLinea

            End If
        ElseIf sFlag = 2 Then
            If sColumna > 0 And Trim(sRow("cod_pq1")) <> "" Then

                If sTipo = 2 Then
                    sCadena = sCadena & "   ^LH006,00^FS" & FinLinea
                Else
                    sCadena = sCadena & "   ^LH20,00^FS" & FinLinea
                End If

                'Printer.Print "   ^LH0,00^FS"
                sCadena = sCadena & "   ^FO016,020^A0N,23,18^FDBLOQUE:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,020^A0N,23,18^FD" & Trim(sRow("DES_BLO")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,020^A0N,23,18^FDTAL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,020^A0N,23,18^FD" & Format(sRow("TALLA1")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO280,020^A0N,23,18^FDCANT:^FS" & FinLinea
                sCadena = sCadena & "   ^FO330,020^A0N,23,18^FD" & Format(sRow("NRO_PR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,040^A0N,23,18^FDPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO050,040^A0N,23,18^FD" & Trim(sRow("COD_PQ1")) & " - " & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO140,040^A0N,23,18^FDGD:^FS" & FinLinea
                sCadena = sCadena & "   ^FO175,040^A0N,23,18^FD" & Trim(sRow("COD_CATGOPE1")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,040^A0N,23,18^FDEST:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,040^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,060^A0N,23,18^FDPARTIDA:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,060^A0N,23,18^FD" & Trim(sRow("PARTIDA")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,060^A0N,23,18^FDOP-SEC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO290,060^A0N,23,18^FD" & Trim(sRow("NRO_OP")) & "-" & Trim(sRow("COD_SEC")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,080^A0N,23,18^FDPO:^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,080^A0N,23,18^FD" & Trim(sRow("COD_PURORD")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO160,080^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,080^A0N,23,18^FD" & Trim(sRow("COLOR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO070,100^A0N,23,18^FD" & Trim(sRow("Des_ope1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,130^A0N,23,18^FDOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,130^A0N,23,18^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,150^A0N,23,18^FDPH:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,150^A0N,23,18^FD" & Trim(sRow("PR_HR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,130^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,130^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br1")) & "^FS" & FinLinea

            End If
            If sColumna > 1 And Trim(sRow("cod_pq2")) <> "" Then

                If sTipo = 2 Then
                    sCadena = sCadena & "   ^LH410,00^FS" & FinLinea
                Else
                    sCadena = sCadena & "   ^LH430,00^FS" & FinLinea
                End If

                'Printer.Print "   ^LH270,00^FS"
                sCadena = sCadena & "   ^FO016,020^A0N,23,18^FDBLOQUE:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,020^A0N,23,18^FD" & Trim(sRow("DES_BLO")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,020^A0N,23,18^FDTAL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,020^A0N,23,18^FD" & Format(sRow("TALLA2")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO280,020^A0N,23,18^FDCANT:^FS" & FinLinea
                sCadena = sCadena & "   ^FO330,020^A0N,23,18^FD" & Format(sRow("NRO_PR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,040^A0N,23,18^FDPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO050,040^A0N,23,18^FD" & Trim(sRow("COD_PQ2")) & " - " & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO140,040^A0N,23,18^FDGD:^FS" & FinLinea
                sCadena = sCadena & "   ^FO175,040^A0N,23,18^FD" & Trim(sRow("COD_CATGOPE2")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,040^A0N,23,18^FDEST:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,040^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,060^A0N,23,18^FDPARTIDA:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,060^A0N,23,18^FD" & Trim(sRow("PARTIDA")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,060^A0N,23,18^FDOP-SEC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO290,060^A0N,23,18^FD" & Trim(sRow("NRO_OP")) & "-" & Trim(sRow("COD_SEC")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,080^A0N,23,18^FDPO:^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,080^A0N,23,18^FD" & Trim(sRow("COD_PURORD")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO160,080^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,080^A0N,23,18^FD" & Trim(sRow("COLOR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO070,100^A0N,23,18^FD" & Trim(sRow("Des_ope2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,130^A0N,23,18^FDOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,130^A0N,23,18^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,150^A0N,23,18^FDPH:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,150^A0N,23,18^FD" & Trim(sRow("PR_HR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,130^A0N,23,18^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,130^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br2")) & "^FS" & FinLinea


            End If

        ElseIf sFlag = 3 Then
            If sColumna > 0 Then

                If sTipo = 2 Then
                    sCadena = sCadena & "   ^LH006,00^FS" & FinLinea
                Else
                    sCadena = sCadena & "   ^LH20,10^FS" & FinLinea
                End If

                sCadena = sCadena & "   ^FO016,020^A0N,20,15^FDBLOQUE:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,020^A0N,18,15^FD" & Trim(sRow("DES_BLO")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,020^A0N,23,18^FDTAL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,020^A0N,23,18^FD" & Format(sRow("TALLA1")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO280,020^A0N,23,18^FDCANT:^FS" & FinLinea
                sCadena = sCadena & "   ^FO330,020^A0N,23,18^FD" & Format(sRow("NRO_PR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,040^A0N,20,15^FDPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO050,040^A0N,18,15^FD" & Trim(sRow("COD_PQ1")) & " - " & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO140,040^A0N,23,18^FDGD:^FS" & FinLinea
                sCadena = sCadena & "   ^FO175,040^A0N,23,18^FD" & Trim(sRow("COD_CATGOPE1")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,040^A0N,23,18^FDEST:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,040^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,060^A0N,20,15^FDPARTIDA:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,060^A0N,18,15^FD" & Trim(sRow("PARTIDA")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,060^A0N,20,15^FDOP-SEC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO290,060^A0N,18,15^FD" & Trim(sRow("NRO_OP")) & "-" & Trim(sRow("COD_SEC")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,080^A0N,20,15^FDPO:^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,080^A0N,18,15^FD" & Trim(sRow("COD_PURORD")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO160,080^A0N,20,15^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,080^A0N,18,15^FD" & Trim(sRow("COLOR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO070,110^A0N,18,15^FD" & Trim(sRow("Des_ope1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,130^A0N,20,15^FDOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,130^A0N,18,15^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,150^A0N,23,18^FDPH:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,150^A0N,23,18^FD" & Trim(sRow("PR_HR1")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,140^A0N,20,15^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO040,140^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br1")) & "^FS" & FinLinea
            End If
            If sColumna > 1 Then

                If sTipo = 2 Then
                    sCadena = sCadena & "   ^LH410,00^FS" & FinLinea
                Else
                    sCadena = sCadena & "   ^LH430,00^FS" & FinLinea
                End If

                sCadena = sCadena & "   ^FO016,020^A0N,20,15^FDBLOQUE:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,020^A0N,18,15^FD" & Trim(sRow("DES_BLO")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,020^A0N,23,18^FDTAL:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,020^A0N,23,18^FD" & Format(sRow("TALLA2")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO280,020^A0N,23,18^FDCANT:^FS" & FinLinea
                sCadena = sCadena & "   ^FO330,020^A0N,23,18^FD" & Format(sRow("NRO_PR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,040^A0N,20,15^FDPQ:^FS" & FinLinea
                sCadena = sCadena & "   ^FO050,040^A0N,18,15^FD" & Trim(sRow("COD_PQ2")) & " - " & Trim(sRow("NRO_PAQUETES")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO140,040^A0N,23,18^FDGD:^FS" & FinLinea
                sCadena = sCadena & "   ^FO175,040^A0N,23,18^FD" & Trim(sRow("COD_CATGOPE2")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,040^A0N,23,18^FDEST:^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,040^A0N,23,18^FD" & Trim(sRow("COD_ESTCLI")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,060^A0N,20,15^FDPARTIDA:^FS" & FinLinea
                sCadena = sCadena & "   ^FO090,060^A0N,18,15^FD" & Trim(sRow("PARTIDA")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO210,060^A0N,20,15^FDOP-SEC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO290,060^A0N,18,15^FD" & Trim(sRow("NRO_OP")) & "-" & Trim(sRow("COD_SEC")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,080^A0N,20,15^FDPO:^FS" & FinLinea
                sCadena = sCadena & "   ^FO070,080^A0N,18,15^FD" & Trim(sRow("COD_PURORD")) & "^FS" & FinLinea
                sCadena = sCadena & "   ^FO160,080^A0N,20,15^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO250,080^A0N,18,15^FD" & Trim(sRow("COLOR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO070,110^A0N,18,15^FD" & Trim(sRow("Des_ope2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,130^A0N,20,15^FDOC:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,130^A0N,18,15^FD" & Trim(sRow("co_codordpro")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO280,150^A0N,23,18^FDPH:^FS" & FinLinea
                sCadena = sCadena & "   ^FO310,150^A0N,23,18^FD" & Trim(sRow("PR_HR2")) & "^FS" & FinLinea

                sCadena = sCadena & "   ^FO016,140^A0N,20,15^FD^FS" & FinLinea
                sCadena = sCadena & "   ^FO040,140^BUN,45,Y,N,Y^FD" & Trim(sRow("Cod_br2")) & "^FS" & FinLinea

            End If
        End If

        sCadena = sCadena & "   ^PQ1,0,0,N" & FinLinea
        sCadena = sCadena & "   ^XZ" & FinLinea
        sCadena = sCadena
    End Sub
    Sub ImprimirArchivo(ByVal Path_Fichero As String)
        Try
            Dim FormImpresion As New Form
            FormImpresion.StartPosition = FormStartPosition.CenterScreen
            FormImpresion.Visible = False
            Dim prtDialog As New PrintDialog


            Dim result As DialogResult = prtDialog.ShowDialog(FormImpresion)
            If (result = DialogResult.OK) Then
                Dim psi As New ProcessStartInfo
                psi.UseShellExecute = True
                psi.Verb = "printto"
                psi.WindowStyle = ProcessWindowStyle.Hidden
                'psi.Arguments = $"""{PrintDialog1.PrinterSettings.PrinterName}"""
                psi.Arguments = Chr(34) & prtDialog.PrinterSettings.PrinterName & Chr(34) 'PARA QUE CORRA EN VS2012
                psi.FileName = Path_Fichero
                Process.Start(psi)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Des_Apos(strDes As String) As String
        Des_Apos = Replace(strDes, "'", "''")
    End Function

    Public Function EnLetras(Numero As String) As String

        Dim b, paso As Integer

        Dim expresion, entero, deci, flag As String

        EnLetras = letra(Numero)

        If EnLetras <> "" Then Exit Function

        flag = "N"

        For paso = 1 To Len(Numero)

            If Mid(Numero, paso, 1) = "." Then

                flag = "S"

            Else

                If flag = "N" Then

                    entero = entero + Mid(Numero, paso, 1) 'Extae la parte entera del numero

                Else

                    deci = deci + Mid(Numero, paso, 1) 'Extrae la parte decimal del numero

                End If

            End If

        Next paso



        If Len(deci) = 1 Then

            deci = deci & "0"

        End If



        flag = "N"

        If Val(Numero) >= -999999999 And Val(Numero) <= 999999999 Then 'si el numero esta dentro de 0 a 999.999.999

            For paso = Len(entero) To 1 Step -1

                b = Len(entero) - (paso - 1)

                Select Case paso

                    Case 3, 6, 9

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If Mid(entero, b + 1, 1) = "0" And Mid(entero, b + 2, 1) = "0" Then

                                    expresion = expresion & "cien "

                                Else

                                    expresion = expresion & "ciento "

                                End If

                            Case "2"

                                expresion = expresion & "doscientos "

                            Case "3"

                                expresion = expresion & "trescientos "

                            Case "4"

                                expresion = expresion & "cuatrocientos "

                            Case "5"

                                expresion = expresion & "quinientos "

                            Case "6"

                                expresion = expresion & "seiscientos "

                            Case "7"

                                expresion = expresion & "setecientos "

                            Case "8"

                                expresion = expresion & "ochocientos "

                            Case "9"

                                expresion = expresion & "novecientos "

                        End Select



                    Case 2, 5, 8

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    flag = "S"

                                    expresion = expresion & "diez "

                                End If

                                If Mid(entero, b + 1, 1) = "1" Then

                                    flag = "S"

                                    expresion = expresion & "once "

                                End If

                                If Mid(entero, b + 1, 1) = "2" Then

                                    flag = "S"

                                    expresion = expresion & "doce "

                                End If

                                If Mid(entero, b + 1, 1) = "3" Then

                                    flag = "S"

                                    expresion = expresion & "trece "

                                End If

                                If Mid(entero, b + 1, 1) = "4" Then

                                    flag = "S"

                                    expresion = expresion & "catorce "

                                End If

                                If Mid(entero, b + 1, 1) = "5" Then

                                    flag = "S"

                                    expresion = expresion & "quince "

                                End If

                                If Mid(entero, b + 1, 1) > "5" Then

                                    flag = "N"

                                    expresion = expresion & "dieci"

                                End If



                            Case "2"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "veinte "

                                    flag = "S"

                                Else

                                    expresion = expresion & "veinti"

                                    flag = "N"

                                End If



                            Case "3"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "treinta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "treinta y "

                                    flag = "N"

                                End If



                            Case "4"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "cuarenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "cuarenta y "

                                    flag = "N"

                                End If



                            Case "5"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "cincuenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "cincuenta y "

                                    flag = "N"

                                End If



                            Case "6"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "sesenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "sesenta y "

                                    flag = "N"

                                End If



                            Case "7"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "setenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "setenta y "

                                    flag = "N"

                                End If



                            Case "8"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "ochenta "

                                    flag = "S"

                                Else

                                    expresion = expresion & "ochenta y "

                                    flag = "N"

                                End If



                            Case "9"

                                If Mid(entero, b + 1, 1) = "0" Then

                                    expresion = expresion & "noventa "

                                    flag = "S"

                                Else

                                    expresion = expresion & "noventa y "

                                    flag = "N"

                                End If

                        End Select



                    Case 1, 4, 7

                        Select Case Mid(entero, b, 1)

                            Case "1"

                                If flag = "N" Then

                                    If paso = 1 Then

                                        expresion = expresion & "uno "

                                    Else

                                        expresion = expresion & "un "

                                    End If

                                End If

                            Case "2"

                                If flag = "N" Then

                                    expresion = expresion & "dos "

                                End If

                            Case "3"

                                If flag = "N" Then

                                    expresion = expresion & "tres "

                                End If

                            Case "4"

                                If flag = "N" Then

                                    expresion = expresion & "cuatro "

                                End If

                            Case "5"

                                If flag = "N" Then

                                    expresion = expresion & "cinco "

                                End If

                            Case "6"

                                If flag = "N" Then

                                    expresion = expresion & "seis "

                                End If

                            Case "7"

                                If flag = "N" Then

                                    expresion = expresion & "siete "

                                End If

                            Case "8"

                                If flag = "N" Then

                                    expresion = expresion & "ocho "

                                End If

                            Case "9"

                                If flag = "N" Then

                                    expresion = expresion & "nueve "

                                End If

                        End Select

                End Select

                If paso = 4 Then

                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                      (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                       Len(entero) <= 6) Then

                        expresion = expresion & "mil "

                    End If

                End If

                If paso = 7 Then

                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then

                        expresion = expresion & "millón "

                    Else

                        expresion = expresion & "millones "

                    End If

                End If

            Next paso



            If deci <> "" Then

                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo

                    EnLetras = "menos " & expresion & "con " & deci ' & "/100"

                Else

                    EnLetras = expresion & "con " & deci ' & "/100"

                End If

            Else

                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo

                    EnLetras = "menos " & expresion

                Else

                    EnLetras = expresion

                End If

            End If

        Else 'si el numero a convertir esta fuera del rango superior e inferior

            EnLetras = ""

        End If

    End Function

    Function letra(Numero)
        Dim Texto
        Dim Millones
        Dim Miles
        Dim Cientos
        Dim Decimales
        Dim cadena
        Dim CadMillones
        Dim CadMiles
        Dim CadCientos
        Dim caddecimales
        Texto = Math.Round(Numero, 2)
        Texto = FormatNumber(Texto, 2)
        Texto = Right(Space(14) & Texto, 14)
        Millones = Mid(Texto, 1, 3)
        Miles = Mid(Texto, 5, 3)
        Cientos = Mid(Texto, 9, 3)
        Decimales = Mid(Texto, 13, 2)
        CadMillones = ConvierteCifra(Millones, False)
        CadMiles = ConvierteCifra(Miles, False)
        CadCientos = ConvierteCifra(Cientos, True)
        caddecimales = ConvierteDecimal(Decimales)
        If Trim(CadMillones) > "" Then
            If Trim(CadMillones) = "UN" Then
                cadena = CadMillones & " MILLON"
            Else
                cadena = CadMillones & " MILLONES"
            End If
        End If
        If Trim(CadMiles) > "" Then
            If Trim(CadMiles) = "UN" Then
                CadMiles = ""
                cadena = cadena & "" & CadMiles & "MIL"
                CadMiles = "UN"
            Else
                cadena = cadena & " " & CadMiles & " MIL"
            End If
        End If

        If Decimales = "00" Then
            If Trim(CadMillones & CadMiles & CadCientos & caddecimales) = "UN" Then
                cadena = cadena & "UNO "
            Else
                If Miles & Cientos = "000000" Then
                    cadena = cadena & " " & Trim(CadCientos)
                Else
                    cadena = cadena & " " & Trim(CadCientos)
                End If
                letra = Trim(cadena)
            End If
        Else
            If Trim(CadMillones & CadMiles & CadCientos & caddecimales) = "UN" Then
                cadena = cadena & "UNO " & "CON " & Trim(caddecimales)
            Else
                If Miles & Cientos = "000000" Then
                    cadena = cadena & " " & Trim(CadCientos) & " CON " & Trim(Decimales)
                Else
                    cadena = cadena & " " & Trim(CadCientos) & " CON " & Trim(Decimales)
                End If
                letra = Trim(cadena)
            End If
        End If

    End Function

    Function ConvierteCifra(Texto As Object, IsCientos As Boolean)
        Dim Centena
        Dim Decena
        Dim Unidad
        Dim txtCentena
        Dim txtDecena
        Dim txtUnidad
        Centena = Mid(Texto, 1, 1)
        Decena = Mid(Texto, 2, 1)
        Unidad = Mid(Texto, 3, 1)
        Select Case Centena
            Case "1"
                txtCentena = "CIEN"
                If Decena & Unidad <> "00" Then
                    txtCentena = "CIENTO"
                End If
            Case "2"
                txtCentena = "DOSCIENTOS"
            Case "3"
                txtCentena = "TRESCIENTOS"
            Case "4"
                txtCentena = "CUATROCIENTOS"
            Case "5"
                txtCentena = "QUINIENTOS"
            Case "6"
                txtCentena = "SEISCIENTOS"
            Case "7"
                txtCentena = "SETECIENTOS"
            Case "8"
                txtCentena = "OCHOCIENTOS"
            Case "9"
                txtCentena = "NOVECIENTOS"
        End Select

        Select Case Decena
            Case "1"
                txtDecena = "DIEZ"
                Select Case Unidad
                    Case "1"
                        txtDecena = "ONCE"
                    Case "2"
                        txtDecena = "DOCE"
                    Case "3"
                        txtDecena = "TRECE"
                    Case "4"
                        txtDecena = "CATORCE"
                    Case "5"
                        txtDecena = "QUINCE"
                    Case "6"
                        txtDecena = "DIECISEIS"
                    Case "7"
                        txtDecena = "DIECISIETE"
                    Case "8"
                        txtDecena = "DIECIOCHO"
                    Case "9"
                        txtDecena = "DIECINUEVE"
                End Select
            Case "2"
                txtDecena = "VEINTE"
                If Unidad <> "0" Then
                    txtDecena = "VEINTI"
                End If
            Case "3"
                txtDecena = "TREINTA"
                If Unidad <> "0" Then
                    txtDecena = "TREINTA Y "
                End If
            Case "4"
                txtDecena = "CUARENTA"
                If Unidad <> "0" Then
                    txtDecena = "CUARENTA Y "
                End If
            Case "5"
                txtDecena = "CINCUENTA"
                If Unidad <> "0" Then
                    txtDecena = "CINCUENTA Y "
                End If
            Case "6"
                txtDecena = "SESENTA"

                If Unidad <> "0" Then
                    txtDecena = "SESENTA Y "
                End If
            Case "7"
                txtDecena = "SETENTA"
                If Unidad <> "0" Then
                    txtDecena = "SETENTA Y "
                End If
            Case "8"
                txtDecena = "OCHENTA"
                If Unidad <> "0" Then
                    txtDecena = "OCHENTA Y "
                End If
            Case "9"
                txtDecena = "NOVENTA"
                If Unidad <> "0" Then
                    txtDecena = "NOVENTA Y "
                End If
        End Select

        If Decena <> "1" Then
            Select Case Unidad
                Case "1"
                    If IsCientos = False Then
                        txtUnidad = "UN"
                    Else
                        txtUnidad = "UNO"
                    End If
                Case "2"
                    txtUnidad = "DOS"
                Case "3"
                    txtUnidad = "TRES"
                Case "4"
                    txtUnidad = "CUATRO"
                Case "5"
                    txtUnidad = "CINCO"
                Case "6"
                    txtUnidad = "SEIS"
                Case "7"
                    txtUnidad = "SIETE"
                Case "8"
                    txtUnidad = "OCHO"
                Case "9"
                    txtUnidad = "NUEVE"
            End Select
        End If
        ConvierteCifra = txtCentena & " " & txtDecena & txtUnidad
    End Function

    Function ConvierteDecimal(Texto)
        Dim Decenadecimal
        Dim Unidaddecimal
        Dim txtDecenadecimal
        Dim txtUnidaddecimal
        Decenadecimal = Mid(Texto, 1, 1)
        Unidaddecimal = Mid(Texto, 2, 1)

        Select Case Decenadecimal
            Case "1"
                txtDecenadecimal = "DIEZ"
                Select Case Unidaddecimal
                    Case "1"
                        txtDecenadecimal = "ONCE"
                    Case "2"
                        txtDecenadecimal = "DOCE"
                    Case "3"
                        txtDecenadecimal = "TRECE"
                    Case "4"
                        txtDecenadecimal = "CATORCE"
                    Case "5"
                        txtDecenadecimal = "QUINCE"
                    Case "6"
                        txtDecenadecimal = "DIECISEIS"
                    Case "7"
                        txtDecenadecimal = "DIECISIETE"
                    Case "8"
                        txtDecenadecimal = "DIECIOCHO"
                    Case "9"
                        txtDecenadecimal = "DIECINUEVE"
                End Select
            Case "2"
                txtDecenadecimal = "VEINTE"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "VEINTI"
                End If
            Case "3"
                txtDecenadecimal = "TREINTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "TREINTA Y "
                End If
            Case "4"
                txtDecenadecimal = "CUARENTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "CUARENTA Y "
                End If
            Case "5"
                txtDecenadecimal = "CINCUENTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "CINCUENTA Y "
                End If
            Case "6"
                txtDecenadecimal = "SESENTA"

                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "SESENTA Y "
                End If
            Case "7"
                txtDecenadecimal = "SETENTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "SETENTA Y "
                End If
            Case "8"
                txtDecenadecimal = "OCHENTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "OCHENTA Y "
                End If
            Case "9"
                txtDecenadecimal = "NOVENTA"
                If Unidaddecimal <> "0" Then
                    txtDecenadecimal = "NOVENTA Y "
                End If
        End Select

        If Decenadecimal <> "1" Then
            Select Case Unidaddecimal
                Case "1"
                    txtUnidaddecimal = "UNO"
                Case "2"
                    txtUnidaddecimal = "DOS"
                Case "3"
                    txtUnidaddecimal = "TRES"
                Case "4"
                    txtUnidaddecimal = "CUATRO"
                Case "5"
                    txtUnidaddecimal = "CINCO"
                Case "6"
                    txtUnidaddecimal = "SEIS"
                Case "7"
                    txtUnidaddecimal = "SIETE"
                Case "8"
                    txtUnidaddecimal = "OCHO"
                Case "9"
                    txtUnidaddecimal = "NUEVE"
            End Select
        End If
        If Decenadecimal = 0 And Unidaddecimal = 0 Then
            ConvierteDecimal = ""
        Else
            ConvierteDecimal = txtDecenadecimal & txtUnidaddecimal
        End If
    End Function
End Module