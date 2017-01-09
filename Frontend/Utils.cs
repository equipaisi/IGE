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
                {"cafe", "café"},
                {"dentist", "dentista"},
                {"church", "igreja"},
                {"city_hall", "câmara municipal"},
                {"clothing_store", "loja de roupa"},
                {"doctor", "médico"},
                {"gym", "ginásio"},
                {"store", "loja"},
                {"police", "polícia"},
                {"school", "escola"},
                {"restaurant", "restaurante"},
                {"park", "parque"},
                {"museum", "museu"},
                {"pharmacy", "farmácia"},
                {"university", "universidade"},
                {"establishment", "establecimento"},
                {"food", "comida"},
                {"finance", "finanças"},
                {"veterinary_care", "veterinário"},
                {"health", "saúde"},
                {"local_government_office", "escritório de governo local"},
                {"political", "politico" },
                {"beauty_salon", "salão de beleza" },
                {"locality", "localidade" },
                {"bus_station", "estação de autocarros" },
                {"transit_station", "estação de trânsito" },          
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