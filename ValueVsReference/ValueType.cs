using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    class ValueType
    {
        public static void Example()
        {
            //Tipi semplici tipi numerici integrali,hanno sempre defaul che 0

            //con segno
            int _int; // va da -2147483648 a 2147483648 -> occupa sempre 32 bit
            sbyte _sbyte;  //8 bit
            short _short;  //16 bit
            long _long;    // 64 bit
            nint _nint;    //32 o 64 bit

            //Senza segno - davanti hanno U - unsigned -> Da 0 a 4.294.967.295
            uint _uInt;   //32 bit
            byte _byte;   // 8 bit
            ushort _uShort;  // 16 bit
            ulong _uLong; //64 bit
            nuint _nuint; //32 o 64 bit

            //tipi semplici numerici

            float _float; //4 byte, 6/9 cifre
            double _double; //8 byte, 16/18 cifre
            decimal _decimal; // 16 byte, 28/29 cifre;

            //Caratteri -> di default '\0'
            char _char;

            //Boolean-> default false 
            bool _bool;

            //Tipi complessi ->come default il primo elemento
            Month _month;
            Season _season; //-> spring 0

            //Struct ->default delle proprieta oppure solo il tipo 
            //puo avere i metodi e  e campi
            //non ha ereditarieta,puo solo avere interface
            Coords _coords = new Coords();
            Coords2 _coords2;

            DateTime dt = new DateTime(); // anche lui e un struct

            //Tupla
            (int, double) _tupla = new(5, 4.2);
            //se non ho bisogno per forza di una classe intera

            int ilPrimoIntero = 5;
            int ilSecondoIntero = 10;

            //5             5
            ilPrimoIntero = ilSecondoIntero;

            ilPrimoIntero = 7;

            // Il secondo intero - > 5

            int i = 22;
            object o = 1; //boxing
            int j = (int)o; //unboxing

            var result = j.CompareTo(5); // ho gia i suoi metodi implementati

            char c = 'a';
            c.GetType();


        }
        enum Month { }
        enum Season
        {
            spring,
            summer,
            autumn,
            winter
        }

        public struct Coords
        {
            public double x { get; set; }
            public double y { get; set; }
        }
        public struct Coords2{}
    }

}



