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

namespace DA_PTPMUDTM
{
    public partial class frmMain : Form
    {
        XuLy xl = new XuLy();

        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmQuanLySanPham_Load;
        }
        public void LoadSanPham()
        {
            dataGridViewSanPham.DataSource = xl.GetDanhSachSanPham();
        }
        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            List<DanhMuc> danhMucs = xl.GetDanhSachDanhMucSP();
            comboBox1.DataSource = danhMucs;
            comboBox1.DisplayMember = "TenDanhMuc";
            comboBox1.ValueMember = "DanhMucID";
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
            if(ketQua != null && ketQua.Count > 0)
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
            List<SanPham> danhSachSanPham = xl.GetDanhSachSanPhamTheoDanhMuc(selectedCategory.TenDanhMuc);
            if (danhSachSanPham == null || danhSachSanPham.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào thuộc danh mục đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSanPham();
            }
            else
            {
                dataGridViewSanPham.DataSource = danhSachSanPham;
            }
        }
    }
}
