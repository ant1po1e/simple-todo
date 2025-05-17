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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoCard));
            lblTitle = new Label();
            lblDesc = new Label();
            lblDate = new Label();
            btnMenu = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            todoActionMenu1 = new SimpleTodo.TodoComponents.TodoActionMenu();
            contextMenuStrip1.SuspendLayout();
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
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(32, 45, 72);
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(227, 125);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 30);
            btnMenu.TabIndex = 4;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // todoActionMenu1
            // 
            todoActionMenu1.BackColor = Color.FromArgb(32, 45, 72);
            todoActionMenu1.Location = new Point(160, 34);
            todoActionMenu1.Name = "todoActionMenu1";
            todoActionMenu1.Size = new Size(98, 85);
            todoActionMenu1.TabIndex = 5;
            todoActionMenu1.Visible = false;
            // 
            // TodoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(todoActionMenu1);
            Controls.Add(lblDate);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(btnMenu);
            Name = "TodoCard";
            Size = new Size(270, 158);
            MouseDown += TodoCard_MouseDown;
            MouseMove += TodoCard_MouseMove;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDesc;
        private Label lblDate;
        private Button btnMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TodoComponents.TodoActionMenu todoActionMenu1;
    }
}
