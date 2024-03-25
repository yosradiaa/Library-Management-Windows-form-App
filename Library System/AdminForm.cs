using Library_System.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_System
{
    public partial class AdminForm : Form
    {

        private readonly LibraryContext dbContext;
        long selectedBookId;
        int selectedLibranianId;
        public AdminForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Admin";


            InitializeComponent();

            BookdataGridView.SelectionChanged += dataGridView2_SelectionChanged;
            LibraniandataGridView.SelectionChanged += dataGridView1_SelectionChanged;

            dbContext = new LibraryContext();
            DisplayLibrarians();
            DisplayBooks();
        }

        //Display Librarian
        private void DisplayLibrarians()
        {
            var librarians = dbContext.Librarian
               .Select(l => new
               {
                   l.Name,
                   l.Password,
                   l.Phone,
                   l.Address
               }).ToList();
            LibraniandataGridView.DataSource = librarians;
        }


        //Add Librarian Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(PhonetextBox.ForeColor == System.Drawing.Color.Red) || (PhonetextBox == null))
            {
                try
                {
                    string name = NametextBox.Text;
                    string password = PasstextBox.Text;
                    string phone = PhonetextBox.Text;
                    string address = AddresstextBox.Text;

                    if (!(name == "" || password == "" || address == "" || phone == ""))
                    {

                        var newLibrarian = new Librarian
                        {
                            Name = name,
                            Password = password,
                            Phone = phone,
                            Address = address
                        };


                        dbContext.Librarian.Add(newLibrarian);


                        dbContext.SaveChanges();

                        MessageBox.Show("Librarian added successfully!");
                        ResetBoxes();
                        NametextBox.Text = AddresstextBox.Text = PasstextBox.Text = PhonetextBox.Text = "";
                        DisplayLibrarians();
                    }
                    else
                    {
                        MessageBox.Show("All Data Required");
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
            


            else
            {
                MessageBox.Show("Enter a valid phone number");

            }
        }

        private void ResetBoxes()
        {
            NametextBox.Text = "";
            PasstextBox.Text = "";
            PhonetextBox.Text = "";
            AddresstextBox.Text = "";
        }



        //Delete Librarian
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (LibraniandataGridView.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = LibraniandataGridView.SelectedRows[0];
                    string name = selectedRow.Cells["Name"].Value.ToString();
                    var librarianToDelete = dbContext.Librarian.FirstOrDefault(l => l.Name == name);


                    if (librarianToDelete != null)
                    {

                        dbContext.Librarian.Remove(librarianToDelete);


                        dbContext.SaveChanges();
                        NametextBox.Text = AddresstextBox.Text = PasstextBox.Text = PhonetextBox.Text = "";

                        MessageBox.Show("Librarian deleted successfully!");
                        DisplayLibrarians();
                    }
                    else
                    {
                        MessageBox.Show("Selected librarian not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a librarian to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox11.Text.Trim();
            var searchResult = dbContext.Librarian
                                    .Where(b => b.Name.Contains(searchTerm))
                                    .ToList();


            LibraniandataGridView.DataSource = searchResult;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            DisplayBooks();
        }

        //tap2
        //Dispaly Books 
        private void DisplayBooks()
        {
            var books = dbContext.Book
               .Select(book => new
               {
                   book.ISBN,
                   book.Genre,
                   book.Title,
                   book.Author,
                   book.PublicationDate,
                   book.Quantity,
                   book.AvailabilityStatus

               }).ToList();
            BookdataGridView.DataSource = books;
        }

        //Add Book Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string genre = GernetextBox.Text;
                string title = TitletextBox.Text;
                string author = AuthortextBox.Text;
                DateTime publicationDate = PublicationdateTimePicker.Value;
                int quantity = Convert.ToInt32(QuantitytextBox.Text);
                bool availabilityStatus = AvailabilitycheckBox.Checked;


                var newBook = new Book
                {
                    Genre = genre,
                    Title = title,
                    Author = author,
                    PublicationDate = publicationDate,
                    Quantity = quantity,
                    AvailabilityStatus = availabilityStatus
                };


                dbContext.Book.Add(newBook);

                dbContext.SaveChanges();

                MessageBox.Show("Book added successfully!");
                GernetextBox.Text = TitletextBox.Text = AuthortextBox.Text = QuantitytextBox.Text = PublicationdateTimePicker.Text = "";
                AvailabilitycheckBox.Checked = false;
                DisplayBooks(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Delete Book Button
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (BookdataGridView.SelectedRows.Count > 0)
                {

                    int rowIndex = BookdataGridView.SelectedRows[0].Index;


                    long isbn = Convert.ToInt64(BookdataGridView.Rows[rowIndex].Cells["ISBN"].Value);


                    var bookToDelete = dbContext.Book.FirstOrDefault(b => b.ISBN == isbn);


                    if (bookToDelete != null)
                    {

                        dbContext.Book.Remove(bookToDelete);


                        dbContext.SaveChanges();
                        GernetextBox.Text = TitletextBox.Text = AuthortextBox.Text = QuantitytextBox.Text = PublicationdateTimePicker.Text = "";
                        AvailabilitycheckBox.Checked = false;

                        MessageBox.Show("Book deleted successfully!");
                        DisplayBooks();
                    }
                    else
                    {
                        MessageBox.Show("Selected book not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        //Search Button
        private void button6_Click(object sender, EventArgs e)
        {


            string searchTerm = textBox9.Text.Trim();
            var searchResult = dbContext.Book
                                    .Where(b => b.Title.Contains(searchTerm) || b.Author.Contains(searchTerm))
                                    .ToList();


            BookdataGridView.DataSource = searchResult;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            DisplayBooks();
        }




        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (BookdataGridView.SelectedRows.Count > 0)
                {

                    int rowIndex = BookdataGridView.SelectedRows[0].Index;


                    long isbn = Convert.ToInt64(BookdataGridView.Rows[rowIndex].Cells["ISBN"].Value);


                    var bookToUpdate = dbContext.Book.FirstOrDefault(b => b.ISBN == isbn);
                    bookToUpdate.Genre = GernetextBox.Text = bookToUpdate.Genre;
                    bookToUpdate.Title = TitletextBox.Text = bookToUpdate.Title;
                    bookToUpdate.Author = AuthortextBox.Text = bookToUpdate.Author;
                    PublicationdateTimePicker.Value = bookToUpdate.PublicationDate;
                    QuantitytextBox.Text = Convert.ToString(bookToUpdate.Quantity);
                    AvailabilitycheckBox.Checked = bookToUpdate.AvailabilityStatus;


                    if (bookToUpdate != null)
                    {

                        bookToUpdate.Genre = GernetextBox.Text;
                        bookToUpdate.Title = TitletextBox.Text;
                        bookToUpdate.Author = AuthortextBox.Text;
                        bookToUpdate.PublicationDate = PublicationdateTimePicker.Value;
                        bookToUpdate.Quantity = Convert.ToInt32(AuthortextBox.Text);
                        bookToUpdate.AvailabilityStatus = AvailabilitycheckBox.Checked;

                        dbContext.SaveChanges();

                        MessageBox.Show("Book updated successfully!");
                        DisplayBooks();
                    }
                    else
                    {
                        MessageBox.Show("Selected book not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibraniandataGridView.RowTemplate.Height = 150;
            LibraniandataGridView.ColumnHeadersHeight = 150;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn1 = new SignIn();
            signIn1.ShowDialog();
            this.Close();
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Your code here
            if (BookdataGridView.SelectedRows.Count > 0)
            {
                //Finestxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                GernetextBox.Text = BookdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TitletextBox.Text = BookdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                AuthortextBox.Text = BookdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                QuantitytextBox.Text = BookdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                PublicationdateTimePicker.Text = BookdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                AvailabilitycheckBox.Checked = (BookdataGridView.SelectedRows[0].Cells[6].Value.ToString() == "True") ? true : false;
                // MessageBox.Show(BookdataGridView.SelectedRows[0].Cells[6].Value.ToString());

                selectedBookId = long.Parse(BookdataGridView.SelectedRows[0].Cells[0].Value.ToString());


            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var UpdatedBook = dbContext.Book.Find(selectedBookId);
            UpdatedBook.Genre = GernetextBox.Text;
            UpdatedBook.Title = TitletextBox.Text;
            UpdatedBook.Author = AuthortextBox.Text;
            UpdatedBook.Quantity = int.Parse(QuantitytextBox.Text);
            UpdatedBook.PublicationDate = PublicationdateTimePicker.Value;
            UpdatedBook.AvailabilityStatus = AvailabilitycheckBox.Checked;
            dbContext.SaveChanges();
            GernetextBox.Text = TitletextBox.Text = AuthortextBox.Text = QuantitytextBox.Text = PublicationdateTimePicker.Text = "";
            AvailabilitycheckBox.Checked = false;
            DisplayBooks();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Your code here
            if (LibraniandataGridView.SelectedRows.Count > 0)
            {
                //Finestxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                NametextBox.Text = LibraniandataGridView.SelectedRows[0].Cells[0].Value.ToString();
                PasstextBox.Text = LibraniandataGridView.SelectedRows[0].Cells[1].Value.ToString();
                AddresstextBox.Text = LibraniandataGridView.SelectedRows[0].Cells[3].Value.ToString();
                PhonetextBox.Text = LibraniandataGridView.SelectedRows[0].Cells[2].Value.ToString();

                selectedLibranianId = dbContext.Librarian.
                    Where(lib => lib.Name == NametextBox.Text && lib.Password == PasstextBox.Text && lib.Address == AddresstextBox.Text && lib.Phone == PhonetextBox.Text)
                    .Select(x => x.Id).FirstOrDefault();




            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            var UpdatedLipranian = dbContext.Librarian.Find(selectedLibranianId);
            UpdatedLipranian.Name = NametextBox.Text;
            UpdatedLipranian.Address = AddresstextBox.Text;
            UpdatedLipranian.Password = PasstextBox.Text;
            UpdatedLipranian.Phone = PhonetextBox.Text;

            dbContext.SaveChanges();
            NametextBox.Text = AddresstextBox.Text = PasstextBox.Text = PhonetextBox.Text = "";
            DisplayLibrarians();
        }

        private void PhonetextBox_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = PhonetextBox.Text;


            Regex phoneRegex = new Regex(@"^(010|011|012)?\d{8}$");


            if (phoneRegex.IsMatch(phoneNumber))
            {

                PhonetextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                PhonetextBox.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}




