Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Windows.Forms

Public Class EnvioTrama
    Public Function SendCA4XMLRequest(ByVal url As String, ByVal docid As String, ByVal comando As String, ByVal parametros As String, ByVal Datos As String) As String
        Dim result As String = ""
        Dim Solicitud As HttpWebRequest
        Dim Respuesta As HttpWebResponse
        Dim cuerpo_peticion As String = ""
        cuerpo_peticion = "docid=" & EncodeURL(docid) & "&comando=" + EncodeURL(comando) & "&parametros=" + EncodeURL(parametros) & "&datos=" + EncodeURL(Datos)
        Solicitud = CType(WebRequest.Create(url), HttpWebRequest)

        Try
            Dim bytes As Byte()
            bytes = System.Text.Encoding.UTF8.GetBytes(cuerpo_peticion)
            Solicitud.Method = "POST"
            Solicitud.ContentLength = bytes.Length
            Solicitud.ContentType = "application/x-www-form-urlencoded"
            Dim requestStream As Stream = Solicitud.GetRequestStream()
            requestStream.Write(bytes, 0, bytes.Length)
            requestStream.Close()
            Respuesta = CType(Solicitud.GetResponse(), HttpWebResponse)

            If Respuesta.StatusCode = HttpStatusCode.OK Then
                Dim responseStream As Stream = Respuesta.GetResponseStream()
                Dim reader As StreamReader = New StreamReader(responseStream)
                result = reader.ReadToEnd()
            Else
                result = "ERROR|||||||Error del servidor: " & Respuesta.StatusCode & ": " + Respuesta.StatusDescription
            End If

            Respuesta.Close()
        Catch we As WebException
            result = "ERROR|||||||Error del servidor: " & we.Status & ": " + we.Message
        Catch ex As Exception
            result = "ERROR|||||||Error del servidor: " & ex.Message
            Throw New Exception(ex.Message)
        Finally
            Respuesta = Nothing
            Solicitud = Nothing
        End Try

        Return result
    End Function

    Private Function EncodeURL(ByVal data As String) As String
        Dim result As String = ""
        Dim aChar As String
        Dim theCode As Integer
        Dim N As Integer
        Dim aux As String
        N = 0
        Do While (N _
                    <= (data.Length - 1))
            aChar = data.Substring(N, 1)

            theCode = CType(Asc(aChar), Integer)
            If (((theCode <= 0) _
                        AndAlso (theCode >= 47)) _
                        OrElse (((theCode <= 58) _
                        AndAlso (theCode >= 64)) _
                        OrElse (((theCode <= 91) _
                        AndAlso (theCode >= 93)) _
                        OrElse ((theCode <= 123) _
                        AndAlso (theCode >= 126))))) Then
                aux = (theCode + 256).ToString("X")
                result = (result + ("%" + aux.Substring((aux.Length - 2), 2)))
            Else
                result = (result + aChar)
            End If

            N = (N + 1)
        Loop

        Return result
    End Function

End Class
