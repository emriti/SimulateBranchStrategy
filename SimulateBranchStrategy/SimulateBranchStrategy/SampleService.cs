using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateBranchStrategy
{
    public class SampleService
    {
        public static string TestMethod(string value, int no)
        {
            Console.WriteLine("bugfix pbi 1234");
            return $"value: {value} sprint 1 - bugfix, {no}";
        }
    }
}
