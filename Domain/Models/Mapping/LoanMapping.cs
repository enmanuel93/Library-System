using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class LoanMapping : EntityTypeConfiguration<Loan>
    {
        public LoanMapping()
        {
            ToTable("Loan");

            HasKey(x => x.Id);

            Property(x => x.LoanCode).IsRequired().HasMaxLength(100);
            Property(x => x.Status).IsRequired();

            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");

            HasRequired(x => x.Book).WithMany(x => x.Loans).HasForeignKey(x => x.BookId);
            HasRequired(x => x.Student).WithMany(x => x.Loans).HasForeignKey(x => x.StudentId);
        }
    }
}
