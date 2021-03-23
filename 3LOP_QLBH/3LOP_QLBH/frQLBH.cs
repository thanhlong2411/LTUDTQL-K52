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
    public partial class frQLBH : Form
    {
        SqlConnection cn;
        string ketnoi = @"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter da;
        string SQL;
        DataTable dt;
        DataSet ds;
        public frQLBH()
        {
            InitializeComponent();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frHangHoa frm = new frHangHoa();
            frm.ShowDialog();
        }


        private void frQLBH_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frNhanVien frm = new frNhanVien();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frKhachHang frm = new frKhachHang();
            frm.ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frThanhToan frm = new frThanhToan();
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frHoaDon frm = new frHoaDon();
            frm.ShowDialog();
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCongTy frm = new frCongTy();
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCTHD frm = new frCTHD();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cTHDHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTHD_HOADON frm = new CTHD_HOADON();
            frm.ShowDialog();
        }
    }
}
