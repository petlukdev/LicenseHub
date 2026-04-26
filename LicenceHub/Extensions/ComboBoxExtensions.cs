using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LicenseHub.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void Setup<T>(
            this ComboBox comboBox,
            LocalView<T> items,
            Func<T, FilterItem> map,
            string allText
            ) where T : class
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

        public static void SetupOptionalData<T>(
            this ComboBox comboBox,
            IBindingList list,
            T emptyItem,
            string displayMember = "Name",
            string valueMember = "Id"
            ) where T : class
        {
            void UpdateData()
            {
                var originalValue = comboBox.SelectedValue;

                var displayList = list.Cast<T>().ToList();
                displayList.Insert(0, emptyItem);

                comboBox.DataSource = null;
                comboBox.DataSource = displayList;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;

                if (originalValue != null)
                {
                    comboBox.SelectedValue = originalValue;
                }
            }

            UpdateData();
            list.ListChanged += (sender, e) => UpdateData();
        }
    }
}
