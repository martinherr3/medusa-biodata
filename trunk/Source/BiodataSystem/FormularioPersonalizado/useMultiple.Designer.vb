<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useMultiple
    Inherits useTexto

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
        Me.grbContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(6, 26)
        Me.txtTexto.Multiline = True
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(403, 64)
        'Me.txtTexto.TipoDato = Prominente.DocumentExplorer.Controls.TextBoxPersonalizado.TipoDatos.LetrasYNumerosYPersonal
        Me.txtTexto.TipoDato = Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado.TipoDatos.LetrasYNumerosYPersonal
        Me.txtTexto.TipoPersonalFiltro = ",.;:/\-_()+$%#""&{}[]*¡?¿!'<>@"
        '
        'grbContenedor
        '
        Me.grbContenedor.Size = New System.Drawing.Size(415, 96)
        '
        'useMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "useMultiple"
        Me.Size = New System.Drawing.Size(421, 95)
        'Me.TipoDato = Prominente.DocumentExplorer.Controls.TextBoxPersonalizado.TipoDatos.LetrasYNumerosYPersonal
        Me.TipoDato = Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado.TipoDatos.LetrasYNumerosYPersonal
        Me.TipoPersonaFiltro = ",.;:/\-_()+$%#""&{}[]*¡?¿!'<>@"
        Me.grbContenedor.ResumeLayout(False)
        Me.grbContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class
