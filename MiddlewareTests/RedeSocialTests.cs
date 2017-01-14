using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Middleware.Tests
{
    [TestClass()]
    public class RedeSocialTests
    {
        [TestMethod()]
        public void RedeSocialNameUriTest()
        {
            var facebook = new RedeSocial("Facebook", "https://www.facebook.com");
            Assert.AreEqual(facebook.Nome, "Facebook");
            Assert.AreEqual(facebook.Uri, new Uri("https://www.facebook.com"));

            var twitter = new RedeSocial("Twitter", "https://twitter.com");
            Assert.AreEqual(twitter.Nome, "Twitter");
            Assert.AreEqual(twitter.Uri, new Uri("https://twitter.com"));
        }
    }
}