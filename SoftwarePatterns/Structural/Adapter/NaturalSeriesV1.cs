namespace SoftwarePatterns.Structural.Adapter
{
    public class NaturalSeriesV1 : ISeriesAlgorithm
    {
        public double FirstNNaturalNumbers(int MaxNaturalNumber)
        {
            return MaxNaturalNumber * 0.5 * (MaxNaturalNumber + 1);
        }
    }
}
