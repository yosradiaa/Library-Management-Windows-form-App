using Library_System.Model;
using System.Windows.Forms;

namespace Library_System
{
    public partial class PatronForm : Form
    {
        private readonly LibraryContext _context = new LibraryContext();
        int patronId;

        public PatronForm(int patronId)
        {
            InitializeComponent();
            //LoadBooks();
            //InsertDataIntoPatron();
            this.patronId = patronId;

        }

        private void LoadBooks()
        {
            using (var context = new LibraryContext())
            {
                var books = context.Book
                    .Select(b => new
                    {
                        b.ISBN,
                        b.Title,
                        b.Author,
                        b.Genre,
                        b.Quantity
                    })



                    .ToList();
                dataGridView1.DataSource = books;
            }
        }






        private void button1_Click(object sender, EventArgs e)

        {
            var isbns = _context.Book.Select(b => b.ISBN).ToList();
            List<string> reservations = _context.PatronReserveBook.Select(ptr => ptr.PatronID.ToString() + " " + ptr.ISBN.ToString()).ToList();
            if (long.TryParse(textBox1.Text, out long isbn))
            {
                if (isbns.Contains(isbn))
                {
                    if (!reservations.Contains(patronId.ToString() + " " + isbn.ToString()))
                    {
                        var reservation = new PatronReserveBook { ISBN = isbn, PatronID = patronId, ReservationDate = DateTime.Now };
                        _context.PatronReserveBook.Add(reservation);
                        _context.SaveChanges();

                        MessageBox.Show("Reservation successful! We will Call U when it Available");
                        LoadBooks();
                    }
                    else
                        MessageBox.Show("you made this reservation before");

                }
                else
                    MessageBox.Show("Invalid ISBN");


            }
            else
            {
                MessageBox.Show("Invalid ISBN");
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}