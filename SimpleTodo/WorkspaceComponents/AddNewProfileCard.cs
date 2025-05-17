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
    public partial class AddNewProfileCard: UserControl
    {
        public event Action OnAddProfile;

        public AddNewProfileCard()
        {
            InitializeComponent();
            lblAdd.Click += (s, e) => OnAddProfile?.Invoke();
        }
    }
}
