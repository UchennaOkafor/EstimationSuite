namespace EstimationSuite.Forms.Subform.Forms
{
    partial class FormAddPart
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
            this.lblCharsLeft = new RPLabel();
            this.rpLabel2 = new RPLabel();
            this.btnAdd = new RPButton();
            this.rpLabel3 = new RPLabel();
            this.nudStock = new RPNumericUpDown();
            this.rpLabel4 = new RPLabel();
            this.nudUnits = new RPNumericUpDown();
            this.rpLabel5 = new RPLabel();
            this.nudWeight = new RPNumericUpDown();
            this.rpLabel1 = new RPLabel();
            this.nudLength = new RPNumericUpDown();
            this.rpLabel6 = new RPLabel();
            this.nudWidth = new RPNumericUpDown();
            this.nudPurchasePrice = new RPNumericUpDown();
            this.rpLabel7 = new RPLabel();
            this.nudSalesPrice = new RPNumericUpDown();
            this.rpLabel8 = new RPLabel();
            this.txtName = new RPTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.AutoSize = true;
            this.lblCharsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.lblCharsLeft.Location = new System.Drawing.Point(267, 156);
            this.lblCharsLeft.Name = "lblCharsLeft";
            this.lblCharsLeft.Size = new System.Drawing.Size(106, 18);
            this.lblCharsLeft.TabIndex = 36;
            this.lblCharsLeft.Text = "255 char(s) left";
            // 
            // rpLabel2
            // 
            this.rpLabel2.AutoSize = true;
            this.rpLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel2.Location = new System.Drawing.Point(12, 11);
            this.rpLabel2.Name = "rpLabel2";
            this.rpLabel2.Size = new System.Drawing.Size(48, 18);
            this.rpLabel2.TabIndex = 28;
            this.rpLabel2.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnAdd.Location = new System.Drawing.Point(219, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 36);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rpLabel3
            // 
            this.rpLabel3.AutoSize = true;
            this.rpLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel3.Location = new System.Drawing.Point(12, 193);
            this.rpLabel3.Name = "rpLabel3";
            this.rpLabel3.Size = new System.Drawing.Size(54, 18);
            this.rpLabel3.TabIndex = 29;
            this.rpLabel3.Text = "Weight";
            // 
            // nudStock
            // 
            this.nudStock.BackColor = System.Drawing.Color.White;
            this.nudStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudStock.Location = new System.Drawing.Point(219, 272);
            this.nudStock.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudStock.Size = new System.Drawing.Size(154, 26);
            this.nudStock.TabIndex = 32;
            // 
            // rpLabel4
            // 
            this.rpLabel4.AutoSize = true;
            this.rpLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel4.Location = new System.Drawing.Point(12, 241);
            this.rpLabel4.Name = "rpLabel4";
            this.rpLabel4.Size = new System.Drawing.Size(42, 18);
            this.rpLabel4.TabIndex = 31;
            this.rpLabel4.Text = "Units";
            // 
            // nudUnits
            // 
            this.nudUnits.BackColor = System.Drawing.Color.White;
            this.nudUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudUnits.Location = new System.Drawing.Point(219, 230);
            this.nudUnits.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudUnits.Name = "nudUnits";
            this.nudUnits.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudUnits.Size = new System.Drawing.Size(154, 26);
            this.nudUnits.TabIndex = 33;
            // 
            // rpLabel5
            // 
            this.rpLabel5.AutoSize = true;
            this.rpLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel5.Location = new System.Drawing.Point(12, 284);
            this.rpLabel5.Name = "rpLabel5";
            this.rpLabel5.Size = new System.Drawing.Size(47, 18);
            this.rpLabel5.TabIndex = 30;
            this.rpLabel5.Text = "Stock";
            // 
            // nudWeight
            // 
            this.nudWeight.BackColor = System.Drawing.Color.White;
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudWeight.Location = new System.Drawing.Point(219, 185);
            this.nudWeight.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudWeight.Size = new System.Drawing.Size(154, 26);
            this.nudWeight.TabIndex = 34;
            // 
            // rpLabel1
            // 
            this.rpLabel1.AutoSize = true;
            this.rpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel1.Location = new System.Drawing.Point(12, 366);
            this.rpLabel1.Name = "rpLabel1";
            this.rpLabel1.Size = new System.Drawing.Size(46, 18);
            this.rpLabel1.TabIndex = 30;
            this.rpLabel1.Text = "Width";
            // 
            // nudLength
            // 
            this.nudLength.BackColor = System.Drawing.Color.White;
            this.nudLength.DecimalPlaces = 2;
            this.nudLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudLength.Location = new System.Drawing.Point(219, 312);
            this.nudLength.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudLength.Size = new System.Drawing.Size(154, 26);
            this.nudLength.TabIndex = 33;
            // 
            // rpLabel6
            // 
            this.rpLabel6.AutoSize = true;
            this.rpLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel6.Location = new System.Drawing.Point(12, 323);
            this.rpLabel6.Name = "rpLabel6";
            this.rpLabel6.Size = new System.Drawing.Size(52, 18);
            this.rpLabel6.TabIndex = 31;
            this.rpLabel6.Text = "Length";
            // 
            // nudWidth
            // 
            this.nudWidth.BackColor = System.Drawing.Color.White;
            this.nudWidth.DecimalPlaces = 2;
            this.nudWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudWidth.Location = new System.Drawing.Point(219, 354);
            this.nudWidth.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudWidth.Size = new System.Drawing.Size(154, 26);
            this.nudWidth.TabIndex = 32;
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.BackColor = System.Drawing.Color.White;
            this.nudPurchasePrice.DecimalPlaces = 2;
            this.nudPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudPurchasePrice.Location = new System.Drawing.Point(219, 437);
            this.nudPurchasePrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudPurchasePrice.Size = new System.Drawing.Size(154, 26);
            this.nudPurchasePrice.TabIndex = 39;
            // 
            // rpLabel7
            // 
            this.rpLabel7.AutoSize = true;
            this.rpLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel7.Location = new System.Drawing.Point(12, 406);
            this.rpLabel7.Name = "rpLabel7";
            this.rpLabel7.Size = new System.Drawing.Size(81, 18);
            this.rpLabel7.TabIndex = 38;
            this.rpLabel7.Text = "Sales price";
            // 
            // nudSalesPrice
            // 
            this.nudSalesPrice.BackColor = System.Drawing.Color.White;
            this.nudSalesPrice.DecimalPlaces = 2;
            this.nudSalesPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudSalesPrice.Location = new System.Drawing.Point(219, 395);
            this.nudSalesPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudSalesPrice.Name = "nudSalesPrice";
            this.nudSalesPrice.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudSalesPrice.Size = new System.Drawing.Size(154, 26);
            this.nudSalesPrice.TabIndex = 40;
            // 
            // rpLabel8
            // 
            this.rpLabel8.AutoSize = true;
            this.rpLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.rpLabel8.Location = new System.Drawing.Point(12, 449);
            this.rpLabel8.Name = "rpLabel8";
            this.rpLabel8.Size = new System.Drawing.Size(107, 18);
            this.rpLabel8.TabIndex = 37;
            this.rpLabel8.Text = "Purchase price";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtName.Location = new System.Drawing.Point(13, 35);
            this.txtName.MaxLength = 255;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(4);
            this.txtName.Size = new System.Drawing.Size(360, 118);
            this.txtName.TabIndex = 27;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FormAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 527);
            this.Controls.Add(this.nudPurchasePrice);
            this.Controls.Add(this.rpLabel7);
            this.Controls.Add(this.nudSalesPrice);
            this.Controls.Add(this.rpLabel8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCharsLeft);
            this.Controls.Add(this.rpLabel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rpLabel3);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.rpLabel6);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.rpLabel4);
            this.Controls.Add(this.rpLabel1);
            this.Controls.Add(this.nudUnits);
            this.Controls.Add(this.rpLabel5);
            this.Controls.Add(this.nudWeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddPart";
            this.Text = "Add part";
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RPLabel lblCharsLeft;
        private RPLabel rpLabel2;
        private RPButton btnAdd;
        private RPLabel rpLabel3;
        private RPNumericUpDown nudStock;
        private RPLabel rpLabel4;
        private RPNumericUpDown nudUnits;
        private RPLabel rpLabel5;
        private RPNumericUpDown nudWeight;
        private RPLabel rpLabel1;
        private RPNumericUpDown nudLength;
        private RPLabel rpLabel6;
        private RPNumericUpDown nudWidth;
        private RPNumericUpDown nudPurchasePrice;
        private RPLabel rpLabel7;
        private RPNumericUpDown nudSalesPrice;
        private RPLabel rpLabel8;
        private RPTextBox txtName;
    }
}