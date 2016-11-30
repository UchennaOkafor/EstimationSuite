namespace EstimationSuite.Forms.Subform.Forms
{
    partial class FormParts
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
            this.dgViewParts = new Custom.CustomDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPart = new RPButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewParts)).BeginInit();
            this.SuspendLayout();
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(413, 38);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(63, 25);
            this.rpLabel1.TabIndex = 17;
            this.rpLabel1.Text = "Parts";
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
            this.cboAttribute.TabIndex = 16;
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
            this.txtInput.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnSearch.Location = new System.Drawing.Point(664, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgViewParts
            // 
            this.dgViewParts.AllowUserToAddRows = false;
            this.dgViewParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column11,
            this.Column6,
            this.Column9});
            this.dgViewParts.Location = new System.Drawing.Point(29, 128);
            this.dgViewParts.Name = "dgViewParts";
            this.dgViewParts.RowTemplate.Height = 24;
            this.dgViewParts.Size = new System.Drawing.Size(905, 567);
            this.dgViewParts.TabIndex = 13;
            this.dgViewParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgViewParts_KeyDown);
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
            // Column3
            // 
            this.Column3.HeaderText = "Weight";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Units";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stock";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Length";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Width";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sales Price";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Purchase Price";
            this.Column11.Name = "Column11";
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
            // btnAddPart
            // 
            this.btnAddPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAddPart.Image = global::EstimationSuite.Properties.Resources.document_new;
            this.btnAddPart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPart.Location = new System.Drawing.Point(385, 708);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(113, 36);
            this.btnAddPart.TabIndex = 18;
            this.btnAddPart.Text = "New part";
            this.btnAddPart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // FormParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 803);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.cboAttribute);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgViewParts);
            this.Controls.Add(this.btnAddPart);
            this.Name = "FormParts";
            this.Text = "PartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPLabel rpLabel1;
        private RPComboBox cboAttribute;
        private RPTextBox txtInput;
        private RPButton btnSearch;
        private Custom.CustomDataGridView dgViewParts;
        private RPButton btnAddPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}