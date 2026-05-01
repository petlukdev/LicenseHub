using LicenseHub.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LicenseHub.Services
{
    public class FilterUIManager
    {
        private readonly FilterService _filterService;

        public FilterUIManager(FilterService filterService) => _filterService = filterService;

        public void ApplyLicense(DataGridView grid, Button clearBtn, string search, int? ownerId, int? supplierId, string type, string status)
        {
            var query = _filterService.GetFilteredLicenses(search, ownerId, supplierId, type, status);
            DataGridViewExtensions.ApplyFilters(grid, query);
            clearBtn.Enabled = true;
        }

        public void ApplyOwner(DataGridView grid, Button clearBtn, string search, int? departmentId)
        {
            var query = _filterService.GetFilteredOwners(search, departmentId);
            DataGridViewExtensions.ApplyFilters(grid, query);
            clearBtn.Enabled = true;
        }

        public void ApplySupplier(DataGridView grid, Button clearBtn, string search)
        {
            var query = _filterService.GetFilteredSuppliers(search);
            DataGridViewExtensions.ApplyFilters(grid, query);
            clearBtn.Enabled = true;
        }

        public void ApplyDepartment(DataGridView grid, Button clearBtn, string search)
        {
            var query = _filterService.GetFilteredDepartments(search);
            DataGridViewExtensions.ApplyFilters(grid, query);
            clearBtn.Enabled = true;
        }

        public void Clear<T>(DataGridView grid, Button clearBtn, DbSet<T> dbSet) where T : class
        {
            grid.DataSource = dbSet.Local.ToBindingList();
            clearBtn.Enabled = false;
        }
    }
}
