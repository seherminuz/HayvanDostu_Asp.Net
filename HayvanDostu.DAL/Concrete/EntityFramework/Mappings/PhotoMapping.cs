using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class PhotoMapping : EntityTypeConfiguration<Photo>
    {
        public PhotoMapping()
        {
            Property(a => a.PhotoPath).HasMaxLength(250);

        }
    }
}
