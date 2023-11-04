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
            SuspendLayout();
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(323, 77);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(100, 23);
            nombretxt.TabIndex = 0;
            // 
            // nuevobtn
            // 
            nuevobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nuevobtn.Location = new Point(348, 319);
            nuevobtn.Name = "nuevobtn";
            nuevobtn.Size = new Size(75, 23);
            nuevobtn.TabIndex = 1;
            nuevobtn.Text = "Nuevo";
            nuevobtn.UseVisualStyleBackColor = true;
            nuevobtn.Click += nuevobtn_Click;
            // 
            // agrempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}