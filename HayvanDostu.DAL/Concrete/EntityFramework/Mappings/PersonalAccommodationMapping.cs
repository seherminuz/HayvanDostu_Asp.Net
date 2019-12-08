using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class PersonalAccommodationMapping : EntityTypeConfiguration<PersonalAccommodation>
    {
        public PersonalAccommodationMapping()
        {
            Property(a => a.Job).HasMaxLength(30);
            Property(a => a.CarePets).HasMaxLength(30);
        }
    }
}
