namespace StudentProfile
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
            label1 = new Label();
            lblName = new Label();
            lblID = new Label();
            lblYear = new Label();
            groupBox1 = new GroupBox();
            txtStudentID = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 18);
            label1.TabIndex = 0;
            label1.Text = "Enter Student ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaption;
            lblName.Font = new Font("Stencil", 9F);
            lblName.Location = new Point(31, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = SystemColors.ActiveCaption;
            lblID.Font = new Font("Stencil", 9F);
            lblID.Location = new Point(31, 196);
            lblID.Name = "lblID";
            lblID.Size = new Size(29, 18);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = SystemColors.ActiveCaption;
            lblYear.Font = new Font("Stencil", 9F);
            lblYear.Location = new Point(31, 248);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(50, 18);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Stencil", 9F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(174, 45);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(261, 25);
            txtStudentID.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 192);
            btnSearch.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(135, 295);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 53);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(459, 360);
            Controls.Add(btnSearch);
            Controls.Add(groupBox1);
            Controls.Add(lblYear);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblID;
        private Label lblYear;
        private GroupBox groupBox1;
        private TextBox txtStudentID;
        private Button btnSearch;
    }
}
