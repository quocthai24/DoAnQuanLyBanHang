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
    public partial class frmTraCuuNhaCungCap : Form
    {
        DataTable dt;
        public frmTraCuuNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmTraCuuNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (radMa.Checked)
            {
                radGT.Checked = false;
                radTen.Checked = false;
            }
            if (radTen.Checked)
            {
                radGT.Checked = false;
                radMa.Checked = false;
            }
            if (radGT.Checked)
            {
                radTen.Checked = false;
                radMa.Checked = false;
            }
        }
        public void LoadDataGridView()
        {
            dt = new DataTable();
            dt = Functions.LoadNhaCungCap();
            dgvDanhSach.DataSource = dt;
            dgvDanhSach.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvDanhSach.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvDanhSach.Columns[2].HeaderText = "Địa Chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Số Điện Thoại";
            dgvDanhSach.Columns[4].HeaderText = "Email";

            dgvDanhSach.Columns[0].Width = 150;
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].Width = 150;
            dgvDanhSach.Columns[3].Width = 150;
            dgvDanhSach.Columns[4].Width = 150;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radMa.Checked)
            {
                string sql = $"select * from NHACUNGCAP where MaNhaCungCap = " + $" N'{txtMa.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radTen.Checked)
            {
                string sql = $"select * from NHACUNGCAP where TenNhaCungCap like" + $" N'%{txtTen.Text}%'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radGT.Checked)
            {
                string sql = $"select * from NHACUNGCAP where SDT =" + $" N'{txtNSX.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
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
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmHangHoa.ShowDialog();
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
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            frmPhieuNhap.ShowDialog();
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
            frmTimKiemHoaDonBan f =new frmTimKiemHoaDonBan();
            f.ShowDialog();
            this.Dispose();
            this.Close();
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
