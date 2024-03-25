using Library_System.Model;

namespace Library_System
{
    public partial class SignIn : Form
    {
        LibraryContext context = new LibraryContext();
        public SignIn()
        {
            InitializeComponent();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Patron");
            comboBox1.Items.Add("Libranian");
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Clear();
            }

        }



        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from textboxes
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (comboBox1.Text == "Admin")
            {

                if (username == "admin" && password == "admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    this.Close();
                    // MessageBox.Show("Login successful!");
                }
                MessageBox.Show("Not valid Admin");
            }
            else if (comboBox1.Text == "Patron")
            {
                Patron patron = context.Patron.FirstOrDefault(patron => patron.Name == username && patron.Password == password);
                if (patron != null)
                {
                    this.Hide();
                    PatronForm patronForm = new PatronForm(patron.Id);
                    patronForm.ShowDialog();
                    this.Close();
                }

                MessageBox.Show("Not valid Patron , Sign Up please");

            }
            else if (comboBox1.Text == "Libranian")
            {
                Librarian libranian = context.Librarian.FirstOrDefault(libr => libr.Name == username && libr.Password == password);
                if (libranian != null)
                {
                    this.Hide();
                    LibrarianForm librarianForm = new LibrarianForm(libranian.Id);
                    librarianForm.ShowDialog();
                    this.Close();
                }

                MessageBox.Show("Not valid Libranian , ask Admin to join");

            }


            MessageBox.Show("Invalid username or password. Please try again.");


        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm patronForm = new SignUpForm();
            // Show PatronForm and hide Form1
            patronForm.ShowDialog();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}


