namespace CharacterExporter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSave1 = new System.Windows.Forms.Label();
            this.labelSave1Name = new System.Windows.Forms.Label();
            this.buttonSave1Export = new System.Windows.Forms.Button();
            this.buttonSave1Import = new System.Windows.Forms.Button();
            this.buttonSave2Import = new System.Windows.Forms.Button();
            this.buttonSave2Export = new System.Windows.Forms.Button();
            this.labelSave2Name = new System.Windows.Forms.Label();
            this.labelSave2 = new System.Windows.Forms.Label();
            this.buttonSave3Import = new System.Windows.Forms.Button();
            this.buttonSave3Export = new System.Windows.Forms.Button();
            this.labelSave3Name = new System.Windows.Forms.Label();
            this.labelSave3 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(336, 24);
            this.menuStripMain.TabIndex = 0;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // labelSave1
            // 
            this.labelSave1.AutoSize = true;
            this.labelSave1.Location = new System.Drawing.Point(12, 38);
            this.labelSave1.Name = "labelSave1";
            this.labelSave1.Size = new System.Drawing.Size(44, 13);
            this.labelSave1.TabIndex = 1;
            this.labelSave1.Text = "Save 1:";
            // 
            // labelSave1Name
            // 
            this.labelSave1Name.AutoSize = true;
            this.labelSave1Name.Location = new System.Drawing.Point(62, 38);
            this.labelSave1Name.Name = "labelSave1Name";
            this.labelSave1Name.Size = new System.Drawing.Size(69, 13);
            this.labelSave1Name.TabIndex = 2;
            this.labelSave1Name.Text = "[Uninitialized]";
            // 
            // buttonSave1Export
            // 
            this.buttonSave1Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave1Export.Location = new System.Drawing.Point(172, 33);
            this.buttonSave1Export.Name = "buttonSave1Export";
            this.buttonSave1Export.Size = new System.Drawing.Size(75, 23);
            this.buttonSave1Export.TabIndex = 3;
            this.buttonSave1Export.Text = "Export";
            this.buttonSave1Export.UseVisualStyleBackColor = true;
            this.buttonSave1Export.Click += new System.EventHandler(this.buttonSave1Export_Click);
            // 
            // buttonSave1Import
            // 
            this.buttonSave1Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave1Import.Location = new System.Drawing.Point(253, 33);
            this.buttonSave1Import.Name = "buttonSave1Import";
            this.buttonSave1Import.Size = new System.Drawing.Size(75, 23);
            this.buttonSave1Import.TabIndex = 4;
            this.buttonSave1Import.Text = "Import";
            this.buttonSave1Import.UseVisualStyleBackColor = true;
            this.buttonSave1Import.Click += new System.EventHandler(this.buttonSave1Import_Click);
            // 
            // buttonSave2Import
            // 
            this.buttonSave2Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave2Import.Location = new System.Drawing.Point(253, 62);
            this.buttonSave2Import.Name = "buttonSave2Import";
            this.buttonSave2Import.Size = new System.Drawing.Size(75, 23);
            this.buttonSave2Import.TabIndex = 8;
            this.buttonSave2Import.Text = "Import";
            this.buttonSave2Import.UseVisualStyleBackColor = true;
            this.buttonSave2Import.Click += new System.EventHandler(this.buttonSave2Import_Click);
            // 
            // buttonSave2Export
            // 
            this.buttonSave2Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave2Export.Location = new System.Drawing.Point(172, 62);
            this.buttonSave2Export.Name = "buttonSave2Export";
            this.buttonSave2Export.Size = new System.Drawing.Size(75, 23);
            this.buttonSave2Export.TabIndex = 7;
            this.buttonSave2Export.Text = "Export";
            this.buttonSave2Export.UseVisualStyleBackColor = true;
            this.buttonSave2Export.Click += new System.EventHandler(this.buttonSave2Export_Click);
            // 
            // labelSave2Name
            // 
            this.labelSave2Name.AutoSize = true;
            this.labelSave2Name.Location = new System.Drawing.Point(62, 67);
            this.labelSave2Name.Name = "labelSave2Name";
            this.labelSave2Name.Size = new System.Drawing.Size(69, 13);
            this.labelSave2Name.TabIndex = 6;
            this.labelSave2Name.Text = "[Uninitialized]";
            // 
            // labelSave2
            // 
            this.labelSave2.AutoSize = true;
            this.labelSave2.Location = new System.Drawing.Point(12, 67);
            this.labelSave2.Name = "labelSave2";
            this.labelSave2.Size = new System.Drawing.Size(44, 13);
            this.labelSave2.TabIndex = 5;
            this.labelSave2.Text = "Save 2:";
            // 
            // buttonSave3Import
            // 
            this.buttonSave3Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave3Import.Location = new System.Drawing.Point(253, 92);
            this.buttonSave3Import.Name = "buttonSave3Import";
            this.buttonSave3Import.Size = new System.Drawing.Size(75, 23);
            this.buttonSave3Import.TabIndex = 12;
            this.buttonSave3Import.Text = "Import";
            this.buttonSave3Import.UseVisualStyleBackColor = true;
            this.buttonSave3Import.Click += new System.EventHandler(this.buttonSave3Import_Click);
            // 
            // buttonSave3Export
            // 
            this.buttonSave3Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave3Export.Location = new System.Drawing.Point(172, 92);
            this.buttonSave3Export.Name = "buttonSave3Export";
            this.buttonSave3Export.Size = new System.Drawing.Size(75, 23);
            this.buttonSave3Export.TabIndex = 11;
            this.buttonSave3Export.Text = "Export";
            this.buttonSave3Export.UseVisualStyleBackColor = true;
            this.buttonSave3Export.Click += new System.EventHandler(this.buttonSave3Export_Click);
            // 
            // labelSave3Name
            // 
            this.labelSave3Name.AutoSize = true;
            this.labelSave3Name.Location = new System.Drawing.Point(62, 97);
            this.labelSave3Name.Name = "labelSave3Name";
            this.labelSave3Name.Size = new System.Drawing.Size(69, 13);
            this.labelSave3Name.TabIndex = 10;
            this.labelSave3Name.Text = "[Uninitialized]";
            // 
            // labelSave3
            // 
            this.labelSave3.AutoSize = true;
            this.labelSave3.Location = new System.Drawing.Point(12, 97);
            this.labelSave3.Name = "labelSave3";
            this.labelSave3.Size = new System.Drawing.Size(44, 13);
            this.labelSave3.TabIndex = 9;
            this.labelSave3.Text = "Save 3:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 129);
            this.Controls.Add(this.buttonSave3Import);
            this.Controls.Add(this.buttonSave3Export);
            this.Controls.Add(this.labelSave3Name);
            this.Controls.Add(this.labelSave3);
            this.Controls.Add(this.buttonSave2Import);
            this.Controls.Add(this.buttonSave2Export);
            this.Controls.Add(this.labelSave2Name);
            this.Controls.Add(this.labelSave2);
            this.Controls.Add(this.buttonSave1Import);
            this.Controls.Add(this.buttonSave1Export);
            this.Controls.Add(this.labelSave1Name);
            this.Controls.Add(this.labelSave1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "APM Character Exporter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label labelSave1;
        private System.Windows.Forms.Label labelSave1Name;
        private System.Windows.Forms.Button buttonSave1Export;
        private System.Windows.Forms.Button buttonSave1Import;
        private System.Windows.Forms.Button buttonSave2Import;
        private System.Windows.Forms.Button buttonSave2Export;
        private System.Windows.Forms.Label labelSave2Name;
        private System.Windows.Forms.Label labelSave2;
        private System.Windows.Forms.Button buttonSave3Import;
        private System.Windows.Forms.Button buttonSave3Export;
        private System.Windows.Forms.Label labelSave3Name;
        private System.Windows.Forms.Label labelSave3;
    }
}

