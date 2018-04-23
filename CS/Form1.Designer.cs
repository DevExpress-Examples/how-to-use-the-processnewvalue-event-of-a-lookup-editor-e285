namespace ProcessNewValueSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.RadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.DataView1 = new System.Data.DataView();
            this.LookupTable = new System.Data.DataTable();
            this.DataColumn1 = new System.Data.DataColumn();
            this.DataColumn2 = new System.Data.DataColumn();
            this.LookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.DataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioGroup1
            // 
            this.RadioGroup1.EditValue = 1;
            this.RadioGroup1.Location = new System.Drawing.Point(14, 127);
            this.RadioGroup1.Name = "RadioGroup1";
            this.RadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Solution 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Solution 2")});
            this.RadioGroup1.Size = new System.Drawing.Size(174, 48);
            this.RadioGroup1.TabIndex = 12;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(14, 210);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(174, 20);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = "TextBox1";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(214, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(154, 20);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Lookup list rows:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(14, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 20);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "LookUp editor:";
            // 
            // DataGrid1
            // 
            this.DataGrid1.DataMember = "";
            this.DataGrid1.DataSource = this.DataView1;
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(214, 37);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(234, 256);
            this.DataGrid1.TabIndex = 8;
            // 
            // DataView1
            // 
            this.DataView1.Sort = "ID";
            this.DataView1.Table = this.LookupTable;
            // 
            // LookupTable
            // 
            this.LookupTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn1,
            this.DataColumn2});
            this.LookupTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, false)});
            this.LookupTable.TableName = "LookupTable";
            // 
            // DataColumn1
            // 
            this.DataColumn1.AllowDBNull = false;
            this.DataColumn1.AutoIncrement = true;
            this.DataColumn1.ColumnName = "ID";
            this.DataColumn1.DataType = typeof(int);
            // 
            // DataColumn2
            // 
            this.DataColumn2.ColumnName = "Name";
            // 
            // LookUpEdit1
            // 
            this.LookUpEdit1.Location = new System.Drawing.Point(14, 37);
            this.LookUpEdit1.Name = "LookUpEdit1";
            this.LookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit1.Properties.PopupWidth = 216;
            this.LookUpEdit1.Size = new System.Drawing.Size(174, 20);
            this.LookUpEdit1.TabIndex = 7;
            this.LookUpEdit1.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.LookUpEdit1_ProcessNewValue);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "NewDataSet";
            this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.LookupTable});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 317);
            this.Controls.Add(this.RadioGroup1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.LookUpEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.RadioGroup RadioGroup1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGrid DataGrid1;
        internal DevExpress.XtraEditors.LookUpEdit LookUpEdit1;
        internal System.Data.DataView DataView1;
        internal System.Data.DataTable LookupTable;
        internal System.Data.DataColumn DataColumn1;
        internal System.Data.DataColumn DataColumn2;
        internal System.Data.DataSet DataSet1;

    }
}

