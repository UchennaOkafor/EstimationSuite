using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;
using EstimationSuite.Forms.Subform.Base;

namespace EstimationSuite.Forms.Subform.Forms
{
    public partial class FormParts : SubRpForm
    {
        public FormParts()
        {
            InitializeComponent();
            cboAttribute.SelectedIndex = 0;
            dgViewParts.CellValueChanged += dgViewParts_CellValueChanged;
        }

        private void dgViewParts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgViewParts.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells[0].Value);
            string name = row.Cells[1].Value.ToString();
            double weight = Convert.ToDouble((row.Cells[2].Value));
            int units = Convert.ToInt32((row.Cells[3].Value));
            int stock = Convert.ToInt32((row.Cells[4].Value));
            double length = Convert.ToDouble(row.Cells[5].Value);
            double width = Convert.ToDouble(row.Cells[6].Value);
            double salesPrice = Convert.ToDouble(row.Cells[7].Value);
            double purchasePrice = Convert.ToDouble(row.Cells[8].Value);

            var newPart = new Part()
            {
                Id = id,
                Name = name,
                Weight = weight,
                Units = units,
                Stock = stock,
                Length = length,
                Width = width,
                SalesPrice = salesPrice,
                PurchasePrice = purchasePrice,
            };

            Api.Parts.EditPart(newPart);
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            new FormAddPart().ShowDialog();
            RefreshStatistics();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Part[] parts = null;
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                parts = await Api.Parts.GetPartsByName("%");
            }
            else
            {
                if (cboAttribute.SelectedItem.ToString() == "Id")
                {
                    int id = 0;

                    if (!int.TryParse(input, out id))
                    {
                        MessageBox.Show("Id entered is not a form of a valid integer");
                        return;
                    }

                    parts = new Part[] { await Api.Parts.GetPartById(id) };
                }
                else if (cboAttribute.SelectedItem.ToString() == "Name")
                {
                    parts = await Api.Parts.GetPartsByName(input);
                }
            }

            if (parts[0] == null || parts.Length == 0)
            {
                MessageBox.Show("Sorry no part(s) matching your search criteria was found.");
            }
            else
            {
                dgViewParts.Rows.Clear();
                AddPartsToGridView(parts);
            }
        }

        private void AddPartsToGridView(Part[] parts)
        {
            var dgRows = new DataGridViewRow[parts.Length];

            for (int i = 0; i < dgRows.Length; i++)
            {
                dgRows[i] = new DataGridViewRow();
                string[] stringRow = new string[]
                {
                    parts[i].Id.ToString(),
                    parts[i].Name,
                    parts[i].Weight.ToString(),
                    parts[i].Units.ToString(),
                    parts[i].Stock.ToString(),
                    parts[i].Length.ToString(),
                    parts[i].Width.ToString(),
                    parts[i].SalesPrice.ToString(),
                    parts[i].PurchasePrice.ToString(),
                    parts[i].CreatedAt,
                    parts[i].UpdatedAt
                };

                dgRows[i].CreateCells(dgViewParts, stringRow);
            }

            dgViewParts.Rows.AddRange(dgRows);
        }

        private void dgViewParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want really to delete the selected row(s)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgViewParts.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        Api.Parts.DeletePart(id);
                    }

                    e.Handled = false;
                    RefreshStatistics();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
