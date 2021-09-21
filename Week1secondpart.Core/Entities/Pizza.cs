using System;
using System.Collections.Generic;

namespace Week1secondpart.Core
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Ingredienti { get; set; } = new List<string>();
        public int Prezzo { get; set; }
        public Pizza() { }

        public override string ToString()
        {
            var p = " ";
            var ingredienti = " ";
            foreach (var i in Ingredienti)
            {
                ingredienti += i + ",";

                p = $"{Nome} - {ingredienti} - {Prezzo}";
            }

            return p;
        }
    }
}
