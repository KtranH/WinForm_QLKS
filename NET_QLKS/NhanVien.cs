using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NET_QLKS
{
    public partial class NhanVien : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable NV = new DataTable(); 
        public NhanVien()
        {
            InitializeComponent();
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_TENNV.DataBindings.Clear();
            TEXT_TENTKNV.DataBindings.Clear();
            TEXT_DC.DataBindings.Clear();
            TEXT_EMAIL.DataBindings.Clear();    
            TEXT_MK.DataBindings.Clear();
            TEXT_NGSINH.DataBindings.Clear();
            TEXT_QUE.DataBindings.Clear();
            TEXT_SDT.DataBindings.Clear();
            TEXT_TENNV.DataBindings.Add("Text",dt,"Tên nhân viên");
            TEXT_TENTKNV.DataBindings.Add("Text", dt, "Tên tài khoản");
            TEXT_DC.DataBindings.Add("Text", dt, "Địa chỉ");
            TEXT_EMAIL.DataBindings.Add("Text", dt, "Email");
            TEXT_MK.DataBindings.Add("Text", dt, "Mật khẩu");
            TEXT_NGSINH.DataBindings.Add("Text", dt, "Ngày sinh");
            TEXT_QUE.DataBindings.Add("Text", dt, "Quê quán");
            TEXT_SDT.DataBindings.Add("Text", dt, "Số điện thoại");
        }
        public void LoadNV()
        {
            NV = new DataTable();
            NV.Columns.Add("Mã nhân viên");
            NV.Columns.Add("Tên nhân viên");
            NV.Columns.Add("Tên tài khoản");
            NV.Columns.Add("Mật khẩu");
            NV.Columns.Add("Ngày sinh");
            NV.Columns.Add("Quê quán");
            NV.Columns.Add("Số điện thoại");
            NV.Columns.Add("Email");
            NV.Columns.Add("Địa chỉ");
            var listNV = DB.NHANVIENs.ToList();
            foreach (var item in listNV)
            {
                NV.Rows.Add(item.MANV,item.TENNV,item.TENTK,item.PASSNV,item.NGAYSINH.Value.ToString("dd/MM/yyyy"),item.QUEQUAN,item.SDT,item.EMAIL,item.DIACHI);
            }
            DT_DS_NV.DataSource = NV;
            DT_DS_NV.AllowUserToAddRows = false;
            DT_DS_NV.ReadOnly = true;
        }    
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void DT_DS_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(NV);
        }

        private void BTN_THEMNV_Click(object sender, EventArgs e)
        {
            DT_DS_NV.AllowUserToAddRows = true;
            DT_DS_NV.ReadOnly = false;
            for(int i = 0;i < DT_DS_NV.RowCount - 1;i++)
            {
                DT_DS_NV.Rows[i].ReadOnly = true;
            }    
            DT_DS_NV.FirstDisplayedScrollingRowIndex = DT_DS_NV.Rows.Count - 1;
            DT_DS_NV.Columns[0].ReadOnly = true;
        }

        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            TEXT_DC.Enabled = true;
            TEXT_EMAIL.Enabled = true;
            TEXT_MK.Enabled = true;
            TEXT_NGSINH.Enabled = true;
            TEXT_QUE.Enabled = true;
            TEXT_SDT.Enabled = true;
            TEXT_TENNV.Enabled = true;
            TEXT_TENTKNV.Enabled = true;
        }

        private void FindNV_Click(object sender, EventArgs e)
        {
            FindNV.Clear();
        }

        private void FindNV_Leave(object sender, EventArgs e)
        {
            if(FindNV.Text.Trim() == "")
            {
                FindNV.Text = "Tìm kiếm nhân viên";
            }    
        }

        private void FindNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindNV.Text.Trim() != "")
                {
                    string tenNV = FindNV.Text.Trim();
                    tenNV = tenNV.ToLower();
                    NV = new DataTable();
                    NV.Columns.Add("Mã nhân viên");
                    NV.Columns.Add("Tên nhân viên");
                    NV.Columns.Add("Tên tài khoản");
                    NV.Columns.Add("Mật khẩu");
                    NV.Columns.Add("Ngày sinh");
                    NV.Columns.Add("Quê quán");
                    NV.Columns.Add("Số điện thoại");
                    NV.Columns.Add("Email");
                    NV.Columns.Add("Địa chỉ");
                    var parameters = new SqlParameter("@TENNV", SqlDbType.NVarChar, 50)
                    {
                        Value = tenNV
                    };
                    var find = DB.PROC_FINDNV(tenNV);
                    //var find = DB.NHANVIENs.Where(x => x.TENNV.ToLower().Contains(tenNV)).ToList();
                    foreach (var item in find)
                    {
                        NV.Rows.Add(item.MANV, item.TENNV, item.TENTK, item.PASSNV, item.NGAYSINH.Value.ToString("dd/MM/yyyy"), item.QUEQUAN, item.SDT, item.EMAIL, item.DIACHI);
                    }
                    DT_DS_NV.DataSource = NV;
                    DT_DS_NV.ReadOnly = true;
                    DT_DS_NV.Refresh();
                }
                else
                {
                    LoadNV();
                }
            }
        }

        private void BTN_SAVENV_Click(object sender, EventArgs e)
        {
            TEXT_DC.Enabled = false;
            TEXT_EMAIL.Enabled = false;
            TEXT_MK.Enabled = false;
            TEXT_NGSINH.Enabled = false;
            TEXT_QUE.Enabled = false;
            TEXT_SDT.Enabled = false;
            TEXT_TENNV.Enabled = false;
            TEXT_TENTKNV.Enabled = false;
            DT_DS_NV.AllowUserToAddRows = false;
            DT_DS_NV.ReadOnly = true;
            int check = 0;
            foreach(DataGridViewRow row in DT_DS_NV.Rows)
            {
                if (!row.IsNewRow)
                {
                    string checkAddNV = row.Cells[0].Value.ToString().Trim();
                    if (checkAddNV == "")
                    {
                        try
                        {
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            var newNV = new NHANVIEN();
                            newNV.TENNV = row.Cells[1].Value.ToString().Trim();
                            newNV.TENTK = row.Cells[2].Value.ToString().Trim();
                            newNV.MANHOMPQ = 2;
                            newNV.PASSNV = row.Cells[3].Value.ToString().Trim();
                            string ngaySinhString = row.Cells[4].Value.ToString();
                            DateTime ngaySinh = DateTime.ParseExact(ngaySinhString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            TimeSpan tuoi = DateTime.Now - ngaySinh;
                            int checkTuoi = (int)tuoi.TotalDays / 365;
                            if(checkTuoi < 18)
                            {
                                check = 1;
                                MessageBox.Show("Tuổi nhân viên không thể nhỏ hơn 18", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }    
                           else
                            {
                                newNV.NGAYSINH = ngaySinh;
                                newNV.QUEQUAN = row.Cells[5].Value.ToString().Trim();
                                newNV.SDT = row.Cells[6].Value.ToString().Trim();
                                newNV.EMAIL = row.Cells[7].Value.ToString().Trim();
                                newNV.DIACHI = row.Cells[8].Value.ToString().Trim();
                                DB.NHANVIENs.Add(newNV);
                                DB.SaveChanges();
                            }    
                        }
                        catch
                        {
                            check = 1;
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        try
                        {
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            int IDNV = Convert.ToInt32(row.Cells[0].Value.ToString().Trim());
                            var upNV = DB.NHANVIENs.FirstOrDefault(x => x.MANV.Equals(IDNV));
                            upNV.TENNV = row.Cells[1].Value.ToString().Trim();
                            upNV.TENTK = row.Cells[2].Value.ToString().Trim();
                            upNV.PASSNV = row.Cells[3].Value.ToString().Trim();
                            string ngaySinhString = row.Cells[4].Value.ToString();
                            DateTime ngaySinh = DateTime.ParseExact(ngaySinhString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            TimeSpan tuoi = DateTime.Now - ngaySinh;
                            int checkTuoi = (int)tuoi.TotalDays / 365;
                            if (checkTuoi < 18)
                            {
                                check = 1;
                                MessageBox.Show("Tuổi nhân viên không thể nhỏ hơn 18", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                upNV.NGAYSINH = ngaySinh;
                                upNV.QUEQUAN = row.Cells[5].Value.ToString().Trim();
                                upNV.SDT = row.Cells[6].Value.ToString().Trim();
                                upNV.EMAIL = row.Cells[7].Value.ToString().Trim();
                                upNV.DIACHI = row.Cells[8].Value.ToString().Trim();
                                DB.Entry(upNV).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                            }
                        }
                        catch
                        {
                            check = 1;
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }    
            if(check == 0)
            {
                LoadNV();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TEXT_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }
    }
}
