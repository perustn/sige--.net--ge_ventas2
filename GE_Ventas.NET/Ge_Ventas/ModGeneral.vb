Imports Janus.Windows.GridEX
Imports System.Data.SqlClient

Module ModGeneral

#If DEBUG Then
    Public ReadOnly IsDebugMode As Boolean = True
#Else
        Public ReadOnly IsDebugMode As Boolean = FALSE
#End If


    Declare Function GetcomputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpbuffer As String, ByRef nSize As Integer) As Integer

    <STAThread()> _
    Sub main()
        'Application.EnableVisualStyles()

        If IsDebugMode Then
            Dim x As New _FrmPrincipal
            x.ShowDialog()
        End If

    End Sub

#Region " Janus "

    ''' <summary>
    ''' Verificar Columnas de un DataSource para una grilla Janus
    ''' </summary>
    ''' <param name="poGrid"></param>
    ''' <remarks></remarks>
    Public Sub CheckLayoutGridEx(ByRef poGrid As Janus.Windows.GridEX.GridEX)
        Dim oDataSet As DataSet
        Dim oDataTable As DataTable
        Dim oColumnGrid As Janus.Windows.GridEX.GridEXColumn
        Dim bFound As Boolean

        If poGrid.DataSource Is Nothing Then Return
        If poGrid.RootTable Is Nothing Then Return

        poGrid.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        poGrid.HideSelection = HideSelection.Highlight

        If TypeOf poGrid.DataSource Is DataSet Then
            oDataSet = CType(poGrid.DataSource, DataSet)
            oDataTable = oDataSet.Tables(0)
        Else
            oDataTable = CType(poGrid.DataSource, DataTable)
        End If


        '// first check if there are columns removed from the source
        'For Each oGridEXColum As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns()
        '    bFound = False
        '    If oGridEXColum.FormatString = "c" Then
        '        oGridEXColum.FormatString = ""
        '        oGridEXColum.TextAlignment = TextAlignment.Far
        '        oGridEXColum.Trimming = Trimming.NoTrimming
        '    End If

        '    For Each oDataColumn As DataColumn In oDataTable.Columns
        '        If oDataColumn.ColumnName = oGridEXColum.Key Then
        '            bFound = True
        '            Exit For
        '        End If
        '    Next

        '    'If Not bFound Then
        '    '    Try
        '    '        poGrid.Layouts.Remove(poGrid.CurrentLayout)
        '    '    Catch
        '    '    End Try
        '    '    poGrid.RetrieveStructure()
        '    '    Exit For
        '    'End If
        'Next

        '// then check if there are new columns in the source and add them to the layout
        For Each oDataColumn As DataColumn In oDataTable.Columns
            bFound = False
            For Each oGridEXColum As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns()
                With oGridEXColum
                    If .FormatString = "c" Then
                        .FormatString = ""
                        .TextAlignment = TextAlignment.Far
                        .Trimming = Trimming.NoTrimming
                    End If
                End With
                If oDataColumn.ColumnName.ToString.Trim.ToUpper = oGridEXColum.Key.ToString.Trim.ToUpper Then
                    bFound = True
                    Exit For
                End If
            Next

            'If Not bFound Then
            If bFound = False Then
                oColumnGrid = New GridEXColumn(oDataColumn.Caption, Janus.Windows.GridEX.ColumnType.Text)
                With oColumnGrid
                    If .FormatString = "c" Then
                        .FormatString = ""
                        .TextAlignment = TextAlignment.Far
                        .Trimming = Trimming.NoTrimming
                    End If
                End With
                poGrid.RootTable.Columns.Insert(oDataColumn.Ordinal, oColumnGrid)
            End If
        Next

        'With poGrid
        '    .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '    .RootTable.HeaderFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center}

        '    .RootTable.RowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.FontName = "tahoma"}


        '    For Each oGridEXColumn As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns
        '        oGridEXColumn.Caption = oGridEXColumn.Caption.Trim.ToUpper
        '    Next
        'End With
        With poGrid
            .AlternatingColors = False
            .VisualStyle = VisualStyle.Office2010
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
            .RootTable.PreviewRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.ForeColor = Color.Blue,
                                                                                                .FontItalic = TriState.True,
                                                                                                .BackColor = Color.LightYellow}
            .RootTable.GroupRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.ForeColor = Color.Blue,
                                                                                              .FontName = "TAHOMA",
                                                                                              .FontSize = 8,
                                                                                              .FontBold = TriState.True}

            .RootTable.HeaderFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center,
                                                                                            .FontBold = TriState.True,
                                                                                            .FontSize = 7,
                                                                                            .FontName = "VERDANA"}

            .RootTable.RowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.FontName = "tahoma",
                                                                                         .FontSize = 8}

            .RootTable.TotalRowFormatStyle = New Janus.Windows.GridEX.GridEXFormatStyle With {.FontName = "tahoma",
                                                                                              .FontSize = 8,
                                                                                              .FontBold = TriState.True}
            For Each oGridEXColumn As Janus.Windows.GridEX.GridEXColumn In poGrid.RootTable.Columns
                With oGridEXColumn
                    .Caption = oGridEXColumn.Caption.Trim.ToUpper
                End With
            Next
        End With



        With poGrid
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.GroupByBoxInfo) = "Arrastre un encabezado de columna aquí para agrupar por esa columna"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.CalendarNoneButton) = "Ninguna"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.CalendarTodayButton) = "Hoy"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.RecordNavigator) = "Registro:|De"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.RecordNavigatorError) = "no puedes ir al registro especificado"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.EmptyGridInfo) = "No se ha encontrado Información para esta cuadrícula"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateEmpty) = "Ninguna"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateOlder) = "Mayor"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateLastMonth) = "Último mes"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateEarlierThisMonth) = "A principios de este mes"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateThreeWeeksAgo) = "Hace 3 semanas"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateTwoWeeksAgo) = "Hace 2 semanas"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateLastWeek) = "Última semana"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateYesterday) = "Ayer"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateToday) = "Hoy"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateTomorrow) = "Mañana"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateNextWeek) = "Sgte. Semana"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateTwoWeeksAway) = "2 semanas de distancia"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateThreeWeeksAway) = "3 semanas de distancia"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateLaterThisMonth) = "A finales de este mes"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateNextMonth) = "Sgte. Mes"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.OutlookDateBeyondNextMonth) = "Mas allá del próximo mes"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.DropDownOkButton) = "aceptar"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.DropDownCancelButton) = "cancelar"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowInfoText) = "Texto de información de fila de filtro"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionEqual) = "="
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotEqual) = "<>"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionGreaterThan) = ">"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionGreaterThanOrEqual) = ">="
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionLessThan) = "<"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionLessThanOrEqual) = "<="
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionContains) = "contiene"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotContains) = "no contiene"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionEndsWith) = "Termina con"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionBeginsWith) = "Inicia con"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionIsEmpty) = "{vacíos}"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionNotIsEmpty) = "{no vacíos}"
            .BuiltInTexts(Janus.Windows.GridEX.GridEXBuiltInText.FilterRowConditionClear) = "Limpiar"
        End With


    End Sub


    ''' <summary>
    ''' Obtener DataRow de GridEx
    ''' </summary>
    ''' <param name="xGridEx"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ObtenerDr_DeGridEx(ByVal xGridEx As GridEX) As DataRow
        Try
            If (CType(xGridEx.DataSource, DataTable) Is Nothing) OrElse _
               (CType(xGridEx.DataSource, DataTable).Rows.Count = 0) Then
                Return Nothing
            Else
                Dim oDrGrx As GridEXRow = xGridEx.GetRow
                Dim oDrV As DataRowView = oDrGrx.DataRow
                Dim oDr As DataRow = Nothing
                If Not (oDrV Is Nothing) Then oDr = oDrV.Row

                Return oDr
            End If
        Catch xErr As Exception
            Dim oDr As DataRow = Nothing
            MsgBox(xErr.Message, MsgBoxStyle.Critical)
            Return oDr
        End Try
    End Function

#End Region

#Region "Validaciones"

#Region "Validaciones"

    Sub ValidarSoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs,
                           Optional ByVal bolSW_PermitirNegativos As Boolean = True,
                           Optional ByVal strContenido As String = "")
        Select Case bolSW_PermitirNegativos
            Case True
                If e.KeyChar.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar = "-" And Not strContenido.IndexOf("-") Then
                    e.Handled = True
                ElseIf e.KeyChar = "-" Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case False
                If e.KeyChar.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
        End Select



    End Sub

    Sub ValidarSoloDecimales(ByVal strContenido As String,
                             ByRef e As System.Windows.Forms.KeyPressEventArgs,
                             Optional ByVal bolSW_PermitirNegativos As Boolean = True)

        Select Case bolSW_PermitirNegativos
            Case True
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar = "." And Not strContenido.IndexOf(".") Then
                    e.Handled = True
                ElseIf e.KeyChar = "." Then
                    e.Handled = False
                ElseIf e.KeyChar = "-" And Not strContenido.IndexOf("-") Then
                    e.Handled = True
                ElseIf e.KeyChar = "-" Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case False
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar = "." And Not strContenido.IndexOf(".") Then
                    e.Handled = True
                ElseIf e.KeyChar = "." Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
        End Select

    End Sub

    Sub ValidarSoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub ValidarSoloNumerosLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function RellenaDeCerosEnIzquierda(ByVal strValor As String,
                                       ByVal intCantidadDeCeros As Integer) As String
        Return New String("0", intCantidadDeCeros - strValor.Length) & strValor
    End Function

    Public Function CompletaCodigo(CodOrigen As String, longcodfinal As Integer, PosfinalCod As Integer) As String
        ' CodOrigen     = Es el codigo que sera pasado por parametro
        ' LongCodFinal  = Es el tamaño del Codigo a devolver
        ' PosFinalCod   = Es la posicion de la 1era parte del codigo
        Dim Contador As Integer
        CompletaCodigo = Mid(CodOrigen, 1, PosfinalCod).ToUpper
        For Contador = 1 To longcodfinal - Len(CodOrigen)
            CompletaCodigo = CompletaCodigo & "0"
        Next
        If Len(CodOrigen) = 2 Then
            CompletaCodigo = CompletaCodigo
        Else
            CompletaCodigo = CompletaCodigo & Mid(CodOrigen, 3, 2)
        End If

    End Function

    Public Function CompletaCodigos(CodOrigen As String, longcodfinal As Integer, PosfinalCod As Integer) As String
        ' CodOrigen     = Es el codigo que sera pasado por parametro
        ' LongCodFinal  = Es el tamaño del Codigo a devolver
        ' PosFinalCod   = Es la posicion de la 1era parte del codigo
        Dim Contador As Integer
        CompletaCodigos = Mid(CodOrigen, 1, PosfinalCod).ToUpper
        For Contador = 1 To longcodfinal - Len(CodOrigen)
            CompletaCodigos = CompletaCodigos & "0"
        Next
        If Len(CodOrigen) = 2 Then
            CompletaCodigos = CompletaCodigos
        Else
            CompletaCodigos = CompletaCodigos & Mid(CodOrigen, 3, 3)
        End If

    End Function

#End Region

    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub SoloDecimales(ByVal strContenido As String,
                      ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not strContenido.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub SoloNumerosLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region


    Sub FondoDegradeDiagonalEnPanel(ByVal objPanel As Panel,
                                 ByVal e As PaintEventArgs,
                                 ByVal colEmpresa As Color)
        Try

            Dim Brocha As System.Drawing.Drawing2D.LinearGradientBrush
            Dim Superficie As Graphics
            Dim Rectangulo As Rectangle
            Dim Lapiz As Pen

            Try
                Superficie = e.Graphics
                Lapiz = New Pen(Color.Azure, 1)
                Rectangulo = New Rectangle(0, 0, objPanel.Width, objPanel.Height)
                Brocha = New System.Drawing.Drawing2D.LinearGradientBrush(Rectangulo, Color.White, colEmpresa, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)


                Superficie.FillRectangle(Brocha, Rectangulo)
                Superficie.DrawRectangle(Lapiz, Rectangulo)
                Lapiz.Dispose()
                Superficie.Dispose()
            Catch ex As Exception
                'No hacemos nada si falla. Si hay error
            End Try
        Catch ex As Exception

        End Try
    End Sub



#Region " Convertir Datatable a Recordset "
    'Function ConvertToRecordset(ByVal inTable As DataTable) As ADODB.Recordset
    '    Try
    '        Dim result As New ADODB.Recordset()
    '        result.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        Dim resultFields As ADODB.Fields = result.Fields
    '        Dim inColumns As System.Data.DataColumnCollection = inTable.Columns

    '        For Each inColumn As DataColumn In inColumns
    '            resultFields.Append(inColumn.ColumnName, TranslateType(inColumn.DataType), inColumn.MaxLength, IIf(inColumn.AllowDBNull, _
    '                 ADODB.FieldAttributeEnum.adFldIsNullable, ADODB.FieldAttributeEnum.adFldUnspecified), Nothing)
    '        Next

    '        result.Open(System.Reflection.Missing.Value, System.Reflection.Missing.Value, ADODB.CursorTypeEnum.adOpenStatic, _
    '                 ADODB.LockTypeEnum.adLockOptimistic, 0)

    '        For Each dr As DataRow In inTable.Rows
    '            result.AddNew(System.Reflection.Missing.Value, System.Reflection.Missing.Value)
    '            For columnIndex As Integer = 0 To inColumns.Count - 1
    '                resultFields(columnIndex).Value = dr(columnIndex)
    '            Next
    '        Next
    '        Return result
    '    Catch xErr As Exception
    '        Dim result As ADODB.Recordset() = Nothing
    '        MsgBox(xErr.Message, MsgBoxStyle.Critical)
    '        Return Nothing
    '    End Try
    'End Function

    'Function TranslateType(ByVal columnType As Type) As ADODB.DataTypeEnum
    '    Select Case columnType.UnderlyingSystemType.ToString()
    '        Case "System.Boolean"
    '            Return ADODB.DataTypeEnum.adBoolean
    '        Case "System.Byte"
    '            Return ADODB.DataTypeEnum.adUnsignedTinyInt
    '        Case "System.Char"
    '            Return ADODB.DataTypeEnum.adChar
    '        Case "System.DateTime"
    '            Return ADODB.DataTypeEnum.adDate
    '        Case "System.TimeSpan"
    '            Return ADODB.DataTypeEnum.adDate
    '        Case "System.Decimal"
    '            Return ADODB.DataTypeEnum.adCurrency
    '        Case "System.Double"
    '            Return ADODB.DataTypeEnum.adDouble
    '        Case "System.Int16"
    '            Return ADODB.DataTypeEnum.adSmallInt
    '        Case "System.Int32"
    '            Return ADODB.DataTypeEnum.adInteger
    '        Case "System.Int64"
    '            Return ADODB.DataTypeEnum.adBigInt
    '        Case "System.SByte"
    '            Return ADODB.DataTypeEnum.adTinyInt
    '        Case "System.Single"
    '            Return ADODB.DataTypeEnum.adSingle
    '        Case "System.UInt16"
    '            Return ADODB.DataTypeEnum.adUnsignedSmallInt
    '        Case "System.UInt32"
    '            Return ADODB.DataTypeEnum.adUnsignedInt
    '        Case "System.UInt64"
    '            Return ADODB.DataTypeEnum.adUnsignedBigInt
    '        Case "System.String"
    '            Return ADODB.DataTypeEnum.adVarChar
    '        Case Else
    '            Return ADODB.DataTypeEnum.adVarChar
    '    End Select
    'End Function
#End Region

    Public Function ComputerName() As String
        Dim Keyname As String
        Dim keylen As Integer
        Dim iNull As Object

        keylen = 2000
        Keyname = New String(Chr(0), keylen)

        GetcomputerName(Keyname, keylen)

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iNull. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        iNull = InStr(Keyname, Chr(0))
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iNull. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ComputerName = Mid(Keyname, 1, iNull - 1)
    End Function

    Function ConvertirImagenEnEscalaDeGrises(ByVal objBitmap As Bitmap) As Image
        If objBitmap Is Nothing Then Return Nothing


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' DECLARACION DE VARIABLES GENERALES
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim Niveles(,) As System.Drawing.Color ' ECN -L-" : ARREGLO QUE ALMACENARÁ LOS NIVELES DIGITALES DE LA IMAGEN
        Dim I, J As Long
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' ASIGNAMOS A LA MATRIZ LAS DIMENSIONES DE LA IMAGEN - 1
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ReDim Niveles(objBitmap.Width - 1,
                      objBitmap.Height - 1)

        Dim objBitmap_AUX = objBitmap ' CREO UNA COPIA DE LA IMAGEN  OBJETO AUZILIAR

        For I = 0 To objBitmap_AUX.Width - 1 ' RECORRO LA MATRIZ A LO ANCHO
            For J = 0 To objBitmap_AUX.Height - 1 ' RECORRO LA MATRIZ A LO LARGO
                Niveles(I, J) = objBitmap_AUX.GetPixel(I, J) ' CON EL MÉTODO GETPIXEL, ASIGNO PARA CADA CELDA DE LA MATRIZ EL COLOR CON SUS VALORES RGB.
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' DECLARACION DE VARIABLES GENERALES
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim objBMP As New Bitmap(Niveles.GetUpperBound(0) + 1,
                                     Niveles.GetUpperBound(1) + 1)
        Dim objIMG As Image

        objIMG = CType(objBMP, Image)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' DECLARO TRES VARIABLES QUE ALMACENARÁN LOS COLORES PRINCIPALES (RGB)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dobMedia As Double ' Variable para calcular la dobMedia de los tres colores
        Dim bytROJO,
                bytVERDE,
                bytAZUL As Byte

        Dim R,
            G,
            B As Double 'Variables auxiliares para que no se desborde las variables bytROJO, bytVERDE, bytAZUL            
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' RECORRO LA MATRIZ
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            For I = 0 To Niveles.GetUpperBound(0)
                For J = 0 To Niveles.GetUpperBound(1)
                    R = Niveles(I, J).R
                    G = Niveles(I, J).G
                    B = Niveles(I, J).B

                    dobMedia = CInt((R + G + B) / 3)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    ' SEGUN LA OPCION DE MODIFICACION INDICADOSE EFECTUA EL PROCEDE CON EL PROCESAMIENTO
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    bytROJO = dobMedia
                    bytVERDE = dobMedia
                    bytAZUL = dobMedia
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    ' PINTO EL PIXEL CON EL NUEVO COLOR CALCULADO
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    objBMP.SetPixel(I,
                                        J,
                                        Color.FromArgb(bytROJO,
                                                       bytVERDE,
                                                       bytAZUL)
                                        )
                Next J
            Next I
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ECN : ConvertirImagenEnEscalaDeGrises", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return objIMG
    End Function

    Sub DefinirSeguridadEnGrillaJanus(ByRef grxJanus As GridEX,
                                      ByVal strCodPerfilUsuario As String,
                                      ByVal strCodEmpresa As String,
                                      ByVal strGUI As String)
        Try
            Dim strSQL As String = String.Format("EXEC SEG_MUESTRA_ACCESOS_FORMULARIOS_FUNCION  '{0}','{1}','{2}'", strCodPerfilUsuario, strCodEmpresa, strGUI)
            Dim oDa As New SqlClient.SqlDataAdapter(strSQL, cSEGURIDAD)
            Dim oDtAccesos As New DataTable
            oDa.Fill(oDtAccesos)

            Dim oFormatoBotonDesactivado As New GridEXFormatStyle With {.BackColor = Color.LightGray,
                                                                        .ForeColor = Color.Gray,
                                                                        .FontBold = TriState.True
                                                                        }

            With grxJanus
                If oDtAccesos Is Nothing OrElse oDtAccesos.Rows.Count = 0 Then
                    For Each oGridEXTable As GridEXTable In .Tables
                        For Each oGridEXColumn As GridEXColumn In oGridEXTable.Columns
                            With oGridEXColumn
                                .ButtonStyle = ButtonStyle.NoButton

                                With .CellStyle
                                    .BackColor = Color.LightGray
                                    .ForeColor = Color.Gray
                                    .FontBold = TriState.True
                                End With
                                If Not .Image Is Nothing Then
                                    .Image = ConvertirImagenEnEscalaDeGrises(.Image)
                                End If
                            End With
                        Next
                    Next
                Else
                    Dim bolSW As Boolean
                    Dim opcButtonStyle As ButtonStyle


                    For Each oGridEXTable As GridEXTable In .Tables
                        For Each oGridEXColumn As GridEXColumn In oGridEXTable.Columns
                            With oGridEXColumn
                                If .ButtonStyle <> ButtonStyle.NoButton Then
                                    bolSW = False
                                    opcButtonStyle = .ButtonStyle

                                    For Each oDataRow As DataRow In oDtAccesos.Rows
                                        If .Key.ToString.Trim.ToUpper = oDataRow("Nom_Corto").ToString.Trim.ToUpper Then
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
                                        If Not .Image Is Nothing Then
                                            .Image = ConvertirImagenEnEscalaDeGrises(.Image)
                                        End If
                                    End If
                                End If
                            End With
                        Next
                    Next
                End If

            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message, "DefinirSeguridadEnGrillaJanus")
        End Try

    End Sub



    Public Function Fecha_Corta(Mes As String) As String
        If Mes = "01" Then
            Fecha_Corta = "Ene"
        ElseIf Mes = "02" Then
            Fecha_Corta = "Feb"
        ElseIf Mes = "03" Then
            Fecha_Corta = "Mar"
        ElseIf Mes = "04" Then
            Fecha_Corta = "Abr"
        ElseIf Mes = "05" Then
            Fecha_Corta = "May"
        ElseIf Mes = "06" Then
            Fecha_Corta = "Jun"
        ElseIf Mes = "07" Then
            Fecha_Corta = "Jul"
        ElseIf Mes = "08" Then
            Fecha_Corta = "Ago"
        ElseIf Mes = "09" Then
            Fecha_Corta = "Sep"
        ElseIf Mes = "10" Then
            Fecha_Corta = "Oct"
        ElseIf Mes = "11" Then
            Fecha_Corta = "Nov"
        ElseIf Mes = "12" Then
            Fecha_Corta = "Dic"
        End If
    End Function



    Public Function LPad(InString As String, _
                        NumChar As Integer, _
                        Charr As Object) As String

        Dim WithThisChar As String
        Dim StringChar As String
        Dim iIndex As Integer

        StringChar = ""
        WithThisChar = IIf(Charr = vbNull, Space$(1), Charr)

        For iIndex = 1 To NumChar - Len(InString)
            StringChar = StringChar + WithThisChar
        Next

        LPad = StringChar + InString

    End Function


#Region " Convertir Datatable a Recordset "
    Function ConvertToRecordset(ByVal inTable As DataTable) As ADODB.Recordset
        Try
            Dim result As New ADODB.Recordset()
            result.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            Dim resultFields As ADODB.Fields = result.Fields
            Dim inColumns As System.Data.DataColumnCollection = inTable.Columns

            For Each inColumn As DataColumn In inColumns
                resultFields.Append(inColumn.ColumnName, TranslateType(inColumn.DataType), inColumn.MaxLength, IIf(inColumn.AllowDBNull,
                     ADODB.FieldAttributeEnum.adFldIsNullable, ADODB.FieldAttributeEnum.adFldUnspecified), Nothing)
            Next

            result.Open(System.Reflection.Missing.Value, System.Reflection.Missing.Value, ADODB.CursorTypeEnum.adOpenStatic,
                     ADODB.LockTypeEnum.adLockOptimistic, 0)

            For Each dr As DataRow In inTable.Rows
                result.AddNew(System.Reflection.Missing.Value, System.Reflection.Missing.Value)
                For columnIndex As Integer = 0 To inColumns.Count - 1
                    resultFields(columnIndex).Value = dr(columnIndex)
                Next
            Next
            Return result
        Catch xErr As Exception
            Dim result As ADODB.Recordset() = Nothing
            MsgBox(xErr.Message, MsgBoxStyle.Critical)
            Return DBNull.Value   'CAR  DECIA result
        End Try
    End Function

    Function TranslateType(ByVal columnType As Type) As ADODB.DataTypeEnum
        Select Case columnType.UnderlyingSystemType.ToString()
            Case "System.Boolean"
                Return ADODB.DataTypeEnum.adBoolean
            Case "System.Byte"
                Return ADODB.DataTypeEnum.adUnsignedTinyInt
            Case "System.Char"
                Return ADODB.DataTypeEnum.adChar
            Case "System.DateTime"
                Return ADODB.DataTypeEnum.adDate
            Case "System.TimeSpan"
                Return ADODB.DataTypeEnum.adDate
            Case "System.Decimal"
                Return ADODB.DataTypeEnum.adCurrency
            Case "System.Double"
                Return ADODB.DataTypeEnum.adDouble
            Case "System.Int16"
                Return ADODB.DataTypeEnum.adSmallInt
            Case "System.Int32"
                Return ADODB.DataTypeEnum.adInteger
            Case "System.Int64"
                Return ADODB.DataTypeEnum.adBigInt
            Case "System.SByte"
                Return ADODB.DataTypeEnum.adTinyInt
            Case "System.Single"
                Return ADODB.DataTypeEnum.adSingle
            Case "System.UInt16"
                Return ADODB.DataTypeEnum.adUnsignedSmallInt
            Case "System.UInt32"
                Return ADODB.DataTypeEnum.adUnsignedInt
            Case "System.UInt64"
                Return ADODB.DataTypeEnum.adUnsignedBigInt
            Case "System.String"
                Return ADODB.DataTypeEnum.adVarChar
            Case Else
                Return ADODB.DataTypeEnum.adVarChar
        End Select
    End Function
#End Region
End Module