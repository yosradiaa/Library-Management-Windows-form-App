using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Model
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Patron> Patron { get; set; }

        public DbSet<Librarian> Librarian { get; set; }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<PatronReserveBook> PatronReserveBook { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YOSRA\\SQLEXPRESS;Database=Library;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PatronReserveBook>()
            //                .HasKey(e => new { e.Patron, e.ISBN });

            //modelBuilder.Entity<PatronReserveBook>()
            //    .HasOne(prb => prb.Patron)
            //    .WithMany(p => p.Reservations)
            //    .HasForeignKey(prb => prb.PatronID);

            //modelBuilder.Entity<PatronReserveBook>()
            //    .HasOne(prb => prb.Book)
            //    .WithMany(b => b.Reservations)
            //    .HasForeignKey(prb => prb.ISBN);
            modelBuilder.Entity<PatronReserveBook>()
        .HasKey(prb => new { prb.ISBN, prb.PatronID });

            modelBuilder.Entity<PatronReserveBook>()
                .HasOne(prb => prb.Book)
                .WithMany(b => b.PatronReserveBooks)
                .HasForeignKey(prb => prb.ISBN);

            modelBuilder.Entity<PatronReserveBook>()
                .HasOne(prb => prb.Patron)
                .WithMany(p => p.PatronReserveBooks)
                .HasForeignKey(prb => prb.PatronID);


            base.OnModelCreating(modelBuilder);

        }
    }
}
