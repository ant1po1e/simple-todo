namespace SimpleTodo
{
    partial class EditTodoForm
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
            datePicker = new DateTimePicker();
            txtDesc = new TextBox();
            txtTitle = new TextBox();
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
            button1.Location = new Point(339, 300);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Verdana", 12F);
            datePicker.Location = new Point(33, 252);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(426, 32);
            datePicker.TabIndex = 3;
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Verdana", 12F);
            txtDesc.Location = new Point(33, 78);
            txtDesc.MaxLength = 76;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Description";
            txtDesc.Size = new Size(426, 158);
            txtDesc.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Verdana", 12F);
            txtTitle.Location = new Point(33, 30);
            txtTitle.MaxLength = 15;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(426, 32);
            txtTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(51, 73, 119);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(33, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Edit Task";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // EditTodoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 45, 72);
            ClientSize = new Size(490, 390);
            Controls.Add(button1);
            Controls.Add(datePicker);
            Controls.Add(txtDesc);
            Controls.Add(txtTitle);
            Controls.Add(btnAdd);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditTodoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTodoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker datePicker;
        private TextBox txtDesc;
        private TextBox txtTitle;
        private Button btnAdd;
    }
}