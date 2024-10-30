using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public partial class SearchCustomer : UserControl
    {
        public SearchCustomer()
        {
            InitializeComponent();

            toolSearchAndRefresh1.FindClicked += ToolSearchAndRefresh1_FindClicked;
            toolSearchAndRefresh1.RefreshClicked += ToolSearchAndRefresh1_RefreshClicked;   

        }

        private void ToolSearchAndRefresh1_RefreshClicked(object? sender, EventArgs e)
        {
            MessageBox.Show("Refresh Clicked");
        }

        private void ToolSearchAndRefresh1_FindClicked(object? sender, EventArgs e)
        {
            MessageBox.Show("Find Clicked");
        }
       
    }
}
