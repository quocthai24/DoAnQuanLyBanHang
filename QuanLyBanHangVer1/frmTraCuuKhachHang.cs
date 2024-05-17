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
    public partial class frmTraCuuKhachHang : Form
    {
        DataTable dt;
        public frmTraCuuKhachHang()
        {
            InitializeComponent();
        }

        private void frmTraCuuKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (radMa.Checked)
            {
                radGT.Checked = false;

            }

            if (radGT.Checked)
            {

                radMa.Checked = false;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (radMa.Checked)
            {
                string sql = $"select * from KHACH where MaKhach = " + $" N'{txtMa.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
            if (radGT.Checked)
            {
                string sql = $"select * from KHACH where SDT =" + $" N'{txtTen.Text}'";
                dt = Functions.GetDataToTable(sql);
                dgvDanhSach.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMa.Text = null;
            txtTen.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuKhachHang f = new frmTraCuuKhachHang();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap F = new frmNhaCungCap();
            F.ShowDialog();
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

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat f =new frmPhieuXuat();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }
    }
}
