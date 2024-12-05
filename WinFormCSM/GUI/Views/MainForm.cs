using GUI.Views.Category;
using GUI.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class MainForm : Form
    {
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new DonHang.Index(), null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductView(), null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistical.index(), null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Attribute.Index(), null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryView(), null);
        }
    }
}
