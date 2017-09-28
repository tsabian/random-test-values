﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTestValues.Formats;

namespace RandomTestValues.Tests.RandomValueFormatsTests
{
    [TestClass]
    public class UriStringShould
    {
        [TestMethod]
        public void ReturnAValidUrl()
        {
            // Act
            var url = RandomFormat.UriString();
            
            // Assert
            Assert.IsTrue(IsValidHttpUrl(url), $"{url} is not a valid uri.");
        }

        private static bool IsValidHttpUrl(string urlString)
        {
            Uri uri;
            return Uri.TryCreate(urlString, UriKind.Absolute, out uri)
                   && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
