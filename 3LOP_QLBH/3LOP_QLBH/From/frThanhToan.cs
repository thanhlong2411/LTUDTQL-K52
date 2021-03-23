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

namespace _3LOP_QLBH
{
    public partial class frThanhToan : Form
    {
        SqlConnection cn;
        string ketnoi = @"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter da;
        string SQL;
        DataTable dt, CTHD;
        DataSet ds;
        public frThanhToan()
        {
            InitializeComponent();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(ketnoi); //kết nối đến dữ liệu
            SQL = "Select HoTenKH as 'Họ Tên Khách Hàng',SoHD as 'Mã HĐ',NgayHD as 'Ngày lập' ,TenNV as 'Tên Nhân Viên' from KHACHHANG inner join HOADON on KHACHHANG.MaKH=HOADON.MaKH inner join NHANVIEN on HOADON.MaNV=NHANVIEN.MaNV Where KHACHHANG.MAKH=N'" + comboBox1.SelectedValue.ToString() + "'";//lấy dữ liệu
            da = new SqlDataAdapter(SQL, cn);//chuyển đổi dữ liệu            
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            cn.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = dataGridView1.CurrentRow.Index;
            txtsoHD.Text = dataGridView1[1, dong].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1[2, dong].Value.ToString());
            cbnhanvien.Text = dataGridView1[3, dong].Value.ToString();
            cn = new SqlConnection(ketnoi); //kết nối đến dữ liệu
            SQL = " Select TenHangHoa as 'Tên Hàng Hóa', DVT as 'ĐVT', SoLuong as 'Số Lượng', DonGia as 'Đơn Giá', SoLuong*DonGia as 'Thành Tiền' from HOADON inner join CTHD on HOADON.SoHD=CTHD.SoHD inner join HANGHOA on CTHD.MaHangHoa=HANGHOA.MaHangHoa  Where HOADON.SoHD=N'" + dataGridView1[1, dong].Value.ToString() + "'";//lấy dữ liệu
            da = new SqlDataAdapter(SQL, cn);//chuyển đổi dữ liệu            
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cn.Close();
            cn.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int dong;
            dong = dataGridView2.CurrentRow.Index;
            cbhanghoa.Text = dataGridView2[0, dong].Value.ToString();
            txtdonvitinh.Text = dataGridView2[1, dong].Value.ToString();
            txtsoluong.Text = dataGridView2[2, dong].Value.ToString();
            txtdongia.Text = dataGridView2[3, dong].Value.ToString();
        }

        private void frThanhToan_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ketnoi); //kết nối đến dữ liệu
            SQL = "Select * from KHACHHANG";//lấy dữ liệu
            da = new SqlDataAdapter(SQL, cn);//chuyển đổi dữ liệu            
            dt = new DataTable();
            da.Fill(dt);


            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "HoTenKH";
            comboBox1.ValueMember = "MaKH";


            SQL = "Select * from NHANVIEN";//lấy dữ liệu
            da = new SqlDataAdapter(SQL, cn);//chuyển đổi dữ liệu            
            dt = new DataTable();
            da.Fill(dt);

            cbnhanvien.DataSource = dt;
            cbnhanvien.DisplayMember = "TenNV";
            cbnhanvien.ValueMember = "MaNV";


            SQL = "Select HoTenKH as 'Họ Tên Khách Hàng',SoHD as 'Số HĐ',NgayHD as 'Ngày lập' ,TenNV as 'Tên Nhân Viên' from KHACHHANG inner join HOADON on KHACHHANG.MaKH=HOADON.MaKH inner join NHANVIEN on HOADON.MaNV=NHANVIEN.MaNV Where KHACHHANG.MAKH=N'" + comboBox1.SelectedValue.ToString() + "'";//lấy dữ liệu
            da = new SqlDataAdapter(SQL, cn);//chuyển đổi dữ liệu            
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SQL = " Select * from HANGHOA ";
            da = new SqlDataAdapter(SQL, cn);
            dt = new DataTable();
            da.Fill(dt);

            cbhanghoa.DataSource = dt;
            cbhanghoa.DisplayMember = "TenHangHoa";
            cbhanghoa.ValueMember = "MaHangHoa";
            cbhanghoa.SelectedIndex = 0;


            cn.Close();
            cn.Dispose();
        }
    }
}
