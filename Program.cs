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

            //Console.WriteLine(new CSVReader().AllContent().Count);

            foreach (String[] t in new CSVReader().HomicidePerYear(1979))
            {
                Console.WriteLine(@"Código: {0}, Estado: {1}, Ano: {2}, Homicídios: {3}", t[0], t[1], t[2], t[3]);
            }

        }
    }
}
