namespace SimpleTodo.WorkspaceComponents
{
    partial class AddProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtProfileName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(339, 79);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtProfileName
            // 
            txtProfileName.BorderStyle = BorderStyle.FixedSingle;
            txtProfileName.Font = new Font("Verdana", 12F);
            txtProfileName.Location = new Point(33, 31);
            txtProfileName.MaxLength = 15;
            txtProfileName.Name = "txtProfileName";
            txtProfileName.PlaceholderText = "Title";
            txtProfileName.Size = new Size(426, 32);
            txtProfileName.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(51, 73, 119);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(33, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 57);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Workspace";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // AddProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 45, 72);
            ClientSize = new Size(490, 166);
            Controls.Add(button1);
            Controls.Add(txtProfileName);
            Controls.Add(btnAdd);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtProfileName;
        private Button btnAdd;
    }
}