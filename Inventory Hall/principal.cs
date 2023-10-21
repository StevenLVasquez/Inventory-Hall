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
    }
}