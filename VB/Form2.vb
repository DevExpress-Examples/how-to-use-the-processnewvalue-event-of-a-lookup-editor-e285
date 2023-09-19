Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ProcessNewValueSample

    Public Partial Class Form2
        Inherits Form

        Public Property ItemID As Object
            Get
                Return TextEdit1.EditValue
            End Get

            Set(ByVal value As Object)
                TextEdit1.EditValue = value
            End Set
        End Property

        Public Property ItemName As String
            Get
                Return TextEdit2.Text
            End Get

            Set(ByVal value As String)
                TextEdit2.EditValue = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
