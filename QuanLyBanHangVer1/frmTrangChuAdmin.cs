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
    public partial class frmTrangChuAdmin : Form
    {
        private string username;
        DataTable tblNhanVien;
        DataTable tblMaChucVu;
        public frmTrangChuAdmin()
        {
            InitializeComponent();
        }
        public frmTrangChuAdmin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien form = new frmNhanVien();
            form.ShowDialog();
        }

        private void frmTrangChuAdmin_Load(object sender, EventArgs e)
        {
            Ten1.Text = $"Chào Mừng Tài Khoản {username} Quay Trở Lại";
            tblMaChucVu = new DataTable();
            tblMaChucVu = Functions.LoadDanhSachMaChucVu();
            cbMaChucVu.DataSource = tblMaChucVu;
            cbMaChucVu.ValueMember = "MaChucVu";

            btnLuu.Enabled = false;
            txtUsername.Enabled = false;

            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            tblNhanVien = new DataTable();
            tblNhanVien = Functions.LoadDanhSachAccount();
            dgvQuyenDangNhap.DataSource = tblNhanVien;
            dgvQuyenDangNhap.Columns[0].HeaderText = "Tên Đăng Nhập";
            dgvQuyenDangNhap.Columns[1].HeaderText = "Mật Khẩu";
            dgvQuyenDangNhap.Columns[2].HeaderText = "Mã Chức Vụ";

            dgvQuyenDangNhap.Columns[0].Width = 150;
            dgvQuyenDangNhap.Columns[1].Width = 150;
            dgvQuyenDangNhap.Columns[2].Width = 150;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            txtUsername.Enabled = true;
            txtUsername.Focus();
        }
        public void ResetValue()
        {
            txtUsername.Text = null;
            txtPass.Text = null;
            cbMaChucVu.Text = "0";
            btnLuu.Enabled=false;
        }

        private void dgvQuyenDangNhap_Click(object sender, EventArgs e)
        {
            txtUsername.Text = dgvQuyenDangNhap.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = dgvQuyenDangNhap.CurrentRow.Cells[1].Value.ToString();
            cbMaChucVu.Text = dgvQuyenDangNhap.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tblDangNhap = new DataTable(); 
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string jobID = cbMaChucVu.Text;
            string sql = "SELECT * FROM QUYENDANGNHAP WHERE TenDangNhap = N'" + username + "' AND MatKhau = N'" + password + "' AND MaChucVu = N'" + jobID + "'";

            tblDangNhap = Functions.GetDataToTable(sql);
            if (MessageBox.Show("Chắc Chắn Muốn Thêm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(tblDangNhap.Rows.Count > 0)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    tblNhanVien = Functions.ThemQuyenDangNhap(txtUsername.Text, txtPass.Text, cbMaChucVu.Text);
                    dgvQuyenDangNhap.DataSource = tblNhanVien;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chắc Chắn Muốn Xóa ?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblNhanVien = Functions.XoaQuyenDangNhap(txtUsername.Text);
                dgvQuyenDangNhap.DataSource = tblNhanVien;
                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue() ;
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Sửa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblNhanVien = Functions.SuaQuyenDangNhap(txtUsername.Text,txtPass.Text,cbMaChucVu.Text);
                dgvQuyenDangNhap.DataSource = tblNhanVien;
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc Chắn Muốn Hủy ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Hủy Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValue();
                txtUsername.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mnuChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu f = new frmChucVu();
            f.ShowDialog();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
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
            this.Dispose();
            this.Hide();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            frmPhieuNhap.ShowDialog();
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuNhanVien f = new frmTraCuuNhanVien();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
