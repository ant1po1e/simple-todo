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
    public partial class AddNewCard: UserControl
    {
        public event Action OnAddNew;

        public AddNewCard()
        {
            InitializeComponent();
            this.Click += (s, e) => OnAddNew?.Invoke();
            label1.Click += (s, e) => OnAddNew?.Invoke();
        }
    }
}
