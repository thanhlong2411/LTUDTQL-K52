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
    public partial class frHoaDon : Form
    {
        HoaDon_BLL HoaDon_BLL = new HoaDon_BLL();
        public frHoaDon()
        {
            InitializeComponent();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            txtSoHD.Clear();
            txtmakh.Clear();
            txtmanv.Clear();
            txthttt.Clear();
            txtmacty.Clear();
            txtSoHD.Focus();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = HoaDon_BLL.HoaDon_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            HoaDon_BLL.HoaDon_Insert(txtSoHD.Text, txtmakh.Text, txtmanv.Text, DateTime.Parse(timengaylap.Value.ToString()), txtmacty.Text,txthttt.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            HoaDon_BLL.HoaDon_Update(txtSoHD.Text, txtmakh.Text, txtmanv.Text, DateTime.Parse(timengaylap.Value.ToString()), txtmacty.Text, txthttt.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                HoaDon_BLL.HoaDon_Delete(txtSoHD.Text);
                butshow_Click(sender, e);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtSoHD.Text = data[0, dong].Value.ToString();
            txtmakh.Text = data[3, dong].Value.ToString();
            txtmanv.Text = data[4, dong].Value.ToString();
            timengaylap.Value = DateTime.Parse(data[1, dong].Value.ToString());
            txtmacty.Text = data[5, dong].Value.ToString();
            txthttt.Text = data[2, dong].Value.ToString();
        }
    }
}
