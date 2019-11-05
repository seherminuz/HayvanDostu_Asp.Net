using HayvanDostu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class Message :BaseEntity
    {
        public int MessageDetails { get; set; }
        public int PersonalID { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
