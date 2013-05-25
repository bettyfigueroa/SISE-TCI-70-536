Public Class AplicationFlow
    Inherits ApplicationContext

    Sub New(ByVal FormParent As Form, ByVal FormChildreen As WinBase)
        FormChildreen.MdiParent = FormParent
        Me.MainForm = FormChildreen      
        Me.MainForm.Show()
    End Sub

    Public Sub Save()
        Try
            DirectCast(Me.MainForm, WinBase).OnBaseSave()
        Catch ex As Exception
            Debug.Fail(ex.Message)
        End Try

    End Sub

    Public Sub Delete()
        Try
            DirectCast(Me.MainForm, WinBase).OnBaseDelete()
        Catch ex As Exception
            Debug.Fail(ex.Message)
        End Try
    End Sub

    Public Sub Search()
        Try
            DirectCast(Me.MainForm, WinBase).OnBaseSearch()
        Catch ex As Exception
            Debug.Fail(ex.Message)
        End Try
    End Sub


End Class
