using System;
using System.Reflection;

namespace SoftwarePatterns.Structural.Adapter
{
    public class SeriesNaturalAdapter : ISeries
    {
        public double FirstNNaturalNumbers(string Algorithm, int MaxNaturalNumber)
        {
            ISeriesAlgorithm AlgorithmSeries = null;
            double Result = 0.0d;

            string ClassName = "SoftwarePatterns.Structural.Adapter.NaturalSeries" + Algorithm;

            try
            {
                AlgorithmSeries = (ISeriesAlgorithm)Assembly.GetExecutingAssembly().CreateInstance(ClassName);
                Result = AlgorithmSeries.FirstNNaturalNumbers(MaxNaturalNumber);
            }
            catch (Exception)
            {
                // catch exception here ...
            }

            return Result;
        }
    }
}
