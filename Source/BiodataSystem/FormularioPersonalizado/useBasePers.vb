Imports Medusa.Biodata.Common.BusinessEntities
Imports System.Windows.Forms
'Imports Prominente.DocumentExplorer.ManejadorDeIdioma

Public Class useBasePers


    Protected _value As String = String.Empty

    Public Overridable Property Valor() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

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

    Private _orden As Nullable(Of Integer) = Nothing
    Public Property Orden() As Integer
        Get
            Return _orden
        End Get
        Set(ByVal value As Integer)
            _orden = value
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


    Public Property Seleccionado() As Boolean
        Get
            Return chkSeleccionado.Checked
        End Get
        Set(ByVal value As Boolean)
            chkSeleccionado.Checked = value
        End Set
    End Property

    Private _modoEdicion As Boolean
    Public Property ModoEdicion() As Boolean
        Get
            Return _modoEdicion
        End Get
        Set(ByVal value As Boolean)
            _modoEdicion = value
            chkSeleccionado.Visible = ModoEdicion
        End Set
    End Property

    Protected _EsModificable As Boolean = True
    Public ReadOnly Property EsModificable() As Boolean
        Get
            Return _EsModificable
        End Get
    End Property

    Public ReadOnly Property TipoControl() As TipoControl
        Get
            Select Case Me.GetType.Name
                Case "useChequeo" 
                    Return Medusa.Biodata.Common.BusinessEntities.TipoControl.Chequeo
                Case "useCombo"
                    Return Medusa.Biodata.Common.BusinessEntities.TipoControl.Combo
                Case "useMultiple"
                    Return Medusa.Biodata.Common.BusinessEntities.TipoControl.Multilinea
                Case "useOpcion"
                    Return Medusa.Biodata.Common.BusinessEntities.TipoControl.Opcion
                Case "useTexto"
                    Return Medusa.Biodata.Common.BusinessEntities.TipoControl.Texto
            End Select
        End Get
    End Property

    Private _tipopro As ProductTypeEntity
    Public Property ProductType() As ProductTypeEntity
        Get
            Return _tipopro
        End Get
        Set(ByVal value As ProductTypeEntity)
            _tipopro = value
        End Set
    End Property

    'Protected objIdioma As New ManejadorIdioma("Prominente.DocumentExplorer.ManejadorDeIdioma", "rsfIdioma")
    Private Sub useBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'objIdioma.CambiarIdiomaSO()
        'ActualizarIdioma()
    End Sub

    'Protected Sub ActualizarIdioma()
    '    objIdioma.RefrescarControlesRecursivo(Me)
    'End Sub

    Protected Sub ProcesarExcepcion(ByVal ex As Exception)
        ProcesarExcepcion(ex, MessageBoxIcon.Information)
    End Sub

    Protected Sub ProcesarExcepcion(ByVal ex As Exception, ByVal pIcon As MessageBoxIcon)
        'MessageBox.Show(objIdioma.GetResource(ex.Message, True, True), objIdioma.GetResource("Atencion", True), MessageBoxButtons.OK, pIcon)
        MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, pIcon)
    End Sub

    Protected Sub ProcesarMensaje(ByVal Mensaje As String)
        ProcesarMensaje(Mensaje, MessageBoxButtons.OK)
    End Sub

    Protected Function ProcesarMensaje(ByVal Mensaje As String, ByVal Botones As MessageBoxButtons) As DialogResult
        'Return MessageBox.Show(objIdioma.GetResource(Mensaje, True, True), objIdioma.GetResource("Atencion", True), Botones, MessageBoxIcon.Information)
        Return MessageBox.Show(Mensaje, "Atencion", Botones, MessageBoxIcon.Information)
    End Function
End Class
