using Microsoft.Data.SqlClient;
using System;
using System.Configuration;

namespace Inventory_Hall
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

            KeyPreview = true; // Enable key preview for the form
            KeyDown += (sender, e) => { if (e.KeyCode == Keys.Escape) Dispose(); };

        }



        //disposes the program , meaning it wont consume any resources since it is now completely closed 
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //menustrip del menu principal (del primer form)
        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //calling form ( agr_producto)
        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (agrproducto agrproducto = new agrproducto())
            {
                agrproducto.ShowDialog(); // Open the form as a modal dialog
            }
        }
        //calling form (agr_empleado)
        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.ShowDialog();// here im using ( using ) bc its the right way 

        }
        //calling form ( agr_suplidor )
        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrsuplidor agrsuplidor = new agrsuplidor();
            agrsuplidor.ShowDialog(); // here im just using showdialog to see if it works , later ill change it if it gives me any problems with the code 
        }

        // calling form ( con_producto )
        private void pRODUCTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conproducto conproducto = new conproducto();
            conproducto.ShowDialog();

        }
        //calling form ( con_empleado )
        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conempleado conempleado = new conempleado();
            conempleado.ShowDialog();
        }
        //calling form ( con_suplidor )
        private void sUPLIDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consuplidor consuplidor = new consuplidor();
            consuplidor.ShowDialog();
        }

        private void dISTRIBUCIONDECATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodistribucion prodistribucion = new prodistribucion();
            prodistribucion.ShowDialog();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sisacercade sisacercade = new sisacercade();
            sisacercade.ShowDialog();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}

