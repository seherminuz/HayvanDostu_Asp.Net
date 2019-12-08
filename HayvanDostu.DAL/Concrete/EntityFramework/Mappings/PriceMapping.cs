using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class PriceMapping: EntityTypeConfiguration<Price>
    {
        public PriceMapping()
        {
            Property(a => a.CartNo).HasColumnType("char").HasMaxLength(16);
            Property(a => a.SecurityCode).HasColumnType("char").HasMaxLength(3);
            Property(a => a.CardOwner).HasMaxLength(50);
            Property(a => a.PaymentMethod).HasMaxLength(15);
            
        }
    }
}
