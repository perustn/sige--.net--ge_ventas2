Imports System.IO
Public Class ClsWeight

    Private _path As String = "D:\\PesoBalanza\\peso.txt"
    Protected disposed As Boolean = False

    Public Property Path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    Function GetWeightForTxt() As String
        Return GetWeightForTxt(Path)
    End Function

    Function GetWeightForTxt(path As String) As String
        Dim WeightBalanceAuto As String
        Dim WeightBalance As StreamReader
        Try
            GetWeightForTxt = ""
            WeightBalance = New StreamReader(path)
            WeightBalanceAuto = WeightBalance.ReadLine()
            While Not (WeightBalanceAuto = Nothing)
                GetWeightForTxt = WeightBalanceAuto
                WeightBalanceAuto = Nothing
            End While
            WeightBalance.Close()
            WeightBalance = Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function GetIsWeightRequiredForTipoMov(tipMov As String) As Boolean
        Try
            Dim oHp As New clsHELPER
            Dim strSQL As String
            Dim IsRequired As Boolean
            strSQL = String.Format("select upper(Flg_Solicita_Peso) from Lg_TiposMov where Cod_TipMov = '{0}'", tipMov)
            IsRequired = IIf(oHp.DevuelveDato(strSQL, cCONNECT) = "S", True, False)
            Return IsRequired
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class