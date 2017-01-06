using System.Collections.Generic;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Frontend
{
    public static class Twitter
    {
        public static readonly int MaxAllowedUploadedPhotos = 4;

        private const string ApiKey = "S4NZKcLJteWjn65vZ8BpwIMiM";
        private const string ApiSecret = "ZCjb25BkYmv1xPcjUjSoPzh5HylLv1NCxBHGnvif4uxjGOojmG";

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
    }
}
