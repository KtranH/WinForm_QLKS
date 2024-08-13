using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class CT_PhieuDatPhong : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable KH = new DataTable();
        public string UserCurrentCTDATPHONG { get; set; }
        public DataTable phieuDatPhong { get; set; }
        public string Tenphong { get; set; }
        public CT_PhieuDatPhong()
        {
            InitializeComponent();
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_CCCD.DataBindings.Clear();
            TEXT_SDT.DataBindings.Clear();
            TEXT_TENKH.DataBindings.Clear();
            TEXT_TENKH.DataBindings.Add("Text",dt,"Tên khách hàng");
            TEXT_SDT.DataBindings.Add("Text",dt,"Số điện thoại");
            TEXT_CCCD.DataBindings.Add("Text",dt,"Số căn cước công dân");
        }
        public void LoadPhong()
        {
            var phong = DB.PHONGs.FirstOrDefault(x=>x.TENPHONG.Equals(Tenphong));
            TEXT_MAPHONG.Text = phong.MAPH.ToString();
            TEXT_TENPHONG.Text = phong.TENPHONG.ToString();
            TEXT_GIATHUE.Text = phong.GIATHUE.ToString();
            TEXT_LOAIPHONG.Text = phong.LOAIPHONG.TENLOAI.ToString();
            TEXT_VITRI.Text = phong.VITRI.ToString();
            TEXT_SUCCHUA.Text = phong.LOAIPHONG.SUCCHUA.ToString();
        }
        private void CT_PhieuDatPhong_Load(object sender, EventArgs e)
        {
            KH = new DataTable();
            KH.Columns.Add("Tên khách hàng");
            KH.Columns.Add("Số điện thoại");
            KH.Columns.Add("Số căn cước công dân");
            DT_DS_KH.DataSource = KH;
            DT_DS_KH.ReadOnly = true;
            DT_DS_KH.AllowUserToAddRows = false;
            LoadPhong();
        }

        private void BTN_HUY_Click(object sender, EventArgs e)
        {
            DatPhong DP = new DatPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP.UserCurrentDatPhong = UserCurrentCTDATPHONG;
            this.Controls.Clear();
            this.Controls.Add(DP);
            DP.Show();
        }

        private void BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            if(TEXT_TENKH.Text.Trim() != "" && TEXT_SDT.Text.Trim() != "" && TEXT_CCCD.Text.Trim() != "")
            {
                if(TEXT_SDT.Text.Length < 10 || TEXT_SDT.Text.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DT_DS_KH.Refresh();
                    int check = 0;
                    int count = 1;
                    var phong = DB.PHONGs.FirstOrDefault(x => x.TENPHONG.Equals(Tenphong));
                    foreach (DataGridViewRow item in DT_DS_KH.Rows)
                    {
                        if (!item.IsNewRow)
                        {
                            count++;
                            if (item.Cells[1].Value.ToString() == TEXT_SDT.Text.ToString() || item.Cells[2].Value.ToString() == TEXT_CCCD.Text.ToString())
                            {
                                check = 1;
                                MessageBox.Show("Thông tin bị trùng số điện thoại hoặc CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    if(check == 0)
                    {
                        KH.Rows.Add(TEXT_TENKH.Text, TEXT_SDT.Text, TEXT_CCCD.Text);
                        DT_DS_KH.DataSource = KH;
                        DT_DS_KH.ReadOnly = true;
                        DT_DS_KH.AllowUserToAddRows = false;
                        DT_DS_KH.Refresh();
                        TEXT_STT.Clear();
                        TEXT_TENKH.Clear();
                        TEXT_CCCD.Clear();
                        TEXT_SDT.Clear();
                        if (count == phong.LOAIPHONG.SUCCHUA)
                        {
                            BTN_XACNHAN.Enabled = false;
                        }
                    }    
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
        }

        private void TEXT_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void BTN_XOAKH_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = false;
            foreach (DataGridViewRow item in DT_DS_KH.Rows)
            {
                if (!item.IsNewRow)
                {
                    if (item.Cells[2].Value.ToString() == TEXT_CCCD.Text.ToString())
                    {
                        foreach(DataRow x in KH.Rows)
                        {
                            if (x["Số căn cước công dân"].ToString() == item.Cells[2].Value.ToString())
                            {
                                KH.Rows.Remove(x);
                                break;
                            }    
                        }
                        DT_DS_KH.DataSource = KH;
                        BTN_XACNHAN.Enabled = true;
                        DT_DS_KH.Refresh();
                        TEXT_STT.Clear();
                        TEXT_TENKH.Clear();
                        TEXT_CCCD.Clear();
                        TEXT_SDT.Clear();
                        TEXT_TENKH.DataBindings.Clear();
                        TEXT_SDT.DataBindings.Clear();
                        TEXT_CCCD.DataBindings.Clear();
                        TEXT_STT.DataBindings.Clear();
                        TEXT_TENKH.ReadOnly = false;
                        TEXT_CCCD.ReadOnly = false;
                        TEXT_SDT.ReadOnly = false;
                        TEXT_STT.ReadOnly = false;
                        break;
                    }
                }
            }
        }

        private void DT_DS_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(KH);
            TEXT_TENKH.ReadOnly = true;
            TEXT_CCCD.ReadOnly = true;
            TEXT_SDT.ReadOnly = true;
            TEXT_STT.ReadOnly = true;
            DT_DS_KH.ReadOnly = false;
            int count = 0;
            foreach (DataGridViewRow item in DT_DS_KH.Rows)
            {
                if (!item.IsNewRow)
                {
                    if(TEXT_CCCD.Text.ToString().Trim() == item.Cells[2].Value.ToString())
                    {
                        break;
                    }
                    count++;
                }
            }
            TEXT_STT.Text = count.ToString();
        }

        private void TEXT_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void BTN_CAPNHAT_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = true;
            if (TEXT_TENKH.Text.Trim() != "" && TEXT_SDT.Text.Trim() != "" && TEXT_CCCD.Text.Trim() != "")
            {
                if (TEXT_SDT.Text.Length < 10 || TEXT_SDT.Text.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(TEXT_STT.Text != "")
                    {
                        try
                        {
                            DT_DS_KH.Refresh();
                            int count = 0;
                            int check = Convert.ToInt32(TEXT_STT.Text.ToString());
                            int flag = 0;
                            foreach (DataGridViewRow item in DT_DS_KH.Rows)
                            {
                                if (!item.IsNewRow)
                                {
                                    if (count == check)
                                    {
                                        int checkTrung = 0;
                                        foreach (DataGridViewRow X in DT_DS_KH.Rows)
                                        {
                                            if (!X.IsNewRow)
                                            {
                                                if (checkTrung != check)
                                                {
                                                    if (X.Cells[1].Value.ToString() == TEXT_SDT.Text.ToString() || X.Cells[2].Value.ToString() == TEXT_CCCD.Text.ToString())
                                                    {
                                                        flag = 1;
                                                        MessageBox.Show("Thông tin bị trùng số điện thoại hoặc CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        break;
                                                    }
                                                }
                                                checkTrung++;
                                            }
                                        }
                                        if (flag == 0)
                                        {
                                            foreach (DataRow x in KH.Rows)
                                            {
                                                if (x["Số căn cước công dân"].ToString() == item.Cells[2].Value.ToString())
                                                {
                                                    x["Tên khách hàng"] = TEXT_TENKH.Text.ToString().Trim();
                                                    x["Số điện thoại"] = TEXT_SDT.Text.ToString().Trim();
                                                    x["Số căn cước công dân"] = TEXT_CCCD.Text.ToString().Trim();
                                                    break;
                                                }
                                            }
                                            item.Cells[0].Value = TEXT_TENKH.Text.ToString().Trim();
                                            item.Cells[1].Value = TEXT_SDT.Text.ToString().Trim();
                                            item.Cells[2].Value = TEXT_CCCD.Text.ToString().Trim();
                                            DT_DS_KH.Refresh();
                                            TEXT_TENKH.Clear();
                                            TEXT_SDT.Clear();
                                            TEXT_CCCD.Clear();
                                            TEXT_STT.Clear();
                                            TEXT_TENKH.DataBindings.Clear();
                                            TEXT_SDT.DataBindings.Clear();
                                            TEXT_CCCD.DataBindings.Clear();
                                            TEXT_STT.DataBindings.Clear();
                                            TEXT_TENKH.ReadOnly = false;
                                            TEXT_CCCD.ReadOnly = false;
                                            TEXT_SDT.ReadOnly = false;
                                            TEXT_STT.ReadOnly = false;
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    count++;
                                }
                            }
                        } 
                        catch
                        {
                            MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_HOANTAT_Click(object sender, EventArgs e)
        {
            if(DT_DS_KH.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               try
                {
                    int upKHCheck = 0;
                    DB.Configuration.ValidateOnSaveEnabled = false;
                    List<string> listKH = new List<string>();
                    foreach (DataGridViewRow row in DT_DS_KH.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            listKH.Add(row.Cells[2].Value.ToString());
                            string CCCD = row.Cells[2].Value.ToString();
                            var checkKH = DB.KHACHes.Any(x => x.CCCD.Equals(CCCD));
                            if (checkKH)
                            {
                                var takeKH = DB.KHACHes.FirstOrDefault(x => x.CCCD.Equals(CCCD));
                                if (row.Cells[0].Value.ToString() != takeKH.TENKH.ToString() || row.Cells[1].Value.ToString() != takeKH.SDT.ToString())
                                {
                                    DialogResult result = MessageBox.Show("Đã phát hiện khách hàng này tồn tại trong dữ liệu!\n Dữ liệu có thay đổi về họ tên hoặc số điện thoại. Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result == DialogResult.Yes)
                                    {                                        
                                        takeKH.TENKH = row.Cells[0].Value.ToString();
                                        takeKH.SDT = row.Cells[1].Value.ToString();
                                        DB.Entry(takeKH).State = System.Data.Entity.EntityState.Modified;
                                        DB.SaveChanges();
                                    }
                                    else
                                    {
                                        upKHCheck = 1;
                                        break;
                                    }    
                                }
                            }
                            else
                            {
                                var newKH = new KHACH();
                                newKH.TENKH = row.Cells[0].Value.ToString();
                                newKH.SDT = row.Cells[1].Value.ToString();
                                newKH.CCCD = row.Cells[2].Value.ToString();
                                DB.KHACHes.Add(newKH);
                                DB.SaveChanges();
                            }
                        }
                    }
                    if (upKHCheck == 0)
                    {
                        var newDP = new PHIEUDATPHONG();
                        var takeNV = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentCTDATPHONG));
                        int IDNV = Convert.ToInt32(takeNV.MANV.ToString());
                        foreach (DataRow x in phieuDatPhong.Rows)
                        {
                            newDP.MANV = IDNV;
                            newDP.MAPH = Convert.ToInt32(x["MaPhong"].ToString());
                            int IDROOM = Convert.ToInt32(x["MaPhong"].ToString());
                            var upStateRoom = DB.PHONGs.FirstOrDefault(z => z.MAPH.Equals(IDROOM));
                            upStateRoom.TINHTRANG = "Đã đặt";
                            DB.Entry(upStateRoom).State = System.Data.Entity.EntityState.Modified;
                            newDP.NGAYDAT = DateTime.Parse(x["NgayDat"].ToString());
                            newDP.TINHTRANG = x["TinhTrang"].ToString();
                        }
                        List<KHACH> khachList = new List<KHACH>();
                        foreach (string item in listKH)
                        {
                            var IDKH = DB.KHACHes.FirstOrDefault(x => x.CCCD.Equals(item));
                            KHACH khach = IDKH;
                            khachList.Add(khach);
                        }
                        newDP.KHACHes = khachList;
                        DB.PHIEUDATPHONGs.Add(newDP);
                        DB.SaveChanges();
                        var addCT_DP = DB.PHIEUDATPHONGs.Max(x => x.MAPDP);
                        var checkCT_DP = DB.PHIEUDATPHONGs.FirstOrDefault(x => x.MAPDP.Equals(addCT_DP));
                        if (checkCT_DP.TINHTRANG != "Đặt trước")
                        {
                            var newHD = new HOADON();
                            newHD.MAPDP = checkCT_DP.MAPDP;
                            newHD.THANHTIEN = null;
                            newHD.NHANVIEN = null;
                            newHD.NGAYLAP = null;
                            DB.HOADONs.Add(newHD);
                            DB.SaveChanges();
                            MessageBox.Show("Thêm đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm đặt trước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        TT_PDP PDP = new TT_PDP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        this.Controls.Clear();
                        this.Controls.Add(PDP);
                        PDP.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra với dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            TEXT_TENKH.Clear();
            TEXT_SDT.Clear();
            TEXT_CCCD.Clear();
            TEXT_STT.Clear();
            TEXT_TENKH.DataBindings.Clear();
            TEXT_SDT.DataBindings.Clear();
            TEXT_CCCD.DataBindings.Clear();
            TEXT_STT.DataBindings.Clear();
            TEXT_TENKH.ReadOnly = false;
            TEXT_CCCD.ReadOnly = false;
            TEXT_SDT.ReadOnly = false;
            TEXT_STT.ReadOnly = false;
            TEXT_TENKH.Focus();
        }

        private void BTN_CHINHSUA_Click(object sender, EventArgs e)
        {
            DT_DS_KH.ReadOnly = true;
        }
    }
}
