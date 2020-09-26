using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach(String[] t in new CSVReader().Reader())
            {
                Console.WriteLine(t[3]);
            }

        }
    }
}
