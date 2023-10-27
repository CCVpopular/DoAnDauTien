using QLBVMB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class FormBookTickets : Form
    {
        ModelQLBVMB context;
        List<danhsachve> listdanhsachve;
        danhsachve danhsachve;
        string temp;
        string tempmakhachhang;
        int dem = 1;
        public FormBookTickets(string t)
        {
            InitializeComponent();
            context = new ModelQLBVMB();
            tempmakhachhang = t;
        }
        private void FillDepaturePlaceCombobox()
        {
            var uniqueData = context.datvemaybays.Select(x => x.Nơi_khởi_hành).Distinct().ToList();
            cmb1.Items.Add("");
            foreach (var item in uniqueData)
            {
                cmb1.Items.Add(item);
            }
        }
        private void FillTypeofTicketCombobox()
        {
            var uniqueData = context.datvemaybays.Select(x => x.Hạng_vé).Distinct().ToList();
            cmb3.DataSource = uniqueData;
        }
        private void Datvemaybay_Load(object sender, EventArgs e)
        {
            FillDepaturePlaceCombobox();
            FillTypeofTicketCombobox();
            BindGrid();
        }
        private void BindGrid()
        {
            var listdvmb = context.datvemaybays.ToList();
            dgvmaybay.Rows.Clear();
            foreach (var item in listdvmb)
            {
                int indexRow = dgvmaybay.Rows.Add();
                dgvmaybay.Rows[indexRow].Cells[0].Value = item.Mã_chuyến_bay;
                dgvmaybay.Rows[indexRow].Cells[1].Value = item.Nơi_khởi_hành;
                dgvmaybay.Rows[indexRow].Cells[2].Value = item.Nơi_đến;
                dgvmaybay.Rows[indexRow].Cells[3].Value = item.Thời_gian_khởi_hành;
                dgvmaybay.Rows[indexRow].Cells[4].Value = item.Thời_gian_đến;
                dgvmaybay.Rows[indexRow].Cells[5].Value = item.Ngày_đi.Day + "/" + item.Ngày_đi.Month + "/" + item.Ngày_đi.Year;
                if (item.Ngày_về != null)
                {
                    dgvmaybay.Rows[indexRow].Cells[6].Value = item.Ngày_về.Value.Day + "/" + item.Ngày_về.Value.Month + "/" + item.Ngày_về.Value.Year;
                }
                dgvmaybay.Rows[indexRow].Cells[7].Value = item.Hạng_vé;
                dgvmaybay.Rows[indexRow].Cells[8].Value = item.Kiểu_vé;
                dgvmaybay.Rows[indexRow].Cells[9].Value = item.Máy_bay;
                dgvmaybay.Rows[indexRow].Cells[10].Value = Decimal.Parse(item.Giá.ToString());
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //quanlydatcho quanlydatcho = new quanlydatcho();
            //quanlydatcho.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false || cmb1.Text == "" || cmb2.Text == "" || cmb3.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                string loaivetemp = radioButton1.Checked == true ? "Một chiều" : "Khứ hồi";
                var listvemaybay = context.datvemaybays.ToList();
                dgvmaybay.Rows.Clear();
                for (int i = 0; i < listvemaybay.Count; i++)
                {
                    if (radioButton1.Checked == true)
                    {
                        if (cmb1.Text == listvemaybay[i].Nơi_khởi_hành && cmb2.Text == listvemaybay[i].Nơi_đến && loaivetemp == listvemaybay[i].Kiểu_vé && dateTimePicker1.Value.Date <= listvemaybay[i].Ngày_đi.Date)
                        {
                            int indexRow = dgvmaybay.Rows.Add();
                            dgvmaybay.Rows[indexRow].Cells[0].Value = listvemaybay[i].Mã_chuyến_bay;
                            dgvmaybay.Rows[indexRow].Cells[1].Value = listvemaybay[i].Nơi_khởi_hành;
                            dgvmaybay.Rows[indexRow].Cells[2].Value = listvemaybay[i].Nơi_đến;
                            dgvmaybay.Rows[indexRow].Cells[3].Value = listvemaybay[i].Thời_gian_khởi_hành;
                            dgvmaybay.Rows[indexRow].Cells[4].Value = listvemaybay[i].Thời_gian_đến;
                            dgvmaybay.Rows[indexRow].Cells[5].Value = listvemaybay[i].Ngày_đi.Day + "/" + listvemaybay[i].Ngày_đi.Month + "/" + listvemaybay[i].Ngày_đi.Year;
                            if (listvemaybay[i].Ngày_về != null)
                            {
                                dgvmaybay.Rows[indexRow].Cells[6].Value = listvemaybay[i].Ngày_về.Value.Day + "/" + listvemaybay[i].Ngày_về.Value.Month + "/" + listvemaybay[i].Ngày_về.Value.Year;
                            }
                            dgvmaybay.Rows[indexRow].Cells[7].Value = listvemaybay[i].Hạng_vé;
                            dgvmaybay.Rows[indexRow].Cells[8].Value = listvemaybay[i].Kiểu_vé;
                            dgvmaybay.Rows[indexRow].Cells[9].Value = listvemaybay[i].Máy_bay;
                            dgvmaybay.Rows[indexRow].Cells[10].Value = Decimal.Parse(listvemaybay[i].Giá.ToString());
                        }
                    }
                    else
                    {
                        if (cmb1.Text == listvemaybay[i].Nơi_khởi_hành && cmb2.Text == listvemaybay[i].Nơi_đến && loaivetemp == listvemaybay[i].Kiểu_vé && dateTimePicker1.Value.Date <= listvemaybay[i].Ngày_đi.Date && dateTimePicker2.Value.Date >= listvemaybay[i].Ngày_về.Value.Date)
                        {
                            int indexRow = dgvmaybay.Rows.Add();
                            dgvmaybay.Rows[indexRow].Cells[0].Value = listvemaybay[i].Mã_chuyến_bay;
                            dgvmaybay.Rows[indexRow].Cells[1].Value = listvemaybay[i].Nơi_khởi_hành;
                            dgvmaybay.Rows[indexRow].Cells[2].Value = listvemaybay[i].Nơi_đến;
                            dgvmaybay.Rows[indexRow].Cells[3].Value = listvemaybay[i].Thời_gian_khởi_hành;
                            dgvmaybay.Rows[indexRow].Cells[4].Value = listvemaybay[i].Thời_gian_đến;
                            dgvmaybay.Rows[indexRow].Cells[5].Value = listvemaybay[i].Ngày_đi.Day + "/" + listvemaybay[i].Ngày_đi.Month + "/" + listvemaybay[i].Ngày_đi.Year;
                            if (listvemaybay[i].Ngày_về != null)
                            {
                                dgvmaybay.Rows[indexRow].Cells[6].Value = listvemaybay[i].Ngày_về.Value.Day + "/" + listvemaybay[i].Ngày_về.Value.Month + "/" + listvemaybay[i].Ngày_về.Value.Year;
                            }
                            dgvmaybay.Rows[indexRow].Cells[7].Value = listvemaybay[i].Hạng_vé;
                            dgvmaybay.Rows[indexRow].Cells[8].Value = listvemaybay[i].Kiểu_vé;
                            dgvmaybay.Rows[indexRow].Cells[9].Value = listvemaybay[i].Máy_bay;
                            dgvmaybay.Rows[indexRow].Cells[10].Value = Decimal.Parse(listvemaybay[i].Giá.ToString());
                        }
                    }
                }

                temp = null;
            }
            catch (Exception ex)
            {
                BindGrid();
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb2.Items.Clear();
            cmb2.Text = string.Empty;
            var uniqueData = context.datvemaybays.Select(x => x.Nơi_đến).Distinct().ToList();
            foreach (var item in uniqueData)
            {
                if (item != cmb1.Text)
                {
                    cmb2.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(temp == null || temp == "")
                {
                    throw new Exception("Vui lòng chọn vé trong danh sách");
                }
                danhsachve = new danhsachve();
                listdanhsachve = context.danhsachves.ToList();
                danhsachve.Mã_vé_chuyến_bay = "VMB" + (listdanhsachve.Count + dem).ToString("D4");
                danhsachve.Mã_chuyến_bay = temp;
                danhsachve.Mã_khách_hàng = tempmakhachhang;
                context.danhsachves.Add(danhsachve);
                textBox1.Text = dem++.ToString();
                cmb1.Text = "";
                cmb2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                cmb3.SelectedIndex = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label5.Visible = false;
                dateTimePicker2.Visible = false;
                BindGrid();
                MessageBox.Show("Lưu vé thành công");
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using ( var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    if(danhsachve == null)
                    {
                        throw new Exception("Vui lòng lưu vé trước khi thanh toán");
                    }
                    context.SaveChanges();
                    transaction.Commit();
                    danhsachve = null;
                    dem = 1;
                    textBox1.Text = "";
                    FormPayment formPayment = new FormPayment(tempmakhachhang);
                    formPayment.Show();
                    this.Close();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void dgvmaybay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvmaybay.SelectedRows.Count <= 0)
                {
                    dgvmaybay.CurrentRow.Selected = true;
                    temp = dgvmaybay.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            dateTimePicker2.Visible = true;
        }
    }
}
