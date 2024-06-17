using Recall.Services;
using System.Diagnostics;

namespace Recall
{
    public partial class MainForm : Form
    {
        RecallService recallService;

        public MainForm()
        {
            InitializeComponent();
        }
        private void ToggleService(object sender, EventArgs e)
        {
            if (recallService.Enabled)
            {
                recallService.Enabled = false;
                toggleMenuItem.Text = "Enable";
                btnToggle.Text = "Enable";
            }
            else
            {
                recallService.Enabled = true;
                toggleMenuItem.Text = "Disable";
                btnToggle.Text = "Disable";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "recall.db");
            recallService = new RecallService(dbPath);
        }

        private void lblIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo("https://icons8.com/icons/set/eye")
            {
                UseShellExecute = true,
            };
            Process.Start(psi);
        }
    }
}