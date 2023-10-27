using System;
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
        public FormInputCash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.textcash(50000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.textcash(100000);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.textcash(200000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPayment"] is FormPayment form1)
            {
                form1.textcash(500000);
            }
        }
    }
}
