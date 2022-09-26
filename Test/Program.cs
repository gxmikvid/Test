using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int egy = Convert.ToInt32(Console.ReadLine());
            int ketto = Convert.ToInt32(Console.ReadLine());
            if (egy > ketto)
            {
                Console.WriteLine(egy);
            }
            else
            {
                Console.WriteLine(ketto);
            }
        }
    }
}
