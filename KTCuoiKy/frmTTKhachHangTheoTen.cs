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
    public partial class frmTTKhachHangTheoTen : Form
    {
        public List<KhachHang> khachHangs { get; set; }
        public frmTTKhachHangTheoTen(List<KhachHang> khachHangs)
        {
            InitializeComponent();
            this.khachHangs = khachHangs;
        }

        private void frmTTKhachHangTheoTen_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = khachHangs;
        }
    }
}
