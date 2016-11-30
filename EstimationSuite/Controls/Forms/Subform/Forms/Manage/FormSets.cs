using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;
using EstimationSuite.Forms.Subform.Base;

namespace EstimationSuite.Forms.Subform.Forms
{
    public partial class FormSets : SubRpForm
    {
        public FormSets()
        {
            InitializeComponent();
            cboAttribute.SelectedIndex = 0;

            dgViewSets.CellValueChanged += dgViewSets_CellValueChanged;
        }

        private void dgViewSets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgViewSets.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells[0].Value);
            string name = row.Cells[1].Value.ToString();
            double salesPrice = Convert.ToDouble(row.Cells[2].Value);
            double purchasePrice = Convert.ToDouble(row.Cells[3].Value);

            Api.Sets.EditSet(new Set()
            {
                Id = id,
                Name = name
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Set[] sets = null;
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                sets = Api.Sets.GetSetsByName("%");
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

                    sets = new Set[] { Api.Sets.GetSetById(id) };
                }
                else if (cboAttribute.SelectedItem.ToString() == "Name")
                {
                    sets = Api.Sets.GetSetsByName(input);
                }
            }

            if (sets[0] == null || sets.Length == 0)
            {
                MessageBox.Show("Sorry no set(s) matching your search criteria was found.");
            }
            else
            {
                dgViewSets.Rows.Clear();
                AddSetsToGridView(sets);
            }
        }

        private void AddSetsToGridView(Set[] sets)
        {
            var dgRows = new DataGridViewRow[sets.Length];

            for (int i = 0; i < dgRows.Length; i++)
            {
                dgRows[i] = new DataGridViewRow();
                string[] stringRow = new string[]
                {
                    sets[i].Id.ToString(),
                    sets[i].Name,
                    sets[i].CreatedAt,
                    sets[i].UpdatedAt
                };

                dgRows[i].CreateCells(dgViewSets, stringRow);
            }

            dgViewSets.Rows.AddRange(dgRows);
        }

        private void btnAddSet_Click(object sender, EventArgs e)
        {
            new FormAddSet().ShowDialog();
            RefreshStatistics();
        }

        private void dgViewSets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want really to delete the selected row(s)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgViewSets.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        Api.Sets.DeleteSet(id);
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
