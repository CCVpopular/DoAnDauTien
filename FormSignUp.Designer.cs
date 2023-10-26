namespace QLBVMB
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxMaskPass = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbxMaskRePass = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmaIl = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxMaskPass);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.cbxMaskRePass);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtRePass);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmaIl);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpBirthday);
            this.panel1.Controls.Add(this.rbtNu);
            this.panel1.Controls.Add(this.rbtNam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(35, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 341);
            this.panel1.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(328, 104);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 22);
            this.txtCity.TabIndex = 20;
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Location = new System.Drawing.Point(407, 286);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(120, 36);
            this.btnSignUp.TabIndex = 27;
            this.btnSignUp.Text = "Đăng Ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(325, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tỉnh Thành*";
            // 
            // cbxMaskPass
            // 
            this.cbxMaskPass.AutoSize = true;
            this.cbxMaskPass.Location = new System.Drawing.Point(204, 229);
            this.cbxMaskPass.Name = "cbxMaskPass";
            this.cbxMaskPass.Size = new System.Drawing.Size(18, 17);
            this.cbxMaskPass.TabIndex = 26;
            this.cbxMaskPass.UseVisualStyleBackColor = true;
            this.cbxMaskPass.Click += new System.EventHandler(this.cbxMaskPass_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mật Khẩu *";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(25, 226);
            this.txtPass.MaxLength = 14;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(199, 22);
            this.txtPass.TabIndex = 24;
            // 
            // cbxMaskRePass
            // 
            this.cbxMaskRePass.AutoSize = true;
            this.cbxMaskRePass.Location = new System.Drawing.Point(507, 229);
            this.cbxMaskRePass.Name = "cbxMaskRePass";
            this.cbxMaskRePass.Size = new System.Drawing.Size(18, 17);
            this.cbxMaskRePass.TabIndex = 23;
            this.cbxMaskRePass.UseVisualStyleBackColor = true;
            this.cbxMaskRePass.Click += new System.EventHandler(this.cbxMaskRePass_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(325, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nhập Lại Mật Khẩu *";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(328, 226);
            this.txtRePass.MaxLength = 14;
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(199, 22);
            this.txtRePass.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(328, 166);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 22);
            this.txtPhone.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(325, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số Điện Thoại*";
            // 
            // txtEmaIl
            // 
            this.txtEmaIl.Location = new System.Drawing.Point(25, 166);
            this.txtEmaIl.Name = "txtEmaIl";
            this.txtEmaIl.Size = new System.Drawing.Size(199, 22);
            this.txtEmaIl.TabIndex = 13;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(25, 104);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(199, 22);
            this.txtCountry.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quốc Tịch*";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "yyyy-M-d";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(381, 46);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(146, 22);
            this.dtpBirthday.TabIndex = 16;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.ForeColor = System.Drawing.Color.Black;
            this.rbtNu.Location = new System.Drawing.Point(315, 49);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(45, 20);
            this.rbtNu.TabIndex = 15;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.ForeColor = System.Drawing.Color.Black;
            this.rbtNam.Location = new System.Drawing.Point(252, 48);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(57, 20);
            this.rbtNam.TabIndex = 14;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            this.rbtNam.CheckedChanged += new System.EventHandler(this.rbtNam_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(378, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày Sinh*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giới Tính*";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(25, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(199, 22);
            this.txtFullName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ Tên*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "*: Bắt Buộc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormSignUp";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmaIl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox cbxMaskPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox cbxMaskRePass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
    }
}