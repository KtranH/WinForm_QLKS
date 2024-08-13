namespace NET_QLKS
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.FindKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.DT_DS_KH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GR_DSPHONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.FindKH);
            this.GR_DSPHONG.Controls.Add(this.DT_DS_KH);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(12, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(1496, 778);
            this.GR_DSPHONG.TabIndex = 8;
            this.GR_DSPHONG.Text = "Danh sách khách hàng";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // FindKH
            // 
            this.FindKH.BackColor = System.Drawing.Color.Transparent;
            this.FindKH.BorderColor = System.Drawing.Color.White;
            this.FindKH.BorderRadius = 15;
            this.FindKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FindKH.DefaultText = "";
            this.FindKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FindKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FindKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FindKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FindKH.FillColor = System.Drawing.SystemColors.Control;
            this.FindKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FindKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FindKH.IconRight = ((System.Drawing.Image)(resources.GetObject("FindKH.IconRight")));
            this.FindKH.Location = new System.Drawing.Point(935, 16);
            this.FindKH.Name = "FindKH";
            this.FindKH.PasswordChar = '\0';
            this.FindKH.PlaceholderText = "Tìm kiếm khách hàng";
            this.FindKH.SelectedText = "";
            this.FindKH.Size = new System.Drawing.Size(539, 36);
            this.FindKH.TabIndex = 12;
            this.FindKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindRoom_KeyDown);
            // 
            // DT_DS_KH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DT_DS_KH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_DS_KH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DT_DS_KH.ColumnHeadersHeight = 30;
            this.DT_DS_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DT_DS_KH.DefaultCellStyle = dataGridViewCellStyle3;
            this.DT_DS_KH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_KH.Location = new System.Drawing.Point(3, 70);
            this.DT_DS_KH.Name = "DT_DS_KH";
            this.DT_DS_KH.RowHeadersVisible = false;
            this.DT_DS_KH.Size = new System.Drawing.Size(1490, 696);
            this.DT_DS_KH.TabIndex = 11;
            this.DT_DS_KH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_KH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DT_DS_KH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DT_DS_KH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DT_DS_KH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DT_DS_KH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_KH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_KH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT_DS_KH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DT_DS_KH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_KH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DT_DS_KH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DT_DS_KH.ThemeStyle.HeaderStyle.Height = 30;
            this.DT_DS_KH.ThemeStyle.ReadOnly = false;
            this.DT_DS_KH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_KH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DT_DS_KH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_KH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DT_DS_KH.ThemeStyle.RowsStyle.Height = 22;
            this.DT_DS_KH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_KH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1520, 802);
            this.Controls.Add(this.GR_DSPHONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.Text = "GTX - Khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.GR_DSPHONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_KH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2TextBox FindKH;
        private Guna.UI2.WinForms.Guna2DataGridView DT_DS_KH;
    }
}