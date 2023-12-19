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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbLoai.SelectedIndex = 0;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string maKH = txtMKH.Text;
            string tenKH = txtTenKH.Text;
            string diaChi = txtDiaChi.Text;
            bool isValidate = true;

            string loai = cmbLoai.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maKH))
            {
                errorProvider1.SetError(txtMKH, "Không được bỏ trống");
                isValidate = false;
            }
            if (string.IsNullOrEmpty(tenKH))
            {
                errorProvider1.SetError(txtTenKH, "Không được bỏ trống");
                isValidate = false;
            }
            if (string.IsNullOrEmpty(diaChi))
            {
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống");
                isValidate = false;
            }
            if (!isValidate)
                return;

            KhachHang kh = KhachHang.khachHangs.FirstOrDefault(m => m.MaKH == maKH);
            if(kh != null)
            {
                MessageBox.Show($"{maKH} đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKH.SelectAll();
                txtMKH.Focus();
                return;
            }

            KhachHang khachHang = new KhachHang(maKH, tenKH, diaChi, loai);

            KhachHang.khachHangs.Add(khachHang);

            int soLuong = KhachHang.khachHangs.Count;

            txtSoLuong.Text = soLuong.ToString();

            //reset
            txtMKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cmbLoai.SelectedIndex = 0;
            txtMKH.Focus();

            if (soLuong > 0)
                dataGridView1.DataSource = KhachHang.khachHangs;

            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = KhachHang.khachHangs; 
            dataGridView1.Refresh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ten = txtTenKH.Text;
            if (string.IsNullOrEmpty(ten))
            {
                errorProvider1.SetError(txtTenKH, "Vui lòng nhập tên để tìm kiếm");
                txtTenKH.SelectAll();
                txtTenKH.Focus();
            }
            var result = KhachHang.khachHangs.Where(m => m.TenKH == ten).ToList();
            if(result.Count > 0)
                (new frmTTKhachHangTheoTen(result)).ShowDialog();
            else
            {
                MessageBox.Show("Không tìm thấy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maKh = txtMKH.Text;
            if (string.IsNullOrEmpty(maKh))
            {
                errorProvider1.SetError(txtMKH, "Vui lòng nhập mã Xóa");
                txtMKH.SelectAll();
                txtMKH.Focus();
            }
            KhachHang khachHang = KhachHang.khachHangs.FirstOrDefault(m => m.MaKH == maKh);
            if(khachHang == null)
            {
                MessageBox.Show($"Không tìm thấy KH có mã {maKh}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show( $"Xóa thành công KH có mã {maKh}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KhachHang.khachHangs.Remove(khachHang);

                txtSoLuong.Text = KhachHang.khachHangs.Count.ToString();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = KhachHang.khachHangs;
                dataGridView1.Refresh();
                return;
            }
        }
    }
}
