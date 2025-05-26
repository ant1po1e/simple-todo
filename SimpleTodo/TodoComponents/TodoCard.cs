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

        public event Action<int> OnEditClicked;
        public event Action<int> OnDeleteClicked;

        private Point dragStartPoint;

        public TodoCard(int id, string title, string description, DateTime date, string status)
        {
            InitializeComponent();

            TodoId = id;
            CurrentStatus = status;
            lblTitle.Text = title;
            lblDesc.Text = description;
            lblDate.Text = date.ToString("dd/MM/yyyy");

            if (CurrentStatus == "Completed")
            {
                this.BackColor = Color.Honeydew;
            }
            else
            {
                DateTime today = DateTime.Today;
                int daysRemaining = (date.Date - today).Days;

                if (daysRemaining == 1)
                {
                    this.BackColor = Color.LightCyan;
                }
                else if (daysRemaining == 0)
                {
                    this.BackColor = Color.Wheat;
                }
                else if (daysRemaining < 0)
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }

            todoActionMenu1.OnDeleteClicked += () =>
            {
                todoActionMenu1.Visible = false;
                OnDeleteClicked?.Invoke(TodoId);
            };

            todoActionMenu1.OnEditClicked += () =>
            {
                todoActionMenu1.Visible = false;
                OnEditClicked?.Invoke(TodoId);
            };

            this.MouseDown += TodoCard_MouseDown;
            this.MouseMove += TodoCard_MouseMove;

            foreach (Control ctl in this.Controls)
            {
                if (ctl != btnMenu)
                {
                    ctl.MouseDown += TodoCard_MouseDown;
                    ctl.MouseMove += TodoCard_MouseMove;
                }
            }
        }

        private void TodoCard_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = this.PointToClient(Cursor.Position);

            if (btnMenu.Bounds.Contains(pt)) return;

            dragStartPoint = e.Location;
        }

        private void TodoCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = Math.Abs(e.X - dragStartPoint.X);
                int dy = Math.Abs(e.Y - dragStartPoint.Y);

                if (dx > 5 || dy > 5)
                {
                    DoDragDrop(this, DragDropEffects.Move);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            todoActionMenu1.Visible = !todoActionMenu1.Visible;
        }
    }
}