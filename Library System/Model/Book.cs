using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class Book
    {
        [Key]
        public long ISBN { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime PublicationDate { get; set; }

        public int Quantity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        //public virtual ICollection<PatronReserveBook> Reservations { get; set; }
        //public virtual ICollection<Patron> Patron { get; set; }
        public virtual ICollection<PatronReserveBook> PatronReserveBooks { get; set; }

    }
}
