﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class FormInputCash : Form
    {
        private FormPayment formPayment;
        public FormInputCash(FormPayment formPayment)
        {
            InitializeComponent();
            this.formPayment = formPayment;
        }

        public string DataToPass { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.text1(50000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.text1(100000);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.text1(200000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.text1(500000);
            }
        }
    }
}
