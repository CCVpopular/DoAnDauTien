namespace QLBVMB
{
    partial class FormLogIn
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
            this.BtnReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbMaskPW = new System.Windows.Forms.CheckBox();
            this.lbForgotPW = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.BtnReg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ckbMaskPW);
            this.panel1.Controls.Add(this.lbForgotPW);
            this.panel1.Controls.Add(this.BtnLogIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(29, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 159);
            this.panel1.TabIndex = 3;
            // 
            // BtnReg
            // 
            this.BtnReg.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.ForeColor = System.Drawing.Color.Black;
            this.BtnReg.Location = new System.Drawing.Point(43, 127);
            this.BtnReg.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(82, 22);
            this.BtnReg.TabIndex = 10;
            this.BtnReg.Text = "Đăng Ký";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "*: Bắt Buộc";
            // 
            // ckbMaskPW
            // 
            this.ckbMaskPW.AutoSize = true;
            this.ckbMaskPW.Location = new System.Drawing.Point(202, 79);
            this.ckbMaskPW.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMaskPW.Name = "ckbMaskPW";
            this.ckbMaskPW.Size = new System.Drawing.Size(15, 14);
            this.ckbMaskPW.TabIndex = 4;
            this.ckbMaskPW.UseVisualStyleBackColor = true;
            this.ckbMaskPW.Click += new System.EventHandler(this.ckbMaskPW_Click);
            // 
            // lbForgotPW
            // 
            this.lbForgotPW.AutoSize = true;
            this.lbForgotPW.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPW.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbForgotPW.Location = new System.Drawing.Point(134, 106);
            this.lbForgotPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForgotPW.Name = "lbForgotPW";
            this.lbForgotPW.Size = new System.Drawing.Size(87, 14);
            this.lbForgotPW.TabIndex = 8;
            this.lbForgotPW.Text = "Quên Mật Khẩu?";
            this.lbForgotPW.Click += new System.EventHandler(this.lbForgotPW_Click);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.Color.Black;
            this.BtnLogIn.Location = new System.Drawing.Point(136, 127);
            this.BtnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(82, 22);
            this.BtnLogIn.TabIndex = 5;
            this.BtnLogIn.Text = "Đăng Nhập";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu *";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(19, 76);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.MaxLength = 14;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(200, 20);
            this.txtPassWord.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(19, 31);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thành Viên / Email / SĐT *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbForgotPW;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbMaskPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReg;
    }
}

