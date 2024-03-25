using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class PatronReserveBook
    {
        [ForeignKey("Book")]
        public long ISBN { get; set; }

        [ForeignKey("Patron")]
        public int PatronID { get; set; }

        [DefaultValue(typeof(DateTime), "GETDATE()")]
        public DateTime ReservationDate { get; set; }

        public Book Book { get; set; }
        public Patron Patron { get; set; }

    }
}
