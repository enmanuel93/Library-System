using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class AuthorMapping : EntityTypeConfiguration<Author>
    {
        public AuthorMapping()
        {
            ToTable("Author");
            HasKey(x => x.Id);

            Property(x => x.AuthorCode).IsRequired().HasMaxLength(100);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.Nationality).IsRequired().HasMaxLength(100);

            Property(x => x.Status).IsRequired();
            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");
        }
    }
}
