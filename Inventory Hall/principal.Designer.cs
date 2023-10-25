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
            dISTRIBUCIONDEARTICULOSToolStripMenuItem = new ToolStripMenuItem();
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
            btncerrar.Location = new Point(720, 27);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(80, 74);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "CERRAR";
            btncerrar.TextAlign = ContentAlignment.BottomCenter;
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, pROCESOToolStripMenuItem, cONSULTAToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem, eMPLEADOToolStripMenuItem, sUPLIDORToolStripMenuItem });
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(71, 20);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // pRODUCTOToolStripMenuItem
            // 
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(180, 22);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO ";
            pRODUCTOToolStripMenuItem.Click += pRODUCTOToolStripMenuItem_Click;
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(180, 22);
            eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem.Click += eMPLEADOToolStripMenuItem_Click;
            // 
            // sUPLIDORToolStripMenuItem
            // 
            sUPLIDORToolStripMenuItem.Name = "sUPLIDORToolStripMenuItem";
            sUPLIDORToolStripMenuItem.Size = new Size(180, 22);
            sUPLIDORToolStripMenuItem.Text = "SUPLIDOR";
            sUPLIDORToolStripMenuItem.Click += sUPLIDORToolStripMenuItem_Click;
            // 
            // pROCESOToolStripMenuItem
            // 
            pROCESOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dISTRIBUCIONDEARTICULOSToolStripMenuItem });
            pROCESOToolStripMenuItem.Name = "pROCESOToolStripMenuItem";
            pROCESOToolStripMenuItem.Size = new Size(71, 20);
            pROCESOToolStripMenuItem.Text = "PROCESO";
            // 
            // dISTRIBUCIONDEARTICULOSToolStripMenuItem
            // 
            dISTRIBUCIONDEARTICULOSToolStripMenuItem.Name = "dISTRIBUCIONDEARTICULOSToolStripMenuItem";
            dISTRIBUCIONDEARTICULOSToolStripMenuItem.Size = new Size(234, 22);
            dISTRIBUCIONDEARTICULOSToolStripMenuItem.Text = "DISTRIBUCION DE ARTICULOS ";
            dISTRIBUCIONDEARTICULOSToolStripMenuItem.Click += dISTRIBUCIONDEARTICULOSToolStripMenuItem_Click;
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem1, eMPLEADOToolStripMenuItem1, sUPLIDORToolStripMenuItem1 });
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(77, 20);
            cONSULTAToolStripMenuItem.Text = "CONSULTA";
            cONSULTAToolStripMenuItem.Click += cONSULTAToolStripMenuItem_Click;
            // 
            // pRODUCTOToolStripMenuItem1
            // 
            pRODUCTOToolStripMenuItem1.Name = "pRODUCTOToolStripMenuItem1";
            pRODUCTOToolStripMenuItem1.Size = new Size(138, 22);
            pRODUCTOToolStripMenuItem1.Text = "PRODUCTO";
            // 
            // eMPLEADOToolStripMenuItem1
            // 
            eMPLEADOToolStripMenuItem1.Name = "eMPLEADOToolStripMenuItem1";
            eMPLEADOToolStripMenuItem1.Size = new Size(138, 22);
            eMPLEADOToolStripMenuItem1.Text = "EMPLEADO ";
            // 
            // sUPLIDORToolStripMenuItem1
            // 
            sUPLIDORToolStripMenuItem1.Name = "sUPLIDORToolStripMenuItem1";
            sUPLIDORToolStripMenuItem1.Size = new Size(138, 22);
            sUPLIDORToolStripMenuItem1.Text = "SUPLIDOR ";
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERCADEToolStripMenuItem });
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(68, 20);
            sISTEMAToolStripMenuItem.Text = "SISTEMA ";
            // 
            // aCERCADEToolStripMenuItem
            // 
            aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            aCERCADEToolStripMenuItem.Size = new Size(139, 22);
            aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btncerrar);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "principal";
            Text = "Inventory Hall";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem dISTRIBUCIONDEARTICULOSToolStripMenuItem;
        private ToolStripMenuItem cONSULTAToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem1;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem1;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem1;
        private ToolStripMenuItem sISTEMAToolStripMenuItem;
        private ToolStripMenuItem aCERCADEToolStripMenuItem;
    }
}