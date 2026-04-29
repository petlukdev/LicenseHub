using System;
using System.Collections.Generic;
using System.Text;

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
            grid.DataSource = new System.ComponentModel.BindingList<TEntity>(query.ToList());
        }

        public static IEnumerable<T> ApplyTextFilter<T>(
            IEnumerable<T> source,
            Func<T, string> selector,
            string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return source;

            return source.Where(x => selector(x).Contains(text, StringComparison.OrdinalIgnoreCase));
        }
    }
}
