using NET_QLKS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_QLKS
{
    public partial class TC_HD : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable DV = new DataTable(); 
        public string MAHD { get; set; }
        double tongTienDv = 0;
        public TC_HD()
        {
            InitializeComponent();
        }
        public void ListTienDV()
        {
            tongTienDv = 0;
            foreach (DataGridViewRow row in DT_DS_DV.Rows)
            {
                double gia = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                tongTienDv = tongTienDv + gia;
            }
        }
        public void LoadInformation()
        {
            try
            {
                var hoadon = DB.HOADONs.FirstOrDefault(x => x.MAHD.ToString().Equals(MAHD));
                TEXT_MAHD.Text = hoadon.MAHD.ToString();
                TEXT_MAPDP.Text = hoadon.MAPDP.ToString();
                TEXT_TENPH.Text = hoadon.PHIEUDATPHONG.PHONG.TENPHONG.ToString();
                TEXT_GIATHUE.Text = hoadon.PHIEUDATPHONG.PHONG.GIATHUE.ToString();
                TEXT_NGAYLAP.Text = hoadon.NGAYLAP.Value.ToString("dd/MM/yyyy");
                DateTime NGTHUE = hoadon.PHIEUDATPHONG.NGAYDAT.Value;
                DateTime NGTRA = hoadon.NGAYLAP.Value;
                TimeSpan timeSpan = NGTRA - NGTHUE;
                int khoangCachNgay = timeSpan.Days + 1;
                TEXT_SONGAYTHUE.Text = khoangCachNgay.ToString();
                TEXT_TIENDV.Text = tongTienDv.ToString();
                int soNgayThue = Convert.ToInt32(TEXT_SONGAYTHUE.Text.ToString());
                double tienNgayThue = (double)soNgayThue * hoadon.PHIEUDATPHONG.PHONG.GIATHUE.Value;
                double tongTienThanhToan = tienNgayThue + double.Parse(TEXT_TIENDV.Text.ToString());
                TEXT_THANHTIEN.Text = tongTienThanhToan.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDV()
        {
            DV = new DataTable();
            DV.Columns.Add("Tên dịch vụ");
            DV.Columns.Add("Số lượng");
            DV.Columns.Add("Giá dịch vụ");
            //var listDV = DB.CT_HOADON.Where(x=>x.MAHD.ToString().Equals(MAHD)).ToList();
            int IDDV = Convert.ToInt32(MAHD.ToString());
            var listDV = DB.FUNC_DVPH(IDDV);
            foreach ( var item in listDV )
            {
                DV.Rows.Add(item.TENDV,item.SOLUONG,item.GIADV);
            }
            DT_DS_DV.DataSource = DV;
            DT_DS_DV.AllowUserToAddRows = false;
            DT_DS_DV.ReadOnly = true;
        }
        private void TC_HD_Load(object sender, EventArgs e)
        {
            LoadDV();
            ListTienDV();
            LoadInformation();
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(HD);
            HD.Show();
        }
    }
}
