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
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Enabled = false;
            LoadDataGridView();
        }
        DataTable dt;
        DataTable hh;
        DataTable nv;
        DataTable ncc;

        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadPhieuXuat();
            dgvDanhSach.DataSource = dt;
            hh = new DataTable();
            hh = Functions.LoadMaHangHoa();
            cbMaHangHoa.DataSource = hh;
            cbMaHangHoa.ValueMember = "MaHangHoa";
            nv = new DataTable();
            nv = Functions.LoadMaNhanVien();
            cbMaNhanVien.DataSource = nv;
            cbMaNhanVien.ValueMember = "MaNhanVien";
            ncc = new DataTable();
            ncc = Functions.LoadKhachHang();
            cbMaNhaCungCap.DataSource = ncc;
            cbMaNhaCungCap.ValueMember = "MaKhach";
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


        public void ResetValue()
        {
            txtMaPhieuNhap.Text = null;
            txtMaPhieuNhap.Enabled = false;
            txtDonGia.Text = null;
            txtSoLuong.Text = null;
            txtTongTien.Text = null;
            txtThanhTien.Text = null;
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DataTable checkID = new DataTable();
            string username = txtMaPhieuNhap.Text;
            string sql = "SELECT * FROM PHIEUXUAT WHERE MaPhieuXuat = N'" + username + "'";
            checkID = Functions.GetDataToTable(sql);
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkID.Rows.Count > 0)
                {
                    MessageBox.Show("Phiếu Nhập Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    dt = Functions.ThemPhieuXuat(txtMaPhieuNhap.Text, dpNgayNhap.Text, float.Parse(txtThanhTien.Text), cbMaNhanVien.Text, cbMaNhaCungCap.Text, float.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text), cbMaHangHoa.Text);
                    dgvDanhSach.DataSource = dt;
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Enabled = true;
            txtMaPhieuNhap.Focus();
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DataTable tong = new DataTable();
            tong = Functions.TinhTongTienpPhieuXuat(cbMaNhaCungCap.Text);
            txtTongTien.DataSource = tong;
            txtTongTien.ValueMember = "tongTienNhap";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            string maHH = cbMaHangHoa.Text;
            DataTable tenHH = new DataTable();
            tenHH = Functions.LayTenHangHoa(maHH);
            txtTenHangHoa.DataSource = tenHH;
            txtTenHangHoa.ValueMember = "TenHangHoa";
            DataTable donGia = new DataTable();
            donGia = Functions.LayDonGia(maHH);
            txtDonGia.DataSource = donGia;
            txtDonGia.ValueMember = "DonViTinh";
            float donGia1 = float.Parse(txtDonGia.Text);
            float soLuong = float.Parse(txtSoLuong.Text);
            float thanhTien = donGia1 * soLuong;
            txtThanhTien.Text = thanhTien.ToString();
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
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void phiếuToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            dpNgayNhap.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtThanhTien.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            cbMaNhanVien.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            cbMaNhaCungCap.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
            cbMaHangHoa.Text = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt = Functions.XoaPhieuXuat(txtMaPhieuNhap.Text);
                dgvDanhSach.DataSource = dt;
                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuHangHoa f = new frmTraCuuHangHoa();
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

