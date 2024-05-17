using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyBanHangVer1
{
    public partial class frmKhachHang : Form
    {
        DataTable dt = new DataTable();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;
            LoadDataGridView();
        }
        public void ResetValue()
        {
            txtMaKhach.Text = null;
            txtMaKhach.Enabled = false;
            txtDiaChi.Text = null;
            txtSoDienThoai.Text = null;
            cbLoaiKhach.Text = null;
            btnLuu.Enabled = false;
        }
        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadKhachHang();
            dgvDanhSach.DataSource = dt;
            dgvDanhSach.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvDanhSach.Columns[1].HeaderText = "Số Điện Thoại";
            dgvDanhSach.Columns[2].HeaderText = "Địa Chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Loại Khách";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable check = new DataTable();
            string username = txtMaKhach.Text;
            string sql = "SELECT * FROM KHACH WHERE MaKhach = N'" + username + "'";
            check = Functions.GetDataToTable(sql);
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (check.Rows.Count > 0)
                {
                    MessageBox.Show("Khách Hàng Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    dt = Functions.ThemKhach(txtMaKhach.Text, txtSoDienThoai.Text, txtDiaChi.Text, cbLoaiKhach.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Sửa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt = Functions.SuaKhach(txtMaKhach.Text, txtSoDienThoai.Text, txtDiaChi.Text, cbLoaiKhach.Text);
                dgvDanhSach.DataSource = dt;
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt = Functions.XoaKhach(txtMaKhach.Text);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Hủy ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Hủy Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue();
                txtMaKhach.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            txtMaKhach.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtSoDienThoai.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            cbLoaiKhach.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
        }

        private void nhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
            this.Hide();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            this.Hide();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void hóaĐơnMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonMua f = new frmTraCuuHoaDonMua();
            f.ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBan f = new frmTimKiemHoaDonBan();
            f.ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuHangHoa f = new frmTraCuuHangHoa();
            f.ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuNhaCungCap f = new frmTraCuuNhaCungCap();
            f.ShowDialog();
            this.Hide();
            this.Dispose();
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
