using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QLBVMB.Model;

namespace QLBVMB
{
    public partial class FormSignUp : Form
    {
        string Gender = "Nam";
        ModelQLBVMB context = new ModelQLBVMB();
        public FormSignUp()
        {
            InitializeComponent();
        }
        //Đợi có SQL code textbox sau

        private void cbxMaskPass_Click(object sender, EventArgs e)
        {
            if (cbxMaskPass.Checked)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }

        private void cbxMaskRePass_Click(object sender, EventArgs e)
        {
            if (cbxMaskRePass.Checked)
                txtRePass.PasswordChar = '\0';
            else
                txtRePass.PasswordChar = '*';
        }

        private void rbtNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNam.Checked)
                Gender = "Nam";
            else
                Gender = "Nữ";
        }

        private string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            List<KhachHang> listTK = context.KhachHangs.ToList();
            string ID = GenerateNumber();
            foreach (KhachHang k in listTK)
            {
                if (ID == k.MaKH)
                    ID = GenerateNumber();
            }
            try
            {
                if (txtFullName.Text == "" || txtCountry.Text == "" || txtCity.Text == "" || txtEmaIl.Text == "" || txtPhone.Text == "" || txtPass.Text == "" || txtRePass.Text == "")
                    MessageBox.Show("Mời nhập hết thông tin!");
                else if (!rbtNam.Checked && !rbtNu.Checked)
                    MessageBox.Show("Mời chọn giới tính theo trên giấy tờ tùy thân!");
                else if (txtPass.Text != txtRePass.Text)
                    MessageBox.Show("Phần Mật Khẩu và Điền Lại Mật Khẩu phải trùng nhau");
                else
                {
                    KhachHang newkhach = new KhachHang() { MaKH = ID, HoTen = txtFullName.Text, GioiTinh = Gender, NgaySinh = dtpBirthday.Value, QuocTich = txtCountry.Text, TinhThanh = txtCity.Text, Email = txtEmaIl.Text, SDT = txtPhone.Text, MatKhau = txtPass.Text };
                    context.KhachHangs.Add(newkhach);
                    context.SaveChanges();
                    MessageBox.Show("Đăng Ký thành công!, mã khách hàng của bạn là: " + ID);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
