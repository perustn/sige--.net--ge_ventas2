Module ModConexion

    Public cConexionORACLE As String
    Public cCONNECT As String
    Public cSEGURIDAD As String
    Public cCONNECTVB6 As String
    Public cSEGURIDADVB6 As String
    Public StrPrendas As String
    Public Tsali As String
    Public contas As Integer
    Public Tip_Salida As String

    Public bCargaConexion As Boolean
    Public oMDIParent As Object

    Dim sQuery As String
    Public vRuta As String

    Public Ruta_Logo_Empresa As String
    Public Num_Ruc_Empresa As String
    Public Direccion_Empresa As String
    Public DSN_Empresa As String
    Public DSN_Seguridad As String
    Public Ruta0_Empresa As String
    Public Fecha_Hora_Conexion As String

    Public vusu As String
    Public vemp As String
    Public vper As String
    Public vemp1 As String
    Public vpas As String
    Public vNomFor As String


    Public sAnoPeriodoContableVigente As String
    Public sAnoContableVigente As String
    Public sPeriodoContableVigente As String


    Public iLanguage As Short
    Public oParent As Object


    Public sDllName As String
    Public oFormObjDLL As Object
    Public objFormDLL As Object
    Public cServidor As String

    Public Enum DataTypeEnum
        adBigInt = 20
        adBinary = 128
        adBoolean = 11
        adBSTR = 8
        adChar = 129
        adCurrency = 6
        adDate = 7
        adDBDate = 133
        adDBTime = 134
        adDBTimeStamp = 135
        adDecimal = 14
        adDouble = 5
        adEmpty = 0
        adError = 10
        adGUID = 72
        adIDispatch = 9
        adInteger = 3
        adIUnknown = 13
        adLongVarBinary = 205
        adLongVarChar = 201
        adLongVarWChar = 203
        adNumeric = 131
        adSingle = 4
        adSmallInt = 2
        adTinyInt = 16
        adUnsignedBigInt = 21
        adUnsignedInt = 19
        adUnsignedSmallInt = 18
        adUnsignedTinyInt = 17
        adUserDefined = 132
        adVarBinary = 204
        adVarChar = 200
        adVariant = 12
        adVarWChar = 202
        adWChar = 130
    End Enum


End Module