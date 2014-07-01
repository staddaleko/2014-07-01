using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencja
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 2.6;
            int a = (int)y;
            Console.WriteLine(a);

            a = (int)(y + 0.5);//dodoajemy 0,5 aby zaokrąglało bardzo sztucznie do góry, gdy wartość większa lub równa 0,5
            Console.WriteLine(a);

            Console.WriteLine(Math.Round(y));//jest klasa pozwalająca zaokrąglać
            Console.ReadKey();
        }
    }
}
