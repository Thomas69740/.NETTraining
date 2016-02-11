namespace CSharpDiscovery
{
    using System;

    public class Calculator
    {
        public string Name { get; set; }

        public Calculator()
        {
            this.Name = "Calculator";
        }

        public Calculator(string n)
        {
            this.Name = n;
        }

        public static double sum(double[] sumArray)
        {
            double ret = 0.0;

            foreach (double current in sumArray)
            {
                ret += current;
            }
            return ret;
        }

        public static double sum(string stringToParse)
        {
            string[] strings = stringToParse.Split('+');
            Array.ConvertAll(stringToParse.Split('+'), double.Parse);
            return sum(Array.ConvertAll(stringToParse.Split('+'), double.Parse));
        }
    }
}