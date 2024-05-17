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
    public partial class frmHangHoa : Form
    {
        DataTable dt;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            txtMaHangHoa.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadHangHoa();
            dgvDanhSach.DataSource = dt;
            dgvDanhSach.Columns[0].HeaderText = "Mã Hàng Hóa";
            dgvDanhSach.Columns[1].HeaderText = "Hạn Sử Dụng";
            dgvDanhSach.Columns[2].HeaderText = "Tên Hàng Hóa";
            dgvDanhSach.Columns[3].HeaderText = "Nơi Sản Xuất";
            dgvDanhSach.Columns[4].HeaderText = "Đơn Vị Tính";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
            dgvDanhSach.Columns[4].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHangHoa.Enabled = true;
            txtMaHangHoa.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable check = new DataTable();
            string username = txtMaHangHoa.Text;
            string sql = "SELECT * FROM HANGHOA WHERE MaHangHoa = N'" + username +"'";
            check = Functions.GetDataToTable(sql);

            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(check.Rows.Count > 0)
                {
                    MessageBox.Show("Hàng Hóa Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    dt = Functions.ThemHangHoa(txtMaHangHoa.Text, txtHanSuDung.Text, txtTenHangHoa.Text, txtNoiSanXuat.Text, txtDonViTinh.Text);
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
        public void ResetValue()
        {
            txtMaHangHoa.Text = null;
            txtMaHangHoa.Enabled = false;
            txtHanSuDung.Text = null;
            txtTenHangHoa.Text = null;
            txtNoiSanXuat.Text = null;
            txtDonViTinh.Text = null;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Sửa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt = Functions.SuaHangHoa(txtMaHangHoa.Text, txtHanSuDung.Text, txtTenHangHoa.Text, txtNoiSanXuat.Text, txtDonViTinh.Text);
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
                dt = Functions.XoaHangHoa(txtMaHangHoa.Text);
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
                txtMaHangHoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            txtMaHangHoa.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHanSuDung.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtTenHangHoa.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtNoiSanXuat.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            txtDonViTinh.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
        }

        private void phiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
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
            frmHangHoa f = new frmHangHoa();
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDonBan f = new frmTimKiemHoaDonBan();
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
