using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class Patron
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        //public string Role { get; set; } // Admin , Librarian ,Patron  
        public string MembershipType { get; set; }//Student , Faculty , community member

        //public virtual ICollection<PatronReserveBook> Reservations { get; set; }
        // public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<PatronReserveBook> PatronReserveBooks { get; set; }

    }
}
