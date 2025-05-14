using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SimpleTodo
{
    public static class Database
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lenovo\\Documents\\Simple Todo.mdf\";Integrated Security=True;Connect Timeout=30";

        public static List<Todo> GetTodos()
        {
            var list = new List<Todo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Todos", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Todo
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        DueDate = (DateTime)reader["DueDate"],
                        Status = reader["Status"].ToString()
                    });
                }
            }
            return list;
        }

        public static void AddTodo(Todo todo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Todos (Title, Description, DueDate, Status) VALUES (@title, @desc, @date, @status)", conn);
                cmd.Parameters.AddWithValue("@title", todo.Title);
                cmd.Parameters.AddWithValue("@desc", todo.Description);
                cmd.Parameters.AddWithValue("@date", todo.DueDate);
                cmd.Parameters.AddWithValue("@status", todo.Status);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
