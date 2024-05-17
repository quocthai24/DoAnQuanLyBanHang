using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangVer1
{
    public partial class frmDangNhap : Form
    {
        DataTable tblDangNhap,chucVu;//tao bang du lieu quyen dang nhap
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Functions.Connect();//chay phuong thuc Connect trong class Functions
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string sql = "SELECT * FROM QUYENDANGNHAP WHERE TenDangNhap = N'"+username+ "' AND MatKhau = N'"+password+"' AND MaChucVu='0'";
            string nhanVien = "SELECT * FROM QUYENDANGNHAP WHERE TenDangNhap = N'"+username+ "' AND MatKhau = N'"+password+"' AND MaChucVu='1'";

            tblDangNhap = Functions.GetDataToTable(sql);
            chucVu = Functions.GetDataToTable(nhanVien);
            if (tblDangNhap.Rows.Count > 0)
            {
                MessageBox.Show($"Đăng Nhập ADMIN Thành Công !!!", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChuAdmin form = new frmTrangChuAdmin(username);
                form.ShowDialog();
                this.Dispose(true);
                return;
            }
            if (chucVu.Rows.Count > 0)
            {
                MessageBox.Show($"Đăng Nhập Nhân Viên Thành Công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChuNhanVien f = new frmTrangChuNhanVien(username);
                f.ShowDialog();
                this.Dispose();
                return;
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
