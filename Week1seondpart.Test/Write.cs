using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1seondpart.Test
{
    class Write
    {
        public static void WriteToFile()
        {
            //Dove salvo -> path
            const string path = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Prova.txt"; // nome esato del file Prova.txt

            StreamWriter sw = new StreamWriter(path); //using system IO
            sw.WriteLine("Ciao questa e una prova di scrittura sul file");
            //chiusura del file
            sw.Close(); // cancella il puntatore
            sw.Dispose(); //libera la memoria

            using (StreamWriter sw1 = new StreamWriter(path))
            {
                sw.WriteLine("Questa e la seconda righa"); // va al posto della prima righa,cancella
            }


            using (StreamWriter sw2 = new StreamWriter(path,true)) // true ->append alla fine della righa
            {
                sw.WriteLine("Questa e la seconda righa"); // va al posto della prima righa, non cancella
            }
        }

    }
}
