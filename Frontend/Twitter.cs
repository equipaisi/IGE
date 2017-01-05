using System.IO;
using Tweetinvi;
using Tweetinvi.Parameters;

namespace Frontend
{
    public static class Twitter
    {
        private const string ApiKey = "S4NZKcLJteWjn65vZ8BpwIMiM";
        private const string ApiSecret = "ZCjb25BkYmv1xPcjUjSoPzh5HylLv1NCxBHGnvif4uxjGOojmG";

        public static long PostTweet(string message, string imgPath)
        {
            Auth.SetUserCredentials(ApiKey, ApiSecret, "811979534086144001-3nxRmr2fSOpLcZpFbC1BvtO8ktUGpJ0", "crTWje5UNtJyr9Ol0yzluUqrGD5xoZelJpssiPUbtjxgM");
            var image = File.ReadAllBytes(imgPath);
            var media = Upload.UploadImage(image);
            var tweet = Tweet.PublishTweet(message, new PublishTweetOptionalParameters
            {
                Medias = { media }
            });
            return tweet.Id;
        }
    }
}
