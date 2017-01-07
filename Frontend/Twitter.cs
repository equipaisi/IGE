using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Middleware;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Frontend
{
    public static class Twitter
    {
        // Número máximo de fotos permitidas pelo Twitter em cada tweet
        public static readonly int MaxAllowedUploadedPhotos = 4;

        private const string ApiKey = "S4NZKcLJteWjn65vZ8BpwIMiM";
        private const string ApiSecret = "ZCjb25BkYmv1xPcjUjSoPzh5HylLv1NCxBHGnvif4uxjGOojmG";


        /// <summary>
        /// Publica um tweet na conta do Twitter.
        /// </summary>
        /// <param name="message">Tweet a publicar</param>
        /// <param name="images">Imagens incluídas no tweet</param>
        /// <returns>Id do Tweet publicados</returns>
        public static long PostTweet(string message, IEnumerable<string> images)
        {
            Auth.SetUserCredentials(ApiKey, ApiSecret, "811979534086144001-3nxRmr2fSOpLcZpFbC1BvtO8ktUGpJ0", "crTWje5UNtJyr9Ol0yzluUqrGD5xoZelJpssiPUbtjxgM");
            List<IMedia> media = new List<IMedia>(MaxAllowedUploadedPhotos);
            foreach (var imagePath in images)
            {
                byte[] image = File.ReadAllBytes(imagePath);
                media.Add(Upload.UploadImage(image));
            }
            
            ITweet tweet = Tweet.PublishTweet(message, new PublishTweetOptionalParameters
            {
                Medias = media
            });
            return tweet.Id;
        }

        /// <summary>
        /// Retorna uma string representando um tweet.
        /// </summary>
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

    public class TweetTooLongException : Exception
    {
        public TweetTooLongException()
        {
        }

        public TweetTooLongException(string message) : base(message)
        {
        }

        public TweetTooLongException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TweetTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
