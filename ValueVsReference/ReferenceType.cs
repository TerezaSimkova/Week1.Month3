using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    class ReferenceType
    {
        public static void Example()
        {

            Object _object;

            string _string;
            _string = null; // valore null
            _string = String.Empty; // -> ""  stringa vuota

            int[] _array;
            _array = new int[5]; // ->contiene 5 elementi
            _array = new int[] { 1, 2, 3 }; // ->contiene 3  / new int[] { 1, 2, 3 };  ->fare l'istanza
            int[] _array2 = { 1, 2, 3, 4, 5, 6 };

            int[][] _matrix;

            IInterfaceExample _interface;
            ClassExample classExamle;


            ClassExample primaClasse = new ClassExample();
            primaClasse.Nome = "Arianna";

            ClassExample secondaClasse = new ClassExample();
            secondaClasse.Nome = "Alessandra";

            secondaClasse = primaClasse; // puntatore SC puntera su PC e tutte e due sono Arianna

            primaClasse.Nome = "Renata"; // ci sara un unico puntatore e divente Renata; in ValueType i puntatori rimangoo separati

            //Attenzione alle stringhe

            string salutoInglese = "Hello";
            string salutoITaliano = "Ciao";
            salutoInglese = salutoITaliano; // -> salutoInlese sara uguale a "Ciao" e salutoITaliano e sempre uguale a "Ciao"

            salutoITaliano = "Buongirno"; // saluto inglese -> "Ciao",salutoITliano -> "Buongiorno"
        }
    }
    public interface IInterfaceExample { }

    public class ClassExample {
     public string Nome { get; set; }
    }
}
