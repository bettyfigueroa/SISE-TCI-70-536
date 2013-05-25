Public Class WinMDI

    Private Sub tsmiPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPersonal.Click
        FlowChildren = New AplicationFlow(Me, WinPersonal)
    End Sub

    Private Sub WinMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FlowChildren.Save()
    End Sub
End Class