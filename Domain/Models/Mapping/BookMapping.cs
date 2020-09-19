using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class BookMapping : EntityTypeConfiguration<Book>
    {
        public BookMapping()
        {
            ToTable("Book");
            HasKey(x => x.Id);

            Property(x => x.BookCode).IsRequired().HasMaxLength(100);
            Property(x => x.Name).IsRequired().HasMaxLength(100);

            Property(x => x.Status).IsRequired();
            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");

            HasRequired(x => x.Author).WithMany(x => x.Books).HasForeignKey(x => x.AuthorId);
            HasRequired(x => x.Editorial).WithMany(x => x.Books).HasForeignKey(x => x.EditorialId);
        }
    }
}
