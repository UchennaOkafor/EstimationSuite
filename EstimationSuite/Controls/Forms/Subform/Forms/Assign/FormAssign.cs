using EstimationSuite.Forms.Subform.Base;
using Suite.Models;
using Suite.Providers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    public partial class FormAssign : SubRpForm
    {
        private Project[] latestProjects;

        public FormAssign()
        {
            InitializeComponent();
            InitializeListBoxEvents();
            latestProjects = new Project[] { };
        }

        private void InitializeListBoxEvents()
        {
            lstProjects.Tag = contextMenuProjects;
            lstSets.Tag = contextMenuSets;
            lstParts.Tag = contextMenuParts;

            foreach (var lstBox in new ListBox[] { lstProjects, lstSets, lstParts })
            {
                lstBox.MouseDown += (o, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        ((RPContextMenuStrip)lstBox.Tag).Show(MousePosition);
                    }
                };
            }
        }

        private void ClearListBoxes()
        {
            lstProjects.Items.Clear();
            lstSets.Items.Clear();
            lstParts.Items.Clear();
        }

        private void tsmRefreshProjectList_Click(object sender, EventArgs e)
        {
            ClearListBoxes();

            latestProjects = Api.Projects.GetAllProjects();

            if (latestProjects.Length == 0)
            {
                MessageBox.Show("Sorry there are currently no projects");
            }
            else
            {
                lstProjects.Items.AddRange(latestProjects);
            }
        }

        private void tsmViewReport_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndex > -1)
            {
                int projectId = (lstProjects.SelectedItem as Project).Id;
                Process.Start(Api.Projects.GetReportUrl(projectId));
            }
        }

        private void txtProjectFilter_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtProjectFilter.Text.ToLower();
            var filteredProjects = new List<Project>();

            foreach (Project project in latestProjects)
            {
                if (project.Name.ToLower().Contains(searchValue))
                {
                    filteredProjects.Add(project);
                }
            }

            lstProjects.Items.Clear();
            lstProjects.Items.AddRange(filteredProjects.ToArray());
        }

        private void txtSetFilter_TextChanged(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndex > -1)
            {
                string searchValue = txtSetFilter.Text.ToLower();
                var filteredSets = new List<Set>();
                var selectedProject = (Project)lstProjects.SelectedItem;

                foreach (Set set in selectedProject.Sets)
                {
                    if (set.Name.ToLower().Contains(searchValue))
                    {
                        filteredSets.Add(set);
                    }
                }

                lstSets.Items.Clear();
                lstSets.Items.AddRange(filteredSets.ToArray());
            }
        }

        private void txtPartFilter_TextChanged(object sender, EventArgs e)
        {
            if (lstSets.SelectedIndex > -1)
            {
                string searchValue = txtPartFilter.Text.ToLower();
                var filteredParts = new List<Part>();
                var selectedSet = (Set)lstSets.SelectedItem;

                foreach (Part part in selectedSet.Parts)
                {
                    if (part.Name.ToLower().Contains(searchValue))
                    {
                        filteredParts.Add(part);
                    }
                }

                lstParts.Items.Clear();
                lstParts.Items.AddRange(filteredParts.ToArray());
            }
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndex > -1)
            {
                lstSets.Items.Clear();
                lstParts.Items.Clear();

                txtSetFilter.Clear();
                txtPartFilter.Clear();

                var selectedProject = (Project)lstProjects.SelectedItem;
                lstSets.Items.AddRange(selectedProject.Sets.ToArray());
            }
        }

        private void lstSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSets.SelectedIndex > -1)
            {
                lstParts.Items.Clear();

                var selectedSet = (Set)lstSets.SelectedItem;
                lstParts.Items.AddRange(selectedSet.Parts.ToArray());
            }
        }

        private void tsmAddNewSets_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure you've selected a project");
                return;
            }

            int projectId = (lstProjects.SelectedItem as Project).Id;
            new FormAddProjectSet(projectId).ShowDialog();
        }

        private void tsmRemoveSelectedSets_Click(object sender, EventArgs e)
        {
            if (lstSets.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure you've selected a list of set(s) to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected set(s)?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in lstSets.SelectedItems)
                {
                    var set = item as Set;
                    Api.Projects.DeleteProjectSet(set.Pivot.ProjectSetId);
                }

                MessageBox.Show("All selected set(s) have been deleted");
            }
        }

        private void tsmAddNewParts_Click(object sender, EventArgs e)
        {
            if (lstSets.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure you've selected a set");
                return;
            }

            int projectSetId = (lstSets.SelectedItem as Set).Pivot.ProjectSetId;
            new FormAddSetPart(projectSetId).ShowDialog();
        }

        private void tsmRemoveSelectedParts_Click(object sender, EventArgs e)
        {
            if (lstParts.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure you've selected a list of part(s) to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected part(s)?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int projectSetId = (lstSets.SelectedItem as Set).Pivot.ProjectSetId;
                foreach (var item in lstParts.SelectedItems)
                {
                    var part = item as Part;
                    Api.Sets.DeleteSetPart(projectSetId, part.Id);
                }

                MessageBox.Show("All selected part(s) have been deleted");
            }
        }
    }
}