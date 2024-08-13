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
    public partial class KhachHang : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        DataTable KH = new DataTable();
        public KhachHang()
        {
            InitializeComponent();
        }
        public void LoadKH()
        {
            KH = new DataTable();
            KH.Columns.Add("Mã khách hàng");
            KH.Columns.Add("Tên khách hàng");
            KH.Columns.Add("Số điện thoại");
            KH.Columns.Add("Căn cước công dân");
            var listKH = DB.KHACHes.ToList();
            foreach(var item in listKH)
            {
                KH.Rows.Add(item.MAKH,item.TENKH,item.SDT,item.CCCD);
            }
            DT_DS_KH.DataSource = KH;
            DT_DS_KH.AllowUserToAddRows = false;
            DT_DS_KH.ReadOnly = true;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FindKH.Text.Trim() != "")
                {
                    string CCCD = FindKH.Text.Trim();
                    KH = new DataTable();
                    KH.Columns.Add("Mã khách hàng");
                    KH.Columns.Add("Tên khách hàng");
                    KH.Columns.Add("Số điện thoại");
                    KH.Columns.Add("Căn cước công dân");
                    //var find = DB.KHACHes.Where(x => x.CCCD.Contains(CCCD)).ToList();
                    var find = DB.FUNC_FINDKH(CCCD);
                    foreach (var item in find)
                    {
                        KH.Rows.Add(item.MAKH, item.TENKH, item.SDT, item.CCCD);
                    }
                    DT_DS_KH.DataSource = KH;
                    DT_DS_KH.ReadOnly = true;
                    DT_DS_KH.Refresh();
                }
                else
                {
                    LoadKH();
                }
            }
        }
    }
}
