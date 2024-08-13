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
    public partial class TrangChu : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public string UserCurrent { get;set; }
        public TrangChu()
        {
            InitializeComponent();
        }
        public void InformationUser()
        {
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrent));
            Title.Text = Title.Text + USER.NHOMQUYEN.PHANQUYEN.CHUCNANG + " " + USER.TENNV;
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            DB.Configuration.ValidateOnSaveEnabled = false;
            var upPDP = DB.PHIEUDATPHONGs.Where(x=>x.TINHTRANG == "Đặt trước").ToList();
            foreach(var item in upPDP)
            {
                if(item.NGAYDAT < DateTime.Today)
                {
                    item.TINHTRANG = "Đã hủy";
                    item.PHONG.TINHTRANG = "Trống";
                    DB.Entry(item).State = System.Data.Entity.EntityState.Modified; 
                }   
            }
            DB.SaveChanges();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            InformationUser();
            TrangChinh Home = new TrangChinh() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Home.UserCurrentHome = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(Home);
            guna2DateTimePicker1.Value = DateTime.Now;
            Home.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DangNhap LoginForm = new DangNhap();
            this.Hide();
            LoginForm.ShowDialog();
        }
        bool EF_PHONG_EXPAND = true;
        private void BTN_PHONG_Click(object sender, EventArgs e)
        {
            EF_PHONG.Start();
        }
        private void EF_PHONG_Tick(object sender, EventArgs e)
        {
            if (EF_PHONG_EXPAND)
            {
                PHONG.Height -= 10;
                if (PHONG.Height <= PHONG.MinimumSize.Height)
                {
                    EF_PHONG_EXPAND = false;
                    EF_PHONG.Stop();
                }
            }
            else
            {
                PHONG.Height += 10;
                if (PHONG.Height >= PHONG.MaximumSize.Height)
                {
                    EF_PHONG_EXPAND = true;
                    EF_PHONG.Stop();
                }
            }
        }

        private void CN_DSPHONG_Click(object sender, EventArgs e)
        {
            Phong OpenPhong = new Phong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenPhong.UserCurrentPH = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(OpenPhong);
            OpenPhong.Show();
        }

        private void BTN_TRANGCHU_Click(object sender, EventArgs e)
        {
            TrangChinh Home = new TrangChinh() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Home.UserCurrentHome = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(Home);
            Home.Show();
        }

        private void SlideMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CN_DSDV_Click(object sender, EventArgs e)
        {
            Dichvu dv = new Dichvu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dv.UserCurrentDV = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(dv);
            dv.Show();
        }

        private void BTN_DATPHONG_Click(object sender, EventArgs e)
        {
            EF_DATPHONG.Start();
        }
        bool EF_DATPHONG_EXPAND = true;

        private void EF_DATPHONG_Tick(object sender, EventArgs e)
        {
            if (EF_DATPHONG_EXPAND)
            {
                DATPHONG.Height -= 10;
                if (DATPHONG.Height <= DATPHONG.MinimumSize.Height)
                {
                    EF_DATPHONG_EXPAND = false;
                    EF_DATPHONG.Stop();
                }
            }
            else
            {
                DATPHONG.Height += 10;
                if (DATPHONG.Height >= DATPHONG.MaximumSize.Height)
                {
                    EF_DATPHONG_EXPAND = true;
                    EF_DATPHONG.Stop();
                }
            }
        }

        private void CN_PDPKH_Click(object sender, EventArgs e)
        {
            DatPhong datPhong = new DatPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            datPhong.UserCurrentDatPhong = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(datPhong);
            datPhong.Show();
        }

        private void CN_THANHTOAN_Click(object sender, EventArgs e)
        {
            EF_THANHTOAN.Start();
        }
        bool EF_THANHTOAN_EXPAND = true;
        private void EF_THANHTOAN_Tick(object sender, EventArgs e)
        {
            if (EF_THANHTOAN_EXPAND)
            {
                THANHTOAN.Height -= 10;
                if (THANHTOAN.Height <= THANHTOAN.MinimumSize.Height)
                {
                    EF_THANHTOAN_EXPAND = false;
                    EF_THANHTOAN.Stop();
                }
            }
            else
            {
                THANHTOAN.Height += 10;
                if (THANHTOAN.Height >= THANHTOAN.MaximumSize.Height)
                {
                    EF_THANHTOAN_EXPAND = true;
                    EF_THANHTOAN.Stop();
                }
            }
        }

        private void BTN_THANHTOANHD_Click(object sender, EventArgs e)
        {
            HoaDon ThanhToanHD = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ThanhToanHD.UserCurrentBill = UserCurrent;
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(ThanhToanHD);
            ThanhToanHD.Show();
        }
        bool EF_DANHMUC_EXPAND = true;
        private void EF_DANHMUC_Tick(object sender, EventArgs e)
        {
            if (EF_DANHMUC_EXPAND)
            {
                DANHMUC.Height -= 10;
                if (DANHMUC.Height <= DANHMUC.MinimumSize.Height)
                {
                    EF_DANHMUC_EXPAND = false;
                    EF_DANHMUC.Stop();
                }
            }
            else
            {
                DANHMUC.Height += 10;
                if (DANHMUC.Height >= DANHMUC.MaximumSize.Height)
                {
                    EF_DANHMUC_EXPAND = true;
                    EF_DANHMUC.Stop();
                }
            }
        }
        bool EF_THONGTIN_EXPAND = true;

        private void EF_THONGTIN_Tick(object sender, EventArgs e)
        {
            if (EF_THONGTIN_EXPAND)
            {
                THONGTIN.Height -= 10;
                if (THONGTIN.Height <= THONGTIN.MinimumSize.Height)
                {
                    EF_THONGTIN_EXPAND = false;
                    EF_THONGTIN.Stop();
                }
            }
            else
            {
                THONGTIN.Height += 10;
                if (THONGTIN.Height >= THONGTIN.MaximumSize.Height)
                {
                    EF_THONGTIN_EXPAND = true;
                    EF_THONGTIN.Stop();
                }
            }
        }

        private void CN_DANHMUC_Click(object sender, EventArgs e)
        {
            EF_DANHMUC.Start();
        }

        private void CN_THONGTIN_Click(object sender, EventArgs e)
        {
            EF_THONGTIN.Start();

        }

        private void BTN_NHANVIEN_Click(object sender, EventArgs e)
        {
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrent));
            if (USER.NHOMQUYEN.PHANQUYEN.CHUCNANG == "Admin")
            {
                NhanVien NV = new NhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.ConvertForm.Controls.Clear();
                this.ConvertForm.Controls.Add(NV);
                NV.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_KHACHHANG_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(KH);
            KH.Show();
        }

        private void BTN_PDP_Click(object sender, EventArgs e)
        {
            TT_PDP PDP = new TT_PDP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(PDP);
            PDP.Show();
        }

        private void BTN_HOADON_Click(object sender, EventArgs e)
        {
            TT_HD HD = new TT_HD() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.ConvertForm.Controls.Clear();
            this.ConvertForm.Controls.Add(HD);
            HD.Show();
        }
    }
}
