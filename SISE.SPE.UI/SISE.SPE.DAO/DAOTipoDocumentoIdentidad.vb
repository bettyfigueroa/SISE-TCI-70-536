Imports SISE.SPE.BE
Imports SISE.SPE.Util
Imports System.IO

Public Class DAOTipoDocumentoIdentidad
    Implements ITipoDocumentoIdentidad

    Public Function GetAll() As Util.GenericList(Of BE.ETipoDocumentoIdentidad) Implements BE.ITipoDocumentoIdentidad.GetAll
        Dim lTdocXml As XDocument = XDocument.Load(Path.Combine(Constants.PathDataSource, "TipoDocumentoIdentidad.xml"))
        Dim elements As IEnumerable(Of XElement) = lTdocXml.Elements("TipoDocumentoIdentidad").Elements()
        Dim list As New GenericList(Of ETipoDocumentoIdentidad)(New ETipoDocumentoIdentidad(String.Empty, "(SELECCIONE)"))
        For Each item As XElement In elements
            list.Add(New ETipoDocumentoIdentidad(item.Attribute("Codigo").Value, item.Attribute("Descripcion").Value, item.Attribute("MaximoValor").Value))
        Next
        Return list
    End Function
End Class
