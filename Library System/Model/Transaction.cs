using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DefaultValue(typeof(DateTime), "GETDATE()")]
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        [DefaultValue(false)]

        public bool Returned { get; set; }//Borrowed , returned
        [DefaultValue(0)]
        public int Fines { get; set; }
        [ForeignKey("Patron")]

        public int PatronID { get; set; }
        [ForeignKey("Librarian")]
        public int LibrarianId { get; set; }
        [ForeignKey("Book")]
        public long ISBN { get; set; }

        public virtual Librarian Librarian { get; set; }

        public virtual Book Book { get; set; }
        public virtual Patron Patron { get; set; }
    }
}
