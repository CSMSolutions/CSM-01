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
    public partial class AddProductView : Form
    {
        private readonly ProductService productService;
        public AddProductView()
        {
            InitializeComponent();
            productService = new();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CreateProductDTO dto = new()
            {
                Name = textBox1.Text,
                Discription = textBox2.Text,
                DanhMuc = comboBox1.SelectedItem.ToString()
            };
            bool result = await productService.AddProduct(dto);
            if(result)
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                this.Close();
            } else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        private void AddProductView_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = productService.GetAllCategoryName();
        }
    }
}
