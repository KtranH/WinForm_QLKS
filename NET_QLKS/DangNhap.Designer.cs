namespace NET_QLKS
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PANELOGIN = new Guna.UI2.WinForms.Guna2Panel();
            this.ErrorMK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ErrorTK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTNEXIT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNLOGIN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTNMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNTENTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.PANELOGIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(490, 800);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PANELOGIN
            // 
            this.PANELOGIN.BackColor = System.Drawing.SystemColors.Window;
            this.PANELOGIN.Controls.Add(this.ErrorMK);
            this.PANELOGIN.Controls.Add(this.ErrorTK);
            this.PANELOGIN.Controls.Add(this.BTNEXIT);
            this.PANELOGIN.Controls.Add(this.BTNLOGIN);
            this.PANELOGIN.Controls.Add(this.guna2HtmlLabel4);
            this.PANELOGIN.Controls.Add(this.guna2HtmlLabel3);
            this.PANELOGIN.Controls.Add(this.BTNMK);
            this.PANELOGIN.Controls.Add(this.BTNTENTK);
            this.PANELOGIN.Controls.Add(this.guna2HtmlLabel2);
            this.PANELOGIN.Controls.Add(this.guna2PictureBox2);
            this.PANELOGIN.Controls.Add(this.guna2HtmlLabel1);
            this.PANELOGIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.PANELOGIN.Location = new System.Drawing.Point(490, 0);
            this.PANELOGIN.Name = "PANELOGIN";
            this.PANELOGIN.Size = new System.Drawing.Size(1317, 800);
            this.PANELOGIN.TabIndex = 1;
            this.PANELOGIN.Paint += new System.Windows.Forms.PaintEventHandler(this.PANELOGIN_Paint);
            // 
            // ErrorMK
            // 
            this.ErrorMK.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMK.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.ErrorMK.Location = new System.Drawing.Point(91, 513);
            this.ErrorMK.Name = "ErrorMK";
            this.ErrorMK.Size = new System.Drawing.Size(150, 20);
            this.ErrorMK.TabIndex = 10;
            this.ErrorMK.Text = "Mật khẩu không đúng";
            this.ErrorMK.Visible = false;
            // 
            // ErrorTK
            // 
            this.ErrorTK.BackColor = System.Drawing.Color.Transparent;
            this.ErrorTK.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.ErrorTK.Location = new System.Drawing.Point(91, 394);
            this.ErrorTK.Name = "ErrorTK";
            this.ErrorTK.Size = new System.Drawing.Size(151, 20);
            this.ErrorTK.TabIndex = 9;
            this.ErrorTK.Text = "Tài khoản không đúng";
            this.ErrorTK.Visible = false;
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.BorderRadius = 20;
            this.BTNEXIT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNEXIT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNEXIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEXIT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNEXIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNEXIT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTNEXIT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.BTNEXIT.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEXIT.ForeColor = System.Drawing.Color.White;
            this.BTNEXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTNEXIT.Image")));
            this.BTNEXIT.Location = new System.Drawing.Point(384, 743);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(114, 45);
            this.BTNEXIT.TabIndex = 8;
            this.BTNEXIT.Text = "Thoát";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.BorderRadius = 20;
            this.BTNLOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNLOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNLOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLOGIN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNLOGIN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTNLOGIN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.BTNLOGIN.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLOGIN.ForeColor = System.Drawing.Color.White;
            this.BTNLOGIN.Location = new System.Drawing.Point(82, 543);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(350, 45);
            this.BTNLOGIN.TabIndex = 7;
            this.BTNLOGIN.Text = "Đăng Nhập";
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(91, 433);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(88, 24);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Mật khẩu:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(91, 314);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(125, 24);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Tên tài khoản:";
            // 
            // BTNMK
            // 
            this.BTNMK.Animated = true;
            this.BTNMK.BorderColor = System.Drawing.Color.White;
            this.BTNMK.BorderRadius = 20;
            this.BTNMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BTNMK.DefaultText = "Nhập mật khẩu của bạn";
            this.BTNMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BTNMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BTNMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BTNMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BTNMK.FillColor = System.Drawing.SystemColors.Control;
            this.BTNMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BTNMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BTNMK.Location = new System.Drawing.Point(82, 463);
            this.BTNMK.Name = "BTNMK";
            this.BTNMK.PasswordChar = '*';
            this.BTNMK.PlaceholderText = "";
            this.BTNMK.SelectedText = "";
            this.BTNMK.Size = new System.Drawing.Size(350, 44);
            this.BTNMK.TabIndex = 4;
            this.BTNMK.Click += new System.EventHandler(this.BTNMK_Click);
            this.BTNMK.Leave += new System.EventHandler(this.BTNMK_Leave);
            // 
            // BTNTENTK
            // 
            this.BTNTENTK.Animated = true;
            this.BTNTENTK.BorderColor = System.Drawing.Color.White;
            this.BTNTENTK.BorderRadius = 20;
            this.BTNTENTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BTNTENTK.DefaultText = "Nhập tên tài khoản của bạn";
            this.BTNTENTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BTNTENTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BTNTENTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BTNTENTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BTNTENTK.FillColor = System.Drawing.SystemColors.Control;
            this.BTNTENTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BTNTENTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNTENTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BTNTENTK.Location = new System.Drawing.Point(82, 344);
            this.BTNTENTK.Name = "BTNTENTK";
            this.BTNTENTK.PasswordChar = '\0';
            this.BTNTENTK.PlaceholderText = "";
            this.BTNTENTK.SelectedText = "";
            this.BTNTENTK.Size = new System.Drawing.Size(350, 44);
            this.BTNTENTK.TabIndex = 3;
            this.BTNTENTK.Click += new System.EventHandler(this.BTNTENTK_Click);
            this.BTNTENTK.Leave += new System.EventHandler(this.BTNTENTK_Leave);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(82, 177);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(350, 28);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Vui lòng đặt nhập tài khoản của bạn";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(220, 211);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(69, 64);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(146, 121);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(216, 50);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.PANELOGIN);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTX | Quản lý khách sạn";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.PANELOGIN.ResumeLayout(false);
            this.PANELOGIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel PANELOGIN;
        private Guna.UI2.WinForms.Guna2GradientButton BTNEXIT;
        private Guna.UI2.WinForms.Guna2GradientButton BTNLOGIN;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox BTNMK;
        private Guna.UI2.WinForms.Guna2TextBox BTNTENTK;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorMK;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorTK;
    }
}

