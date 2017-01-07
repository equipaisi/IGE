using System;
using System.Collections.Generic;
using Facebook;
using Middleware;

namespace Frontend
{
    public static class Facebook
    {
        private const string PageId = "1790653341199179";
        private const string AppId = "1797812087146101";
        private const string AppSecret = "73d6a5ade078880f0bf2e0f71360118a";
        private const string AccessToken =
            "EAAZAjGb7TxnUBAGSWDZCaZB6ByiVZCtZBfyty6Mr2MXVSrv2VvvdPVcJOheWRnd3ZCMW0XvKqzB1ZBy3jbdsum0CVwOq4fCiteuer1t6PZCZAvjgd8aUMm7ZAukeTWssNy7lQthDqjgvjVFg8gM8a3nw83KvXNDITRZBZASyCRMKH5eskAZDZD";

        /// <summary>
        /// Publica um post na página do Facebook.
        /// </summary>
        /// <param name="message">Post a publicar</param>
        public static object PublishPost(string message, FacebookMediaObject media)
        {
            FacebookClient client = new FacebookClient(AccessToken)
            {
                AppId = AppId,
                AppSecret = AppSecret
            };
            return client.Post($"{PageId}/photos?", new Dictionary<string, object>
            {
                {"message", message},
                {"source", media}
            });
        }

        /// <summary>
        /// Retorna uma string representando um post.
        /// </summary>
        public static string CreatePost(IHabitacao habitacao)
        {
            var despesas = habitacao.IncluiDespesas ? "(Inclui despesas)" : "(Não inclui despesas)";

            #region Comodidades

            var televisao = habitacao.Comodidades.Televisao ? "Televisão" : string.Empty;
            var internet = habitacao.Comodidades.Internet ? "Internet" : string.Empty;
            var limpeza = habitacao.Comodidades.ServicoDeLimpeza ? "Serviço de Limpeza" : string.Empty;
            var com = string.Join(", ", new List<string> { televisao, internet, limpeza });

            #endregion

            var message =
                $@"{habitacao.Descricao}

Morada: {habitacao.Morada.Arruamento}, {habitacao.Morada.CodigoPostal}, {habitacao
                    .Morada.Localidade}
Metros quadrados: {habitacao.MetrosQuadrados} m2
Ano de construção: {habitacao
                        .AnoDeConstrucao}
Custo mensal de um quarto: {habitacao.CustoMensal}€ {despesas}
Quartos: {habitacao
                            .NumeroDeQuartos}
Assoalhadas: {habitacao.NumeroDeAssoalhadas}
Casas de banho:  {habitacao.NumeroDeWcs}
Com {com} íncluido!
";
            return message;
        }

    }
}