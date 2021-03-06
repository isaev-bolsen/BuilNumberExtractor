﻿using System;
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
            Assert.IsTrue(BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("zsdf234Test5.10.0161.0004-Cluster123.xml asd"));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void BuilNumberInCorrect()
        {
            BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("Test-Cluster123.xml asd");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void BuilNumberInCorrect2()
        {
            BuilNumberExtractor.BuilNumberExtractor.isFeatureBuild("Test-Cluster125.1032.0161.00043.xml asd");
        }

        [TestMethod]
        public void INRTEST()
        {
            var res1 = BuilNumberExtractor.BuilNumberExtractor.Extract("zsdf234Test5.10.0161.0004-Cluster123.xml asd");
            Assert.AreEqual(res1.Length, 4);
            var res2 = BuilNumberExtractor.BuilNumberExtractor.Extract("Test5.10.0161-Cluster123.xml asd");
            Assert.AreEqual(res2.Length, 3);

            var res = BuilNumberExtractor.BuilNumberExtractor.INcr();
            Assert.AreEqual(4, res.Key);
            Assert.AreEqual(4, res.Value);
        }
    }
}
