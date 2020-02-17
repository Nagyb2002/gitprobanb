using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitprobanb
{
    class Program
    {
        static void Main(string[] args)
        {
            auto e1 = new auto("Ferrari", 2012, 100, "benzin", 12000000);
            Console.WriteLine(e1.ToString());
            auto e2 = new auto("Audi", 2010, 10000, "disel", 100000);
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());
            Console.ReadKey();
        }
    }
}
