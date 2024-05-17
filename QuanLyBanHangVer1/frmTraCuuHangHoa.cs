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
    public partial class frmTraCuuHangHoa : Form
    {
        DataTable dt;
        public frmTraCuuHangHoa()
        {
            InitializeComponent();
        }

        private void frmTraCuuHangHoa_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (radMa.Checked)
            {
                radNSX.Checked = false;
                radTen.Checked = false;
            }
            if (radTen.Checked)
            {
                radMa.Checked = false;
                radNSX.Checked = false;
            }
            if (radNSX.Checked)
            {
                radMa.Checked = false;
                radTen.Checked= false;
            }
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
            dgvDanhSach.Columns[4].HeaderText = "Đơn Giá";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
        }

        private void radMa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radMa.Checked)
            {
                dt = Functions.TimHangHoaTheoMa(txtMa.Text);
                dgvDanhSach.DataSource = dt;
            }
            if (radTen.Checked)
            {
                string sql = $"select * from HANGHOA where TenHangHoa like "+$"N'%{txtTen.Text}%'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radNSX.Checked)
            {
                string sql = $"select * from HANGHOA where NoiSanXuat like "+$"N'%{txtNSX.Text}%'";
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap phi = new frmPhieuNhap();
            phi.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frmPhieuXuat = new frmPhieuXuat();
            frmPhieuXuat.ShowDialog();
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
            frmTraCuuHangHoa f =new frmTraCuuHangHoa();
            f.ShowDialog();
            this.Dispose(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuNhaCungCap f = new frmTraCuuNhaCungCap();
            f.ShowDialog();
            this.Dispose(); this.Close();
        }

        private void hàngHóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTraCuuHangHoa f = new frmTraCuuHangHoa();
                f.ShowDialog();
            this.Dispose(); this.Close();
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
