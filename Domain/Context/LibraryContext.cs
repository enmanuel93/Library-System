using Domain.Models;
using Domain.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("LibraryDB")
        {

        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Devolution> devolutions { get; set; }
        public DbSet<Editorial> editorials { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMapping());
            modelBuilder.Configurations.Add(new LoanMapping());
            modelBuilder.Configurations.Add(new BookMapping());
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new DevolutionMapping());
            modelBuilder.Configurations.Add(new EditorialMapping());
            modelBuilder.Configurations.Add(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
