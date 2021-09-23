using System;
using System.Collections.Generic;

namespace Week1secondpart.Core
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Ingredienti { get; set; }
        public int Prezzo { get; set; }

        public Pizza(int id, string nome, int prezzo)
        {
            Id = id;
            Nome = nome;
            Prezzo = prezzo;
        }
        public Pizza(int id, string nome, List<string> ingredienti, int prezzo)
        {
            Id = id;
            Nome = nome;
            Ingredienti = ingredienti;
            Prezzo = prezzo;
        }


        public Pizza() 
        { 
        }

        public virtual string Stampa()
        {
            return $"{Nome}\t € {Prezzo}";
        }

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
