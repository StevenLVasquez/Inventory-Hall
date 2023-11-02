namespace Inventory_Hall
{
    partial class agrproducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrproducto));
            LBnombre = new Label();
            LBcategoria = new Label();
            LBdescripcion = new Label();
            LBstock = new Label();
            LBidsuplidor = new Label();
            LBseccion = new Label();
            insertarbtn = new Button();
            guardarbtn = new Button();
            nombretxt = new TextBox();
            categoriatxt = new TextBox();
            descripciontxt = new TextBox();
            stocktxt = new TextBox();
            suplidortxt = new TextBox();
            secciontxt = new TextBox();
            SuspendLayout();
            // 
            // LBnombre
            // 
            LBnombre.AutoSize = true;
            LBnombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBnombre.Location = new Point(72, 53);
            LBnombre.Name = "LBnombre";
            LBnombre.Size = new Size(58, 17);
            LBnombre.TabIndex = 0;
            LBnombre.Text = "Nombre";
            // 
            // LBcategoria
            // 
            LBcategoria.AutoSize = true;
            LBcategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBcategoria.Location = new Point(63, 107);
            LBcategoria.Name = "LBcategoria";
            LBcategoria.Size = new Size(67, 17);
            LBcategoria.TabIndex = 1;
            LBcategoria.Text = "Categoria";
            // 
            // LBdescripcion
            // 
            LBdescripcion.AutoSize = true;
            LBdescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBdescripcion.Location = new Point(50, 166);
            LBdescripcion.Name = "LBdescripcion";
            LBdescripcion.Size = new Size(80, 17);
            LBdescripcion.TabIndex = 2;
            LBdescripcion.Text = "Descripcion";
            // 
            // LBstock
            // 
            LBstock.AutoSize = true;
            LBstock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBstock.Location = new Point(89, 216);
            LBstock.Name = "LBstock";
            LBstock.Size = new Size(41, 17);
            LBstock.TabIndex = 3;
            LBstock.Text = "Stock";
            // 
            // LBidsuplidor
            // 
            LBidsuplidor.AutoSize = true;
            LBidsuplidor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBidsuplidor.Location = new Point(52, 270);
            LBidsuplidor.Name = "LBidsuplidor";
            LBidsuplidor.Size = new Size(78, 17);
            LBidsuplidor.TabIndex = 4;
            LBidsuplidor.Text = "ID Suplidor";
            // 
            // LBseccion
            // 
            LBseccion.AutoSize = true;
            LBseccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBseccion.Location = new Point(76, 323);
            LBseccion.Name = "LBseccion";
            LBseccion.Size = new Size(54, 17);
            LBseccion.TabIndex = 5;
            LBseccion.Text = "Seccion";
            // 
            // insertarbtn
            // 
            insertarbtn.BackColor = Color.DarkTurquoise;
            insertarbtn.Cursor = Cursors.Hand;
            insertarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertarbtn.Location = new Point(139, 398);
            insertarbtn.Name = "insertarbtn";
            insertarbtn.Size = new Size(75, 23);
            insertarbtn.TabIndex = 6;
            insertarbtn.Text = "Insertar";
            insertarbtn.UseVisualStyleBackColor = false;
            insertarbtn.Click += insertarbtn_Click;
            // 
            // guardarbtn
            // 
            guardarbtn.AutoSize = true;
            guardarbtn.BackColor = Color.DarkTurquoise;
            guardarbtn.Cursor = Cursors.Hand;
            guardarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.ForeColor = SystemColors.ControlText;
            guardarbtn.Location = new Point(499, 398);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(75, 27);
            guardarbtn.TabIndex = 7;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // nombretxt
            // 
            nombretxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nombretxt.BackColor = SystemColors.ControlDark;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(170, 53);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(355, 23);
            nombretxt.TabIndex = 8;
            // 
            // categoriatxt
            // 
            categoriatxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriatxt.BackColor = SystemColors.ControlDark;
            categoriatxt.Enabled = false;
            categoriatxt.Location = new Point(170, 107);
            categoriatxt.Name = "categoriatxt";
            categoriatxt.Size = new Size(355, 23);
            categoriatxt.TabIndex = 9;
            categoriatxt.TextChanged += categoriatxt_TextChanged;
            // 
            // descripciontxt
            // 
            descripciontxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descripciontxt.BackColor = SystemColors.ControlDark;
            descripciontxt.Enabled = false;
            descripciontxt.Location = new Point(170, 160);
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(355, 23);
            descripciontxt.TabIndex = 10;
            // 
            // stocktxt
            // 
            stocktxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stocktxt.BackColor = SystemColors.ControlDark;
            stocktxt.Enabled = false;
            stocktxt.Location = new Point(170, 210);
            stocktxt.Name = "stocktxt";
            stocktxt.Size = new Size(355, 23);
            stocktxt.TabIndex = 11;
            // 
            // suplidortxt
            // 
            suplidortxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            suplidortxt.BackColor = SystemColors.ControlDark;
            suplidortxt.Enabled = false;
            suplidortxt.Location = new Point(170, 264);
            suplidortxt.Name = "suplidortxt";
            suplidortxt.Size = new Size(355, 23);
            suplidortxt.TabIndex = 12;
            // 
            // secciontxt
            // 
            secciontxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secciontxt.BackColor = SystemColors.ControlDark;
            secciontxt.Enabled = false;
            secciontxt.Location = new Point(170, 317);
            secciontxt.Name = "secciontxt";
            secciontxt.Size = new Size(355, 23);
            secciontxt.TabIndex = 13;
            // 
            // agrproducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(secciontxt);
            Controls.Add(suplidortxt);
            Controls.Add(stocktxt);
            Controls.Add(descripciontxt);
            Controls.Add(categoriatxt);
            Controls.Add(nombretxt);
            Controls.Add(guardarbtn);
            Controls.Add(insertarbtn);
            Controls.Add(LBseccion);
            Controls.Add(LBidsuplidor);
            Controls.Add(LBstock);
            Controls.Add(LBdescripcion);
            Controls.Add(LBcategoria);
            Controls.Add(LBnombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "agrproducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBnombre;
        private Label LBcategoria;
        private Label LBdescripcion;
        private Label LBstock;
        private Label LBidsuplidor;
        private Label LBseccion;
        private Button insertarbtn;
        private Button guardarbtn;
        private TextBox nombretxt;
        private TextBox categoriatxt;
        private TextBox descripciontxt;
        private TextBox stocktxt;
        private TextBox suplidortxt;
        private TextBox secciontxt;
    }
}