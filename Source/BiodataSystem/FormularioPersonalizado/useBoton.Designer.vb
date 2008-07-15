<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useBoton
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
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.btnA = New System.Windows.Forms.Button
        Me.grbContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbContenedor
        '
        Me.grbContenedor.Controls.Add(Me.btnAplicar)
        Me.grbContenedor.Size = New System.Drawing.Size(383, 54)
        Me.grbContenedor.Controls.SetChildIndex(Me.btnAplicar, 0)
        Me.grbContenedor.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.grbContenedor.Controls.SetChildIndex(Me.chkSeleccionado, 0)
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(7, 22)
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.Location = New System.Drawing.Point(284, 19)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 4
        Me.btnAplicar.Text = "Dale masa"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnA.Location = New System.Drawing.Point(203, 19)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 4
        Me.btnA.Text = "Dale masa"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'useBoton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "useBoton"
        Me.Size = New System.Drawing.Size(386, 52)
        Me.grbContenedor.ResumeLayout(False)
        Me.grbContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button

End Class
