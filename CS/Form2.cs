using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessNewValueSample {
    public partial class Form2 : Form {
        public object ItemID {
            get { return TextEdit1.EditValue; }
            set { TextEdit1.EditValue = value; }
        }
        public string ItemName {

            get { return TextEdit2.Text; }
            set { TextEdit2.EditValue = value; }
        } 

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}