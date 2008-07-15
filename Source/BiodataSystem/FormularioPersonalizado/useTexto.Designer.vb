<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useTexto
    Inherits useBasePers

    'UserControl overrides dispose to clean up the component list.
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
        'Me.txtTexto = New Prominente.DocumentExplorer.Controls.TextBoxPersonalizado
        Me.txtTexto = New Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado
		Me.grbContenedor.SuspendLayout()
		Me.SuspendLayout()
		'
		'grbContenedor
		'
		Me.grbContenedor.Controls.Add(Me.txtTexto)
		Me.grbContenedor.Location = New System.Drawing.Point(3, -4)
		Me.grbContenedor.Size = New System.Drawing.Size(415, 55)
		Me.grbContenedor.Controls.SetChildIndex(Me.chkSeleccionado, 0)
		Me.grbContenedor.Controls.SetChildIndex(Me.lblTitulo, 0)
		Me.grbContenedor.Controls.SetChildIndex(Me.txtTexto, 0)
		'
		'lblTitulo
		'
		Me.lblTitulo.Location = New System.Drawing.Point(6, 10)
		'
		'chkSeleccionado
		'
		Me.chkSeleccionado.Location = New System.Drawing.Point(397, 9)
		'
		'txtTexto
		'
		Me.txtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtTexto.Location = New System.Drawing.Point(6, 27)
		Me.txtTexto.Name = "txtTexto"
		Me.txtTexto.Size = New System.Drawing.Size(403, 20)
		Me.txtTexto.TabIndex = 0
        'Me.txtTexto.TipoDato = Prominente.DocumentExplorer.Controls.TextBoxPersonalizado.TipoDatos.LetrasYNumeros
        Me.txtTexto.TipoDato = Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado.TipoDatos.LetrasYNumeros
		Me.txtTexto.TipoPersonalFiltro = Nothing
		'
		'useTexto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Name = "useTexto"
		Me.Size = New System.Drawing.Size(421, 54)
		Me.grbContenedor.ResumeLayout(False)
		Me.grbContenedor.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    'Protected WithEvents txtTexto As Prominente.DocumentExplorer.Controls.TextBoxPersonalizado
    Protected WithEvents txtTexto As Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado

End Class
