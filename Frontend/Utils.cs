using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    internal static class Utils
    {
        private static string ParseApplicationVersion()
        {
            Version version = new Version(Application.ProductVersion);
            return $"{version.Major}.{version.Minor}.{version.Revision}";
        }


        public static string FormatPontosDeInteresse(IList<string> types)
        {
            types.Remove("point_of_interest");
            return $"Categoria: {types[0]}";
        }
    }
}