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
    public partial class EditTodoForm : Form
    {
        public string TodoTitle => txtTitle.Text;
        public string TodoDescription => txtDesc.Text;
        public DateTime TodoDate => datePicker.Value;

        public EditTodoForm()
        {
            InitializeComponent();
            btnAdd.Click += (s, e) => this.DialogResult = DialogResult.OK;
        }

        public EditTodoForm(string title, string desc, DateTime dueDate) : this()
        {
            txtTitle.Text = title;
            txtDesc.Text = desc;
            datePicker.Value = dueDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
