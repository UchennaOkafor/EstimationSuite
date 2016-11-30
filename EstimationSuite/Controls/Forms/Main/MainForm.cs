using System;
using System.Drawing;
using Suite.Providers;
using EstimationSuite.Forms.Subform.Forms;
using EstimationSuite.Forms.Subform.Forms.Assign;

namespace EstimationSuite.Forms.Main
{
    public partial class MainForm : RPForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeSubforms();
            RefreshStatistics();
        }

        private void InitializeSubforms()
        {
            tabProjects.Controls.Add(new FormProject());
            tabParts.Controls.Add(new FormParts());
            tabSets.Controls.Add(new FormSets());
            tabAssign.Controls.Add(new FormAssign());
        }

        public async void RefreshStatistics()
        {
            var stats = await Api.Base.GetStatistics();

            lblTotalProjects.Text = $"Total project(s): {stats.TotalProjects}";
            lblTotalSets.Text = $"Total set(s): {stats.TotalSets}";
            lblTotalParts.Text = $"Total part(s): {stats.TotalParts}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resize += (s2, e2) =>
            {
                Size size = tabControl.Size;

                tabProjects.Controls[0].Size = size;
                tabParts.Controls[0].Size = size;
                tabSets.Controls[0].Size = size;
            };
        }

        private void btnRefreshStats_Click(object sender, EventArgs e)
        {
            RefreshStatistics();
        }
    }
}