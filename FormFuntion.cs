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
    public partial class FormFuntion : Form
    {
        public FormFuntion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBookTickets formBookTickets = new FormBookTickets();
            formBookTickets.Show();
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Close();
        }
    }
}
