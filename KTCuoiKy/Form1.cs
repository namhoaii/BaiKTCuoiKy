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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string AmLich(int nam)
        {
            string[] Can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đính", "Mậu", "Kỷ" };
            string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tị", "Ngọ", "Mùi" }; 
            return Can[nam % 10] + " " + Chi[nam % 12];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int nam = (int)nmNamDuongLich.Value;
            txtNamAmLich.Text = AmLich(nam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.XoaTextBox(this);
            nmNamDuongLich.Value = 0;
            nmNamDuongLich.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
