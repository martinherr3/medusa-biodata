'Imports Prominente.DocumentExplorer.CommonEntities
Imports Medusa.Biodata.Common.BusinessEntities
Imports System.Windows.Forms

Public Class useOpcion
    Inherits useBaseLista

    Public Overrides Property Valor() As String
        Get
            For i As Int32 = 0 To Me._controles.Count - 1
                If (Me._controles(i).Checked = True) Then
                    _value = Me._controles(i).Tag
                    Exit For
                End If
            Next
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
            For Each wRadio As RadioButton In _controles
                If wRadio.Tag.ToString().Trim() = _value.Trim() Then
                    wRadio.Checked = True
                    Exit For
                End If
            Next
        End Set
    End Property

	Private _controles As New List(Of RadioButton)
    Public Overrides WriteOnly Property Lista() As FormularioPersonalizadoItemEntities
        Set(ByVal value As FormularioPersonalizadoItemEntities)
            For i As Int32 = 0 To value.Count - 1
                Dim wRadio As New RadioButton
                wRadio.Name = "opt" & i
                wRadio.Text = value(i).Etiqueta
                wRadio.Tag = value(i).Id
                _controles.Add(wRadio)
                _items = value
            Next
        End Set
    End Property

    Private Sub useOpcion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim UltimaPosicion As Integer
        UltimaPosicion = Me.grbContenedor.Top + 17
        lblTitulo.Text = Me.Texto

        If Me._controles.Count > 0 Then

            For i As Int32 = 0 To Me._controles.Count - 1
                Me.grbContenedor.Controls.Add(Me._controles(i))
                UltimaPosicion = UltimaPosicion + 20

                With Me._controles(i)
                    .Top = UltimaPosicion
                    .Left = Me.grbContenedor.Left + 10
                    .AutoSize = True
                    If (i = 0) Then
                        .Checked = True
                    End If
                End With
            Next

            Me.Height = UltimaPosicion + 25

        End If

    End Sub

End Class