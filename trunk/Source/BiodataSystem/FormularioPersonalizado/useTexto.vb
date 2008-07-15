Public Class useTexto
	Inherits useBasePers

    'Private _value As String = String.Empty
    Public Overrides Property Valor() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
            If Not _value Is Nothing Then
                txtTexto.Text = _value
            End If
        End Set
    End Property

    Private Sub txtTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTexto.TextChanged
        Valor = txtTexto.Text
    End Sub

    'Public Property TipoDato() As Prominente.DocumentExplorer.Controls.TextBoxPersonalizado.TipoDatos
    Public Property TipoDato() As Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado.TipoDatos
        Get
            Return txtTexto.TipoDato
        End Get
        'Set(ByVal value As Prominente.DocumentExplorer.Controls.TextBoxPersonalizado.TipoDatos)
        Set(ByVal value As Medusa.Biodata.FrontEnd.UserControls.TextBoxPersonalizado.TipoDatos)
            txtTexto.TipoDato = value
        End Set
    End Property

    Public Property TipoPersonaFiltro() As String
        Get
            Return txtTexto.TipoPersonalFiltro
        End Get
        Set(ByVal value As String)
            txtTexto.TipoPersonalFiltro = value
        End Set
    End Property

End Class