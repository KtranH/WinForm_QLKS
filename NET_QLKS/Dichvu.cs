using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class Dichvu : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable dv = new DataTable();
        public string UserCurrentDV { get; set; }
        public Dichvu()
        {
            InitializeComponent();
        }
        public void LockControl()
        {
            TEXT_GIADV.Enabled = false;
            TEXT_TENDV.Enabled = false;
        }
        public void LoadDV()
        {
            dv = new DataTable();
            dv.Columns.Add("Mã dịch vụ");
            dv.Columns.Add("Tên dịch vụ");
            dv.Columns.Add("Giá dịch vụ");
            var dichVu = DB.DICHVUs.ToList();
            foreach(var item in dichVu)
            {
                dv.Rows.Add(item.MADV,item.TENDV,item.GIADV);  
            }
            DT_DS_DV.DataSource = dv;
            DT_DS_DV.ReadOnly = true;
            DT_DS_DV.AllowUserToAddRows = false;
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentDV));
            if(USER.NHOMQUYEN.PHANQUYEN.CHUCNANG == "Admin")
            {
                BTN_SAVEDV.Enabled = true;
                BTN_THEMDV.Enabled = true;
                BTN_UPDATEDV.Enabled = true;
            }    
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_TENDV.DataBindings.Clear();
            TEXT_GIADV.DataBindings.Clear();
            MADV.DataBindings.Clear();
            TEXT_TENDV.DataBindings.Add("Text",dt,"Tên dịch vụ");
            TEXT_GIADV.DataBindings.Add("Text",dt,"Giá dịch vụ");
            MADV.DataBindings.Add("Text", dt, "Mã dịch vụ");
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            LoadDV();
            LockControl();
        }

        private void FindDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindDV.Text.Trim() != "")
                {
                    string tenDV = FindDV.Text.Trim();
                    tenDV = tenDV.ToLower();
                    dv = new DataTable();
                    dv.Columns.Add("Mã dịch vụ");
                    dv.Columns.Add("Tên dịch vụ");
                    dv.Columns.Add("Giá dịch vụ");
                    //var find = DB.DICHVUs.Where(x => x.TENDV.ToLower().Contains(tenDV)).ToList();
                    var find = DB.PROC_FINDDV(tenDV);
                    foreach (var item in find)
                    {
                        dv.Rows.Add(item.MADV, item.TENDV, item.GIADV);
                    }
                    DT_DS_DV.DataSource = dv;
                    DT_DS_DV.ReadOnly = true;
                    DT_DS_DV.AllowUserToAddRows = false;
                    DT_DS_DV.Refresh();
                }
                else
                {
                    LoadDV();
                }
            }
        }

        private void FindDV_Click(object sender, EventArgs e)
        {
            FindDV.Clear();
        }

        private void FindDV_Leave(object sender, EventArgs e)
        {
            if(FindDV.Text.Trim() == "")
            {
                FindDV.Text = "Tìm kiếm dịch vụ";
            }    
        }

        private void DT_DS_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(dv);
        }

        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            DT_DS_DV.AllowUserToAddRows = true;
            DT_DS_DV.ReadOnly = false;
            for (int i = 0; i < DT_DS_DV.RowCount - 1; i++)
            {
                DT_DS_DV.Rows[i].ReadOnly = true;
            }
            DT_DS_DV.Columns[0].ReadOnly = true;
            DT_DS_DV.FirstDisplayedScrollingRowIndex = DT_DS_DV.Rows.Count - 1;
        }

        private void BTN_UPDATEDV_Click(object sender, EventArgs e)
        {
            TEXT_TENDV.Enabled = true;
            TEXT_GIADV.Enabled = true;
            if (MADV.Text.Trim() != "" && TEXT_TENDV.Text.Trim() != "" && TEXT_GIADV.Text.Trim() != "")
            {
                string IDDV = MADV.Text.Trim();
                foreach (DataGridViewRow row in DT_DS_DV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value.ToString().Trim().Equals(IDDV))
                        {
                            row.Cells[1].Value = TEXT_TENDV.Text.Trim();
                            row.Cells[2].Value = TEXT_GIADV.Text.Trim();
                        }
                    }
                }
                DT_DS_DV.Refresh();
            }
        }
        private void BTN_SAVEDV_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in DT_DS_DV.Rows)
            {
                if (!row.IsNewRow)
                {
                    string tenDV = row.Cells[1].Value.ToString().Trim();
                    string checkDV = row.Cells[0].Value.ToString().Trim();
                    if (checkDV == "")
                    {
                        try
                        {
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            double GIADV = double.Parse(row.Cells[2].Value.ToString().Trim());
                            var newDV = DB.PROC_THEMDV(tenDV, GIADV);
                            //var newDV = new DICHVU();
                            //newDV.TENDV = tenDV;
                            //newDV.GIADV = double.Parse(row.Cells[2].Value.ToString().Trim());
                            //DB.DICHVUs.Add(newDV);
                            LockControl();
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
                            int checkID = Convert.ToInt32(checkDV);
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            double GIADV = double.Parse(row.Cells[2].Value.ToString().Trim());
                            var upDV = DB.PROC_UPDICHVU(checkID, tenDV, GIADV);
                            //var upDV = DB.DICHVUs.FirstOrDefault(x => x.MADV.Equals(checkID));
                            //upDV.TENDV = tenDV;
                            //upDV.GIADV = double.Parse(row.Cells[2].Value.ToString().Trim());
                            //DB.Entry(upDV).State = System.Data.Entity.EntityState.Modified;
                            LockControl();
                        }
                        catch
                        {
                            check = 1;
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadDV();
                            break;
                        }
                    }
                }
            }
            if (check == 0)
            {
                DT_DS_DV.ReadOnly = true;
                DT_DS_DV.AllowUserToAddRows = false;
                DB.SaveChanges();
                DT_DS_DV.Refresh();
                LoadDV();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TEXT_GIADV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }
    }
}
