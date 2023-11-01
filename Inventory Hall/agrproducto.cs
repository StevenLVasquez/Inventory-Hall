using Microsoft.Data.SqlClient;
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
    public partial class agrproducto : Form
    {

        public agrproducto()
        {
            InitializeComponent();
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            categoriatxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;
            suplidortxt.Enabled = true;
            secciontxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            categoriatxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            suplidortxt.BackColor = Color.White;
            secciontxt.BackColor = Color.White;


        }

        private void agrproducto_Load(object sender, EventArgs e)
        {

        }
    }
}
