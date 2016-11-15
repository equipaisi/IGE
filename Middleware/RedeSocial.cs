using System;

namespace Middleware
{
    public interface IRedeSocial
    {
        /// <summary>
        /// O nome da rede social em questão. (eg: Facebook)
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// O Uri (Uniform Resource Identifier) da rede social. (eg: "https://www.facebook.com")
        /// </summary>
        Uri Uri { get; set; }
    }

    public class RedeSocial: IRedeSocial
    {
        public RedeSocial(string nome, string uri)
        {
            Nome = nome;
            Uri = new Uri(uri);
        }
        public string Nome { get; set; }
        public Uri Uri { get; set; }
    }
}
