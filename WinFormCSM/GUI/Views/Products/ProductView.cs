using Services.Services;

namespace GUI.Views.Products
{
    public partial class ProductView : Form
    {
        private readonly ProductService productService;

        public ProductView()
        {
            InitializeComponent();
            productService = new ProductService();
            _ = LoadData();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        // Tải dữ liệu
        private async Task LoadData()
        {
            var data = await productService.GetAllProduct();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            if (dataGridView1.Columns["EditButton"] == null)
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Chỉnh sửa",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButtonColumn);
            }

            if (dataGridView1.Columns["ActivateButton"] == null)
            {
                DataGridViewButtonColumn activateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "ActivateButton",
                    HeaderText = "Kích hoạt",
                    Text = "Kích hoạt",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(activateButtonColumn);
            }

            dataGridView1.Columns["EditButton"].DisplayIndex = dataGridView1.Columns.Count - 1; // Đặt gần cuối
            dataGridView1.Columns["ActivateButton"].DisplayIndex = dataGridView1.Columns.Count - 2; // Đặt cuối cùng
        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý nút chỉnh sửa
            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["SanPhamId"].Value;
                EditProduct(productId); // Gọi hàm chỉnh sửa
            }

            // Xử lý nút kích hoạt
            if (e.ColumnIndex == dataGridView1.Columns["ActivateButton"].Index && e.RowIndex >= 0)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["SanPhamId"].Value;
                string currentStatus = dataGridView1.Rows[e.RowIndex].Cells["KichHoat"].Value.ToString();

                // Xác định trạng thái mới
                bool newState = currentStatus != "Đang hoạt động";

                // Gọi hàm để cập nhật trạng thái kích hoạt
                ToggleActivation(productId, newState);
            }
        }

        private void EditProduct(int productId)
        {
            UpdateProductView f = new(productId);
            f.ShowDialog();
            _ = LoadData();
        }

        private async void ToggleActivation(int productId, bool newState)
        {
            try
            {
                string newStatus = newState ? "Đang hoạt động" : "Dừng hoạt động";
                MessageBox.Show($"Đổi trạng thái sản phẩm ID: {productId} thành {newStatus}");

                await productService.UpdateProductAcivation(productId, newState);

                _ = LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            var data = await productService.Search(searchText);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            if (dataGridView1.Columns["EditButton"] == null)
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Chỉnh sửa",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButtonColumn);
            }

            if (dataGridView1.Columns["ActivateButton"] == null)
            {
                DataGridViewButtonColumn activateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "ActivateButton",
                    HeaderText = "Kích hoạt",
                    Text = "Kích hoạt",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(activateButtonColumn);
            }

            dataGridView1.Columns["EditButton"].DisplayIndex = dataGridView1.Columns.Count - 1; // Đặt gần cuối
            dataGridView1.Columns["ActivateButton"].DisplayIndex = dataGridView1.Columns.Count - 2; // Đặt cuối cùng
        }

        // Sự kiện làm mới
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _ = LoadData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddProductView f = new();
            f.ShowDialog();
            _ = LoadData();
        }
    }
}
