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
    public partial class FormTicketCancellation : Form
    {
        string tempmakhachhang;
        bool check2 = false;
        ModelQLBVMB context = new ModelQLBVMB();
        public FormTicketCancellation(string v)
        {
            InitializeComponent();
            tempmakhachhang = v;
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void FormTicketCancellation_Load(object sender, EventArgs e)    
        {
            loaddatagridview();
        }

        private void loaddatagridview()
        {
            dataGridView1.Rows.Clear();
            var listve = context.danhsachves.ToList();
            var listchuyenbay = context.datvemaybays.ToList();
            TimeSpan oneHour = new TimeSpan(1, 0, 0);
            foreach (var item in listve)
            {
                if (item.Mã_khách_hàng == tempmakhachhang && item.MaHoaDon != null && item.TinhTrang.Trim() == "S")
                {
                    foreach (var item1 in listchuyenbay)
                    {
                        if (item.Mã_chuyến_bay == item1.Mã_chuyến_bay && item1.Ngày_đi.Date > DateTime.Now.Date || item.Mã_chuyến_bay == item1.Mã_chuyến_bay && item1.Ngày_đi.Date == DateTime.Now.Date && item1.Thời_gian_đến > DateTime.Now.TimeOfDay + oneHour)
                        {
                            int i = dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[1].Value = item.Mã_vé_chuyến_bay;
                            dataGridView1.Rows[i].Cells[2].Value = item1.Nơi_khởi_hành;
                            dataGridView1.Rows[i].Cells[3].Value = item1.Nơi_đến;
                            dataGridView1.Rows[i].Cells[4].Value = item1.Thời_gian_khởi_hành;
                            dataGridView1.Rows[i].Cells[5].Value = item1.Thời_gian_đến;
                            dataGridView1.Rows[i].Cells[6].Value = item1.Ngày_đi.Day + "/" + item1.Ngày_đi.Month + "/" + item1.Ngày_đi.Year;
                            if (item1.Ngày_về != null)
                            {
                                dataGridView1.Rows[i].Cells[7].Value = item1.Ngày_về.Value.Day + "/" + item1.Ngày_về.Value.Month + "/" + item1.Ngày_về.Value.Year;
                            }
                            dataGridView1.Rows[i].Cells[8].Value = item1.Hạng_vé;
                            dataGridView1.Rows[i].Cells[9].Value = item1.Kiểu_vé;
                            dataGridView1.Rows[i].Cells[10].Value = item1.Máy_bay;
                            dataGridView1.Rows[i].Cells[11].Value = item1.Giá;
                        }
                    }
                }
            }
        }

        private void bntfind_Click(object sender, EventArgs e)
        {
            FormFuntion formFuntion = new FormFuntion(tempmakhachhang);
            formFuntion.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                var listve = context.danhsachves.ToList();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        check = true;
                        foreach (var item in listve)
                        {
                            if (item.Mã_vé_chuyến_bay == row.Cells[1].Value.ToString())
                            {
                                item.TinhTrang = "C";
                            }
                        }
                    }
                }
                if (check == false)
                {
                    throw new Exception("Vui lòng chọn vé cần hủy trong danh sách");
                }
                context.SaveChanges();
                loaddatagridview();
                check2 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i != e.RowIndex)
                    {
                        dataGridView1[e.ColumnIndex, i].Value = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check2 == true)
            {
                FormPaymentSuccess formPaymentSuccess = new FormPaymentSuccess();
                formPaymentSuccess.label1.Text = "Hủy vé thành công\r\nquý khách vui lòng kiểm tra lại tiền thừa từ máy";
                formPaymentSuccess.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vé cần hủy trước khi thanh toán");
            }
        }
    }
}
