namespace Inventory_Hall
{
    partial class conempleado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conempleado));
            dataGridView1 = new DataGridView();
            buscartxt = new TextBox();
            buscarbtn = new Button();
            refreshbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1037, 309);
            dataGridView1.TabIndex = 0;
            // 
            // buscartxt
            // 
            buscartxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buscartxt.Location = new Point(292, 413);
            buscartxt.Multiline = true;
            buscartxt.Name = "buscartxt";
            buscartxt.Size = new Size(140, 32);
            buscartxt.TabIndex = 1;
            buscartxt.TextChanged += buscartxt_TextChanged;
            // 
            // buscarbtn
            // 
            buscarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarbtn.Location = new Point(453, 410);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(83, 35);
            buscarbtn.TabIndex = 2;
            buscarbtn.Text = "Buscar";
            buscarbtn.UseVisualStyleBackColor = true;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            refreshbtn.Location = new Point(584, 410);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(83, 35);
            refreshbtn.TabIndex = 3;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(439, 22);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 4;
            label1.Text = "Consulta De Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 384);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 5;
            label2.Text = "Inserte Empleado";
            // 
            // conempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1075, 457);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(refreshbtn);
            Controls.Add(buscarbtn);
            Controls.Add(buscartxt);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "conempleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Empleado";
            Load += conempleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox buscartxt;
        private Button buscarbtn;
        private Button refreshbtn;
        private Label label1;
        private Label label2;
    }
}