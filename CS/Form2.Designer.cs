namespace ProcessNewValueSample {
    partial class Form2 {
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(172, 105);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(62, 20);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "Cancel";
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.Location = new System.Drawing.Point(92, 105);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(62, 20);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "OK";
            // 
            // TextEdit2
            // 
            this.TextEdit2.EditValue = "TextEdit2";
            this.TextEdit2.Location = new System.Drawing.Point(105, 56);
            this.TextEdit2.Name = "TextEdit2";
            this.TextEdit2.Size = new System.Drawing.Size(127, 20);
            this.TextEdit2.TabIndex = 11;
            // 
            // TextEdit1
            // 
            this.TextEdit1.EditValue = "TextEdit1";
            this.TextEdit1.Location = new System.Drawing.Point(105, 22);
            this.TextEdit1.Name = "TextEdit1";
            this.TextEdit1.Size = new System.Drawing.Size(127, 20);
            this.TextEdit1.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(25, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Name:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(25, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 137);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextEdit2);
            this.Controls.Add(this.TextEdit1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form2";
            this.Text = "Edit New Record";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal DevExpress.XtraEditors.TextEdit TextEdit2;
        internal DevExpress.XtraEditors.TextEdit TextEdit1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}