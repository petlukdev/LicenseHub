using LicenseHub.DB;
using LicenseHub.Models;

namespace LicenseHub.Helpers
{
    public class FilterService
    {
        private AppDbContext _db;
        
        public FilterService(AppDbContext db) => _db = db;
        
        public IEnumerable<License> GetFilteredLicenses(
            string search,
            int? ownerId,
            int? supplierId,
            string typeStr,
            string statusStr)
        {
            var query = _db.Licenses.Local.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(l => l.Title.Contains(search, StringComparison.OrdinalIgnoreCase));

            if (Enum.TryParse<LicenseType>(typeStr, out var type))
                query = query.Where(l => l.Type == type);

            if (Enum.TryParse<ExpirationStatus>(statusStr, out var status))
                query = query.Where(l => l.ExpirationStatus == status);

            if (ownerId > 0) query = query.Where(l => l.OwnerId == ownerId);
            if (supplierId > 0) query = query.Where(l => l.SupplierId == supplierId);

            return query;
        }

        public IEnumerable<Owner> GetFilteredOwners(string search, int? departmentId)
        {
            var query = _db.Owners.Local.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(o =>
                    o.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    o.LastName.Contains(search, StringComparison.OrdinalIgnoreCase)
                );

            if (departmentId > 0) query = query.Where(o => o.DepartmentId == departmentId);

            return query;
        }

        public IEnumerable<Supplier> GetFilteredSuppliers(string search)
        {
            var query = _db.Suppliers.Local.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase));

            return query;
        }

        public IEnumerable<Department> GetFilteredDepartments(string search)
        {
            var query = _db.Departments.Local.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(d => d.Name.Contains(search, StringComparison.OrdinalIgnoreCase));

            return query;
        }
    }
}
