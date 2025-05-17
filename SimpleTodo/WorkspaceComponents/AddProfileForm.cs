using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleTodo.WorkspaceComponents
{
    public partial class AddProfileForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public string ProfileName { get; private set; }

        public AddProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProfileName.Text))
            {
                MessageBox.Show("Please enter a valid profile name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProfileName = txtProfileName.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
