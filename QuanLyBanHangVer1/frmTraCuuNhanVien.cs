using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangVer1
{
    public partial class frmTraCuuNhanVien : Form
    {
        DataTable dt;
        public frmTraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void frmTraCuuNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (radMa.Checked)
            {
                radGT.Checked = false;
                radTen.Checked = false;
            }
            if(radTen.Checked)
            {
                radGT.Checked = false;
                radMa.Checked = false;
            }
            if (radGT.Checked)
            {
                radTen.Checked = false;
                radMa.Checked = false;
            }
        }
        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadNhanVien();
            dgvDanhSach.DataSource = dt;
            dgvDanhSach.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvDanhSach.Columns[1].HeaderText = "Mã Chức Vụ";
            dgvDanhSach.Columns[2].HeaderText = "Tên Nhân Viên";
            dgvDanhSach.Columns[3].HeaderText = "Giới Tính";
            dgvDanhSach.Columns[4].HeaderText = "Số Điện Thoại";
            dgvDanhSach.Columns[5].HeaderText = "Địa Chỉ";
            dgvDanhSach.Columns[6].HeaderText = "Ngày Sinh";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
            dgvDanhSach.Columns[4].Width = 150;
            dgvDanhSach.Columns[5].Width = 150;
            dgvDanhSach.Columns[6].Width = 150;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radMa.Checked)
            {
                string sql = $"select * from NHANVIEN where MaNhanVien = "+$" N'{txtMa.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radTen.Checked)
            {
                string sql = $"select * from NHANVIEN where TenNhanVien like"+$" N'%{txtTen.Text}%'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radGT.Checked)
            {
                string sql = $"select * from NHANVIEN where GioiTinh ="+$" N'{txtNSX.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMa.Text = null;
            txtNSX.Text = null;
            txtTen.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat f = new frmPhieuXuat();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void hóaĐơnMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonMua f = new frmTraCuuHoaDonMua();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBan f = new frmTimKiemHoaDonBan();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuHangHoa f = new frmTraCuuHangHoa();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuNhaCungCap f = new frmTraCuuNhaCungCap();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuKhachHang f = new frmTraCuuKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }
    }
}
