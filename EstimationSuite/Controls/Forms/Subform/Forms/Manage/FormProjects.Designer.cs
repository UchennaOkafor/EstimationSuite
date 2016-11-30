namespace EstimationSuite.Forms.Subform.Forms
{
    partial class FormProject
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
            this.rpLabel1 = new RPLabel();
            this.cboAttribute = new RPComboBox();
            this.txtInput = new RPTextBox();
            this.btnSearch = new RPButton();
            this.dgViewProjects = new Custom.CustomDataGridView();
            this.btnAddProject = new RPButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(413, 38);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(92, 25);
            this.rpLabel1.TabIndex = 11;
            this.rpLabel1.Text = "Projects";
            // 
            // cboAttribute
            // 
            this.cboAttribute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.cboAttribute.FormattingEnabled = true;
            this.cboAttribute.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.cboAttribute.Location = new System.Drawing.Point(178, 81);
            this.cboAttribute.Name = "cboAttribute";
            this.cboAttribute.Size = new System.Drawing.Size(87, 27);
            this.cboAttribute.TabIndex = 10;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtInput.Location = new System.Drawing.Point(271, 80);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(4);
            this.txtInput.Size = new System.Drawing.Size(387, 29);
            this.txtInput.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnSearch.Location = new System.Drawing.Point(664, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgViewProjects
            // 
            this.dgViewProjects.AllowUserToAddRows = false;
            this.dgViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column9});
            this.dgViewProjects.Location = new System.Drawing.Point(29, 128);
            this.dgViewProjects.Name = "dgViewProjects";
            this.dgViewProjects.RowTemplate.Height = 24;
            this.dgViewProjects.Size = new System.Drawing.Size(905, 567);
            this.dgViewProjects.TabIndex = 7;
            this.dgViewProjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgViewProjects_KeyDown);
            // 
            // btnAddProject
            // 
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAddProject.Image = global::EstimationSuite.Properties.Resources.document_new;
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(384, 709);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(135, 36);
            this.btnAddProject.TabIndex = 12;
            this.btnAddProject.Text = "New project";
            this.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Created At";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Updated At";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 803);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.cboAttribute);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgViewProjects);
            this.Name = "FormProject";
            this.Text = "ProjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPLabel rpLabel1;
        private RPComboBox cboAttribute;
        private RPTextBox txtInput;
        private RPButton btnSearch;
        private Custom.CustomDataGridView dgViewProjects;
        private RPButton btnAddProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}