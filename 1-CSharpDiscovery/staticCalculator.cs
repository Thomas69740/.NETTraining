namespace CSharpDiscovery
{
    public static class staticCalculator
    {

        public static string Name { get;}

        static staticCalculator()
        {
            Name = "Static Calculator";
        }

        public static double sum(double[] sumArray)
        {
            return Calculator.sum(sumArray);
        }

        public static double sum(string stringToParse)
        {
            return Calculator.sum(stringToParse);
        }
    }
}