using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace GUI.CustomControls
{
    public partial class SearchCustomer : UserControl
    {
        public event Action<List<NguoiDung>>? OnCustomerSearchCompleted;

        public SearchCustomer()
        {
            InitializeComponent();

            toolSearchAndRefresh1.FindClicked += ToolSearchAndRefresh1_FindClicked;
            toolSearchAndRefresh1.RefreshClicked += ToolSearchAndRefresh1_RefreshClicked;

        }

        private void ToolSearchAndRefresh1_RefreshClicked(object? sender, EventArgs e)
        {
            txtNumberPhone.Clear();
            txtNameCustomer.Clear();
            OnCustomerSearchCompleted?.Invoke(new List<NguoiDung>());
        }

        private async void ToolSearchAndRefresh1_FindClicked(object? sender, EventArgs e)
        {
            string phoneNumber = txtNumberPhone.Text.Trim();
            string customerName = txtNameCustomer.Text.Trim();

            using (var context = new CSMContext())
            {
                var query = context.NguoiDungs.AsQueryable();

                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    query = query.Where(nd => nd.SoDienThoai!.Contains(phoneNumber));
                }

                if (!string.IsNullOrEmpty(customerName))
                {
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        query = query.Where(nd => nd.SoDienThoai != null && nd.SoDienThoai == phoneNumber);
                    }
                    query = query.Where(nd => nd.HoTen.Contains(customerName));
                }

                var customers = await query.ToListAsync();

                OnCustomerSearchCompleted?.Invoke(customers);

                if (customers.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào phù hợp.");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
           
        }
    }
}
