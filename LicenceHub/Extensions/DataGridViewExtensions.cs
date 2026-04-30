using LicenseHub.Models;
using System.ComponentModel;
using License = LicenseHub.Models.License;

namespace LicenseHub.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void RefreshCurrentRow(this DataGridView view)
        {
            if (view.CurrentRow is not null)
            {
                view.InvalidateRow(view.CurrentRow.Index);
            }
        }

        public static void ApplyFilters<TEntity>(
            DataGridView grid,
            IEnumerable<TEntity> query
            ) where TEntity : class
        {
            grid.DataSource = new BindingList<TEntity>(query.ToList());
        }

        public static void FormatLicenseCell(DataGridViewCellFormattingEventArgs e, License license)
        {
            if (license.ExpirationStatus == ExpirationStatus.Expired)
            {
                e.CellStyle.BackColor = Color.LightCoral;
            }
            else if (license.ExpirationStatus == ExpirationStatus.ExpiringSoon)
            {
                e.CellStyle.BackColor = Color.LightGoldenrodYellow;
            }
        }
    }
}
