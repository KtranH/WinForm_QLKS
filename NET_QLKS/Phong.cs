using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NET_QLKS.Model;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace NET_QLKS
{
    public partial class Phong : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable phong = new DataTable();
        DataTable loai = new DataTable();
        public string UserCurrentPH { get; set; }
        public Phong()
        {
            InitializeComponent();
        }
        public void LoadPhong()
        {
            phong = new DataTable();
            phong.Columns.Add("Mã phòng");
            phong.Columns.Add("Tên phòng");
            phong.Columns.Add("Vị trí");
            phong.Columns.Add("Giá thuê");
            phong.Columns.Add("Tình trạng", typeof(string));
            phong.Columns.Add("Tên loại phòng", typeof(string));
            var ListPhong = DB.PHONGs.ToList();
            foreach (var item in ListPhong)
            {
                phong.Rows.Add(item.MAPH, item.TENPHONG, item.VITRI, item.GIATHUE, item.TINHTRANG, item.LOAIPHONG.TENLOAI);
            }
            DT_DS_PHONG.DataSource = phong;
            DT_DS_PHONG.ReadOnly = true;
            DT_DS_PHONG.AllowUserToAddRows = false;
        }
        public void LoadLoai()
        {
            loai = new DataTable();
            loai.Columns.Add("Mã loại");
            loai.Columns.Add("Tên loại");
            loai.Columns.Add("Sức chứa");
            var ListLoai = DB.LOAIPHONGs.ToList();
            foreach (var item in ListLoai)
            {
                loai.Rows.Add(item.MALOAI, item.TENLOAI, item.SUCCHUA);
            }
            DT_DS_LOAI.DataSource = loai;
            DT_DS_LOAI.ReadOnly = true;
            DT_DS_LOAI.AllowUserToAddRows = false;
        }
        public void OptionPhong()
        {
            OP_PHONG.Items.Add("Trống");
            OP_PHONG.Items.Add("Dọn phòng");
            OP_PHONG.Items.Add("Sửa chữa");
            OP_PHONG.Items.Add("Đã đặt");
            OP_PHONG.SelectedItem = "Trống";
        }
        public void OptionState()
        {
            List<string> tinhTrang = new List<string> { "Trống", "Bảo trì", "Đang dọn" };
            OP_STATE.DataSource = tinhTrang;
        }
        public void OptionKind()
        {
            var loai = DB.LOAIPHONGs.ToList();
            OP_KIND.DataSource = loai;
            OP_KIND.DisplayMember = "TENLOAI";
            OP_KIND.ValueMember = "TENLOAI";
        }
        public void FindLoai()
        {

        }
        public void ConnectionControl2(DataTable dt)
        {
            TEXT_TENLOAI.DataBindings.Clear();
            TEXT_SUCCHUA.DataBindings.Clear();
            MALOAI.DataBindings.Clear();
            MALOAI.DataBindings.Add("Text", dt, "Mã loại");
            TEXT_TENLOAI.DataBindings.Add("Text", dt, "Tên loại");
            TEXT_SUCCHUA.DataBindings.Add("Text", dt, "Sức chứa");
        }
        public void ConnectionControl(DataTable dt)
        {
            TEXT_TENPHONG.DataBindings.Clear();
            TEXT_GIA.DataBindings.Clear();
            TEXT_VITRI.DataBindings.Clear();
            OP_KIND.DataBindings.Clear();
            MAPH.DataBindings.Clear();
            MAPH.DataBindings.Add("Text", dt, "Mã phòng");
            TEXT_TENPHONG.DataBindings.Add("Text", dt, "Tên phòng");
            TEXT_GIA.DataBindings.Add("Text", dt, "Giá thuê");
            TEXT_VITRI.DataBindings.Add("Text", dt, "Vị trí");
            OP_KIND.DataBindings.Add("SelectedValue", dt, "Tên loại phòng");
        }
        public void LockControl()
        {
            TEXT_TENPHONG.Enabled = false;
            TEXT_GIA.Enabled = false;
            TEXT_VITRI.Enabled = false;
            TEXT_TENLOAI.Enabled = false;
            TEXT_SUCCHUA.Enabled = false;
            OP_KIND.Enabled = false;
            OP_STATE.Enabled = false;
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            OptionPhong();
            OptionState();
            OptionKind();
            LoadPhong();
            LoadLoai();
            LockControl();
            var USER = DB.NHANVIENs.FirstOrDefault(x => x.TENTK.Equals(UserCurrentPH));
            if(USER.NHOMQUYEN.PHANQUYEN.CHUCNANG == "Admin")
            {
                BTN_UPDATEROOM.Enabled = true;
                BTN_UPDATEKIND.Enabled = true;
                BTN_SAVEKIND.Enabled = true;
                BTN_SAVEROOM.Enabled = true;
                BTN_THEMLOAI.Enabled = true;
                BTN_THEMPHONG.Enabled = true;
            }    
        }

        private void OP_PHONG_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OP_PHONG.Text != null)
            {
                string check = OP_PHONG.Text.Trim();
                phong = new DataTable();
                phong.Columns.Add("Mã phòng");
                phong.Columns.Add("Tên phòng");
                phong.Columns.Add("Vị trí");
                phong.Columns.Add("Giá thuê");
                phong.Columns.Add("Tình trạng");
                phong.Columns.Add("Tên loại phòng");
                var ListPhong = DB.PHONGs.Where(x => x.TINHTRANG.Equals(check)).ToList();
                foreach (var item in ListPhong)
                {
                    phong.Rows.Add(item.MAPH, item.TENPHONG, item.VITRI, item.GIATHUE, item.TINHTRANG, item.LOAIPHONG.TENLOAI);
                }
                DT_DS_PHONG.DataSource = phong;
                DT_DS_PHONG.ReadOnly = true;
                DT_DS_PHONG.Refresh();
            }
        }

        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindRoom.Text.Trim() != "")
                {
                    string tenPH = FindRoom.Text.Trim();
                    tenPH = tenPH.ToLower();
                    phong = new DataTable();
                    phong.Columns.Add("Mã phòng");
                    phong.Columns.Add("Tên phòng");
                    phong.Columns.Add("Vị trí");
                    phong.Columns.Add("Giá thuê");
                    phong.Columns.Add("Tình trạng");
                    phong.Columns.Add("Tên loại phòng");
                    var find = DB.PROC_FINDPHONG(tenPH);
                    //var find = DB.PHONGs.Where(x => x.TENPHONG.ToLower().Contains(tenPH)).ToList();
                    foreach (var item in find)
                    {
                        phong.Rows.Add(item.MAPH, item.TENPHONG, item.VITRI, item.GIATHUE, item.TINHTRANG, item.TENLOAI);
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

        private void FindRoom_Click(object sender, EventArgs e)
        {
            FindRoom.Clear();
        }

        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (FindRoom.Text.Trim() == "")
            {
                FindRoom.Text = "Tìm kiếm phòng";
            }
        }

        private void FindKind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindKind.Text.Trim() != "")
                {
                    string tenLoai = FindKind.Text.Trim();
                    tenLoai = tenLoai.ToLower();
                    loai = new DataTable();
                    loai.Columns.Add("Mã loại");
                    loai.Columns.Add("Tên loại");
                    loai.Columns.Add("Sức chứa");
                    //var find = DB.LOAIPHONGs.Where(x => x.TENLOAI.ToLower().Contains(tenLoai)).ToList();
                    var find = DB.PROC_FINDLOAI(tenLoai);
                    foreach (var item in find)
                    {
                        loai.Rows.Add(item.MALOAI, item.TENLOAI, item.SUCCHUA);
                    }
                    DT_DS_LOAI.DataSource = loai;
                    DT_DS_LOAI.ReadOnly = true;
                    DT_DS_LOAI.Refresh();
                }
                else
                {
                    LoadLoai();
                }
            }
        }

        private void FindKind_Click(object sender, EventArgs e)
        {
            FindKind.Clear();
        }

        private void FindKind_Leave(object sender, EventArgs e)
        {
            if (FindKind.Text.Trim() == "")
            {
                FindKind.Text = "Tìm kiếm loại";
            }
        }

        private void BTN_THEMPHONG_Click(object sender, EventArgs e)
        {
            DT_DS_PHONG.AllowUserToAddRows = true;
            DT_DS_PHONG.ReadOnly = false;
            for (int i = 0; i < DT_DS_PHONG.RowCount - 1; i++)
            {
                DT_DS_PHONG.Rows[i].ReadOnly = true;
            }
            DT_DS_PHONG.Columns[0].ReadOnly = true;
            DT_DS_PHONG.FirstDisplayedScrollingRowIndex = DT_DS_PHONG.Rows.Count - 1;
        }

        private void BTN_SAVEROOM_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in DT_DS_PHONG.Rows)
            {
                if (!row.IsNewRow)
                {
                    string nameRoom = row.Cells[1].Value.ToString().Trim();
                    string checkRoom = row.Cells[0].Value.ToString().Trim();
                    if (checkRoom == "")
                    {
                        try
                        {
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            var newRoom = new PHONG();
                            newRoom.TENPHONG = nameRoom;
                            newRoom.VITRI = row.Cells[2].Value.ToString().Trim();
                            newRoom.GIATHUE = double.Parse(row.Cells[3].Value.ToString().Trim());
                            newRoom.TINHTRANG = row.Cells[4].Value.ToString().Trim();
                            switch (row.Cells[5].Value.ToString().Trim().ToLower())
                            {
                                case "phòng đơn":
                                    newRoom.MALOAI = 1;
                                    break;
                                case "phòng đôi":
                                    newRoom.MALOAI = 2;
                                    break;
                                case "phòng gia đình":
                                    newRoom.MALOAI = 3;
                                    break;
                                case "suite":
                                    newRoom.MALOAI = 4;
                                    break;
                                default:
                                    newRoom.MALOAI = 1;
                                    break;
                            }
                            DB.PHONGs.Add(newRoom);
                        }
                        catch
                        {
                            check = 1;
                            LockControl();
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        try
                        {
                            int checkID = Convert.ToInt32(checkRoom);
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            var upRoom = DB.PHONGs.FirstOrDefault(x => x.MAPH.Equals(checkID));
                            upRoom.TENPHONG = nameRoom;
                            upRoom.VITRI = row.Cells[2].Value.ToString().Trim();
                            upRoom.GIATHUE = double.Parse(row.Cells[3].Value.ToString().Trim());
                            upRoom.TINHTRANG = row.Cells[4].Value.ToString().Trim();
                            switch (row.Cells[5].Value.ToString().Trim().ToLower())
                            {
                                case "phòng đơn":
                                    upRoom.MALOAI = 1;
                                    break;
                                case "phòng đôi":
                                    upRoom.MALOAI = 2;
                                    break;
                                case "phòng gia đình":
                                    upRoom.MALOAI = 3;
                                    break;
                                case "suite":
                                    upRoom.MALOAI = 4;
                                    break;
                                default:
                                    upRoom.MALOAI = 1;
                                    break;
                            }
                            LockControl();
                            DB.Entry(upRoom).State = System.Data.Entity.EntityState.Modified;
                        }
                        catch
                        {
                            check = 1;
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LockControl();
                            break;
                        }
                    }
                }
            }
            if (check == 0)
            {
                DT_DS_PHONG.ReadOnly = true;
                DT_DS_PHONG.AllowUserToAddRows = false;
                DB.SaveChanges();
                LoadPhong();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BTN_UPDATEROOM_Click(object sender, EventArgs e)
        {

            TEXT_TENPHONG.Enabled = true;
            TEXT_GIA.Enabled = true;
            TEXT_VITRI.Enabled = true;
            OP_KIND.Enabled = true;
            OP_STATE.Enabled = true;
            if (MAPH.Text.Trim() != "" && TEXT_TENPHONG.Text.Trim() != "" && TEXT_VITRI.Text.Trim() != "" && TEXT_GIA.Text.Trim() != "")
            {
                string IDROOM = MAPH.Text.ToString().Trim();
                foreach (DataGridViewRow row in DT_DS_PHONG.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value.ToString().Trim() == IDROOM)
                        {
                            if (row.Cells[4].Value.ToString().Trim() != "Đã đặt")
                            {
                                row.Cells[1].Value = TEXT_TENPHONG.Text.Trim();
                                row.Cells[2].Value = TEXT_VITRI.Text.Trim();
                                row.Cells[3].Value = TEXT_GIA.Text.Trim();
                                row.Cells[4].Value = OP_STATE.Text.Trim();
                                row.Cells[5].Value = OP_KIND.Text.Trim();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật phòng này, vì đang có khách đang ở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LockControl();
                                break;
                            }
                        }
                    }
                }
                DT_DS_PHONG.Refresh();
            }
        }

        private void TEXT_GIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void DT_DS_PHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl(phong);
        }

        private void TEXT_SUCCHUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }
        }

        private void BTN_THEMLOAI_Click(object sender, EventArgs e)
        {
            DT_DS_LOAI.AllowUserToAddRows = true;
            DT_DS_LOAI.ReadOnly = false;
            for (int i = 0; i < DT_DS_LOAI.RowCount - 1; i++)
            {
                DT_DS_LOAI.Rows[i].ReadOnly = true;
            }
            DT_DS_LOAI.Columns[0].ReadOnly = true;
            DT_DS_LOAI.FirstDisplayedScrollingRowIndex = DT_DS_LOAI.Rows.Count - 1;
        }
        private void DT_DS_LOAI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionControl2(loai);
        }
        private void BTN_SAVEKIND_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in DT_DS_LOAI.Rows)
            {
                if (!row.IsNewRow)
                {
                    string nameLoai = row.Cells[1].Value.ToString().Trim();
                    string checkLoai = row.Cells[0].Value.ToString().Trim();
                    if (checkLoai == "")
                    {
                        try
                        {
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            int SUCCHUA = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
                            var newKind = DB.PROC_THEMLOAI(nameLoai, SUCCHUA);
                            //var newKind = new LOAIPHONG();
                            //newKind.TENLOAI = nameLoai;
                            //newKind.SUCCHUA = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
                            //DB.LOAIPHONGs.Add(newKind);
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
                            int checkID = Convert.ToInt32(checkLoai);
                            DB.Configuration.ValidateOnSaveEnabled = false;
                            int SUCCHUA = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
                            var upKind = DB.PROC_UPLOAIPHONG(checkID,nameLoai,SUCCHUA);
                            //var upKind = DB.LOAIPHONGs.FirstOrDefault(x => x.MALOAI.Equals(checkID));
                            //upKind.TENLOAI = nameLoai;
                            //upKind.SUCCHUA = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
                            //DB.Entry(upKind).State = System.Data.Entity.EntityState.Modified;
                            LockControl();
                        }
                        catch
                        {
                            check = 1;
                            MessageBox.Show("Dữ liệu nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadLoai();
                            break;
                        }
                    }
                }
            }
            if (check == 0)
            {
                DT_DS_LOAI.ReadOnly = true;
                DT_DS_LOAI.AllowUserToAddRows = false;
                DB.SaveChanges();
                LoadLoai();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BTN_UPDATEKIND_Click(object sender, EventArgs e)
        {
            TEXT_TENLOAI.Enabled = true;
            TEXT_SUCCHUA.Enabled = true;
            if (MALOAI.Text.Trim() != "" && TEXT_TENLOAI.Text.Trim() != "" && TEXT_SUCCHUA.Text.Trim() != "")
            {
                string IDKIND = MALOAI.Text.Trim();
                foreach (DataGridViewRow row in DT_DS_LOAI.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value.ToString().Trim().Equals(IDKIND))
                        {
                            row.Cells[1].Value = TEXT_TENLOAI.Text.Trim();
                            row.Cells[2].Value = TEXT_SUCCHUA.Text.Trim();
                        }
                    }
                }
                DT_DS_LOAI.Refresh();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
