using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class UserMapping : EntityTypeConfiguration<Users>
    {
        public UserMapping()
        {
            ToTable("Users");

            HasKey(x => x.Id);

            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.UserName).IsRequired().HasMaxLength(100);
            Property(x => x.Password).IsRequired().HasMaxLength(100);

            Property(x => x.Status).IsRequired();
            Property(x => x.Rol).HasColumnType("bit");
            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");
        }
    }
}
