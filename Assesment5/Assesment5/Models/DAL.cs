using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5.Models
{
    public class DAL
    {
        SqlConnection connection;      
        public DAL(string connectionString)
        {

            connection = new SqlConnection(connectionString);

        }

        public IEnumerable<DishInfo> DisplayDishes()
        {
            string queryString = "SELECT DISHNAME, DISHDESCRIPTION FROM Dish";
            IEnumerable<DishInfo> Meal = connection.Query<DishInfo>(queryString);

            return Meal;
        }

     
   
        public int AddDish(DishInfo prod)
        {
            string addString = "INSERT INTO Products (Name, Category, Description, Price) ";
            addString += "VALUES (@Name, @Category, @Description, @Price)";
            return connection.Execute(addString, prod);
        }

        public int DeleteDishById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int EditDishById(DishInfo id)
        {
            string editString = "UPDATE Products SET Name = @Name, Description = @Description, ";
            editString += "Category = @Category, Price = @Price WHERE Id = @Id";
            return connection.Execute(editString, id);
        }

    }
}
