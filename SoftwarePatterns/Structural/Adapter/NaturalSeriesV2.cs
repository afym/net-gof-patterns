namespace SoftwarePatterns.Structural.Adapter
{
    public class NaturalSeriesV2 : ISeriesAlgorithm
    {
        public double FirstNNaturalNumbers(int MaxNaturalNumber)
        {
            double Result = 0.0d;

            for (int Counter = 0; Counter <= MaxNaturalNumber; Counter++)
            {
                Result += Counter;
            }

            return Result;
        }
    }
}
