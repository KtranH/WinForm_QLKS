using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_QLKS.Model;

namespace NET_QLKS
{
    public partial class DangNhap : Form
    {
        NET_QLKS1Entities DB = new NET_QLKS1Entities();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void BTNTENTK_Click(object sender, EventArgs e)
        {
            BTNTENTK.Clear();
        }
        private void BTNTENTK_Leave(object sender, EventArgs e)
        {
            if(BTNTENTK.Text.Trim() == "")
            {
                BTNTENTK.Text = "Nhập tên tài khoản của bạn";
            }    
        }

        private void BTNMK_Click(object sender, EventArgs e)
        {
            BTNMK.Clear();
        }

        private void BTNMK_Leave(object sender, EventArgs e)
        {
            if (BTNMK.Text.Trim() == "")
            {
                BTNMK.Text = "Nhập tên tài khoản của bạn";
            }
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if(BTNTENTK.Text.Trim() != "" && BTNMK.Text.Trim() != "")
            {
                string USERNAME = BTNTENTK.Text.Trim();
                string PASS = BTNMK.Text.Trim();
                SqlParameter tenDangNhapParam = new SqlParameter("@TENDK", USERNAME);
                SqlParameter matKhauParam = new SqlParameter("@MATKHAU", PASS);
                int count = DB.Database.SqlQuery<int>("EXEC PROC_DANGNHAP @TENDK, @MATKHAU", tenDangNhapParam, matKhauParam).SingleOrDefault();
                if (count > 0)
                {
                    TrangChu LoginForm = new TrangChu();
                    LoginForm.UserCurrent = USERNAME;
                    this.Hide();
                    LoginForm.ShowDialog();
                }    
                else
                {
                    BTNTENTK.Clear();
                    BTNTENTK.Text = "Nhập tên tài khoản của bạn";
                    BTNMK.Clear();
                    BTNMK.Text = "Nhập tên tài khoản của bạn";
                    ErrorTK.Visible = true;
                    ErrorMK.Visible = true;
                }    
            }
            else
            {
                BTNTENTK.Clear();
                BTNTENTK.Text = "Nhập tên tài khoản của bạn";
                BTNMK.Clear();
                BTNMK.Text = "Nhập tên tài khoản của bạn";
                ErrorTK.Visible = true;
                ErrorMK.Visible = true;
            }
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            ErrorTK.Visible = false;
            ErrorMK.Visible = false;
            BTNTENTK.Text = "nv_a";
            BTNMK.Text = "passwordA";
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result  == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void PANELOGIN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
