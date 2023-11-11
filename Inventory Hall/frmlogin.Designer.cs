namespace Inventory_Hall
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            loginbtn = new Button();
            cancelarbtn = new Button();
            usuariolb = new Label();
            usuariotxt = new TextBox();
            maskedcon = new MaskedTextBox();
            passwordlb = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.Location = new Point(49, 349);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(129, 67);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Iniciar Sesion";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // cancelarbtn
            // 
            cancelarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarbtn.Location = new Point(213, 349);
            cancelarbtn.Name = "cancelarbtn";
            cancelarbtn.Size = new Size(86, 67);
            cancelarbtn.TabIndex = 1;
            cancelarbtn.Text = "Cancelar";
            cancelarbtn.UseVisualStyleBackColor = true;
            cancelarbtn.Click += cancelarbtn_Click;
            // 
            // usuariolb
            // 
            usuariolb.AutoSize = true;
            usuariolb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usuariolb.Location = new Point(157, 40);
            usuariolb.Name = "usuariolb";
            usuariolb.Size = new Size(55, 17);
            usuariolb.TabIndex = 2;
            usuariolb.Text = "Usuario";
            // 
            // usuariotxt
            // 
            usuariotxt.Location = new Point(49, 91);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(250, 23);
            usuariotxt.TabIndex = 4;
            // 
            // maskedcon
            // 
            maskedcon.Location = new Point(49, 237);
            maskedcon.Name = "maskedcon";
            maskedcon.PasswordChar = '*';
            maskedcon.Size = new Size(250, 23);
            maskedcon.TabIndex = 5;
            // 
            // passwordlb
            // 
            passwordlb.AutoSize = true;
            passwordlb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlb.Location = new Point(145, 175);
            passwordlb.Name = "passwordlb";
            passwordlb.Size = new Size(77, 17);
            passwordlb.TabIndex = 6;
            passwordlb.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fotodeinventoryhall;
            pictureBox1.Location = new Point(391, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 342);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(passwordlb);
            Controls.Add(maskedcon);
            Controls.Add(usuariotxt);
            Controls.Add(usuariolb);
            Controls.Add(cancelarbtn);
            Controls.Add(loginbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL DE ACCESO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Button cancelarbtn;
        private Label usuariolb;
        private TextBox usuariotxt;
        private MaskedTextBox maskedcon;
        private Label passwordlb;
        private PictureBox pictureBox1;
    }
}