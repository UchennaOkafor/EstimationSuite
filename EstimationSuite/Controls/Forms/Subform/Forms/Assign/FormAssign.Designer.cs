namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    partial class FormAssign
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
            this.txtProjectFilter = new RPTextBox();
            this.txtSetFilter = new RPTextBox();
            this.txtPartFilter = new RPTextBox();
            this.rpLabel3 = new RPLabel();
            this.rpLabel2 = new RPLabel();
            this.rpLabel1 = new RPLabel();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.lstSets = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.contextMenuSets = new RPContextMenuStrip();
            this.tsmAddNewSets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveSelectedSets = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuProjects = new RPContextMenuStrip();
            this.tsmRefreshProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuParts = new RPContextMenuStrip();
            this.tsmAddNewParts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveSelectedParts = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSets.SuspendLayout();
            this.contextMenuProjects.SuspendLayout();
            this.contextMenuParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProjectFilter
            // 
            this.txtProjectFilter.BackColor = System.Drawing.Color.White;
            this.txtProjectFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProjectFilter.Location = new System.Drawing.Point(113, 43);
            this.txtProjectFilter.Name = "txtProjectFilter";
            this.txtProjectFilter.Padding = new System.Windows.Forms.Padding(4);
            this.txtProjectFilter.Size = new System.Drawing.Size(204, 25);
            this.txtProjectFilter.TabIndex = 21;
            this.txtProjectFilter.TextChanged += new System.EventHandler(this.txtProjectFilter_TextChanged);
            // 
            // txtSetFilter
            // 
            this.txtSetFilter.BackColor = System.Drawing.Color.White;
            this.txtSetFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSetFilter.Location = new System.Drawing.Point(407, 43);
            this.txtSetFilter.Name = "txtSetFilter";
            this.txtSetFilter.Padding = new System.Windows.Forms.Padding(4);
            this.txtSetFilter.Size = new System.Drawing.Size(226, 25);
            this.txtSetFilter.TabIndex = 20;
            this.txtSetFilter.TextChanged += new System.EventHandler(this.txtSetFilter_TextChanged);
            // 
            // txtPartFilter
            // 
            this.txtPartFilter.BackColor = System.Drawing.Color.White;
            this.txtPartFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPartFilter.Location = new System.Drawing.Point(738, 43);
            this.txtPartFilter.Name = "txtPartFilter";
            this.txtPartFilter.Padding = new System.Windows.Forms.Padding(4);
            this.txtPartFilter.Size = new System.Drawing.Size(209, 25);
            this.txtPartFilter.TabIndex = 19;
            this.txtPartFilter.TextChanged += new System.EventHandler(this.txtPartFilter_TextChanged);
            // 
            // rpLabel3
            // 
            this.rpLabel3.AutoSize = true;
            this.rpLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel3.Location = new System.Drawing.Point(686, 50);
            this.rpLabel3.Name = "rpLabel3";
            this.rpLabel3.Size = new System.Drawing.Size(35, 18);
            this.rpLabel3.TabIndex = 18;
            this.rpLabel3.Text = "Part";
            // 
            // rpLabel2
            // 
            this.rpLabel2.AutoSize = true;
            this.rpLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel2.Location = new System.Drawing.Point(359, 50);
            this.rpLabel2.Name = "rpLabel2";
            this.rpLabel2.Size = new System.Drawing.Size(30, 18);
            this.rpLabel2.TabIndex = 17;
            this.rpLabel2.Text = "Set";
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(43, 50);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(55, 18);
            this.rpLabel1.TabIndex = 16;
            this.rpLabel1.Text = "Project";
            // 
            // lstParts
            // 
            this.lstParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstParts.FormattingEnabled = true;
            this.lstParts.ItemHeight = 18;
            this.lstParts.Location = new System.Drawing.Point(648, 90);
            this.lstParts.Name = "lstParts";
            this.lstParts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstParts.Size = new System.Drawing.Size(296, 544);
            this.lstParts.TabIndex = 13;
            // 
            // lstSets
            // 
            this.lstSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSets.FormattingEnabled = true;
            this.lstSets.ItemHeight = 18;
            this.lstSets.Location = new System.Drawing.Point(334, 90);
            this.lstSets.Name = "lstSets";
            this.lstSets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSets.Size = new System.Drawing.Size(296, 544);
            this.lstSets.TabIndex = 14;
            this.lstSets.SelectedIndexChanged += new System.EventHandler(this.lstSets_SelectedIndexChanged);
            // 
            // lstProjects
            // 
            this.lstProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(18, 90);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(296, 544);
            this.lstProjects.TabIndex = 15;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // contextMenuSets
            // 
            this.contextMenuSets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuSets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewSets,
            this.tsmRemoveSelectedSets});
            this.contextMenuSets.Name = "contextMenuSets";
            this.contextMenuSets.Size = new System.Drawing.Size(178, 56);
            // 
            // tsmAddNewSets
            // 
            this.tsmAddNewSets.Name = "tsmAddNewSets";
            this.tsmAddNewSets.Size = new System.Drawing.Size(177, 26);
            this.tsmAddNewSets.Text = "Add set(s)";
            this.tsmAddNewSets.Click += new System.EventHandler(this.tsmAddNewSets_Click);
            // 
            // tsmRemoveSelectedSets
            // 
            this.tsmRemoveSelectedSets.Name = "tsmRemoveSelectedSets";
            this.tsmRemoveSelectedSets.Size = new System.Drawing.Size(177, 26);
            this.tsmRemoveSelectedSets.Text = "Remove set(s)";
            this.tsmRemoveSelectedSets.Click += new System.EventHandler(this.tsmRemoveSelectedSets_Click);
            // 
            // contextMenuProjects
            // 
            this.contextMenuProjects.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRefreshProjectList,
            this.tsmViewReport});
            this.contextMenuProjects.Name = "rpContextMenuStrip1";
            this.contextMenuProjects.Size = new System.Drawing.Size(162, 56);
            // 
            // tsmRefreshProjectList
            // 
            this.tsmRefreshProjectList.Name = "tsmRefreshProjectList";
            this.tsmRefreshProjectList.Size = new System.Drawing.Size(161, 26);
            this.tsmRefreshProjectList.Text = "Refresh";
            this.tsmRefreshProjectList.Click += new System.EventHandler(this.tsmRefreshProjectList_Click);
            // 
            // tsmViewReport
            // 
            this.tsmViewReport.Name = "tsmViewReport";
            this.tsmViewReport.Size = new System.Drawing.Size(161, 26);
            this.tsmViewReport.Text = "View report";
            this.tsmViewReport.Click += new System.EventHandler(this.tsmViewReport_Click);
            // 
            // contextMenuParts
            // 
            this.contextMenuParts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuParts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewParts,
            this.tsmRemoveSelectedParts});
            this.contextMenuParts.Name = "contextMenuParts";
            this.contextMenuParts.Size = new System.Drawing.Size(186, 56);
            // 
            // tsmAddNewParts
            // 
            this.tsmAddNewParts.Name = "tsmAddNewParts";
            this.tsmAddNewParts.Size = new System.Drawing.Size(185, 26);
            this.tsmAddNewParts.Text = "Add part(s)";
            this.tsmAddNewParts.Click += new System.EventHandler(this.tsmAddNewParts_Click);
            // 
            // tsmRemoveSelectedParts
            // 
            this.tsmRemoveSelectedParts.Name = "tsmRemoveSelectedParts";
            this.tsmRemoveSelectedParts.Size = new System.Drawing.Size(185, 26);
            this.tsmRemoveSelectedParts.Text = "Remove part(s)";
            this.tsmRemoveSelectedParts.Click += new System.EventHandler(this.tsmRemoveSelectedParts_Click);
            // 
            // FormAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(965, 803);
            this.Controls.Add(this.txtProjectFilter);
            this.Controls.Add(this.txtSetFilter);
            this.Controls.Add(this.txtPartFilter);
            this.Controls.Add(this.rpLabel3);
            this.Controls.Add(this.rpLabel2);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.lstSets);
            this.Controls.Add(this.lstProjects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAssign";
            this.Text = "FormAssign";
            this.contextMenuSets.ResumeLayout(false);
            this.contextMenuProjects.ResumeLayout(false);
            this.contextMenuParts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPTextBox txtProjectFilter;
        private RPTextBox txtSetFilter;
        private RPTextBox txtPartFilter;
        private RPLabel rpLabel3;
        private RPLabel rpLabel2;
        private RPLabel rpLabel1;
        private System.Windows.Forms.ListBox lstParts;
        private RPContextMenuStrip contextMenuSets;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewSets;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveSelectedSets;
        private RPContextMenuStrip contextMenuProjects;
        private System.Windows.Forms.ToolStripMenuItem tsmRefreshProjectList;
        private RPContextMenuStrip contextMenuParts;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewParts;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveSelectedParts;
        public System.Windows.Forms.ListBox lstProjects;
        public System.Windows.Forms.ListBox lstSets;
        private System.Windows.Forms.ToolStripMenuItem tsmViewReport;
    }
}