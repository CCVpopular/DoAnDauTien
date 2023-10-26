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
    public partial class FormForgotPassword : Form
    {
        ModelQLBVMB context = new ModelQLBVMB();
        int txtMode = 0;
        int number = 0;
        int index = 0;
        Random Random = new Random();
        public FormForgotPassword()
        {
            InitializeComponent();
            number = GenRanNum();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            List<KhachHang> listTK = context.KhachHangs.ToList();
            if (txtMode == 0)
            {
                if (txtVerify.Text == "")
                    MessageBox.Show("Mời nhập hết thông tin!");
                else
                {
                    //Dùng vòng lập for tìm tài khoản chỉ định và lưu index
                    for (int i = 0; i < listTK.Count; i++)
                    {
                        if (txtVerify.Text == listTK[i].MaKH || txtVerify.Text == listTK[i].Email || txtVerify.Text == listTK[i].SDT)
                        {
                            txtMode = 1;
                            index = i;
                            label2.Text = "Mời nhập mã xác nhận đã gửi *";
                            txtVerify.Text = "";
                            txtVerify.MaxLength = 6;
                            //Hiện mã xác nhận do không thể kết nối với thiết bị bên ngoài
                            MessageBox.Show("Mã xác nhận: " + number.ToString());
                        }
                    }
                }
            }
            else if (txtMode == 2)
            {
                if (txtVerify.Text == "" || textBox1.Text == "" || txtVerify.Text != textBox1.Text)
                    MessageBox.Show("Mời nhập đúng thông tin!");
                else
                {
                    //Cập nhật mật khẩu mới vào tài khoản tương ứng trong SQL bằng index đã lưu từ trước
                    if (txtVerify.Text == textBox1.Text)
                    {
                        listTK[index].MatKhau = txtVerify.Text;
                        context.SaveChanges();
                    }
                    MessageBox.Show("Đổi mật khẩu thành công");
                    Close();
                }
            }
            else
            {
                if (txtVerify.Text == number.ToString())
                {
                    txtMode = 2;
                    panel1.Size = new System.Drawing.Size(310, 202);
                    BtnSubmit.Location = new System.Drawing.Point(181, 153);
                    label4.Location = new System.Drawing.Point(22, 131);
                    label3.Visible = true;
                    checkBox1.Visible = true;
                    textBox1.Visible = true;
                    ckbMaskPW.Visible = true;
                    label2.Text = "Mời nhập mật khẩu mới *";
                    txtVerify.Text = "";
                    txtVerify.MaxLength = 14;
                }
                else
                    MessageBox.Show("Nhập sai mã xác nhận");
            }
        }

        private int GenRanNum()
        {
            return Random.Next(100000, 999999);
        }

        private void ckbMaskPW_Click(object sender, EventArgs e)
        {
            if (ckbMaskPW.Checked)
                txtVerify.PasswordChar = '\0';
            else
                txtVerify.PasswordChar = '*';
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.PasswordChar = '\0';
            else
                textBox1.PasswordChar = '*';
        }
    }
}
