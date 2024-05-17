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
    public partial class frmTrangChuNhanVien : Form
    {
        private string username;
        public frmTrangChuNhanVien()
        {
            InitializeComponent();
        }
        public frmTrangChuNhanVien(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            frmPhieuNhap.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonMua f = new frmTraCuuHoaDonMua();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBan f = new frmTimKiemHoaDonBan();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat f = new frmPhieuXuat();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void frmTrangChuNhanVien_Load(object sender, EventArgs e)
        {
            label1.Text = $"Chào Mừng Tài Khoản {username} Quay Trở Lại";
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuHangHoa f = new frmTraCuuHangHoa();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuNhaCungCap f = new frmTraCuuNhaCungCap();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuKhachHang f = new frmTraCuuKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }
    }
}
