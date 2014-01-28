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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.graphImage = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBoundary = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPoint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutAxisControl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.chkXLog = new System.Windows.Forms.CheckBox();
            this.flowLayoutXStart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblXStart = new System.Windows.Forms.Label();
            this.txtXStart = new System.Windows.Forms.TextBox();
            this.flowLayoutXEnd = new System.Windows.Forms.FlowLayoutPanel();
            this.lblXEnd = new System.Windows.Forms.Label();
            this.txtXEnd = new System.Windows.Forms.TextBox();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.chkYLog = new System.Windows.Forms.CheckBox();
            this.flowLayoutYStart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblYStart = new System.Windows.Forms.Label();
            this.txtYStart = new System.Windows.Forms.TextBox();
            this.flowLayoutYEnd = new System.Windows.Forms.FlowLayoutPanel();
            this.lblYEnd = new System.Windows.Forms.Label();
            this.txtYEnd = new System.Windows.Forms.TextBox();
            this.dgvDataPoints = new System.Windows.Forms.DataGridView();
            this.dataPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graphImage)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutAxisControl.SuspendLayout();
            this.flowLayoutXStart.SuspendLayout();
            this.flowLayoutXEnd.SuspendLayout();
            this.flowLayoutYStart.SuspendLayout();
            this.flowLayoutYEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // graphImage
            // 
            this.graphImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.graphImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.graphImage.Location = new System.Drawing.Point(378, 302);
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
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(114, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Enabled = false;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(114, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.Save);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Enabled = false;
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(114, 22);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(114, 22);
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 656);
            this.splitContainer1.SplitterDistance = 811;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutAxisControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvDataPoints);
            this.splitContainer2.Size = new System.Drawing.Size(226, 652);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 2;
            // 
            // flowLayoutAxisControl
            // 
            this.flowLayoutAxisControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutAxisControl.Controls.Add(this.lblXAxis);
            this.flowLayoutAxisControl.Controls.Add(this.chkXLog);
            this.flowLayoutAxisControl.Controls.Add(this.flowLayoutXStart);
            this.flowLayoutAxisControl.Controls.Add(this.flowLayoutXEnd);
            this.flowLayoutAxisControl.Controls.Add(this.lblYAxis);
            this.flowLayoutAxisControl.Controls.Add(this.chkYLog);
            this.flowLayoutAxisControl.Controls.Add(this.flowLayoutYStart);
            this.flowLayoutAxisControl.Controls.Add(this.flowLayoutYEnd);
            this.flowLayoutAxisControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutAxisControl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutAxisControl.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutAxisControl.Name = "flowLayoutAxisControl";
            this.flowLayoutAxisControl.Size = new System.Drawing.Size(226, 212);
            this.flowLayoutAxisControl.TabIndex = 0;
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(3, 0);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(36, 13);
            this.lblXAxis.TabIndex = 0;
            this.lblXAxis.Text = "X Axis";
            // 
            // chkXLog
            // 
            this.chkXLog.AutoSize = true;
            this.chkXLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkXLog.Location = new System.Drawing.Point(3, 16);
            this.chkXLog.Name = "chkXLog";
            this.chkXLog.Size = new System.Drawing.Size(80, 17);
            this.chkXLog.TabIndex = 1;
            this.chkXLog.Text = "Log Scale?";
            this.chkXLog.UseVisualStyleBackColor = true;
            this.chkXLog.CheckedChanged += new System.EventHandler(this.chkXLog_CheckedChanged);
            // 
            // flowLayoutXStart
            // 
            this.flowLayoutXStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutXStart.AutoSize = true;
            this.flowLayoutXStart.Controls.Add(this.lblXStart);
            this.flowLayoutXStart.Controls.Add(this.txtXStart);
            this.flowLayoutXStart.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutXStart.Name = "flowLayoutXStart";
            this.flowLayoutXStart.Size = new System.Drawing.Size(211, 26);
            this.flowLayoutXStart.TabIndex = 1;
            // 
            // lblXStart
            // 
            this.lblXStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblXStart.AutoSize = true;
            this.lblXStart.Location = new System.Drawing.Point(3, 6);
            this.lblXStart.Name = "lblXStart";
            this.lblXStart.Size = new System.Drawing.Size(61, 13);
            this.lblXStart.TabIndex = 0;
            this.lblXStart.Text = "X Axis Start";
            // 
            // txtXStart
            // 
            this.txtXStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtXStart.Location = new System.Drawing.Point(70, 3);
            this.txtXStart.Name = "txtXStart";
            this.txtXStart.Size = new System.Drawing.Size(138, 20);
            this.txtXStart.TabIndex = 2;
            this.txtXStart.Tag = "XStart";
            this.txtXStart.TextChanged += new System.EventHandler(this.ValidateAxisTextBox);
            // 
            // flowLayoutXEnd
            // 
            this.flowLayoutXEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutXEnd.AutoSize = true;
            this.flowLayoutXEnd.Controls.Add(this.lblXEnd);
            this.flowLayoutXEnd.Controls.Add(this.txtXEnd);
            this.flowLayoutXEnd.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutXEnd.Name = "flowLayoutXEnd";
            this.flowLayoutXEnd.Size = new System.Drawing.Size(211, 26);
            this.flowLayoutXEnd.TabIndex = 2;
            // 
            // lblXEnd
            // 
            this.lblXEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblXEnd.AutoSize = true;
            this.lblXEnd.Location = new System.Drawing.Point(3, 6);
            this.lblXEnd.Name = "lblXEnd";
            this.lblXEnd.Size = new System.Drawing.Size(58, 13);
            this.lblXEnd.TabIndex = 0;
            this.lblXEnd.Text = "X Axis End";
            // 
            // txtXEnd
            // 
            this.txtXEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtXEnd.Location = new System.Drawing.Point(67, 3);
            this.txtXEnd.Name = "txtXEnd";
            this.txtXEnd.Size = new System.Drawing.Size(138, 20);
            this.txtXEnd.TabIndex = 3;
            this.txtXEnd.Tag = "XEnd";
            this.txtXEnd.TextChanged += new System.EventHandler(this.ValidateAxisTextBox);
            // 
            // lblYAxis
            // 
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Location = new System.Drawing.Point(3, 100);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(36, 13);
            this.lblYAxis.TabIndex = 4;
            this.lblYAxis.Text = "Y Axis";
            // 
            // chkYLog
            // 
            this.chkYLog.AutoSize = true;
            this.chkYLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkYLog.Location = new System.Drawing.Point(3, 116);
            this.chkYLog.Name = "chkYLog";
            this.chkYLog.Size = new System.Drawing.Size(80, 17);
            this.chkYLog.TabIndex = 4;
            this.chkYLog.Text = "Log Scale?";
            this.chkYLog.UseVisualStyleBackColor = true;
            this.chkYLog.CheckedChanged += new System.EventHandler(this.chkYLog_CheckedChanged);
            // 
            // flowLayoutYStart
            // 
            this.flowLayoutYStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutYStart.AutoSize = true;
            this.flowLayoutYStart.Controls.Add(this.lblYStart);
            this.flowLayoutYStart.Controls.Add(this.txtYStart);
            this.flowLayoutYStart.Location = new System.Drawing.Point(3, 139);
            this.flowLayoutYStart.Name = "flowLayoutYStart";
            this.flowLayoutYStart.Size = new System.Drawing.Size(211, 26);
            this.flowLayoutYStart.TabIndex = 6;
            // 
            // lblYStart
            // 
            this.lblYStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYStart.AutoSize = true;
            this.lblYStart.Location = new System.Drawing.Point(3, 6);
            this.lblYStart.Name = "lblYStart";
            this.lblYStart.Size = new System.Drawing.Size(61, 13);
            this.lblYStart.TabIndex = 0;
            this.lblYStart.Text = "Y Axis Start";
            // 
            // txtYStart
            // 
            this.txtYStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtYStart.Location = new System.Drawing.Point(70, 3);
            this.txtYStart.Name = "txtYStart";
            this.txtYStart.Size = new System.Drawing.Size(138, 20);
            this.txtYStart.TabIndex = 5;
            this.txtYStart.Tag = "YStart";
            this.txtYStart.TextChanged += new System.EventHandler(this.ValidateAxisTextBox);
            // 
            // flowLayoutYEnd
            // 
            this.flowLayoutYEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutYEnd.AutoSize = true;
            this.flowLayoutYEnd.Controls.Add(this.lblYEnd);
            this.flowLayoutYEnd.Controls.Add(this.txtYEnd);
            this.flowLayoutYEnd.Location = new System.Drawing.Point(3, 171);
            this.flowLayoutYEnd.Name = "flowLayoutYEnd";
            this.flowLayoutYEnd.Size = new System.Drawing.Size(211, 26);
            this.flowLayoutYEnd.TabIndex = 7;
            // 
            // lblYEnd
            // 
            this.lblYEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYEnd.AutoSize = true;
            this.lblYEnd.Location = new System.Drawing.Point(3, 6);
            this.lblYEnd.Name = "lblYEnd";
            this.lblYEnd.Size = new System.Drawing.Size(58, 13);
            this.lblYEnd.TabIndex = 0;
            this.lblYEnd.Text = "Y Axis End";
            // 
            // txtYEnd
            // 
            this.txtYEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtYEnd.Location = new System.Drawing.Point(67, 3);
            this.txtYEnd.Name = "txtYEnd";
            this.txtYEnd.Size = new System.Drawing.Size(138, 20);
            this.txtYEnd.TabIndex = 6;
            this.txtYEnd.Tag = "YEnd";
            this.txtYEnd.TextChanged += new System.EventHandler(this.ValidateAxisTextBox);
            // 
            // dgvDataPoints
            // 
            this.dgvDataPoints.AllowUserToAddRows = false;
            this.dgvDataPoints.AllowUserToOrderColumns = true;
            this.dgvDataPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataPoints.Location = new System.Drawing.Point(0, 0);
            this.dgvDataPoints.Name = "dgvDataPoints";
            this.dgvDataPoints.ReadOnly = true;
            this.dgvDataPoints.Size = new System.Drawing.Size(226, 436);
            this.dgvDataPoints.TabIndex = 0;
            this.dgvDataPoints.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDataPoints_UserDeletingRow);
            // 
            // dataPointBindingSource
            // 
            this.dataPointBindingSource.DataSource = typeof(GraphValues.DataPoint);
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
            this.Text = "Graph Grabber, stealing your dataz";
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutAxisControl.ResumeLayout(false);
            this.flowLayoutAxisControl.PerformLayout();
            this.flowLayoutXStart.ResumeLayout(false);
            this.flowLayoutXStart.PerformLayout();
            this.flowLayoutXEnd.ResumeLayout(false);
            this.flowLayoutXEnd.PerformLayout();
            this.flowLayoutYStart.ResumeLayout(false);
            this.flowLayoutYStart.PerformLayout();
            this.flowLayoutYEnd.ResumeLayout(false);
            this.flowLayoutYEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDataPoints;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.BindingSource dataPointBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAxisControl;
        private System.Windows.Forms.Label lblXAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutXStart;
        private System.Windows.Forms.Label lblXStart;
        private System.Windows.Forms.TextBox txtXStart;
        private System.Windows.Forms.CheckBox chkXLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutXEnd;
        private System.Windows.Forms.Label lblXEnd;
        private System.Windows.Forms.TextBox txtXEnd;
        private System.Windows.Forms.Label lblYAxis;
        private System.Windows.Forms.CheckBox chkYLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutYStart;
        private System.Windows.Forms.Label lblYStart;
        private System.Windows.Forms.TextBox txtYStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutYEnd;
        private System.Windows.Forms.Label lblYEnd;
        private System.Windows.Forms.TextBox txtYEnd;
    }
}

