namespace SimpleTodo
{
    partial class ProfileCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProfileName = new Label();
            SuspendLayout();
            // 
            // lblProfileName
            // 
            lblProfileName.BackColor = Color.FromArgb(0, 5, 28, 129);
            lblProfileName.Dock = DockStyle.Fill;
            lblProfileName.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileName.ForeColor = Color.White;
            lblProfileName.Location = new Point(0, 0);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(244, 50);
            lblProfileName.TabIndex = 0;
            lblProfileName.Text = "label1";
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 73, 119);
            Controls.Add(lblProfileName);
            Name = "ProfileCard";
            Size = new Size(244, 50);
            ResumeLayout(false);
        }

        #endregion

        private Label lblProfileName;
    }
}
