using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;

namespace EstimationSuite.Forms.Subform.Forms
{
    public partial class FormAddSet : Form
    {
        public FormAddSet()
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
                MessageBox.Show("Set name cannot be left blank");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to add a new set?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (Api.Sets.AddSet(new Set() { Name = txtName.Text }))
                {
                    MessageBox.Show("Set has been added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("An error occured trying to add new set");
                }
            }     
        }
    }
}
