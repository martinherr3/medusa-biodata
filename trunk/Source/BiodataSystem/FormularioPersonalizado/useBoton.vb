Imports Medusa.Biodata.Common.BusinessEntities
Imports Medusa.Biodata.BackEnd.BusinessComponents
Imports System.Windows.Forms

Public Class useBoton
    Inherits useBasePers

    Public Overrides Property Valor() As String
        Get
            Return "useBoton"
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

    Private _Product As ProductEntity

    Public Property Product() As ProductEntity
        Get
            Return _Product
        End Get
        Set(ByVal value As ProductEntity)
            _Product = value
        End Set
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click, btnA.Click
        Try
            If VerificarRequeridos() Then
                'Throw New Exception("msgRequeridosSinCargar")
                Throw New Exception("Existen Campos Requeridos sin grabar")
            Else
                Dim wValores As New FormularioPersonalizadoValorEntities()
                For Each wUse As useBasePers In CType(Me.Parent, System.Windows.Forms.Control).Controls
                    wValores.Add(llenarValor(wUse))
                Next
                'If MessageBox.Show(objIdioma.GetResource("msgSeguroGrabar", True, True), objIdioma.GetResource("Atencion", True), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.OK Then
                If MessageBox.Show("Esta seguro de grabar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.OK Then
                    'wValores.Grabar()
                    '//////////////////////////////////////////////
                    'VER
                    'FormularioPersonalizadoBC.Actualizar(wValores)
                End If
            End If
        Catch ex As Exception
            ProcesarExcepcion(ex)
        End Try
    End Sub

    Private Function llenarValor(ByVal pUse As useBasePers) As FormularioPersonalizadoValorEntity
        Dim wEnt As New FormularioPersonalizadoValorEntity()
        'wEnt.Documento = Me.Documento
        wEnt.Product = Me.Product
        wEnt.Valor = pUse.Valor
        Dim wControl As New FormularioPersonalizadoEntity()
        wControl.Etiqueta = pUse.Text
        wControl.Orden = pUse.Orden
        wControl.Requerido = pUse.Requerido
        wControl.TipoControl = pUse.TipoControl
        'wControl.TipoDocumento = pUse.TipoDocumento
        wControl.ProductType = pUse.ProductType
        wEnt.Control = wControl
        Return wEnt
    End Function


    Private Function VerificarRequeridos() As Boolean
        Dim FaltaValorRequerido As Boolean = False
        For Each wUse As useBasePers In CType(Me.Parent, System.Windows.Forms.Control).Controls
            If wUse.Requerido = True Then
                If wUse.Valor = Nothing OrElse wUse.Valor.Trim() = String.Empty Then
                    FaltaValorRequerido = True
                    Exit For
                End If
            End If
        Next
        Return FaltaValorRequerido
    End Function


    Private Sub grbContenedor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grbContenedor.Enter

    End Sub
End Class
