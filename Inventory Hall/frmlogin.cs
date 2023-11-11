using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usuariotxt.Text == "steven" && maskedcon.Text == "0785")
            {
                DialogResult = DialogResult.OK; // Set the DialogResult to OK
                Close(); // Close the login form

            }

            else
            {
                if (usuariotxt.Text != "steven" && maskedcon.Text != "0785")
                {
                    MessageBox.Show("El usuario y la contraseña son incorrectas");
                }
                else if (usuariotxt.Text != "steven")
                {
                    MessageBox.Show("El usuario es incorrecto");
                }
                else if (maskedcon.Text != "0785")
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
        }


    }
}
