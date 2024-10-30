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
    public partial class ToolSearchAndRefresh : UserControl
    {
        public event EventHandler? FindClicked;
        public event EventHandler? RefreshClicked;
        public ToolSearchAndRefresh()
        {
            InitializeComponent();
        }

        private void btnFInd_Click(object sender, EventArgs e)
        {
            FindClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
