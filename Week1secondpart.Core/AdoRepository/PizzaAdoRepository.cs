using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Core.AdoRepository
{
    public class PizzaAdoRepository : IRepositoryPizza
    {
        const string connectionString = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog=Pizzeria; Integrated Security=true;";
        List<Pizza> pizze = new List<Pizza>() { };
        List<Pizza> conto = new List<Pizza>() { };

        public void AddToConto(Pizza existPizza)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Pizza where Pizza = @existPizza";
                command.Parameters.AddWithValue(@"existPizza", existPizza);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pizza piz = new Pizza();
                    piz.Id = (int)reader["Id"];
                    piz.Ingredienti = (List<string>)reader["Ingredienti"];
                    piz.Nome = (string)reader["Nome"];
                    piz.Prezzo = (int)reader["Prezzo"];

                    pizze.Add(piz);

                    conto.Add(piz);
                }


            }
        }

        public List<Pizza> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Pizza";

                SqlDataReader reader = command.ExecuteReader();

                List<Pizza> pizze = new List<Pizza>();
                while (reader.Read())
                {
                    Pizza piz = new Pizza();
                    piz.Id = (int)reader["Id"];
                    piz.Ingredienti = (List<string>)reader["Ingredienti"];
                    piz.Nome = (string)reader["Nome"];
                    piz.Prezzo = (int)reader["Prezzo"];

                    pizze.Add(piz);
                }
                return pizze;
            }
        }

        public List<Pizza> GetAll(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetByIngrediente(string ingrediente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Ingrediente where Ingredienti = @ingrediente";
                command.Parameters.AddWithValue("@ingrediente", ingrediente);

                var ingr = "";
                foreach (var i in ingrediente)
                {
                    ingr += i;
                }

                SqlDataReader reader = command.ExecuteReader();

                List<Pizza> pizze = new List<Pizza>();

                while (reader.Read())
                {
                    Pizza piz = new Pizza();
                    piz.Id = (int)reader["Id"];
                    piz.Nome = (string)reader["Nome"];
                    piz.Ingredienti = (List<string>)reader["Ingredienti"];
                    piz.Prezzo = (int)reader["Prezzo"];

                    pizze.Add(piz);
                }
                return pizze;

                
            }
        }

        public Pizza GetByName(string nome)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Pizza where Nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                SqlDataReader reader = command.ExecuteReader();
                Pizza piz = new Pizza();
                while (reader.Read())
                {

                    int id = (int)reader["Id"];
                    List<string> ingrediente = (List<string>)reader["Ingredienti"];
                    int prezzo = (int)reader["Prezzo"];

                    piz = new Pizza(id, nome, ingrediente, prezzo);
                }
                return piz;
            }
        }

        public string GetConto()
        {
            string contoDaPagare = "";
            //int contoPrezzi = 0;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{               
            //    connection.Open();

            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandType = System.Data.CommandType.Text;
            //    command.CommandText = "";
            //    command.Parameters.AddWithValue();

            //    SqlDataReader reader = command.ExecuteReader();



            //}
            return contoDaPagare;
        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto)
        {
            throw new NotImplementedException();
        }
    }
}
