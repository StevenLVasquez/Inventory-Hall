namespace Inventory_Hall
{
    partial class prodistribucion
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
            dataGridView1 = new DataGridView();
            comboBoxProductIDs = new ComboBox();
            buttonseccionupdate = new Button();
            textBoxNewSeccion = new TextBox();
            idproductoLB = new Label();
            nuevaseccionLB = new Label();
            distribuciondecategoriaLB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(21, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 250);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxProductIDs
            // 
            comboBoxProductIDs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductIDs.FormattingEnabled = true;
            comboBoxProductIDs.Location = new Point(110, 391);
            comboBoxProductIDs.Name = "comboBoxProductIDs";
            comboBoxProductIDs.Size = new Size(121, 23);
            comboBoxProductIDs.TabIndex = 1;
            // 
            // buttonseccionupdate
            // 
            buttonseccionupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonseccionupdate.Location = new Point(459, 389);
            buttonseccionupdate.Name = "buttonseccionupdate";
            buttonseccionupdate.Size = new Size(98, 35);
            buttonseccionupdate.TabIndex = 2;
            buttonseccionupdate.Text = "Actualizar";
            buttonseccionupdate.UseVisualStyleBackColor = true;
            buttonseccionupdate.Click += buttonseccionupdate_Click;
            // 
            // textBoxNewSeccion
            // 
            textBoxNewSeccion.Location = new Point(269, 391);
            textBoxNewSeccion.Name = "textBoxNewSeccion";
            textBoxNewSeccion.Size = new Size(109, 23);
            textBoxNewSeccion.TabIndex = 3;
            // 
            // idproductoLB
            // 
            idproductoLB.AutoSize = true;
            idproductoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            idproductoLB.Location = new Point(110, 362);
            idproductoLB.Name = "idproductoLB";
            idproductoLB.Size = new Size(97, 17);
            idproductoLB.TabIndex = 4;
            idproductoLB.Text = "ID PRODUCTO";
            // 
            // nuevaseccionLB
            // 
            nuevaseccionLB.AutoSize = true;
            nuevaseccionLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nuevaseccionLB.Location = new Point(269, 362);
            nuevaseccionLB.Name = "nuevaseccionLB";
            nuevaseccionLB.Size = new Size(109, 17);
            nuevaseccionLB.TabIndex = 5;
            nuevaseccionLB.Text = "NUEVA SECCION";
            // 
            // distribuciondecategoriaLB
            // 
            distribuciondecategoriaLB.AutoSize = true;
            distribuciondecategoriaLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            distribuciondecategoriaLB.Location = new Point(269, 21);
            distribuciondecategoriaLB.Name = "distribuciondecategoriaLB";
            distribuciondecategoriaLB.Size = new Size(238, 21);
            distribuciondecategoriaLB.TabIndex = 6;
            distribuciondecategoriaLB.Text = "DISTRIBUCION DE CATEGORIA";
            // 
            // prodistribucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(distribuciondecategoriaLB);
            Controls.Add(nuevaseccionLB);
            Controls.Add(idproductoLB);
            Controls.Add(textBoxNewSeccion);
            Controls.Add(buttonseccionupdate);
            Controls.Add(comboBoxProductIDs);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prodistribucion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distribucion de Categoria";
            Load += prodistribucion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxProductIDs;
        private Button buttonseccionupdate;
        private TextBox textBoxNewSeccion;
        private Label idproductoLB;
        private Label nuevaseccionLB;
        private Label distribuciondecategoriaLB;
    }
}