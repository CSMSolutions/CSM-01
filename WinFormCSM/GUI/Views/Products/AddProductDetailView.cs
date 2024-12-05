using Models;
using Services.ModelViews.ProductDTO;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.Products
{
    public partial class AddProductDetailView : Form
    {
        private readonly ProductService productService;
        private SanPham? product;

        public AddProductDetailView(int productId)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Chỉ cho phép chọn file ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                // Mở hộp thoại để chọn ảnh
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn file vào TextBox (nếu cần)
                    txtImagePath.Text = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pictureBoxImage.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtImagePath.Text))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh.");
                    return;
                }

                CreateProductDetailDTO dto = new()
                {
                    SanPhamId = product.SanPhamId,
                    Size = comboBox1.SelectedItem.ToString(),
                    Mau = comboBox2.SelectedItem.ToString(),
                    Gia = Convert.ToDecimal(textBox2.Text),
                    SoLuongTonKho = Convert.ToInt32(textBox3.Text)
                };

                bool isAdded = await productService.AddProductDetail(dto, txtImagePath.Text);
                if (isAdded)
                {
                    MessageBox.Show("Thêm chi tiết sản phẩm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết sản phẩm thất bại");
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Dữ liệu đã nhập không hợp lệ");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi sao chép tệp hình ảnh. Vui lòng thử lại.");
            }
        }


        private void AddProductDetailView_Load(object sender, EventArgs e)
        {
            textBox1.Text = product?.TenSanPham;
            comboBox1.DataSource = productService.GetAllSizeName();
            comboBox2.DataSource = productService.GetAllMauName();
        }
    }
}
