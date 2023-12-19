using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTCuoiKy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đổiNămDươngLịchSangÂmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void đổiSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void táchHọTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void khácHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void frmMain_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
