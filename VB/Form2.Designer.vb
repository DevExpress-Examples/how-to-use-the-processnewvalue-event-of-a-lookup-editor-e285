Imports Microsoft.VisualBasic
Imports System
Namespace ProcessNewValueSample
	Partial Public Class Form2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Button2 = New System.Windows.Forms.Button()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' Button2
			' 
			Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Button2.Location = New System.Drawing.Point(172, 105)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New System.Drawing.Size(62, 20)
			Me.Button2.TabIndex = 13
			Me.Button2.Text = "Cancel"
			' 
			' Button1
			' 
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button1.Location = New System.Drawing.Point(92, 105)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New System.Drawing.Size(62, 20)
			Me.Button1.TabIndex = 12
			Me.Button1.Text = "OK"
			' 
			' TextEdit2
			' 
			Me.TextEdit2.EditValue = "TextEdit2"
			Me.TextEdit2.Location = New System.Drawing.Point(105, 56)
			Me.TextEdit2.Name = "TextEdit2"
			Me.TextEdit2.Size = New System.Drawing.Size(127, 20)
			Me.TextEdit2.TabIndex = 11
			' 
			' TextEdit1
			' 
			Me.TextEdit1.EditValue = "TextEdit1"
			Me.TextEdit1.Location = New System.Drawing.Point(105, 22)
			Me.TextEdit1.Name = "TextEdit1"
			Me.TextEdit1.Size = New System.Drawing.Size(127, 20)
			Me.TextEdit1.TabIndex = 10
			' 
			' Label2
			' 
			Me.Label2.Location = New System.Drawing.Point(25, 56)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New System.Drawing.Size(60, 20)
			Me.Label2.TabIndex = 9
			Me.Label2.Text = "Name:"
			' 
			' Label1
			' 
			Me.Label1.Location = New System.Drawing.Point(25, 22)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(60, 20)
			Me.Label1.TabIndex = 8
			Me.Label1.Text = "ID:"
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(245, 137)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextEdit2)
			Me.Controls.Add(Me.TextEdit1)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Name = "Form2"
			Me.Text = "Edit New Record"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend Button2 As System.Windows.Forms.Button
		Friend Button1 As System.Windows.Forms.Button
		Friend TextEdit2 As DevExpress.XtraEditors.TextEdit
		Friend TextEdit1 As DevExpress.XtraEditors.TextEdit
		Friend Label2 As System.Windows.Forms.Label
		Friend Label1 As System.Windows.Forms.Label
	End Class
End Namespace