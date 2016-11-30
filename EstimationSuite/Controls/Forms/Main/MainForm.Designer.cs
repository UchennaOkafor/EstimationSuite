namespace EstimationSuite.Forms.Main
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
            MintUI.NavMenuItem navMenuItem1 = new MintUI.NavMenuItem();
            MintUI.NavMenuItem navMenuItem2 = new MintUI.NavMenuItem();
            MintUI.NavMenuSubItem navMenuSubItem1 = new MintUI.NavMenuSubItem();
            MintUI.NavMenuSubItem navMenuSubItem2 = new MintUI.NavMenuSubItem();
            MintUI.NavMenuSubItem navMenuSubItem3 = new MintUI.NavMenuSubItem();
            MintUI.NavMenuItem navMenuItem3 = new MintUI.NavMenuItem();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.rpSeparator1 = new RPSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rpGroupBox1 = new RPGroupBox();
            this.btnRefreshStats = new RPButton();
            this.lblTotalParts = new RPLabel();
            this.lblTotalSets = new RPLabel();
            this.lblTotalProjects = new RPLabel();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.tabSets = new System.Windows.Forms.TabPage();
            this.tabParts = new System.Windows.Forms.TabPage();
            this.tabAssign = new System.Windows.Forms.TabPage();
            this.navMenu = new RPVNavMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new MintUI.ClipTabControl();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rpGroupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabHome.Controls.Add(this.rpSeparator1);
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Controls.Add(this.rpGroupBox1);
            this.tabHome.Location = new System.Drawing.Point(0, 0);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(965, 803);
            this.tabHome.TabIndex = 6;
            this.tabHome.Text = "tabPage1";
            // 
            // rpSeparator1
            // 
            this.rpSeparator1.Location = new System.Drawing.Point(103, 261);
            this.rpSeparator1.Name = "rpSeparator1";
            this.rpSeparator1.Size = new System.Drawing.Size(732, 19);
            this.rpSeparator1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstimationSuite.Properties.Resources.laptop;
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rpGroupBox1
            // 
            this.rpGroupBox1.Controls.Add(this.btnRefreshStats);
            this.rpGroupBox1.Controls.Add(this.lblTotalParts);
            this.rpGroupBox1.Controls.Add(this.lblTotalSets);
            this.rpGroupBox1.Controls.Add(this.lblTotalProjects);
            this.rpGroupBox1.Location = new System.Drawing.Point(326, 602);
            this.rpGroupBox1.Name = "rpGroupBox1";
            this.rpGroupBox1.Size = new System.Drawing.Size(277, 154);
            this.rpGroupBox1.TabIndex = 0;
            this.rpGroupBox1.TabStop = false;
            this.rpGroupBox1.Text = "Statistics";
            // 
            // btnRefreshStats
            // 
            this.btnRefreshStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnRefreshStats.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshStats.Image")));
            this.btnRefreshStats.Location = new System.Drawing.Point(226, 115);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(43, 31);
            this.btnRefreshStats.TabIndex = 3;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);
            // 
            // lblTotalParts
            // 
            this.lblTotalParts.AutoSize = true;
            this.lblTotalParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.lblTotalParts.Location = new System.Drawing.Point(25, 115);
            this.lblTotalParts.Name = "lblTotalParts";
            this.lblTotalParts.Size = new System.Drawing.Size(122, 18);
            this.lblTotalParts.TabIndex = 2;
            this.lblTotalParts.Text = "Total part(s): 0";
            // 
            // lblTotalSets
            // 
            this.lblTotalSets.AutoSize = true;
            this.lblTotalSets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.lblTotalSets.Location = new System.Drawing.Point(25, 76);
            this.lblTotalSets.Name = "lblTotalSets";
            this.lblTotalSets.Size = new System.Drawing.Size(115, 18);
            this.lblTotalSets.TabIndex = 1;
            this.lblTotalSets.Text = "Total set(s): 0";
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.lblTotalProjects.Location = new System.Drawing.Point(25, 35);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(145, 18);
            this.lblTotalProjects.TabIndex = 0;
            this.lblTotalProjects.Text = "Total project(s): 0";
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabProjects.Location = new System.Drawing.Point(0, 0);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(965, 803);
            this.tabProjects.TabIndex = 3;
            this.tabProjects.Text = "tabPage1";
            // 
            // tabSets
            // 
            this.tabSets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabSets.Location = new System.Drawing.Point(0, 0);
            this.tabSets.Name = "tabSets";
            this.tabSets.Size = new System.Drawing.Size(965, 803);
            this.tabSets.TabIndex = 4;
            this.tabSets.Text = "tabPage2";
            // 
            // tabParts
            // 
            this.tabParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabParts.Location = new System.Drawing.Point(0, 0);
            this.tabParts.Name = "tabParts";
            this.tabParts.Size = new System.Drawing.Size(965, 803);
            this.tabParts.TabIndex = 5;
            this.tabParts.Text = "tabPage3";
            // 
            // tabAssign
            // 
            this.tabAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabAssign.Location = new System.Drawing.Point(0, 0);
            this.tabAssign.Name = "tabAssign";
            this.tabAssign.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssign.Size = new System.Drawing.Size(965, 803);
            this.tabAssign.TabIndex = 0;
            this.tabAssign.Text = "tabPage1";
            // 
            // navMenu
            // 
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu.ImageList = this.imageList1;
            navMenuItem1.ImageIndex = 0;
            navMenuItem1.IsDropDown = false;
            navMenuItem1.TabPage = this.tabHome;
            navMenuItem1.Text = "Home";
            navMenuItem2.ImageIndex = 1;
            navMenuSubItem1.TabPage = this.tabProjects;
            navMenuSubItem1.Text = "Projects";
            navMenuSubItem2.TabPage = this.tabSets;
            navMenuSubItem2.Text = "Sets";
            navMenuSubItem3.TabPage = this.tabParts;
            navMenuSubItem3.Text = "Parts";
            navMenuItem2.SubItems.Add(navMenuSubItem1);
            navMenuItem2.SubItems.Add(navMenuSubItem2);
            navMenuItem2.SubItems.Add(navMenuSubItem3);
            navMenuItem2.Text = "Manager";
            navMenuItem3.ImageIndex = 2;
            navMenuItem3.IsDropDown = false;
            navMenuItem3.TabPage = this.tabAssign;
            navMenuItem3.Text = "Assign";
            this.navMenu.Items.Add(navMenuItem1);
            this.navMenu.Items.Add(navMenuItem2);
            this.navMenu.Items.Add(navMenuItem3);
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(157, 803);
            this.navMenu.TabControl = this.tabControl;
            this.navMenu.TabIndex = 0;
            this.navMenu.Text = "rpvNavMenu1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1467059113_home.png");
            this.imageList1.Images.SetKeyName(1, "1467059278_display_off.png");
            this.imageList1.Images.SetKeyName(2, "1469125282_pencil.png");
            this.imageList1.Images.SetKeyName(3, "1469125284_copy.png");
            this.imageList1.Images.SetKeyName(4, "1467059114_chart_line.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabProjects);
            this.tabControl.Controls.Add(this.tabSets);
            this.tabControl.Controls.Add(this.tabParts);
            this.tabControl.Controls.Add(this.tabAssign);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(157, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(965, 803);
            this.tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 803);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.navMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1140, 850);
            this.Name = "MainForm";
            this.Text = "Estimation Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rpGroupBox1.ResumeLayout(false);
            this.rpGroupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RPVNavMenu navMenu;
        private MintUI.ClipTabControl tabControl;
        private System.Windows.Forms.TabPage tabAssign;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabSets;
        private System.Windows.Forms.TabPage tabParts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabHome;
        private RPGroupBox rpGroupBox1;
        private RPLabel lblTotalParts;
        private RPLabel lblTotalSets;
        private RPLabel lblTotalProjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RPSeparator rpSeparator1;
        private RPButton btnRefreshStats;
    }
}

