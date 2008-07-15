Imports System.Windows.Forms
'Imports Prominente.DocumentExplorer.CommonEntities
Imports Medusa.Biodata.Common.BusinessEntities

Public Class useChequeo
    Inherits useBaseLista


    Public Overrides Property Valor() As String
        Get
            Dim i As Int32 = 1
            Dim MiValor As Int32 = 0
            For Each wCheck As CheckBox In _controles
                If wCheck.Checked = True Then
                    MiValor = MiValor + i
                End If
                i = i * 2
            Next
            Return MiValor.ToString()
        End Get
        Set(ByVal value As String)
            For Each wChk As CheckBox In _controles
                wChk.Checked = False
            Next
            Dim Mivalor As Int32 = Convert.ToInt32(value)
            If Mivalor > 0 Then
                Dim i As Int32 = 2 ^ (_controles.Count - 1)
                For b As Int32 = _controles.Count - 1 To 0 Step -1
                    If (Mivalor - i) >= 0 Then
                        Mivalor = Mivalor - i
                        _controles(b).Checked = True
                        If Mivalor = 0 Then
                            Exit For
                        End If
                    End If
                    i = (i - 1) / 2
                Next
            End If
        End Set
    End Property

    Private _controles As New List(Of CheckBox)
    Public Overrides WriteOnly Property Lista() As FormularioPersonalizadoItemEntities
        Set(ByVal value As FormularioPersonalizadoItemEntities)
            For i As Int32 = 0 To value.Count - 1
                Dim wCheck As New CheckBox
                wCheck.Name = "chk" & i
                wCheck.Text = value(i).Etiqueta
                wCheck.Tag = value(i).Id
                _controles.Add(wCheck)
                _items = value
            Next
        End Set
    End Property

	Private Sub useOpcion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me._EsModificable = False
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
                End With
            Next

            Me.Height = UltimaPosicion + 25

        End If

	End Sub

End Class
