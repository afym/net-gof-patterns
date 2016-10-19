namespace SoftwarePatterns.Structural.Adapter
{
    public class SeriesCalculator : ISeries
    {
        public SeriesNaturalAdapter SeriesNaturalAdapter { get; set; }

        public double FirstNNaturalNumbers(string Algorithm, int MaxNaturalNumber)
        {
            return SeriesNaturalAdapter.FirstNNaturalNumbers(Algorithm, MaxNaturalNumber);
        }
    }
}
