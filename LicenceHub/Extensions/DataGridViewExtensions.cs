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
    }
}
