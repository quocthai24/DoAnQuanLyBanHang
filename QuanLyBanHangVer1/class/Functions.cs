using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHangVer1
{
     class Functions
    {
        public static SqlConnection Conn;//tao bien ket noi database

        //phuong thuc ket noi database
        public static void Connect()
        {
            Conn = new SqlConnection();//Khoi tao doi tuong
            Conn.ConnectionString = Properties.Settings.Default.DB_Connection;//ket noi databse bang gia tri DB_Connection trong Properties Setting
            Conn.Open();//Mo ket noi
            //kiem tra ket noi
            if(Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết Nối Database Thành Công !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết Nối Database Thất Bại !!!","Thông báo");
                Conn.Open();//thu mo lai ket noi
            }
        }
        //Phuong thuc dung ket noi database
        public static void Disconnect()
        {
            if(Conn.State == ConnectionState.Open)
            {
                Conn.Close();//dong database
                Conn.Dispose();//giai phong bo nho
                Conn = null;
            }
        }
        //Phuong thuc thuc thuc thi cau lenh SELECT du lieu tu database
        public static DataTable GetDataToTable(string sql)
        {
            DataTable dt = new DataTable();//khoi tao doi tuong
            SqlDataAdapter adapter = new SqlDataAdapter(sql,Conn);
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable TimHangHoaTheoMa(string maHH)
        {
            string sql = "timHangHoaTheoMa";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maHH", maHH);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LayTenHangHoa(string maHH)
        {
            string sql = "layTenHangHoa";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maHH",maHH);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LayDonGia(string maHH)
        {
            string sql = "layDonGia";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maHH", maHH);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable TinhTongTien(string maNCC)
        {
            string sql = "tinhTongPhieuNhap2";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maNCC", maNCC);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable TinhTongTienpPhieuXuat(string maKH)
        {
            string sql = "tinhTongPhieuXuat";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maKH", maKH);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadMaNhanVien()
        {
            string sql = "layDanhSachMaNhanVien";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadMaHangHoa()
        {
            string sql = "layDanhSachMaHangHoa";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadMaNCC()
        {
            string sql = "layDanhSachMaNCC";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadNhanVien()
        {
            string sql = "layDanhSachNhanVien";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadPhieuNhap()
        {
            string sql = "layPhieuNhap";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadPhieuXuat()
        {
            string sql = "layPhieuXuat";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LayChucVuCuaNhanVien(string ma)
        {
            string sql = "layChucVuThongQuaNhanVien";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            sqlCommand.Parameters.Add("@maNV",ma);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadHangHoa()
        {
            string sql = "layDanhSachHangHoa";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadKhachHang()
        {
            string sql = "danhSachKhachHang";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable TimKiemPhieuNhap(string maNCC)
        {
            string sql = "timKiemPhieuNhap";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maNCC",maNCC);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable TimKiemPhieuXuat(string maNCC)
        {
            string sql = "timKiemPhieuXuat1";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@maKH", maNCC);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemPhieuNhap(string maPN, string ngayNhap, float tongTien, string maNV,string maNCC,float donGia,int soLuong,string maHH)
        {
            string sql = "themPhieuNhap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maPN", maPN);
            cmd.Parameters.Add("@ngayNhap", ngayNhap);
            cmd.Parameters.Add("@tongTien", tongTien);
            cmd.Parameters.Add("@maNV", maNV);
            cmd.Parameters.Add("@maNCC", maNCC);
            cmd.Parameters.Add("@donGia", donGia);
            cmd.Parameters.Add("@soLuong", soLuong);
            cmd.Parameters.Add("@maHH", maHH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemPhieuXuat(string maPN, string ngayNhap, float tongTien, string maNV, string maKH, float donGia, int soLuong, string maHH)
        {
            string sql = "themPhieuXuat";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maPX", maPN);
            cmd.Parameters.Add("@ngayNhap", ngayNhap);
            cmd.Parameters.Add("@tongTien", tongTien);
            cmd.Parameters.Add("@maNV", maNV);
            cmd.Parameters.Add("@maKH", maKH);
            cmd.Parameters.Add("@donGia", donGia);
            cmd.Parameters.Add("@soLuong", soLuong);
            cmd.Parameters.Add("@maHH", maHH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemKhach(string maKH, string sdt, string diaChi, string loaiKH)
        {
            string sql = "themKhachHang";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maKH", maKH);
            cmd.Parameters.Add("@SDT", sdt);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@loaiKhach", loaiKH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemHangHoa(string maHH, string hsd, string tenHH, string noiSX, string donViTinh)
        {
            string sql = "themHangHoa";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maHH", maHH);
            cmd.Parameters.Add("@hanSuDung", hsd);
            cmd.Parameters.Add("@tenHH", tenHH);
            cmd.Parameters.Add("@noiSanXuat", noiSX);
            cmd.Parameters.Add("@donViTinh", donViTinh);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaHangHoa(string maHH, string hsd, string tenHH, string noiSX, string donViTinh)
        {
            string sql = "suaHangHoa";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maHH", maHH);
            cmd.Parameters.Add("@hanSuDung", hsd);
            cmd.Parameters.Add("@tenHH", tenHH);
            cmd.Parameters.Add("@noiSanXuat", noiSX);
            cmd.Parameters.Add("@donViTinh", donViTinh);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaHangHoa(string maHH)
        {
            string sql = "xoaHangHoa";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maHH", maHH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaKhach(string maKH, string sdt, string diaChi, string loaiKH)
        {
            string sql = "suaKhachHang";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maKH", maKH);
            cmd.Parameters.Add("@SDT", sdt);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@loaiKhach", loaiKH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaKhach(string maKH)
        {
            string sql = "xoaKhachHang";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maKH", maKH);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadNhaCungCap()
        {
            string sql = "LayDanhSachNhaCungCap";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemNhanVien(string maNV, string maCV, string ten, string gioiTinh, string SDT,string diaChi, string ngaySinh)
        {
            string sql = "themNhanVien";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNV", maNV);
            cmd.Parameters.Add("@maChucVu", maCV);
            cmd.Parameters.Add("@tenNV", ten);
            cmd.Parameters.Add("@gioiTinh", gioiTinh);
            cmd.Parameters.Add("@sDT", SDT);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@ngaySinh", ngaySinh);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaNhanVien(string maNV, string maCV, string ten, string gioiTinh, string SDT, string diaChi, string ngaySinh)
        {
            string sql = "suaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNV", maNV);
            cmd.Parameters.Add("@maChucVu", maCV);
            cmd.Parameters.Add("@tenNV", ten);
            cmd.Parameters.Add("@gioiTinh", gioiTinh);
            cmd.Parameters.Add("@sDT", SDT);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@ngaySinh", ngaySinh);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaNhanVien(string maNV)
        {
            string sql = "xoaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNV", maNV);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaPhieuNhap(string maNV)
        {
            string sql = "xoaPhieuNhap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maPN", maNV);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaPhieuXuat(string maNV)
        {
            string sql = "xoaPhieuXuat";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maPX", maNV);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemNhaCungCap(string maNCC, string tenNCC, string diaChi,string soDienThoai,string email)
        {
            string sql = "themNhaCungCap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNhaCungCap", maNCC);
            cmd.Parameters.Add("@tenNhaCungCap", tenNCC);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@soDienThoai", soDienThoai);
            cmd.Parameters.Add("@email", email);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDienThoai, string email)
        {
            string sql = "suaNhaCungCap1";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNhaCungCap", maNCC);
            cmd.Parameters.Add("@tenNhaCungCap", tenNCC);
            cmd.Parameters.Add("@diaChi", diaChi);
            cmd.Parameters.Add("@soDienThoai", soDienThoai);
            cmd.Parameters.Add("@email", email);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaNhaCungCap(string maNCC)
        {
            string sql = "xoaNhaCungCap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maNhaCungCap", maNCC);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemChucVu(string maChucVu,string tenChucVu)
        {
            string sql = "themChucVu";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@tenChucVu", tenChucVu);
            cmd.Parameters.Add("@maChucVu", maChucVu);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaChucVu(string maChucVu,string tenChucVu)
        {
            string sql = "suaChucVu";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@tenDangNhap", tenChucVu);
            cmd.Parameters.Add("@maChucVu", maChucVu);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaChucVu(string maChucVu)
        {
            string sql = "xoaChucVu";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@maChucVu", maChucVu);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadChucVu()
        {
            string sql = "layTatCaChucVu";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable ThemQuyenDangNhap(string ten,string matKhau,string maChucVu)
        {
            string sql = "ThemQuyenDangNhap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@tenDangNhap",ten);
            cmd.Parameters.Add("@matKhau",matKhau);
            cmd.Parameters.Add("@maChucVu",maChucVu);
            data.Fill(dt);
            return dt;
        }
        public static DataTable SuaQuyenDangNhap(string ten, string matKhau, string maChucVu)
        {
            string sql = "suaQuyenDangNhap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@tenDangNhap", ten);
            cmd.Parameters.Add("@matKhau", matKhau);
            cmd.Parameters.Add("@maChucVu", maChucVu);
            data.Fill(dt);
            return dt;
        }
        public static DataTable XoaQuyenDangNhap(string ten)
        {
            string sql = "xoaQuyenDangNhap";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@tenDangNhap", ten);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadDanhSachAccount()
        {
            string sql = "LayDanhSachQuyenDangNhap";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql, Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        public static DataTable LoadDanhSachMaChucVu()
        {
            string sql = "LayDanhSachMaChucVu";
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sql,Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            data.Fill(dt);
            return dt;
        }
        //phuong thuc dinh dang ngay thang nam
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
