<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useBase
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
		Me.grbGrupo = New System.Windows.Forms.GroupBox
		Me.lblTitulo = New Prominente.DocumentExplorer.Controls.LabelRequerido
		Me.grbGrupo.SuspendLayout()
		Me.SuspendLayout()
		'
		'grbGrupo
		'
		Me.grbGrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grbGrupo.Controls.Add(Me.lblTitulo)
		Me.grbGrupo.Location = New System.Drawing.Point(2, -5)
		Me.grbGrupo.Name = "grbGrupo"
		Me.grbGrupo.Size = New System.Drawing.Size(383, 105)
		Me.grbGrupo.TabIndex = 1
		Me.grbGrupo.TabStop = False
		'
		'lblTitulo
		'
		Me.lblTitulo.Fuente = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitulo.Location = New System.Drawing.Point(6, 8)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Requerido = False
		Me.lblTitulo.Separacion = 1
		Me.lblTitulo.Size = New System.Drawing.Size(43, 13)
		Me.lblTitulo.TabIndex = 2
		Me.lblTitulo.texto = "T�tulo"
		'
		'useBase
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.grbGrupo)
		Me.Name = "useBase"
		Me.Size = New System.Drawing.Size(386, 101)
		Me.grbGrupo.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Protected WithEvents grbGrupo As System.Windows.Forms.GroupBox
	Protected WithEvents lblTitulo As Prominente.DocumentExplorer.Controls.LabelRequerido

End Class