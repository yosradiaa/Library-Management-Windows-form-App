using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace Library_System
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            btnLogin = new Button();
            button2 = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(99, 151);
            txtUserName.Margin = new Padding(4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(411, 44);
            txtUserName.TabIndex = 1;
            txtUserName.MouseClick += txtUserName_MouseClick;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(99, 253);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(411, 44);
            txtPassword.TabIndex = 2;
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 80);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 1);
            panel1.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RosyBrown;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(99, 451);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(411, 56);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.RosyBrown;
            button2.Location = new Point(466, 555);
            button2.Name = "button2";
            button2.Size = new Size(170, 27);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(614, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(408, 529);
            label1.Name = "label1";
            label1.Size = new Size(228, 18);
            label1.TabIndex = 10;
            label1.Text = "Don't Have An Account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(235, 25);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 11;
            label2.Text = "Sign In";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(411, 27);
            comboBox1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(214, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 590);
            panel2.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btnLogin);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtUserName);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(txtPassword);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(459, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(641, 590);
            panel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RosyBrown;
            label5.Location = new Point(62, 318);
            label5.Name = "label5";
            label5.Size = new Size(222, 27);
            label5.TabIndex = 26;
            label5.Text = "MemberShip Type";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(466, 151);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(466, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(62, 211);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(3, 71);
            label9.Name = "label9";
            label9.Size = new Size(642, 10);
            label9.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(62, 109);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 12;
            label3.Text = "User Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(462, 590);
            panel3.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(459, 597);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1500, 690);
            Controls.Add(panel2);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Panel panel1;
        private Button btnLogin;
        private Button button2;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
