using Services.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.Attribute
{
    public partial class Index : Form
    {
        private readonly AttributeServices _attributeServices;
        private int? selectedColorId = null;
        private int? selectedSizeId = null;

        public Index()
        {
            InitializeComponent();
            _attributeServices = new AttributeServices();
            LoadAttributes();
        }

        private async void LoadAttributes()
        {
            var colors = await _attributeServices.GetAllColorsAsync();
            dtGViewColor.DataSource = colors.Select(c => new
            {
                ID = c.MauId,
                Name = c.MauName
            }).ToList();
            var sizes = await _attributeServices.GetAllSizesAsync();
            dtGViewSize.DataSource = sizes.Select(s => new
            {
                ID = s.SizeId,
                Name = s.SizeName
            }).ToList();
        }
        private async void btnAddColor_Click_1(object sender, EventArgs e)
        {
            string colorName = txtColor.Text;
            if (!string.IsNullOrWhiteSpace(colorName))
            {
                await _attributeServices.AddColorAsync(colorName);
                LoadAttributes();
            }
        }

        private async void btnUpdateColor_Click(object sender, EventArgs e)
        {
            if (selectedColorId == null)
            {
                MessageBox.Show("Vui lòng chọn một màu để cập nhật.");
                return;
            }

            string newColorName = txtColor.Text;
            string currentColorName = dtGViewColor.SelectedRows[0].Cells["Name"].Value.ToString();

            if (newColorName == currentColorName)
            {
                MessageBox.Show("Tên màu không thay đổi.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(newColorName))
            {
                await _attributeServices.UpdateColorAsync(selectedColorId.Value, newColorName);
                MessageBox.Show("Cập nhật màu thành công.");
                LoadAttributes(); // Refresh lại dữ liệu
            }
            else
            {
                MessageBox.Show("Tên màu không được để trống.");
            }
        }

        private void dtGViewColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedColorId = (int)dtGViewColor.Rows[e.RowIndex].Cells["ID"].Value;
                txtColor.Text = dtGViewColor.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void dtGViewSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedSizeId = (int)dtGViewSize.Rows[e.RowIndex].Cells["ID"].Value;
                txtSize.Text = dtGViewSize.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private async void btnUpdateSize_Click(object sender, EventArgs e)
        {
            if (selectedSizeId == null)
            {
                MessageBox.Show("Vui lòng chọn một kích thước để cập nhật.");
                return;
            }

            string newSizeName = txtSize.Text;
            string currentSizeName = dtGViewSize.SelectedRows[0].Cells["Name"].Value.ToString();

            if (newSizeName == currentSizeName)
            {
                MessageBox.Show("Tên kích thước không thay đổi.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(newSizeName))
            {
                await _attributeServices.UpdateSizeAsync(selectedSizeId.Value, newSizeName);
                MessageBox.Show("Cập nhật kích thước thành công.");
                LoadAttributes();
            }
            else
            {
                MessageBox.Show("Tên kích thước không được để trống.");
            }
        }

        private async void btnAddSize_Click(object sender, EventArgs e)
        {
            string sizeName = txtSize.Text;
            if (!string.IsNullOrWhiteSpace(sizeName))
            {
                await _attributeServices.AddSizeAsync(sizeName);
                LoadAttributes();
            }
        }
    }
}
