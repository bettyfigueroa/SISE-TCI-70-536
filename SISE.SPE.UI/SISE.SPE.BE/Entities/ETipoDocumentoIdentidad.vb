<DebuggerDisplay("Codigo={_codigo}, Descripcion={_Descripcion}, MaximoValor={_maximoValor}, LongitudFija={_longitudFija}")> _
Public Class ETipoDocumentoIdentidad
    Implements IDisposable

    Private _codigo As String = String.Empty
    Private _descripcion As String = String.Empty
    Private _maximoValor As Int32 = 0
    Private _longitudFija As Boolean = False

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property MaximoValor As Integer
        Get
            Return _maximoValor
        End Get
        Set(ByVal value As Integer)
            _maximoValor = value
        End Set
    End Property

    Public Property LongitudFija As Boolean
        Get
            Return _longitudFija
        End Get
        Set(ByVal value As Boolean)
            _longitudFija = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal pCodigo As String, ByVal pDescripcion As String)
        _codigo = pCodigo
        _descripcion = pDescripcion
    End Sub

    Public Sub New(ByVal pCodigo As String, ByVal pDescripcion As String, ByVal pMaximoValor As Integer)
        _codigo = pCodigo
        _descripcion = pDescripcion
        _maximoValor = pMaximoValor
    End Sub

    Public Sub New(ByVal pCodigo As String, ByVal pDescripcion As String, ByVal pMaximoValor As Integer, ByVal pLongitudFija As Boolean)
        _codigo = pCodigo
        _descripcion = pDescripcion
        _maximoValor = pMaximoValor
        _longitudFija = pLongitudFija
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _codigo = String.Empty
                _descripcion = String.Empty
                MaximoValor = 0
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
