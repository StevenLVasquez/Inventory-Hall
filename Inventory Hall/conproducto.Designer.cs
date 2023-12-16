namespace Inventory_Hall
{
    partial class conproducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conproducto));
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            buscarbtn = new Button();
            refreshbtn = new Button();
            buscarLB = new Label();
            consultadeproductoLB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(758, 287);
            dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Bottom;
            txtID.Location = new Point(126, 393);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(140, 45);
            txtID.TabIndex = 1;
            // 
            // buscarbtn
            // 
            buscarbtn.Anchor = AnchorStyles.Bottom;
            buscarbtn.AutoSize = true;
            buscarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarbtn.Location = new Point(314, 378);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(100, 48);
            buscarbtn.TabIndex = 2;
            buscarbtn.Text = "Buscar";
            buscarbtn.UseVisualStyleBackColor = true;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.Anchor = AnchorStyles.Bottom;
            refreshbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            refreshbtn.Location = new Point(453, 378);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(110, 48);
            refreshbtn.TabIndex = 3;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // buscarLB
            // 
            buscarLB.Anchor = AnchorStyles.Bottom;
            buscarLB.AutoSize = true;
            buscarLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buscarLB.Location = new Point(126, 363);
            buscarLB.Name = "buscarLB";
            buscarLB.Size = new Size(140, 15);
            buscarLB.TabIndex = 4;
            buscarLB.Text = "Inserte ID del producto.";
            // 
            // consultadeproductoLB
            // 
            consultadeproductoLB.AutoSize = true;
            consultadeproductoLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            consultadeproductoLB.Location = new Point(299, 18);
            consultadeproductoLB.Name = "consultadeproductoLB";
            consultadeproductoLB.Size = new Size(174, 21);
            consultadeproductoLB.TabIndex = 5;
            consultadeproductoLB.Text = "Consulta de Producto";
            // 
            // conproducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(consultadeproductoLB);
            Controls.Add(buscarLB);
            Controls.Add(refreshbtn);
            Controls.Add(buscarbtn);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "conproducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Producto ";
            Load += conproducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private Button buscarbtn;
        private Button refreshbtn;
        private Label buscarLB;
        private Label consultadeproductoLB;
    }
}