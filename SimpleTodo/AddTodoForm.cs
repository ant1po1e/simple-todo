using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTodo
{
    public partial class AddTodoForm : Form
    {
        public string TodoTitle => txtTitle.Text;
        public string TodoDescription => txtDesc.Text;
        public DateTime TodoDate => datePicker.Value;

        public AddTodoForm()
        {
            InitializeComponent();
            btnAdd.Click += (s, e) => this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
