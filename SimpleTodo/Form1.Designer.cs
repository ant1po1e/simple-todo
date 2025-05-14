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
            label4 = new Label();
            txtSearch = new TextBox();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btpResetFilter = new Button();
            flowPanelToStart = new ScrollableFlowPanel();
            flowPanelInProgress = new ScrollableFlowPanel();
            flowPanelCompleted = new ScrollableFlowPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 162, 184);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 177);
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
            panel2.Location = new Point(304, 177);
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
            panel3.Location = new Point(597, 177);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(341, 11);
            label4.Name = "label4";
            label4.Size = new Size(193, 45);
            label4.TabIndex = 6;
            label4.Text = "My Todo";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(202, 66);
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
            dtTo.Location = new Point(501, 117);
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
            dtFrom.Location = new Point(272, 117);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(171, 32);
            dtFrom.TabIndex = 9;
            dtFrom.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(202, 121);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 10;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(461, 121);
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
            btpResetFilter.Location = new Point(691, 117);
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
            flowPanelToStart.BackColor = Color.FromArgb(51, 73, 119);
            flowPanelToStart.FlowDirection = FlowDirection.TopDown;
            flowPanelToStart.Location = new Point(12, 226);
            flowPanelToStart.Name = "flowPanelToStart";
            flowPanelToStart.Size = new Size(276, 617);
            flowPanelToStart.TabIndex = 16;
            flowPanelToStart.WrapContents = false;
            // 
            // flowPanelInProgress
            // 
            flowPanelInProgress.AutoScroll = true;
            flowPanelInProgress.BackColor = Color.FromArgb(51, 73, 119);
            flowPanelInProgress.FlowDirection = FlowDirection.TopDown;
            flowPanelInProgress.Location = new Point(304, 226);
            flowPanelInProgress.Name = "flowPanelInProgress";
            flowPanelInProgress.Size = new Size(276, 617);
            flowPanelInProgress.TabIndex = 17;
            flowPanelInProgress.WrapContents = false;
            // 
            // flowPanelCompleted
            // 
            flowPanelCompleted.AutoScroll = true;
            flowPanelCompleted.BackColor = Color.FromArgb(51, 73, 119);
            flowPanelCompleted.FlowDirection = FlowDirection.TopDown;
            flowPanelCompleted.Location = new Point(597, 226);
            flowPanelCompleted.Name = "flowPanelCompleted";
            flowPanelCompleted.Size = new Size(276, 617);
            flowPanelCompleted.TabIndex = 18;
            flowPanelCompleted.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 45, 72);
            ClientSize = new Size(885, 855);
            Controls.Add(flowPanelCompleted);
            Controls.Add(flowPanelInProgress);
            Controls.Add(flowPanelToStart);
            Controls.Add(btpResetFilter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtFrom);
            Controls.Add(dtTo);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Todo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Label label4;
        private TextBox txtSearch;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Label label5;
        private Label label6;
        private Button btpResetFilter;
        private ScrollableFlowPanel flowPanelToStart;
        private ScrollableFlowPanel flowPanelInProgress;
        private ScrollableFlowPanel flowPanelCompleted;
    }
}
