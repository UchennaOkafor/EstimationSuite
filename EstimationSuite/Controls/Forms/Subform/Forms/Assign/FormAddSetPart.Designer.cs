namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    partial class FormAddSetPart
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
            this.btnAdd = new RPButton();
            this.lstParts = new System.Windows.Forms.CheckedListBox();
            this.rpLabel1 = new RPLabel();
            this.txtPartName = new RPTextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAdd.Location = new System.Drawing.Point(182, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstParts
            // 
            this.lstParts.FormattingEnabled = true;
            this.lstParts.Location = new System.Drawing.Point(12, 52);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(423, 403);
            this.lstParts.TabIndex = 6;
            this.lstParts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstParts_ItemCheck);
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(9, 22);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(48, 18);
            this.rpLabel1.TabIndex = 5;
            this.rpLabel1.Text = "Name";
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.White;
            this.txtPartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPartName.Location = new System.Drawing.Point(82, 15);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Padding = new System.Windows.Forms.Padding(4);
            this.txtPartName.Size = new System.Drawing.Size(353, 25);
            this.txtPartName.TabIndex = 4;
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // FormAddSetPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 505);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.txtPartName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddSetPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPButton btnAdd;
        private System.Windows.Forms.CheckedListBox lstParts;
        private RPLabel rpLabel1;
        private RPTextBox txtPartName;
    }
}