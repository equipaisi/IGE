using System.Collections.Generic;
using System.IO;
using System.Linq;
using Middleware;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Frontend
{
    public static class Twitter
    {
        // Número máximo de fotos permitidas pelo Twitter em cada tweet
        private const int MaxAllowedUploadedPhotos = 4;

        private const string ApiKey = "S4NZKcLJteWjn65vZ8BpwIMiM";
        private const string ApiSecret = "ZCjb25BkYmv1xPcjUjSoPzh5HylLv1NCxBHGnvif4uxjGOojmG";
        private const string UserAcessToken = "811979534086144001-3nxRmr2fSOpLcZpFbC1BvtO8ktUGpJ0";
        private const string UserAcessSecret = "crTWje5UNtJyr9Ol0yzluUqrGD5xoZelJpssiPUbtjxgM";

        /// <summary>
        /// Publica um tweet na conta do Twitter.
        /// </summary>
        /// <param name="message">Tweet a publicar</param>
        /// <param name="images">Fotos incluídas no tweet</param>
        /// <exception cref="NoPhotosException">Não foi incluida nenhuma foto no tweet</exception>
        /// <returns>Id do Tweet publicado</returns>
        public static long PostTweet(string message, IList<string> images)
        {
            // Precisamos de pelo menos uma foto no tweet
            if (images.Count < 1) throw new NoPhotosException();

            // Realizar a autenticação
            Auth.SetUserCredentials(ApiKey, ApiSecret, UserAcessToken, UserAcessSecret);

            #region Imagens
            List<IMedia> media = new List<IMedia>(MaxAllowedUploadedPhotos);
            foreach (var imagePath in images.Take(MaxAllowedUploadedPhotos))
            {
                byte[] image = File.ReadAllBytes(imagePath);
                media.Add(Upload.UploadImage(image));
            }
            #endregion

            // Publicar tweet
            ITweet tweet = Tweet.PublishTweet(message, new PublishTweetOptionalParameters
            {
                Medias = media
            });

            // Retornar o número de identificação (Id) do tweet
            return tweet.Id;
        }

        /// <summary>
        /// Retorna uma string representando um tweet.
        /// </summary>
        /// <exception cref="TweetTooLongException">Limite de caracteres permitido excedido</exception>
        public static string CreateTweet(IHabitacao habitacao)
        {
            var custosIncluidos = habitacao.IncluiDespesas ? " (c/ custos inc.)" : "";
            var message =
                $"{habitacao.TQuartos}, {habitacao.MetrosQuadrados} m2, {habitacao.CustoMensal} €/mês por quarto{custosIncluidos}, contruído em {habitacao.AnoDeConstrucao}, {habitacao.Morada.Localidade}";

            // Um tweet não pode ter mais do que a 140 caracteres
            if (message.Length > 140) throw new TweetTooLongException();

            return message;
        }
    }
}
