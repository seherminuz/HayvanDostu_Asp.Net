using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class PetMapping : EntityTypeConfiguration<Pet>
    {
        public PetMapping()
        {
            Property(a => a.Name).HasMaxLength(50);
            Property(a => a.Story).HasMaxLength(250);
            Property(a => a.PetType).HasMaxLength(50);
            
    }
    }
}
