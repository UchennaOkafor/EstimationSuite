using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;

namespace EstimationSuite.Forms.Subform.Forms
{
    public partial class FormAddPart : Form
    {
        public FormAddPart()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblCharsLeft.Text = $"{txtName.MaxLength - txtName.TextLength} char(s) left";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Project name cannot be left blank");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to add a new part?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var p = new Part()
                {
                    Name = txtName.Text,
                    Weight = (double)nudWeight.Value,
                    Units = (int)nudUnits.Value,
                    Stock = (int)nudStock.Value,
                    Length = (double)nudLength.Value,
                    Width = (double)nudWidth.Value,
                    SalesPrice = (double)nudSalesPrice.Value,
                    PurchasePrice = (double)nudPurchasePrice.Value
                };

                if (Api.Parts.AddPart(p))
                {
                    MessageBox.Show("Part has been added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("An error occured trying to create a new part");
                }
            }
        }
    }
}