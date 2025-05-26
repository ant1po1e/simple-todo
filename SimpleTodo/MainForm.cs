using Microsoft.Data.Sqlite;
using SimpleTodo;
using SimpleTodo.WorkspaceComponents;

namespace SimpleTodo
{
    public partial class MainForm : Form
    {
        private string connectionString = $"Data Source={Application.StartupPath}\\SimpleTodo.db";
        private int? selectedProfileId = null;
        private List<ProfileCard> profileCards = new List<ProfileCard>();

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadTodos();
            LoadProfiles();

            dtFrom.Value = DateTime.Today.AddMonths(-1);
            dtTo.Value = DateTime.Today.AddMonths(1);

            flowPanelToStart.DragEnter += FlowPanel_DragEnter;
            flowPanelInProgress.DragEnter += FlowPanel_DragEnter;
            flowPanelCompleted.DragEnter += FlowPanel_DragEnter;

            flowPanelToStart.DragDrop += (s, e) => HandleDrop(e, "To Start");
            flowPanelInProgress.DragDrop += (s, e) => HandleDrop(e, "In Progress");
            flowPanelCompleted.DragDrop += (s, e) => HandleDrop(e, "Completed");
        }

        private void InitializeDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string createProfiles = @"CREATE TABLE IF NOT EXISTS Profiles (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL
                );";

                string createTodos = @"CREATE TABLE IF NOT EXISTS Todos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Description TEXT,
                    DueDate TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    ProfileId INTEGER,
                    FOREIGN KEY(ProfileId) REFERENCES Profiles(Id)
                );";

                new SqliteCommand(createProfiles, conn).ExecuteNonQuery();
                new SqliteCommand(createTodos, conn).ExecuteNonQuery();
            }
        }

        private void FlowPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TodoCard)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void HandleDrop(DragEventArgs e, string newStatus)
        {
            if (e.Data.GetDataPresent(typeof(TodoCard)))
            {
                var todoCard = (TodoCard)e.Data.GetData(typeof(TodoCard));

                if (todoCard.CurrentStatus != newStatus)
                {
                    using (var conn = new SqliteConnection(connectionString))
                    {
                        conn.Open();
                        var cmd = new SqliteCommand("UPDATE Todos SET Status = @Status WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@Id", todoCard.TodoId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadTodos();
                }
            }
        }

        private void LoadProfiles()
        {
            flowPanelProfiles.Controls.Clear();
            profileCards.Clear();

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT * FROM Profiles", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);

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

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT Name FROM Profiles WHERE Id = @Id", conn);
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
            using (var form = new AddProfileForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string name = form.ProfileName;
                    using (var conn = new SqliteConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Profiles (Name) VALUES (@Name)";
                        var cmd = new SqliteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.ExecuteNonQuery();
                    }
                    LoadProfiles();
                }
            }
        }

        private void LoadTodos(string search = "", DateTime? fromDate = null, DateTime? toDate = null)
        {
            flowPanelToStart.Controls.Clear();
            flowPanelInProgress.Controls.Clear();
            flowPanelCompleted.Controls.Clear();

            if (selectedProfileId == null)
                return;

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                List<string> conditions = new List<string> { "ProfileId = @ProfileId" };

                if (!string.IsNullOrWhiteSpace(search))
                    conditions.Add("(Title LIKE @Search OR Description LIKE @Search)");
                if (fromDate.HasValue)
                    conditions.Add("DueDate >= @FromDate");
                if (toDate.HasValue)
                    conditions.Add("DueDate <= @ToDate");

                string whereClause = "WHERE " + string.Join(" AND ", conditions);
                var cmd = new SqliteCommand($"SELECT * FROM Todos {whereClause}", conn);

                cmd.Parameters.AddWithValue("@ProfileId", selectedProfileId);
                if (!string.IsNullOrWhiteSpace(search))
                    cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                if (fromDate.HasValue)
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.Value.ToString("yyyy-MM-dd"));
                if (toDate.HasValue)
                    cmd.Parameters.AddWithValue("@ToDate", toDate.Value.ToString("yyyy-MM-dd"));

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    string description = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    DateTime date = DateTime.Parse(reader.GetString(3));
                    string status = reader.GetString(4);

                    TodoCard card = new TodoCard(id, title, description, date, status);
                    card.OnEditClicked += EditTodo;
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
                    using (var conn = new SqliteConnection(connectionString))
                    {
                        conn.Open();
                        var cmd = new SqliteCommand("INSERT INTO Todos (Title, Description, DueDate, Status, ProfileId) VALUES (@Title, @Desc, @Date, @Status, @ProfileId)", conn);

                        cmd.Parameters.AddWithValue("@ProfileId", selectedProfileId);
                        cmd.Parameters.AddWithValue("@Title", form.TodoTitle);
                        cmd.Parameters.AddWithValue("@Desc", form.TodoDescription);
                        cmd.Parameters.AddWithValue("@Date", form.TodoDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Status", "To Start");
                        cmd.ExecuteNonQuery();
                    }
                    LoadTodos();
                }
            }
        }

        private void EditTodo(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT Title, Description, DueDate FROM Todos WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string title = reader.GetString(0);
                    string desc = reader.GetString(1);
                    DateTime date = DateTime.Parse(reader.GetString(2));

                    using (var form = new EditTodoForm(title, desc, date))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var confirm = MessageBox.Show("Are you sure you want to edit this todo?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (confirm != DialogResult.Yes) return;

                            var updateCmd = new SqliteCommand("UPDATE Todos SET Title = @Title, Description = @Desc, DueDate = @Date WHERE Id = @Id", conn);
                            updateCmd.Parameters.AddWithValue("@Title", form.TodoTitle);
                            updateCmd.Parameters.AddWithValue("@Desc", form.TodoDescription);
                            updateCmd.Parameters.AddWithValue("@Date", form.TodoDate.ToString("yyyy-MM-dd"));
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            LoadTodos();
        }

        private void DeleteTodo(int id)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this todo?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("DELETE FROM Todos WHERE Id = @Id", conn);
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

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT Name FROM Profiles WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", selectedProfileId);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    currentName = result.ToString();
            }

            var form = new EditProfileForm(currentName); // kirim nama lama
            var resultDialog = form.ShowDialog();

            if (resultDialog == DialogResult.OK && !string.IsNullOrWhiteSpace(form.ProfileName))
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqliteCommand("UPDATE Profiles SET Name = @Name WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Name", form.ProfileName);
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

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                var cmd1 = new SqliteCommand("DELETE FROM Todos WHERE ProfileId = @ProfileId", conn);
                cmd1.Parameters.AddWithValue("@ProfileId", selectedProfileId);
                cmd1.ExecuteNonQuery();

                var cmd2 = new SqliteCommand("DELETE FROM Profiles WHERE Id = @Id", conn);
                cmd2.Parameters.AddWithValue("@Id", selectedProfileId);
                cmd2.ExecuteNonQuery();
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
