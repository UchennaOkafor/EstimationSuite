using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;
using System.Collections.Generic;
using EstimationSuite.Custom;

namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    public partial class FormAddProjectSet : Form
    {
        private List<CheckedItem<Set>> sets;

        public FormAddProjectSet(int projectId)
        {
            InitializeComponent();
            InitializeSets(projectId);
            Text = $"Add set(s) - Project Id - {projectId}";
        }

        private void InitializeSets(int projectId)
        {
            sets = new List<CheckedItem<Set>>();

            foreach (var set in Api.Projects.GetSetsNotIn(projectId))
            {
                sets.Add(new CheckedItem<Set>() { Item = set });
            }

            lstSets.Items.AddRange(sets.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to add these sets to this project?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var form = Application.OpenForms["FormAssign"] as FormAssign;
                int projectId = (form.lstProjects.SelectedItem as Project).Id;
                var setIds = new List<int>();

                foreach (object item in lstSets.CheckedItems)
                {
                    setIds.Add((item as CheckedItem<Set>).Item.Id);
                }

                Api.Projects.CreateProjectSets(projectId, setIds);
                MessageBox.Show("All set(s) have been successfully added to project");
                Close();
            }
        }

        private void txtSetName_TextChanged(object sender, EventArgs e)
        {
            lstSets.Items.Clear();

            foreach (var checkedSet in sets)
            {
                if (checkedSet.Item.Name.ToLower().Contains(txtSetName.Text.ToLower()))
                {
                    lstSets.Items.Add(checkedSet);
                    lstSets.SetItemCheckState(lstSets.Items.IndexOf(checkedSet), checkedSet.State);
                }
            }
        }

        private void lstSets_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (lstSets.Items[e.Index] as CheckedItem<Set>).State = e.NewValue;
        }
    }
}
