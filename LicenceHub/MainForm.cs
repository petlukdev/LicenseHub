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
            Form form = new OwnerForm();
            form.ShowDialog();
        }
    }
}
