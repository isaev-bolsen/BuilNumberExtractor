using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilNumberExtractorTest
    {
    [TestClass]
    public class BuilNumberExtractorUnitTest
        {
        [TestMethod]
        public void BuilNumberCorrectNonFeature()
            {
            Assert.IsFalse(BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("Test5.10.0161-Cluster123.xml asd"));
            }

        [TestMethod]
        public void BuilNumberCorrectFeature()
            {
            Assert.IsTrue(BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("Test5.10.0161.0004-Cluster123.xml asd"));
            }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void BuilNumberInCorrect()
            {
            BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("Test-Cluster123.xml asd");
            }
        }
    }
