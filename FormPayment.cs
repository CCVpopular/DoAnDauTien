using QLBVMB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class FormPayment : Form
    {
        ModelQLBVMB context = new ModelQLBVMB();
        TextBox textBox1 = new TextBox();
        Label label3 = new Label();
        public TextBox textBoxnhantien = new TextBox();
        public TextBox textBoxPIN = new TextBox();
        private decimal sothe = 0;
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
            foreach (var item1 in listve)
            {
                if(tempmakhachhang == item1.Mã_khách_hàng && item1.MaHoaDon == null)
                {
                    foreach (var item in listvemaybay)
                    {
                        if (item1.Mã_chuyến_bay == item.Mã_chuyến_bay)
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
                    }
                }
            }
            textBoxthue.Text = (tongtien * 10 / 100).ToString();
            textBoxttongtien.Text = (tongtien + (tongtien * 10 / 100)).ToString();
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
                if(sothe == 0)
                {
                    throw new Exception("Quý khách vui lòng đưa thẻ vào máy");
                }
                if (textBoxPIN.TextLength != 6 && comboBox1.SelectedIndex == 1)
                {
                    throw new Exception("Vui lòng nhập số PIN đủ 6 số");
                }
                var listcard = context.ThongTinThes.ToList();
                bool temp = false;
                foreach (var item in listcard)
                {
                    if (item.sothe == sothe && item.pin == decimal.Parse(textBoxPIN.Text))
                    {
                        temp = true; break;
                    }
                }
                if (temp == false)
                {
                    throw new Exception("Vui lòng nhập số số thẻ và số PIN hợp lệ");
                }
                if(comboBox1.SelectedIndex == 0)
                {
                    if (decimal.Parse(textBoxnhantien.Text) < decimal.Parse(textBoxttongtien.Text))
                    {
                        throw new Exception("Vui lòng đưa tiền mặt vào máy đủ hoặc hơn số tiền cần thanh toán");
                    }
                }
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
                savesql();
                form3.Show();
                this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        public void savesql()
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var listve = context.danhsachves.ToList();
                    var listhoadon = context.HoaDons.ToList();
                    for (int i = 0; i < listve.Count; i++)
                    {
                        if (tempmakhachhang == listve[i].Mã_khách_hàng && listve[i].MaHoaDon == null)
                        {
                            listve[i].MaHoaDon = "HD" + (listhoadon.Count + 1).ToString("D4"); ;
                        }
                    }
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHoaDon = "HD" + (listhoadon.Count + 1).ToString("D4");
                    hoaDon.MaKH = tempmakhachhang;
                    hoaDon.NgayLapHoaDon = DateTime.Now;
                    hoaDon.Thue = double.Parse(textBoxthue.Text);
                    hoaDon.TongTien = double.Parse(textBoxttongtien.Text);
                    context.HoaDons.Add(hoaDon);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormInputCash form2 = new FormInputCash();
            form2.ShowDialog();
        }
        public void textcash(double v)
        {
            double temp = double.Parse(textBoxnhantien.Text.ToString());
            temp += v;
            textBoxnhantien.Text = temp.ToString();
        }
        public void textcard(decimal v)
        {
            sothe = v;
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

        private void textBoxthue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
