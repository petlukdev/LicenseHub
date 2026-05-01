using LicenseHub.DB;
using LicenseHub.Extensions;
using LicenseHub.Factories;
using LicenseHub.Helpers;
using LicenseHub.Services;
using Microsoft.EntityFrameworkCore;
using License = LicenseHub.Models.License;

namespace LicenceHub
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly FilterService _filterService;
        private readonly FormFactory _formFactory;
        private readonly DialogService _dialogService;
        private readonly FilterUIManager _filterUIManager;
        private readonly StatsService _statsService;
        private readonly FormInitializer _formInitializer;

        public MainForm()
        {
            InitializeComponent();

            _dbContext = new();
            _dbContext.Database.Migrate();

            _filterService = new(_dbContext);
            _formFactory = new(_dbContext);
            _dialogService = new(_dbContext);
            _statsService = new(_dbContext);
            _formInitializer = new(_dbContext);

            _filterUIManager = new(_filterService);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _formInitializer.PopulateDataGrids(dataGridLicense, dataGridOwner, dataGridSupplier, dataGridDepartment);
            _formInitializer.PopulateCombos(comboOwner, comboSupplier, comboDepartment, comboTypeLicense, comboExpiration);
            RefreshStats();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _dbContext.Dispose();
        }

        private void AddEntryEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            string? tabName = tabControl.SelectedTab?.Name;
            if (string.IsNullOrWhiteSpace(tabName)) return;

            bool wasAdded = _dialogService.AddEntity(_formFactory.CreateAddForm(tabName));

            if (wasAdded) RefreshStats();
        }, "An error occurred while trying to add a new entry.");

        private void ModifyEntryEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            DataGridView view = UIHelper.GetCurrentDataGridView(tabControl);

            if (view.SelectedRows.Count == 0) return;
            if (view.SelectedRows.Count > 1)
                throw new ArgumentException("Multiple rows selected. Please select only one row to modify.");

            var selectedEntity = view.SelectedRows[0].DataBoundItem
                ?? throw new ArgumentException("Selected row does not have a valid data bound item.");

            string? tabName = tabControl.SelectedTab?.Name;
            if (string.IsNullOrWhiteSpace(tabName)) return;

            bool wasModified = _dialogService.ModifyEntity(_formFactory.CreateEditForm(tabName, selectedEntity), selectedEntity);

            if (wasModified)
            {
                view.RefreshCurrentRow();
                RefreshStats();
            }
        }, "An error occurred while trying to modify an entry.");

        private void DeleteEntryEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            DataGridView view = tabControl.GetCurrentDataGridView();
            if (view.SelectedRows.Count == 0) return;

            var entitiesToDelete = view.SelectedRows.Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem)
                .Where(item => item is not null)
                .Cast<object>();

            if (_dialogService.DeleteEntities(entitiesToDelete)) RefreshStats();
        }, "An error occurred while trying to delete an entry.");

        private void ApplyFilterEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            switch (tabControl.SelectedTab?.Name)
            {
                case "licensePage":
                    _filterUIManager.ApplyLicense(dataGridLicense, btnClearLicense,
                        searchLicense.Text.Trim(),
                        comboOwner.SelectedValue as int?,
                        comboSupplier.SelectedValue as int?,
                        comboTypeLicense.Text,
                        comboExpiration.Text
                    );
                    break;

                case "supplierPage":
                    _filterUIManager.ApplySupplier(dataGridSupplier, btnClearSupplier, searchSupplier.Text);
                    break;

                case "ownerPage":
                    _filterUIManager.ApplyOwner(dataGridOwner, btnClearOwner, searchOwner.Text.Trim(), comboDepartment.SelectedValue as int?);
                    break;

                case "departmentPage":
                    _filterUIManager.ApplyDepartment(dataGridDepartment, btnClearDepartment, searchDepartment.Text);
                    break;

                default:
                    throw new ArgumentException("Unknown tab selected");
            }
        }, "An error occurred while trying to filter an entries.");

        private void ClearFilterEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            switch (tabControl.SelectedTab?.Name)
            {
                case "licensePage":
                    _filterUIManager.Clear(dataGridLicense, btnClearLicense, _dbContext.Licenses);
                    break;

                case "supplierPage":
                    _filterUIManager.Clear(dataGridSupplier, btnClearSupplier, _dbContext.Suppliers);
                    break;

                case "ownerPage":
                    _filterUIManager.Clear(dataGridOwner, btnClearOwner, _dbContext.Owners);
                    break;

                case "departmentPage":
                    _filterUIManager.Clear(dataGridDepartment, btnClearDepartment, _dbContext.Departments);
                    break;

                default:
                    throw new ArgumentException("Unknown tab selected");
            }
        }, "An error occurred while trying to clear a filters.");

        private void LicenseCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridLicense.Rows[e.RowIndex].DataBoundItem is License license)
            {
                DataGridViewExtensions.FormatLicenseCell(e, license);
            }
        }

        private void RefreshStats()
        {
            var stats = _statsService.GetLicenseStats();

            lblTotalLicenses.Text = stats.Total.ToString();
            lblExpire30Days.Text = stats.ExpiringSoon.ToString();
            lblExpired.Text = stats.Expired.ToString();
        }
    }
}
