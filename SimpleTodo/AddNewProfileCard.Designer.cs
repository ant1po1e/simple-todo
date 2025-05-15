namespace SimpleTodo
{
    partial class AddNewProfileCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProfileCard));
            lblAdd = new Label();
            SuspendLayout();
            // 
            // lblAdd
            // 
            lblAdd.BackColor = Color.Black;
            lblAdd.Dock = DockStyle.Fill;
            lblAdd.Image = (Image)resources.GetObject("lblAdd.Image");
            lblAdd.Location = new Point(0, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(244, 50);
            lblAdd.TabIndex = 0;
            // 
            // AddNewProfileCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAdd);
            Name = "AddNewProfileCard";
            Size = new Size(244, 50);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdd;
    }
}
