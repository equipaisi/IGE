using Microsoft.VisualStudio.TestTools.UnitTesting;
using Middleware.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Validation.Tests
{
    [TestClass()]
    public class UsernameValidatorTests
    {
        [TestMethod()]
        public void UsernameValidatorTest()
        {
            Assert.AreEqual(true, new UsernameValidator().Valid("usernames"));
        }
    }
}