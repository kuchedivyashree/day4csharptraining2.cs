using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Nullable
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.1467;
            bool? boolval = new bool?();

            Console.WriteLine("nullables at show:{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("a nullable boolean value:{0}", boolval);
            Console.ReadLine();

        }
    }
}
