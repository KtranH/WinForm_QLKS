using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class TrangChinh : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public string UserCurrentHome { get; set; }

        public TrangChinh()
        {
            InitializeComponent();
        }
        public void InformationUser()
        {
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentHome));
            TenUser.Text = USER.TENNV;
            ChucVuUser.Text = USER.NHOMQUYEN.PHANQUYEN.CHUCNANG;
            NgSinhUser.Text = USER.NGAYSINH.Value.ToString("dd/MM/yyyy");
            QueQuanUser.Text = USER.QUEQUAN;
            DTUser.Text = USER.SDT;
            EmailUser.Text = USER.EMAIL;
            DiaChiUser.Text = USER.DIACHI;
        }
        public void InformationRoom()
        {
            var TONG = DB.PHONGs.Count();
            //var THUE = DB.PHONGs.Count(x => x.TINHTRANG.Equals("Đã đặt"));
            //var TRONG = DB.PHONGs.Count(x => x.TINHTRANG.Equals("Trống"));
            var TRONG = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_PHONGTRONG()").FirstOrDefault();
            var THUE = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_PHONGDAT()").FirstOrDefault();
            ChartRoom.Maximum = TONG;
            ChartRoom.Value = THUE + 1;
            SLTRONG.Text = TRONG.ToString();
            SLTHUE.Text = THUE.ToString();
        }
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            InformationUser();
            InformationRoom();
            //int datTruoc = DB.PHIEUDATPHONGs.Count(x=>x.TINHTRANG.Equals("Đặt trước"));
            //int daXacNhan = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã xác nhận"));
            //int daThanhToan = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã thanh toán"));
            //int datHuy = DB.PHIEUDATPHONGs.Count(x => x.TINHTRANG.Equals("Đã hủy"));
            var datTruoc = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_DATTRUOC()").FirstOrDefault();
            var daXacNhan = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_DAXACNHAN()").FirstOrDefault();
            var daThanhToan = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_DATHANHTOAN()").FirstOrDefault();
            var datHuy = DB.Database.SqlQuery<int>("SELECT dbo.FUNC_DAHUY()").FirstOrDefault();
            PDP_DATTRUOC.DataPoints.Add("", datTruoc);
            PDP_DAXACNHAN.DataPoints.Add("", daXacNhan);
            PDP_HUY.DataPoints.Add("", datHuy);
            PDP_THANHTOAN.DataPoints.Add("", daThanhToan);
        }

        private void SD_PDP_Load(object sender, EventArgs e)
        {
        }
    }
}
