using System;

namespace SimulateBranchStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SampleService.TestMethod("abcd", 456));
            Console.WriteLine(AdditionalSampleService.Add(1, 2));
        }
    }
}
