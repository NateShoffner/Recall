namespace Recall
{
    public partial class MainForm : Form
    {
        RecallService recallService;

        public MainForm()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "recall.db");
            recallService = new RecallService(dbPath);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recallService.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recallService.Enabled = false;
        }
    }
}