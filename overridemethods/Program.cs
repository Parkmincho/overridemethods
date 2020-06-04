using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Test ad = new Test();
            Console.WriteLine(ad.Power(3));
            Console.WriteLine(ad.Power(3, 4));
            Console.WriteLine(ad.Sumall(3));
            Console.WriteLine(ad.Sumall(3, 12));
        }
    }
}
