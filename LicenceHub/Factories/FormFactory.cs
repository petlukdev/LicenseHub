using LicenseHub.DB;
using LicenseHub.Forms;
using LicenseHub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LicenseHub.Factories
{
    public class FormFactory
    {
        private AppDbContext _db;

        public FormFactory(AppDbContext db) => _db = db;

        public Form CreateAddForm(string? tabName) => tabName switch
        {
            "licensePage" => new LicenseForm(_db.Owners.Local.ToBindingList(), _db.Suppliers.Local.ToBindingList(), _db.Departments.Local.ToBindingList()),
            "supplierPage" => new SupplierForm(),
            "ownerPage" => new OwnerForm(_db.Departments.Local.ToBindingList()),
            "departmentPage" => new DepartmentForm(),
            _ => throw new ArgumentException("Invalid tab name")
        };

        public Form CreateEditForm(string? tabName, object entity) => tabName switch
        {
            "licensePage" => new LicenseForm((License)entity, _db.Owners.Local.ToBindingList(), _db.Suppliers.Local.ToBindingList(), _db.Departments.Local.ToBindingList()),
            "supplierPage" => new SupplierForm((Supplier)entity),
            "ownerPage" => new OwnerForm((Owner)entity, _db.Departments.Local.ToBindingList()),
            "departmentPage" => new DepartmentForm((Department)entity),
            _ => throw new ArgumentException("Invalid tab name")
        };
    }
}
