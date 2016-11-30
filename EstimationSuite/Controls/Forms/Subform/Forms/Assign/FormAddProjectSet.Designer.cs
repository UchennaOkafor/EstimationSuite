namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    partial class FormAddProjectSet
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
            this.txtSetName = new RPTextBox();
            this.rpLabel1 = new RPLabel();
            this.lstSets = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new RPButton();
            this.SuspendLayout();
            // 
            // txtSetName
            // 
            this.txtSetName.BackColor = System.Drawing.Color.White;
            this.txtSetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSetName.Location = new System.Drawing.Point(68, 17);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Padding = new System.Windows.Forms.Padding(4);
            this.txtSetName.Size = new System.Drawing.Size(367, 25);
            this.txtSetName.TabIndex = 0;
            this.txtSetName.TextChanged += new System.EventHandler(this.txtSetName_TextChanged);
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(14, 20);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(48, 18);
            this.rpLabel1.TabIndex = 1;
            this.rpLabel1.Text = "Name";
            // 
            // lstSets
            // 
            this.lstSets.FormattingEnabled = true;
            this.lstSets.Location = new System.Drawing.Point(12, 56);
            this.lstSets.Name = "lstSets";
            this.lstSets.Size = new System.Drawing.Size(423, 403);
            this.lstSets.TabIndex = 2;
            this.lstSets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSets_ItemCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAdd.Location = new System.Drawing.Point(180, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddProjectSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 505);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSets);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.txtSetName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddProjectSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPTextBox txtSetName;
        private RPLabel rpLabel1;
        private System.Windows.Forms.CheckedListBox lstSets;
        private RPButton btnAdd;
    }
}