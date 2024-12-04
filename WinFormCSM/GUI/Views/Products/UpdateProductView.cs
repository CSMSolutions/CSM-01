using Models;
using Services.ModelViews.ProductDTO;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.Products
{
    public partial class UpdateProductView : Form
    {
        private readonly ProductService productService;
        private SanPham? product;

        public UpdateProductView(int productId)
        {
            InitializeComponent();
            productService = new ProductService();
            product = productService.GetProductById(productId);

            if (product == null)
            {
                MessageBox.Show($"Sản phẩm {productId} không tồn tại");
                this.Close();
                return;
            }

            dataGridView1.CellClick += dataGridView1_CellClick;
            this.Load += UpdateProductView_Load;
            _ = LoadData(productId);
        }

        private async Task LoadData(int id)
        {
            var productDetails = productService.GetProductDetailByProduct(id);

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Thêm các cột thông tin chi tiết sản phẩm
            dataGridView1.Columns.Add("SizeName", "Size");
            dataGridView1.Columns.Add("MauName", "Màu");
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns.Add("SoLuong", "Số lượng");

            // Thêm cột hình ảnh
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "ImageColumn",
                HeaderText = "Hình ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imageColumn);

            // Thêm cột "Chỉnh sửa"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Chỉnh sửa",
                Text = "Sửa",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButtonColumn);

            // Thêm cột "Kích hoạt"
            DataGridViewButtonColumn activateButtonColumn = new DataGridViewButtonColumn
            {
                Name = "ActivateButton",
                HeaderText = "Kích hoạt",
                Text = "Kích hoạt",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(activateButtonColumn);

            // Thêm dữ liệu vào các hàng
            foreach (var detail in productDetails)
            {
                var rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];

                row.Cells["SizeName"].Value = detail.SizeName;
                row.Cells["MauName"].Value = detail.MauName;
                row.Cells["DonGia"].Value = detail.DonGia;
                row.Cells["SoLuong"].Value = detail.SoLuong;

                if (System.IO.File.Exists(detail.HinhAnh))
                {
                    row.Cells["ImageColumn"].Value = Image.FromFile(detail.HinhAnh);
                }
            }
        }

        private void UpdateProductView_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin cơ bản của sản phẩm
            textBox1.Text = product?.SanPhamId.ToString();
            textBox2.Text = product?.TenSanPham;
            textBox3.Text = product?.MoTa;

            // Gán danh mục vào ComboBox
            comboBox1.DataSource = productService.GetAllCategoryName();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi nhấn vào nút "Chỉnh sửa"
            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                var detail = (ResponseProductDetail)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                MessageBox.Show($"Chỉnh sửa chi tiết sản phẩm: Màu {detail.MauName}, Size {detail.SizeName}");
                // Logic chỉnh sửa có thể được thêm tại đây
            }

            // Xử lý khi nhấn vào nút "Kích hoạt"
            if (e.ColumnIndex == dataGridView1.Columns["ActivateButton"].Index && e.RowIndex >= 0)
            {
                var detail = (ResponseProductDetail)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                MessageBox.Show($"Kích hoạt chi tiết sản phẩm: Màu {detail.MauName}, Size {detail.SizeName}");
                // Logic kích hoạt có thể được thêm tại đây
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int id = product.SanPhamId;
            UpdateProductDTO dto = new UpdateProductDTO()
            {
                Name = textBox2.Text,
                Category = comboBox1.SelectedItem.ToString(),
                Discription = textBox3.Text
            };
            bool result = await productService.UpdateProduct(id, dto);
            if(result)
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
