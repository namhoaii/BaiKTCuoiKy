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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Program.XoaTextBox(this);
            txtHoTen.Focus();
        }

        string TachHo(string s) => s.Trim().Substring(0, s.IndexOf(' '));
        string TachTen(string s) => s.Trim().Substring(s.LastIndexOf(' ') + 1);


        private void btnThiHanh_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;

            
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ và tên!");
                txtHoTen.SelectAll();
                txtHoTen.Focus();
                return;
            }

            if (hoTen.IndexOf(' ') == -1)
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập đủ họ và tên!");
                txtHoTen.SelectAll();
                txtHoTen.Focus();
                return;
            }

            txtHo.Text = TachHo(hoTen);
            txtTen.Text = TachTen(hoTen);
        }
    }
}
