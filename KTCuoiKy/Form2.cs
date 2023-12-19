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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string _10_2(int n)
        {
            string kq = "";
            while (n != 0)
            {
                kq = (n % 2).ToString() + kq;
                n = n / 2;

            }

            return kq;
        }
        public static int _2_10(int n)
        {
            int i, kq;
            i = kq = 0;
            while (n != 0)
            {
                kq = kq + (n % 10) * (int)Math.Pow(2, i);
                n = n / 10;
                i++;
            }

            return kq;
        }

        public static bool IsBinary(int n)
        {
            char[] Any = { '2', '3', '4', '5', '6', '7', '8', '9' };
            string s = n.ToString();
            if (s.IndexOfAny(Any) != -1)
                return false;
            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Program.XoaTextBox(this);
            txtSoCanChuyen.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            errorProvider1.Clear();
            if(!int.TryParse(txtSoCanChuyen.Text, out n))
            {
                errorProvider1.SetError(txtSoCanChuyen, "Vui lòng nhập đúng!");
                txtSoCanChuyen.SelectAll();
                txtSoCanChuyen.Focus();
                return;
            }
            if(n < 0)
            {
                errorProvider1.SetError(txtSoCanChuyen, "Vui lòng nhập số dương!");
                txtSoCanChuyen.SelectAll();
                txtSoCanChuyen.Focus();
                return;
            }    
            txtResult.Text = _10_2(n);
        }

        private void btn10_2_Click(object sender, EventArgs e)
        {
            int n;
            errorProvider1.Clear();
            if (!int.TryParse(txtSoCanChuyen.Text, out n))
            {
                errorProvider1.SetError(txtSoCanChuyen, "Vui lòng nhập đúng!");
                txtSoCanChuyen.SelectAll();
                txtSoCanChuyen.Focus();
                return;
            }
            if (!IsBinary(n))
            {
                errorProvider1.SetError(txtSoCanChuyen, "Vui lòng nhập đúng số thập phân (0 và 1)!");
                txtSoCanChuyen.SelectAll();
                txtSoCanChuyen.Focus();
                return;
            }
            if (n < 0)
            {
                errorProvider1.SetError(txtSoCanChuyen, "Vui lòng nhập số dương!");
                txtSoCanChuyen.SelectAll();
                txtSoCanChuyen.Focus();
                return;
            }
            txtResult.Text = _2_10(n).ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
