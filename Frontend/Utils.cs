using System;
using System.Windows.Forms;

namespace Frontend
{
    internal static class Utils
    {
        private static string ParseApplicationVersion()
        {
            var version = new Version(Application.ProductVersion);
            return $"{version.Major}.{version.Minor}.{version.Revision}";
        }
    }
}