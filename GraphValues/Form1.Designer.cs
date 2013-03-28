﻿namespace GraphValues
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
            this.graphImage = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBoundary = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPoint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.graphImage)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphImage
            // 
            this.graphImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.graphImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.graphImage.Location = new System.Drawing.Point(0, 0);
            this.graphImage.Name = "graphImage";
            this.graphImage.Size = new System.Drawing.Size(0, 0);
            this.graphImage.TabIndex = 0;
            this.graphImage.TabStop = false;
            this.graphImage.Paint += new System.Windows.Forms.PaintEventHandler(this.graphImage_Paint);
            this.graphImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphImage_MouseClick);
            this.graphImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphImage_MouseDown);
            this.graphImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphImage_MouseMove);
            this.graphImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphImage_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(103, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBoundary,
            this.toolStripButtonPoint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBoundary
            // 
            this.toolStripButtonBoundary.Checked = true;
            this.toolStripButtonBoundary.CheckOnClick = true;
            this.toolStripButtonBoundary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonBoundary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBoundary.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBoundary.Image")));
            this.toolStripButtonBoundary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBoundary.Name = "toolStripButtonBoundary";
            this.toolStripButtonBoundary.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonBoundary.Text = "I can haz axis";
            this.toolStripButtonBoundary.Click += new System.EventHandler(this.toolStripButtonBoundary_Click);
            // 
            // toolStripButtonPoint
            // 
            this.toolStripButtonPoint.CheckOnClick = true;
            this.toolStripButtonPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPoint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPoint.Image")));
            this.toolStripButtonPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPoint.Name = "toolStripButtonPoint";
            this.toolStripButtonPoint.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonPoint.Text = "I can haz datums";
            this.toolStripButtonPoint.Click += new System.EventHandler(this.toolStripButtonPoint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.graphImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 656);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "I stealz datas";
            ((System.ComponentModel.ISupportInitialize)(this.graphImage)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphImage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBoundary;
        private System.Windows.Forms.ToolStripButton toolStripButtonPoint;
    }
}

