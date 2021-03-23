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
    public partial class frCongTy : Form
    {
        CongTy_BLL CongTy_BLL = new CongTy_BLL();
        public frCongTy()
        {
            InitializeComponent();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            txtmacty.Clear();
            txttencty.Clear();
            txtsdt.Clear();
            txtfax.Clear();
            txtmst.Clear();
            txtmacty.Focus();
            txtmacty.Enabled = true;
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = CongTy_BLL.CongTy_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            CongTy_BLL.CongTy_Insert(txtmacty.Text, txttencty.Text, txtsdt.Text, txtfax.Text, txtmst.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            CongTy_BLL.CongTy_Update(txtmacty.Text, txttencty.Text, txtsdt.Text, txtfax.Text, txtmst.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                CongTy_BLL.CongTy_Delete(txtmacty.Text);
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
            txtmacty.Text = data[0, dong].Value.ToString();
            txttencty.Text = data[1, dong].Value.ToString();
            txtsdt.Text = data[2, dong].Value.ToString();
            txtfax.Text = data[3, dong].Value.ToString();
            txtmst.Text = data[4, dong].Value.ToString();
        }
    }
}
