<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useBasePers
    Inherits System.Windows.Forms.UserControl

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
		Me.grbContenedor = New System.Windows.Forms.GroupBox
		Me.chkSeleccionado = New System.Windows.Forms.CheckBox
        'Me.lblTitulo = New Prominente.DocumentExplorer.Controls.LabelRequerido
        Me.lblTitulo = New Medusa.Biodata.FrontEnd.UserControls.LabelRequerido
		Me.grbContenedor.SuspendLayout()
		Me.SuspendLayout()
		'
		'grbContenedor
		'
		Me.grbContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grbContenedor.Controls.Add(Me.chkSeleccionado)
		Me.grbContenedor.Controls.Add(Me.lblTitulo)
		Me.grbContenedor.Location = New System.Drawing.Point(2, -5)
		Me.grbContenedor.Name = "grbContenedor"
		Me.grbContenedor.Size = New System.Drawing.Size(383, 105)
		Me.grbContenedor.TabIndex = 1
		Me.grbContenedor.TabStop = False
		'
		'chkSeleccionado
		'
		Me.chkSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.chkSeleccionado.AutoSize = True
		Me.chkSeleccionado.Location = New System.Drawing.Point(365, 9)
		Me.chkSeleccionado.Name = "chkSeleccionado"
		Me.chkSeleccionado.Size = New System.Drawing.Size(15, 14)
		Me.chkSeleccionado.TabIndex = 3
		Me.chkSeleccionado.UseVisualStyleBackColor = True
		Me.chkSeleccionado.Visible = False
		'
		'lblTitulo
		'
		Me.lblTitulo.AutoSize = True
		Me.lblTitulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.lblTitulo.Fuente = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitulo.Location = New System.Drawing.Point(6, 8)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Requerido = False
		Me.lblTitulo.Separacion = 1
		Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
		Me.lblTitulo.TabIndex = 2
		Me.lblTitulo.texto = "Título"
		'
		'useBasePers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.grbContenedor)
		Me.Name = "useBasePers"
		Me.Size = New System.Drawing.Size(386, 101)
		Me.grbContenedor.ResumeLayout(False)
		Me.grbContenedor.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Protected WithEvents grbContenedor As System.Windows.Forms.GroupBox
    'Protected WithEvents lblTitulo As Prominente.DocumentExplorer.Controls.LabelRequerido
    Protected WithEvents lblTitulo As Medusa.Biodata.FrontEnd.UserControls.LabelRequerido
	Protected WithEvents chkSeleccionado As System.Windows.Forms.CheckBox

End Class
