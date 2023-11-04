namespace Inventory_Hall
{
    partial class agrempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrempleado));
            nombretxt = new TextBox();
            nuevobtn = new Button();
            nombreLB = new Label();
            apellidoLB = new Label();
            direccionLB = new Label();
            dniLB = new Label();
            emailLB = new Label();
            telefonoLB = new Label();
            celularLB = new Label();
            cargoLB = new Label();
            apellidotxt = new TextBox();
            direcciontxt = new TextBox();
            emailtxt = new TextBox();
            cargotxt = new TextBox();
            maskeddni = new MaskedTextBox();
            maskedtel = new MaskedTextBox();
            maskedcel = new MaskedTextBox();
            guardarbtn = new Button();
            SuspendLayout();
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(174, 27);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(100, 23);
            nombretxt.TabIndex = 10;
            nombretxt.TextChanged += nombretxt_TextChanged;
            // 
            // nuevobtn
            // 
            nuevobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nuevobtn.Location = new Point(384, 359);
            nuevobtn.Name = "nuevobtn";
            nuevobtn.Size = new Size(75, 23);
            nuevobtn.TabIndex = 18;
            nuevobtn.Text = "Nuevo";
            nuevobtn.UseVisualStyleBackColor = true;
            nuevobtn.Click += nuevobtn_Click;
            // 
            // nombreLB
            // 
            nombreLB.AutoSize = true;
            nombreLB.Location = new Point(62, 35);
            nombreLB.Name = "nombreLB";
            nombreLB.Size = new Size(51, 15);
            nombreLB.TabIndex = 2;
            nombreLB.Text = "Nombre";
            // 
            // apellidoLB
            // 
            apellidoLB.AutoSize = true;
            apellidoLB.Location = new Point(62, 85);
            apellidoLB.Name = "apellidoLB";
            apellidoLB.Size = new Size(51, 15);
            apellidoLB.TabIndex = 3;
            apellidoLB.Text = "Apellido";
            // 
            // direccionLB
            // 
            direccionLB.AutoSize = true;
            direccionLB.Location = new Point(62, 129);
            direccionLB.Name = "direccionLB";
            direccionLB.Size = new Size(57, 15);
            direccionLB.TabIndex = 4;
            direccionLB.Text = "Direccion";
            // 
            // dniLB
            // 
            dniLB.AutoSize = true;
            dniLB.Location = new Point(62, 178);
            dniLB.Name = "dniLB";
            dniLB.Size = new Size(27, 15);
            dniLB.TabIndex = 5;
            dniLB.Text = "DNI";
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Location = new Point(62, 225);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(36, 15);
            emailLB.TabIndex = 6;
            emailLB.Text = "Email";
            // 
            // telefonoLB
            // 
            telefonoLB.AutoSize = true;
            telefonoLB.Location = new Point(62, 268);
            telefonoLB.Name = "telefonoLB";
            telefonoLB.Size = new Size(52, 15);
            telefonoLB.TabIndex = 7;
            telefonoLB.Text = "Telefono";
            // 
            // celularLB
            // 
            celularLB.AutoSize = true;
            celularLB.Location = new Point(62, 319);
            celularLB.Name = "celularLB";
            celularLB.Size = new Size(44, 15);
            celularLB.TabIndex = 8;
            celularLB.Text = "Celular";
            // 
            // cargoLB
            // 
            cargoLB.AutoSize = true;
            cargoLB.Location = new Point(62, 367);
            cargoLB.Name = "cargoLB";
            cargoLB.Size = new Size(39, 15);
            cargoLB.TabIndex = 9;
            cargoLB.Text = "Cargo";
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = SystemColors.ScrollBar;
            apellidotxt.Enabled = false;
            apellidotxt.Location = new Point(174, 77);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(100, 23);
            apellidotxt.TabIndex = 11;
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = SystemColors.ScrollBar;
            direcciontxt.Enabled = false;
            direcciontxt.Location = new Point(174, 121);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(100, 23);
            direcciontxt.TabIndex = 12;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.ScrollBar;
            emailtxt.Enabled = false;
            emailtxt.Location = new Point(174, 225);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(100, 23);
            emailtxt.TabIndex = 14;
            // 
            // cargotxt
            // 
            cargotxt.BackColor = SystemColors.ScrollBar;
            cargotxt.Enabled = false;
            cargotxt.Location = new Point(174, 359);
            cargotxt.Name = "cargotxt";
            cargotxt.Size = new Size(100, 23);
            cargotxt.TabIndex = 17;
            // 
            // maskeddni
            // 
            maskeddni.BackColor = SystemColors.ScrollBar;
            maskeddni.Enabled = false;
            maskeddni.Location = new Point(174, 170);
            maskeddni.Mask = "000-0000000-0";
            maskeddni.Name = "maskeddni";
            maskeddni.Size = new Size(100, 23);
            maskeddni.TabIndex = 13;
            // 
            // maskedtel
            // 
            maskedtel.BackColor = SystemColors.ScrollBar;
            maskedtel.Enabled = false;
            maskedtel.Location = new Point(174, 268);
            maskedtel.Mask = "0-(999)-000-0000";
            maskedtel.Name = "maskedtel";
            maskedtel.Size = new Size(100, 23);
            maskedtel.TabIndex = 15;
            // 
            // maskedcel
            // 
            maskedcel.BackColor = SystemColors.ScrollBar;
            maskedcel.Enabled = false;
            maskedcel.Location = new Point(174, 311);
            maskedcel.Mask = "(999)-000-0000";
            maskedcel.Name = "maskedcel";
            maskedcel.Size = new Size(100, 23);
            maskedcel.TabIndex = 16;
            // 
            // guardarbtn
            // 
            guardarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.Location = new Point(510, 359);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(75, 23);
            guardarbtn.TabIndex = 19;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // agrempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarbtn);
            Controls.Add(maskedcel);
            Controls.Add(maskedtel);
            Controls.Add(maskeddni);
            Controls.Add(cargotxt);
            Controls.Add(emailtxt);
            Controls.Add(direcciontxt);
            Controls.Add(apellidotxt);
            Controls.Add(cargoLB);
            Controls.Add(celularLB);
            Controls.Add(telefonoLB);
            Controls.Add(emailLB);
            Controls.Add(dniLB);
            Controls.Add(direccionLB);
            Controls.Add(apellidoLB);
            Controls.Add(nombreLB);
            Controls.Add(nuevobtn);
            Controls.Add(nombretxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "agrempleado";
            Text = "Entrada de Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombretxt;
        private Button nuevobtn;
        private Label nombreLB;
        private Label apellidoLB;
        private Label direccionLB;
        private Label dniLB;
        private Label emailLB;
        private Label telefonoLB;
        private Label celularLB;
        private Label cargoLB;
        private TextBox apellidotxt;
        private TextBox direcciontxt;
        private TextBox emailtxt;
        private TextBox cargotxt;
        private MaskedTextBox maskeddni;
        private MaskedTextBox maskedtel;
        private MaskedTextBox maskedcel;
        private Button guardarbtn;
    }
}