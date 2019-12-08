using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class CorporateMapping : EntityTypeConfiguration<Corporate>
    {
        public CorporateMapping()
        {
            Property(a => a.Username).HasMaxLength(20);
            Property(a => a.EMail).HasMaxLength(255);
            Property(a => a.Password).HasColumnType("char").HasMaxLength(8);
            Property(a => a.Phone).HasColumnType("char").HasMaxLength(11);
            Property(a => a.Address).HasMaxLength(255);
            Property(a => a.ImagePath1).HasMaxLength(255);


            Property(a => a.CompanyName).HasMaxLength(50);


        }
    }
}
