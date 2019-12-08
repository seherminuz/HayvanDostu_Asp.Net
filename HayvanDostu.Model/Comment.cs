using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Comment : BaseEntity
    {
        public string CommentDetail { get; set; }
        public int CorporateID { get; set; }
        public int PersonalID { get; set; }
        public int VetID { get; set; }

        public virtual Personal Personal { get; set; }

        public virtual Veterinary Veterinary { get; set; }

        public virtual Corporate Corporate { get; set; }

    }
}
