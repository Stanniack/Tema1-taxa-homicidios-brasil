using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class CSVReader
    {
        private const string Path = @"C:\Users\Mateus\source\repos\Tema1\homicidios-geral.csv";

        public ArrayList AllContent()
        {
            String[] data = null;
            ArrayList list = new ArrayList();

            try
            {
                StreamReader reader = new StreamReader(Path, Encoding.UTF8, true);
                /* Tira o cabeçalho*/
                reader.ReadLine();

                while (true)
                {
                    String line = reader.ReadLine();

                    if (line == null)
                        break;

                    data = line.Split(';');

                    list.Add(data);
                }

            } catch (FileNotFoundException e)
            {
                Console.WriteLine("Erro na procura do arquivo: " + e);
            }


            return list;
            
        }

        public ArrayList HomicidePerYear (int year)
        {
            String[] data = null;
            ArrayList list = new ArrayList();

            try
            {
                StreamReader reader = new StreamReader(Path, Encoding.UTF8, true);
                /* Tira o cabeçalho*/
                reader.ReadLine();

                while (true)
                {
                    String line = reader.ReadLine();

                    if (line == null)
                        break;

                    data = line.Split(';');

                    /* Traz os dados apenas do ano referenciado */
                    if (data[2].Equals(Convert.ToString(year)))
                    {
                        list.Add(data);
                    }

                    
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Erro na procura do arquivo: " + e);
            }

            return list;
        }
    }

}




