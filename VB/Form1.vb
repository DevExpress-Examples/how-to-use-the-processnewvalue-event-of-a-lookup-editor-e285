Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace ProcessNewValueSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FillLookupTable()
            Const RowCount As Integer = 5
            Dim Row As DataRow
            For i As Integer = 1 To RowCount
                Row = LookupTable.NewRow()
                Row("Name") = "Item " & i.ToString()
                LookupTable.Rows.Add(Row)
            Next

            LookupTable.AcceptChanges()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillLookupTable()
            LookUpEdit1.Properties.DataSource = LookupTable
            LookUpEdit1.Properties.ValueMember = "ID"
            LookUpEdit1.Properties.DisplayMember = "Name"
            LookUpEdit1.Properties.PopulateColumns()
            LookUpEdit1.Properties.AutoSearchColumnIndex = 1
            LookUpEdit1.Properties.DropDownRows = 20
            LookUpEdit1.Properties.ValidateOnEnterKey = True
            LookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
            LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End Sub

        Private Sub LookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs)
            Console.WriteLine("LookUpEdit1_ProcessNewValue: {0}", e.DisplayValue)
            Dim Row As DataRow
            Dim Edit As RepositoryItemLookUpEdit
            Edit = CType(sender, LookUpEdit).Properties
            If e.DisplayValue Is Nothing OrElse Edit.NullText.Equals(e.DisplayValue) OrElse String.Empty.Equals(e.DisplayValue) Then Return
            If CInt(RadioGroup1.EditValue) = 1 Then
                ' solution 1 
                Row = LookupTable.NewRow()
                Row("Name") = e.DisplayValue
                LookupTable.Rows.Add(Row)
            Else
                ' solution 2 
                Using f As Form2 = New Form2()
                    f.ItemID = "(Auto Number)"
                    f.ItemName = e.DisplayValue.ToString()
                    If f.ShowDialog(Me) = DialogResult.OK Then
                        e.DisplayValue = f.ItemName
                        Row = LookupTable.NewRow()
                        Row("Name") = f.ItemName
                        LookupTable.Rows.Add(Row)
                    End If
                End Using
            End If

            e.Handled = True
        End Sub
    End Class
End Namespace
