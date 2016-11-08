using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Middleware
{
    public interface IRedeSocial
    {
        /// <summary>
        /// O nome da rede social em questão. (eg: Facebook)
        /// </summary>
        string Nome { get; }

        /// <summary>
        /// O Uri (Uniform Resource Identifier) da rede social. (eg: "https://www.facebook.com")
        /// </summary>
        Uri Uri { get; }
    }

    public class RedeSocial: IRedeSocial
    {
        public RedeSocial(string nome, string uri)
        {
            Nome = nome;
            Uri = new Uri(uri);
        }
        public string Nome { get; }
        public Uri Uri { get; }
    }
}
