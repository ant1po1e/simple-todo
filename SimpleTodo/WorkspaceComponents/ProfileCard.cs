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
    public partial class ProfileCard: UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public int ProfileId { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public string ProfileName { get; private set; }

        public event Action<int> OnProfileSelected;
        public event Action<int> OnEditProfile;
        public event Action<int> OnDeleteProfile;

        public ProfileCard(int id, string name)
        {
            InitializeComponent();
            ProfileId = id;
            ProfileName = name;
            lblProfileName.Text = name;

            lblProfileName.Click += (s, e) => OnProfileSelected?.Invoke(ProfileId);
        }

        public void SetSelected(bool selected)
        {
            this.BackColor = selected ? Color.FromArgb(83, 119, 195) : Color.FromArgb(51, 73, 119);
        }
    }
}
