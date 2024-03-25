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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_System
{
    public partial class TransactionsForm : Form
    {
        int selectedTrasId;
        int LibrarianID;
        LibraryContext context = new LibraryContext();
        public TransactionsForm(int LibrarianID)
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.LibrarianID = LibrarianID;
            StatuscomboBox.Items.Add("Returned");
            StatuscomboBox.Items.Add("Borrowed");
        }

        public void disply()
        {
            var Transactions = context.Transaction.Include(tr => tr.Librarian).Include(tr => tr.Patron).Include(tr => tr.Book).
               Where(Trans => Trans.Librarian.Id == LibrarianID).Select(Transactioninfo =>
               new
               {
                   //Transactioninfo.
                   Patron_Name = Transactioninfo.Patron.Name,
                   //Patron_ID = Transactioninfo.PatronID,
                   Book_Title = Transactioninfo.Book.Title,
                   //ISBN = Transactioninfo.ISBN,
                   //Reservation_Time = Transactioninfo.ReservationDate
                   Returned_Status = Transactioninfo.Returned,
                   Fines = Transactioninfo.Fines,
                   Return_Date = Transactioninfo.DueDate,
                   Librarian_Name = Transactioninfo.Librarian.Name
               }).ToList();
            dataGridView1.DataSource = Transactions;

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Your code here
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Finestxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                StatuscomboBox.Text = (bool.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) == true) ? "Returned" : "Borrowed";
                DueDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string patronName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string bookName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                //MessageBox.Show(patronName+"  "+ bookName +"  "+ DueDateTimePicker.Value.ToString());

                selectedTrasId = context.Transaction.
                    Where(trans => (trans.Patron.Name == patronName) && (trans.Book.Title == bookName)).Select(t => t.Id).FirstOrDefault();
                

            }

        }


        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            disply();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedTrasId != 0)
            {
                var UpdatedTrans = context.Transaction.Find(selectedTrasId);
                UpdatedTrans.Returned = (StatuscomboBox.Text == "Returned") ? true : false;
                UpdatedTrans.DueDate = DueDateTimePicker.Value;
                UpdatedTrans.Fines = CalculateFines(UpdatedTrans.DueDate);
                context.SaveChanges();
                StatuscomboBox.Text = DueDateTimePicker.Text = "";
                disply();
            }
            else
            {
                MessageBox.Show("You must select the transaction to update");
            }
            
        }
        public int CalculateFines(DateTime duedate)
        {
            int days = (DateTime.Now - duedate).Days;

            if (days < 0) { return 0; }
            return days * 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedTrasId != 0)
            {
                context.Transaction.Remove(context.Transaction.Find(selectedTrasId));
                context.SaveChanges();
                StatuscomboBox.Text = DueDateTimePicker.Text = "";
                disply();
            }
            else
                MessageBox.Show("You must select the transaction to delete");

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
            LibrarianForm librarianForm = new LibrarianForm(LibrarianID);
            librarianForm.ShowDialog();
            this.Close();
        }
    }
}
