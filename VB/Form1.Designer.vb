Namespace ProcessNewValueSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DataGrid1 = New System.Windows.Forms.DataGrid()
            Me.DataView1 = New System.Data.DataView()
            Me.LookupTable = New System.Data.DataTable()
            Me.DataColumn1 = New System.Data.DataColumn()
            Me.DataColumn2 = New System.Data.DataColumn()
            Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.DataSet1 = New System.Data.DataSet()
            CType((Me.RadioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DataGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DataView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LookupTable), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' RadioGroup1
            ' 
            Me.RadioGroup1.EditValue = 1
            Me.RadioGroup1.Location = New System.Drawing.Point(14, 127)
            Me.RadioGroup1.Name = "RadioGroup1"
            Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Solution 1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Solution 2")})
            Me.RadioGroup1.Size = New System.Drawing.Size(174, 48)
            Me.RadioGroup1.TabIndex = 12
            ' 
            ' TextBox1
            ' 
            Me.TextBox1.Location = New System.Drawing.Point(14, 210)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(174, 20)
            Me.TextBox1.TabIndex = 11
            Me.TextBox1.Text = "TextBox1"
            ' 
            ' Label2
            ' 
            Me.Label2.Location = New System.Drawing.Point(214, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(154, 20)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Lookup list rows:"
            ' 
            ' Label1
            ' 
            Me.Label1.Location = New System.Drawing.Point(14, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 20)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "LookUp editor:"
            ' 
            ' DataGrid1
            ' 
            Me.DataGrid1.DataMember = ""
            Me.DataGrid1.DataSource = Me.DataView1
            Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.DataGrid1.Location = New System.Drawing.Point(214, 37)
            Me.DataGrid1.Name = "DataGrid1"
            Me.DataGrid1.Size = New System.Drawing.Size(234, 256)
            Me.DataGrid1.TabIndex = 8
            ' 
            ' DataView1
            ' 
            Me.DataView1.Sort = "ID"
            Me.DataView1.Table = Me.LookupTable
            ' 
            ' LookupTable
            ' 
            Me.LookupTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
            Me.LookupTable.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ID"}, False)})
            Me.LookupTable.TableName = "LookupTable"
            ' 
            ' DataColumn1
            ' 
            Me.DataColumn1.AllowDBNull = False
            Me.DataColumn1.AutoIncrement = True
            Me.DataColumn1.ColumnName = "ID"
            Me.DataColumn1.DataType = GetType(Integer)
            ' 
            ' DataColumn2
            ' 
            Me.DataColumn2.ColumnName = "Name"
            ' 
            ' LookUpEdit1
            ' 
            Me.LookUpEdit1.Location = New System.Drawing.Point(14, 37)
            Me.LookUpEdit1.Name = "LookUpEdit1"
            Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit1.Properties.PopupWidth = 216
            Me.LookUpEdit1.Size = New System.Drawing.Size(174, 20)
            Me.LookUpEdit1.TabIndex = 7
            AddHandler Me.LookUpEdit1.ProcessNewValue, New DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(AddressOf Me.LookUpEdit1_ProcessNewValue)
            ' 
            ' DataSet1
            ' 
            Me.DataSet1.DataSetName = "NewDataSet"
            Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.LookupTable})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(463, 317)
            Me.Controls.Add(Me.RadioGroup1)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.DataGrid1)
            Me.Controls.Add(Me.LookUpEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.RadioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DataGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DataView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LookupTable), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Friend RadioGroup1 As DevExpress.XtraEditors.RadioGroup

        Friend TextBox1 As System.Windows.Forms.TextBox

        Friend Label2 As System.Windows.Forms.Label

        Friend Label1 As System.Windows.Forms.Label

        Friend DataGrid1 As System.Windows.Forms.DataGrid

        Friend LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit

        Friend DataView1 As System.Data.DataView

        Friend LookupTable As System.Data.DataTable

        Friend DataColumn1 As System.Data.DataColumn

        Friend DataColumn2 As System.Data.DataColumn

        Friend DataSet1 As System.Data.DataSet
    End Class
End Namespace
