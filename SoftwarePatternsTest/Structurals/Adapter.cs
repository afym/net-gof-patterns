using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwarePatterns.Structural.Adapter;

namespace SoftwarePatternsTest.Structurals
{
    [TestClass]
    public class Adapter
    {
        [TestMethod]
        public void TestInstance()
        {
            NaturalSeriesV1 N1 = new NaturalSeriesV1();
            NaturalSeriesV2 N2 = new NaturalSeriesV2();
            SeriesCalculator SeriesCalculator = new SeriesCalculator();
            SeriesNaturalAdapter SeriesNaturalAdapter = new SeriesNaturalAdapter();

            Assert.IsInstanceOfType(N1, typeof(ISeriesAlgorithm));
            Assert.IsInstanceOfType(N2, typeof(ISeriesAlgorithm));
            Assert.IsInstanceOfType(SeriesCalculator, typeof(ISeries));
            Assert.IsInstanceOfType(SeriesNaturalAdapter, typeof(ISeries));
        }

        [TestMethod]
        public void TestAdapterPattern() 
        {
            SeriesCalculator SeriesCalculator = new SeriesCalculator();
            SeriesCalculator.SeriesNaturalAdapter = new SeriesNaturalAdapter();
            Assert.AreEqual(SeriesCalculator.FirstNNaturalNumbers("V1", 2), 3.0d);
            Assert.AreEqual(SeriesCalculator.FirstNNaturalNumbers("V2", 2), 3.0d);
            Assert.AreEqual(SeriesCalculator.FirstNNaturalNumbers("V3", 3), 0.0d);
        }
    }
}
