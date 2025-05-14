namespace SimpleTodo
{
    partial class TodoCard
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
            lblTitle = new Label();
            lblDesc = new Label();
            lblDate = new Label();
            btnDelete = new Button();
            btnMove = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(21, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "|";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = Color.DimGray;
            lblDesc.Location = new Point(15, 43);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(243, 73);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "|";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 134);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(102, 18);
            lblDate.TabIndex = 2;
            lblDate.Text = "99/99/9999";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(142, 125);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnMove
            // 
            btnMove.BackColor = Color.FromArgb(32, 45, 72);
            btnMove.Cursor = Cursors.Hand;
            btnMove.FlatAppearance.BorderSize = 0;
            btnMove.FlatStyle = FlatStyle.Flat;
            btnMove.ForeColor = Color.White;
            btnMove.Location = new Point(142, 125);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(125, 30);
            btnMove.TabIndex = 4;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = false;
            // 
            // TodoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 246, 255);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDate);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnMove);
            Name = "TodoCard";
            Size = new Size(270, 158);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDesc;
        private Label lblDate;
        private Button btnDelete;
        private Button btnMove;
    }
}
