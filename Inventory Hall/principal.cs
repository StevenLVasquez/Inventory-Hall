namespace Inventory_Hall
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
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
            agrproducto agrproducto = new agrproducto();
            agrproducto.Show();


        }
        //calling form (agr_empleado)
        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.Show();
        }
        //calling form ( agr_suplidor )
        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrsuplidor agrsuplidor = new agrsuplidor();
            agrsuplidor.Show();
        }
        //calling form ( pro_distribucion de articulos)
        private void dISTRIBUCIONDEARTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodistribucion prodistribucion = new prodistribucion();
            prodistribucion.Show();
        }
        // calling form ( con_producto )
        private void pRODUCTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conproducto conproducto = new conproducto();
            conproducto.Show();

        }
        //calling form ( con_empleado )
        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conempleado conempleado = new conempleado();
            conempleado.Show();
        }
        //calling form ( con_suplidor )
        private void sUPLIDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consuplidor consuplidor = new consuplidor();   
            consuplidor.Show();
        }
    }
}

