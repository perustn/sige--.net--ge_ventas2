Option Strict Off
Option Explicit On

'<System.Runtime.InteropServices.ProgId("clsForm_NET.clsForm")>
Public Class clsForm

    Private mConnect As String
    Private mConnectVB6 As String
    Private mConnectOracle As String
    Private Declare Function PutFocus Lib "user32" Alias "SetFocus" (ByVal hwnd As Integer) As Integer

    Public Property Language() As Short
        Get
            Language = iLanguage
        End Get
        Set(ByVal Value As Short)
            iLanguage = Value
        End Set
    End Property

    Public Property PARENT() As Object
        Get
            PARENT = oParent
        End Get
        Set(ByVal Value As Object)
            oParent = Value
        End Set
    End Property

    Public Property Rutas() As Object
        Get
            Rutas = vRuta
        End Get
        Set(ByVal Value As Object)
            vRuta = Value
        End Set
    End Property

    Public WriteOnly Property Cod_Empresa() As String
        Set(ByVal Value As String)
            vemp = Value
            vemp1 = Value
            bCargaConexion = True
        End Set
    End Property

    Public WriteOnly Property Cod_Perfil() As String
        Set(ByVal Value As String)
            vper = Value
        End Set
    End Property

    Public WriteOnly Property Cod_Opcion() As String
        Set(ByVal Value As String)
            'gsCod_Opcion = mCod_Opcion
        End Set
    End Property

    Public WriteOnly Property Key_Node() As String
        Set(ByVal Value As String)
            'gsKey_Node = mKey_Node
        End Set
    End Property
    Public WriteOnly Property Permisos() As String
        Set(ByVal Value As String)
            'gsPermisos = mPermisos
        End Set
    End Property
    Public WriteOnly Property Nom_Empresa() As String
        Set(ByVal Value As String)
            'gsNomEmpresa = vnewvalue
        End Set
    End Property
    Public WriteOnly Property Nom_Aplicacion() As String
        Set(ByVal Value As String)
            'gsNomAplicacion = vnewvalue
        End Set
    End Property
    Public WriteOnly Property Nom_Opcion() As String
        Set(ByVal Value As String)
            vNomFor = Value
        End Set
    End Property
    Public Property UserName() As String
        Get
            UserName = vusu
        End Get
        Set(ByVal Value As String)
            vusu = Value
        End Set
    End Property
    Public WriteOnly Property ConnectEmpresa() As String
        Set(ByVal Value As String)
            mConnect = Value
            cCONNECT = mConnect
        End Set
    End Property

    Public WriteOnly Property ConnectSeguridad() As String
        Set(ByVal Value As String)
            cSEGURIDAD = Value
        End Set
    End Property

    Public Property ConnectVB60() As String
        Get
            ConnectVB60 = mConnectVB6
        End Get
        Set(ByVal value As String)
            mConnectVB6 = value
            cCONNECTVB6 = mConnectVB6
        End Set
    End Property

    Public Property ConnectSeguridadVB60() As String
        Get
            ConnectSeguridadVB60 = cSEGURIDADVB6
        End Get
        Set(ByVal value As String)
            cSEGURIDADVB6 = value
        End Set
    End Property

    Public Property ConnectOracle() As String
        Get
            ConnectOracle = cConexionORACLE
        End Get
        Set(ByVal Value As String)
            mConnectOracle = Value
            cConexionORACLE = mConnectOracle
        End Set
    End Property

    Public Property AnoPeriodoContableVigente() As String
        Get
            AnoPeriodoContableVigente = sAnoPeriodoContableVigente
        End Get
        Set(ByVal Value As String)
            sAnoPeriodoContableVigente = Value
            sAnoContableVigente = Mid(sAnoPeriodoContableVigente, 1, 4)
            sPeriodoContableVigente = Mid(sAnoPeriodoContableVigente, 5, 2)
        End Set
    End Property

    Public Function GetForm(ByRef sFormName As Object) As Object
        sFormName = sFormName.ToString.Trim.ToUpper
        Select Case sFormName
            Case "FRMDOCUMENTOVENTA"
                GetForm = New FrmDocumentoVenta
            Case "FRMDOCUMENTOVENTAEXPORTACION"
                GetForm = New FrmDocumentoVentaExportacion
        End Select
        Return GetForm
    End Function

    Public Function GetWindowBorderStyle(ByVal lngHandle As Integer) As Integer

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetWindowBorderStyle = -1
        Else
            GetWindowBorderStyle = objForm.FormBorderStyle
        End If

    End Function

    Public Function GetWindowTitle(ByVal lngHandle As Integer) As String

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetWindowTitle = ""
        Else
            GetWindowTitle = objForm.Text
        End If

    End Function

    Public Function GetWindowWidth(ByVal lngHandle As Integer) As Integer

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetWindowWidth = 0

        End If

    End Function

    Public Function GetWindowHeight(ByVal lngHandle As Integer) As Integer

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetWindowHeight = 0

        End If

    End Function

    Public Function GetWindowState(ByVal lngHandle As Integer) As Integer

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetWindowState = 0
        Else
            GetWindowState = objForm.WindowState
        End If

    End Function

    Public Function GetStartUpPosition(ByVal lngHandle As Integer) As Integer

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            GetStartUpPosition = 0
        Else
            GetStartUpPosition = objForm.StartPosition
        End If

    End Function

    Public Function ResizeForm(ByVal lngHandle As Integer, ByVal lngAncho As Integer, ByVal lngAlto As Integer) As Object

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then Exit Function

        On Error Resume Next

    End Function

    Public Function IsFormOpen(ByVal lngHandle As Integer) As Boolean

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then
            IsFormOpen = False
        Else
            IsFormOpen = True
        End If

    End Function

    Public Function OpenFormCount() As Integer

        OpenFormCount = Application.OpenForms.Count

    End Function

    Public Sub CloseForm(ByVal lngHandle As Integer)

        Dim objForm As System.Windows.Forms.Form
        objForm = GetFormByHandle(lngHandle)

        If objForm Is Nothing Then Exit Sub

        Dim oform As System.Windows.Forms.Form
        oform = GetFormVB6("Frm_Toolbar")

        If Not oform Is Nothing Then
            oform.Close()
        End If

        objForm.Close()



    End Sub



    '------------------------------------------------------------------------------
    ' Métodos privados
    '------------------------------------------------------------------------------

    Private Function GetFormVB6(ByVal strFormName As String) As System.Windows.Forms.Form

        Dim objForm As System.Windows.Forms.Form

        For Each objForm In Application.OpenForms
            If objForm.Name = strFormName Then
                GetFormVB6 = objForm
                Exit Function
            End If
        Next objForm

        'UPGRADE_NOTE: El objeto GetFormVB6 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        GetFormVB6 = Nothing

    End Function

    Private Function GetFormByHandle(ByVal lngHandle As Integer) As System.Windows.Forms.Form

        Dim objForm As System.Windows.Forms.Form

        For Each objForm In Application.OpenForms
            If objForm.Handle.ToInt32 = lngHandle Then
                GetFormByHandle = objForm
                Exit Function
            End If
        Next objForm

        'UPGRADE_NOTE: El objeto GetFormByHandle no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        GetFormByHandle = Nothing

    End Function

    'Public Function Showform(ByVal sform As String)
    '    Main2 GetForm(sform)
    'End Function

    Public Sub GetControlFocus(ByVal lngHandle As Integer)
        Try
            Dim SavedWnd As Integer

            Dim objForm As System.Windows.Forms.Form
            objForm = GetFormByHandle(lngHandle)
            SavedWnd = objForm.ActiveControl.Handle.ToInt32
            'End If

            'Restore the focus to the original control
            Call PutFocus(lngHandle)
            'If Not objForm.ActiveControl Is Nothing Then
            Call PutFocus(SavedWnd)
        Catch ex As Exception
            MsgBox("Configurando Ventana", MsgBoxStyle.Information, "Configuración")
        End Try
    End Sub

End Class