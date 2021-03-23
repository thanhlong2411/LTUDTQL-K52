using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_BLL;
using System.Data.SqlClient;

namespace _3LOP_QLBH
{


    public partial class CTHD_HOADON : Form
    {
        int dongCTHD;
        //int dthdRowIndex;
        DataTable CTHD = new DataTable();
        double thanhtien;
        HoaDon_BLL HoaDon_BLL = new HoaDon_BLL();
        CTHD_BLL CTHD_BLL = new CTHD_BLL();
        KhachHang_BLL KhachHang_BLL = new KhachHang_BLL();
        NhanVien_BLL nhanVien_BLL = new NhanVien_BLL();
        HangHoa_BLL hangHoa_BLL = new HangHoa_BLL();
        
        public CTHD_HOADON()
        {
            InitializeComponent();
            
        }

        private void CTHD_HOADON_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = KhachHang_BLL.KhachHang_Select();
            comboBox1.DisplayMember = "HoTenKH";
            comboBox1.ValueMember = "MaKH";

            cbnhanvien.DataSource = nhanVien_BLL.SinhVien_Select();
            cbnhanvien.DisplayMember = "TenNV";
            cbnhanvien.ValueMember = "MaNV";

            cbhanghoa.DataSource = hangHoa_BLL.HangHoa_Select();
            cbhanghoa.DisplayMember = "TenHangHoa";
            cbhanghoa.ValueMember = "MaHangHoa";

            datahoadon.DataSource = HoaDon_BLL.HoaDon_SelectPROVIP();

            CTHD = new DataTable();
            CTHD.Columns.Add("Mã Hàng", typeof(string));
            CTHD.Columns.Add("Tên Hàng Hóa", typeof(string));
            CTHD.Columns.Add("ĐVT", typeof(string));
            CTHD.Columns.Add("Đơn Giá", typeof(string));
            CTHD.Columns.Add("Số Lượng", typeof(string));
            CTHD.Columns.Add("Thành Tiền", typeof(string));
            dataCTHD.DataSource = CTHD;
        }
            
