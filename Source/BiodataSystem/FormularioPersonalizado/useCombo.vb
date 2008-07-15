'Imports Prominente.DocumentExplorer.CommonEntities
Imports Medusa.Biodata.Common.BusinessEntities
Imports System.Windows.Forms

Public Class useCombo
    Inherits useBaseLista

	Private wEsLoad As Boolean = False

	Public Overrides Property Valor() As String
		Get
			If (cmbElementos.SelectedIndex <> -1) Then
				_value = cmbElementos.SelectedItem.Etiqueta
			End If
			Return _value
		End Get
		Set(ByVal value As String)
			_value = value
			For Each wItem As FormularioPersonalizadoItemEntity In _lista
				If wItem.Etiqueta = _value Then
					'cmbElementos.SelectedItem.Etiqueta = wItem.Etiqueta.ToString()
					cmbElementos.SelectedIndex = cmbElementos.FindString(wItem.Etiqueta)
					Exit For
				End If
			Next
		End Set
	End Property

    Private _lista As New List(Of FormularioPersonalizadoItemEntity)
    Public Overrides WriteOnly Property Lista() As FormularioPersonalizadoItemEntities
        Set(ByVal value As FormularioPersonalizadoItemEntities)
            For i As Int32 = 0 To value.Count - 1
                _lista.Add(value(i))
            Next
            _items = value
        End Set
    End Property

	Private Sub useCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		wEsLoad = True
		If Me._lista.Count > 0 Then
			cmbElementos.DataSource = Me._lista

			If (Me.Valor <> Nothing Or Me.Valor <> "") Then
				'cmbElementos.SelectedItem.Etiqueta = Me.Valor
				cmbElementos.SelectedIndex = cmbElementos.FindString(Me.Valor)
			End If
		End If
		wEsLoad = False
	End Sub

    Private Sub cmbElementos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbElementos.SelectedIndexChanged
		If Not wEsLoad Then
			If (cmbElementos.SelectedIndex <> -1) Then
				Me.Valor = cmbElementos.SelectedItem.Etiqueta
			End If
		End If
	End Sub

End Class