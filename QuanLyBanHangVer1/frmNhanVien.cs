using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangVer1
{
    public partial class frmNhanVien : Form
    {
        DataTable tblNhanVien;//tao bang du lieu nhan vien
        DataTable tblChucVu;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            tblNhanVien = new DataTable();
            tblNhanVien = Functions.LoadNhanVien();
            tblChucVu = new DataTable();
            tblChucVu = Functions.LoadChucVu();
            txtMaChucVu.DataSource = tblChucVu;
            txtMaChucVu.ValueMember = "MaChucVu";
            dgvDanhSach.DataSource = tblNhanVien;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
            btnLuu.Enabled = true;
        }

        public void ResetValue()
        {
            txtMaNhanVien.Text = null;
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Text = null;
            txtMaChucVu.Text = null;
            txtDiaChi.Text = null;
            mtxtSDT.Text = null;
            dtpNgaySinh.Text = null;
            chkNam.Checked = false;
            chkNu.Checked = false;
            btnLuu.Enabled = false;
        }

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtMaChucVu.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtTenNhanVien.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            mtxtSDT.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();

            dtpNgaySinh.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string check = "";
            if (chkNam.Checked)
            {
                check = chkNam.Text;
            }
            else
            {
                check = chkNu.Text;
            }
            if (MessageBox.Show("Chắc Chắn Muốn Sửa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblNhanVien = Functions.SuaNhanVien(txtMaNhanVien.Text, txtMaChucVu.Text,txtTenNhanVien.Text,check,mtxtSDT.Text,txtDiaChi.Text,dtpNgaySinh.Text);
                dgvDanhSach.DataSource = tblNhanVien;
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
                tblNhanVien = Functions.XoaNhanVien(txtMaNhanVien.Text);
                dgvDanhSach.DataSource = tblNhanVien;
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
                txtMaNhanVien.Enabled = false;
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
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DataTable checkID = new DataTable();
            string username = txtMaNhanVien.Text;
            string sql = "SELECT * FROM NHANVIEN WHERE MaNhanVien = N'" + username + "'";
            checkID = Functions.GetDataToTable(sql);
            string check = "";
            if (chkNam.Checked)
            {
                check = chkNam.Text;
            }
            else
            {
                check = chkNu.Text;
            }
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(txtMaChucVu.Text == null)
                {
                    MessageBox.Show("Chưa Chọn Mã Chức Vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (checkID.Rows.Count > 0)
                {
                    MessageBox.Show("Nhân Viên Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    tblNhanVien = Functions.ThemNhanVien(txtMaNhanVien.Text, txtMaChucVu.Text, txtTenNhanVien.Text, check, mtxtSDT.Text, txtDiaChi.Text, dtpNgaySinh.Text);
                    dgvDanhSach.DataSource = tblNhanVien;
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
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
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
