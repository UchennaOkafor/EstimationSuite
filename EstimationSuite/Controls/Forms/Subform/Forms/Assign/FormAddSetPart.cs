using System;
using Suite.Models;
using Suite.Providers;
using System.Windows.Forms;
using System.Collections.Generic;
using EstimationSuite.Custom;

namespace EstimationSuite.Forms.Subform.Forms.Assign
{
    public partial class FormAddSetPart : Form
    {
        private List<CheckedItem<Part>> parts;

        public FormAddSetPart(int projectSetId)
        {
            InitializeComponent();
            InitializeParts(projectSetId);
            Text = $"Add part(s) - Project Set Id - {projectSetId}";
        }

        private void InitializeParts(int projectSetId)
        {
            parts = new List<CheckedItem<Part>>();

            foreach (var part in Api.Projects.GetPartsNotIn(projectSetId))
            {
                parts.Add(new CheckedItem<Part>() { Item = part });
            }

            lstParts.Items.AddRange(parts.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to add these parts to this set?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                var form = Application.OpenForms["FormAssign"] as FormAssign;
                int projectSetId = (form.lstSets.SelectedItem as Set).Pivot.ProjectSetId;
                var partIds = new List<int>();

                foreach (object item in lstParts.CheckedItems)
                {
                    partIds.Add((item as CheckedItem<Part>).Item.Id);
                }

                Api.Sets.CreateSetParts(projectSetId, partIds);
                MessageBox.Show("All part(s) have been successfully added to set");
                Close();
            }
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            lstParts.Items.Clear();

            foreach (var checkedItem in parts)
            {
                if (checkedItem.Item.Name.ToLower().Contains(txtPartName.Text.ToLower()))
                {
                    lstParts.Items.Add(checkedItem);
                    lstParts.SetItemCheckState(lstParts.Items.IndexOf(checkedItem), checkedItem.State);
                }
            }
        }

        private void lstParts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (lstParts.Items[e.Index] as CheckedItem<Part>).State = e.NewValue;
        }
    }
}