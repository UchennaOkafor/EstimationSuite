using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;
using EstimationSuite.Forms.Subform.Base;

namespace EstimationSuite.Forms.Subform.Forms
{
    public partial class FormProject : SubRpForm
    {
        public FormProject()
        {
            InitializeComponent();
            cboAttribute.SelectedIndex = 0;

            dgViewProjects.CellValueChanged += dgViewProjects_CellValueChanged;
        }

        private void dgViewProjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgViewProjects.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells[0].Value);
            string name = row.Cells[1].Value.ToString();

            Api.Projects.EditProject(new Project()
            {
                Id = id,
                Name = name
            });
        }

        private void dgViewProjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want really to delete the selected row(s)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgViewProjects.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        Api.Projects.DeleteProject(id);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Project[] projects = null;
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                projects = Api.Projects.GetProjectsByName("%");
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

                    projects = new Project[] { Api.Projects.GetProjectById(id) };
                }
                else if (cboAttribute.SelectedItem.ToString() == "Name")
                {
                    projects = Api.Projects.GetProjectsByName(input);
                }
            }

            if (projects[0] == null || projects.Length == 0)
            {
                MessageBox.Show("Sorry no project(s) matching your search criteria was found.");
            }
            else
            {
                dgViewProjects.Rows.Clear();
                AddProjectsToGridView(projects);
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            new FormAddProject().ShowDialog();
            RefreshStatistics();
        }

        private void AddProjectsToGridView(Project[] projects)
        {
            var dgRows = new DataGridViewRow[projects.Length];

            for (int i = 0; i < dgRows.Length; i++)
            {
                dgRows[i] = new DataGridViewRow();
                string[] stringRow = new string[]
                {
                    projects[i].Id.ToString(),
                    projects[i].Name,
                    projects[i].CreatedAt,
                    projects[i].UpdatedAt
                };
                dgRows[i].CreateCells(dgViewProjects, stringRow);
            }

            dgViewProjects.Rows.AddRange(dgRows);
        }
    }
}