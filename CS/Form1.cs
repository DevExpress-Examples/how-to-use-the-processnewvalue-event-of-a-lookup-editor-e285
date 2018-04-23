using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace ProcessNewValueSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void FillLookupTable() {
            const int RowCount = 5;
            DataRow Row;

            for(int i = 1; i <= RowCount; i++) {
                Row = LookupTable.NewRow();
                Row["Name"] = "Item " + i.ToString();
                LookupTable.Rows.Add(Row);
            }
            LookupTable.AcceptChanges();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            FillLookupTable();
            LookUpEdit1.Properties.DataSource = LookupTable;
            LookUpEdit1.Properties.ValueMember = "ID";
            LookUpEdit1.Properties.DisplayMember = "Name";
            LookUpEdit1.Properties.PopulateColumns();
            LookUpEdit1.Properties.AutoSearchColumnIndex = 1;
            LookUpEdit1.Properties.DropDownRows = 20;
            LookUpEdit1.Properties.ValidateOnEnterKey = true;

            LookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void LookUpEdit1_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e) {
            Console.WriteLine("LookUpEdit1_ProcessNewValue: {0}", e.DisplayValue);

            DataRow Row;
            RepositoryItemLookUpEdit Edit;
            Edit = ((LookUpEdit)sender).Properties;

            if(e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                return;


            if((int)RadioGroup1.EditValue == 1) {
                // solution 1 
                Row = LookupTable.NewRow();
                Row["Name"] = e.DisplayValue;
                LookupTable.Rows.Add(Row);
            }
            else
                // solution 2 
                using(Form2 f = new Form2()) {
                    f.ItemID = "(Auto Number)";
                    f.ItemName = e.DisplayValue.ToString();
                    if(f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                        e.DisplayValue = f.ItemName;
                        Row = LookupTable.NewRow();
                        Row["Name"] = f.ItemName;
                        LookupTable.Rows.Add(Row);
                    }
                }
            e.Handled = true;
        }
    }
}