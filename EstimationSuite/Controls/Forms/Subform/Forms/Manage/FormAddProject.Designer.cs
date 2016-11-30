namespace EstimationSuite.Forms.Subform.Forms
{
    partial class FormAddProject
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
            this.txtName = new RPTextBox();
            this.lblCharsLeft = new RPLabel();
            this.rpLabel2 = new RPLabel();
            this.btnAdd = new RPButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtName.Location = new System.Drawing.Point(15, 41);
            this.txtName.MaxLength = 255;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(4);
            this.txtName.Size = new System.Drawing.Size(358, 136);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.AutoSize = true;
            this.lblCharsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.lblCharsLeft.Location = new System.Drawing.Point(267, 184);
            this.lblCharsLeft.Name = "lblCharsLeft";
            this.lblCharsLeft.Size = new System.Drawing.Size(106, 18);
            this.lblCharsLeft.TabIndex = 26;
            this.lblCharsLeft.Text = "255 char(s) left";
            // 
            // rpLabel2
            // 
            this.rpLabel2.AutoSize = true;
            this.rpLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel2.Location = new System.Drawing.Point(14, 14);
            this.rpLabel2.Name = "rpLabel2";
            this.rpLabel2.Size = new System.Drawing.Size(48, 18);
            this.rpLabel2.TabIndex = 18;
            this.rpLabel2.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAdd.Location = new System.Drawing.Point(228, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 252);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCharsLeft);
            this.Controls.Add(this.rpLabel2);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddProject";
            this.Text = "Add project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPTextBox txtName;
        private RPLabel lblCharsLeft;
        private RPLabel rpLabel2;
        private RPButton btnAdd;
    }
}