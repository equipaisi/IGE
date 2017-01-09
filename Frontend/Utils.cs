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

            var ts = new Dictionary<string, string>(types.Count)
            {
                {"airport", "aeroporto"},
                {"cafe", "caf�"},
                {"dentist", "dentista"},
                {"church", "igreja"},
                {"city_hall", "c�mara municipal"},
                {"clothing_store", "loja de roupa"},
                {"doctor", "m�dico"},
                {"gym", "gin�sio"},
                {"store", "loja"},
                {"police", "pol�cia"},
                {"school", "escola"},
                {"restaurant", "restaurante"},
                {"park", "parque"},
                {"museum", "museu"},
                {"pharmacy", "farm�cia"},
                {"university", "universidade"},
                {"establishment", "establecimento"},
                {"food", "comida"},
                {"finance", "finan�as"},
                {"veterinary_care", "veterin�rio"},
                {"health", "sa�de"},
                {"local_government_office", "escrit�rio de governo local"},
                {"political", "politico" },
                {"beauty_salon", "sal�o de beleza" },
                {"locality", "localidade" },
                {"bus_station", "esta��o de autocarros" },
                {"transit_station", "esta��o de tr�nsito" },          
                {"hair_care", "cabeleireiro" },

            };

            var xs = new List<string>(types.Count);
            foreach (var t in types)
            {
                xs.Add(ts.ContainsKey(t) ? ts[t] : t);
            }
            return $"Categoria: {string.Join(", ", xs)}";
        }
    }
}