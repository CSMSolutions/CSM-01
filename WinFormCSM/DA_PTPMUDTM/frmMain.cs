using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using DTO;

namespace DA_PTPMUDTM
{
    public partial class frmMain : Form
    {
        BLL_SanPham xl = new BLL_SanPham();

        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmQuanLySanPham_Load;
        }
        public void LoadSanPham()
        {
            var danhSachSanPham = xl.LayDanhSachSanPham();
            if (danhSachSanPham != null && danhSachSanPham.Count > 0)
            {
                dataGridViewSanPham.DataSource = danhSachSanPham;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            List<DanhMuc> danhMucs = xl.LayDanhSachDanhMucSP();
            if (danhMucs != null && danhMucs.Count > 0)
            {
                comboBox1.DataSource = danhMucs;
                comboBox1.DisplayMember = "TenDanhMuc";
                comboBox1.ValueMember = "DanhMucID";
            }
            else
            {
                MessageBox.Show("Không có danh mục nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tenSanPham = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenSanPham))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm để tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ketQua = xl.TimKiemSanPhamTheoTen(tenSanPham);
            if (ketQua != null && ketQua.Count > 0)
            {
                dataGridViewSanPham.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào với tên đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            DanhMuc selectedCategory = (DanhMuc)comboBox1.SelectedItem;
            var danhSachSanPham = xl.LayDanhSachSanPhamTheoDanhMuc(selectedCategory.TenDanhMuc);

            if (danhSachSanPham == null || danhSachSanPham.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào thuộc danh mục đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSanPham();  // Load lại tất cả sản phẩm nếu không tìm thấy sản phẩm trong danh mục
            }
            else
            {
                dataGridViewSanPham.DataSource = danhSachSanPham;
            }
        }
    }
}
