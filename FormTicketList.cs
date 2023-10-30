using QLBVMB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class FormTicketList : Form
    {
        string tempmakhachhang;
        string tempmavemaybay;
        public FormTicketList(string v,string f)
        {
            InitializeComponent();
            tempmakhachhang = v;
            tempmavemaybay = f;
        }
        public string TextBoxValue { get; set; }

        ModelQLBVMB context = new ModelQLBVMB();



        private void ThayDoiVe_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            var listdvmb = context.datvemaybays.ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in listdvmb)
            {
                int indexRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[indexRow].Cells[1].Value = item.Mã_chuyến_bay;
                dataGridView1.Rows[indexRow].Cells[2].Value = item.Nơi_khởi_hành;
                dataGridView1.Rows[indexRow].Cells[3].Value = item.Nơi_đến;
                dataGridView1.Rows[indexRow].Cells[4].Value = item.Thời_gian_khởi_hành;
                dataGridView1.Rows[indexRow].Cells[5].Value = item.Thời_gian_đến;
                dataGridView1.Rows[indexRow].Cells[6].Value = item.Ngày_đi.Day + "/" + item.Ngày_đi.Month + "/" + item.Ngày_đi.Year;
                if (item.Ngày_về != null)
                {
                    dataGridView1.Rows[indexRow].Cells[7].Value = item.Ngày_về.Value.Day + "/" + item.Ngày_về.Value.Month + "/" + item.Ngày_về.Value.Year;
                }
                dataGridView1.Rows[indexRow].Cells[8].Value = item.Hạng_vé;
                dataGridView1.Rows[indexRow].Cells[9].Value = item.Kiểu_vé;
                dataGridView1.Rows[indexRow].Cells[10].Value = item.Máy_bay;
                dataGridView1.Rows[indexRow].Cells[11].Value = Convert.ToDecimal(item.Giá);
            }
        }


        private void btnChon_Click(object sender, EventArgs e)
        {
            string tempmachuyenbay = string.Empty;
            var listve = context.danhsachves.ToList();
            bool anyCheckboxSelected = false;



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    tempmachuyenbay = row.Cells[1].Value.ToString();
                    anyCheckboxSelected = true;
                    break;
                }

            }


            if (anyCheckboxSelected)
            {
                var changelist = context.danhsachves.FirstOrDefault(x => x.Mã_vé_chuyến_bay == tempmavemaybay);
                changelist.TinhTrang = "C";
                var listdanhsachve = context.danhsachves.ToList();
                var danhsachve = new danhsachve();
                danhsachve.Mã_vé_chuyến_bay = "VMB" + (listdanhsachve.Count + 1).ToString("D4");
                danhsachve.Mã_chuyến_bay = tempmachuyenbay;
                danhsachve.Mã_khách_hàng = tempmakhachhang;
                context.danhsachves.Add(danhsachve);
                context.SaveChanges();
                FormChangeTicket formChangeTicket = new FormChangeTicket(tempmakhachhang,true);
                formChangeTicket.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn chuyến bay cần đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
