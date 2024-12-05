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

namespace GUI.Views.Category
{
    public partial class CategoryView : Form
    {
        public readonly CategoryService service;
        public CategoryView()
        {
            InitializeComponent();
            service = new();
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            textBox1.Text = "";
            dataGridView1.DataSource = service.GetAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = textBox2.Text;
                service.Add(ten);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Search(textBox1.Text);
        }
    }
}
