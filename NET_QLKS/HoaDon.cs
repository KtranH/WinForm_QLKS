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
    public partial class HoaDon : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public string UserCurrentBill { get; set; }
        DataTable hd = new DataTable();
        DataTable kh =  new DataTable();
        public HoaDon()
        {
            InitializeComponent();
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_MAHD.DataBindings.Clear();
            TEXT_MAPDP.DataBindings.Clear();
            TEXT_TENPHONG.DataBindings.Clear();
            MAPDP.DataBindings.Clear();
            TEXT_MAHD.DataBindings.Add("Text", dt, "Mã hóa đơn");
            TEXT_MAPDP.DataBindings.Add("Text", dt, "Mã phiếu đặt phòng");
            MAPDP.DataBindings.Add("Text", dt, "Mã phiếu đặt phòng");
            TEXT_TENPHONG.DataBindings.Add("Text", dt, "Tên phòng");
        }
        public void LoadHoaDon()
        {
            hd = new DataTable();
            hd.Columns.Add("Mã hóa đơn");
            hd.Columns.Add("Mã phiếu đặt phòng");
            hd.Columns.Add("Tên phòng");
            hd.Columns.Add("Ngày đặt");
            var hoaDon = DB.HOADONs.Where(x=> x.THANHTIEN == null).ToList();
            foreach(var item in hoaDon)
            {
                string date = item.PHIEUDATPHONG.NGAYDAT.Value.ToShortDateString();
                hd.Rows.Add(item.MAHD,item.PHIEUDATPHONG.MAPDP,item.PHIEUDATPHONG.PHONG.TENPHONG, date);
            }    
            DT_DS_HD.DataSource = hd;
            DT_DS_HD.ReadOnly = true;
            DT_DS_HD.AllowUserToAddRows = false;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            var checkNV = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentBill));
            TEXT_NV.Text = checkNV.TENNV.ToString();    
        }

        private void FindBill_Click(object sender, EventArgs e)
        {
            FindBill.Clear();
        }

        private void FindBill_Leave(object sender, EventArgs e)
        {
            if(FindBill.Text.Trim() == "")
            {
                FindBill.Text = "Nhập CCCD của khách để tìm kiếm hóa đơn";
            }    
        }

        private void FindBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(FindBill.Text != "")
                {
                    string tenPH = FindBill.Text.Trim();
                    hd = new DataTable();
                    hd.Columns.Add("Mã hóa đơn");
                    hd.Columns.Add("Mã phiếu đặt phòng");
                    hd.Columns.Add("Tên phòng");
                    hd.Columns.Add("Ngày đặt");
                    //var find = DB.HOADONs.Where(x => x.PHIEUDATPHONG.KHACHes.Any(y => y.CCCD.Equals(tenPH)) && x.THANHTIEN == null).ToList();
                    var find = DB.FUNC_FINDHDY(tenPH);
                    foreach (var item in find)
                    {
                        string date = item.NGAYDAT.Value.ToShortDateString();
                        hd.Rows.Add(item.MAHD, item.MAPDP, item.TENPHONG, date);
                    }
                    DT_DS_HD.DataSource = hd;
                    DT_DS_HD.ReadOnly = true;
                    DT_DS_HD.AllowUserToAddRows = false;
                    DT_DS_HD.Refresh();
                }   
                else
                {
                    LoadHoaDon();
                }    
            }
        }

        private void DT_DS_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(hd);
            int IDDP;
            try
            {
                IDDP = Convert.ToInt32(MAPDP.Text.ToString().Trim());
            }
            catch
            {
                IDDP = 0;
            }
            var lisKH = DB.PHIEUDATPHONGs.FirstOrDefault(x=>x.MAPDP.Equals(IDDP));
            if (lisKH != null)
            {
                kh = new DataTable();
                kh.Columns.Add("Tên khách hàng");
                kh.Columns.Add("Số điện thoại");
                kh.Columns.Add("Căn cước công dân");
                foreach(var khach in  lisKH.KHACHes) 
                {
                    kh.Rows.Add(khach.TENKH,khach.SDT,khach.CCCD);
                }
                DT_DS_KH.DataSource = kh;
                DT_DS_KH.ReadOnly = true;
                DT_DS_KH.AllowUserToAddRows =false;
                DT_DS_KH.Refresh();
            }
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = UserCurrentBill;
            this.Controls.Clear();
            this.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }

        private void BTN_THANHTOAN_Click(object sender, EventArgs e)
        {
            try
            {
                var checkNV = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentBill));
                int IDHD = Convert.ToInt32(TEXT_MAHD.Text.ToString());
                var upHD = DB.HOADONs.FirstOrDefault(x => x.MAHD.Equals(IDHD));
                upHD.MANV = checkNV.MANV;
                DB.Entry(upHD).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                CT_HoaDon CT_ThanhToanHD = new CT_HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                CT_ThanhToanHD.MaHD = TEXT_MAHD.Text.ToString();
                CT_ThanhToanHD.UserCurrentCT_HD = UserCurrentBill;
                this.Controls.Clear();
                this.Controls.Add(CT_ThanhToanHD);
                CT_ThanhToanHD.Show();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
