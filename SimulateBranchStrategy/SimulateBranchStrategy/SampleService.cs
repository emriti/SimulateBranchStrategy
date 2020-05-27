using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateBranchStrategy
{
    public class SampleService
    {
        public static string TestMethod(string value, int no)
        {
            Console.WriteLine("bugfix pbi 12345 ...");
            Console.WriteLine("bugfix pbi 12345 ... 66777");
            return $"value: {value} sprint 1";
        }
    }
}
