Public Class GenericList(Of T)
    Inherits List(Of T)

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal val As T)
        MyBase.New()
        Me.Add(val)
    End Sub

 
End Class


