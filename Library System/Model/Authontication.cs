﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class Authontication
    {
        [Key]
        static public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Role { get; set; } // Admin , Librarian ,Patron  

        public Authontication() {
            Id++;
        }

    }
}
