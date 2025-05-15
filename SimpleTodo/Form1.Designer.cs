using SimpleTodo.CustomControl;

namespace SimpleTodo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            profileTitle = new Label();
            txtSearch = new TextBox();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btpResetFilter = new Button();
            flowPanelToStart = new ScrollableFlowPanel();
            flowPanelInProgress = new ScrollableFlowPanel();
            flowPanelCompleted = new ScrollableFlowPanel();
            panel4 = new Panel();
            label7 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            flowPanelProfiles = new ScrollableFlowPanel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 162, 184);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(353, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 43);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 43);
            label1.TabIndex = 4;
            label1.Text = "Pending";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(645, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 43);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(276, 43);
            label2.TabIndex = 4;
            label2.Text = "In Progress";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 162, 184);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(938, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 43);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(139, 195, 74);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(276, 43);
            label3.TabIndex = 4;
            label3.Text = "Completed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileTitle
            // 
            profileTitle.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileTitle.ForeColor = Color.Black;
            profileTitle.Location = new Point(582, 40);
            profileTitle.Name = "profileTitle";
            profileTitle.Size = new Size(400, 34);
            profileTitle.TabIndex = 6;
            profileTitle.Text = "In Workspace: none";
            profileTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(546, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(470, 32);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dtTo
            // 
            dtTo.CalendarFont = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(845, 134);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(171, 32);
            dtTo.TabIndex = 8;
            dtTo.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtFrom
            // 
            dtFrom.CalendarFont = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFrom.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(616, 134);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(171, 32);
            dtFrom.TabIndex = 9;
            dtFrom.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(546, 138);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 10;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(805, 138);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 11;
            label6.Text = "To";
            // 
            // btpResetFilter
            // 
            btpResetFilter.BackColor = Color.FromArgb(51, 73, 119);
            btpResetFilter.FlatAppearance.BorderSize = 0;
            btpResetFilter.FlatStyle = FlatStyle.Flat;
            btpResetFilter.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btpResetFilter.ForeColor = Color.White;
            btpResetFilter.Location = new Point(1035, 134);
            btpResetFilter.Name = "btpResetFilter";
            btpResetFilter.Size = new Size(99, 32);
            btpResetFilter.TabIndex = 15;
            btpResetFilter.Text = "Reset";
            btpResetFilter.UseVisualStyleBackColor = false;
            btpResetFilter.Click += btpResetFilter_Click;
            // 
            // flowPanelToStart
            // 
            flowPanelToStart.AutoScroll = true;
            flowPanelToStart.BackColor = Color.FromArgb(242, 246, 255);
            flowPanelToStart.FlowDirection = FlowDirection.TopDown;
            flowPanelToStart.Location = new Point(353, 221);
            flowPanelToStart.Name = "flowPanelToStart";
            flowPanelToStart.Size = new Size(276, 617);
            flowPanelToStart.TabIndex = 16;
            flowPanelToStart.WrapContents = false;
            // 
            // flowPanelInProgress
            // 
            flowPanelInProgress.AutoScroll = true;
            flowPanelInProgress.BackColor = Color.FromArgb(242, 246, 255);
            flowPanelInProgress.FlowDirection = FlowDirection.TopDown;
            flowPanelInProgress.Location = new Point(645, 221);
            flowPanelInProgress.Name = "flowPanelInProgress";
            flowPanelInProgress.Size = new Size(276, 617);
            flowPanelInProgress.TabIndex = 17;
            flowPanelInProgress.WrapContents = false;
            // 
            // flowPanelCompleted
            // 
            flowPanelCompleted.AutoScroll = true;
            flowPanelCompleted.BackColor = Color.FromArgb(242, 246, 255);
            flowPanelCompleted.FlowDirection = FlowDirection.TopDown;
            flowPanelCompleted.Location = new Point(938, 221);
            flowPanelCompleted.Name = "flowPanelCompleted";
            flowPanelCompleted.Size = new Size(276, 617);
            flowPanelCompleted.TabIndex = 18;
            flowPanelCompleted.WrapContents = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(32, 45, 72);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(flowPanelProfiles);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 855);
            panel4.TabIndex = 19;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 107);
            label7.Name = "label7";
            label7.Size = new Size(332, 49);
            label7.TabIndex = 22;
            label7.Text = "Workspaces";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(43, 784);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Workspace";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Goldenrod;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(43, 748);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(250, 30);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit Workspace";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // flowPanelProfiles
            // 
            flowPanelProfiles.AutoScroll = true;
            flowPanelProfiles.BackColor = Color.White;
            flowPanelProfiles.Location = new Point(43, 172);
            flowPanelProfiles.Name = "flowPanelProfiles";
            flowPanelProfiles.Size = new Size(250, 533);
            flowPanelProfiles.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(582, 0);
            label4.Name = "label4";
            label4.Size = new Size(400, 49);
            label4.TabIndex = 20;
            label4.Text = "My Todo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1230, 855);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(flowPanelCompleted);
            Controls.Add(flowPanelInProgress);
            Controls.Add(flowPanelToStart);
            Controls.Add(btpResetFilter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtFrom);
            Controls.Add(dtTo);
            Controls.Add(txtSearch);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(profileTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Todo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label profileTitle;
        private TextBox txtSearch;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Label label5;
        private Label label6;
        private Button btpResetFilter;
        private ScrollableFlowPanel flowPanelToStart;
        private ScrollableFlowPanel flowPanelInProgress;
        private ScrollableFlowPanel flowPanelCompleted;
        private Panel panel4;
        private ScrollableFlowPanel flowPanelProfiles;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private Label label7;
    }
}
