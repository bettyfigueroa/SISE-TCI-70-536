Imports SISE.SPE.BE
Imports SISE.SPE.DAO

Public Class BLTipoDocumentoIdentidad
    Implements ITipoDocumentoIdentidad

    Private dao As New DAOTipoDocumentoIdentidad

    Public Function GetAll() As Util.GenericList(Of BE.ETipoDocumentoIdentidad) Implements BE.ITipoDocumentoIdentidad.GetAll
        Return dao.GetAll()
    End Function
End Class
