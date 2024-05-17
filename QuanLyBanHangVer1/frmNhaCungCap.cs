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
    public partial class frmNhaCungCap : Form
    {
        DataTable tblNhaCungCap;//tao bang du lieu nha cung cap
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            tblNhaCungCap = new DataTable();
            tblNhaCungCap = Functions.LoadNhaCungCap();
            dgvNhaCungCap.DataSource = tblNhaCungCap;
            dgvNhaCungCap.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCungCap.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhaCungCap.Columns[3].HeaderText = "Số Điện Thoại";
            dgvNhaCungCap.Columns[4].HeaderText = "Email";

            dgvNhaCungCap.Columns[0].Width = 150;
            dgvNhaCungCap.Columns[1].Width = 150;
            dgvNhaCungCap.Columns[2].Width = 150;
            dgvNhaCungCap.Columns[3].Width = 150;
            dgvNhaCungCap.Columns[4].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable check = new DataTable();
            string username = txtMaNCC.Text;
            string sql = "SELECT * FROM NHACUNGCAP WHERE MaNhaCungCap = N'" + username + "'";
            check = Functions.GetDataToTable(sql);
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(check.Rows.Count > 0)
                {
                    MessageBox.Show("Nhà Cung Cấp Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    tblNhaCungCap = Functions.ThemNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                    dgvNhaCungCap.DataSource = tblNhaCungCap;
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
            txtMaNCC.Text = null;
            txtMaNCC.Enabled = false;
            txtTenNCC.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
            txtEmail.Text = null;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Sửa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblNhaCungCap = Functions.SuaNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                dgvNhaCungCap.DataSource = tblNhaCungCap;
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
                tblNhaCungCap = Functions.XoaNhaCungCap(txtMaNCC.Text);
                dgvNhaCungCap.DataSource = tblNhaCungCap;
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
                txtMaNCC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvNhaCungCap.CurrentRow.Cells[4].Value.ToString();
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
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            frmPhieuNhap.ShowDialog();
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

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat f = new frmPhieuXuat();
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

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
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
