namespace Library_System
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            memberComb = new ComboBox();
            btnLogin2 = new Button();
            btnSignUp = new Button();
            btnClose2 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(442, 84);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(442, 174);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(442, 254);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(442, 334);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RosyBrown;
            label5.Location = new Point(442, 417);
            label5.Name = "label5";
            label5.Size = new Size(205, 23);
            label5.TabIndex = 4;
            label5.Text = "Membership Type";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(471, 201);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 40);
            txtPassword.TabIndex = 8;
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ButtonHighlight;
            txtUserName.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(471, 111);
            txtUserName.Margin = new Padding(4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(346, 40);
            txtUserName.TabIndex = 7;
            txtUserName.MouseClick += txtUserName_MouseClick;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(471, 281);
            txtPhone.Margin = new Padding(4);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(346, 40);
            txtPhone.TabIndex = 10;
            txtPhone.MouseClick += txtPhone_MouseClick;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(471, 361);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(346, 40);
            txtAddress.TabIndex = 12;
            txtAddress.MouseClick += txtAddress_MouseClick;
            // 
            // memberComb
            // 
            memberComb.BackColor = Color.White;
            memberComb.FormattingEnabled = true;
            memberComb.Location = new Point(471, 452);
            memberComb.Name = "memberComb";
            memberComb.Size = new Size(346, 23);
            memberComb.TabIndex = 14;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = Color.Transparent;
            btnLogin2.FlatStyle = FlatStyle.Popup;
            btnLogin2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin2.ForeColor = Color.RosyBrown;
            btnLogin2.Location = new Point(859, 608);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(161, 28);
            btnLogin2.TabIndex = 16;
            btnLogin2.Text = "Sign In";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.RosyBrown;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(471, 503);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(346, 53);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnClose2
            // 
            btnClose2.BackColor = Color.White;
            btnClose2.FlatStyle = FlatStyle.Popup;
            btnClose2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose2.ForeColor = Color.Black;
            btnClose2.Location = new Point(1013, 0);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(27, 30);
            btnClose2.TabIndex = 17;
            btnClose2.Text = "X";
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += btnClose_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(836, 579);
            label6.Name = "label6";
            label6.Size = new Size(197, 21);
            label6.TabIndex = 19;
            label6.Text = " Have An Acoount?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnClose2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(memberComb);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(174, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 643);
            panel1.TabIndex = 20;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(410, 70);
            label9.Name = "label9";
            label9.Size = new Size(628, 3);
            label9.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RosyBrown;
            label7.Location = new Point(629, 13);
            label7.Name = "label7";
            label7.Size = new Size(129, 45);
            label7.TabIndex = 20;
            label7.Text = "SignUp";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 639);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 639);
            panel3.TabIndex = 0;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(401, 70);
            label8.Name = "label8";
            label8.Size = new Size(641, 3);
            label8.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1333, 980);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1333, 827);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox memberComb;
        private Button btnLogin2;
        private Button btnSignUp;
        private Button btnClose2;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
    }
}