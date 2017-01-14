using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Facebook;
using Middleware;

namespace Frontend
{
    public static class Facebook
    {
        private const int MaxAllowedUploadedPhotos = 5;  
        private const int MaxPhotoSizeInMegabytes = 4000000;

        private const string PageId = "1790653341199179";
        private const string AppId = "1797812087146101";
        private const string AppSecret = "73d6a5ade078880f0bf2e0f71360118a";
        private const string AccessToken =
            "EAAZAjGb7TxnUBAGSWDZCaZB6ByiVZCtZBfyty6Mr2MXVSrv2VvvdPVcJOheWRnd3ZCMW0XvKqzB1ZBy3jbdsum0CVwOq4fCiteuer1t6PZCZAvjgd8aUMm7ZAukeTWssNy7lQthDqjgvjVFg8gM8a3nw83KvXNDITRZBZASyCRMKH5eskAZDZD";

        /// <summary>
        /// Publica um post na página do Facebook.
        /// </summary>
        /// <param name="message">Post a publicar</param>
        /// <param name="images">Fotos incluídas no post</param>
        /// <exception cref="ExcessiveImageFilesizeException">Tamanho de foto demasiado grande</exception>
        /// <exception cref="NoPhotosException">Não foi incluida nenhuma foto no post</exception>
        public static object PublishPost(string message, IList<string> images)
        {
            // Precisamos de pelo menos uma foto no post
            if (images.Count < 1) throw new NoPhotosException();

            // Criar um cliente autenticado
            var client = new FacebookClient(AccessToken)
            {
                AppId = AppId,
                AppSecret = AppSecret
            };

            #region Imagens
            // TODO: If you upload a PNG file, try keep the file size below 1 MB. PNG files larger than 1 MB may appear pixelated after upload.

            var ids = new List<string>(MaxAllowedUploadedPhotos);
            foreach (var imagePath in images.Take(MaxAllowedUploadedPhotos))
            {
                // De acordo com a documentacao Graph API: "Check the file size of your photos. We recommend uploading photos under 4MB."
                var imageSize = new FileInfo(imagePath).Length;
                if (imageSize > MaxPhotoSizeInMegabytes)
                    throw new ExcessiveImageFilesizeException(); // Path.GetFileName(imagePath), imageSize

                var img = Image.FromFile(imagePath);
                var foto = (byte[]) new ImageConverter().ConvertTo(img, typeof(byte[]));
                var media = new FacebookMediaObject
                {
                    ContentType = "image/jpeg", // BUG: what if this image is NOT a jpeg?
                    FileName = Path.GetFileName(imagePath),
                }.SetValue(foto);

                var response = client.Post($"{PageId}/photos?", new Dictionary<string, object>
                {
                    {"source", media},
                    {"published", false}
                }) as JsonObject;

                if (response != null) ids.Add(response["id"] as string);
            }
            #endregion

            // Publicar post e retornar a resposta
            var parameters = new Dictionary<string, object>
            {
                {"message", message}
            };

            for (var i = 0; i < ids.Count; i++)
            {
                var a = "\"media_fbid\"";
                var b = $"\"{ids[i]}\"";
                parameters[$"attached_media[{i}]"] = $"{{{a}:{b}}}";
            }

            return client.Post($"{PageId}/feed?", parameters);
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

            string message =
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