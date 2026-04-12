using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace LicenseHub.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void Setup<T>(this ComboBox comboBox, LocalView<T> items, Func<T, FilterItem> map, string allText) where T : class
        {
            void UpdateData()
            {
                var displayData = items.Select(map).ToList();
                displayData.Insert(0, new FilterItem { Id = 0, Text = allText });

                comboBox.DataSource = null;
                comboBox.DataSource = displayData;
                comboBox.DisplayMember = "Text";
                comboBox.ValueMember = "Id";
            }

            UpdateData();
            items.CollectionChanged += (sender, e) => UpdateData();
        }
    }
}
