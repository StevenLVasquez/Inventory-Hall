namespace Inventory_Hall
{
    partial class agrsuplidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrsuplidor));
            nombreLB = new Label();
            rncLB = new Label();
            direccionLB = new Label();
            emailLB = new Label();
            telefonoLB = new Label();
            descripcionLB = new Label();
            nombretxt = new TextBox();
            direcciontxt = new TextBox();
            emailtxt = new TextBox();
            descripciontxt = new TextBox();
            insertarbtn = new Button();
            guardarbtn = new Button();
            telefonotxt = new MaskedTextBox();
            rnctxt = new MaskedTextBox();
            entradadesuplidorLB = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nombreLB
            // 
            nombreLB.AutoSize = true;
            nombreLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nombreLB.Location = new Point(14, 127);
            nombreLB.Name = "nombreLB";
            nombreLB.Size = new Size(58, 17);
            nombreLB.TabIndex = 0;
            nombreLB.Text = "Nombre";
            // 
            // rncLB
            // 
            rncLB.AutoSize = true;
            rncLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rncLB.Location = new Point(38, 171);
            rncLB.Name = "rncLB";
            rncLB.Size = new Size(34, 17);
            rncLB.TabIndex = 1;
            rncLB.Text = "RNC";
            // 
            // direccionLB
            // 
            direccionLB.AutoSize = true;
            direccionLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            direccionLB.Location = new Point(6, 229);
            direccionLB.Name = "direccionLB";
            direccionLB.Size = new Size(66, 17);
            direccionLB.TabIndex = 2;
            direccionLB.Text = "Direccion";
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailLB.Location = new Point(414, 122);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(42, 17);
            emailLB.TabIndex = 3;
            emailLB.Text = "Email";
            // 
            // telefonoLB
            // 
            telefonoLB.AutoSize = true;
            telefonoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            telefonoLB.Location = new Point(394, 174);
            telefonoLB.Name = "telefonoLB";
            telefonoLB.Size = new Size(62, 17);
            telefonoLB.TabIndex = 4;
            telefonoLB.Text = "Telefono";
            // 
            // descripcionLB
            // 
            descripcionLB.AutoSize = true;
            descripcionLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            descripcionLB.Location = new Point(376, 223);
            descripcionLB.Name = "descripcionLB";
            descripcionLB.Size = new Size(80, 17);
            descripcionLB.TabIndex = 5;
            descripcionLB.Text = "Descripcion";
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(94, 121);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(252, 23);
            nombretxt.TabIndex = 6;
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = SystemColors.ScrollBar;
            direcciontxt.Enabled = false;
            direcciontxt.Location = new Point(94, 223);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(252, 23);
            direcciontxt.TabIndex = 8;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.ScrollBar;
            emailtxt.Enabled = false;
            emailtxt.Location = new Point(482, 116);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(294, 23);
            emailtxt.TabIndex = 9;
            // 
            // descripciontxt
            // 
            descripciontxt.BackColor = SystemColors.ScrollBar;
            descripciontxt.Enabled = false;
            descripciontxt.Location = new Point(482, 217);
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(294, 23);
            descripciontxt.TabIndex = 11;
            // 
            // insertarbtn
            // 
            insertarbtn.BackColor = SystemColors.ActiveCaption;
            insertarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertarbtn.Location = new Point(271, 384);
            insertarbtn.Name = "insertarbtn";
            insertarbtn.Size = new Size(75, 23);
            insertarbtn.TabIndex = 12;
            insertarbtn.Text = "Insertar";
            insertarbtn.UseVisualStyleBackColor = false;
            insertarbtn.Click += insertarbtn_Click;
            // 
            // guardarbtn
            // 
            guardarbtn.BackColor = SystemColors.ActiveCaption;
            guardarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.Location = new Point(429, 384);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(75, 23);
            guardarbtn.TabIndex = 13;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = SystemColors.ScrollBar;
            telefonotxt.Enabled = false;
            telefonotxt.Location = new Point(482, 165);
            telefonotxt.Mask = "(999) 000-0000";
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(89, 23);
            telefonotxt.TabIndex = 10;
            telefonotxt.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // rnctxt
            // 
            rnctxt.BackColor = SystemColors.ScrollBar;
            rnctxt.Enabled = false;
            rnctxt.Location = new Point(94, 173);
            rnctxt.Mask = "0-0000000-0";
            rnctxt.Name = "rnctxt";
            rnctxt.Size = new Size(75, 23);
            rnctxt.TabIndex = 7;
            rnctxt.MaskInputRejected += rnctxt_MaskInputRejected;
            // 
            // entradadesuplidorLB
            // 
            entradadesuplidorLB.AutoSize = true;
            entradadesuplidorLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            entradadesuplidorLB.Location = new Point(310, 44);
            entradadesuplidorLB.Name = "entradadesuplidorLB";
            entradadesuplidorLB.Size = new Size(192, 21);
            entradadesuplidorLB.TabIndex = 14;
            entradadesuplidorLB.Text = "ENTRADA DE SUPLIDOR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9044388_enterprise_icon;
            pictureBox1.Location = new Point(260, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9043673_3d_mpr_toggle_icon;
            pictureBox2.Location = new Point(364, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // agrsuplidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 478);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(entradadesuplidorLB);
            Controls.Add(rnctxt);
            Controls.Add(telefonotxt);
            Controls.Add(guardarbtn);
            Controls.Add(insertarbtn);
            Controls.Add(descripciontxt);
            Controls.Add(emailtxt);
            Controls.Add(direcciontxt);
            Controls.Add(nombretxt);
            Controls.Add(descripcionLB);
            Controls.Add(telefonoLB);
            Controls.Add(emailLB);
            Controls.Add(direccionLB);
            Controls.Add(rncLB);
            Controls.Add(nombreLB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "agrsuplidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Suplidor ";
            Load += agrsuplidor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLB;
        private Label rncLB;
        private Label direccionLB;
        private Label emailLB;
        private Label telefonoLB;
        private Label descripcionLB;
        private TextBox nombretxt;
        private TextBox direcciontxt;
        private TextBox emailtxt;
        private TextBox descripciontxt;
        private Button insertarbtn;
        private Button guardarbtn;
        private MaskedTextBox telefonotxt;
        private MaskedTextBox rnctxt;
        private Label entradadesuplidorLB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}