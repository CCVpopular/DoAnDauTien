using QLBVMB.Model;
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
    public partial class FormInputCard : Form
    {
        ModelQLBVMB context = new ModelQLBVMB();
        public FormInputCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool temp = false;
                if(textBox1.Text == null || textBox1.Text == "")
                {
                    throw new Exception("Vui lòng nhập số thẻ");
                }
                var listcard = context.ThongTinThes.ToList();
                foreach (var item in listcard)
                {
                    if (item.sothe == decimal.Parse(textBox1.Text))
                    {
                        if (Application.OpenForms["FormPayment"] is FormPayment form1)
                        {
                            form1.textcard(item.sothe);
                            temp = true;
                            this.Close();
                        }
                    }
                }
                if(temp == false)
                {
                    throw new Exception("Vui lòng nhập số thẻ hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
