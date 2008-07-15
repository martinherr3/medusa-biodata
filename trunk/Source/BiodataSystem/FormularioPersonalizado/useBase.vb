Public MustInherit Class useBase

	Public Overrides Property Text() As String
		Get
			Return Texto
		End Get
		Set(ByVal value As String)
			Texto = value
		End Set
	End Property

	Private _texto As String = "Título"
	Public Property Texto() As String
		Get
			Return _texto
		End Get
		Set(ByVal value As String)
			_texto = value
			lblTitulo.Text = Texto
		End Set
	End Property

	Private _requerido As Boolean
	Public Property Requerido() As Boolean
		Get
			Return _requerido
		End Get
		Set(ByVal value As Boolean)
			_requerido = value
			lblTitulo.Requerido = Requerido
		End Set
	End Property

	'Public MustOverride Property Valor() As String

End Class
