namespace LicenseHub.Helpers
{
    public static class UIHelper
    {
        public static DataGridView GetCurrentDataGridView(this TabControl tabControl)
        {
            return tabControl.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault()
                ?? throw new InvalidOperationException("No grid found");
        }

        public static void ExecuteSafe(Action action, string errorMessage)
        {
            try { action(); }
            catch (Exception ex) { MessageViewer.ShowError(errorMessage, ex.Message); }
        }
    }
}