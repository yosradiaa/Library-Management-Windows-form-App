using Library_System.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Transaction = Library_System.Model.Transaction;

namespace Library_System
{
    public partial class LibrarianForm : Form
    {
        LibraryContext context = new LibraryContext();
        int LibrarianId;
        public LibrarianForm(int LibrarianID)
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.LibrarianId = LibrarianID;
        }

        public void disply()
        {
            var Reservations = context.PatronReserveBook.Include(prs => prs.Patron).Include(prs => prs.Book).
               Select(Reservationinfo =>
               new
               {
                   Patron_Name = Reservationinfo.Patron.Name,
                   Patron_ID = Reservationinfo.PatronID,
                   Book_Name = Reservationinfo.Book.Title,
                   ISBN = Reservationinfo.ISBN,
                   Reservation_Time = Reservationinfo.ReservationDate
               }).ToList();
            dataGridView1.DataSource = Reservations;

        }
        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            disply();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Your code here
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PatronIDtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ISBNtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool Available = context.Book.
                Where(b => b.ISBN == long.Parse(ISBNtxt.Text)).
                Select(book => book.AvailabilityStatus).FirstOrDefault();
            if (Available)
            {
                Transaction transaction = new Transaction
                {
                    PatronID = int.Parse(PatronIDtxt.Text),
                    ISBN = long.Parse(ISBNtxt.Text),
                    TransactionDate = DateTime.Now,
                    DueDate = DueDateTimePicker.Value,
                    LibrarianId = LibrarianId,
                };
                context.Transaction.Add(transaction);
                context.SaveChanges();
                int quan = --context.Book.Find(long.Parse(ISBNtxt.Text)).Quantity;
                context.SaveChanges();

                if (quan == 0)
                {
                    context.Book.Find(long.Parse(ISBNtxt.Text)).AvailabilityStatus = false;
                    context.SaveChanges();
                }
                context.PatronReserveBook.Remove(context.PatronReserveBook.Find(transaction.ISBN, transaction.PatronID));
                //context.Students.Remove(context.Students.Find(selectedId));
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("this book isn’t Available right now , try again soon");
            }
            PatronIDtxt.Text = ISBNtxt.Text = DueDateTimePicker.Text = "";
            disply();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionsForm transactionsForm = new TransactionsForm(LibrarianId);
            transactionsForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

      

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionsForm transactionsForm = new TransactionsForm(LibrarianId);
            transactionsForm.ShowDialog();
            this.Close();
        }
    }
}
