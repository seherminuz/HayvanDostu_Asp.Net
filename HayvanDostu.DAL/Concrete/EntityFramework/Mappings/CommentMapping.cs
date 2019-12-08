using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.Mappings
{
    class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            Property(a => a.CommentDetail).HasMaxLength(500);
        }
    }
}
