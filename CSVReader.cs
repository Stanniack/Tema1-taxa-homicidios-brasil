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

        public ArrayList Reader()
        {
            String[] data = null;
            String result = null;
            ArrayList list = new ArrayList();

            try
            {
                StreamReader reader = new StreamReader(Path, Encoding.UTF8, true);

                while (reader.ReadLine() != null)
                {
                    data = reader.ReadLine().Split(';');

                    list.Add(data);
                }

            } catch (FileNotFoundException e)
            {
                Console.WriteLine("Erro na procura do arquivo: " + e);
            }


            return list;
            
        }
    }

}




