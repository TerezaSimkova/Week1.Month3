using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1seondpart.Test
{
    class Read
    {
        public static void ReadFromFile()
        {
            const string path1 = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Prova.txt";
            // Metodo 1
            StreamReader sr = new StreamReader(path1);
            string contenutoFile = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();

            //In using sarebbe:
            //Lettura del tutto il file
            using (StreamReader sr1 = new StreamReader(path1)) // questo contiene tutto quello scritto su
            {
                string contenuto = sr.ReadToEnd();
            }
            //Lettura di un file 
            using (StreamReader sr2 = new StreamReader(path1))
            {
                string contenuto = sr.ReadLine();
            }
            //Per fare split
            string contenuto1 = String.Empty;

            using (StreamReader sr2 = new StreamReader(path1))
            {
                contenuto1 = sr.ReadLine();
            }

            var parole = contenuto1.Split(" ");
        }
    }
}
