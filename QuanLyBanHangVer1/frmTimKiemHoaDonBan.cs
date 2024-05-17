using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangVer1
{
    public partial class frmTimKiemHoaDonBan : Form
    {
        DataTable dt, maKH;
        public frmTimKiemHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = Functions.TimKiemPhieuXuat(cbMaNCC.Text);
            dgvDanhSach.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tong = new DataTable();
            tong = Functions.TinhTongTienpPhieuXuat(cbMaNCC.Text);
            cbTongTien.DataSource = tong;
            cbTongTien.ValueMember = "tongTienNhap";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbMaNCC.Text = null;
            cbTongTien.Text = null;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
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

        private void hóaĐơnMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonMua f = new frmTraCuuHoaDonMua();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBan f = new frmTimKiemHoaDonBan();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
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

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuKhachHang f = new frmTraCuuKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadPhieuXuat();
            dgvDanhSach.DataSource = dt;
            maKH = new DataTable();
            maKH = Functions.LoadKhachHang();
            cbMaNCC.DataSource = maKH;
            cbMaNCC.ValueMember = "MaKhach";
            dgvDanhSach.Columns[0].HeaderText = "Mã Phiếu Xuất";
            dgvDanhSach.Columns[1].HeaderText = "Ngày Nhập";
            dgvDanhSach.Columns[2].HeaderText = "Thành Tiền";
            dgvDanhSach.Columns[3].HeaderText = "Mã Nhân Viên";
            dgvDanhSach.Columns[4].HeaderText = "Mã Khách Hàng";
            dgvDanhSach.Columns[5].HeaderText = "Đơn Giá";
            dgvDanhSach.Columns[6].HeaderText = "Số Lượng";
            dgvDanhSach.Columns[7].HeaderText = "Mã Hàng Hóa";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
            dgvDanhSach.Columns[4].Width = 150;
            dgvDanhSach.Columns[5].Width = 150;
            dgvDanhSach.Columns[6].Width = 150;
            dgvDanhSach.Columns[7].Width = 150;
        }
    }
}
