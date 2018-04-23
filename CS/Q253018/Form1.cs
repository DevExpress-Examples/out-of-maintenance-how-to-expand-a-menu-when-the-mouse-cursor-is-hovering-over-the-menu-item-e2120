using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Q253018 {
    public partial class Form1 :Form {

        BarHelper helper;

        public Form1() {
            InitializeComponent();
            helper = new BarHelper(barManager1);
            helper.ExpandMenuOnMouseHover = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.ExpandMenuOnMouseHover = false;
        }
    }
}