namespace SimpleTodo
{
    partial class AddTodoForm
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
            btnAdd = new Button();
            txtTitle = new TextBox();
            txtDesc = new TextBox();
            datePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(51, 73, 119);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(43, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Verdana", 12F);
            txtTitle.Location = new Point(43, 30);
            txtTitle.MaxLength = 15;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(426, 32);
            txtTitle.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Verdana", 12F);
            txtDesc.Location = new Point(43, 78);
            txtDesc.MaxLength = 57;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Description";
            txtDesc.Size = new Size(426, 158);
            txtDesc.TabIndex = 2;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Verdana", 12F);
            datePicker.Location = new Point(43, 252);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(426, 32);
            datePicker.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(349, 300);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddTodoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 45, 72);
            ClientSize = new Size(513, 388);
            Controls.Add(button1);
            Controls.Add(datePicker);
            Controls.Add(txtDesc);
            Controls.Add(txtTitle);
            Controls.Add(btnAdd);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTodoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTodoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtTitle;
        private TextBox txtDesc;
        private DateTimePicker datePicker;
        private Button button1;
    }
}