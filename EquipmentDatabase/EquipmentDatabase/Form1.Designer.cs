namespace EquipmentDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.opțiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.echipamentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.înregistrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.Indigo;
            this.topMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opțiuniToolStripMenuItem,
            this.afisareToolStripMenuItem,
            this.addToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 6);
            this.topMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topMenu.Size = new System.Drawing.Size(1087, 29);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // opțiuniToolStripMenuItem
            // 
            this.opțiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setăriToolStripMenuItem,
            this.ieșireToolStripMenuItem});
            this.opțiuniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opțiuniToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opțiuniToolStripMenuItem.Name = "opțiuniToolStripMenuItem";
            this.opțiuniToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.opțiuniToolStripMenuItem.Text = "Opțiuni";
            // 
            // setăriToolStripMenuItem
            // 
            this.setăriToolStripMenuItem.Name = "setăriToolStripMenuItem";
            this.setăriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setăriToolStripMenuItem.Text = "Setări";
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripEquipment,
            this.elevToolStripMenuItem,
            this.înregistrareToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.addToolStripMenuItem.Text = "Adaugă";
            // 
            // stripEquipment
            // 
            this.stripEquipment.BackColor = System.Drawing.Color.Indigo;
            this.stripEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.echipamentToolStripMenuItem1});
            this.stripEquipment.ForeColor = System.Drawing.Color.White;
            this.stripEquipment.Name = "stripEquipment";
            this.stripEquipment.Size = new System.Drawing.Size(180, 22);
            this.stripEquipment.Text = "Echipament";
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categorieToolStripMenuItem.Text = "Categorie";
            // 
            // echipamentToolStripMenuItem1
            // 
            this.echipamentToolStripMenuItem1.Name = "echipamentToolStripMenuItem1";
            this.echipamentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.echipamentToolStripMenuItem1.Text = "Echipament";
            // 
            // elevToolStripMenuItem
            // 
            this.elevToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.elevToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.elevToolStripMenuItem.Name = "elevToolStripMenuItem";
            this.elevToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elevToolStripMenuItem.Text = "Elev";
            // 
            // înregistrareToolStripMenuItem
            // 
            this.înregistrareToolStripMenuItem.Name = "înregistrareToolStripMenuItem";
            this.înregistrareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.înregistrareToolStripMenuItem.Text = "Înregistrare";
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.afisareToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.afisareToolStripMenuItem.Text = "Afisare";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(1000, 583);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Refresh";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1087, 618);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bază de date echipament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem opțiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripEquipment;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem echipamentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem înregistrareToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.Button btnSelect;
    }
}

