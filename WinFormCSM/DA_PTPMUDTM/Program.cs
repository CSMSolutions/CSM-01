using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTPMUDTM
{
    internal static class Program
    {
        public static frmDangNhap _frmDangNhap = null;
        public static frmMain _frmMain = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _frmDangNhap = new frmDangNhap();
            Application.Run(_frmDangNhap);
        }
    }
}
