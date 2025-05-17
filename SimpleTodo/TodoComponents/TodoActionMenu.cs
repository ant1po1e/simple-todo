using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTodo.TodoComponents
{
    public partial class TodoActionMenu : UserControl
    {
        public event Action OnEditClicked;
        public event Action OnDeleteClicked;

        public TodoActionMenu()
        {
            InitializeComponent();

            btnEdit.Click += (s, e) => OnEditClicked?.Invoke();
            btnDelete.Click += (s, e) => OnDeleteClicked?.Invoke();
        }
    }
}