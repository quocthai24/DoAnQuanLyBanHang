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
    public partial class frmChucVu : Form
    {
        DataTable tblNhanVien;
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaChucVu.Enabled = false;

            LoadDataGridView();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            txtMaChucVu.Enabled = true;
            txtMaChucVu.Focus();
        }
        public void ResetValue()
        {
            txtMaChucVu.Text = null;
            txtTenChucVu.Text = null;
            btnLuu.Enabled=false;
        }
        public void LoadDataGridView()
        {
            tblNhanVien = new DataTable();
            tblNhanVien = Functions.LoadChucVu();
            dgvCV.DataSource = tblNhanVien;
            dgvCV.Columns[0].HeaderText = "Mã Chức Vụ";
            dgvCV.Columns[1].HeaderText = "Tên Chức Vụ";

            dgvCV.Columns[0].Width = 150;
            dgvCV.Columns[1].Width = 150;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable check = new DataTable();
            string username = txtMaChucVu.Text;
            string sql = "SELECT * FROM CHUCVU WHERE MaChucVu = N'" + username + "'";
            check = Functions.GetDataToTable(sql);
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (check.Rows.Count > 0)
                {
                    MessageBox.Show("Chức Vụ Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    tblNhanVien = Functions.ThemChucVu(txtMaChucVu.Text, txtTenChucVu.Text);
                    dgvCV.DataSource = tblNhanVien;
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
                tblNhanVien = Functions.SuaChucVu(txtMaChucVu.Text, txtTenChucVu.Text);
                dgvCV.DataSource = tblNhanVien;
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
                tblNhanVien = Functions.XoaChucVu(txtMaChucVu.Text);
                dgvCV.DataSource = tblNhanVien;
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
                txtMaChucVu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            txtMaChucVu.Enabled = true;
            txtMaChucVu.Focus();
        }

        private void dgvCV_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Text = dgvCV.CurrentRow.Cells[0].Value.ToString();
            txtTenChucVu.Text = dgvCV.CurrentRow.Cells[1].Value.ToString();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
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
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
            this.Hide();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
            this.Hide();
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
