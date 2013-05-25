Imports System.IO

Public Class Constants
    Public Shared PathExecute As String = System.AppDomain.CurrentDomain.BaseDirectory
    Public Shared SourceDirectory As String = "DataSource"
    Public Shared PathDataSource As String = Path.Combine(PathExecute, SourceDirectory)
End Class
