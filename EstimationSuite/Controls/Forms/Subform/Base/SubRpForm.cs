using EstimationSuite.Forms.Main;
using System.Windows.Forms;

namespace EstimationSuite.Forms.Subform.Base
{
    public class SubRpForm : RPForm
    {
        public SubRpForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;
            Show();
        }

        protected void RefreshStatistics()
        {
            (Application.OpenForms["MainForm"] as MainForm).RefreshStatistics();
        }
    }
}