namespace NET_QLKS
{
    partial class DatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatPhong));
            this.GR_DSPHONG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DT_DS_PHONG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FindRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.OP_PHONG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TEXT_PHONGKHADUNG = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTN_CONTINUE = new Guna.UI2.WinForms.Guna2Button();
            this.OP_STATE = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DATE_DATPHONG = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TEXT_TENNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GR_DSPHONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_PHONG)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GR_DSPHONG
            // 
            this.GR_DSPHONG.BorderColor = System.Drawing.Color.White;
            this.GR_DSPHONG.BorderRadius = 10;
            this.GR_DSPHONG.Controls.Add(this.DT_DS_PHONG);
            this.GR_DSPHONG.Controls.Add(this.FindRoom);
            this.GR_DSPHONG.Controls.Add(this.OP_PHONG);
            this.GR_DSPHONG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.GR_DSPHONG.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GR_DSPHONG.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR_DSPHONG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GR_DSPHONG.Location = new System.Drawing.Point(12, 12);
            this.GR_DSPHONG.Name = "GR_DSPHONG";
            this.GR_DSPHONG.Size = new System.Drawing.Size(784, 778);
            this.GR_DSPHONG.TabIndex = 5;
            this.GR_DSPHONG.Text = "Danh sách phòng khả dụng";
            this.GR_DSPHONG.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // DT_DS_PHONG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DT_DS_PHONG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DT_DS_PHONG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DT_DS_PHONG.ColumnHeadersHeight = 30;
            this.DT_DS_PHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DT_DS_PHONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DT_DS_PHONG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_PHONG.Location = new System.Drawing.Point(3, 54);
            this.DT_DS_PHONG.Name = "DT_DS_PHONG";
            this.DT_DS_PHONG.RowHeadersVisible = false;
            this.DT_DS_PHONG.Size = new System.Drawing.Size(778, 721);
            this.DT_DS_PHONG.TabIndex = 11;
            this.DT_DS_PHONG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_PHONG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DT_DS_PHONG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DT_DS_PHONG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DT_DS_PHONG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DT_DS_PHONG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_PHONG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DT_DS_PHONG.ThemeStyle.HeaderStyle.Height = 30;
            this.DT_DS_PHONG.ThemeStyle.ReadOnly = false;
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.Height = 22;
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DT_DS_PHONG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DT_DS_PHONG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_DS_PHONG_CellContentClick);
            // 
            // FindRoom
            // 
            this.FindRoom.BackColor = System.Drawing.Color.Transparent;
            this.FindRoom.BorderColor = System.Drawing.Color.White;
            this.FindRoom.BorderRadius = 15;
            this.FindRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FindRoom.DefaultText = "Tìm kiếm phòng";
            this.FindRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FindRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FindRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FindRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FindRoom.FillColor = System.Drawing.SystemColors.Control;
            this.FindRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FindRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FindRoom.IconRight = ((System.Drawing.Image)(resources.GetObject("FindRoom.IconRight")));
            this.FindRoom.Location = new System.Drawing.Point(404, 12);
            this.FindRoom.Name = "FindRoom";
            this.FindRoom.PasswordChar = '\0';
            this.FindRoom.PlaceholderText = "";
            this.FindRoom.SelectedText = "";
            this.FindRoom.Size = new System.Drawing.Size(198, 36);
            this.FindRoom.TabIndex = 6;
            this.FindRoom.Click += new System.EventHandler(this.FindRoom_Click);
            this.FindRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindRoom_KeyDown);
            this.FindRoom.Leave += new System.EventHandler(this.FindRoom_Leave);
            // 
            // OP_PHONG
            // 
            this.OP_PHONG.BackColor = System.Drawing.Color.Transparent;
            this.OP_PHONG.BorderColor = System.Drawing.Color.White;
            this.OP_PHONG.BorderRadius = 15;
            this.OP_PHONG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OP_PHONG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OP_PHONG.FillColor = System.Drawing.SystemColors.Control;
            this.OP_PHONG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OP_PHONG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OP_PHONG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OP_PHONG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OP_PHONG.ItemHeight = 30;
            this.OP_PHONG.Location = new System.Drawing.Point(608, 12);
            this.OP_PHONG.Name = "OP_PHONG";
            this.OP_PHONG.Size = new System.Drawing.Size(134, 36);
            this.OP_PHONG.TabIndex = 2;
            this.OP_PHONG.SelectedValueChanged += new System.EventHandler(this.OP_PHONG_SelectedValueChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.TEXT_PHONGKHADUNG);
            this.guna2GroupBox2.Controls.Add(this.BTN_CONTINUE);
            this.guna2GroupBox2.Controls.Add(this.OP_STATE);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox2.Controls.Add(this.DATE_DATPHONG);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox2.Controls.Add(this.TEXT_TENNV);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.guna2GroupBox2.Location = new System.Drawing.Point(834, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(706, 388);
            this.guna2GroupBox2.TabIndex = 7;
            this.guna2GroupBox2.Text = "Thông tin phiếu đặt phòng";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lưu ý: Các đơn có tình trạng là đặt trước. \r\nSẽ không được thêm vào hóa đơn.\r\nTrừ" +
    " khi cập nhật lại tình trạng đơn đặt phòng.\r\n";
            // 
            // TEXT_PHONGKHADUNG
            // 
            this.TEXT_PHONGKHADUNG.BackColor = System.Drawing.Color.Transparent;
            this.TEXT_PHONGKHADUNG.BorderColor = System.Drawing.Color.White;
            this.TEXT_PHONGKHADUNG.BorderRadius = 10;
            this.TEXT_PHONGKHADUNG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXT_PHONGKHADUNG.DefaultText = "";
            this.TEXT_PHONGKHADUNG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TEXT_PHONGKHADUNG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TEXT_PHONGKHADUNG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_PHONGKHADUNG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_PHONGKHADUNG.FillColor = System.Drawing.SystemColors.Control;
            this.TEXT_PHONGKHADUNG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_PHONGKHADUNG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TEXT_PHONGKHADUNG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_PHONGKHADUNG.Location = new System.Drawing.Point(51, 204);
            this.TEXT_PHONGKHADUNG.Name = "TEXT_PHONGKHADUNG";
            this.TEXT_PHONGKHADUNG.PasswordChar = '\0';
            this.TEXT_PHONGKHADUNG.PlaceholderText = "";
            this.TEXT_PHONGKHADUNG.ReadOnly = true;
            this.TEXT_PHONGKHADUNG.SelectedText = "";
            this.TEXT_PHONGKHADUNG.Size = new System.Drawing.Size(261, 41);
            this.TEXT_PHONGKHADUNG.TabIndex = 39;
            // 
            // BTN_CONTINUE
            // 
            this.BTN_CONTINUE.Animated = true;
            this.BTN_CONTINUE.AnimatedGIF = true;
            this.BTN_CONTINUE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CONTINUE.BorderRadius = 20;
            this.BTN_CONTINUE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CONTINUE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_CONTINUE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_CONTINUE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_CONTINUE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.BTN_CONTINUE.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONTINUE.ForeColor = System.Drawing.Color.White;
            this.BTN_CONTINUE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CONTINUE.Image")));
            this.BTN_CONTINUE.Location = new System.Drawing.Point(288, 325);
            this.BTN_CONTINUE.Name = "BTN_CONTINUE";
            this.BTN_CONTINUE.Size = new System.Drawing.Size(151, 42);
            this.BTN_CONTINUE.TabIndex = 38;
            this.BTN_CONTINUE.Text = "Tiếp tục";
            this.BTN_CONTINUE.Click += new System.EventHandler(this.BTN_CONTINUE_Click);
            // 
            // OP_STATE
            // 
            this.OP_STATE.BackColor = System.Drawing.Color.Transparent;
            this.OP_STATE.BorderColor = System.Drawing.Color.White;
            this.OP_STATE.BorderRadius = 15;
            this.OP_STATE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OP_STATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OP_STATE.FillColor = System.Drawing.SystemColors.Control;
            this.OP_STATE.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OP_STATE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OP_STATE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OP_STATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OP_STATE.ItemHeight = 30;
            this.OP_STATE.Location = new System.Drawing.Point(392, 209);
            this.OP_STATE.Name = "OP_STATE";
            this.OP_STATE.Size = new System.Drawing.Size(261, 36);
            this.OP_STATE.TabIndex = 37;
            this.OP_STATE.SelectedValueChanged += new System.EventHandler(this.OP_STATE_SelectedValueChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(392, 179);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(85, 24);
            this.guna2HtmlLabel7.TabIndex = 36;
            this.guna2HtmlLabel7.Text = "Tình trạng";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(51, 179);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(167, 24);
            this.guna2HtmlLabel6.TabIndex = 34;
            this.guna2HtmlLabel6.Text = "Mã phòng khả dụng";
            // 
            // DATE_DATPHONG
            // 
            this.DATE_DATPHONG.BackColor = System.Drawing.Color.Transparent;
            this.DATE_DATPHONG.BorderRadius = 10;
            this.DATE_DATPHONG.Checked = true;
            this.DATE_DATPHONG.FillColor = System.Drawing.SystemColors.Control;
            this.DATE_DATPHONG.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_DATPHONG.ForeColor = System.Drawing.Color.White;
            this.DATE_DATPHONG.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DATE_DATPHONG.Location = new System.Drawing.Point(392, 107);
            this.DATE_DATPHONG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DATE_DATPHONG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DATE_DATPHONG.Name = "DATE_DATPHONG";
            this.DATE_DATPHONG.Size = new System.Drawing.Size(261, 41);
            this.DATE_DATPHONG.TabIndex = 32;
            this.DATE_DATPHONG.Value = new System.DateTime(2023, 12, 6, 4, 56, 5, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(392, 77);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(75, 24);
            this.guna2HtmlLabel5.TabIndex = 31;
            this.guna2HtmlLabel5.Text = "Ngày đặt";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(51, 77);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(166, 24);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Nhân viên thực hiện";
            // 
            // TEXT_TENNV
            // 
            this.TEXT_TENNV.BackColor = System.Drawing.Color.Transparent;
            this.TEXT_TENNV.BorderColor = System.Drawing.Color.White;
            this.TEXT_TENNV.BorderRadius = 10;
            this.TEXT_TENNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXT_TENNV.DefaultText = "";
            this.TEXT_TENNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TEXT_TENNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TEXT_TENNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_TENNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TEXT_TENNV.FillColor = System.Drawing.SystemColors.Control;
            this.TEXT_TENNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_TENNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TEXT_TENNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TEXT_TENNV.Location = new System.Drawing.Point(51, 107);
            this.TEXT_TENNV.Name = "TEXT_TENNV";
            this.TEXT_TENNV.PasswordChar = '\0';
            this.TEXT_TENNV.PlaceholderText = "Tên nhân viên";
            this.TEXT_TENNV.ReadOnly = true;
            this.TEXT_TENNV.SelectedText = "";
            this.TEXT_TENNV.Size = new System.Drawing.Size(261, 41);
            this.TEXT_TENNV.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lưu ý: Các đơn có tình trạng là đặt trước. \r\nSẽ bị hủy nếu như ngày đặt nhỏ hơn n" +
    "gày hiện tại và tình trạng không được thay đổi sang đã xác nhận.\r\n";
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1552, 880);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.GR_DSPHONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatPhong";
            this.Text = "GTX - Đặt phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.GR_DSPHONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DS_PHONG)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GR_DSPHONG;
        private Guna.UI2.WinForms.Guna2DataGridView DT_DS_PHONG;
        private Guna.UI2.WinForms.Guna2TextBox FindRoom;
        private Guna.UI2.WinForms.Guna2ComboBox OP_PHONG;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button BTN_CONTINUE;
        private Guna.UI2.WinForms.Guna2ComboBox OP_STATE;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DATE_DATPHONG;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox TEXT_TENNV;
        private Guna.UI2.WinForms.Guna2TextBox TEXT_PHONGKHADUNG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}