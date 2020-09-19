using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class DevolutionMapping : EntityTypeConfiguration<Devolution>
    {
        public DevolutionMapping()
        {
            ToTable("Devolution");

            HasKey(x => x.Id);

            Property(x => x.DevolutionCode).IsRequired().HasMaxLength(100);

            Property(x => x.Status).IsRequired();
            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");

            HasRequired(x => x.Loan).WithMany(x => x.Devolutions).HasForeignKey(x => x.LoanId);
        }
    }
}
