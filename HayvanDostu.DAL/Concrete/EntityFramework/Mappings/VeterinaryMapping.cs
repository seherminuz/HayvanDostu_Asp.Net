using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class VeterinaryMapping : EntityTypeConfiguration<Veterinary>
    {
        public VeterinaryMapping()
        {
            Property(a => a.FirstName).HasMaxLength(20);
            Property(a => a.LastName).HasMaxLength(20);
            Property(a => a.ImagePath).HasMaxLength(255);
            Property(a => a.GraduationUniversity).HasMaxLength(255);
            Property(a => a.Experience).HasMaxLength(255);
        }
    }
}
