namespace Library_System
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            DueDateTimePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ISBNtxt = new TextBox();
            PatronIDtxt = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 733);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(166, 27);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 1;
            label1.Text = "Reservations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(119, 804);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 2;
            label2.Text = "Transactions";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(DueDateTimePicker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ISBNtxt);
            groupBox1.Controls.Add(PatronIDtxt);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 812);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.RosyBrown;
            button4.Location = new Point(86, 688);
            button4.Name = "button4";
            button4.Size = new Size(347, 47);
            button4.TabIndex = 14;
            button4.Text = "Manage Transaction";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(162, 52);
            label6.Name = "label6";
            label6.Size = new Size(257, 37);
            label6.TabIndex = 13;
            label6.Text = "TransaAction";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 815);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(86, 604);
            button1.Name = "button1";
            button1.Size = new Size(354, 60);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DueDateTimePicker
            // 
            DueDateTimePicker.Location = new Point(86, 495);
            DueDateTimePicker.Name = "DueDateTimePicker";
            DueDateTimePicker.Size = new Size(354, 27);
            DueDateTimePicker.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RosyBrown;
            label5.Location = new Point(71, 436);
            label5.Name = "label5";
            label5.Size = new Size(124, 27);
            label5.TabIndex = 6;
            label5.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(58, 291);
            label4.Name = "label4";
            label4.Size = new Size(68, 27);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(58, 181);
            label3.Name = "label3";
            label3.Size = new Size(138, 27);
            label3.TabIndex = 4;
            label3.Text = "Patron ID";
            // 
            // ISBNtxt
            // 
            ISBNtxt.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ISBNtxt.Location = new Point(86, 345);
            ISBNtxt.Multiline = true;
            ISBNtxt.Name = "ISBNtxt";
            ISBNtxt.ReadOnly = true;
            ISBNtxt.Size = new Size(354, 47);
            ISBNtxt.TabIndex = 1;
            // 
            // PatronIDtxt
            // 
            PatronIDtxt.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatronIDtxt.Location = new Point(86, 225);
            PatronIDtxt.Multiline = true;
            PatronIDtxt.Name = "PatronIDtxt";
            PatronIDtxt.ReadOnly = true;
            PatronIDtxt.Size = new Size(354, 45);
            PatronIDtxt.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Location = new Point(101, 712);
            button2.Name = "button2";
            button2.Size = new Size(181, 49);
            button2.TabIndex = 10;
            button2.Text = "Manage Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(399, 809);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(71, 43);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1483, 815);
            panel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(610, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(873, 815);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(614, 815);
            panel2.TabIndex = 0;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1594, 873);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox PatronIDtxt;
        private TextBox ISBNtxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private DateTimePicker DueDateTimePicker;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button4;
    }
}