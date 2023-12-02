namespace Inventory_Hall
{
    partial class principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncerrar = new Button();
            menuStrip1 = new MenuStrip();
            eNTRADAToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOToolStripMenuItem = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            sUPLIDORToolStripMenuItem = new ToolStripMenuItem();
            pROCESOToolStripMenuItem = new ToolStripMenuItem();
            dISTRIBUCIONDECATEGORIAToolStripMenuItem = new ToolStripMenuItem();
            cONSULTAToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOToolStripMenuItem1 = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem1 = new ToolStripMenuItem();
            sUPLIDORToolStripMenuItem1 = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem = new ToolStripMenuItem();
            aCERCADEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.Image = Properties.Resources._330399_bad_cancel_clear_close_decline_icon;
            btncerrar.ImageAlign = ContentAlignment.TopCenter;
            btncerrar.Location = new Point(-110, 853);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(276, 74);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "CERRAR";
            btncerrar.TextAlign = ContentAlignment.BottomCenter;
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, pROCESOToolStripMenuItem, cONSULTAToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(935, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem, eMPLEADOToolStripMenuItem, sUPLIDORToolStripMenuItem });
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(91, 25);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // pRODUCTOToolStripMenuItem
            // 
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(180, 26);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO ";
            pRODUCTOToolStripMenuItem.Click += pRODUCTOToolStripMenuItem_Click;
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(180, 26);
            eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem.Click += eMPLEADOToolStripMenuItem_Click;
            // 
            // sUPLIDORToolStripMenuItem
            // 
            sUPLIDORToolStripMenuItem.Name = "sUPLIDORToolStripMenuItem";
            sUPLIDORToolStripMenuItem.Size = new Size(180, 26);
            sUPLIDORToolStripMenuItem.Text = "SUPLIDOR";
            sUPLIDORToolStripMenuItem.Click += sUPLIDORToolStripMenuItem_Click;
            // 
            // pROCESOToolStripMenuItem
            // 
            pROCESOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dISTRIBUCIONDECATEGORIAToolStripMenuItem });
            pROCESOToolStripMenuItem.Name = "pROCESOToolStripMenuItem";
            pROCESOToolStripMenuItem.Size = new Size(92, 25);
            pROCESOToolStripMenuItem.Text = "PROCESO";
            // 
            // dISTRIBUCIONDECATEGORIAToolStripMenuItem
            // 
            dISTRIBUCIONDECATEGORIAToolStripMenuItem.Name = "dISTRIBUCIONDECATEGORIAToolStripMenuItem";
            dISTRIBUCIONDECATEGORIAToolStripMenuItem.Size = new Size(297, 26);
            dISTRIBUCIONDECATEGORIAToolStripMenuItem.Text = "DISTRIBUCION DE CATEGORIA ";
            dISTRIBUCIONDECATEGORIAToolStripMenuItem.Click += dISTRIBUCIONDECATEGORIAToolStripMenuItem_Click;
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem1, eMPLEADOToolStripMenuItem1, sUPLIDORToolStripMenuItem1 });
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(100, 25);
            cONSULTAToolStripMenuItem.Text = "CONSULTA";
            cONSULTAToolStripMenuItem.Click += cONSULTAToolStripMenuItem_Click;
            // 
            // pRODUCTOToolStripMenuItem1
            // 
            pRODUCTOToolStripMenuItem1.Name = "pRODUCTOToolStripMenuItem1";
            pRODUCTOToolStripMenuItem1.Size = new Size(164, 26);
            pRODUCTOToolStripMenuItem1.Text = "PRODUCTO";
            pRODUCTOToolStripMenuItem1.Click += pRODUCTOToolStripMenuItem1_Click;
            // 
            // eMPLEADOToolStripMenuItem1
            // 
            eMPLEADOToolStripMenuItem1.Name = "eMPLEADOToolStripMenuItem1";
            eMPLEADOToolStripMenuItem1.Size = new Size(164, 26);
            eMPLEADOToolStripMenuItem1.Text = "EMPLEADO ";
            eMPLEADOToolStripMenuItem1.Click += eMPLEADOToolStripMenuItem1_Click;
            // 
            // sUPLIDORToolStripMenuItem1
            // 
            sUPLIDORToolStripMenuItem1.Name = "sUPLIDORToolStripMenuItem1";
            sUPLIDORToolStripMenuItem1.Size = new Size(164, 26);
            sUPLIDORToolStripMenuItem1.Text = "SUPLIDOR ";
            sUPLIDORToolStripMenuItem1.Click += sUPLIDORToolStripMenuItem1_Click;
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERCADEToolStripMenuItem });
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(88, 25);
            sISTEMAToolStripMenuItem.Text = "SISTEMA ";
            // 
            // aCERCADEToolStripMenuItem
            // 
            aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            aCERCADEToolStripMenuItem.Size = new Size(165, 26);
            aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            aCERCADEToolStripMenuItem.Click += aCERCADEToolStripMenuItem_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = Properties.Resources.foto_para_imagen_de_fono_del_inventory_hall_;
            ClientSize = new Size(935, 615);
            ControlBox = false;
            Controls.Add(btncerrar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "principal";
            Text = "Inventory Hall";
            WindowState = FormWindowState.Maximized;
            Load += principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncerrar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eNTRADAToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem;
        private ToolStripMenuItem pROCESOToolStripMenuItem;
        private ToolStripMenuItem cONSULTAToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem1;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem1;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem1;
        private ToolStripMenuItem sISTEMAToolStripMenuItem;
        private ToolStripMenuItem aCERCADEToolStripMenuItem;
        private ToolStripMenuItem dISTRIBUCIONDECATEGORIAToolStripMenuItem;
    }
}