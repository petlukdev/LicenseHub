using LicenseHub.DB;
using LicenseHub.Extensions;
using LicenseHub.Helpers;
using LicenseHub.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenseHub.Services
{
    public class FormInitializer
    {
        private readonly AppDbContext _db;

        public FormInitializer(AppDbContext db) => _db = db;

        public void PopulateDataGrids(DataGridView dgLicense, DataGridView dgOwner, DataGridView dgSupplier, DataGridView dgDepartment)
        {
            _db.Licenses.Load();
            _db.Owners.Load();
            _db.Suppliers.Load();
            _db.Departments.Load();

            dgLicense.DataSource = _db.Licenses.Local.ToBindingList();
            dgOwner.DataSource = _db.Owners.Local.ToBindingList();
            dgSupplier.DataSource = _db.Suppliers.Local.ToBindingList();
            dgDepartment.DataSource = _db.Departments.Local.ToBindingList();

            DataGridView[] dataGrids = { dgLicense, dgOwner, dgSupplier, dgDepartment };

            foreach (var view in dataGrids)
            {
                view.AutoGenerateColumns = false;
                view.DataBindingComplete += (s, e) =>
                {
                    view.ClearSelection();
                    view.CurrentCell = null;
                };
            }
        }

        public void PopulateCombos(ComboBox cbOwner, ComboBox cbSupplier, ComboBox cbDepartment, ComboBox cbType, ComboBox cbStatus)
        {
            cbOwner.Setup(_db.Owners.Local, o => new FilterItem { Id = o.Id, Text = o.ToString() }, "All Owners");
            cbSupplier.Setup(_db.Suppliers.Local, s => new FilterItem { Id = s.Id, Text = s.Name }, "All Suppliers");
            cbDepartment.Setup(_db.Departments.Local, d => new FilterItem { Id = d.Id, Text = d.Name }, "All Departments");

            List<string> types = Enum.GetNames<LicenseType>().ToList();
            types.Insert(0, "All Types");

            List<string> statuses = Enum.GetNames<ExpirationStatus>().ToList();
            statuses.Insert(0, "All Statuses");

            cbType.DataSource = types;
            cbStatus.DataSource = statuses;
        }
    }
}
