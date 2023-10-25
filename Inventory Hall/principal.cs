namespace Inventory_Hall
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrproducto agrproducto = new agrproducto();
            agrproducto.Show();


        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.Show();
        }

        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrsuplidor agrsuplidor = new agrsuplidor();
            agrsuplidor.Show();
        }

        private void dISTRIBUCIONDEARTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodistribucion prodistribucion = new prodistribucion();
            prodistribucion.Show();
        }
    }
}

//k