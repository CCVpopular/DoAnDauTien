namespace QLBVMB
{
    partial class FormFuntion
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
            this.components = new System.ComponentModel.Container();
            this.buttondatve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonhuyve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttondatve
            // 
            this.buttondatve.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondatve.Location = new System.Drawing.Point(581, 126);
            this.buttondatve.Name = "buttondatve";
            this.buttondatve.Size = new System.Drawing.Size(263, 65);
            this.buttondatve.TabIndex = 0;
            this.buttondatve.Text = "Đặt vé";
            this.buttondatve.UseVisualStyleBackColor = true;
            this.buttondatve.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quý khách vui lòng chọn một trong những chức năng sau";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(-1, 338);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(263, 65);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Thoát";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // buttonhuyve
            // 
            this.buttonhuyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhuyve.Location = new System.Drawing.Point(581, 338);
            this.buttonhuyve.Name = "buttonhuyve";
            this.buttonhuyve.Size = new System.Drawing.Size(263, 65);
            this.buttonhuyve.TabIndex = 4;
            this.buttonhuyve.Text = "Hủy vé";
            this.buttonhuyve.UseVisualStyleBackColor = true;
            this.buttonhuyve.Click += new System.EventHandler(this.buttonhuyve_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đổi vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormFuntion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonhuyve);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondatve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuntion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFuntion";
            this.Load += new System.EventHandler(this.FormFuntion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondatve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonhuyve;
        private System.Windows.Forms.Button button1;
    }
}