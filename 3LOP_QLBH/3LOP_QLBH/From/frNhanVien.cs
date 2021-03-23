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
    public partial class frNhanVien : Form
    {
        NhanVien_BLL NhanVien_BLL = new NhanVien_BLL();

        public frNhanVien()
        {
            InitializeComponent();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtmanv.Focus();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = NhanVien_BLL.SinhVien_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            NhanVien_BLL.SinhVien_Insert(txtmanv.Text, txttennv.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
           NhanVien_BLL.SinhVien_Update(txtmanv.Text, txttennv.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                NhanVien_BLL.SinhVien_Delete(txtmanv.Text);
                butshow_Click(sender, e);
            }
        }

        private void Buttimkiem_Click(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtmanv.Text = data[0, dong].Value.ToString();
            txttennv.Text = data[1, dong].Value.ToString();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
