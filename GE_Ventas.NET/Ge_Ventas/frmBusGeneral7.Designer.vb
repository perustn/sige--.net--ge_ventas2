﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusGeneral7
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub

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
        Dim DGridLista_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.DGridLista = New Janus.Windows.GridEX.GridEX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        CType(Me.DGridLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGridLista
        '
        Me.DGridLista.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.DGridLista.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        DGridLista_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.DGridLista.DesignTimeLayout = DGridLista_DesignTimeLayout
        Me.DGridLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridLista.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.DGridLista.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.DGridLista.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.DGridLista.GroupByBoxVisible = False
        Me.DGridLista.Location = New System.Drawing.Point(0, 0)
        Me.DGridLista.Name = "DGridLista"
        Me.DGridLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.DGridLista.Size = New System.Drawing.Size(825, 298)
        Me.DGridLista.TabIndex = 26
        Me.DGridLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 37)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAceptar)
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(668, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 37)
        Me.Panel2.TabIndex = 7
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(25, 25)
        Me.BtnAceptar.Location = New System.Drawing.Point(5, 7)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(71, 23)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&aceptar"
        Me.BtnAceptar.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(25, 25)
        Me.BtnCancelar.Location = New System.Drawing.Point(78, 7)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(71, 23)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&cancelar"
        Me.BtnCancelar.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'frmBusGeneral7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGridLista)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusGeneral7"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda"
        CType(Me.DGridLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGridLista As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
End Class
