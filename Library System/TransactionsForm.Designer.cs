namespace Library_System
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            DueDateTimePicker = new DateTimePicker();
            StatuscomboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 456);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(224, 25);
            label2.Name = "label2";
            label2.Size = new Size(231, 34);
            label2.TabIndex = 3;
            label2.Text = "Transactions";
            // 
            // DueDateTimePicker
            // 
            DueDateTimePicker.Location = new Point(394, 592);
            DueDateTimePicker.Name = "DueDateTimePicker";
            DueDateTimePicker.Size = new Size(230, 27);
            DueDateTimePicker.TabIndex = 9;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(31, 592);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(250, 28);
            StatuscomboBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(179, 657);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(31, 657);
            button2.Name = "button2";
            button2.Size = new Size(104, 37);
            button2.TabIndex = 13;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(7, 545);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 15;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(371, 548);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 16;
            label4.Text = "Due Date";
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 3);
            button3.Name = "button3";
            button3.Size = new Size(111, 36);
            button3.TabIndex = 17;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(StatuscomboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DueDateTimePicker);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(85, 75);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 727);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(801, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 724);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 45);
            button4.Name = "button4";
            button4.Size = new Size(111, 36);
            button4.TabIndex = 19;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 868);
            Controls.Add(panel1);
            Name = "TransactionsForm";
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private DateTimePicker DueDateTimePicker;
        private ComboBox StatuscomboBox;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}