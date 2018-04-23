Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ProcessNewValueSample
	Partial Public Class Form2
		Inherits Form
		Public Property ItemID() As Object
			Get
				Return TextEdit1.EditValue
			End Get
			Set(ByVal value As Object)
				TextEdit1.EditValue = value
			End Set
		End Property
		Public Property ItemName() As String

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

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace