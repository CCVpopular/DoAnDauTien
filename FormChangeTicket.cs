using QLBVMB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class FormChangeTicket : Form
    {
        string tempmakhachhang;
        string tempmavemaybay;
        bool x1;
        public FormChangeTicket(string  v,bool x)
        {
            InitializeComponent();
            tempmakhachhang = v;
            x1 = x;
        }
        ModelQLBVMB context = new ModelQLBVMB();
        List<datvemaybay> datvemaybays = new List<datvemaybay>();
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {

                bool anyCheckboxSelected = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        tempmavemaybay = row.Cells[1].Value.ToString();
                        anyCheckboxSelected = true;
                        break;
                    }

                }

                if (anyCheckboxSelected)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.CurrentCell.ColumnIndex].Value) == true)
                    {
                        FormTicketList thayDoiVe = new FormTicketList(tempmakhachhang, tempmavemaybay);
                        thayDoiVe.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chuyến bay cần đổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormFuntion formFuntion = new FormFuntion(tempmakhachhang);
            formFuntion.Show();
            this.Close();
        }

        private void DoiVe_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }
        public void loaddatagridview()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (x1)
            {
                MessageBox.Show("Quý khách vui lòng kiểm tra lại tiền từ máy");
                FormPayment formPayment = new FormPayment(tempmakhachhang, true);
                formPayment.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("quý khách vui lòng đổi vé trước khi thanh toán");
            }
        }
    }
}
