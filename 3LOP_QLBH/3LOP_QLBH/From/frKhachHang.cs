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

namespace _3LOP_QLBH
{
    public partial class frKhachHang : Form
    {

        KhachHang_BLL KhachHang_BLL = new KhachHang_BLL();
        public frKhachHang()
        {
            InitializeComponent();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = KhachHang_BLL.KhachHang_Select();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenhh.Clear();
            txtctkh.Clear();
            txtdiachi.Clear();
            txtmst.Clear();
            txtmakh.Focus();
            txtmakh.Enabled = true;
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            KhachHang_BLL.KhachHang_Insert(txtmakh.Text, txttenhh.Text, txtctkh.Text, txtdiachi.Text,txtmst.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            KhachHang_BLL.KhachHang_Update(txtmakh.Text, txttenhh.Text, txtctkh.Text, txtdiachi.Text, txtmst.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                KhachHang_BLL.KhachHang_Delete(txtmakh.Text);
                butshow_Click(sender, e);
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtmakh.Text = data[0, dong].Value.ToString();
            txttenhh.Text = data[1, dong].Value.ToString();
            txtctkh.Text = data[2, dong].Value.ToString();
            txtdiachi.Text = data[3, dong].Value.ToString();
            txtmst.Text = data[4, dong].Value.ToString();
        }
    }
}
