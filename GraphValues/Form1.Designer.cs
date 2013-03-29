namespace GraphValues
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
            this.txtYEnd = new System.Windows.Forms.ToolStripTextBox();
            this.lblYEnd = new System.Windows.Forms.ToolStripLabel();
            this.txtYStart = new System.Windows.Forms.ToolStripTextBox();
            this.lblYStart = new System.Windows.Forms.ToolStripLabel();
            this.txtXEnd = new System.Windows.Forms.ToolStripTextBox();
            this.lblXEnd = new System.Windows.Forms.ToolStripLabel();
            this.txtXStart = new System.Windows.Forms.ToolStripTextBox();
            this.lblXStart = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.graphImage)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphImage
            // 
            this.graphImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.graphImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.graphImage.Location = new System.Drawing.Point(380, 302);
            this.graphImage.Name = "graphImage";
            this.graphImage.Size = new System.Drawing.Size(75, 37);
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
            this.toolStripButtonPoint,
            this.txtYEnd,
            this.lblYEnd,
            this.txtYStart,
            this.lblYStart,
            this.txtXEnd,
            this.lblXEnd,
            this.txtXStart,
            this.lblXStart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBoundary
            // 
            this.toolStripButtonBoundary.BackColor = System.Drawing.SystemColors.Control;
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
            // txtYEnd
            // 
            this.txtYEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtYEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYEnd.Name = "txtYEnd";
            this.txtYEnd.Size = new System.Drawing.Size(70, 25);
            // 
            // lblYEnd
            // 
            this.lblYEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblYEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblYEnd.Name = "lblYEnd";
            this.lblYEnd.Size = new System.Drawing.Size(61, 22);
            this.lblYEnd.Text = "Y Axis End";
            // 
            // txtYStart
            // 
            this.txtYStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtYStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYStart.Name = "txtYStart";
            this.txtYStart.Size = new System.Drawing.Size(70, 25);
            // 
            // lblYStart
            // 
            this.lblYStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblYStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblYStart.Name = "lblYStart";
            this.lblYStart.Size = new System.Drawing.Size(65, 22);
            this.lblYStart.Text = "Y Axis Start";
            // 
            // txtXEnd
            // 
            this.txtXEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtXEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXEnd.Name = "txtXEnd";
            this.txtXEnd.Size = new System.Drawing.Size(70, 25);
            // 
            // lblXEnd
            // 
            this.lblXEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblXEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblXEnd.Name = "lblXEnd";
            this.lblXEnd.Size = new System.Drawing.Size(61, 22);
            this.lblXEnd.Text = "X Axis End";
            // 
            // txtXStart
            // 
            this.txtXStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtXStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXStart.Name = "txtXStart";
            this.txtXStart.Size = new System.Drawing.Size(70, 25);
            // 
            // lblXStart
            // 
            this.lblXStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblXStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblXStart.Name = "lblXStart";
            this.lblXStart.Size = new System.Drawing.Size(65, 22);
            this.lblXStart.Text = "X Axis Start";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 656);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.graphImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 656);
            this.splitContainer1.SplitterDistance = 814;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 74);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(107, 77);
            this.dataGridView1.TabIndex = 0;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripTextBox txtXStart;
        private System.Windows.Forms.ToolStripTextBox txtXEnd;
        private System.Windows.Forms.ToolStripLabel lblXEnd;
        private System.Windows.Forms.ToolStripLabel lblXStart;
        private System.Windows.Forms.ToolStripTextBox txtYEnd;
        private System.Windows.Forms.ToolStripLabel lblYEnd;
        private System.Windows.Forms.ToolStripTextBox txtYStart;
        private System.Windows.Forms.ToolStripLabel lblYStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