        private void datahoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = datahoadon.CurrentRow.Index;
            txtsoHD.Text = datahoadon[1, dong].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(datahoadon[2, dong].Value.ToString());
            cbnhanvien.Text = datahoadon[3, dong].Value.ToString();
            dataCTHD.DataSource = CTHD_BLL.CTHD_Select_Where(txtsoHD.Text);

        }

        private void dataCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = dataCTHD.CurrentRow.Index;
            cbhanghoa.Text = dataCTHD[1, dong].Value.ToString();
            txtdonvitinh.Text = dataCTHD[2, dong].Value.ToString();
            txtsoluong.Text = dataCTHD[3, dong].Value.ToString();
            txtdongia.Text = dataCTHD[4, dong].Value.ToString();

        }

        private void dataCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongCTHD = e.RowIndex;
            cbhanghoa.Text = dataCTHD[1, dongCTHD].Value.ToString();
            txtdonvitinh.Text = dataCTHD[2, dongCTHD].Value.ToString();
            txtdongia.Text = dataCTHD[4, dongCTHD].Value.ToString();
            txtsoluong.Text = dataCTHD[3, dongCTHD].Value.ToString();

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (DataRow dr in CTHD.Rows)
            {
                if(dr[0].ToString()==cbhanghoa.SelectedValue.ToString())
                {
                    string MaHang = ((DataRowView)cbhanghoa.SelectedItem)[0].ToString();
                    string TenHangHoa = ((DataRowView)cbhanghoa.SelectedItem)[1].ToString();
                    int SL = int.Parse(txtsoluong.Text) + int.Parse(dr[4].ToString());
                    thanhtien = SL * float.Parse(dr[3].ToString());
                    dr.Delete();
                    CTHD.Rows.Add(MaHang,TenHangHoa,txtdonvitinh.Text, SL, float.Parse(txtdongia.Text), thanhtien);
                    dataCTHD.DataSource = CTHD;
                    break;
                }
                i++;
            }
            if (i > CTHD.Rows.Count)
            {
                string MaHang = ((DataRowView)cbhanghoa.SelectedItem)[0].ToString();
                string TenHangHoa = ((DataRowView)cbhanghoa.SelectedItem)[1].ToString();
                thanhtien = float.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text);
                CTHD.Rows.Add(MaHang,TenHangHoa, txtdonvitinh.Text, int.Parse(txtsoluong.Text), float.Parse(txtdongia.Text), thanhtien);
                dataCTHD.DataSource = CTHD;
            }                

        }

        private void butsua_Click(object sender, EventArgs e)
        {

            DataGridViewRow newRow = dataCTHD.Rows[dongCTHD];
            string MaHang = ((DataRowView)cbhanghoa.SelectedItem)[0].ToString();
            string TenHangHoa = ((DataRowView)cbhanghoa.SelectedItem)[1].ToString();
            newRow.Cells[0].Value = MaHang;
            newRow.Cells[1].Value = TenHangHoa;
            newRow.Cells[2].Value = txtdonvitinh.Text;
            newRow.Cells[4].Value = txtsoluong.Text;
            newRow.Cells[3].Value = txtdongia.Text;
            newRow.Cells[5].Value = float.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text);

        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            dataCTHD.Rows.RemoveAt(dongCTHD);
        }

        private void cbhanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtdonvitinh.Text = ((DataRowView)cbhanghoa.SelectedItem)[2].ToString();
            txtdongia.Text = ((DataRowView)cbhanghoa.SelectedItem)[3].ToString();
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            txtsoHD.Enabled = true;
            butluuHD.Enabled = true;
        }     

        private void butluuHD_Click(object sender, EventArgs e)
        {
            
            var HoaDon_BLL = new HoaDon_BLL();
            string MaKH = comboBox1.SelectedValue.ToString();
            string MaNV = cbnhanvien.SelectedValue.ToString();
  
            datahoadon.DataSource = HoaDon_BLL.HoaDon_Insert(txtsoHD.Text, MaKH, MaNV, DateTime.Parse(dateTimePicker1.Value.ToString()),"Khó Quá","Tiền Mặt");
            datahoadon.DataSource = HoaDon_BLL.HoaDon_Select_Where(txtsoHD.Text);


            foreach (DataRow dr in CTHD.Rows)
            {
                var CTHD_BLL = new CTHD_BLL();
                dataCTHD.DataSource = CTHD_BLL.CTHD_Insert(txtsoHD.Text,dr[0].ToString(), int.Parse(txtsoluong.Text));
                dataCTHD.DataSource = CTHD_BLL.CTHD_Select_Where(txtsoHD.Text);
            }
            CTHD.Clear(); 
            CTHD_HOADON_Load(sender, e);
        }   

        private void butcapnhapHD_Click(object sender, EventArgs e)
        {
            var HoaDon_BLL = new HoaDon_BLL();
            string MaKH = comboBox1.SelectedValue.ToString();
            string MaNV = cbnhanvien.SelectedValue.ToString();

            datahoadon.DataSource = HoaDon_BLL.HoaDon_Update(txtsoHD.Text, MaKH, MaNV, DateTime.Parse(dateTimePicker1.Value.ToString()), "Khó Quá", "Tiền Mặt");
            datahoadon.DataSource = HoaDon_BLL.HoaDon_SelectPROVIP();
            txtsoHD.Enabled = false;

            foreach (DataRow dr in CTHD.Rows)
            {
                var CTHD_BLL = new CTHD_BLL();
                dataCTHD.DataSource = CTHD_BLL.CTHD_Update(txtsoHD.Text, dr[0].ToString(), int.Parse(txtsoluong.Text));
                dataCTHD.DataSource = CTHD_BLL.CTHD_SelectPROVIP();
            }

            foreach (DataRow dr in CTHD.Rows)
            {
                var CTHD_BLL = new CTHD_BLL();
                dataCTHD.DataSource = CTHD_BLL.CTHD_Delete(dr[0].ToString());
                dataCTHD.DataSource = CTHD_BLL.CTHD_SelectPROVIP();
            }
            CTHD.Clear();
            CTHD_HOADON_Load(sender, e);
        }

        private void butxoahd_Click(object sender, EventArgs e)
        {
            var HoaDon_BLL = new HoaDon_BLL();
            HoaDon_BLL.HoaDon_Delete(txtsoHD.Text);

            foreach (DataRow dr in CTHD.Rows)
            {
                var CTHD_BLL = new CTHD_BLL();
                dataCTHD.DataSource = CTHD_BLL.CTHD_Delete(dr[0].ToString());
                dataCTHD.DataSource = CTHD_BLL.CTHD_SelectPROVIP();
            }
            CTHD.Clear();
            CTHD_HOADON_Load(sender, e);
        }
    }
}
