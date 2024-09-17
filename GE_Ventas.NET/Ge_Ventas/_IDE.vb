Public Class _IDE

    Private Sub jebMenu_ItemClick(sender As Object, e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles jebMenu.ItemClick
  
        
    End Sub

    Private Sub _IDE_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cconnect = "Initial Catalog=desarrollo;Data Source=192.168.30.47;uid=SGPusuarios;pwd=SGPusuarios"
        'cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.47;uid=SGPusuarios;pwd=SGPusuarios"

        'cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=desarrollo;Data Source=192.168.30.47;uid=SGPusuarios;pwd=SGPusuarios"
        'cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.47;uid=SGPusuarios;pwd=SGPusuarios"

        cCONNECT = "Initial Catalog=SIGE_STN;Data Source=192.168.30.55;uid=cvera;pwd=cu3r@@789_G3n3s1s"
        cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=cvera;pwd=cu3r@@789_G3n3s1s"

        cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=SIGE_STN;Data Source=192.168.30.55;uid=cvera;pwd=cu3r@@789_G3n3s1s"
        cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=cvera;pwd=cu3r@@789_G3n3s1s"


        vusu = "vluna"
        vper = "0001"
        vemp = "01"
        vemp1 = vemp.ToString
        vRuta = My.Application.Info.DirectoryPath
        iLanguage = CShort(GetSetting("Visuales", "Settings", "Language", "1"))
    End Sub

End Class