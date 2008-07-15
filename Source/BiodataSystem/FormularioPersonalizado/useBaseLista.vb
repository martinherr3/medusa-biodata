Imports System.Windows.Forms
Imports Medusa.Biodata.Common.BusinessEntities


Public Class useBaseLista
    Inherits useBasePers

    Public Overridable WriteOnly Property Lista() As FormularioPersonalizadoItemEntities
        Set(ByVal value As FormularioPersonalizadoItemEntities)
            _items = value
        End Set
    End Property

    Protected _items As New FormularioPersonalizadoItemEntities
    Public ReadOnly Property Items() As FormularioPersonalizadoItemEntities
        Get
            Return _items
        End Get
    End Property

End Class
