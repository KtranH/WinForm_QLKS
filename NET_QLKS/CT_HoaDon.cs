using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class CT_HoaDon : Form
    {
        NET_QLKS1Entities DB =  new NET_QLKS1Entities();
        DataTable dvph = new DataTable();
        public string UserCurrentCT_HD { get;set; }
        double tongTienDv = 0;
        public string MaHD { get; set; }
        public CT_HoaDon()
        {
            InitializeComponent();
        }
        public void ListTienDV()
        {
            tongTienDv = 0;
            foreach(DataGridViewRow row in DT_DS_DV.Rows)
            {
                double gia = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                tongTienDv = tongTienDv + gia;
            }    
        }
        public void LoadInformation()
        {
            int IDHD = Convert.ToInt32(MaHD);
            var hoadon = DB.HOADONs.FirstOrDefault(x => x.MAHD.Equals(IDHD));
            TEXT_MAHD.Text = hoadon.MAHD.ToString();
            TEXT_MAPDP.Text = hoadon.MAPDP.ToString();
            TEXT_TENPH.Text = hoadon.PHIEUDATPHONG.PHONG.TENPHONG.ToString();
            TEXT_GIATHUE.Text = hoadon.PHIEUDATPHONG.PHONG.GIATHUE.ToString();
            TEXT_NGAYLAP.Text = DateTime.Now.ToShortDateString();
            DateTime NGTHUE = hoadon.PHIEUDATPHONG.NGAYDAT.Value;
            DateTime NGTRA = DateTime.Parse(TEXT_NGAYLAP.Text);
            TimeSpan timeSpan = NGTRA - NGTHUE;
            int khoangCachNgay = timeSpan.Days + 1;
            TEXT_SONGAYTHUE.Text = khoangCachNgay.ToString();
            TEXT_TIENDV.Text = tongTienDv.ToString();
            int soNgayThue = Convert.ToInt32(TEXT_SONGAYTHUE.Text.ToString());
            double tienNgayThue = (double)soNgayThue * hoadon.PHIEUDATPHONG.PHONG.GIATHUE.Value;
            double tongTienThanhToan = tienNgayThue + double.Parse(TEXT_TIENDV.Text.ToString());
            TEXT_THANHTIEN.Text = tongTienThanhToan.ToString();
        }
        public void ConnectionControl(DataTable dt)
        {
            OP_DV.DataBindings.Clear();
            TEXT_SOLUONG.DataBindings.Clear();
            OP_DV.DataBindings.Add("Text",dt, "Tên dịch vụ");
            TEXT_SOLUONG.DataBindings.Add("Text",dt,"Số lượng");
        }
        public void LoadDichVuPhong()
        {
            tongTienDv = 0;
            dvph = new DataTable();
            dvph.Columns.Add("Tên dịch vụ");
            dvph.Columns.Add("Số lượng");
            dvph.Columns.Add("Giá dịch vụ");
            int IDHD = Convert.ToInt32(MaHD);
            var dv = DB.CT_HOADON.Where(x => x.MAHD.Equals(IDHD)).ToList();
            foreach (var item in dv)
            {
                double gia = item.DICHVU.GIADV.Value * item.SOLUONG.Value;
                tongTienDv = tongTienDv + gia;
                dvph.Rows.Add(item.DICHVU.TENDV, item.SOLUONG, item.DICHVU.GIADV);
            }
            DT_DS_DV.DataSource = dvph;
            DT_DS_DV.ReadOnly = true;
            DT_DS_DV.AllowUserToAddRows = false;
        }
        private void CT_HOADON_Load(object sender, EventArgs e)
        {
            var listdv = DB.DICHVUs.ToList();
            OP_DV.DataSource = listdv;
            OP_DV.DisplayMember = "TENDV";
            OP_DV.ValueMember = "MADV";
            OP_DV.SelectedIndex = 0;
            LoadDichVuPhong();
            LoadInformation();
        }

        private void DT_DS_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(dvph);
        }

        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            if (TEXT_SOLUONG.Text != "")
            {
                int check = 0;
                string nameDV = OP_DV.Text.ToString();
                var checkDV = DB.DICHVUs.FirstOrDefault(x => x.TENDV.Equals(nameDV));
                foreach (DataGridViewRow row in DT_DS_DV.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() == OP_DV.Text.ToString())
                        {
                            check = 1;
                            int soLuong = Convert.ToInt32(row.Cells[1].Value.ToString());
                            int themSL = Convert.ToInt32(TEXT_SOLUONG.Text.ToString());
                            int sum = soLuong + themSL;
                            row.Cells[1].Value = sum.ToString();
                            DT_DS_DV.Refresh();
                            ListTienDV();
                            LoadInformation();
                            break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (check == 0)
                {
                    dvph.Rows.Add(checkDV.TENDV, TEXT_SOLUONG.Text.ToString(), checkDV.GIADV);
                    DT_DS_DV.DataSource = dvph;
                    DT_DS_DV.Refresh();
                    ListTienDV();
                    LoadInformation();
                }
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }    
        }

        private void BTN_XOADV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DT_DS_DV.Rows)
            {
                if (row.Cells[0].Value.ToString() == OP_DV.Text.ToString())
                {
                    DT_DS_DV.Rows.Remove(row);
                    DT_DS_DV.Refresh();
                    ListTienDV();
                    LoadInformation();
                    break;
                }
            }
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
           try
            {
                var checkNV = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentCT_HD));
                int IDHD = Convert.ToInt32(TEXT_MAHD.Text.ToString());
                var upHD = DB.HOADONs.FirstOrDefault(x => x.MAHD.Equals(IDHD));
                upHD.MANV = null;
                DB.Entry(upHD).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ThanhToanHD.UserCurrentBill = UserCurrentCT_HD;
                this.Controls.Clear();
                this.Controls.Add(ThanhToanHD);
                ThanhToanHD.Show();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Configuration.ValidateOnSaveEnabled = false;
                int IDHD = Convert.ToInt32(TEXT_MAHD.Text.ToString());
                int IDPDP = Convert.ToInt32(TEXT_MAPDP.Text.ToString());
                foreach (DataGridViewRow row in DT_DS_DV.Rows)
                {
                    var newCT_HD = new CT_HOADON();
                    newCT_HD.MAHD = IDHD;
                    string DVTRONGHD = row.Cells[0].Value.ToString();
                    int SLDVTRONGHD = Convert.ToInt32(row.Cells[1].Value.ToString());
                    var takeDV = DB.DICHVUs.FirstOrDefault(x => x.TENDV.Equals(DVTRONGHD));
                    newCT_HD.MADV = takeDV.MADV;
                    newCT_HD.SOLUONG = SLDVTRONGHD;
                    DB.CT_HOADON.Add(newCT_HD);
                }
                var upHDTT = DB.HOADONs.FirstOrDefault(x => x.MAHD.Equals(IDHD));
                upHDTT.THANHTIEN = double.Parse(TEXT_THANHTIEN.Text.ToString());
                upHDTT.NGAYLAP = DateTime.Parse(TEXT_NGAYLAP.Text.ToString());
                DB.Entry(upHDTT).State = System.Data.Entity.EntityState.Modified;
                string namePHHT = TEXT_TENPH.Text.ToString();
                var upPHState = DB.PROC_UPSTATE_PH(namePHHT,"Đang dọn");
                //var upPHState = DB.PHONGs.FirstOrDefault(x => x.TENPHONG.Equals(namePHHT));
                //upPHState.TINHTRANG = "Đang dọn";
                //DB.Entry(upPHState).State = System.Data.Entity.EntityState.Modified;
                var upPDP = DB.PHIEUDATPHONGs.FirstOrDefault(x => x.MAPDP.Equals(IDPDP));
                upPDP.TINHTRANG = "Đã thanh toán";
                DB.Entry(upPDP).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("Xác nhận thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ThanhToanHD.UserCurrentBill = UserCurrentCT_HD;
                this.Controls.Clear();
                this.Controls.Add(ThanhToanHD);
                ThanhToanHD.Show();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
