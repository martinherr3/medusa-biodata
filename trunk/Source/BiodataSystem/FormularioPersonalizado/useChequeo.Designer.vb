<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useChequeo
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
		Me.Button1 = New System.Windows.Forms.Button
		Me.grbContenedor.SuspendLayout()
		Me.SuspendLayout()
		'
		'grbContenedor
		'
		Me.grbContenedor.Size = New System.Drawing.Size(383, 47)
		'
		'lblTitulo
		'
		Me.lblTitulo.Location = New System.Drawing.Point(6, 10)
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(269, 18)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'useChequeo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Name = "useChequeo"
		Me.Size = New System.Drawing.Size(386, 45)
		Me.grbContenedor.ResumeLayout(False)
		Me.grbContenedor.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
