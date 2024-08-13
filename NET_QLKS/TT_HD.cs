using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class TT_HD : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable HD = new DataTable();
        public TT_HD()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            HD = new DataTable();
            HD.Columns.Add("Mã hóa đơn");
            HD.Columns.Add("Mã đặt phòng");
            HD.Columns.Add("Mã nhân viên");
            HD.Columns.Add("Ngày lập");
            HD.Columns.Add("Thành tiền");
            var listHD = DB.HOADONs.Where(x=>x.THANHTIEN != null).ToList();
            foreach (var item in listHD)
            {
                HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV,item.NGAYLAP.Value.ToString("dd/MM/yyyy"),item.THANHTIEN);
            }
            DT_DS_HD.DataSource = HD;
            DT_DS_HD.AllowUserToAddRows = false;
            DT_DS_HD.ReadOnly = true;
        }
        private void TT_HD_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TEXT_MAHOADON.DataBindings.Clear();
            TEXT_MAHOADON.DataBindings.Add("Text",HD,"Mã hóa đơn");
        }

        private void FindHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindHD.Text.Trim() != "")
                {
                    int IDHD = Convert.ToInt32(FindHD.Text.Trim().ToString());
                    HD = new DataTable();
                    HD.Columns.Add("Mã hóa đơn");
                    HD.Columns.Add("Mã đặt phòng");
                    HD.Columns.Add("Mã nhân viên");
                    HD.Columns.Add("Ngày lập");
                    HD.Columns.Add("Thành tiền");
                    //var find = DB.HOADONs.Where(x => x.MAHD.ToString().Contains(IDHD) && x.THANHTIEN != null).ToList();
                    var find = DB.FUNC_FINDHDYED(IDHD);
                    foreach (var item in find)
                    {
                        HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                    }
                    DT_DS_HD.DataSource = HD;
                    DT_DS_HD.AllowUserToAddRows = false;
                    DT_DS_HD.ReadOnly = true;
                }
                else
                {
                    LoadHD();
                }
            }
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(HD);
            HD.Show();
        }

        private void CHECK_KH_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_NGAY_Click(object sender, EventArgs e)
        {
            CHECK_KH.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_PDP_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_KH.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void CHECK_PHONG_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_NV.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_KH.Checked = false;
        }

        private void CHECK_NV_Click(object sender, EventArgs e)
        {
            CHECK_NGAY.Checked = false;
            CHECK_KH.Checked = false;
            CHECK_PDP.Checked = false;
            CHECK_PHONG.Checked = false;
        }

        private void BTN_TIMKIEM_Click(object sender, EventArgs e)
        {
            if(CHECK_PHONG.Checked != true && CHECK_NV.Checked != true && CHECK_PDP.Checked != true && CHECK_NGAY.Checked != true && CHECK_KH.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn mục cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CHECK_KH.Checked == true)
                {
                    if (TEXT_MAKH.Text.Trim() != "")
                    {
                        string CCCD = TEXT_MAKH.Text.ToString().Trim();
                        var find = DB.HOADONs.Where(x => x.PHIEUDATPHONG.KHACHes.Any(y => y.CCCD.Contains(CCCD))).ToList();
                        HD = new DataTable();
                        HD.Columns.Add("Mã hóa đơn");
                        HD.Columns.Add("Mã đặt phòng");
                        HD.Columns.Add("Mã nhân viên");
                        HD.Columns.Add("Ngày lập");
                        HD.Columns.Add("Thành tiền");
                        foreach (var item in find)
                        {
                            HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                        }
                        DT_DS_HD.DataSource = HD;
                        DT_DS_HD.AllowUserToAddRows = false;
                        DT_DS_HD.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CHECK_NGAY.Checked == true)
                {

                    DateTime ngayLap = DATE_NGAYLAP.Value.Date;
                    var find = DB.HOADONs.Where(x => x.NGAYLAP == ngayLap).ToList();
                    HD = new DataTable();
                    HD.Columns.Add("Mã hóa đơn");
                    HD.Columns.Add("Mã đặt phòng");
                    HD.Columns.Add("Mã nhân viên");
                    HD.Columns.Add("Ngày lập");
                    HD.Columns.Add("Thành tiền");
                    foreach (var item in find)
                    {
                        HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                    }
                    DT_DS_HD.DataSource = HD;
                    DT_DS_HD.AllowUserToAddRows = false;
                    DT_DS_HD.ReadOnly = true;
                }
                else if (CHECK_PDP.Checked == true)
                {
                    if (TEXT_PDP.Text.Trim() != "")
                    {
                        string IPDP = TEXT_PDP.Text.ToString();
                        var find = DB.HOADONs.Where(x => x.PHIEUDATPHONG.MAPDP.ToString().Contains(IPDP)).ToList();
                        HD = new DataTable();
                        HD.Columns.Add("Mã hóa đơn");
                        HD.Columns.Add("Mã đặt phòng");
                        HD.Columns.Add("Mã nhân viên");
                        HD.Columns.Add("Ngày lập");
                        HD.Columns.Add("Thành tiền");
                        foreach (var item in find)
                        {
                            HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                        }
                        DT_DS_HD.DataSource = HD;
                        DT_DS_HD.AllowUserToAddRows = false;
                        DT_DS_HD.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CHECK_PHONG.Checked == true)
                {

                    if (TEXT_PH.Text.Trim() != "")
                    {
                        HD = new DataTable();
                        HD.Columns.Add("Mã hóa đơn");
                        HD.Columns.Add("Mã đặt phòng");
                        HD.Columns.Add("Mã nhân viên");
                        HD.Columns.Add("Ngày lập");
                        HD.Columns.Add("Thành tiền");
                        string tenPhong = TEXT_PH.Text.ToString();
                        var listPDP = DB.HOADONs.Where(x => x.PHIEUDATPHONG.PHONG.TENPHONG.Equals(tenPhong)).ToList();
                        foreach (var item in listPDP)
                        {
                            HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                        }
                        DT_DS_HD.DataSource = HD;
                        DT_DS_HD.AllowUserToAddRows = false;
                        DT_DS_HD.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CHECK_NV.Checked == true)
                {
                    if (TEXT_NV.Text.Trim() != "")
                    {
                        string IPNV = TEXT_NV.Text.ToString();
                        var find = DB.HOADONs.Where(x => x.NHANVIEN.TENNV.ToString().Contains(IPNV)).ToList();
                        HD = new DataTable();
                        HD.Columns.Add("Mã hóa đơn");
                        HD.Columns.Add("Mã đặt phòng");
                        HD.Columns.Add("Mã nhân viên");
                        HD.Columns.Add("Ngày lập");
                        HD.Columns.Add("Thành tiền");
                        foreach (var item in find)
                        {
                            HD.Rows.Add(item.MAHD, item.MAPDP, item.MANV, item.NGAYLAP.Value.ToString("dd/MM/yyyy"), item.THANHTIEN);
                        }
                        DT_DS_HD.DataSource = HD;
                        DT_DS_HD.AllowUserToAddRows = false;
                        DT_DS_HD.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }    
        }

        private void BTN_XEMCHITIET_Click(object sender, EventArgs e)
        {
            if(TEXT_MAHOADON.Text.Trim() != "")
            {
                TC_HD tuyChinh = new TC_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                tuyChinh.MAHD = TEXT_MAHOADON.Text.ToString();
                this.Controls.Clear();
                this.Controls.Add(tuyChinh);
                tuyChinh.Show();
            }   
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
