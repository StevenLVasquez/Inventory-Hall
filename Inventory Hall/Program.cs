using System;
using System.Windows.Forms;

namespace Inventory_Hall
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmlogin loginForm = new frmlogin();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK) // Assuming you close the login form with DialogResult.OK
            {
                Application.Run(new principal());
            }
        }
    }
}

