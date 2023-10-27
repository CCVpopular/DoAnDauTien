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
    public partial class FormPayment : Form
    {
        TextBox textBox1 = new TextBox();
        Label label3 = new Label();
        public TextBox textBoxnhantien = new TextBox();
        public TextBox textBoxPIN = new TextBox();
        decimal sothe;
        string tempmakhachhang;
        public FormPayment(string t)
        {
            InitializeComponent();
            tempmakhachhang = t;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            comboBox1.SelectedIndex = 0;
            // 
            // label3
            // 
            panel1.Controls.Remove(textBoxPIN);

            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(9, 235);
            label3.Name = "label3";
            label3.Size = new Size(207, 18);
            label3.TabIndex = 28;
            label3.Text = "Tổng số tiền mặt máy đã nhận";
            panel1.Controls.Add(label3);
            // 
            // textBoxnhantien
            // 
            textBoxnhantien.BorderStyle = BorderStyle.None;
            textBoxnhantien.Location = new Point(12, 267);
            textBoxnhantien.Multiline = true;
            textBoxnhantien.Name = "textBoxnhantien";
            textBoxnhantien.Size = new Size(205, 20);
            textBoxnhantien.TabIndex = 29;
            textBoxnhantien.Text = "0";
            panel1.Controls.Add(textBoxnhantien);

            // 
            // textBox1
            // 
            textBox1.Text = "Quý khách vui lòng đưa từng tờ tiền mặt vào máy\r\nHiện tại máy chỉ hỗ trợ nhận nhữ" +
            "ng tờ tiền có mệnh giá từ 50.000 VND đến 500.000 VND";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            comboBox1.SelectedIndex = 1;
            panel1.Controls.Remove(label3);
            panel1.Controls.Remove(textBoxnhantien);
            textBox1.Text = "Quý khách vui lòng đưa thẻ vào máy và\r\nNhập số PIN";
            // 
            // textBoxPIN
            // 
            textBoxPIN.BackColor = Color.White;
            textBoxPIN.BorderStyle = BorderStyle.FixedSingle;
            textBoxPIN.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBoxPIN.Location = new Point(200, 200);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.Size = new Size(80, 30);
            textBoxPIN.TabIndex = 27;
            textBoxPIN.MaxLength = 6;
            panel1.Controls.Add(textBoxPIN);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new Point(12, 115);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 54);
            textBox1.TabIndex = 27;
            panel1.Controls.Add(textBox1);
            button2.Visible = false;

            ModelQLBVMB context = new ModelQLBVMB();
            var listvemaybay = context.datvemaybays.ToList();
            var listve = context.danhsachves.ToList();
            decimal tongtien = 0;
            foreach (var item in listve)
            {
            }
            foreach (var item in listvemaybay)
            {
                listViewctchuyenbay.Items.Add($"                                                           ");
                listViewctchuyenbay.Items.Add($"       {item.Nơi_khởi_hành} <-----> {item.Nơi_đến}");
                listViewctchuyenbay.Items.Add($"                                                           ");
                listViewctchuyenbay.Items.Add($"    Khởi hành:               {item.Thời_gian_khởi_hành} on {item.Ngày_đi.Day}/{item.Ngày_đi.Month}/{item.Ngày_đi.Year}");
                listViewctchuyenbay.Items.Add($"    Hạng vé: {item.Hạng_vé}");
                listViewctchuyenbay.Items.Add($"    Kiểu vé: {item.Kiểu_vé}");
                listViewctchuyenbay.Items.Add($"    Đơn giá: {item.Giá}");
                listViewctchuyenbay.Items.Add($"");
                tongtien += item.Giá;
            }
            textBoxthue.Text = (tongtien * 10 / 100).ToString();
            textBoxttongtien.Text = (tongtien * 90 / 100).ToString();
            for (int i = 3; i < listViewctchuyenbay.Items.Count; i += 8)
            {
                listViewctchuyenbay.Items[i].Font = new Font("Arial", 16);
                listViewctchuyenbay.Items[i - 1].BackColor = Color.PeachPuff;
                listViewctchuyenbay.Items[i].BackColor = Color.PeachPuff;
                listViewctchuyenbay.Items[i + 1].BackColor = Color.PeachPuff;
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1_Click(sender, e); return;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox4_Click(sender, e); return;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    throw new Exception("Vui lòng chọn phương thức thanh toán");
                }
                if (textBoxPIN.TextLength != 6 && comboBox1.SelectedIndex == 1)
                {
                    throw new Exception("Vui lòng nhập số PIN đủ 6 số");
                }
                if (decimal.Parse(textBoxnhantien.Text) < decimal.Parse(textBoxttongtien.Text) && comboBox1.SelectedIndex == 0)
                {
                    throw new Exception("Vui lòng đưa tiền mặt vào máy đủ hoặc hơn số tiền cần thanh toán");
                }

                ModelQLBVMB context = new ModelQLBVMB();
                var listhoadon = context.HoaDons.ToList();
                var listvemaybay = context.datvemaybays.ToList();
                for (int i = 0; i < listvemaybay.Count; i++)
                {
                }
                FormPaymentSuccess form3 = new FormPaymentSuccess();
                if (comboBox1.SelectedIndex == 0)
                {
                    form3.label2.Visible = true;
                }

                form3.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void savesql()
        {
            try
            {

            }
            catch
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormInputCash form2 = new FormInputCash(this);
            form2.ShowDialog();
        }
        public void text1(double v)
        {
            double temp = double.Parse(textBoxnhantien.Text.ToString());
            temp += v;
            textBoxnhantien.Text = temp.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormInputCard formduathe = new FormInputCard();
            formduathe.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
