using QLBVMB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLBVMB
{
    public partial class FormLogIn : Form
    {
        ModelQLBVMB context = new ModelQLBVMB();
        public FormLogIn()
        {
            InitializeComponent();
        }
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool temp = false;
                if (txtUserName.Text == "" || txtPassWord.Text == "")
                {
                    throw new Exception("Mời nhập hết thông tin!");
                }
                else
                {
                    //Kiểm tra thông tin trong SQL, nếu khớp xuất ra thông báo đăng nhập thành công => Sang Form tiếp theo
                    List<KhachHang> listTK = context.KhachHangs.ToList();
                    foreach (KhachHang k in listTK)
                    {
                        if (txtUserName.Text == k.MaKH || txtUserName.Text == k.Email || txtUserName.Text == k.SDT)
                        {
                            if (txtPassWord.Text == k.MatKhau.Trim())
                            {
                                //Chuyển hướng tới form tiếp theo, do chưa có nên đóng form luôn
                                temp = true;
                                FormFuntion formFuntion = new FormFuntion(k.MaKH);
                                formFuntion.Show();
                                this.Hide();
                                break;
                            }
                        }
                    };
                    if(temp == false)
                    {
                        MessageBox.Show("Sai thông tin đăng nhập, mời kiểm tra và nhập lại!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbMaskPW_Click(object sender, EventArgs e)
        {
            if (ckbMaskPW.Checked)
                txtPassWord.PasswordChar = '\0';
            else
                txtPassWord.PasswordChar = '*';
        }

        private void lbForgotPW_Click(object sender, EventArgs e)
        {
            FormForgotPassword forgotPassword = new FormForgotPassword();
            forgotPassword.Show();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
        }
    }
}
