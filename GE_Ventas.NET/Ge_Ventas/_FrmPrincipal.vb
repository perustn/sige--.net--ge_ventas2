Friend Class _FrmPrincipal
    Inherits System.Windows.Forms.Form

    Private Sub Frm_Principal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'cCONNECT = "Initial Catalog=SIGE_STN_QA_3;Data Source=192.168.30.22;uid=sa;pwd=D8t8$46nt63$"
        'cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.22;uid=sa;pwd=D8t8$46nt63$"

        'cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=SIGE_STN_QA_3;Data Source=192.168.30.22;uid=sa;pwd=D8t8$46nt63$"
        'cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.22;uid=sa;pwd=D8t8$46nt63$"



        cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=SIGE_STN_PROD;Data Source=192.168.30.22;Integrated Security = SSPI"
        cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.22;Integrated Security = SSPI"

        cCONNECT = "Initial Catalog=SIGE_STN_PROD;Data Source=192.168.30.22;Integrated Security = SSPI"
        cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.22;Integrated Security = SSPI"

        vusu = "vluna"
        vper = "0001"
        vemp = "01"
        vemp1 = vemp.ToString
        vRuta = My.Application.Info.DirectoryPath
        iLanguage = CShort(GetSetting("Visuales", "Settings", "Language", "1"))
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        'Using frm As New FrmSecuenciadorDeLineaManufactura_MantenimientoFeriado
        Using frm As New FrmDocumentoVenta
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Using frm As New FrmDocumentoVentaExportacion
            frm.ShowDialog()
        End Using
    End Sub
End Class