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
    public partial class frCTHD : Form
    {
        CTHD_BLL CTHD_BLL = new CTHD_BLL();
        public frCTHD()
        {
            InitializeComponent();
        }

        private void frCTHD_Load(object sender, EventArgs e)
        {

        }

        private void butNew_Click(object sender, EventArgs e)
        {
            txtSoHD.Clear();
            txtmahh.Clear();
            txtsoluong.Clear();
            txtSoHD.Focus();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = CTHD_BLL.CTHD_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            CTHD_BLL.CTHD_Insert(txtSoHD.Text,txtmahh.Text, int.Parse(txtsoluong.Text));
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            CTHD_BLL.CTHD_Update(txtSoHD.Text,txtmahh.Text, int.Parse(txtsoluong.Text));
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                CTHD_BLL.CTHD_Delete(txtSoHD.Text);
                butshow_Click(sender, e);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtSoHD.Text = data[0, dong].Value.ToString();
            txtmahh.Text = data[1, dong].Value.ToString();
            txtsoluong.Text = data[2, dong].Value.ToString();
        }
    }
}
