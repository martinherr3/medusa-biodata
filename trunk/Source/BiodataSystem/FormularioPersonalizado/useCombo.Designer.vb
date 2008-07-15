<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useCombo
    Inherits FormularioPersonalizado.useBaseLista

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
		Me.cmbElementos = New System.Windows.Forms.ComboBox
		Me.grbContenedor.SuspendLayout()
		Me.SuspendLayout()
		'
		'grbContenedor
		'
		Me.grbContenedor.Controls.Add(Me.cmbElementos)
		Me.grbContenedor.Size = New System.Drawing.Size(383, 58)
		Me.grbContenedor.Controls.SetChildIndex(Me.lblTitulo, 0)
		Me.grbContenedor.Controls.SetChildIndex(Me.cmbElementos, 0)
		Me.grbContenedor.Controls.SetChildIndex(Me.chkSeleccionado, 0)
		'
		'lblTitulo
		'
		Me.lblTitulo.Location = New System.Drawing.Point(6, 10)
		'
		'cmbElementos
		'
		Me.cmbElementos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbElementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbElementos.FormattingEnabled = True
		Me.cmbElementos.Location = New System.Drawing.Point(6, 27)
		Me.cmbElementos.Name = "cmbElementos"
		Me.cmbElementos.Size = New System.Drawing.Size(371, 21)
		Me.cmbElementos.TabIndex = 4
		'
		'useCombo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Name = "useCombo"
		Me.Size = New System.Drawing.Size(386, 54)
		Me.grbContenedor.ResumeLayout(False)
		Me.grbContenedor.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Protected WithEvents cmbElementos As System.Windows.Forms.ComboBox

End Class
