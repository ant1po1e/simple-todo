using Microsoft.Data.SqlClient;
using SimpleTodo;

namespace SimpleTodo
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lenovo\\Documents\\Simple Todo.mdf\";Integrated Security=True;Connect Timeout=30";
        private int? selectedProfileId = null;
        private List<ProfileCard> profileCards = new List<ProfileCard>();

        public Form1()
        {
            InitializeComponent();
            LoadTodos();
            LoadProfiles();

            dtFrom.Value = DateTime.Today.AddMonths(-1);
            dtTo.Value = DateTime.Today.AddMonths(1);
            
        }

        private void LoadProfiles()
        {
            flowPanelProfiles.Controls.Clear();
            profileCards.Clear(); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Profiles";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = reader["Name"].ToString();

                    ProfileCard card = new ProfileCard(id, name);
                    card.OnProfileSelected += SelectProfile;
                    profileCards.Add(card);
                    flowPanelProfiles.Controls.Add(card);
                }
            }

            var addCard = new AddNewProfileCard();
            addCard.OnAddProfile += ShowAddProfileDialog;
            flowPanelProfiles.Controls.Add(addCard);
        }

        private void SelectProfile(int profileId)
        {
            selectedProfileId = profileId;

            foreach (var card in profileCards)
            {
                card.SetSelected(card.ProfileId == profileId);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name FROM Profiles WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", profileId);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    profileTitle.Text = $"In Workspace: {result.ToString()}";
                }
            }

            LoadTodos();
        }

        private void ShowAddProfileDialog()
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter workspace name:", "New Profile", "");

            if (!string.IsNullOrWhiteSpace(name))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Profiles (Name) VALUES (@Name)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();
                }
                LoadProfiles();
            }
        }

        private void LoadTodos(string search = "", DateTime? fromDate = null, DateTime? toDate = null)
        {
            flowPanelToStart.Controls.Clear();
            flowPanelInProgress.Controls.Clear();
            flowPanelCompleted.Controls.Clear();

            if (selectedProfileId == null)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                List<string> conditions = new List<string>();
                conditions.Add("ProfileId = @ProfileId");

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

                string whereClause = "WHERE " + string.Join(" AND ", conditions);
                string query = $"SELECT * FROM Todos {whereClause}";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProfileId", selectedProfileId.Value);

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
                        string query = "INSERT INTO Todos (Title, Description, DueDate, Status, ProfileId) VALUES (@Title, @Desc, @Date, @Status, @ProfileId)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProfileId", selectedProfileId);
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

        private void EditProfile()
        {
            if (selectedProfileId == null)
            {
                MessageBox.Show("Please select a workspace to edit.");
                return;
            }

            string currentName = ""; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Profiles WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", selectedProfileId);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    currentName = result.ToString();
            }

            string newName = Microsoft.VisualBasic.Interaction.InputBox("Edit workspace name:", "Edit Workspace", currentName);

            if (!string.IsNullOrWhiteSpace(newName))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Profiles SET Name = @Name WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@Id", selectedProfileId);
                    cmd.ExecuteNonQuery();
                }

                LoadProfiles();
            }
        }

        private void DeleteProfile()
        {
            if (selectedProfileId == null)
            {
                MessageBox.Show("Please select a profile to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this workspace and all its todos?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand deleteTodos = new SqlCommand("DELETE FROM Todos WHERE ProfileId = @ProfileId", conn);
                deleteTodos.Parameters.AddWithValue("@ProfileId", selectedProfileId);
                deleteTodos.ExecuteNonQuery();

                SqlCommand deleteProfile = new SqlCommand("DELETE FROM Profiles WHERE Id = @Id", conn);
                deleteProfile.Parameters.AddWithValue("@Id", selectedProfileId);
                deleteProfile.ExecuteNonQuery();
            }

            selectedProfileId = null;
            LoadProfiles();
            LoadTodos(); 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProfile();
        }
    }
}
