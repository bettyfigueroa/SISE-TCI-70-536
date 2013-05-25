Imports System.ComponentModel

Public Class WinBase

    Public Delegate Sub DelegateSave()
    Public Delegate Sub DelegateSearch()
    Public Delegate Sub DelegateDelete()

    Public OnBaseSave As DelegateSave
    Public OnBaseSearch As DelegateSearch
    Public OnBaseDelete As DelegateDelete

    Private _titulo As String = "Display Title"
    Private _descripcion As String = "Describe function"
    Private Const _copyRight As String = "Copyright © Instituto SISE"
    Private _font As Font = New Font("Arial", 10, FontStyle.Bold)
    Private _textColorHeader As Color = Color.White
    Private _backgroundColorHeader As Color = Color.FromArgb(157, 2, 0)
    Private _borderColor As Color = Color.FromArgb(19, 101, 51)

#Region "Properties"

    <Category("Header")> _
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    <Category("Header")> _
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <Category("Header")> _
    Public Property FontHeader As Font
        Get
            Return _font
        End Get
        Set(ByVal value As Font)
            _font = value
        End Set
    End Property

    <Category("Header")> _
    Public Property TextColorHeader As Color
        Get
            Return _textColorHeader
        End Get
        Set(ByVal value As Color)
            _textColorHeader = value
        End Set
    End Property

    <Category("Header")> _
    Public Property BackgroundColorHeader As Color
        Get
            Return _backgroundColorHeader
        End Get
        Set(ByVal value As Color)
            _backgroundColorHeader = value
        End Set
    End Property

    <Category("Header")> _
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
        End Set
    End Property

#End Region


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)


        Dim rec As Rectangle = Me.DisplayRectangle
        rec.Height = rec.Height - (rec.Height - 60)
        rec.Width = rec.Width - 2
        e.Graphics.FillRectangle(New SolidBrush(_backgroundColorHeader), rec)
        e.Graphics.DrawRectangle(New Pen(_borderColor), rec)
       
        e.Graphics.DrawImageUnscaled(My.Resources.Logo, New Rectangle(Me.Width - 80, 2, Me.Width, 40))
        Dim strFormat As New StringFormat(StringFormatFlags.NoWrap)
        e.Graphics.DrawString(_titulo, FontHeader, New SolidBrush(_textColorHeader), New PointF(10, 10), strFormat)
        e.Graphics.DrawString(_descripcion, FontHeader, New SolidBrush(_textColorHeader), New PointF(10, 35), strFormat)

        If Me.DesignMode Then
            Dim strFormatCopyright As New StringFormat(StringFormatFlags.DirectionRightToLeft Or StringFormatFlags.DirectionVertical)
            strFormatCopyright.Alignment = StringAlignment.Far
            e.Graphics.DrawString(_copyRight, FontHeader, New SolidBrush(Color.FromArgb(215, 37, 30)), Me.ClientRectangle, strFormatCopyright)
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub

    Private Sub WinBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.OnBaseSave = New DelegateSave(AddressOf Save)
        Me.OnBaseSearch = New DelegateSearch(AddressOf Search)
        Me.OnBaseDelete = New DelegateDelete(AddressOf Delete)

    End Sub


    Protected Overridable Sub Save()

    End Sub


    Protected Overridable Sub Search()

    End Sub


    Protected Overridable Sub Delete()

    End Sub



End Class
