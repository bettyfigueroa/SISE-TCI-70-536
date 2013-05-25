Imports SISE.SPE.BE

Public Class WinPersonal

    Private Sub WinPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim bl As New BL.BLTipoDocumentoIdentidad
            cboTipDocumento.DataSource = bl.GetAll()
            cboTipDocumento.DisplayMember = "Descripcion"
            cboTipDocumento.ValueMember = "Codigo"
        Catch ex As Exception
            Debug.WriteLine("Excepción en el load:  " & ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Save()
        MyBase.Save()
        Dim EsValido As Boolean = False
        ErrMessage.Clear()

        If String.IsNullOrEmpty(txtApellidoPaterno.Text) Then
            ErrMessage.SetError(txtApellidoPaterno, "Apellido paterno es requerido")
            EsValido = True
        End If

        If String.IsNullOrEmpty(txtApellidoMaterno.Text) Then
            ErrMessage.SetError(txtApellidoMaterno, "Apellido materno es requerido")
            EsValido = True
        End If

        If String.IsNullOrEmpty(txtNombres.Text) Then
            ErrMessage.SetError(txtNombres, "Nombre es requerido")
            EsValido = True
        End If

        If String.IsNullOrEmpty(cboSexo.SelectedValue) Then
            ErrMessage.SetError(cboSexo, "Sexo es requerido")
            EsValido = True
        End If

        If String.IsNullOrEmpty(cboTipDocumento.SelectedValue) Then
            ErrMessage.SetError(cboTipDocumento, "Tipo de documento es requerido")
            EsValido = True
        End If

        Dim documento As ETipoDocumentoIdentidad = DirectCast(cboTipDocumento.SelectedItem, ETipoDocumentoIdentidad)
        If txtNumDocumento.TextLength > documento.MaximoValor And documento.LongitudFija = False Then
            ErrMessage.SetError(txtNumDocumento, String.Format("El documento {0} debe tener un número menor o igual a {1} caractere(s)", documento.Descripcion, documento.MaximoValor))
            EsValido = True
        ElseIf txtNumDocumento.TextLength <> documento.MaximoValor And documento.LongitudFija = True Then
            ErrMessage.SetError(txtNumDocumento, String.Format("El documento {0} debe tener {1} caractere(s)", documento.Descripcion, documento.MaximoValor))
            EsValido = True
        End If
 
        If Not EsValido Then

        End If

    End Sub


End Class