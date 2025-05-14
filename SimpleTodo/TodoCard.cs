using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTodo
{
    [DesignerCategory("Code")]
    [Serializable]
    public partial class TodoCard : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public int TodoId { get; set; }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public string CurrentStatus { get; set; }
        public event Action<int, string> OnMoveClicked;
        public event Action<int> OnDeleteClicked;

        public TodoCard(int id, string title, string description, DateTime date, string status)
        {
            InitializeComponent();
            TodoId = id;
            CurrentStatus = status;
            lblTitle.Text = title;
            lblDesc.Text = description;
            lblDate.Text = date.ToString("dd/MM/yyyy");

            btnMove.Text = status == "To Start" ? "Start" : status == "In Progress" ? "Complete" : "";
            btnMove.Visible = status != "Completed";
            btnMove.Click += (s, e) => OnMoveClicked?.Invoke(TodoId, CurrentStatus);

            btnDelete.Visible = status == "Completed";
            btnDelete.Click += (s, e) => OnDeleteClicked?.Invoke(TodoId);
        }
    }
}
