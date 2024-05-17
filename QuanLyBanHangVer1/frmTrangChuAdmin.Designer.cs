namespace QuanLyBanHangVer1
{
    partial class frmTrangChuAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnMuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ten1 = new System.Windows.Forms.Label();
            this.Ten = new System.Windows.Forms.Label();
            this.cbMaChucVu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuyenDangNhap = new System.Windows.Forms.DataGridView();
            this.kháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.nhậpPhiếuToolStripMenuItem,
            this.traCứuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuNhaCungCap,
            this.mnuChucVu,
            this.kháchHàngToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(229, 34);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(229, 34);
            this.mnuNhaCungCap.Text = "Nhà Cung Cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuChucVu
            // 
            this.mnuChucVu.Name = "mnuChucVu";
            this.mnuChucVu.Size = new System.Drawing.Size(229, 34);
            this.mnuChucVu.Text = "Chức Vụ";
            this.mnuChucVu.Click += new System.EventHandler(this.mnuChucVu_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // nhậpPhiếuToolStripMenuItem
            // 
            this.nhậpPhiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpToolStripMenuItem,
            this.phiếuXuấtToolStripMenuItem});
            this.nhậpPhiếuToolStripMenuItem.Name = "nhậpPhiếuToolStripMenuItem";
            this.nhậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.nhậpPhiếuToolStripMenuItem.Text = "Nhập Phiếu";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu Nhập";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // phiếuXuấtToolStripMenuItem
            // 
            this.phiếuXuấtToolStripMenuItem.Name = "phiếuXuấtToolStripMenuItem";
            this.phiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.phiếuXuấtToolStripMenuItem.Text = "Phiếu Xuất";
            this.phiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtToolStripMenuItem_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnMuaToolStripMenuItem,
            this.hóaĐơnBánToolStripMenuItem,
            this.hàngHóaToolStripMenuItem1,
            this.nhânViênToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.kháchHàngToolStripMenuItem1});
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu";
            // 
            // hóaĐơnMuaToolStripMenuItem
            // 
            this.hóaĐơnMuaToolStripMenuItem.Name = "hóaĐơnMuaToolStripMenuItem";
            this.hóaĐơnMuaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hóaĐơnMuaToolStripMenuItem.Text = "Hóa Đơn Mua";
            this.hóaĐơnMuaToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnMuaToolStripMenuItem_Click);
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa Đơn Bán";
            this.hóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem1
            // 
            this.hàngHóaToolStripMenuItem1.Name = "hàngHóaToolStripMenuItem1";
            this.hàngHóaToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.hàngHóaToolStripMenuItem1.Text = "Hàng Hóa";
            this.hàngHóaToolStripMenuItem1.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem1_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 122);
            this.panel1.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(844, 33);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(158, 56);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(635, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 56);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(426, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(158, 56);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 56);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(217, 33);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(158, 56);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-201, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 56);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Ten1);
            this.panel2.Controls.Add(this.Ten);
            this.panel2.Controls.Add(this.cbMaChucVu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 178);
            this.panel2.TabIndex = 3;
            // 
            // Ten1
            // 
            this.Ten1.AutoSize = true;
            this.Ten1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Ten1.ForeColor = System.Drawing.Color.Red;
            this.Ten1.Location = new System.Drawing.Point(22, 70);
            this.Ten1.Name = "Ten1";
            this.Ten1.Size = new System.Drawing.Size(177, 26);
            this.Ten1.TabIndex = 20;
            this.Ten1.Text = "Tên Đăng Nhập";
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Location = new System.Drawing.Point(22, 70);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(0, 20);
            this.Ten.TabIndex = 19;
            // 
            // cbMaChucVu
            // 
            this.cbMaChucVu.FormattingEnabled = true;
            this.cbMaChucVu.Location = new System.Drawing.Point(798, 132);
            this.cbMaChucVu.Name = "cbMaChucVu";
            this.cbMaChucVu.Size = new System.Drawing.Size(186, 28);
            this.cbMaChucVu.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Chức Vụ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(459, 132);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(203, 26);
            this.txtPass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 129);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 26);
            this.txtUsername.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(353, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Tài Khoản";
            // 
            // dgvQuyenDangNhap
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuyenDangNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuyenDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuyenDangNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuyenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuyenDangNhap.Location = new System.Drawing.Point(0, 211);
            this.dgvQuyenDangNhap.Name = "dgvQuyenDangNhap";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuyenDangNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuyenDangNhap.RowHeadersWidth = 62;
            this.dgvQuyenDangNhap.RowTemplate.Height = 28;
            this.dgvQuyenDangNhap.Size = new System.Drawing.Size(1012, 245);
            this.dgvQuyenDangNhap.TabIndex = 4;
            this.dgvQuyenDangNhap.Click += new System.EventHandler(this.dgvQuyenDangNhap_Click);
            // 
            // kháchHàngToolStripMenuItem1
            // 
            this.kháchHàngToolStripMenuItem1.Name = "kháchHàngToolStripMenuItem1";
            this.kháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.kháchHàngToolStripMenuItem1.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem1.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem1_Click);
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 578);
            this.Controls.Add(this.dgvQuyenDangNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChuAdmin";
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChuAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ComboBox cbMaChucVu;
        private System.Windows.Forms.DataGridView dgvQuyenDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuChucVu;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Label Ten1;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnMuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem1;
    }
}