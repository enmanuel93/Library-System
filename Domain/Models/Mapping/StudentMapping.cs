using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Mapping
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            ToTable("Student");
            HasKey(x => x.Id);

            Property(x => x.StudentCode).IsRequired().HasMaxLength(100);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.Address).IsRequired().HasMaxLength(100);
            Property(x => x.Phone).IsRequired().HasMaxLength(100);
            Property(x => x.Status).IsRequired();

            Property(x => x.Deleted).HasColumnType("bit");
            Property(x => x.CreationDate).HasColumnType("datetimeoffset");
            Property(x => x.ModificationDate).HasColumnType("datetimeoffset");
        }
    }
}
