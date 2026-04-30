using System;
using System.Collections.Generic;
using System.Text;

namespace LicenseHub.Helpers
{
    public static class MessageViewer
    {
        public static void ShowError(string message, string error)
        {
            MessageBox.Show(
                $"{message}\n\nERROR:\n{error}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
