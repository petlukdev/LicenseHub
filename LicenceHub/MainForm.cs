using LicenseHub.Forms;

namespace LicenceHub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddEntryEvent(object sender, EventArgs e)
        {
            LicenseForm form = new LicenseForm();
            form.ShowDialog();
        }
    }
}
