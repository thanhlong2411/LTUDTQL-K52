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
    public partial class frHangHoa : Form
    {
        HangHoa_BLL HangHoa_BLL = new HangHoa_BLL();
        public frHangHoa()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void butNew_Click(object sender, EventArgs e)
        {

            txtmahang.Clear();
            txttenhh.Clear();
            txtdvt.Clear();
            txtdongia.Clear();
            txtmahang.Focus();
            txtmahang.Enabled = true;
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = HangHoa_BLL.HangHoa_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            
            HangHoa_BLL.HangHoa_Insert(txtmahang.Text, txttenhh.Text, txtdvt.Text, float.Parse(txtdongia.Text));
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            HangHoa_BLL.HangHoa_Update(txtmahang.Text, txttenhh.Text, txtdvt.Text, float.Parse(txtdongia.Text));
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                HangHoa_BLL.HangHoa_Delete(txtmahang.Text);
                butshow_Click(sender, e);
            }    
             
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtmahang.Text = data[0, dong].Value.ToString();
            txttenhh.Text = data[1, dong].Value.ToString();
            txtdvt.Text = data[2, dong].Value.ToString();
            txtdongia.Text = data[3, dong].Value.ToString();
        }
        private void Buttimkiem_Click(object sender, EventArgs e)
        {
            HangHoa_BLL.HangHoa_Select_Where(txtmahang.Text);
            
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
