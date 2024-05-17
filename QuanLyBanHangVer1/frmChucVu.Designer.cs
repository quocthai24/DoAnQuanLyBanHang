namespace QuanLyBanHangVer1
{
    partial class frmChucVu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnMuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvChucVu = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.kháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.dgvChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenChucVu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaChucVu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 155);
            this.panel2.TabIndex = 7;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(773, 73);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(203, 26);
            this.txtTenChucVu.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(126, 73);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(203, 26);
            this.txtMaChucVu.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Chức Vụ";
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
            this.menuStrip1.Size = new System.Drawing.Size(1180, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.nhàCungCấpToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
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
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
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
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.thoátToolStripMenuItem.Text = "Thoát";
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
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnMuaToolStripMenuItem,
            this.hóaĐơnBánToolStripMenuItem,
            this.hàngHóaToolStripMenuItem1,
            this.nhàCungCấpToolStripMenuItem1,
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
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa Đơn Bán";
            // 
            // hàngHóaToolStripMenuItem1
            // 
            this.hàngHóaToolStripMenuItem1.Name = "hàngHóaToolStripMenuItem1";
            this.hàngHóaToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.hàngHóaToolStripMenuItem1.Text = "Hàng Hóa";
            this.hàngHóaToolStripMenuItem1.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem1_Click);
            // 
            // nhàCungCấpToolStripMenuItem1
            // 
            this.nhàCungCấpToolStripMenuItem1.Name = "nhàCungCấpToolStripMenuItem1";
            this.nhàCungCấpToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.nhàCungCấpToolStripMenuItem1.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem1.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 56);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            // dgvChucVu
            // 
            this.dgvChucVu.Controls.Add(this.btnHuy);
            this.dgvChucVu.Controls.Add(this.btnXoa);
            this.dgvChucVu.Controls.Add(this.btnSua);
            this.dgvChucVu.Controls.Add(this.btnThem);
            this.dgvChucVu.Controls.Add(this.btnLuu);
            this.dgvChucVu.Controls.Add(this.btnClose);
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChucVu.Location = new System.Drawing.Point(0, 464);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(1180, 122);
            this.dgvChucVu.TabIndex = 6;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvCV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCV.Location = new System.Drawing.Point(0, 188);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.RowHeadersWidth = 62;
            this.dgvCV.RowTemplate.Height = 28;
            this.dgvCV.Size = new System.Drawing.Size(1180, 276);
            this.dgvCV.TabIndex = 8;
            this.dgvCV.Click += new System.EventHandler(this.dgvCV_Click);
            // 
            // kháchHàngToolStripMenuItem1
            // 
            this.kháchHàngToolStripMenuItem1.Name = "kháchHàngToolStripMenuItem1";
            this.kháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.kháchHàngToolStripMenuItem1.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem1.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem1_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 586);
            this.Controls.Add(this.dgvCV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvChucVu);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dgvChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLuu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.Panel dgvChucVu;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnMuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem1;
    }
}