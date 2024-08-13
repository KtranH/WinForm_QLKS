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
    public partial class DatPhong : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable phong = new DataTable();
        public string UserCurrentDatPhong { get; set; }
        public DatPhong()
        {
            InitializeComponent();
        }
        public void OptionPhong()
        {
            var loaiPhong = DB.LOAIPHONGs.ToList();
            loaiPhong.Insert(0, new LOAIPHONG { MALOAI = 0, TENLOAI = "Tất cả" });
            OP_PHONG.DataSource = loaiPhong;
            OP_PHONG.DisplayMember = "TENLOAI";
            OP_PHONG.ValueMember = "MALOAI";
            OP_PHONG.SelectedValue = 0;
        }    
        public void LoadTinhTrang()
        {
            List<string> tinhTrang = new List<string> { "Đặt trước", "Đã xác nhận"};
            OP_STATE.DataSource = tinhTrang;
            OP_STATE.SelectedIndex = 0;

        }
        public void LoadPhong()
        {
            phong = new DataTable();
            phong.Columns.Add("Mã phòng");
            phong.Columns.Add("Tên phòng");
            phong.Columns.Add("Vị trí");
            phong.Columns.Add("Giá thuê");
            phong.Columns.Add("Tình trạng");
            phong.Columns.Add("Loại phòng");
            var listPhong = DB.PHONGs.Where(x=>x.TINHTRANG.Equals("Trống")).ToList();
            foreach(var item in listPhong)
            {
                phong.Rows.Add(item.MAPH,item.TENPHONG,item.VITRI,item.GIATHUE,item.TINHTRANG,item.LOAIPHONG.TENLOAI);
            }    
            DT_DS_PHONG.DataSource = phong;
            DT_DS_PHONG.ReadOnly = true;
            DT_DS_PHONG.AllowUserToAddRows = false;
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_PHONGKHADUNG.DataBindings.Clear();
            TEXT_PHONGKHADUNG.DataBindings.Add("Text", dt, "Tên phòng");
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentDatPhong));
            TEXT_TENNV.Text = USER.TENNV;
            DATE_DATPHONG.Value = DateTime.Now; 
            LoadPhong();
            OptionPhong();
            LoadTinhTrang();
        }

        private void OP_PHONG_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OP_PHONG.Text != "Tất cả")
            {
                string check = OP_PHONG.Text.Trim();
                phong = new DataTable();
                phong.Columns.Add("Mã phòng");
                phong.Columns.Add("Tên phòng");
                phong.Columns.Add("Vị trí");
                phong.Columns.Add("Giá thuê");
                phong.Columns.Add("Tình trạng");
                phong.Columns.Add("Tên loại phòng");
                var listPhong = DB.PHONGs.Where(x => x.LOAIPHONG.TENLOAI.Equals(check) && x.TINHTRANG.Equals("Trống")).ToList();
                foreach (var item in listPhong)
                {
                    phong.Rows.Add(item.MAPH, item.TENPHONG, item.VITRI, item.GIATHUE, item.TINHTRANG, item.LOAIPHONG.TENLOAI);
                }
                DT_DS_PHONG.DataSource = phong;
                DT_DS_PHONG.ReadOnly = true;
                DT_DS_PHONG.Refresh();
               
            }
            else if(OP_PHONG.Text == "Tất cả")
            {
                LoadPhong();
            }    
        }
        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (FindRoom.Text.Trim() == "")
            {
                FindRoom.Text = "Tìm kiếm phòng";
            }
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            FindRoom.Clear();

        }
        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindRoom.Text.Trim() != "")
                {
                    string tenPH = FindRoom.Text.Trim();
                    tenPH = tenPH.ToLower();
                    var find = DB.PHONGs.Where(x => x.TENPHONG.ToLower().Contains(tenPH) && x.TINHTRANG.Equals("Trống")).ToList();
                    phong = new DataTable();
                    phong.Columns.Add("Mã phòng");
                    phong.Columns.Add("Tên phòng");
                    phong.Columns.Add("Vị trí");
                    phong.Columns.Add("Giá thuê");
                    phong.Columns.Add("Tình trạng");
                    phong.Columns.Add("Tên loại phòng");
                    foreach (var item in find)
                    {
                        phong.Rows.Add(item.MAPH, item.TENPHONG, item.VITRI, item.GIATHUE, item.TINHTRANG, item.LOAIPHONG.TENLOAI);
                    }
                    DT_DS_PHONG.DataSource = phong;
                    DT_DS_PHONG.ReadOnly = true;
                    DT_DS_PHONG.Refresh();
                }
                else
                {
                    LoadPhong();
                }
            }
        }

        private void DT_DS_PHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(phong);
        }

        private void BTN_CONTINUE_Click(object sender, EventArgs e)
        {
           if(TEXT_PHONGKHADUNG.Text != "")
            {
                DateTime ngayHomQua = DateTime.Now.AddDays(-1);
                if (DATE_DATPHONG.Value <= ngayHomQua)
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Đơn đặt phòng này sẽ có tình trạng là: " + OP_STATE.Text.ToString() + "\n Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == DialogResult.Yes)
                    {
                        CT_PhieuDatPhong CTDP = new CT_PhieuDatPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        string namePhong = TEXT_PHONGKHADUNG.Text;
                        var IDPHONG = DB.PHONGs.FirstOrDefault(x => x.TENPHONG.Equals(namePhong));
                        string checkPhong = IDPHONG.MAPH.ToString();
                        CTDP.Tenphong = TEXT_PHONGKHADUNG.Text;
                        CTDP.UserCurrentCTDATPHONG = UserCurrentDatPhong;
                        CTDP.phieuDatPhong = new DataTable();
                        CTDP.phieuDatPhong.Columns.Add("MaNV");
                        CTDP.phieuDatPhong.Columns.Add("MaPhong");
                        CTDP.phieuDatPhong.Columns.Add("NgayDat");
                        CTDP.phieuDatPhong.Columns.Add("TinhTrang");
                        CTDP.phieuDatPhong.Rows.Add(UserCurrentDatPhong, checkPhong, DATE_DATPHONG.Text, OP_STATE.Text);
                        this.Controls.Clear();
                        this.Controls.Add(CTDP);
                        CTDP.Show();
                    }  
                }
            }    
           else
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OP_STATE_SelectedValueChanged(object sender, EventArgs e)
        {
            if(OP_STATE.Text == "Đã xác nhận")
            {
                DATE_DATPHONG.Value = DateTime.Now;
                DATE_DATPHONG.Enabled = false;
            }    
            else
            {
                DATE_DATPHONG.Enabled = true;
            }    
        }
    }
}
