Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class UITextBox
    Inherits TextBox
    Private oldFont As Font = Nothing
    Private waterMarkTextEnabled As [Boolean] = False

#Region "Attributes"

    Private _waterMarkColor As Color = Color.Gray
    Private _waterMarkText As String = "Water Mark"

    <Category("WaterMark"), Description("Obtiene o establece el color del texto de agua")>
    Public Property WaterMarkColor() As Color
        Get
            Return _waterMarkColor
        End Get
        Set(ByVal value As Color)
            _waterMarkColor = value
            Invalidate()
        End Set
    End Property

    <Category("WaterMark"), Description("Obtiene o establece el texto de agua")>
    Public Property WaterMarkText() As String
        Get
            Return _waterMarkText
        End Get
        Set(ByVal value As String)
            _waterMarkText = value
            Invalidate()
        End Set
    End Property

#End Region

    Public Sub New()
        JoinEvents(True)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        WaterMark_Toggel(Nothing, Nothing)
    End Sub

    Protected Overrides Sub OnPaint(ByVal args As PaintEventArgs)
        Dim drawFont As New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Dim drawBrush As New SolidBrush(WaterMarkColor)
        args.Graphics.DrawString((If(waterMarkTextEnabled, WaterMarkText, Text)), drawFont, drawBrush, New PointF(0.0F, 0.0F))
        MyBase.OnPaint(args)
    End Sub

    Private Sub JoinEvents(ByVal join As [Boolean])
        If join Then
            AddHandler Me.TextChanged, New System.EventHandler(AddressOf Me.WaterMark_Toggel)
            AddHandler Me.LostFocus, New System.EventHandler(AddressOf Me.WaterMark_Toggel)
            AddHandler Me.FontChanged, New System.EventHandler(AddressOf Me.WaterMark_FontChanged)
        End If
    End Sub

    Private Sub WaterMark_Toggel(ByVal sender As Object, ByVal args As EventArgs)
        If Me.Text.Length <= 0 Then
            EnableWaterMark()
        Else
            DisbaleWaterMark()
        End If
    End Sub

    Private Sub EnableWaterMark()
        oldFont = New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.waterMarkTextEnabled = True
        Refresh()
    End Sub

    Private Sub DisbaleWaterMark()
        Me.waterMarkTextEnabled = False
        Me.SetStyle(ControlStyles.UserPaint, False)
        If oldFont IsNot Nothing Then
            Me.Font = New System.Drawing.Font(oldFont.FontFamily, oldFont.Size, oldFont.Style, oldFont.Unit)
        End If
    End Sub

    Private Sub WaterMark_FontChanged(ByVal sender As Object, ByVal args As EventArgs)
        If waterMarkTextEnabled Then
            oldFont = New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
            Refresh()
        End If
    End Sub
End Class
