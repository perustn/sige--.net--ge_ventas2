<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IDE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IDE))
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup()
        Dim ExplorerBarItem1 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem()
        Dim ExplorerBarItem2 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem()
        Dim ExplorerBarItem3 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem()
        Dim ExplorerBarItem4 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem()
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup()
        Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup()
        Me.vsmIDE = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Ribbon = New Janus.Windows.Ribbon.Ribbon()
        Me.RibbonStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar()
        Me.jebMenu = New Janus.Windows.ExplorerBar.ExplorerBar()
        CType(Me.Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jebMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmIDE
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "IDE"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2010
        Me.vsmIDE.ColorSchemes.Add(JanusColorScheme1)
        Me.vsmIDE.DefaultColorScheme = "IDE"
        '
        'Ribbon
        '
        Me.Ribbon.BackstageMenuData = "<?xml version=""1.0"" encoding=""utf-8""?><BackstageMenu><ImageKey /><Key /><Text>Fil" & _
    "e</Text></BackstageMenu>"
        '
        '
        '
        Me.Ribbon.HelpButton.Image = CType(resources.GetObject("Ribbon.HelpButton.Image"), System.Drawing.Image)
        Me.Ribbon.HelpButton.Key = "HelpButton"
        Me.Ribbon.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.Name = "Ribbon"
        Me.Ribbon.Size = New System.Drawing.Size(637, 55)
        '
        '
        '
        Me.Ribbon.SuperTipComponent.AutoPopDelay = 2000
        Me.Ribbon.SuperTipComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ribbon.SuperTipComponent.ImageList = Nothing
        Me.Ribbon.TabIndex = 4
        Me.Ribbon.Text = ""
        Me.Ribbon.VisualStyle = Janus.Windows.Ribbon.VisualStyle.Office2010
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 371)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Size = New System.Drawing.Size(637, 32)
        '
        '
        '
        Me.RibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibbonStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibbonStatusBar.TabIndex = 5
        '
        'jebMenu
        '
        Me.jebMenu.Dock = System.Windows.Forms.DockStyle.Left
        ExplorerBarItem1.Key = "grbTejeduria_mnu001"
        ExplorerBarItem1.Text = "Ingreso de producción tejida en servicios - Calidad 1ra"
        ExplorerBarItem2.Key = "grbTejeduria_mnu002"
        ExplorerBarItem2.Text = "Ingreso de producción tejida en servicios - Calidad 2da"
        ExplorerBarItem3.Key = "grbTejeduria_mnu003"
        ExplorerBarItem3.Text = "Despacho de tela cruda a servicios de tintorería"
        ExplorerBarItem4.Key = "grbTejeduria_mnu004"
        ExplorerBarItem4.Text = "Recepcion Telas Acabadas Enviadas desde Lima"
        ExplorerBarGroup1.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem1, ExplorerBarItem2, ExplorerBarItem3, ExplorerBarItem4})
        ExplorerBarGroup1.Key = "grbTejeduria"
        ExplorerBarGroup1.Text = "Tejeduría"
        ExplorerBarGroup2.Expanded = False
        ExplorerBarGroup2.Key = "grbManufactura"
        ExplorerBarGroup2.Text = "Manufactura"
        ExplorerBarGroup3.Expanded = False
        ExplorerBarGroup3.Key = "grbGerencia"
        ExplorerBarGroup3.Text = "Gerencia"
        Me.jebMenu.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1, ExplorerBarGroup2, ExplorerBarGroup3})
        Me.jebMenu.Location = New System.Drawing.Point(0, 55)
        Me.jebMenu.Name = "jebMenu"
        Me.jebMenu.OfficeScrollBarStyle = Janus.Windows.ExplorerBar.OfficeScrollBarStyle.Light
        Me.jebMenu.Size = New System.Drawing.Size(226, 316)
        Me.jebMenu.TabIndex = 6
        Me.jebMenu.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2010
        Me.jebMenu.VisualStyleManager = Me.vsmIDE
        '
        '_IDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 403)
        Me.Controls.Add(Me.jebMenu)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.Ribbon)
        Me.IsMdiContainer = True
        Me.Name = "_IDE"
        Me.ShowIcon = False
        Me.Text = "Gestión Empresarial - Móvil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jebMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmIDE As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents Ribbon As Janus.Windows.Ribbon.Ribbon
    Friend WithEvents RibbonStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents jebMenu As Janus.Windows.ExplorerBar.ExplorerBar
End Class
