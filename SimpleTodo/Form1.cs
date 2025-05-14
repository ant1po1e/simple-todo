using Microsoft.Data.SqlClient;
using SimpleTodo;

namespace SimpleTodo
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lenovo\\Documents\\Simple Todo.mdf\";Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            LoadTodos();

            dtFrom.Value = DateTime.Today.AddMonths(-1);
            dtTo.Value = DateTime.Today.AddMonths(1);
        }

        private void LoadTodos(string search = "", DateTime? fromDate = null, DateTime? toDate = null)
        {
            flowPanelToStart.Controls.Clear();
            flowPanelInProgress.Controls.Clear();
            flowPanelCompleted.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                List<string> conditions = new List<string>();
                if (!string.IsNullOrWhiteSpace(search))
                {
                    conditions.Add("(Title LIKE @Search OR Description LIKE @Search)");
                }
                if (fromDate.HasValue)
                {
                    conditions.Add("DueDate >= @FromDate");
                }
                if (toDate.HasValue)
                {
                    conditions.Add("DueDate <= @ToDate");
                }

                string whereClause = conditions.Count > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";
                string query = $"SELECT * FROM Todos {whereClause}";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                }
                if (fromDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.Value);
                }
                if (toDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ToDate", toDate.Value);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    DateTime date = (DateTime)reader["DueDate"];
                    string status = reader["Status"].ToString();

                    TodoCard card = new TodoCard(id, title, description, date, status);
                    card.OnMoveClicked += MoveTodo;
                    card.OnDeleteClicked += DeleteTodo;

                    switch (status)
                    {
                        case "To Start": flowPanelToStart.Controls.Add(card); break;
                        case "In Progress": flowPanelInProgress.Controls.Add(card); break;
                        case "Completed": flowPanelCompleted.Controls.Add(card); break;
                    }
                }
            }

            AddNewCard addCard = new AddNewCard();
            addCard.OnAddNew += ShowAddTodoDialog;
            flowPanelToStart.Controls.Add(addCard);
        }


        private void ShowAddTodoDialog()
        {
            using (AddTodoForm form = new AddTodoForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Todos (Title, Description, DueDate, Status) VALUES (@Title, @Desc, @Date, @Status)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Title", form.TodoTitle);
                        cmd.Parameters.AddWithValue("@Desc", form.TodoDescription);
                        cmd.Parameters.AddWithValue("@Date", form.TodoDate);
                        cmd.Parameters.AddWithValue("@Status", "To Start");
                        cmd.ExecuteNonQuery();
                    }
                    LoadTodos();
                }
            }
        }

        private void MoveTodo(int id, string currentStatus)
        {
            string nextStatus = currentStatus switch
            {
                "To Start" => "In Progress",
                "In Progress" => "Completed",
                _ => null
            };

            if (nextStatus != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Todos SET Status = @Status WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", nextStatus);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadTodos();
            }
        }

        private void DeleteTodo(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Todos WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            LoadTodos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadTodos(txtSearch.Text, dtFrom.Value.Date, dtTo.Value.Date);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadTodos(txtSearch.Text, dtFrom.Value.Date, dtTo.Value.Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTodos(txtSearch.Text, dtFrom.Value.Date, dtTo.Value.Date);
        }

        private void btpResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dtFrom.Value = DateTime.Today.AddMonths(-1);  
            dtTo.Value = DateTime.Today.AddMonths(1);   
            LoadTodos();
        }
    }
}
