using System;
using System.Collections.Generic;
using System.IO;
using Week1secondpart.Core;
using Week1secondpart.Core.BusinessLayer;
using Week1secondpart.Mock;

namespace Week1secondpart.Pizzeria
{
    public class Start
    {
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryPizzaTxt());
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryPizzaMock());
        public static void Menu()
        {

            Console.WriteLine("***Benvenuto in pizzeria!***\n");
            int scelta;
            bool continua = true;
            do
            {
                do
                {

                    Console.WriteLine("\nScegli Q per uscire.");
                    Console.WriteLine("\nScegli 1. per vedere il menu delle pizze.");
                    Console.WriteLine("Scegli 2. per acquistare delle pizze.");
                    Console.WriteLine("Scegli 3. per pagare.");
                    Console.WriteLine("Scegli 4. per filtrare le pizze per ingredienti.\n");

                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 4);

                switch (scelta)
                {
                    case 'Q':
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                    case 1:
                        ShowPizzeMenu();
                        break;
                    case 2:
                        CompraPizza();
                        break;
                    case 3:
                        Paga();
                        break;
                    case 4:
                        FiltraPizze();
                        break;
                }


            } while (continua);


        }

        private static void FiltraPizze()
        {
            string ingrediente = string.Empty;
            do
            {
                Console.WriteLine("Scegli ingrediente che ti interessa:\n- pomodoro \n- basilico \n- verdure_grigliate \n- mozzarella \n- friarelli");
                ingrediente = Console.ReadLine();

            } while (string.IsNullOrEmpty(ingrediente));

            var esito = bl.FiltraPerIngrediente(ingrediente);
            foreach (var item in esito)
            {
                Console.WriteLine(item.ToString());
            }

        }

        //molti a molti
        private static void Paga()
        {
            string conto = bl.GetContoPizze();
            Console.WriteLine("***Scontrino***\n");
            Console.WriteLine(conto);
        }

        private static void CompraPizza()
        {
            string nome = string.Empty;

            do
            {
                Console.WriteLine("\nScrivi nome della pizza che vuoi aggiungere al carello:");
                nome = Console.ReadLine();

            } while (string.IsNullOrEmpty(nome));

            var esito = bl.GetByName(nome);
            Console.WriteLine(esito);
        }

        private static void ShowPizzeMenu()
        {
            var menu = bl.SeeAllPizza();
            foreach (var p in menu)
            {
                Console.WriteLine(p.ToString());
            }
        }

        private static void prova1()
        {
            //const string path = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\MenuPizze.txt";

            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Pizze:");
            //    sw.WriteLine("1. Margherita - pomodoro,basilico,mozzarela 6 euro");
            //    sw.WriteLine("2. Vegetariana - pomodoro,verdure grigliate,mozzarela 8 euro");
            //    sw.WriteLine("3. Marinara - pomodoro,acciughe,mozzarela 7 euro");
            //}
            //using (StreamReader sw = new StreamReader(path))
            //{
            //    string contenuto = sw.ReadToEnd();
            //    Console.WriteLine(contenuto);
            //}

            //String scelta = String.Empty;
            //do
            //{
            //    Console.WriteLine("Quale pizza vuoi acquistare?");
            //    scelta = Console.ReadLine();

            //} while (String.IsNullOrEmpty(scelta));


            //switch (scelta)
            //{

            //    case "1 2":
            //        const string path1 = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Conto.txt";
            //        using (StreamWriter sw = new StreamWriter(path1))
            //        {
            //            sw.WriteLine(6 + 8);
            //        }
            //        Conto(path1);
            //        break;

            //    case "2 3":
            //        const string path2 = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Conto.txt";
            //        using (StreamWriter sw = new StreamWriter(path2))
            //        {
            //            sw.WriteLine(8 + 7);
            //        }
            //        Conto2(path2);
            //        break;
            //    case "1 3":
            //        const string path3 = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Conto.txt";
            //        using (StreamWriter sw = new StreamWriter(path3))
            //        {
            //            sw.WriteLine(6 + 7);
            //        }
            //        Conto3(path3);
            //        break;
            //}


        }

        //private static string Conto3(string path3)
        //{
        //    string contenuto = String.Empty;
        //    using (StreamReader sw = new StreamReader(path3))
        //    {
        //        contenuto = sw.ReadToEnd();
        //        Console.WriteLine("Devi pagare:");
        //        Console.WriteLine(contenuto);
        //    }

        //    return path3;
        //}

        //private static string Conto2(string path2)
        //{
        //    string contenuto = String.Empty;
        //    using (StreamReader sw = new StreamReader(path2))
        //    {
        //        contenuto = sw.ReadToEnd();
        //        Console.WriteLine("Devi pagare:");
        //        Console.WriteLine(contenuto);
        //    }

        //    return path2;
        //}

        //private static string Conto(string path1)
        //{
        //    string contenuto = String.Empty;
        //    using (StreamReader sw = new StreamReader(path1))
        //    {
        //        contenuto = sw.ReadToEnd();
        //        Console.WriteLine("Devi pagare:");
        //        Console.WriteLine(contenuto);
        //    }

        //    return path1;
        //}
    }

}
